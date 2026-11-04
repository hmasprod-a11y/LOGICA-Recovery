using System;
using LOGICA.Infrastructure.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Only the posting writer is substituted: this executable links the
    // ACTUAL production MySqlCheckoutAtomicPostingBoundary and runs it against
    // the disposable MariaDB schema created by the SQL integration gate.
    internal interface ICheckoutTransactionBoundary
    {
        bool IsOpen { get; }
        void Open();
        void BeginAndBind();
        void Commit();
        void Rollback();
        void Close();
    }
    internal interface ICheckoutPostingStore
    {
        void ApplyStock(CheckoutStockLine line);
        void WriteHeader(TicketHeaderRecord header);
        void WriteJournal(TicketJournalRecord journal);
        void WritePayment(TicketPaymentWrite payment);
        void Complete(CheckoutCompletionRecord completion);
    }
    internal interface ICheckoutAtomicPostingBoundary : ICheckoutTransactionBoundary, ICheckoutPostingStore
    {
        bool TryClaimOperation(string operationId);
    }
    internal sealed class CheckoutStockLine { }
    internal sealed class TicketHeaderRecord { }
    internal sealed class TicketJournalRecord { }
    internal sealed class TicketPaymentWrite { }
    internal sealed class CheckoutCompletionRecord { }
}
namespace LOGICA.Infrastructure.Checkout
{
    internal sealed class MySqlCheckoutPostingStore : LOGICA.ApplicationLayer.Checkout.ICheckoutPostingStore
    {
        internal MySqlCheckoutPostingStore(MySqlCommand command, MySqlConnection connection) { }
        public void ApplyStock(LOGICA.ApplicationLayer.Checkout.CheckoutStockLine line) { }
        public void WriteHeader(LOGICA.ApplicationLayer.Checkout.TicketHeaderRecord header) { }
        public void WriteJournal(LOGICA.ApplicationLayer.Checkout.TicketJournalRecord journal) { }
        public void WritePayment(LOGICA.ApplicationLayer.Checkout.TicketPaymentWrite payment) { }
        public void Complete(LOGICA.ApplicationLayer.Checkout.CheckoutCompletionRecord completion) { }
    }

    internal static class Program
    {
        private static void Require(bool condition, string message)
        {
            if (!condition) throw new InvalidOperationException(message);
        }

        private static MySqlConnection NewConnection()
        {
            return new MySqlConnection(Environment.GetEnvironmentVariable("CHECKOUT_TEST_CONNECTION"));
        }

        private static void Main()
        {
            Require(!string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("CHECKOUT_TEST_CONNECTION")),
                "Disposable CHECKOUT_TEST_CONNECTION is required.");
            string key = "csharp-boundary-" + Guid.NewGuid().ToString("N");
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(boundary.TryClaimOperation(key), "First claim must succeed.");
                boundary.Commit();
                boundary.Close();
            }
            MySqlCheckoutOperationJournal journal = new MySqlCheckoutOperationJournal(NewConnection);
            Require(journal.IsPersisted(key), "Committed C# operation must be durable.");
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(!boundary.TryClaimOperation(key), "Duplicate C# operation must be rejected.");
                boundary.Rollback();
                boundary.Close();
            }
            string rolledBack = key + "-rollback";
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(boundary.TryClaimOperation(rolledBack), "Rollback claim should begin.");
                boundary.Rollback();
                boundary.Close();
            }
            Require(!journal.IsPersisted(rolledBack), "Rolled back C# operation must not persist.");
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(boundary.TryClaimOperation(rolledBack), "Retry after verified rollback must succeed.");
                boundary.Commit();
                boundary.Close();
            }
            Require(journal.IsPersisted(rolledBack), "Retry must be durable.");
            // A lost acknowledgement after COMMIT is not permission to repost.
            // The second connection must see the committed claim, and a third
            // connection must still reject it after the first was closed.
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                Require(!boundary.TryClaimOperation(key), "Lost-ack replay must not claim committed ID.");
                boundary.Rollback();
                boundary.Close();
            }
            Require(journal.IsPersisted(key), "Reconciliation must survive duplicate replay.");

            // A malformed ID must never be inserted, even when the caller
            // has already begun a transaction.
            using (MySqlConnection connection = NewConnection())
            {
                MySqlCheckoutAtomicPostingBoundary boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                boundary.Open();
                boundary.BeginAndBind();
                bool rejected = false;
                try { boundary.TryClaimOperation(" invalid "); }
                catch (ArgumentException) { rejected = true; }
                Require(rejected, "Whitespace-surrounded operation ID must be rejected.");
                boundary.Rollback();
                boundary.Close();
            }

            // The durable journal must not mistake a missing operation for
            // an unknown database result; an actual connection error must
            // propagate instead of authorizing a retry.
            Require(!journal.IsPersisted("not-present-" + Guid.NewGuid().ToString("N")),
                "A never-submitted operation must be absent.");
            var unreachable = new MySqlCheckoutOperationJournal(() =>
                new MySqlConnection("Server=127.0.0.1;Port=1;Database=checkout_disposable;Uid=checkout_test;Pwd=checkout-test-only;SslMode=Disabled;Connection Timeout=1;"));
            bool connectionFailed = false;
            try { unreachable.IsPersisted(key); }
            catch (MySqlException) { connectionFailed = true; }
            Require(connectionFailed, "Unavailable journal must propagate unknown outcome.");

            // Real production stock/movement writers, with signed V1 sale/return.
            using (MySqlConnection db = NewConnection())
            {
                db.Open();
                using (MySqlCommand setup = db.CreateCommand())
                {
                    setup.CommandText = "CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(64) PRIMARY KEY, STOCK DECIMAL(16,3) NOT NULL) ENGINE=InnoDB";
                    setup.ExecuteNonQuery();
                    setup.CommandText = "CREATE TABLE TABLE_MOUVEMENTS_STOCK (DATES VARCHAR(16), HEURE VARCHAR(16), LIBELLE VARCHAR(128), ID_ARTICLE VARCHAR(64), CODE_ARTICLE VARCHAR(64), ARTICLE VARCHAR(128), QUANTITE DECIMAL(16,3)) ENGINE=InnoDB";
                    setup.ExecuteNonQuery();
                    setup.CommandText = "INSERT INTO TABLE_ARTICLES VALUES ('CSharp-Stock',10)";
                    setup.ExecuteNonQuery();
                }
                using (MySqlTransaction tx = db.BeginTransaction())
                using (MySqlCommand cmd = db.CreateCommand())
                {
                    cmd.Transaction = tx;
                    CheckoutStockWriter.Apply(cmd, db, "SALE-1", "CSharp-Stock", "CODE", "Article", 2m);
                    CheckoutStockWriter.Apply(cmd, db, "RETURN-1", "CSharp-Stock", "CODE", "Article", -1m);
                    tx.Commit();
                }
                using (MySqlCommand check = db.CreateCommand())
                {
                    check.CommandText = "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'";
                    Require(Convert.ToDecimal(check.ExecuteScalar()) == 9m, "Sale/return stock parity failed.");
                    check.CommandText = "SELECT SUM(QUANTITE) FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='CSharp-Stock'";
                    Require(Convert.ToDecimal(check.ExecuteScalar()) == -1m, "Signed movement parity failed.");
                }
                using (MySqlTransaction tx = db.BeginTransaction())
                using (MySqlCommand cmd = db.CreateCommand())
                {
                    cmd.Transaction = tx;
                    bool missingRejected = false;
                    try { CheckoutStockWriter.Apply(cmd, db, "BAD", "missing", "CODE", "Article", 3m); }
                    catch (InvalidOperationException) { missingRejected = true; }
                    Require(missingRejected, "Missing article must fail closed.");
                    CheckoutStockWriter.Apply(cmd, db, "ROLLBACK", "CSharp-Stock", "CODE", "Article", 4m);
                    tx.Rollback();
                }
                using (MySqlCommand check = db.CreateCommand())
                {
                    check.CommandText = "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'";
                    Require(Convert.ToDecimal(check.ExecuteScalar()) == 9m, "Rollback changed stock.");
                    check.CommandText = "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE='TICKET | ROLLBACK'";
                    Require(Convert.ToInt64(check.ExecuteScalar()) == 0, "Rollback left movement.");
                    bool noTxRejected = false;
                    try { CheckoutStockWriter.Apply(check, db, "NO-TX", "CSharp-Stock", "CODE", "Article", 1m); }
                    catch (InvalidOperationException) { noTxRejected = true; }
                    Require(noTxRejected, "Writer accepted no transaction.");
                }
            }
            Console.WriteLine("PASS production C# stock sale/return, movement, missing article and rollback.");
            Console.WriteLine("PASS production C# MariaDB boundary: commit, replay, rollback, invalid ID and unknown reconciliation.");
        }
    }
}
