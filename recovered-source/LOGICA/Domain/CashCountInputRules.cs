using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class CashCountInputRules
    {
        public static bool ShouldReset(Func<object> readText)
        {
            // Keep both reads and eager OR; empty text must still evaluate numeric detection.
            return (Operators.CompareString(Strings.Trim(Conversions.ToString(readText())), "", false) == 0) |
                !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(readText()));
        }
    }
}
