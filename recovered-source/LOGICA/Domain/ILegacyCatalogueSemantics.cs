namespace LOGICA.Domain
{
    // Keep VB-specific catalogue conversions outside Domain/Application.
    internal interface ILegacyCatalogueSemantics
    {
        string Trim(string value);
        string FormatNumber(string value);
        double ToMinimumQuantity(string value);
        bool EqualsText(string left, string right);
        decimal ToDecimal(string value);
    }
}
