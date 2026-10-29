using System.Data;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueSequenceWriter
    {
        public static void AdvanceArticle(MySqlCommand command, MySqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            // Preserve command reuse and the original update without a WHERE clause.
            command.CommandText = "UPDATE     TABLE_NUM    SET ARTICLE =  ARTICLE + 1   ";
            command.Connection = connection;
            command.ExecuteNonQuery();
            // Keep the original open connection on execution failure.
            connection.Close();
        }
    }
}
