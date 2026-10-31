namespace LOGICA.Domain
{
    // Preserve recovered cash-count coercion behind a boundary independent of UI and VB.
    internal interface ILegacyCashSemantics
    {
        bool IsTrimmedEmpty(object text);
        bool IsNumeric(object value);
        decimal ToDecimal(string text);
        bool IsCashPaymentMode(object value);
    }
}
