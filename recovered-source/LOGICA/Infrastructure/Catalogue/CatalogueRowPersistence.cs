using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueRowPersistence
    {
        public static void UpdateAndAccept(MySqlDataAdapter adapter, DataTable table)
        {
            // Keep the command builder's adapter association and the original order.
            var builder = new MySqlCommandBuilder(adapter);
            ((DbDataAdapter)adapter).Update(table);
            table.AcceptChanges();
        }
    }
}
