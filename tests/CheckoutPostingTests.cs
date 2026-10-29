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

    private sealed class Store : ICheckoutDocumentStore
    {
        private readonly Probe probe;
        public Store(Probe probe) { this.probe = probe; }
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

    private static void Run(bool credit, string failureAt)
    {
        var probe = new Probe { FailureAt = failureAt };
        var input = new CheckoutPostingInput
        {
            ReadHeader = delegate { probe.Hit("read-header"); return probe.Header; },
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
        var expected = new List<string> { "read-header", "write-header", "read-journal", "write-journal", "read-payments" };
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
            foreach (string stage in new[] { "read-header", "write-header", "read-journal", "write-journal", "read-payments",
                "read-Cash", "write-Cash", "read-Tendered", "write-Tendered", "read-Change", "write-Change", "print", "read-completion", "complete" })
                Run(false, stage);
            Console.WriteLine("PASS checkout posting: " + assertions + " assertions; ordered lazy reads and failure propagation without UI/database");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
