namespace LOGICA.Infrastructure.Checkout
{
    internal static class CheckoutTicketSequenceSql
    {
        // Keep the original spaces and ID predicate; SQL modernization is a separate change.
        internal const string SelectCurrent = "Select CL from TABLE_NUM  where ID = 0 ";
    }
}
