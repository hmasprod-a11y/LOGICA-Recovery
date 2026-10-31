using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;

internal static class CheckoutPostingPipelineTests
{
    private sealed class InjectedFailure : Exception { }
    private sealed class Scenario : ICheckoutPostingStore
    {
        internal readonly List<string> Events = new List<string>();
        internal string FailAt;

        internal void Mark(string name)
        {
            Events.Add(name);
            if (name == FailAt) throw new InjectedFailure();
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

        internal CheckoutPostingInput BuildInput()
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
        public void WriteHeader(TicketHeaderRecord record) { Mark("header.write"); }
        public void WriteJournal(TicketJournalRecord record) { Mark("journal.write"); }
        public void WritePayment(TicketPaymentWrite payment) { Mark("payment.write." + payment.AmountText); }
        public void Complete(CheckoutCompletionRecord completion) { Mark("completion.write"); }
    }

    private static readonly string[] Expected = {
        "stock.read", "stock.next.1", "stock.write.1", "stock.next.2", "stock.write.2",
        "header.read", "header.write", "journal.read", "journal.write",
        "payment.read", "payment.next.1", "payment.write.1", "payment.next.2", "payment.write.2",
        "print", "completion.read", "completion.write"
    };

    private static void Same(IList<string> actual, IList<string> expected, string label)
    {
        if (actual.Count != expected.Count)
            throw new Exception(label + ": expected " + expected.Count + " events, got " + actual.Count +
                " [" + String.Join(",", actual) + "]");
        for (int i = 0; i < expected.Count; i++)
            if (actual[i] != expected[i])
                throw new Exception(label + ": event " + i + " was " + actual[i] + ", expected " + expected[i]);
    }

    public static int Main()
    {
        var normal = new Scenario();
        CheckoutPostingService.Post(normal, normal.BuildInput());
        Same(normal.Events, Expected, "success");

        // Every failure boundary must stop immediately. Prior writes are not compensated
        // by this service; the original Form still owns MySQL commit/rollback and printing.
        for (int failure = 0; failure < Expected.Length; failure++)
        {
            var scenario = new Scenario { FailAt = Expected[failure] };
            bool caught = false;
            try { CheckoutPostingService.Post(scenario, scenario.BuildInput()); }
            catch (InjectedFailure) { caught = true; }
            if (!caught) throw new Exception("Expected injected failure at " + Expected[failure]);
            var prefix = new List<string>();
            for (int i = 0; i <= failure; i++) prefix.Add(Expected[i]);
            Same(scenario.Events, prefix, "failure at " + Expected[failure]);
        }

        var empty = new Scenario();
        CheckoutPostingInput emptyInput = empty.BuildInput();
        emptyInput.ReadStock = delegate { empty.Mark("stock.read"); return new CheckoutStockLine[0]; };
        emptyInput.ReadPayments = delegate { empty.Mark("payment.read"); return new TicketPaymentWrite[0]; };
        CheckoutPostingService.Post(empty, emptyInput);
        Same(empty.Events, new[] {
            "stock.read", "header.read", "header.write", "journal.read", "journal.write",
            "payment.read", "print", "completion.read", "completion.write"
        }, "empty enumerations");

        var nullStock = new Scenario();
        CheckoutPostingInput nullStockInput = nullStock.BuildInput();
        nullStockInput.ReadStock = delegate { nullStock.Mark("stock.read"); return null; };
        bool stockNull = false;
        try { CheckoutPostingService.Post(nullStock, nullStockInput); }
        catch (NullReferenceException) { stockNull = true; }
        if (!stockNull) throw new Exception("Null stock enumeration must fail before header");
        Same(nullStock.Events, new[] { "stock.read" }, "null stock enumeration");

        var nullPayments = new Scenario();
        CheckoutPostingInput nullPaymentsInput = nullPayments.BuildInput();
        nullPaymentsInput.ReadPayments = delegate { nullPayments.Mark("payment.read"); return null; };
        bool paymentNull = false;
        try { CheckoutPostingService.Post(nullPayments, nullPaymentsInput); }
        catch (NullReferenceException) { paymentNull = true; }
        if (!paymentNull) throw new Exception("Null payment enumeration must fail before printing");
        Same(nullPayments.Events, new[] {
            "stock.read", "stock.next.1", "stock.write.1", "stock.next.2", "stock.write.2",
            "header.read", "header.write", "journal.read", "journal.write", "payment.read"
        }, "null payment enumeration");

        Console.WriteLine("PASS checkout posting: 17 stage failures, lazy ordering, empty/null streams, no implicit rollback");
        return 0;
    }
}
