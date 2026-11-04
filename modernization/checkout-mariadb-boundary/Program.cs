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
            Console.WriteLine("PASS production C# MySqlCheckoutAtomicPostingBoundary claim, duplicate, rollback and reconciliation.");
        }
    }
}
