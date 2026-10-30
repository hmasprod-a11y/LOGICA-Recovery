using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class StockAvailability
    {
        public static bool IsBelowRequested(object availableStock, object requestedQuantity)
        {
            // Preserve VB object comparison; coercing everything to decimal would change behavior.
            return Operators.ConditionalCompareObjectLess(availableStock, requestedQuantity, false);
        }
    }
}
