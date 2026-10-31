using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    // Preserve VB object comparisons, culture-sensitive conversions and Val behavior.
    // This is deliberately not a new payment/stock algorithm.
    internal sealed class VisualBasicCheckoutSemantics : ILegacyCheckoutSemantics
    {
        internal static readonly VisualBasicCheckoutSemantics Instance = new VisualBasicCheckoutSemantics();
        private VisualBasicCheckoutSemantics() { }

        public bool EqualsText(string left, string right)
        {
            return Operators.CompareString(left, right, false) == 0;
        }

        public double ToDouble(string value) { return Conversions.ToDouble(value); }
        public decimal ToDecimal(string value) { return Conversions.ToDecimal(value); }
        public double Val(object value) { return Conversion.Val(value); }
        public bool IsStockBelow(object availableStock, object requestedQuantity)
        {
            return Operators.ConditionalCompareObjectLess(availableStock, requestedQuantity, false);
        }
    }
}
