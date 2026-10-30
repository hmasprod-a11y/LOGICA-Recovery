using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;

internal static class CheckoutPostingTests
{
    private static int assertions;
    private sealed class Probe
    {
        public readonly List<string> Events = new List<string>();
        public string FailureAt;
        public readonly Exception Failure = new Exception("controlled posting failure");
        public readonly TicketHeaderRecord Header = new TicketHeaderRecord();
        public readonly TicketJournalRecord Journal = new TicketJournalRecord();
        public readonly CheckoutCompletionRecord Completion = new CheckoutCompletionRecord();
        public void Hit(string stage) { Events.Add(stage); if (stage == FailureAt) throw Failure; }
        public IEnumerable<CheckoutStockLine> Stock(bool disabled)
        {
            if (disabled) yield break;
            for (int i = 1; i <= 2; i++)
            {
                Hit("read-stock" + i);
                yield return new CheckoutStockLine { ArticleId = i };
            }
        }
        public IEnumerable<TicketPaymentWrite> Payments(bool credit)
        {
            if (credit) yield break;
            foreach (TicketPaymentKind kind in new[] { TicketPaymentKind.Cash, TicketPaymentKind.Tendered, TicketPaymentKind.Change })
            {
                Hit("read-" + kind);
                yield return new TicketPaymentWrite { Kind = kind };
            }
        }
    }

    private sealed class Store : ICheckoutPostingStore
    {
        private readonly Probe probe;
        public Store(Probe probe) { this.probe = probe; }
        public void ApplyStock(CheckoutStockLine line) { probe.Hit("write-stock" + line.ArticleId); }
        public void WriteHeader(TicketHeaderRecord header)
        {
            if (!object.ReferenceEquals(header, probe.Header)) throw new Exception("Header was substituted");
            probe.Hit("write-header");
        }
        public void WriteJournal(TicketJournalRecord journal)
        {
            if (!object.ReferenceEquals(journal, probe.Journal)) throw new Exception("Journal was substituted");
            probe.Hit("write-journal");
        }
        public void WritePayment(TicketPaymentWrite payment) { probe.Hit("write-" + payment.Kind); }
        public void Complete(CheckoutCompletionRecord completion)
        {
            if (!object.ReferenceEquals(completion, probe.Completion)) throw new Exception("Completion was substituted");
            probe.Hit("complete");
        }
    }

    private static void Run(bool credit, string failureAt, bool stockDisabled = false)
    {
        var probe = new Probe { FailureAt = failureAt };
        var input = new CheckoutPostingInput
        {
            ReadStock = delegate { probe.Hit("read-stock"); return probe.Stock(stockDisabled); },
            ReadHeader = delegate { probe.Hit("prepare-documents"); probe.Hit("read-header"); return probe.Header; },
            ReadJournal = delegate { probe.Hit("read-journal"); return probe.Journal; },
            ReadPayments = delegate { probe.Hit("read-payments"); return probe.Payments(credit); },
            Print = delegate { probe.Hit("print"); },
            ReadCompletion = delegate { probe.Hit("read-completion"); return probe.Completion; }
        };
        Exception caught = null;
        try { CheckoutPostingService.Post(new Store(probe), input); }
        catch (Exception error) { caught = error; }
        assertions++;
        if (failureAt == null ? caught != null : !object.ReferenceEquals(caught, probe.Failure))
            throw new Exception("Failure propagation changed at " + failureAt);
        var expected = new List<string> { "read-stock" };
        if (!stockDisabled) expected.AddRange(new[] { "read-stock1", "write-stock1", "read-stock2", "write-stock2" });
        expected.AddRange(new[] { "prepare-documents", "read-header", "write-header", "read-journal", "write-journal", "read-payments" });
        if (!credit) expected.AddRange(new[] { "read-Cash", "write-Cash", "read-Tendered", "write-Tendered", "read-Change", "write-Change" });
        expected.AddRange(new[] { "print", "read-completion", "complete" });
        if (failureAt != null) expected = expected.GetRange(0, expected.IndexOf(failureAt) + 1);
        assertions++;
        if (string.Join("|", probe.Events.ToArray()) != string.Join("|", expected.ToArray()))
            throw new Exception("Posting order/short-circuit changed at " + failureAt);
    }

    public static int Main()
    {
        try
        {
            Run(false, null);
            Run(true, null);
            Run(false, null, true);
            Run(true, null, true);
            foreach (string stage in new[] { "read-stock", "read-stock1", "write-stock1", "read-stock2", "write-stock2", "prepare-documents", "read-header", "write-header", "read-journal", "write-journal", "read-payments",
                "read-Cash", "write-Cash", "read-Tendered", "write-Tendered", "read-Change", "write-Change", "print", "read-completion", "complete" })
                Run(false, stage);
            Console.WriteLine("PASS checkout posting: " + assertions + " assertions; ordered lazy reads and failure propagation without UI/database");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
