using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Cash
{
    internal static class CashRecountService
    {
        public static void Recount(ICashRecountContext context, ILegacyCashSemantics semantics)
        {
            context.ResetBackground();
            if (CashCountInputRules.ShouldReset(context.ReadSenderText, semantics))
                context.ResetSender();
            decimal total = CashDenominationTotal.Calculate(context.ReadDenomination, semantics);
            context.DisplayTotal(total);
            checked
            {
                int last = context.LastPaymentIndex;
                for (int index = 0; index <= last; index++)
                    if (semantics.IsCashPaymentMode(context.ReadPaymentMode(index)))
                        context.DisplayCashRow(index, total);
            }
        }
    }
}
