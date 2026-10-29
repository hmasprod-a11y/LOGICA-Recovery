namespace LOGICA.ApplicationLayer.Inventory
{
    internal static class StockMovementRefreshService
    {
        public static void Refresh(IStockMovementRefreshContext context)
        {
            context.FocusSender();
            context.ClearSearch();
            context.FocusSearch();
            context.ReloadAll();
            context.BindResults();
        }
    }
}
