using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Inventory
{
    internal static class StockMovementQuery
    {
        public static MySqlDataAdapter DateRange(string table, DateTime from, DateTime to, MySqlConnection connection)
        {
            return new MySqlDataAdapter("select * from     TABLE_" + table + "      Where       Dates   between   ' " + Strings.Format(from, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(to, "yyyy-MM-dd") + " '               order by   ID    desc ", connection);
        }

        public static MySqlDataAdapter Contains(string table, object datePrefix, object column, object term, MySqlConnection connection)
        {
            return new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + table, "      Where            "), datePrefix), "            ("), column), "  like  '%"), term), "%'   )                                order by   ID    desc ")), connection);
        }

        public static MySqlDataAdapter ExactLike(string table, object datePrefix, object column, object term, MySqlConnection connection)
        {
            return new MySqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + table, "      Where            "), datePrefix), "            ("), column), "  like  '"), term), "'     )                                order by   ID    desc ")), connection);
        }

        public static MySqlDataAdapter Refresh(string table, MySqlConnection connection)
        {
            return new MySqlDataAdapter("select * from      TABLE_" + table + "                  order by   ID    desc ", connection);
        }

        public static string DatePrefix(DateTime from, DateTime to)
        {
            return "        Dates   between   ' " + Strings.Format(from, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(to, "yyyy-MM-dd") + " '         AND     ";
        }
    }
}
