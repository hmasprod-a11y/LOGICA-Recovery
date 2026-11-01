namespace LOGICA.ApplicationLayer.Checkout
{
    // Keep header and journal readers lazy: journal is not read if header writing fails.
    internal static class CheckoutTicketPostingService
    {
        public static void Write(ICheckoutPostingStore store, CheckoutPostingInput input)
        {
            store.WriteHeader(input.ReadHeader());
            store.WriteJournal(input.ReadJournal());
        }
    }
}
