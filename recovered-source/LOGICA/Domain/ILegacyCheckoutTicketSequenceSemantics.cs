namespace LOGICA.Domain
{
    // Preserve the original VB conversions for the ticket counter, not an invariant-culture replacement.
    internal interface ILegacyCheckoutTicketSequenceSemantics
    {
        string ZeroText();
        double ToDouble(object value);
        string FormatSequence(double value);
    }
}
