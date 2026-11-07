using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using Hanouty.ArchitectureBridge;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    // First production cash slice: authenticates the existing local PIN store,
    // validates an existing workstation basket against locked authoritative rows,
    // and reuses the established posting writers. No schema mutation or default
    // credential, no UI price, no privilege inferred from a supplied UserId.
    // Returns/discounts/tier prices remain on the characterized legacy
    // path until their complete monetary policy is accepted for this new port.
    internal sealed class MariaDbCashCheckoutPreparation : ITrustedCheckoutPostingPreparation
    {
        private readonly string workstation;
        private readonly Func<string> readPin;

        internal MariaDbCashCheckoutPreparation(string workstation, Func<string> readPin)
        {
            if (workstation == null || workstation.Length != 2 ||
                workstation.Any(c => c < '0' || c > '9'))
                throw new ArgumentException("An explicit two-digit workstation is required.", nameof(workstation));
            this.workstation = workstation;
            this.readPin = readPin ?? throw new ArgumentNullException(nameof(readPin));
        }

        public CheckoutPostingInput Prepare(AuthorizedCheckoutRequest request,
            MySqlConnection connection, MySqlTransaction transaction)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            request.Validate();
            // Freeze the envelope even when called without the outer gate.
            request = request with { Lines = request.Lines.ToArray(), Payments = request.Payments.ToArray() };
            request.Validate();
            if (connection == null || connection.State != ConnectionState.Open ||
                transaction == null || !ReferenceEquals(transaction.Connection, connection))
                throw new InvalidOperationException("Trusted preparation requires the active checkout transaction.");
            if (request.Currency != "MAD" || request.Payments.Count != 1 ||
                request.Payments[0].Kind != CheckoutPaymentKind.Cash || request.OperationId.Length > 64)
                throw new NotSupportedException("Only single-tender cash MAD sales are accepted by this preparation.");

            // Refuse nontransactional legacy tables instead of silently claiming
            // that stock, receipt and operation rollback is atomic.
            foreach (var table in new[] { "TABLE_PASS", "TABLE_NUM", "TABLE_ARTICLES",
                "TABLE_MOUVEMENTS_STOCK", "TABLE_" + workstation, "TABLE_VENTES_ENTETE",
                "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS", "hanouty_checkout_operations" })
            {
                var engines = Read(connection, transaction,
                    "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table",
                    ("@table", table));
                if (engines.Rows.Count != 1 || Convert.ToString(engines.Rows[0][0]) != "InnoDB")
                    throw new InvalidOperationException("Cash posting requires existing transactional tables.");
            }

            string cashier = AuthenticateCashier(request.CashierId, connection, transaction, readPin);

            // Lock the same original sequence and basket used by the writers.
            // Reject an unsupported sequence layout rather than advance other counters.
            var sequence = Read(connection, transaction, "SELECT ID, CL FROM TABLE_NUM FOR UPDATE");
            if (sequence.Rows.Count != 1 || Number(sequence.Rows[0], "ID") != 0m)
                throw new InvalidOperationException("Unsupported ticket sequence layout.");
            decimal next = Number(sequence.Rows[0], "CL");
            if (next < 0 || next != decimal.Truncate(next) || next >= 999999)
                throw new InvalidOperationException("Invalid ticket sequence.");
            string ticket = next.ToString("000000", CultureInfo.InvariantCulture);
            // W2 bridge: a request from the in-memory checkout session must not
            // depend on an independently preseeded V1 workstation basket.
            // The TABLE_NUM row above serializes participating checkouts; refuse
            // any existing workstation rows rather than deleting another cashier's
            // work. Completion may clear only rows created in this transaction.
            var occupied = Read(connection, transaction,
                "SELECT ID_ARTICLE FROM TABLE_" + workstation + " FOR UPDATE");
            if (occupied.Rows.Count != 0)
                throw new InvalidOperationException(
                    "Workstation basket is occupied; refusing to replace another cashier's sale.");
            if (request.IsReturn)
                return PrepareFullCashReturn(request, connection, transaction, cashier, ticket);
            foreach (var line in request.Lines)
            {
                var authoritative = Read(connection, transaction,
                    "SELECT * FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE",
                    ("@id", line.ArticleId));
                if (authoritative.Rows.Count != 1)
                    throw new InvalidOperationException("Requested article is unavailable.");
                var article = authoritative.Rows[0];
                decimal unit = Number(article, "PRIX_V_1");
                decimal net = StandardCashLineTotal(article, line.Quantity);
                using (var write = connection.CreateCommand())
                {
                    write.Transaction = transaction;
                    write.CommandText = "INSERT INTO TABLE_" + workstation +
                        " (ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,Qté,Remise,TOTAL_NET,TAUX_TVA,GROUPE)" +
                        " VALUES (@id,@code,@article,@family,@cost,@mean,@price,@quantity,0,@net,@tax,@group)";
                    write.Parameters.AddWithValue("@id", line.ArticleId);
                    write.Parameters.AddWithValue("@code", article["Code"]);
                    write.Parameters.AddWithValue("@article", article["Article"]);
                    write.Parameters.AddWithValue("@family", article["Famille"]);
                    write.Parameters.AddWithValue("@cost", article["PRIX_A"]);
                    write.Parameters.AddWithValue("@mean", article["PRIX_MP"]);
                    write.Parameters.AddWithValue("@price", unit);
                    write.Parameters.AddWithValue("@quantity", line.Quantity);
                    write.Parameters.AddWithValue("@net", net);
                    write.Parameters.AddWithValue("@tax", article["TAUX_TVA"]);
                    write.Parameters.AddWithValue("@group", article["GROUPE"]);
                    if (write.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("Unable to stage authoritative basket line.");
                }
            }
            var basket = Read(connection, transaction,
                "SELECT ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,Qté AS trusted_quantity,Remise,TOTAL_NET,TAUX_TVA,GROUPE FROM TABLE_" +
                workstation + " ORDER BY ID_ARTICLE FOR UPDATE");
            if (basket.Rows.Count != request.Lines.Count)
                throw new InvalidOperationException("Authoritative basket changed.");
            var requested = request.Lines.ToDictionary(x => x.ArticleId, x => x.Quantity, StringComparer.Ordinal);
            var seen = new HashSet<string>(StringComparer.Ordinal);
            var stock = new List<CheckoutStockLine>();
            decimal total = 0m;
            foreach (DataRow row in basket.Rows)
            {
                string id = Convert.ToString(row["ID_ARTICLE"], CultureInfo.InvariantCulture);
                if (string.IsNullOrWhiteSpace(id) || !seen.Add(id) || !requested.TryGetValue(id, out var quantity) ||
                    Number(row, "trusted_quantity") != quantity)
                    throw new InvalidOperationException("Authoritative basket identity or quantity changed.");
                var articles = Read(connection, transaction,
                    "SELECT * FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE", ("@id", id));
                if (articles.Rows.Count != 1)
                    throw new InvalidOperationException("Article identity is no longer unique.");
                var article = articles.Rows[0];
                if (OptionalNumber(article, "PROMOTION") != 0m || OptionalNumber(article, "PRIX_QTE") != 0m ||
                    Number(row, "Remise") != 0m)
                    throw new NotSupportedException("Promotion, tier-price and manual-discount policy is not yet accepted for this cash slice.");
                decimal price = Number(article, "PRIX_V_1");
                if (price < 0m || Number(row, "PRIX_V") != price ||
                    Number(row, "TAUX_TVA") != Number(article, "TAUX_TVA"))
                    throw new InvalidOperationException("Authoritative article price or tax changed.");
                // The existing domain rule supplies the decimal operation order.
                // The standard legacy basket stores each line to two decimals.
                decimal net = StandardCashLineTotal(article, quantity);
                if (Number(row, "TOTAL_NET") != net)
                    throw new InvalidOperationException("Authoritative line total changed.");
                foreach (var field in new[] { "Code", "Article", "Famille", "GROUPE" })
                    if (!Equals(Convert.ToString(row[field]), Convert.ToString(article[field])))
                        throw new InvalidOperationException("Authoritative article details changed.");
                if (Number(row, "PRIX_A") != Number(article, "PRIX_A") ||
                    Number(row, "PRIX_MP") != Number(article, "PRIX_MP"))
                    throw new InvalidOperationException("Authoritative article cost changed.");
                total = checked(total + net);
                stock.Add(new CheckoutStockLine { TicketNumber = ticket, ArticleId = id,
                    ArticleCode = row["Code"], ArticleName = row["Article"], BasketQuantity = (decimal)quantity });
            }
            decimal tendered = request.Payments[0].Amount;
            if (total <= 0m || request.ExpectedTotal != total || tendered < total ||
                decimal.Round(tendered, 2, MidpointRounding.AwayFromZero) != tendered)
                throw new InvalidOperationException("Cash tender must cover the authoritative total in whole cents.");
            // V1 FormDialog_calc: FLOUSS(total - paid), persisted as a negative
            // ESPECES change row. Never store both net cash and gross tender.
            decimal change = decimal.Round(checked(total - tendered), 2, MidpointRounding.AwayFromZero);

            var date = DateTime.Now;
            var idTicket = request.OperationId;
            var amount = total.ToString(CultureInfo.CurrentCulture);
            // This slice is an explicit anonymous cash sale. Named customer,
            // credit and alternate tender context must use their own accepted flow.
            var paymentContext = new TicketPaymentContext { TicketId = idTicket, TicketNumber = ticket,
                SaleDate = date, Cashier = cashier, ClientId = "0", ClientCode = "0", ClientName = "",
                Workstation = workstation, Operation = "VENTE", Remark = "" };
            return new CheckoutPostingInput
            {
                ReadStock = () => stock,
                ReadHeader = () => new TicketHeaderRecord { TicketId = idTicket, TicketNumber = ticket,
                    SaleDate = date, Cashier = cashier, ClientId = "0", ClientCode = "0", ClientName = "",
                    Workstation = workstation, TotalText = amount, Operation = "VENTE" },
                ReadJournal = () => new TicketJournalRecord { TicketId = idTicket, TicketNumber = ticket,
                    SaleDate = date, Cashier = cashier, Seller = "", ClientId = "0", ClientCode = "0", ClientName = "",
                    Workstation = workstation, Operation = "VENTE", PriceType = "PRIX 1", PaymentModes = "ESPECES" },
                ReadPayments = () => change == 0m
                    ? new[] { new TicketPaymentWrite {
                        Kind = TicketPaymentKind.Cash, Context = paymentContext, AmountText = amount } }
                    : new[] {
                        new TicketPaymentWrite { Kind = TicketPaymentKind.Tendered,
                            Context = paymentContext, Amount = tendered, Mode = "ESPECES" },
                        new TicketPaymentWrite { Kind = TicketPaymentKind.Change,
                            Context = paymentContext, AmountText = change.ToString(CultureInfo.CurrentCulture) }
                    },
                // Stage a verifiable persisted receipt within this transaction.
                // Physical printing is a separate post-commit/peripheral gate.
                Print = () => {
                    var receipt = Read(connection, transaction,
                        "SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET=@id", ("@id", idTicket));
                    var payments = Read(connection, transaction,
                        "SELECT MONTANT FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET=@id", ("@id", idTicket));
                    var detail = Read(connection, transaction,
                        "SELECT ID_ARTICLE FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET=@id", ("@id", idTicket));
                    if (receipt.Rows.Count != 1 || Number(receipt.Rows[0], "Total_NET") != total ||
                        payments.Rows.Count != (change == 0m ? 1 : 2) ||
                        payments.Rows.Cast<DataRow>().Sum(row => Number(row, "MONTANT")) != total ||
                        (change < 0m && (!payments.Rows.Cast<DataRow>().Any(row => Number(row, "MONTANT") == tendered) ||
                            !payments.Rows.Cast<DataRow>().Any(row => Number(row, "MONTANT") == change))) ||
                        detail.Rows.Count != stock.Count)
                        throw new InvalidOperationException("Persisted receipt staging failed.");
                },
                ReadCompletion = () => new CheckoutCompletionRecord { Workstation = workstation, TicketNumber = ticket }
            };
        }

        // One-line, full-ticket, exact-cash V1 refund. This runs inside the
        // SAME operation-claim transaction and posting writers as a cash sale.
        // Original journal values, never current prices or UI amounts, are authoritative.
        private CheckoutPostingInput PrepareFullCashReturn(AuthorizedCheckoutRequest request,
            MySqlConnection connection, MySqlTransaction transaction, string cashier, string ticket)
        {
            if (request.Lines.Count != 1 || string.IsNullOrWhiteSpace(request.OriginalTicketId))
                throw new NotSupportedException("Only one-line full-ticket cash returns are enabled.");
            var line = request.Lines[0];
            decimal amount = CashReturnConsumptionClaim.VerifyAndClaimFullOriginal(
                connection, transaction, request.OriginalTicketId, request.OperationId,
                line.ArticleId, line.Quantity);
            if (request.ExpectedTotal != amount || request.Payments[0].Amount != amount)
                throw new InvalidOperationException("Refund must equal the persisted original exact-cash settlement.");
            // Require the original article to remain uniquely addressable for stock restoration.
            var article = Read(connection, transaction,
                "SELECT ID_ARTICLE FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE",
                ("@id", line.ArticleId));
            if (article.Rows.Count != 1)
                throw new InvalidOperationException("Original return article is no longer uniquely stocked.");
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText = "INSERT INTO TABLE_" + workstation +
                    " (ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,Qté,Remise,TOTAL_NET,TAUX_TVA,GROUPE) " +
                    "SELECT ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,-Qté,Remise,-Total_NET,TAUX_TVA,GROUPE " +
                    "FROM TABLE_VENTES_JOURNAL WHERE BINARY ID_TICKET=BINARY @original AND BINARY ID_ARTICLE=BINARY @article " +
                    "AND BINARY OPERATION=BINARY 'VENTE' AND Qté=@quantity AND Total_NET=@amount";
                command.Parameters.AddWithValue("@original", request.OriginalTicketId);
                command.Parameters.AddWithValue("@article", line.ArticleId);
                command.Parameters.AddWithValue("@quantity", line.Quantity);
                command.Parameters.AddWithValue("@amount", amount);
                if (command.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("Could not stage the signed original return line.");
            }
            var staged = Read(connection, transaction,
                "SELECT ID_ARTICLE,Code,Article,Qté,TOTAL_NET FROM TABLE_" + workstation + " FOR UPDATE");
            // The signed staging table is shared with the workstation; verify the
            // persisted identity as well as the amount before stock is restored.
            if (staged.Rows.Count != 1 ||
                !String.Equals(Convert.ToString(staged.Rows[0]["ID_ARTICLE"], CultureInfo.InvariantCulture),
                    line.ArticleId, StringComparison.Ordinal) ||
                Number(staged.Rows[0], "Qté") != -line.Quantity ||
                Number(staged.Rows[0], "TOTAL_NET") != -amount)
                throw new InvalidOperationException("Signed return staging differs from the original sale.");
            var date = DateTime.Now;
            string id = request.OperationId;
            string negativeAmount = (-amount).ToString(CultureInfo.CurrentCulture);
            var context = new TicketPaymentContext { TicketId = id, TicketNumber = ticket,
                SaleDate = date, Cashier = cashier, ClientId = "0", ClientCode = "0", ClientName = "",
                Workstation = workstation, Operation = "RETOUR REMBOURSEMENT", Remark = request.OriginalTicketId };
            return new CheckoutPostingInput
            {
                ReadStock = () => new[] { new CheckoutStockLine { TicketNumber = ticket,
                    ArticleId = line.ArticleId, ArticleCode = staged.Rows[0]["Code"],
                    ArticleName = staged.Rows[0]["Article"], BasketQuantity = -line.Quantity } },
                ReadHeader = () => new TicketHeaderRecord { TicketId = id, TicketNumber = ticket,
                    SaleDate = date, Cashier = cashier, ClientId = "0", ClientCode = "0", ClientName = "",
                    Workstation = workstation, TotalText = negativeAmount, Operation = "RETOUR REMBOURSEMENT" },
                ReadJournal = () => new TicketJournalRecord { TicketId = id, TicketNumber = ticket,
                    SaleDate = date, Cashier = cashier, Seller = "", ClientId = "0", ClientCode = "0",
                    ClientName = "", Workstation = workstation, Operation = "RETOUR REMBOURSEMENT",
                    PriceType = "PRIX 1", PaymentModes = "ESPECES" },
                ReadPayments = () => new[] { new TicketPaymentWrite { Kind = TicketPaymentKind.Cash,
                    Context = context, AmountText = negativeAmount } },
                Print = () => {
                    var receipt = Read(connection, transaction,
                        "SELECT Total_NET,OPERATION FROM TABLE_VENTES_ENTETE WHERE BINARY ID_TICKET=BINARY @id", ("@id", id));
                    var payment = Read(connection, transaction,
                        "SELECT MONTANT,OPERATION FROM TABLE_VENTES_REGLEMENTS WHERE BINARY ID_TICKET=BINARY @id", ("@id", id));
                    var detail = Read(connection, transaction,
                        "SELECT Qté,Total_NET,OPERATION FROM TABLE_VENTES_JOURNAL WHERE BINARY ID_TICKET=BINARY @id", ("@id", id));
                    if (receipt.Rows.Count != 1 || payment.Rows.Count != 1 || detail.Rows.Count != 1 ||
                        Number(receipt.Rows[0], "Total_NET") != -amount ||
                        Number(payment.Rows[0], "MONTANT") != -amount ||
                        Number(detail.Rows[0], "Qté") != -line.Quantity ||
                        Number(detail.Rows[0], "Total_NET") != -amount ||
                        Convert.ToString(receipt.Rows[0]["OPERATION"]) != "RETOUR REMBOURSEMENT" ||
                        Convert.ToString(payment.Rows[0]["OPERATION"]) != "RETOUR REMBOURSEMENT" ||
                        Convert.ToString(detail.Rows[0]["OPERATION"]) != "RETOUR REMBOURSEMENT")
                        throw new InvalidOperationException("Signed refund receipt, payment or journal failed verification.");
                },
                ReadCompletion = () => new CheckoutCompletionRecord { Workstation = workstation, TicketNumber = ticket }
            };
        }

        // Shared by posting preparation and explicit cashier reauthorization.
        // A caller-owned transaction and real TABLE_PASS remain authoritative.
        internal static string AuthenticateCashier(string cashierId,
            MySqlConnection connection, MySqlTransaction transaction, Func<string> readPin)
        {
            if (string.IsNullOrWhiteSpace(cashierId) || readPin == null)
                throw new UnauthorizedAccessException("Cashier authentication failed.");
            string pin = readPin();
            if (string.IsNullOrWhiteSpace(pin) || pin.Length > 256)
                throw new UnauthorizedAccessException("Cashier authentication failed.");
            var users = Read(connection, transaction,
                "SELECT ListUser AS trusted_cashier, Catégorie AS trusted_role FROM TABLE_PASS WHERE BINARY ListPass=BINARY @pin AND BINARY ListUser=BINARY @cashier FOR UPDATE",
                ("@pin", pin.Trim()), ("@cashier", cashierId));
            pin = null; // Never retain or log a credential in the posting input.
            if (users.Rows.Count != 1 ||
                Convert.ToString(users.Rows[0]["trusted_cashier"]) != cashierId ||
                !new[] { "ADMIN", "MANAGER", "UTILISATEUR" }.Contains(Convert.ToString(users.Rows[0]["trusted_role"])))
                throw new UnauthorizedAccessException("Cashier authentication failed.");
            return Convert.ToString(users.Rows[0]["trusted_cashier"]);

        }

        // The price preview and actual staging share THIS policy and operation
        // order. Preview never stages/claims/posts and is revalidated at Commit.
        internal static decimal ReadCashSaleTotal(IReadOnlyList<CheckoutBatchLine> lines,
            MySqlConnection connection, MySqlTransaction transaction)
        {
            if (lines == null || lines.Any(x => x == null ||
                string.IsNullOrWhiteSpace(x.ArticleId) || x.Quantity <= 0) ||
                lines.GroupBy(x => x.ArticleId, StringComparer.OrdinalIgnoreCase).Any(g => g.Count() > 1))
                throw new InvalidOperationException("Valid aggregated checkout lines are required for price preview.");
            decimal total = 0m;
            foreach (var line in lines)
            {
                var article = Read(connection, transaction,
                    "SELECT * FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE",
                    ("@id", line.ArticleId));
                if (article.Rows.Count != 1)
                    throw new InvalidOperationException("Requested article is unavailable.");
                total = checked(total + StandardCashLineTotal(article.Rows[0], line.Quantity));
            }
            return total;
        }

        private static decimal StandardCashLineTotal(DataRow article, int quantity)
        {
            if (OptionalNumber(article, "PROMOTION") != 0m ||
                OptionalNumber(article, "PRIX_QTE") != 0m)
                throw new NotSupportedException("Promotions and tier pricing require V1 parity.");
            decimal unit = Number(article, "PRIX_V_1");
            if (unit < 0m || quantity <= 0)
                throw new InvalidOperationException("Authoritative price or quantity is invalid.");
            return Math.Round(SalesLinePricing.CalculateNetAmount(unit, quantity, 0m),
                2, MidpointRounding.ToEven);
        }

        private static decimal Number(DataRow row, string column)
        {
            if (!row.Table.Columns.Contains(column) || row.IsNull(column))
                throw new InvalidOperationException("Required authoritative numeric field is unavailable.");
            return Convert.ToDecimal(row[column], CultureInfo.CurrentCulture);
        }
        private static decimal OptionalNumber(DataRow row, string column) =>
            !row.Table.Columns.Contains(column) || row.IsNull(column) ? 0m : Number(row, column);

        private static DataTable Read(MySqlConnection connection, MySqlTransaction transaction,
            string sql, params (string Name, object Value)[] parameters)
        {
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText = sql;
                foreach (var parameter in parameters) command.Parameters.AddWithValue(parameter.Name, parameter.Value);
                using (var reader = command.ExecuteReader())
                {
                    var result = new DataTable();
                    result.Load(reader);
                    return result;
                }
            }
        }
    }
}
