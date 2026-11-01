using System;
using System.Collections.Generic;
using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Streaming projection of the sale/refund payment grid. Do not buffer rows:
    // the original Form evaluates UI fields only as each item is enumerated.
    internal static class CheckoutPaymentReadService
    {
        internal static IEnumerable<TicketPaymentWrite> Read(
            Func<string> readOperation,
            Func<TicketPaymentContext> readContext,
            Func<bool> readAccessModesEnabled,
            Func<int> readModeRowCount,
            Func<int, object> readPaidAmountAt,
            Func<int, object> readModeAt,
            Func<string> readCashTotal,
            Func<string> readChangeAmount,
            ILegacyCheckoutPaymentReadSemantics semantics)
        {
            checked
            {
                if (semantics.CompareOperation(readOperation(), "VENTE") == 0 ||
                    semantics.CompareOperation(readOperation(), "RETOUR REMBOURSEMENT") == 0)
                {
                    TicketPaymentContext context = readContext();
                    if (!readAccessModesEnabled())
                    {
                        yield return new TicketPaymentWrite
                        {
                            Kind = TicketPaymentKind.Cash,
                            Context = context,
                            AmountText = readCashTotal()
                        };
                    }
                    else if (readAccessModesEnabled())
                    {
                        int lastRow = readModeRowCount() - 1;
                        int index = 0;
                        while (true)
                        {
                            int current = index;
                            int last = lastRow;
                            if (current > last)
                                break;
                            yield return new TicketPaymentWrite
                            {
                                Kind = TicketPaymentKind.Tendered,
                                Context = context,
                                Amount = readPaidAmountAt(index),
                                Mode = readModeAt(index)
                            };
                            index++;
                        }
                        if (semantics.IsNegativeChange(readChangeAmount()))
                        {
                            yield return new TicketPaymentWrite
                            {
                                Kind = TicketPaymentKind.Change,
                                Context = context,
                                AmountText = readChangeAmount()
                            };
                        }
                    }
                }
            }
        }
    }
}
