using System;

namespace LOGICA.ApplicationLayer.Checkout
{
    // The caller owns rollback and UI state. In particular, a failed Commit()
    // has an UNKNOWN database outcome; a failed Close() after Commit() returns
    // cannot make an already committed sale safe to retry.
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
        public CheckoutCommitStage Stage { get; internal set; }

        public bool CommitOutcomeUnknown
        {
            get { return Stage == CheckoutCommitStage.CommitAttempted; }
        }

        public bool CommitWasConfirmed
        {
            get { return Stage == CheckoutCommitStage.CommitConfirmed || Stage == CheckoutCommitStage.Closed; }
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
            if (progress.Stage != CheckoutCommitStage.NotStarted)
                throw new InvalidOperationException("Checkout commit progress cannot be reused.");

            progress.Stage = CheckoutCommitStage.Posting;
            CheckoutPostingService.Post(store, input);
            // Set BEFORE calling Commit: an exception from Commit is ambiguous.
            progress.Stage = CheckoutCommitStage.CommitAttempted;
            finalizer.Commit();
            progress.Stage = CheckoutCommitStage.CommitConfirmed;
            finalizer.Close();
            progress.Stage = CheckoutCommitStage.Closed;
        }
    }
}
