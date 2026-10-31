using System;
using LOGICA.Infrastructure.Compatibility;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Inventory
{
    internal static class StockMovementQuery
    {
        public static MySqlDataAdapter DateRange(string table, DateTime from, DateTime to, MySqlConnection connection)
        {
            return new MySqlDataAdapter(StockMovementQueryText.DateRange(
                table, from, to, VisualBasicStockMovementQuerySemantics.Instance), connection);
        }

        public static MySqlDataAdapter Contains(string table, object datePrefix, object column, object term, MySqlConnection connection)
        {
            return new MySqlDataAdapter(StockMovementQueryText.Contains(
                table, datePrefix, column, term, VisualBasicStockMovementQuerySemantics.Instance), connection);
        }

        public static MySqlDataAdapter ExactLike(string table, object datePrefix, object column, object term, MySqlConnection connection)
        {
            return new MySqlDataAdapter(StockMovementQueryText.ExactLike(
                table, datePrefix, column, term, VisualBasicStockMovementQuerySemantics.Instance), connection);
        }

        public static MySqlDataAdapter Refresh(string table, MySqlConnection connection)
        {
            return new MySqlDataAdapter(StockMovementQueryText.Refresh(table), connection);
        }

        public static string DatePrefix(DateTime from, DateTime to)
        {
            return StockMovementQueryText.DatePrefix(
                from, to, VisualBasicStockMovementQuerySemantics.Instance);
        }
    }
}
