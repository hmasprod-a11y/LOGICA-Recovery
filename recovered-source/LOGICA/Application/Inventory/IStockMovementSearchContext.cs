namespace LOGICA.ApplicationLayer.Inventory
{
    internal interface IStockMovementSearchContext
    {
        string Column { get; }
        string Text { get; }
        bool UseDates { get; }
        bool Exact { get; }
        void LoadDateRange();
        void SetDatePrefix();
        void ClearDatePrefix();
        void LoadContains();
        void LoadExactLike();
        void BindResults();
    }
}
