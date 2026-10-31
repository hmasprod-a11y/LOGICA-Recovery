namespace LOGICA.Domain
{
    // Keep the original VB string comparison and Val() sign test at the edge.
    internal interface ILegacyCheckoutPaymentReadSemantics
    {
        int CompareOperation(string actual, string expected);
        bool IsNegativeChange(string value);
    }
}
