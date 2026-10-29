using System;

namespace LOGICA.ApplicationLayer.Checkout
{
    internal sealed class StockValidationRow
    {
        public object ArticleCode { get; set; }
        public Func<object> ReadQuantity { get; set; }
    }

    internal sealed class StockLookupResult
    {
        public bool Found { get; set; }
        public object AvailableStock { get; set; }
        public Func<object> ReadArticleName { get; set; }
    }

    internal sealed class StockShortage
    {
        public object ArticleName { get; set; }
    }

    internal interface IStockAvailabilityLookup
    {
        StockLookupResult FindByCode(object articleCode);
    }
}
