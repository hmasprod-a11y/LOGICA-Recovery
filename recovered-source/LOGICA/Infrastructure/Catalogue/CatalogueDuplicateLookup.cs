using System;
using System.Data;
using System.Data.Common;
using System.Globalization;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueDuplicateLookup
    {
        // Preserve the legacy exact-match and adapter-owned connection lifecycle.
        // Barcode/article IDs are data, never SQL fragments: apostrophes in a
        // catalogue entry must not break creation or broaden a duplicate check.
        public static void FillNewCode(DataTable table, string code, MySqlConnection connection)
        {
            var adapter = new MySqlDataAdapter(
                "select ID,Code,Article from TABLE_ARTICLES WHERE Code = @code", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@code", (object)code ?? "");
            ((DbDataAdapter)adapter).Fill(table);
        }

        public static void FillEditedCode(DataTable table, string code, string excludedId, MySqlConnection connection)
        {
            long id = ParseExcludedId(excludedId);
            var adapter = new MySqlDataAdapter(
                "select ID,Code,Article from TABLE_ARTICLES WHERE Code = @code AND ID <> @excludedId", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@code", (object)code ?? "");
            adapter.SelectCommand.Parameters.AddWithValue("@excludedId", id);
            ((DbDataAdapter)adapter).Fill(table);
        }

        public static void FillEditedArticleId(DataTable table, string articleId, string excludedId, MySqlConnection connection)
        {
            long id = ParseExcludedId(excludedId);
            var adapter = new MySqlDataAdapter(
                "select ID,ID_ARTICLE from TABLE_ARTICLES WHERE ID_ARTICLE = @articleId AND ID <> @excludedId", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@articleId", (object)articleId ?? "");
            adapter.SelectCommand.Parameters.AddWithValue("@excludedId", id);
            ((DbDataAdapter)adapter).Fill(table);
        }

        public static void FillCollectionCode(DataTable table, object code, MySqlConnection connection)
        {
            var adapter = new MySqlDataAdapter(
                "select ID,Code,Article from TABLE_ARTICLES WHERE Code = @code", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@code", (object)Conversions.ToString(code) ?? "");
            ((DbDataAdapter)adapter).Fill(table);
        }

        private static long ParseExcludedId(string excludedId)
        {
            long id;
            // An ID taken from the form must never be appended to SQL. Reject
            // malformed values instead of silently selecting a different row.
            if (!long.TryParse(excludedId, NumberStyles.Integer, CultureInfo.InvariantCulture, out id))
                throw new ArgumentException("Invalid catalogue database ID", "excludedId");
            return id;
        }
    }
}
