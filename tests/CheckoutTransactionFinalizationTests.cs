using System;
using System.Collections.Generic;
using System.Threading;
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
            yield return new TicketPaymentWrite {
                AmountText = "1", Context = new TicketPaymentContext { TicketNumber = "T-1" } };
            Mark("payment.next.2");
            yield return new TicketPaymentWrite {
                AmountText = "2", Context = new TicketPaymentContext { TicketNumber = "T-1" } };
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

        // The real WinForms SOLDER entry point uses this production finalizer.
        // Track the commit boundary without changing legacy rollback behavior.
        // A failed Commit is ambiguous; a failed Close is AFTER a confirmed Commit.
        foreach (string stage in new[] { "stock.write.1", "payment.write.1", "print", "commit", "close", "" })
        {
            var tracked = new Scenario { FailAt = stage };
            var progress = new CheckoutCommitProgress();
            bool threw = false;
            try
            {
                CheckoutTransactionFinalizationService.PostAndFinalize(
                    tracked, tracked.Input(), tracked, progress);
            }
            catch (InjectedFailure) { threw = true; }
            if (threw != (stage != ""))
                throw new Exception("Commit progress did not propagate " + stage);
            CheckoutCommitStage expected = stage == "" ? CheckoutCommitStage.Closed :
                stage == "commit" ? CheckoutCommitStage.CommitAttempted :
                stage == "close" ? CheckoutCommitStage.CommitConfirmed : CheckoutCommitStage.Posting;
            if (progress.Stage != expected ||
                progress.CommitOutcomeUnknown != (expected == CheckoutCommitStage.CommitAttempted) ||
                progress.CommitWasConfirmed != (expected == CheckoutCommitStage.CommitConfirmed ||
                                                expected == CheckoutCommitStage.Closed))
                throw new Exception("Unsafe SOLDER commit outcome classification at " + stage);
            int commits = 0, closes = 0;
            foreach (string item in tracked.Events)
            {
                if (item == "commit") commits++;
                if (item == "close") closes++;
            }
            if (commits != (expected == CheckoutCommitStage.Posting ? 0 : 1) ||
                closes != (expected == CheckoutCommitStage.CommitConfirmed ||
                           expected == CheckoutCommitStage.Closed ? 1 : 0))
                throw new Exception("Commit/Close called more than once at " + stage);

            // A progress object from any completed/failed attempt is not
            // reusable; rejecting it must not invoke any store callback.
            var accidentalRetry = new Scenario();
            bool retryRejected = false;
            try
            {
                CheckoutTransactionFinalizationService.PostAndFinalize(
                    accidentalRetry, accidentalRetry.Input(), accidentalRetry, progress);
            }
            catch (InvalidOperationException) { retryRejected = true; }
            if (!retryRejected || accidentalRetry.Events.Count != 0)
                throw new Exception("Reused SOLDER progress reached database callbacks");
        }

        var missingProgress = new Scenario();
        bool missingProgressRejected = false;
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                missingProgress, missingProgress.Input(), missingProgress, null);
        }
        catch (ArgumentNullException ex) { missingProgressRejected = ex.ParamName == "progress"; }
        if (!missingProgressRejected || missingProgress.Events.Count != 0)
            throw new Exception("Null SOLDER progress must fail before stock mutation");

        // Concurrent callers must not both enter the same production progress.
        // This is deterministic: only one atomic NotStarted -> Posting wins.
        var sharedProgress = new CheckoutCommitProgress();
        int starts = 0;
        var workers = new Thread[16];
        for (int i = 0; i < workers.Length; i++)
        {
            workers[i] = new Thread(new ThreadStart(delegate {
                if (sharedProgress.TryStart()) Interlocked.Increment(ref starts);
            }));
            workers[i].Start();
        }
        foreach (Thread worker in workers) worker.Join();
        if (starts != 1 || sharedProgress.Stage != CheckoutCommitStage.Posting)
            throw new Exception("Concurrent SOLDER progress was admitted more than once");

        // P0 regression: malformed SOLDER input must fail before the
        // persistent per-form gate is acquired. The same progress/gate must
        // remain usable after the UI fixes its payload, without fake rollback.
        var preflightGate = new CheckoutAttemptGate();
        var preflightProgress = new CheckoutCommitProgress();
        var preflightScenario = new Scenario();
        var missingCallbackInput = preflightScenario.Input();
        missingCallbackInput.ReadPayments = null;
        int rejectedPreflight = 0;
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                null, preflightScenario.Input(), preflightScenario,
                preflightProgress, preflightGate);
        }
        catch (ArgumentNullException ex) { if (ex.ParamName == "store") rejectedPreflight++; }
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                preflightScenario, null, preflightScenario,
                preflightProgress, preflightGate);
        }
        catch (ArgumentNullException ex) { if (ex.ParamName == "input") rejectedPreflight++; }
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                preflightScenario, missingCallbackInput, preflightScenario,
                preflightProgress, preflightGate);
        }
        catch (InvalidOperationException ex)
        {
            if (ex.Message == "Checkout posting requires all callbacks before stock writes.")
                rejectedPreflight++;
        }
        if (rejectedPreflight != 3 || preflightGate.IsBlocked ||
            preflightProgress.Stage != CheckoutCommitStage.NotStarted ||
            preflightScenario.Events.Count != 0)
            throw new Exception("Malformed SOLDER payload locked cashier or invoked DB callbacks");
        CheckoutTransactionFinalizationService.PostAndFinalize(
            preflightScenario, preflightScenario.Input(), preflightScenario,
            preflightProgress, preflightGate);
        AssertEvents(preflightScenario.Events, Stages, "cashier retry after preflight");
        preflightGate.ReleaseAfterBasketReset(preflightProgress);
        if (preflightGate.IsBlocked)
            throw new Exception("Preflight retry gate did not release after verified basket reset");

        // A single per-cashier gate must stay blocked until the UI has either
        // cleared the committed basket or verified rollback/reconciliation.
        var gate = new CheckoutAttemptGate();
        var guarded = new Scenario();
        var guardedProgress = new CheckoutCommitProgress();
        CheckoutTransactionFinalizationService.PostAndFinalize(
            guarded, guarded.Input(), guarded, guardedProgress, gate);
        AssertEvents(guarded.Events, Stages, "guarded cash sale");
        if (!gate.IsBlocked || guardedProgress.Stage != CheckoutCommitStage.Closed)
            throw new Exception("Completed SOLDER must remain gated until basket reset");

        var duplicateClick = new Scenario();
        bool duplicateRejected = false;
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                duplicateClick, duplicateClick.Input(), duplicateClick,
                new CheckoutCommitProgress(), gate);
        }
        catch (InvalidOperationException) { duplicateRejected = true; }
        if (!duplicateRejected || duplicateClick.Events.Count != 0)
            throw new Exception("Double SOLDER click wrote stock/ticket/payment");

        bool wrongResetRejected = false;
        try { gate.ReleaseAfterBasketReset(new CheckoutCommitProgress()); }
        catch (InvalidOperationException) { wrongResetRejected = true; }
        if (!wrongResetRejected || !gate.IsBlocked)
            throw new Exception("Unrelated cashier progress unlocked active settlement");
        gate.ReleaseAfterBasketReset(guardedProgress);
        if (gate.IsBlocked)
            throw new Exception("Verified basket reset did not release cashier gate");

        // A failed precommit posting needs a verified rollback before retry.
        var precommit = new Scenario { FailAt = "payment.write.1" };
        var precommitProgress = new CheckoutCommitProgress();
        bool precommitFailed = false;
        try
        {
            CheckoutTransactionFinalizationService.PostAndFinalize(
                precommit, precommit.Input(), precommit, precommitProgress, gate);
        }
        catch (InjectedFailure) { precommitFailed = true; precommit.Rollback(); }
        if (!precommitFailed || !gate.IsBlocked ||
            precommitProgress.Stage != CheckoutCommitStage.Posting ||
            precommit.Events.Contains("commit"))
            throw new Exception("Precommit SOLDER failure must not commit or unlock");
        gate.ReleaseAfterVerifiedRollback(precommitProgress);
        if (gate.IsBlocked) throw new Exception("Verified rollback did not unlock cashier");

        // Ambiguous Commit and post-Commit Close failures cannot use the
        // precommit rollback path; they require durable ticket reconciliation.
        foreach (string failAt in new[] { "commit", "close" })
        {
            var uncertain = new Scenario { FailAt = failAt };
            var uncertainProgress = new CheckoutCommitProgress();
            bool failed = false;
            try
            {
                CheckoutTransactionFinalizationService.PostAndFinalize(
                    uncertain, uncertain.Input(), uncertain, uncertainProgress, gate);
            }
            catch (InjectedFailure) { failed = true; }
            if (!failed || !gate.IsBlocked)
                throw new Exception("Post/ambiguous commit failure unlocked SOLDER");
            bool unsafeReleaseRejected = false;
            try { gate.ReleaseAfterVerifiedRollback(uncertainProgress); }
            catch (InvalidOperationException) { unsafeReleaseRejected = true; }
            if (!unsafeReleaseRejected || !gate.IsBlocked)
                throw new Exception("Unsafe rollback unlocked a committed/ambiguous sale");
            gate.ReleaseAfterDatabaseReconciliation(uncertainProgress);
            if (gate.IsBlocked)
                throw new Exception("Verified database reconciliation did not unlock cashier");
        }

        // After reconciliation the same cashier gate can serve the next sale,
        // but a previously used progress instance still cannot be reused.
        var nextSale = new Scenario();
        var nextProgress = new CheckoutCommitProgress();
        CheckoutTransactionFinalizationService.PostAndFinalize(
            nextSale, nextSale.Input(), nextSale, nextProgress, gate);
        AssertEvents(nextSale.Events, Stages, "next sale after reconciliation");
        gate.ReleaseAfterBasketReset(nextProgress);

        Console.WriteLine("PASS checkout transaction finalization: 19 ordered stages, atomic progress, duplicate SOLDER gate, rollback/commit reconciliation and caller-owned rollback");
        return 0;
    }
}
