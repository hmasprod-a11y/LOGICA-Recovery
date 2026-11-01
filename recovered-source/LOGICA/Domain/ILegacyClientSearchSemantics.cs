using System;

namespace LOGICA.Domain
{
    // Compatibility contract: original binary VB comparisons, date formatting and late object concatenation.
    internal interface ILegacyClientSearchSemantics
    {
        bool EqualsText(string left, string right);
        string FormatDate(DateTime date);
        object Concat(object left, object right);
        string ToText(object value);
    }
}
