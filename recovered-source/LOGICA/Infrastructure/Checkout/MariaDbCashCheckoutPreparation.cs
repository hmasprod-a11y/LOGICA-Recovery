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
    // Returns/discounts/tier prices/change remain on the characterized legacy
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
            if (request.IsReturn || request.Currency != "MAD" || request.Payments.Count != 1 ||
                request.Payments[0].Kind != CheckoutPaymentKind.Cash || request.OperationId.Length > 64)
                throw new NotSupportedException("Only exact-cash MAD sales are accepted by this preparation.");

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

            string pin = readPin();
            if (string.IsNullOrWhiteSpace(pin) || pin.Length > 256)
                throw new UnauthorizedAccessException("Cashier authentication failed.");
            var users = Read(connection, transaction,
                "SELECT ListUser, Catégorie FROM TABLE_PASS WHERE BINARY ListPass=BINARY @pin AND BINARY ListUser=BINARY @cashier FOR UPDATE",
                ("@pin", pin.Trim()), ("@cashier", request.CashierId));
            pin = null; // Never retain or log a credential in the posting input.
            if (users.Rows.Count != 1 ||
                Convert.ToString(users.Rows[0]["ListUser"]) != request.CashierId ||
                !new[] { "ADMIN", "MANAGER", "UTILISATEUR" }.Contains(Convert.ToString(users.Rows[0]["Catégorie"])))
                throw new UnauthorizedAccessException("Cashier authentication failed.");
            string cashier = Convert.ToString(users.Rows[0]["ListUser"]);

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
            foreach (var line in request.Lines)
            {
                var authoritative = Read(connection, transaction,
                    "SELECT * FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE",
                    ("@id", line.ArticleId));
                if (authoritative.Rows.Count != 1)
                    throw new InvalidOperationException("Requested article is unavailable.");
                var article = authoritative.Rows[0];
                if (OptionalNumber(article, "PROMOTION") != 0m ||
                    OptionalNumber(article, "PRIX_QTE") != 0m)
                    throw new NotSupportedException("Promotions and tier pricing require V1 parity.");
                decimal unit = Number(article, "PRIX_V_1");
                decimal net = Math.Round(
                    SalesLinePricing.CalculateNetAmount(unit, line.Quantity, 0m),
                    2, MidpointRounding.ToEven);
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
                "SELECT ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,Qté,Remise,TOTAL_NET,TAUX_TVA,GROUPE FROM TABLE_" +
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
                    Number(row, "Qté") != quantity)
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
                decimal net = Math.Round(SalesLinePricing.CalculateNetAmount(price, quantity, 0m), 2, MidpointRounding.ToEven);
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
            if (total <= 0m || request.ExpectedTotal != total || request.Payments[0].Amount != total)
                throw new InvalidOperationException("Cash tender and expected total must match the authoritative basket exactly.");

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
                ReadPayments = () => new[] { new TicketPaymentWrite {
                    Kind = TicketPaymentKind.Cash, Context = paymentContext, AmountText = amount } },
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
                        payments.Rows.Count != 1 || Number(payments.Rows[0], "MONTANT") != total ||
                        detail.Rows.Count != stock.Count)
                        throw new InvalidOperationException("Persisted receipt staging failed.");
                },
                ReadCompletion = () => new CheckoutCompletionRecord { Workstation = workstation, TicketNumber = ticket }
            };
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
