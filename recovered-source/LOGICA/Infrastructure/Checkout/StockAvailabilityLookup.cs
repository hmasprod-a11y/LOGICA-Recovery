using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class StockAvailabilityLookup
    {
        // Keep raw result columns and DataAdapter connection handling unchanged.
        public static DataTable FindByCode(MySqlConnection connection, object articleCode)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter val3 = new MySqlDataAdapter();
            dataTable.Clear();
            val3 = new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select   Code,Article,STOCK   from   TABLE_ARTICLES     WHERE      Code =   '", articleCode), "'       ")), connection);
            ((DbDataAdapter)(object)val3).Fill(dataTable);
            return dataTable;
        }
    }
}
