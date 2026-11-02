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

    private static void CheckProgress(string failAt, CheckoutCommitStage expected, string expectedEvents)
    {
        var store = new Store { FailAt = failAt };
        var progress = new CheckoutCommitProgress();
        bool failed = false;
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                store, Input(store), store, progress);
        }
        catch (InvalidOperationException ex) { failed = ex.Message == failAt; }
        if (failed != (failAt != null))
            throw new Exception("Portable commit outcome failure propagation: " + failAt);
        if (progress.Stage != expected ||
            progress.CommitOutcomeUnknown != (expected == CheckoutCommitStage.CommitAttempted) ||
            progress.CommitWasConfirmed != (expected == CheckoutCommitStage.CommitConfirmed ||
                                            expected == CheckoutCommitStage.Closed))
            throw new Exception("Portable commit outcome misclassified: " + failAt);
        if (String.Join(",", store.Events.ToArray()) != expectedEvents)
            throw new Exception("Portable commit outcome changed order: " + failAt);

        var duplicate = new Store();
        bool rejected = false;
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                duplicate, Input(duplicate), duplicate, progress);
        }
        catch (InvalidOperationException) { rejected = true; }
        if (!rejected || duplicate.Events.Count != 0)
            throw new Exception("Portable duplicate SOLDER attempt reused progress");
    }

    public static int Run()
    {
        Check(null, "header,journal,print,complete,commit,close");
        Check("print", "header,journal,print");
        Check("complete", "header,journal,print,complete");
        Check("commit", "header,journal,print,complete,commit");
        Check("close", "header,journal,print,complete,commit,close");
        CheckProgress(null, CheckoutCommitStage.Closed,
            "header,journal,print,complete,commit,close");
        CheckProgress("print", CheckoutCommitStage.Posting,
            "header,journal,print");
        CheckProgress("commit", CheckoutCommitStage.CommitAttempted,
            "header,journal,print,complete,commit");
        CheckProgress("close", CheckoutCommitStage.CommitConfirmed,
            "header,journal,print,complete,commit,close");
        CheckBoundary(null, "state,open,begin.bind,commit,close");
        CheckBoundary("open", "state,open");
        CheckBoundary("begin.bind", "state,open,begin.bind");
        CheckBoundary("commit", "state,open,begin.bind,commit");
        CheckBoundary("close", "state,open,begin.bind,commit,close");

        // The WinForms transaction may already be open when finalization is
        // invoked. A missing finalizer must not post stock/ticket/payment first.
        var missingFinalizer = new Store();
        bool nullFinalizerRejected = false;
        try { CheckoutTransactionFinalizationService.PostAndFinalize(
            missingFinalizer, Input(missingFinalizer), null); }
        catch (ArgumentNullException ex) { nullFinalizerRejected = ex.ParamName == "finalizer"; }
        if (!nullFinalizerRejected || missingFinalizer.Events.Count != 0)
            throw new Exception("Missing transaction finalizer must fail before posting");
        // .NET 10 executes the same production per-cashier guard as WinForms.
        // A second click cannot write another ticket while the first outcome
        // has not been reconciled, even with a fresh progress instance.
        var cashierGate = new CheckoutAttemptGate();
        var first = new Store();
        var firstProgress = new CheckoutCommitProgress();
        CheckoutTransactionFinalizationService.PostAndFinalize(
            first, Input(first), first, firstProgress, cashierGate);
        if (!cashierGate.IsBlocked || firstProgress.Stage != CheckoutCommitStage.Closed)
            throw new Exception("Portable cashier gate released before basket reset");
        var repeated = new Store();
        bool blocked = false;
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                repeated, Input(repeated), repeated,
                new CheckoutCommitProgress(), cashierGate);
        }
        catch (InvalidOperationException) { blocked = true; }
        if (!blocked || repeated.Events.Count != 0)
            throw new Exception("Portable double SOLDER click reached posting");
        cashierGate.ReleaseAfterBasketReset(firstProgress);

        foreach (string failAt in new[] { "print", "commit", "close" })
        {
            var failedStore = new Store { FailAt = failAt };
            var failedProgress = new CheckoutCommitProgress();
            bool thrown = false;
            try
            {
                CheckoutTransactionFinalizationService.PostAndFinalize(
                    failedStore, Input(failedStore), failedStore,
                    failedProgress, cashierGate);
            }
            catch (InvalidOperationException ex) { thrown = ex.Message == failAt; }
            if (!thrown || !cashierGate.IsBlocked)
                throw new Exception("Portable failed checkout was not gated: " + failAt);
            if (failAt == "print")
                cashierGate.ReleaseAfterVerifiedRollback(failedProgress);
            else
            {
                bool unsafeReset = false;
                try { cashierGate.ReleaseAfterVerifiedRollback(failedProgress); }
                catch (InvalidOperationException) { unsafeReset = true; }
                if (!unsafeReset || !cashierGate.IsBlocked)
                    throw new Exception("Portable ambiguous commit incorrectly retried");
                cashierGate.ReleaseAfterDatabaseReconciliation(failedProgress);
            }
            if (cashierGate.IsBlocked)
                throw new Exception("Portable cashier remained blocked after reconciliation");
        }

        Console.WriteLine("PASS .NET 10 portable checkout: transaction boundary, atomic progress, per-cashier double-click gate, commit reconciliation and failure propagation");
        return 0;
    }
}
