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
        // Pure preflight shared by the legacy entry point and the opt-in
        // per-cashier gate. A malformed attempt must not acquire the gate and
        // strand a cashier before any transaction callback was invoked.
        // Never call the readers here: their lazy order is part of POS behavior.
        internal static void Validate(ICheckoutPostingStore store, CheckoutPostingInput input)
        {
            if (store == null) throw new ArgumentNullException("store");
            if (input == null) throw new ArgumentNullException("input");
            if (input.ReadStock == null || input.ReadHeader == null ||
                input.ReadJournal == null || input.ReadPayments == null ||
                input.Print == null || input.ReadCompletion == null)
                throw new InvalidOperationException(
                    "Checkout posting requires all callbacks before stock writes.");
        }

        // Transaction ownership and rollback stay with the existing caller.
        public static void Post(ICheckoutPostingStore store, CheckoutPostingInput input)
        {
            Validate(store, input);
            CheckoutStockPostingService.Apply(store, input.ReadStock());
            CheckoutTicketPostingService.Write(store, input);
            CheckoutPaymentPostingService.Write(store, input.ReadPayments());
            input.Print();
            CheckoutCompletionRecord completion = input.ReadCompletion();
            if (completion == null)
                throw new InvalidOperationException("Checkout completion reader returned null.");
            store.Complete(completion);
        }
    }
}
