using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueDuplicateLookup
    {
        // Retain the original SQL and adapter-owned open/close behavior.
        public static void FillNewCode(DataTable table, string code, MySqlConnection connection)
        {
            var adapter = new MySqlDataAdapter("select ID,Code,Article     from TABLE_ARTICLES WHERE   Code = '" + code + "'", connection);
            ((DbDataAdapter)adapter).Fill(table);
        }

        public static void FillEditedCode(DataTable table, string code, string excludedId, MySqlConnection connection)
        {
            var adapter = new MySqlDataAdapter("select ID,Code,Article     from TABLE_ARTICLES WHERE   Code = '" + code + "'    AND    ID <> " + excludedId + "    ", connection);
            ((DbDataAdapter)adapter).Fill(table);
        }

        public static void FillEditedArticleId(DataTable table, string articleId, string excludedId, MySqlConnection connection)
        {
            var adapter = new MySqlDataAdapter("select ID,ID_ARTICLE     from TABLE_ARTICLES WHERE   ID_ARTICLE = '" + articleId + "'    AND    ID <> " + excludedId + "    ", connection);
            ((DbDataAdapter)adapter).Fill(table);
        }
    }
}
