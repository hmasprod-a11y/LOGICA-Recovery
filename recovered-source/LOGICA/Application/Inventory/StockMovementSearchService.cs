using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Inventory
{
    internal static class StockMovementSearchService
    {
        public static void Search(IStockMovementSearchContext context, ILegacyStockMovementSemantics semantics)
        {
            if (semantics.EqualsText(context.Column, "DATES"))
                context.LoadDateRange();
            else if (!semantics.EqualsText(context.Text, ""))
            {
                if (context.UseDates) context.SetDatePrefix();
                else context.ClearDatePrefix();
                if (!context.Exact) context.LoadContains();
                else if (context.Exact) context.LoadExactLike();
            }
            context.BindResults();
        }
    }
}
