using System.Runtime.CompilerServices;
using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    // Legacy compatibility belongs to Infrastructure, not cash business logic.
    internal sealed class VisualBasicCashSemantics : ILegacyCashSemantics
    {
        internal static readonly VisualBasicCashSemantics Instance = new VisualBasicCashSemantics();
        private VisualBasicCashSemantics() { }

        public bool IsTrimmedEmpty(object text)
        {
            return Operators.CompareString(Strings.Trim(Conversions.ToString(text)), "", false) == 0;
        }

        public bool IsNumeric(object value)
        {
            return Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(value));
        }

        public decimal ToDecimal(string text)
        {
            return Conversions.ToDecimal(text);
        }

        public bool IsCashPaymentMode(object value)
        {
            return Operators.ConditionalCompareObjectEqual(value, "ESPECES", false);
        }
    }
}
