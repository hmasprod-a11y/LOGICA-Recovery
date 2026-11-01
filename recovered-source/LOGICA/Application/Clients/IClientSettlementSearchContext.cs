namespace LOGICA.ApplicationLayer.Clients
{
    // Control access and database effects stay in the original form; getters may trigger events.
    internal interface IClientSettlementSearchContext
    {
        string Column { get; }
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
