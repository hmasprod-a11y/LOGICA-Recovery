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
}
