using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Clients
{
    internal static class ClientSettlementFilterLayoutService
    {
        internal static void DateCheckboxChanged(IClientSettlementFilterLayoutContext context)
        {
            if (context.DateFilterChecked) context.SetDatePanelVisible(true);
            else context.SetDatePanelVisible(false);
        }

        internal static void ColumnChanged(IClientSettlementFilterLayoutContext context, ILegacyClientSearchSemantics semantics)
        {
            if (semantics.EqualsText(context.SelectedColumn, "DATES"))
            {
                context.SetDatePanelVisible(true);
                context.SetDatePanelLeft(78);
                context.SetSearchText("*");
            }
            else
            {
                context.SetDatePanelVisible(false);
                context.SetDatePanelLeft(417);
                context.SetSearchText("");
            }
        }
    }
}
