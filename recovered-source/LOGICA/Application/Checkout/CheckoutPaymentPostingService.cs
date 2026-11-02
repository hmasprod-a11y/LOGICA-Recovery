using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Preserve per-payment writes and exceptions, without buffering or reordering.
    internal static class CheckoutPaymentPostingService
    {
        public static void Write(ICheckoutPostingStore store, IEnumerable<TicketPaymentWrite> payments)
        {
            if (payments == null)
                throw new InvalidOperationException("Checkout payment reader returned no collection.");
            foreach (TicketPaymentWrite payment in payments)
            {
                if (payment == null)
                    throw new InvalidOperationException("Checkout payment reader returned a null line.");
                store.WritePayment(payment);
            }
        }
    }
}
