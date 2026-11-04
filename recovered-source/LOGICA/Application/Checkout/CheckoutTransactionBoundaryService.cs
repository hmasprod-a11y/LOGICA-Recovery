namespace LOGICA.ApplicationLayer.Checkout
{
    // This contract only mirrors the existing Form's transaction calls.
    // It deliberately does not own exception handling or automatic rollback.
    internal interface ICheckoutTransactionBoundary
    {
        bool IsOpen { get; }
        void Open();
        void BeginAndBind();
        void Commit();
        void Close();
        void Rollback();
    }

    internal static class CheckoutTransactionBoundaryService
    {
        // The caller must invoke Begin before its original try block.
        // Failure in Open/Begin is intentionally not caught here.
        internal static void Begin(ICheckoutTransactionBoundary boundary)
        {
            if (!boundary.IsOpen)
                boundary.Open();
            boundary.BeginAndBind();
        }

        // Used by the waiting-ticket flow; do not add a finally/close on failure.
        internal static void CommitAndClose(ICheckoutTransactionBoundary boundary)
        {
            boundary.Commit();
            boundary.Close();
        }

        // The original catch decides when to roll back, including after a
        // failed Commit or Close. Preserve the exception if rollback itself fails.
        internal static void Rollback(ICheckoutTransactionBoundary boundary)
        {
            boundary.Rollback();
        }
    }
    // Shared production transaction seam for an offline durable operation ledger.
    // The infrastructure implementation MUST enforce a UNIQUE operation ID in the
    // SAME MariaDB transaction as ticket, payment and stock writes. A false claim
    // means an already persisted operation; it is never silently re-posted.
    internal interface ICheckoutAtomicPostingBoundary : ICheckoutTransactionBoundary, ICheckoutPostingStore
    {
        bool TryClaimOperation(string operationId);
    }

    internal enum CheckoutAtomicPostingResult { Committed, AlreadyCommitted }

    internal static class CheckoutAtomicPostingService
    {
        // Uses the exact production posting order, rather than a second money
        // calculator or independent stock/payment writer. Printing is still the
        // legacy callback: callers must provide a transaction-safe receipt
        // staging callback, not a physical printer side effect before Commit.
        internal static CheckoutAtomicPostingResult Execute(
            ICheckoutAtomicPostingBoundary boundary, CheckoutPostingInput input,
            string operationId, CheckoutCommitProgress progress)
        {
            if (boundary == null) throw new System.ArgumentNullException("boundary");
            if (progress == null) throw new System.ArgumentNullException("progress");
            if (string.IsNullOrWhiteSpace(operationId))
                throw new System.ArgumentException("Durable operation ID is required.", "operationId");
            if (progress.Stage != CheckoutCommitStage.NotStarted)
                throw new System.InvalidOperationException("Checkout progress cannot be reused.");
            CheckoutPostingService.Validate(boundary, input);
            if (!progress.TryStart())
                throw new System.InvalidOperationException("Checkout progress cannot be reused.");

            bool begun = false;
            try
            {
                // Mark ownership before Begin: BeginAndBind can fail after a
                // transaction has started. Such a failure must attempt rollback.
                begun = true;
                CheckoutTransactionBoundaryService.Begin(boundary);
                if (!boundary.TryClaimOperation(operationId))
                {
                    // The durable claim is a duplicate. Roll back the transaction
                    // and close it; a rollback/close failure is NOT a confirmed
                    // duplicate and must never authorize an automatic retry.
                    boundary.Rollback();
                    begun = false;
                    boundary.Close();
                    progress.Advance(CheckoutCommitStage.Closed);
                    return CheckoutAtomicPostingResult.AlreadyCommitted;
                }

                CheckoutPostingService.Post(boundary, input);
                // Commit failures are ambiguous: do not issue blind retry or
                // declare rollback successful. Reconcile the durable ledger.
                progress.Advance(CheckoutCommitStage.CommitAttempted);
                boundary.Commit();
                progress.Advance(CheckoutCommitStage.CommitConfirmed);
                begun = false;
                boundary.Close();
                progress.Advance(CheckoutCommitStage.Closed);
                return CheckoutAtomicPostingResult.Committed;
            }
            catch
            {
                if (begun && progress.Stage == CheckoutCommitStage.Posting)
                {
                    // Keep the original error when rollback succeeds. A failed
                    // rollback propagates as failure and must be investigated.
                    boundary.Rollback();
                }
                throw;
            }
        }
    }

}
