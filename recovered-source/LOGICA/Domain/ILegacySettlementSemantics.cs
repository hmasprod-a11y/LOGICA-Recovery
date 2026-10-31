namespace LOGICA.Domain
{
    // A port for the recovered POS' VB numeric and empty-field behavior.
    // Business rules depend on this contract, never on Microsoft.VisualBasic.
    internal interface ILegacySettlementSemantics
    {
        bool IsEmpty(string value);
        double ParseAmount(string value);
        double ToDouble(object value);
    }
}
