using System;
using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Mirrors the original ReadCheckoutPaymentModes read order, including its
    // second operation/checkbox reads and per-row VB object operations.
    internal static class CheckoutPaymentModeService
    {
        internal static string Read(
            Func<string> readOperation,
            Func<bool> readAccessModesEnabled,
            Func<int> readModeRowCount,
            Func<int, object> readModeAt,
            ILegacyCheckoutPaymentModeSemantics semantics)
        {
            checked
            {
                string result = "";
                if (semantics.CompareOperation(readOperation(), "VENTE") == 0 ||
                    semantics.CompareOperation(readOperation(), "RETOUR REMBOURSEMENT") == 0)
                {
                    if (!readAccessModesEnabled())
                    {
                        result = "ESPECES;";
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
                            result = semantics.ToText(semantics.Add(result,
                                semantics.Concatenate(readModeAt(index), ";")));
                            index++;
                        }
                    }
                }
                return result;
            }
        }
    }
}
