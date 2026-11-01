namespace LOGICA.Domain
{
    internal static class CheckoutSelectionRules
    {
        public static bool IsMissing(string displayName, ILegacyCheckoutSemantics legacy)
        {
            // Whitespace is not empty; VB null/empty equality is delegated to the adapter.
            return legacy.EqualsText(displayName, "");
        }
    }
}
