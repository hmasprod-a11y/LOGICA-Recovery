namespace LOGICA.ApplicationLayer.Clients
{
    internal static class ClientSettlementRefreshService
    {
        internal static void Refresh(IClientSettlementRefreshContext context)
        {
            // ClearSearch can synchronously invoke TextChanged/Search. Do not reorder.
            context.ClearSearch();
            context.ReloadAll();
            context.BindResults();
        }
    }
}
