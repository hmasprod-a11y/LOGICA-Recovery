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
                throw new NullReferenceException("Checkout payment reader returned no collection.");
            foreach (TicketPaymentWrite payment in payments)
            {
                if (payment == null)
                    throw new InvalidOperationException("Checkout payment reader returned a null line.");
                // The real SOLDER writer dereferences payment context and tender
                // mode when composing the SQL row. Reject missing UI-derived
                // fields before invoking that writer (and before committing).
                // Keep valid rows streaming in their original order; the Form
                // still owns rollback if a later payment fails validation.
                if (payment.Context == null)
                    throw new InvalidOperationException("Checkout payment line has no context.");
                if (payment.Kind == TicketPaymentKind.Tendered && payment.Mode == null)
                    throw new InvalidOperationException("Checkout tendered payment has no mode.");
                store.WritePayment(payment);
            }
        }
    }
}
