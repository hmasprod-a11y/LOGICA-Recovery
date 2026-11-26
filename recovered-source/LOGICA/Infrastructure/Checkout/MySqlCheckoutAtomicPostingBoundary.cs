using System;
using System.Data;
using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    // The journal table is provisioned by the operator in a disposable schema
    // for tests; never create/migrate tables on a real cashier's connection.
    // All legacy ticket, stock, payment and completion writers share command
    // and transaction with the operation claim.
    internal sealed class MySqlCheckoutAtomicPostingBoundary : ICheckoutAtomicPostingBoundary
    {
        private readonly MySqlConnection connection;
        private readonly MySqlCommand command;
        private readonly MySqlCheckoutPostingStore posting;
        private MySqlTransaction transaction;

        internal MySqlCheckoutAtomicPostingBoundary(MySqlConnection connection)
        {
            if (connection == null) throw new ArgumentNullException("connection");
            this.connection = connection;
            command = connection.CreateCommand();
            posting = new MySqlCheckoutPostingStore(command, connection);
        }

        internal MySqlTransaction ActiveTransaction { get { return transaction ?? throw new InvalidOperationException("Checkout transaction has not begun."); } }
        public bool IsOpen { get { return connection.State == ConnectionState.Open; } }
        public void Open() { connection.Open(); }
        public void BeginAndBind()
        {
            if (transaction != null)
                throw new InvalidOperationException("A checkout transaction is already active.");
            transaction = connection.BeginTransaction();
            command.Transaction = transaction;
        }

        public bool TryClaimOperation(string operationId)
        {
            if (transaction == null)
                throw new InvalidOperationException("Checkout transaction has not begun.");
            ValidateOperationId(operationId);
            EnsureTransactionalOperationTable(command);
            // The UNIQUE primary key serializes duplicate submissions even
            // across independent Windows processes and cashier connections.
            command.Parameters.Clear();
            command.CommandText =
                "INSERT INTO hanouty_checkout_operations (operation_id) VALUES (@operation_id)";
            command.Parameters.Add("@operation_id", MySqlDbType.VarChar).Value = operationId;
            try { return command.ExecuteNonQuery() == 1; }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) return false;
                throw;
            }
            finally { command.Parameters.Clear(); }
        }

        internal static void EnsureTransactionalOperationTable(MySqlCommand command)
        {
            command.Parameters.Clear();
            try
            {
                command.CommandText = "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@operationTable";
                command.Parameters.AddWithValue("@operationTable", "hanouty_checkout_operations");
                if (!String.Equals(Convert.ToString(command.ExecuteScalar()), "InnoDB", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("Durable checkout operations require an existing InnoDB ledger.");
            }
            finally { command.Parameters.Clear(); }
        }

        private static void ValidateOperationId(string operationId)
        {
            if (String.IsNullOrWhiteSpace(operationId) || operationId.Length > 128 ||
                operationId.Trim() != operationId || !IsAsciiOperationId(operationId))
                throw new ArgumentException("Operation ID must be 1-128 non-whitespace characters without surrounding spaces.", "operationId");
        }

        internal static bool IsAsciiOperationId(string operationId)
        {
            foreach (char value in operationId)
                if (value < 0x21 || value > 0x7e) return false;
            return true;
        }

        public void Commit()
        {
            if (transaction == null)
                throw new InvalidOperationException("No checkout transaction is active.");
            transaction.Commit();
        }

        public void Rollback()
        {
            if (transaction == null)
                throw new InvalidOperationException("No checkout transaction is active.");
            transaction.Rollback();
        }
        public void Close()
        {
            // A successful Commit must release its transaction and command.
            // Closing a connection is not proof that a failed Commit rolled
            // back: the caller must still reconcile the durable operation ID.
            try { connection.Close(); }
            finally
            {
                command.Transaction = null;
                if (transaction != null)
                {
                    transaction.Dispose();
                    transaction = null;
                }
                command.Dispose();
            }
        }

        public void ApplyStock(CheckoutStockLine line) { posting.ApplyStock(line); }
        public void WriteHeader(TicketHeaderRecord header) { posting.WriteHeader(header); }
        public void WriteJournal(TicketJournalRecord journal) { posting.WriteJournal(journal); }
        public void WritePayment(TicketPaymentWrite payment) { posting.WritePayment(payment); }
        public void Complete(CheckoutCompletionRecord completion) { posting.Complete(completion); }
    }

    // Lookup must run on a fresh read connection after an ambiguous commit.
    // Connection failures propagate; the WPF session must keep Unknown locked.
    internal sealed class MySqlCheckoutOperationJournal
    {
        private readonly Func<MySqlConnection> createConnection;
        internal MySqlCheckoutOperationJournal(Func<MySqlConnection> createConnection)
        {
            this.createConnection = createConnection ??
                throw new ArgumentNullException("createConnection");
        }

        internal bool IsPersisted(string operationId)
        {
            if (String.IsNullOrWhiteSpace(operationId) || operationId.Length > 128 || operationId.Trim() != operationId || !MySqlCheckoutAtomicPostingBoundary.IsAsciiOperationId(operationId))
                throw new ArgumentException("Invalid operation ID.", "operationId");
            using (MySqlConnection connection = createConnection())
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    MySqlCheckoutAtomicPostingBoundary.EnsureTransactionalOperationTable(command);
                    command.CommandText =
                        "SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id = @operation_id";
                    command.Parameters.Add("@operation_id", MySqlDbType.VarChar).Value = operationId;
                    return Convert.ToInt64(command.ExecuteScalar()) == 1L;
                }
            }
        }
    }
}
