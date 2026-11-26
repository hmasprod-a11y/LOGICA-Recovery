using System;

namespace LOGICA.ApplicationLayer.Checkout
{
    internal sealed class StockValidationRow
    {
        public object ArticleCode { get; set; } = DBNull.Value;
        public Func<object> ReadQuantity { get; set; } = () => throw new InvalidOperationException("Stock quantity reader not configured.");
    }

    internal sealed class StockLookupResult
    {
        public bool Found { get; set; }
        public object AvailableStock { get; set; } = DBNull.Value;
        public Func<object> ReadArticleName { get; set; } = () => throw new InvalidOperationException("Article name reader not configured.");
    }

    internal sealed class StockShortage
    {
        public object ArticleName { get; set; } = DBNull.Value;
    }

    internal interface IStockAvailabilityLookup
    {
        StockLookupResult FindByCode(object articleCode);
    }
}
