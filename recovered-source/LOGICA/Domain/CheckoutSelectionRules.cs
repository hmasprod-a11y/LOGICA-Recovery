using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class CheckoutSelectionRules
    {
        public static bool IsMissing(string displayName)
        {
            // Preserve the legacy empty comparison; whitespace is not treated as empty.
            return Operators.CompareString(displayName, "", false) == 0;
        }
    }
}
