using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Stock writes remain in the original enumeration order, with no pre-materialization.
    internal static class CheckoutStockPostingService
    {
        public static void Apply(ICheckoutPostingStore store, IEnumerable<CheckoutStockLine> lines)
        {
            if (lines == null)
                throw new InvalidOperationException("Checkout stock reader returned no collection.");
            foreach (CheckoutStockLine line in lines)
            {
                if (line == null)
                    throw new InvalidOperationException("Checkout stock reader returned a null line.");
                store.ApplyStock(line);
            }
        }
    }
}
