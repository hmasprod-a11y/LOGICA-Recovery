namespace LOGICA.ApplicationLayer.Checkout
{
    internal interface ICheckoutPostingStore
    {
        void ApplyStock(CheckoutStockLine line);
        void WriteHeader(TicketHeaderRecord header);
        void WriteJournal(TicketJournalRecord journal);
        void WritePayment(TicketPaymentWrite payment);
        void Complete(CheckoutCompletionRecord completion);
    }

    internal static class CheckoutPostingService
    {
        // Transaction ownership and rollback stay with the existing caller.
        public static void Post(ICheckoutPostingStore store, CheckoutPostingInput input)
        {
            CheckoutStockPostingService.Apply(store, input.ReadStock());
            CheckoutTicketPostingService.Write(store, input);
            CheckoutPaymentPostingService.Write(store, input.ReadPayments());
            input.Print();
            store.Complete(input.ReadCompletion());
        }
    }
}
