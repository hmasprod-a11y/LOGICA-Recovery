using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.ApplicationLayer.Inventory
{
    internal static class StockMovementSearchService
    {
        public static void Search(IStockMovementSearchContext context)
        {
            if (Operators.CompareString(context.Column, "DATES", false) == 0)
                context.LoadDateRange();
            else if (Operators.CompareString(context.Text, "", false) != 0)
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
