using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;

internal static class CheckoutTransactionFinalizationTests
{
    private sealed class InjectedFailure : Exception { }

    // Simulates the Form's existing catch/rollback without touching a shop database.
    private sealed class Scenario : ICheckoutPostingStore, ICheckoutTransactionFinalizer
    {
        internal readonly List<string> Events = new List<string>();
        internal string FailAt;

        private void Mark(string stage)
        {
            Events.Add(stage);
            if (stage == FailAt) throw new InjectedFailure();
        }

        private IEnumerable<CheckoutStockLine> StockRows()
        {
            Mark("stock.next.1");
            yield return new CheckoutStockLine { ArticleCode = "1" };
            Mark("stock.next.2");
            yield return new CheckoutStockLine { ArticleCode = "2" };
        }

        private IEnumerable<TicketPaymentWrite> PaymentRows()
        {
            Mark("payment.next.1");
            yield return new TicketPaymentWrite { AmountText = "1" };
            Mark("payment.next.2");
            yield return new TicketPaymentWrite { AmountText = "2" };
        }

        internal CheckoutPostingInput Input()
        {
            return new CheckoutPostingInput {
                ReadStock = delegate { Mark("stock.read"); return StockRows(); },
                ReadHeader = delegate { Mark("header.read"); return new TicketHeaderRecord(); },
                ReadJournal = delegate { Mark("journal.read"); return new TicketJournalRecord(); },
                ReadPayments = delegate { Mark("payment.read"); return PaymentRows(); },
                Print = delegate { Mark("print"); },
                ReadCompletion = delegate { Mark("completion.read"); return new CheckoutCompletionRecord(); }
            };
        }

        public void ApplyStock(CheckoutStockLine line) { Mark("stock.write." + line.ArticleCode); }
        public void WriteHeader(TicketHeaderRecord header) { Mark("header.write"); }
        public void WriteJournal(TicketJournalRecord journal) { Mark("journal.write"); }
        public void WritePayment(TicketPaymentWrite payment) { Mark("payment.write." + payment.AmountText); }
        public void Complete(CheckoutCompletionRecord completion) { Mark("completion.write"); }
        public void Commit() { Mark("commit"); }
        public void Close() { Mark("close"); }
        internal void Rollback() { Mark("rollback"); }
    }

    private static readonly string[] Stages = {
        "stock.read", "stock.next.1", "stock.write.1", "stock.next.2", "stock.write.2",
        "header.read", "header.write", "journal.read", "journal.write",
        "payment.read", "payment.next.1", "payment.write.1", "payment.next.2", "payment.write.2",
        "print", "completion.read", "completion.write", "commit", "close"
    };

    private static void AssertEvents(IList<string> actual, IList<string> expected, string label)
    {
        if (actual.Count != expected.Count)
            throw new Exception(label + ": count " + actual.Count + " != " + expected.Count +
                " (" + String.Join(",", actual) + ")");
        for (int i = 0; i < expected.Count; i++)
            if (actual[i] != expected[i])
                throw new Exception(label + ": stage " + i + " " + actual[i] + " != " + expected[i]);
    }

    private static void Run(Scenario scenario)
    {
        try { CheckoutTransactionFinalizationService.PostAndFinalize(scenario, scenario.Input(), scenario); }
        catch (InjectedFailure) { scenario.Rollback(); }
    }

    public static int Main()
    {
        var success = new Scenario();
        Run(success);
        AssertEvents(success.Events, Stages, "successful checkout commit and close");

        // Characterize caller-owned rollback after each original stage AND after
        // commit/close errors. No later writes, printing or connection close are injected.
        for (int failure = 0; failure < Stages.Length; failure++)
        {
            var scenario = new Scenario { FailAt = Stages[failure] };
            Run(scenario);
            var expected = new List<string>();
            for (int i = 0; i <= failure; i++) expected.Add(Stages[i]);
            expected.Add("rollback");
            AssertEvents(scenario.Events, expected, "failure at " + Stages[failure]);
        }

        Console.WriteLine("PASS checkout transaction finalization: 19 ordered stages, commit/close failures and caller-owned rollback");
        return 0;
    }
}
