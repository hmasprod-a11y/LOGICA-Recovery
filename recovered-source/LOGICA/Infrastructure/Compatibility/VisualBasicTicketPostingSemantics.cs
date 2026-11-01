using LOGICA.Domain;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicTicketPostingSemantics : ILegacyTicketPostingSemantics
    {
        internal static readonly VisualBasicTicketPostingSemantics Instance =
            new VisualBasicTicketPostingSemantics();

        private VisualBasicTicketPostingSemantics() { }
        public string DecimalText(string value) { return Conversions.ToString(Conversions.ToDecimal(value)); }
        public string DecimalText(object value) { return Conversions.ToString(Conversions.ToDecimal(value)); }
        public object Concatenate(object left, object right) { return Operators.ConcatenateObject(left, right); }
        public string ToText(object value) { return Conversions.ToString(value); }
    }
}
