namespace LOGICA.Domain
{
    internal static class CatalogueRequiredFields
    {
        public static bool IsMissingIdentifier(string value, ILegacyCatalogueSemantics semantics)
        {
            return semantics.EqualsText(semantics.Trim(value), "");
        }
    }
}
