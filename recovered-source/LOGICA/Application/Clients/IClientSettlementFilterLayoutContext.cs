namespace LOGICA.ApplicationLayer.Clients
{
    internal interface IClientSettlementFilterLayoutContext
    {
        bool DateFilterChecked { get; }
        string SelectedColumn { get; }
        void SetDatePanelVisible(bool visible);
        void SetDatePanelLeft(int left);
        void SetSearchText(string text);
    }
}
