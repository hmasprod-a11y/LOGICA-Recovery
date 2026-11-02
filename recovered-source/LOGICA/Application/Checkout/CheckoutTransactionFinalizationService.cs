using System;
using System.Threading;

namespace LOGICA.ApplicationLayer.Checkout
{
    // A failed Commit has an UNKNOWN DB outcome; a failed Close after Commit
    // returns cannot make an already committed sale safe to retry.
    internal enum CheckoutCommitStage
    {
        NotStarted,
        Posting,
        CommitAttempted,
        CommitConfirmed,
        Closed
    }

    internal sealed class CheckoutCommitProgress
    {
        // Atomic start also guards against concurrent/reentrant calls that
        // accidentally share one progress object.
        private int stage;

        public CheckoutCommitStage Stage
        {
            get { return (CheckoutCommitStage)Interlocked.CompareExchange(ref stage, 0, 0); }
        }

        internal bool TryStart()
        {
            return Interlocked.CompareExchange(ref stage,
                (int)CheckoutCommitStage.Posting, (int)CheckoutCommitStage.NotStarted)
                == (int)CheckoutCommitStage.NotStarted;
        }

        internal void Advance(CheckoutCommitStage next)
        {
            Interlocked.Exchange(ref stage, (int)next);
        }

        public bool CommitOutcomeUnknown
        {
            get { return Stage == CheckoutCommitStage.CommitAttempted; }
        }

        public bool CommitWasConfirmed
        {
            get { return Stage == CheckoutCommitStage.CommitConfirmed || Stage == CheckoutCommitStage.Closed; }
        }
    }

    // Opt-in per-cashier SOLDER gate. Keep ONE instance for the lifetime of
    // the sales form; a fresh gate per click cannot prevent duplicate clicks.
    // In-memory protection only: durable DB idempotency remains unproven.
    internal sealed class CheckoutAttemptGate
    {
        private CheckoutCommitProgress active;

        public bool IsBlocked
        {
            get { return Interlocked.CompareExchange(ref active, null, null) != null; }
        }

        internal bool TryBegin(CheckoutCommitProgress progress)
        {
            if (progress == null) throw new ArgumentNullException("progress");
            if (progress.Stage != CheckoutCommitStage.NotStarted)
                throw new InvalidOperationException("Checkout commit progress cannot be reused.");
            return Interlocked.CompareExchange(ref active, progress, null) == null;
        }

        private void Release(CheckoutCommitProgress progress, bool valid)
        {
            if (progress == null) throw new ArgumentNullException("progress");
            if (!valid)
                throw new InvalidOperationException("Checkout attempt outcome has not been reconciled.");
            if (Interlocked.CompareExchange(ref active, null, progress) != progress)
                throw new InvalidOperationException("Checkout attempt is not active on this cashier.");
        }

        // Call ONLY after the Form has verified rollback succeeded.
        public void ReleaseAfterVerifiedRollback(CheckoutCommitProgress progress)
        {
            Release(progress, progress != null && progress.Stage == CheckoutCommitStage.Posting);
        }

        // Call ONLY after successful settlement and basket/UI reset.
        public void ReleaseAfterBasketReset(CheckoutCommitProgress progress)
        {
            Release(progress, progress != null && progress.Stage == CheckoutCommitStage.Closed);
        }

        // For failed Commit or failed Close after Commit: the caller must
        // inspect the durable ticket and reconcile the UI before releasing.
        public void ReleaseAfterDatabaseReconciliation(CheckoutCommitProgress progress)
        {
            Release(progress, progress != null &&
                (progress.CommitOutcomeUnknown ||
                 progress.Stage == CheckoutCommitStage.CommitConfirmed));
        }
    }

    // Transaction creation and error/rollback handling remain in the original Form.
    // Only the successful post -> commit -> close sequence is moved here.
    internal interface ICheckoutTransactionFinalizer
    {
        void Commit();
        void Close();
    }

    internal static class CheckoutTransactionFinalizationService
    {
        // Opt-in overload: duplicate SOLDER invocations fail before posting.
        // A gate stays blocked until the UI explicitly reconciles its outcome.
        public static void PostAndFinalize(
            ICheckoutPostingStore store,
            CheckoutPostingInput input,
            ICheckoutTransactionFinalizer finalizer,
            CheckoutCommitProgress progress,
            CheckoutAttemptGate gate)
        {
            if (finalizer == null) throw new ArgumentNullException("finalizer");
            if (gate == null) throw new ArgumentNullException("gate");
            if (!gate.TryBegin(progress))
                throw new InvalidOperationException("A checkout attempt is already awaiting reconciliation.");
            PostAndFinalize(store, input, finalizer, progress);
        }

        public static void PostAndFinalize(
            ICheckoutPostingStore store,
            CheckoutPostingInput input,
            ICheckoutTransactionFinalizer finalizer)
        {
            // Preserve the existing WinForms entry point and exception behavior.
            PostAndFinalize(store, input, finalizer, new CheckoutCommitProgress());
        }

        // Opt-in progress for Desktop/QA. This does NOT retry, rollback or
        // swallow errors; it only records which side of Commit an error occurred.
        // Use a fresh progress object for each SOLDER attempt.
        public static void PostAndFinalize(
            ICheckoutPostingStore store,
            CheckoutPostingInput input,
            ICheckoutTransactionFinalizer finalizer,
            CheckoutCommitProgress progress)
        {
            // Missing finalizer/progress and reused attempts must fail before
            // stock/ticket/payment side effects.
            if (finalizer == null) throw new ArgumentNullException("finalizer");
            if (progress == null) throw new ArgumentNullException("progress");
            if (!progress.TryStart())
                throw new InvalidOperationException("Checkout commit progress cannot be reused.");

            CheckoutPostingService.Post(store, input);
            // Set BEFORE calling Commit: an exception from Commit is ambiguous.
            progress.Advance(CheckoutCommitStage.CommitAttempted);
            finalizer.Commit();
            progress.Advance(CheckoutCommitStage.CommitConfirmed);
            finalizer.Close();
            progress.Advance(CheckoutCommitStage.Closed);
        }
    }
}
