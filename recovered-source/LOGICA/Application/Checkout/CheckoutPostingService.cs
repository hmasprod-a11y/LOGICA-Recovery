using System;

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
            // Check callback presence before the first stock mutation. Do not invoke
            // readers early: the legacy form depends on their original order.
            if (store == null) throw new ArgumentNullException("store");
            if (input == null) throw new ArgumentNullException("input");
            if (input.ReadStock == null || input.ReadHeader == null ||
                input.ReadJournal == null || input.ReadPayments == null ||
                input.Print == null || input.ReadCompletion == null)
                throw new InvalidOperationException(
                    "Checkout posting requires all callbacks before stock writes.");
            CheckoutStockPostingService.Apply(store, input.ReadStock());
            CheckoutTicketPostingService.Write(store, input);
            CheckoutPaymentPostingService.Write(store, input.ReadPayments());
            input.Print();
            store.Complete(input.ReadCompletion());
        }
    }
}
