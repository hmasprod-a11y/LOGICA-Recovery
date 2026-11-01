namespace LOGICA.Domain
{
    // Retain Visual Basic comparison and object-addition behavior without a
    // Microsoft.VisualBasic reference in the portable application service.
    internal interface ILegacyCheckoutPaymentModeSemantics
    {
        int CompareOperation(string actual, string expected);
        object Concatenate(object left, object right);
        object Add(object left, object right);
        string ToText(object value);
    }
}
