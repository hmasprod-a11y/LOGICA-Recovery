using LOGICA.Domain;

namespace LOGICA.Infrastructure.Checkout
{
    // Extracts the exact existing SQL, without changing order, quoting or precision.
    // The caller still executes DELETE before evaluating the sequence conversion.
    internal static class CheckoutCompletionSql
    {
        internal static string DeleteWorkstation(string workstation)
        {
            return "Delete  from TABLE_" + workstation + "";
        }

        internal static string AdvanceSequence(string ticketNumber,
            ILegacyCheckoutCompletionSemantics semantics)
        {
            return "UPDATE     TABLE_NUM    SET CL =  " +
                semantics.FormatSequence(semantics.ToDouble(ticketNumber) + 1.0) + "  ";
        }
    }
}
