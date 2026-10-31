using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    // Infrastructure adapter: preserve exact recovered VB behavior, including
    // culture, numeric prefixes, exception types and DBNull conversion.
    // Do not replace with decimal.TryParse or Convert.ToDouble without parity tests.
    internal sealed class VisualBasicSettlementSemantics : ILegacySettlementSemantics
    {
        internal static readonly VisualBasicSettlementSemantics Instance = new VisualBasicSettlementSemantics();

        private VisualBasicSettlementSemantics() { }

        public bool IsEmpty(string value)
        {
            return Operators.CompareString(value, "", false) == 0;
        }

        public double ParseAmount(string value)
        {
            return Conversion.Val(value);
        }

        public double ToDouble(object value)
        {
            return Conversions.ToDouble(value);
        }
    }
}
