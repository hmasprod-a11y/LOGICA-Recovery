using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicCatalogueSemantics : ILegacyCatalogueSemantics
    {
        internal static readonly VisualBasicCatalogueSemantics Instance = new VisualBasicCatalogueSemantics();
        private VisualBasicCatalogueSemantics() { }
        public string Trim(string value) { return Strings.Trim(value); }
        public string FormatNumber(string value) { return Strings.FormatNumber(value); }
        public double ToMinimumQuantity(string value) { return Conversion.Val(value); }
        public bool EqualsText(string left, string right) { return Operators.CompareString(left, right, false) == 0; }
        public decimal ToDecimal(string value) { return Conversions.ToDecimal(value); }
        public int ToDigit(string value) { return Conversions.ToInteger(value); }
    }
}
