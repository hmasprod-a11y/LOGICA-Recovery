using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicCheckoutCompletionSemantics : ILegacyCheckoutCompletionSemantics
    {
        internal static readonly VisualBasicCheckoutCompletionSemantics Instance =
            new VisualBasicCheckoutCompletionSemantics();

        private VisualBasicCheckoutCompletionSemantics() { }
        public double ToDouble(string text) { return Conversions.ToDouble(text); }
        public string FormatSequence(double next) { return Strings.Format(next, "000000"); }
    }
}
