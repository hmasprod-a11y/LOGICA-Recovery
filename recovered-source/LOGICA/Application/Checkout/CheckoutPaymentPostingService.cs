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
                // The real SOLDER writer dereferences payment context and tender
                // mode when composing the SQL row. Reject missing UI-derived
                // fields before invoking that writer (and before committing).
                // Keep valid rows streaming in their original order; the Form
                // still owns rollback if a later payment fails validation.
                if (payment.Context == null)
                    throw new InvalidOperationException("Checkout payment line has no context.");
                // Validate the values consumed by the real MySQL payment writer,
                // not only the tender name. A blank DataGridView amount otherwise
                // reaches SQL after stock and ticket writes and fails opaquely.
                // Do not parse/round here: VB amount and refund semantics belong
                // to the existing writer, and the Form still owns rollback.
                switch (payment.Kind)
                {
                    case TicketPaymentKind.Cash:
                    case TicketPaymentKind.Change:
                        if (String.IsNullOrWhiteSpace(payment.AmountText))
                            throw new InvalidOperationException("Checkout cash/change payment has no amount.");
                        break;
                    case TicketPaymentKind.Tendered:
                        if (payment.Mode == null || payment.Mode == DBNull.Value ||
                            (payment.Mode is string && String.IsNullOrWhiteSpace((string)payment.Mode)))
                            throw new InvalidOperationException("Checkout tendered payment has no mode.");
                        if (payment.Amount == null || payment.Amount == DBNull.Value ||
                            (payment.Amount is string && String.IsNullOrWhiteSpace((string)payment.Amount)))
                            throw new InvalidOperationException("Checkout tendered payment has no amount.");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("payment.Kind");
                }
                store.WritePayment(payment);
            }
        }
    }
}
