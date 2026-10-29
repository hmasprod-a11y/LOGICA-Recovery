using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class MonetaryRounding
    {
        public static decimal Round(decimal amount)
        {
            // Preserve the legacy culture-sensitive conversion during extraction.
            return Conversions.ToDecimal(Math.Round(amount, 2, MidpointRounding.AwayFromZero).ToString("N2"));
        }
    }
}
