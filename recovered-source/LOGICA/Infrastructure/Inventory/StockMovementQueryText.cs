using System;
using LOGICA.Domain;

namespace LOGICA.Infrastructure.Inventory
{
    // SQL text is intentionally byte-for-byte compatible with the recovered POS.
    // This is a migration seam, NOT a query hardening or parameterization change.
    // Query identifiers and user terms retain the original legacy behavior.
    internal static class StockMovementQueryText
    {
        internal static string DateRange(string table, DateTime from, DateTime to,
            ILegacyStockMovementQuerySemantics semantics)
        {
            return "select * from     TABLE_" + table + "      Where       Dates   between   ' " +
                semantics.FormatDate(from) + " '     And      ' " + semantics.FormatDate(to) +
                " '               order by   ID    desc ";
        }

        internal static string Contains(string table, object datePrefix, object column, object term,
            ILegacyStockMovementQuerySemantics semantics)
        {
            object sql = string.Concat("select * from     TABLE_" + table, "      Where            ");
            sql = semantics.Concat(sql, datePrefix);
            sql = semantics.Concat(sql, "            (");
            sql = semantics.Concat(sql, column);
            sql = semantics.Concat(sql, "  like  '%");
            sql = semantics.Concat(sql, term);
            sql = semantics.Concat(sql, "%'   )                                order by   ID    desc ");
            return semantics.ToText(sql);
        }

        internal static string ExactLike(string table, object datePrefix, object column, object term,
            ILegacyStockMovementQuerySemantics semantics)
        {
            object sql = string.Concat("select * from     TABLE_" + table, "      Where            ");
            sql = semantics.Concat(sql, datePrefix);
            sql = semantics.Concat(sql, "            (");
            sql = semantics.Concat(sql, column);
            sql = semantics.Concat(sql, "  like  '");
            sql = semantics.Concat(sql, term);
            sql = semantics.Concat(sql, "'     )                                order by   ID    desc ");
            return semantics.ToText(sql);
        }

        internal static string Refresh(string table)
        {
            return "select * from      TABLE_" + table + "                  order by   ID    desc ";
        }

        internal static string DatePrefix(DateTime from, DateTime to,
            ILegacyStockMovementQuerySemantics semantics)
        {
            return "        Dates   between   ' " + semantics.FormatDate(from) +
                " '     And      ' " + semantics.FormatDate(to) + " '         AND     ";
        }
    }
}
