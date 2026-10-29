namespace LOGICA.ApplicationLayer.Checkout
{
    internal interface ICheckoutDocumentStore
    {
        void WriteHeader(TicketHeaderRecord header);
        void WriteJournal(TicketJournalRecord journal);
        void WritePayment(TicketPaymentWrite payment);
        void Complete(CheckoutCompletionRecord completion);
    }

    internal static class CheckoutPostingService
    {
        // Transaction ownership and rollback stay with the existing caller.
        public static void Post(ICheckoutDocumentStore store, CheckoutPostingInput input)
        {
            store.WriteHeader(input.ReadHeader());
            store.WriteJournal(input.ReadJournal());
            foreach (TicketPaymentWrite payment in input.ReadPayments())
                store.WritePayment(payment);
            input.Print();
            store.Complete(input.ReadCompletion());
        }
    }
}
