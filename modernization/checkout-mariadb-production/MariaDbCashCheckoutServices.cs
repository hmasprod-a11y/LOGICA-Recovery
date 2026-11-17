using System;
using System.Collections.Generic;
using System.Linq;
using Hanouty.ArchitectureBridge;
using LOGICA.Infrastructure.Checkout;
using MySql.Data.MySqlClient;

namespace Hanouty.Checkout.MariaDb
{
    // Production composition factory for the EXISTING Architecture ports.
    // No default credential, fake posting, schema initialization or UI dependency.
    public static class MariaDbCashCheckoutServices
    {
        public static IAuthorizedCheckoutPort CreatePostingPort(Func<MySqlConnection> connections,
            string workstation, Func<string> readAuthenticatedCashierPin, Func<string?>? readWaitingSale = null)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            return new AuthorizedCheckoutMariaDbPort(
                () => LocalConnection(connections),
                new MariaDbCashCheckoutPreparation(workstation, readAuthenticatedCashierPin, readWaitingSale));
        }

        public static ICheckoutOperationJournal CreateOperationJournal(Func<MySqlConnection> connections)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            return new Journal(() => LocalConnection(connections));
        }


        public sealed record PersistedCashSaleCandidate(string SaleId, decimal PaidMad);

        // Exact-ID lookup for UI display. Only persisted, complete, exact-cash
        // V1 sales with no existing return claim are exposed; this is read-only.
        public static IReadOnlyList<PersistedCashSaleCandidate> FindFullCashReturnCandidates(
            Func<MySqlConnection> connections, string receiptId)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            if (string.IsNullOrWhiteSpace(receiptId) || receiptId.Length > 64 ||
                !string.Equals(receiptId, receiptId.Trim(), StringComparison.Ordinal) ||
                receiptId.Any(char.IsControl))
                return Array.Empty<PersistedCashSaleCandidate>();
            using (var connection = LocalConnection(connections))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    RequireInnoDb(connection, transaction, "TABLE_VENTES_ENTETE");
                    RequireInnoDb(connection, transaction, "TABLE_VENTES_JOURNAL");
                    RequireInnoDb(connection, transaction, "TABLE_VENTES_REGLEMENTS");
                    RequireInnoDb(connection, transaction, "hanouty_cash_return_consumption");
                    var result = new List<PersistedCashSaleCandidate>();
                    string saleId = null;
                    using (var command = new MySqlCommand(
                        "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE " +
                        "WHERE BINARY ID_TICKET=BINARY @ticket AND BINARY OPERATION=BINARY 'VENTE' LIMIT 2",
                        connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ticket", receiptId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                                saleId = Convert.ToString(reader.GetValue(0));
                            if (reader.Read())
                                throw new InvalidOperationException("Original ticket identity is ambiguous.");
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(saleId))
                    {
                        // A consumed ticket is not a candidate, even if legacy
                        // journal/payment rows were subsequently damaged.
                        // Check the durable claim before interpreting evidence.
                        using (var claim = new MySqlCommand(
                            "SELECT COUNT(*) FROM hanouty_cash_return_consumption " +
                            "WHERE BINARY original_ticket_id=BINARY @ticket", connection, transaction))
                        {
                            claim.Parameters.AddWithValue("@ticket", saleId);
                            if (Convert.ToInt64(claim.ExecuteScalar()) == 0)
                            {
                                var lines = CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLines(
                                    connection, transaction, saleId);
                                // A ticket that cannot fit the whole-unit WPF return
                                // contract must not be offered as returnable.
                                if (lines.Any(line => line.Quantity <= 0 ||
                        string.IsNullOrWhiteSpace(line.ArticleId)) ||
                        lines.Select(line => line.ArticleId).Distinct(StringComparer.Ordinal).Count() != lines.Count)
                        throw new InvalidOperationException("Original sale has invalid or duplicate return lines.");
                    if (lines.Any(line => line.Quantity != decimal.Truncate(line.Quantity) ||
                                    line.Quantity < int.MinValue || line.Quantity > int.MaxValue))
                                    throw new InvalidOperationException(
                                        "Original sale quantity cannot be represented by the checkout return contract.");
                                result.Add(new PersistedCashSaleCandidate(saleId,
                                    lines.Sum(line => line.Amount)));
                            }
                        }
                    }
                    transaction.Commit();
                    return result.AsReadOnly();
                }
            }
        }

        // Build a request from locked persisted journal/payment evidence. This
        // method is read-only; the posting port repeats all validation and
        // consumes the original ticket in the one InnoDB posting transaction.
        public static AuthorizedCheckoutRequest PrepareFullCashReturnRequest(
            Func<MySqlConnection> connections, string operationId, string cashierId,
            string currency, string originalTicketId)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            if (string.IsNullOrWhiteSpace(operationId) || operationId.Length > 64 ||
                !string.Equals(operationId, operationId.Trim(), StringComparison.Ordinal) ||
                operationId.Any(char.IsControl) ||
                string.IsNullOrWhiteSpace(cashierId) || cashierId.Length > 64 ||
                !string.Equals(cashierId, cashierId.Trim(), StringComparison.Ordinal) ||
                cashierId.Any(char.IsControl) ||
                string.IsNullOrWhiteSpace(originalTicketId) || originalTicketId.Length > 64 ||
                !string.Equals(originalTicketId, originalTicketId.Trim(), StringComparison.Ordinal) ||
                originalTicketId.Any(char.IsControl) ||
                string.Equals(operationId, originalTicketId, StringComparison.Ordinal) ||
                !string.Equals(currency, "MAD", StringComparison.Ordinal))
                throw new ArgumentException("A stable operation, authenticated cashier, MAD currency, and original ticket are required.");
            using (var connection = LocalConnection(connections))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    RequireInnoDb(connection, transaction, "TABLE_VENTES_ENTETE");
                    RequireInnoDb(connection, transaction, "TABLE_VENTES_JOURNAL");
                    RequireInnoDb(connection, transaction, "TABLE_VENTES_REGLEMENTS");
                    RequireInnoDb(connection, transaction, "hanouty_cash_return_consumption");
                    using (var header = new MySqlCommand(
                        "SELECT ID_TICKET FROM TABLE_VENTES_ENTETE " +
                        "WHERE BINARY ID_TICKET=BINARY @ticket AND BINARY OPERATION=BINARY 'VENTE' LIMIT 2 FOR UPDATE",
                        connection, transaction))
                    {
                        header.Parameters.AddWithValue("@ticket", originalTicketId);
                        using (var reader = header.ExecuteReader())
                        {
                            if (!reader.Read() || reader.IsDBNull(0))
                                throw new InvalidOperationException("Persisted original cash sale was not found.");
                            if (reader.Read())
                                throw new InvalidOperationException("Original cash ticket identity is ambiguous.");
                        }
                    }
                    using (var claim = new MySqlCommand(
                        "SELECT COUNT(*) FROM hanouty_cash_return_consumption " +
                        "WHERE BINARY original_ticket_id=BINARY @ticket", connection, transaction))
                    {
                        claim.Parameters.AddWithValue("@ticket", originalTicketId);
                        if (Convert.ToInt64(claim.ExecuteScalar()) != 0)
                            throw new InvalidOperationException("Original cash ticket was already returned.");
                    }
                    var lines = CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLines(
                        connection, transaction, originalTicketId);
                    // CheckoutBatchLine is the existing whole-unit contract. Never
                    // round or truncate a persisted fractional sale during refund.
                    if (lines.Any(line => line.Quantity <= 0 ||
                        string.IsNullOrWhiteSpace(line.ArticleId)) ||
                        lines.Select(line => line.ArticleId).Distinct(StringComparer.Ordinal).Count() != lines.Count)
                        throw new InvalidOperationException("Original sale has invalid or duplicate return lines.");
                    if (lines.Any(line => line.Quantity != decimal.Truncate(line.Quantity) ||
                        line.Quantity < int.MinValue || line.Quantity > int.MaxValue))
                        throw new InvalidOperationException(
                            "Original sale quantity cannot be represented by the checkout return contract.");
                    var amount = lines.Sum(line => line.Amount);
                    var request = new AuthorizedCheckoutRequest(
                        operationId, cashierId, currency, true,
                        Array.AsReadOnly(lines.Select(line =>
                            new CheckoutBatchLine(line.ArticleId, checked((int)line.Quantity))).ToArray()),
                        Array.AsReadOnly(new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, amount) }),
                        amount, originalTicketId);
                    request.Validate();
                    transaction.Commit();
                    return request;
                }
            }
        }

        private static void RequireInnoDb(MySqlConnection connection,
            MySqlTransaction transaction, string table)
        {
            using (var command = new MySqlCommand(
                "SELECT ENGINE FROM information_schema.TABLES " +
                "WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table", connection, transaction))
            {
                command.Parameters.AddWithValue("@table", table);
                if (!string.Equals(Convert.ToString(command.ExecuteScalar()),
                    "InnoDB", StringComparison.Ordinal))
                    throw new InvalidOperationException("Full cash return requires existing InnoDB table " + table + ".");
            }
        }

        // Reauthorization for an explicit reviewed UI reset. This grants no
        // stock permission and performs no financial/basket/journal mutation.
        // Posting STILL independently authenticates inside its own transaction.
        public static void VerifyCashierSession(Func<MySqlConnection> connections,
            string cashierId, Func<string> transientPinProvider)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            if (transientPinProvider == null) throw new ArgumentNullException(nameof(transientPinProvider));
            // Fail closed before opening a connection or invoking the transient PIN.
            // A cashier session must never silently resolve a padded or oversized ID.
            if (string.IsNullOrWhiteSpace(cashierId) || cashierId.Length > 64 ||
                !string.Equals(cashierId, cashierId.Trim(), StringComparison.Ordinal) ||
                cashierId.Any(char.IsControl))
                throw new ArgumentException("A canonical authenticated cashier identity is required.", nameof(cashierId));
            using (var connection = LocalConnection(connections))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = new MySqlCommand(
                        "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='TABLE_PASS'",
                        connection, transaction))
                    {
                        if (!string.Equals(Convert.ToString(command.ExecuteScalar()), "InnoDB", StringComparison.Ordinal))
                            throw new InvalidOperationException("Cashier verification requires transactional credential storage.");
                    }
                    MariaDbCashCheckoutPreparation.AuthenticateCashier(
                        cashierId, connection, transaction, transientPinProvider);
                    transaction.Commit();
                }
            }
        }

        // Authoritative READ-ONLY standard-price MAD preview from the current
        // Application session lines. No UI prices, basket/claim/stock writes,
        // schema initialization or authorization grant. Commit revalidates SQL.
        public static decimal ReadCashSaleTotal(Func<MySqlConnection> connections,
            IReadOnlyList<CheckoutBatchLine> lines) =>
            ReadCashSaleBasket(connections, lines).Sum(line => line.Amount);

        public sealed record CashSaleBasketLine(string ArticleId, string ArticleName, int Quantity, decimal UnitPrice, decimal Amount);

        public static IReadOnlyList<CashSaleBasketLine> ReadCashSaleBasket(Func<MySqlConnection> connections,
            IReadOnlyList<CheckoutBatchLine> lines)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            if (lines == null) throw new ArgumentNullException(nameof(lines));
            // Reject malformed cashier basket input before touching MariaDB.
            // The commit gate independently revalidates current stock and prices.
            var snapshot = Array.AsReadOnly(lines.ToArray());
            // Never open MariaDB for an empty cashier basket. A zero-line
            // preview is not an authorized sale and must not look payable.
            if (snapshot.Count == 0)
                throw new ArgumentException("Basket must contain at least one article.", nameof(lines));
            if (snapshot.Any(line => line == null || string.IsNullOrWhiteSpace(line.ArticleId) ||
                line.ArticleId.Length > 64 ||
                !string.Equals(line.ArticleId, line.ArticleId.Trim(), StringComparison.Ordinal) ||
                line.ArticleId.Any(char.IsControl) ||
                line.Quantity <= 0))
                throw new ArgumentException("Basket requires canonical article identities and positive quantities.", nameof(lines));
            // A repeated live article identity is not a valid basket. Reject it
            // before opening MariaDB; the posting gate also validates it.
            var articleIds = new HashSet<string>(StringComparer.Ordinal);
            if (snapshot.Any(line => !articleIds.Add(line.ArticleId)))
                throw new ArgumentException("Basket contains duplicate article identities.", nameof(lines));
            using (var connection = LocalConnection(connections))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = new MySqlCommand(
                        "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='TABLE_ARTICLES'",
                        connection, transaction))
                    {
                        if (!string.Equals(Convert.ToString(command.ExecuteScalar()), "InnoDB", StringComparison.Ordinal))
                            throw new InvalidOperationException("Price preview requires transactional article storage.");
                    }
                    var basket = MariaDbCashCheckoutPreparation.ReadCashSaleLines(snapshot, connection, transaction);
                    transaction.Commit();
                    return basket.Select(line => new CashSaleBasketLine(line.ArticleId, line.ArticleName,
                        line.Quantity, line.UnitPrice, line.Amount)).ToArray();
                }
            }
        }

        private static MySqlConnection LocalConnection(Func<MySqlConnection> connections)
        {
            var connection = connections() ?? throw new InvalidOperationException("Local checkout connection is unavailable.");
            var settings = new MySqlConnectionStringBuilder(connection.ConnectionString);
            if ((settings.Server != "127.0.0.1" && settings.Server != "localhost" && settings.Server != "::1") ||
                string.IsNullOrWhiteSpace(settings.Database) || string.IsNullOrWhiteSpace(settings.UserID))
            {
                connection.Dispose();
                throw new InvalidOperationException("An explicitly configured local MariaDB account is required.");
            }
            return connection;
        }

        private sealed class Journal : ICheckoutOperationJournal
        {
            private readonly MySqlCheckoutOperationJournal journal;
            internal Journal(Func<MySqlConnection> connections) { journal = new MySqlCheckoutOperationJournal(connections); }
            public CheckoutOperationOutcome Lookup(string operationId)
            {
                try { return journal.IsPersisted(operationId) ? CheckoutOperationOutcome.Persisted : CheckoutOperationOutcome.Absent; }
                catch (MySqlException) { return CheckoutOperationOutcome.Unknown; }
                catch (InvalidOperationException) { return CheckoutOperationOutcome.Unknown; }
            }
        }
    }
}
