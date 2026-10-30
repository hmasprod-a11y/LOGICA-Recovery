using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class CataloguePromotionRules
    {
        public static bool IsRejected(string text)
        {
            // Keep short-circuiting, VB conversion and the legacy upper bound only.
            return Operators.CompareString(text, "", false) == 0 ||
                decimal.Compare(Conversions.ToDecimal(text), 100m) > 0;
        }
    }
}
