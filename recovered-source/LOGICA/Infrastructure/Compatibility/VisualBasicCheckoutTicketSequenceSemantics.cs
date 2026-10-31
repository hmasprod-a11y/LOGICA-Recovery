using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicCheckoutTicketSequenceSemantics : ILegacyCheckoutTicketSequenceSemantics
    {
        internal static readonly VisualBasicCheckoutTicketSequenceSemantics Instance =
            new VisualBasicCheckoutTicketSequenceSemantics();

        private VisualBasicCheckoutTicketSequenceSemantics() { }

        public string ZeroText() { return Conversions.ToString(0); }
        public double ToDouble(object value) { return Conversions.ToDouble(value); }
        public string FormatSequence(double value) { return Strings.Format(value, "000000"); }
    }
}
