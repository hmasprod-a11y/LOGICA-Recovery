using System;
using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicClientSearchSemantics : ILegacyClientSearchSemantics
    {
        internal static readonly VisualBasicClientSearchSemantics Instance = new VisualBasicClientSearchSemantics();
        private VisualBasicClientSearchSemantics() { }
        public bool EqualsText(string left, string right) { return Operators.CompareString(left, right, false) == 0; }
        public string FormatDate(DateTime date) { return Strings.Format(date, "yyyy-MM-dd"); }
        public object Concat(object left, object right) { return Operators.ConcatenateObject(left, right); }
        public string ToText(object value) { return Conversions.ToString(value); }
    }
}
