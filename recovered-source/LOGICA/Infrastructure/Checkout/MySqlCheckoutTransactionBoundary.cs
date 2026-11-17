using System.Data;
using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    // Binds the existing command to the transaction on the existing connection.
    // No new connection, isolation level, retry, disposal or rollback policy.
    internal sealed class MySqlCheckoutTransactionBoundary : ICheckoutTransactionBoundary, ICheckoutTransactionFinalizer
    {
        private readonly MySqlConnection connection;
        private readonly MySqlCommand command;
        private MySqlTransaction transaction;

        internal MySqlCheckoutTransactionBoundary(MySqlConnection connection, MySqlCommand command)
        {
            this.connection = connection;
            this.command = command;
        }

        public bool IsOpen { get { return connection.State == ConnectionState.Open; } }
        public void Open() { connection.Open(); }

        public void BeginAndBind()
        {
            // MySqlCommand.Connection is assigned later by the ticket-sequence
            // reader. Binding the transaction to a command without its
            // connection first can lose that binding when Connection changes.
            // Establish connection ownership before starting the transaction.
            command.Connection = connection;
            transaction = connection.BeginTransaction();
            command.Transaction = transaction;
        }

        public void Commit() { transaction.Commit(); }
        public void Close() { connection.Close(); }
        public void Rollback() { transaction.Rollback(); }
    }
}
