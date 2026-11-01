namespace LOGICA.ApplicationLayer.Clients
{
    internal interface IClientSettlementRefreshContext
    {
        void ClearSearch();
        void ReloadAll();
        void BindResults();
    }
}
