using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Preserve per-payment writes and exceptions, without buffering or reordering.
    internal static class CheckoutPaymentPostingService
    {
        public static void Write(ICheckoutPostingStore store, IEnumerable<TicketPaymentWrite> payments)
        {
            foreach (TicketPaymentWrite payment in payments)
                store.WritePayment(payment);
        }
    }
}
