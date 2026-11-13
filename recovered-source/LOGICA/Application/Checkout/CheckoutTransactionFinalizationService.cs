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

    // A UI recovery decision, not an authorization to retry. The cashier
    // must still verify rollback, durable ticket state, or basket reset.
    internal enum CheckoutAttemptRecoveryAction
    {
        None,
        VerifyRollback,
        ReconcileDatabase,
        ResetBasket
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

        // Single source of truth for the Desktop/QA error path. A failed
        // Commit is UNKNOWN, and a failed Close follows a confirmed Commit:
        // neither may clear the basket or retry without DB reconciliation.
        public CheckoutAttemptRecoveryAction RecoveryAction
        {
            get
            {
                switch (Stage)
                {
                    case CheckoutCommitStage.Posting:
                        return CheckoutAttemptRecoveryAction.VerifyRollback;
                    case CheckoutCommitStage.CommitAttempted:
                    case CheckoutCommitStage.CommitConfirmed:
                        return CheckoutAttemptRecoveryAction.ReconcileDatabase;
                    case CheckoutCommitStage.Closed:
                        return CheckoutAttemptRecoveryAction.ResetBasket;
                    default:
                        return CheckoutAttemptRecoveryAction.None;
                }
            }
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
            if (Interlocked.CompareExchange(ref active, progress, null) != null)
                return false;
            // Claim the progress token while this gate is held. Two cashier
            // gates can otherwise accept the same token concurrently; the
            // losing invocation would fail after reserving its gate forever.
            if (!progress.TryStart())
            {
                // This gate has not invoked any posting callback. Only this
                // failed reservation may be released without DB reconciliation.
                Interlocked.CompareExchange(ref active, null, progress);
                throw new InvalidOperationException("Checkout commit progress cannot be reused.");
            }
            return true;
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
            Release(progress, progress != null &&
                progress.RecoveryAction == CheckoutAttemptRecoveryAction.VerifyRollback);
        }

        // Call ONLY after successful settlement and basket/UI reset.
        public void ReleaseAfterBasketReset(CheckoutCommitProgress progress)
        {
            Release(progress, progress != null &&
                progress.RecoveryAction == CheckoutAttemptRecoveryAction.ResetBasket);
        }

        // For failed Commit or failed Close after Commit: the caller must
        // inspect the durable ticket and reconcile the UI before releasing.
        public void ReleaseAfterDatabaseReconciliation(CheckoutCommitProgress progress)
        {
            Release(progress, progress != null &&
                progress.RecoveryAction == CheckoutAttemptRecoveryAction.ReconcileDatabase);
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
            if (progress == null) throw new ArgumentNullException("progress");
            if (progress.Stage != CheckoutCommitStage.NotStarted)
                throw new InvalidOperationException("Checkout commit progress cannot be reused.");
            // Validate all required callbacks BEFORE taking the persistent gate.
            // An invalid Form payload has performed no DB work and must not
            // require a fictitious rollback to unlock the next cashier attempt.
            CheckoutPostingService.Validate(store, input);
            if (!gate.TryBegin(progress))
                throw new InvalidOperationException("A checkout attempt is already awaiting reconciliation.");
            // TryBegin has atomically claimed both the cashier gate and
            // progress. Do not try to claim the same progress a second time.
            PostStartedAndFinalize(store, input, finalizer, progress);
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
            // A malformed legacy/ungated call must not consume its progress
            // token before any database callback has run. The gated overload
            // already validates before acquiring its per-cashier gate.
            // Validation is pure: no lazy reader is evaluated here.
            // Preserve the original precedence for a reused progress token,
            // while TryStart remains the atomic concurrency check.
            if (progress.Stage != CheckoutCommitStage.NotStarted)
                throw new InvalidOperationException("Checkout commit progress cannot be reused.");
            CheckoutPostingService.Validate(store, input);
            if (!progress.TryStart())
                throw new InvalidOperationException("Checkout commit progress cannot be reused.");
            PostStartedAndFinalize(store, input, finalizer, progress);
        }

        // Both the gated and legacy paths run the exact same production
        // posting/commit sequence once their progress token has been claimed.
        private static void PostStartedAndFinalize(
            ICheckoutPostingStore store,
            CheckoutPostingInput input,
            ICheckoutTransactionFinalizer finalizer,
            CheckoutCommitProgress progress)
        {
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
