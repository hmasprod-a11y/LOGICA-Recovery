using System;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Keep header and journal readers lazy: journal is not read if header writing fails.
    internal static class CheckoutTicketPostingService
    {
        public static void Write(ICheckoutPostingStore store, CheckoutPostingInput input)
        {
            TicketHeaderRecord header = input.ReadHeader();
            if (header == null)
                throw new InvalidOperationException("Checkout header reader returned null.");
            store.WriteHeader(header);
            TicketJournalRecord journal = input.ReadJournal();
            if (journal == null)
                throw new InvalidOperationException("Checkout journal reader returned null.");
            store.WriteJournal(journal);
        }
    }
}
