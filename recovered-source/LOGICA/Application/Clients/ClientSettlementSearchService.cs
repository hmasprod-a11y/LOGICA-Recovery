using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Clients
{
    internal static class ClientSettlementSearchService
    {
        internal static void Search(IClientSettlementSearchContext context, ILegacyClientSearchSemantics semantics)
        {
            if (semantics.EqualsText(context.Column, "DATES"))
            {
                context.LoadDateRange();
            }
            else
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
