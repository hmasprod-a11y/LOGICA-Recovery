using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Checkout
{
    internal static class StockValidationService
    {
        public static StockShortage FindFirstShortage(IStockAvailabilityLookup lookup, IEnumerable<StockValidationRow> rows, LOGICA.Domain.ILegacyCheckoutSemantics legacy)
        {
            foreach (StockValidationRow row in rows)
            {
                StockLookupResult result = lookup.FindByCode(row.ArticleCode);
                if (result.Found && LOGICA.Domain.StockAvailability.IsBelowRequested(result.AvailableStock, row.ReadQuantity(), legacy))
                    return new StockShortage { ArticleName = result.ReadArticleName() };
            }
            return null;
        }
    }
}
