namespace LOGICA.ApplicationLayer.Checkout
{
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
            CheckoutPostingService.Post(store, input);
            finalizer.Commit();
            finalizer.Close();
        }
    }
}
