using System;
using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicStockMovementQuerySemantics : ILegacyStockMovementQuerySemantics
    {
        internal static readonly VisualBasicStockMovementQuerySemantics Instance =
            new VisualBasicStockMovementQuerySemantics();

        private VisualBasicStockMovementQuerySemantics() { }
        public string FormatDate(DateTime value) { return Strings.Format(value, "yyyy-MM-dd"); }
        public object Concat(object left, object right) { return Operators.ConcatenateObject(left, right); }
        public string ToText(object value) { return Conversions.ToString(value); }
    }
}
