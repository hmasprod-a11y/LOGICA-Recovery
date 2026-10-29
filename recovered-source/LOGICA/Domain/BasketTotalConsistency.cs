using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class BasketTotalConsistency
    {
        public static bool AreDifferent(decimal basketTotal, string displayedTotal)
        {
            // Preserve the original whole-unit rounding and VB culture/conversion path.
            return Conversion.Val(Math.Round(Conversions.ToDecimal(basketTotal.ToString())))
                != Conversion.Val(Math.Round(Conversions.ToDecimal(displayedTotal)));
        }
    }
}
