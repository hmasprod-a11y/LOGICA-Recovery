using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueCreationIdentityReader
    {
        public static int ReadNextNumericId(MySqlCommand command, MySqlConnection connection)
        {
            command.CommandText = "SELECT MAX(ID) From TABLE_ARTICLES ";
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            if (connection.State != ConnectionState.Open)
                connection.Open();
            // Preserve separate scalar calls and the original checked int conversion.
            int result = command.ExecuteScalar() == DBNull.Value ? 1 :
                checked((int)Math.Round(Conversions.ToDouble(command.ExecuteScalar()) + 1.0));
            connection.Close();
            return result;
        }

        public static string ReadArticleId(MySqlCommand command, MySqlConnection connection)
        {
            command.CommandText = "Select ARTICLE from TABLE_NUM  where ID = 0 ";
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string result = command.ExecuteScalar() != DBNull.Value ?
                "ART" + Strings.Format(Conversions.ToDouble(command.ExecuteScalar()), "000000") :
                Conversions.ToString(0);
            connection.Close();
            return result;
        }
    }
}
