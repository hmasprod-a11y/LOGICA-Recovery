namespace LOGICA.Domain
{
    internal static class CataloguePromotionRules
    {
        public static bool IsRejected(string text, ILegacyCatalogueSemantics semantics)
        {
            // Preserve short-circuiting before the original decimal conversion.
            return semantics.EqualsText(text, "") ||
                decimal.Compare(semantics.ToDecimal(text), 100m) > 0;
        }
    }
}
