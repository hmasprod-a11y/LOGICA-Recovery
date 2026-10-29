using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Presentation.Input
{
    internal static class NumericEntryFilter
    {
        public static bool ShouldBlock(char keyChar)
        {
            // Preserve the original character policy; this is not complete-number validation.
            return ((Operators.CompareString(Conversions.ToString(keyChar), "0", false) < 0)
                | (Operators.CompareString(Conversions.ToString(keyChar), "9", false) > 0))
                & (keyChar != '\b') & (keyChar != '.') & (keyChar != '-');
        }
    }
}
