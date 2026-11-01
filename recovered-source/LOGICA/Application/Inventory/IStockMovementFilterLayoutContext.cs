namespace LOGICA.ApplicationLayer.Inventory
{
    // UI boundary only: reading controls and applying their effects remains in the Form.
    // Getters and setters must not be cached or reordered because they can raise events.
    internal interface IStockMovementFilterLayoutContext
    {
        bool DateFilterChecked { get; }
        string SelectedColumn { get; }
        void SetDatePanelVisible(bool visible);
        void SetDatePanelLeft(int left);
        void SetDatePanelWidth(int width);
        void SetSearchText(string text);
    }
}
