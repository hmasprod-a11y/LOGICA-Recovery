using LOGICA.Domain;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicCheckoutPaymentModeSemantics : ILegacyCheckoutPaymentModeSemantics
    {
        internal static readonly VisualBasicCheckoutPaymentModeSemantics Instance =
            new VisualBasicCheckoutPaymentModeSemantics();

        private VisualBasicCheckoutPaymentModeSemantics() { }

        public int CompareOperation(string actual, string expected)
        {
            return Operators.CompareString(actual, expected, TextCompare: false);
        }

        public object Concatenate(object left, object right)
        {
            return Operators.ConcatenateObject(left, right);
        }

        public object Add(object left, object right)
        {
            return Operators.AddObject(left, right);
        }

        public string ToText(object value)
        {
            return Conversions.ToString(value);
        }
    }
}
