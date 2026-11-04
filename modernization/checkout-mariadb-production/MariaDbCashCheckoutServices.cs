using System;
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
