using System;

namespace LOGICA.Domain
{
    internal static class BasketTotalConsistency
    {
        public static bool AreDifferent(decimal basketTotal, string displayedTotal, ILegacyCheckoutSemantics legacy)
        {
            // Preserve culture-sensitive ToString, conversion, midpoint rounding, Val and order.
            return legacy.Val(Math.Round(legacy.ToDecimal(basketTotal.ToString())))
                != legacy.Val(Math.Round(legacy.ToDecimal(displayedTotal)));
        }
    }
}
