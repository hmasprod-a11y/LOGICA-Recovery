using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Inventory
{
    // Preserve original event sequencing, including event re-entry from setters.
    // No Windows Forms or Microsoft.VisualBasic dependency in this service.
    internal static class StockMovementFilterLayoutService
    {
        internal static void DateCheckboxChanged(IStockMovementFilterLayoutContext context)
        {
            if (context.DateFilterChecked)
            {
                context.SetDatePanelVisible(true);
            }
            else
            {
                context.SetDatePanelVisible(false);
            }
        }

        internal static void ColumnChanged(
            IStockMovementFilterLayoutContext context,
            ILegacyStockMovementSemantics semantics)
        {
            if (semantics.EqualsText(context.SelectedColumn, "DATES"))
            {
                context.SetDatePanelVisible(true);
                context.SetDatePanelLeft(127);
                context.SetDatePanelWidth(713);
                context.SetSearchText("*");
            }
            else
            {
                context.SetDatePanelVisible(false);
                context.SetDatePanelLeft(564);
                context.SetDatePanelWidth(276);
                context.SetSearchText("");
            }
        }
    }
}
