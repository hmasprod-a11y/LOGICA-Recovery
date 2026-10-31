using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicCheckoutPaymentReadSemantics : ILegacyCheckoutPaymentReadSemantics
    {
        internal static readonly VisualBasicCheckoutPaymentReadSemantics Instance =
            new VisualBasicCheckoutPaymentReadSemantics();

        private VisualBasicCheckoutPaymentReadSemantics() { }

        public int CompareOperation(string actual, string expected)
        {
            return Operators.CompareString(actual, expected, TextCompare: false);
        }

        public bool IsNegativeChange(string value)
        {
            return Conversion.Val(value) < 0.0;
        }
    }
}
