using System;

namespace LOGICA.Domain
{
    internal static class CashCountInputRules
    {
        public static bool ShouldReset(Func<object> readText, ILegacyCashSemantics semantics)
        {
            // Eager OR and two separate reads are deliberate legacy behavior.
            return semantics.IsTrimmedEmpty(readText()) | !semantics.IsNumeric(readText());
        }
    }
}
