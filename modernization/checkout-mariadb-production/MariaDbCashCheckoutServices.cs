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
            string workstation, Func<string> readAuthenticatedCashierPin)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            return new AuthorizedCheckoutMariaDbPort(
                () => LocalConnection(connections),
                new MariaDbCashCheckoutPreparation(workstation, readAuthenticatedCashierPin));
        }

        public static ICheckoutOperationJournal CreateOperationJournal(Func<MySqlConnection> connections)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            return new Journal(() => LocalConnection(connections));
        }

        // Reauthorization for an explicit reviewed UI reset. This grants no
        // stock permission and performs no financial/basket/journal mutation.
        // Posting STILL independently authenticates inside its own transaction.
        public static void VerifyCashierSession(Func<MySqlConnection> connections,
            string cashierId, Func<string> transientPinProvider)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            if (transientPinProvider == null) throw new ArgumentNullException(nameof(transientPinProvider));
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
            IReadOnlyList<CheckoutBatchLine> lines)
        {
            if (connections == null) throw new ArgumentNullException(nameof(connections));
            if (lines == null) throw new ArgumentNullException(nameof(lines));
            var snapshot = Array.AsReadOnly(lines.ToArray());
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
                    decimal total = MariaDbCashCheckoutPreparation.ReadCashSaleTotal(snapshot, connection, transaction);
                    transaction.Commit();
                    return total;
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
