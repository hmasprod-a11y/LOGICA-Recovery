using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Stock writes remain in the original enumeration order, with no pre-materialization.
    internal static class CheckoutStockPostingService
    {
        public static void Apply(ICheckoutPostingStore store, IEnumerable<CheckoutStockLine> lines)
        {
            foreach (CheckoutStockLine line in lines)
                store.ApplyStock(line);
        }
    }
}
