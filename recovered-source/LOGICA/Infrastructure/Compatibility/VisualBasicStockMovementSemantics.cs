using LOGICA.Domain;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Compatibility
{
    internal sealed class VisualBasicStockMovementSemantics : ILegacyStockMovementSemantics
    {
        internal static readonly VisualBasicStockMovementSemantics Instance = new VisualBasicStockMovementSemantics();
        private VisualBasicStockMovementSemantics() { }

        public bool EqualsText(string left, string right)
        {
            return Operators.CompareString(left, right, false) == 0;
        }
    }
}
