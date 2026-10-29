namespace LOGICA.ApplicationLayer.Inventory
{
    internal interface IStockMovementRefreshContext
    {
        void FocusSender();
        void ClearSearch();
        void FocusSearch();
        void ReloadAll();
        void BindResults();
    }
}
