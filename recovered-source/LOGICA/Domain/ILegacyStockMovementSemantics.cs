namespace LOGICA.Domain
{
    // Compatibility boundary for the recovered POS' binary VB string comparisons.
    // Do not replace with Trim or case-insensitive search: "DATES" is exact.
    internal interface ILegacyStockMovementSemantics
    {
        bool EqualsText(string left, string right);
    }
}
