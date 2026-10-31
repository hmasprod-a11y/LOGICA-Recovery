namespace LOGICA.Domain
{
    // Preserve .NET Framework Visual Basic conversions at the infrastructure boundary.
    internal interface ILegacyTicketPostingSemantics
    {
        string DecimalText(string value);
        string DecimalText(object value);
        object Concatenate(object left, object right);
        string ToText(object value);
    }
}
