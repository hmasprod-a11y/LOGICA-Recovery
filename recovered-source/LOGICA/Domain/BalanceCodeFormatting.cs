using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class BalanceCodeFormatting
    {
        public static bool IsNumeric(string code) { return Versioned.IsNumeric(code); }

        public static string Format(string requestedWidth, Func<string> readCode)
        {
            // Read code only after the legacy checked width conversion succeeds.
            int width = checked((int)Math.Round(Conversion.Val(requestedWidth)));
            return Conversion.Val(readCode()).ToString(Strings.StrDup(width, "0"));
        }
    }
}
