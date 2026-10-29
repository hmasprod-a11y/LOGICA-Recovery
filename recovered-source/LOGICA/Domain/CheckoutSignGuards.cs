using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    // Preserve the original Button_Click operation-text matching and eager VB '&' evaluation.
    internal static class CheckoutSignGuards
    {
        public static bool RejectSale(string operation, double displayedTotal)
        {
            return (Operators.CompareString(operation, "VENTE", false) == 0) & (displayedTotal < 0.0);
        }

        public static bool RejectReturn(string operation, double displayedTotal)
        {
            return operation.Contains("RETOUR") & (displayedTotal > 0.0);
        }
    }
}
