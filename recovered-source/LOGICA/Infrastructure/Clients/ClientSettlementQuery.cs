using System;
using LOGICA.Infrastructure.Compatibility;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Clients
{
    internal static class ClientSettlementQuery
    {
        public static MySqlDataAdapter DateRange(string table, DateTime from, DateTime to, MySqlConnection connection)
        {
            return new MySqlDataAdapter(ClientSettlementQueryText.DateRange(
                table, from, to, VisualBasicClientSearchSemantics.Instance), connection);
        }

        public static MySqlDataAdapter Contains(string table, object datePrefix, object column, object term, MySqlConnection connection)
        {
            return new MySqlDataAdapter(ClientSettlementQueryText.Contains(
                table, datePrefix, column, term, VisualBasicClientSearchSemantics.Instance), connection);
        }

        public static MySqlDataAdapter ExactLike(string table, object datePrefix, object column, object term, MySqlConnection connection)
        {
            return new MySqlDataAdapter(ClientSettlementQueryText.ExactLike(
                table, datePrefix, column, term, VisualBasicClientSearchSemantics.Instance), connection);
        }

        public static MySqlDataAdapter Refresh(string table, MySqlConnection connection)
        {
            return new MySqlDataAdapter(ClientSettlementQueryText.Refresh(table), connection);
        }

        public static string DatePrefix(DateTime from, DateTime to)
        {
            return ClientSettlementQueryText.DatePrefix(
                from, to, VisualBasicClientSearchSemantics.Instance);
        }
    }
}
