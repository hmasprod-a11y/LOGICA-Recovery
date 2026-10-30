using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class CheckoutAmountGuards
    {
        public static bool IsNegativeSale(string operation, string displayedTotal)
        {
            // Keep eager evaluation and the existing culture-sensitive VB conversion.
            return (Operators.CompareString(operation, "VENTE", false) == 0)
                & (Conversions.ToDouble(displayedTotal) < 0.0);
        }

        public static bool IsPositiveReturn(string operation, string displayedTotal)
        {
            return operation.Contains("RETOUR")
                & (Conversions.ToDouble(displayedTotal) > 0.0);
        }
    }
}
