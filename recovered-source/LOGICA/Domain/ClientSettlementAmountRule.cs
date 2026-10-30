using Microsoft.VisualBasic;

namespace LOGICA.Domain
{
    // Characterizes the original Button12_Click guard. Do not replace Val with
    // decimal.TryParse: Val's prefix, whitespace and culture behavior is legacy POS behavior.
    internal static class ClientSettlementAmountRule
    {
        internal static bool IsRejected(string text)
        {
            return Conversion.Val(text) <= 0.0;
        }
    }
}
