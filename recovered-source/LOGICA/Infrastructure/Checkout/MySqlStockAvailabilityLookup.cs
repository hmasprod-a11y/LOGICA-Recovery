using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal sealed class MySqlStockAvailabilityLookup : IStockAvailabilityLookup
    {
        private readonly MySqlConnection connection;
        public MySqlStockAvailabilityLookup(MySqlConnection connection) { this.connection = connection; }

        public StockLookupResult FindByCode(object articleCode)
        {
            var table = StockAvailabilityLookup.FindByCode(connection, articleCode);
            if (table.Rows.Count == 0)
                return new StockLookupResult { Found = false };
            return new StockLookupResult
            {
                Found = true,
                AvailableStock = table.Rows[0]["STOCK"],
                ReadArticleName = () => table.Rows[0]["Article"]
            };
        }
    }
}
