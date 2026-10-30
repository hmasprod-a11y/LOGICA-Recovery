using LOGICA.Domain;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.ApplicationLayer.Cash
{
    internal static class CashRecountService
    {
        public static void Recount(ICashRecountContext context)
        {
            context.ResetBackground();
            if (CashCountInputRules.ShouldReset(context.ReadSenderText))
                context.ResetSender();
            decimal total = CashDenominationTotal.Calculate(context.ReadDenomination);
            context.DisplayTotal(total);
            checked
            {
                int last = context.LastPaymentIndex;
                for (int index = 0; index <= last; index++)
                    if (Operators.ConditionalCompareObjectEqual(context.ReadPaymentMode(index), "ESPECES", false))
                        context.DisplayCashRow(index, total);
            }
        }
    }
}
