using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;

internal static class PortableTransactionSmoke
{
    private sealed class Store : ICheckoutPostingStore, ICheckoutTransactionFinalizer, ICheckoutTransactionBoundary
    {
        internal readonly List<string> Events = new List<string>();
        internal string FailAt;
        internal void Mark(string stage)
        {
            Events.Add(stage);
            if (stage == FailAt) throw new InvalidOperationException(stage);
        }
        public void ApplyStock(CheckoutStockLine line) { Mark("stock"); }
        public void WriteHeader(TicketHeaderRecord header) { Mark("header"); }
        public void WriteJournal(TicketJournalRecord journal) { Mark("journal"); }
        public void WritePayment(TicketPaymentWrite payment) { Mark("payment"); }
        public void Complete(CheckoutCompletionRecord completion) { Mark("complete"); }
        public void Commit() { Mark("commit"); }
        public void Close() { Mark("close"); }
        public bool IsOpen { get { Mark("state"); return false; } }
        public void Open() { Mark("open"); }
        public void BeginAndBind() { Mark("begin.bind"); }
        public void Rollback() { Mark("rollback"); }
    }

    private static CheckoutPostingInput Input(Store store)
    {
        return new CheckoutPostingInput {
            ReadStock = delegate { return new CheckoutStockLine[0]; },
            ReadHeader = delegate { return new TicketHeaderRecord(); },
            ReadJournal = delegate { return new TicketJournalRecord(); },
            ReadPayments = delegate { return new TicketPaymentWrite[0]; },
            Print = delegate { store.Mark("print"); },
            ReadCompletion = delegate { return new CheckoutCompletionRecord(); }
        };
    }

    private static void Check(string failAt, string expected)
    {
        var store = new Store { FailAt = failAt };
        bool failed = false;
        try { CheckoutTransactionFinalizationService.PostAndFinalize(store, Input(store), store); }
        catch (InvalidOperationException ex) { failed = ex.Message == failAt; }
        if (failed != (failAt != null)) throw new Exception("Transaction failure propagation: " + failAt);
        string actual = String.Join(",", store.Events.ToArray());
        if (actual != expected)
            throw new Exception("Transaction finalization order: " + actual + " expected " + expected);
    }

    private static void CheckBoundary(string failAt, string expected)
    {
        var boundary = new Store { FailAt = failAt };
        bool failed = false;
        try
        {
            CheckoutTransactionBoundaryService.Begin(boundary);
            CheckoutTransactionBoundaryService.CommitAndClose(boundary);
        }
        catch (InvalidOperationException ex) { failed = ex.Message == failAt; }
        if (failed != (failAt != null))
            throw new Exception("Transaction boundary failure propagation: " + failAt);
        if (String.Join(",", boundary.Events.ToArray()) != expected)
            throw new Exception("Transaction boundary order: " +
                String.Join(",", boundary.Events.ToArray()) + " expected " + expected);
    }

    public static int Run()
    {
        Check(null, "header,journal,print,complete,commit,close");
        Check("print", "header,journal,print");
        Check("complete", "header,journal,print,complete");
        Check("commit", "header,journal,print,complete,commit");
        Check("close", "header,journal,print,complete,commit,close");
        CheckBoundary(null, "state,open,begin.bind,commit,close");
        CheckBoundary("open", "state,open");
        CheckBoundary("begin.bind", "state,open,begin.bind");
        CheckBoundary("commit", "state,open,begin.bind,commit");
        CheckBoundary("close", "state,open,begin.bind,commit,close");
        Console.WriteLine("PASS .NET 10 portable checkout: transaction boundary and finalization failure propagation");
        return 0;
    }
}
