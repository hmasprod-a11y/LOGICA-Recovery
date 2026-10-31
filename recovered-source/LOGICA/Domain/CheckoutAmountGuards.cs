namespace LOGICA.Domain
{
    internal static class CheckoutAmountGuards
    {
        public static bool IsNegativeSale(string operation, string displayedTotal, ILegacyCheckoutSemantics legacy)
        {
            // '&' intentionally evaluates the numeric conversion even for non-sale operations.
            return legacy.EqualsText(operation, "VENTE") & (legacy.ToDouble(displayedTotal) < 0.0);
        }

        public static bool IsPositiveReturn(string operation, string displayedTotal, ILegacyCheckoutSemantics legacy)
        {
            // Contains executes before ToDouble; preserve null exception timing and eager '&'.
            return operation.Contains("RETOUR") & (legacy.ToDouble(displayedTotal) > 0.0);
        }
    }
}
