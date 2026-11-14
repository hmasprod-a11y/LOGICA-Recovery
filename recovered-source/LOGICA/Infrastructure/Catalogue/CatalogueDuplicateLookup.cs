using System;
using System.Data;
using System.Data.Common;
using System.Globalization;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueDuplicateLookup
    {
        // Preserve the legacy exact-match and adapter-owned connection lifecycle.
        // Barcode/article IDs are data, never SQL fragments: apostrophes in a
        // catalogue entry must not break creation or broaden a duplicate check.
        // Creation persists Strings.Trim(code); duplicate prechecks must use the
        // identical normalized value. A blank barcode is not an identity:
        // multiple image-only articles must remain creatable and editable.
        public static void FillNewCode(DataTable table, string code, MySqlConnection connection)
        {
            var adapter = new MySqlDataAdapter(
                "select ID,Code,Article from TABLE_ARTICLES WHERE Code = @code AND @code <> ''", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@code", (object)NormalizeCode(code));
            ((DbDataAdapter)adapter).Fill(table);
        }

        public static void FillEditedCode(DataTable table, string code, string excludedId, MySqlConnection connection)
        {
            long id = ParseExcludedId(excludedId);
            var adapter = new MySqlDataAdapter(
                "select ID,Code,Article from TABLE_ARTICLES WHERE Code = @code AND @code <> '' AND (ID IS NULL OR ID <> @excludedId)", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@code", (object)NormalizeCode(code));
            adapter.SelectCommand.Parameters.AddWithValue("@excludedId", id);
            ((DbDataAdapter)adapter).Fill(table);
        }

        public static void FillEditedArticleId(DataTable table, string articleId, string excludedId, MySqlConnection connection)
        {
            long id = ParseExcludedId(excludedId);
            var adapter = new MySqlDataAdapter(
                "select ID,ID_ARTICLE from TABLE_ARTICLES WHERE ID_ARTICLE = @articleId AND (ID IS NULL OR ID <> @excludedId)", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@articleId", (object)articleId ?? "");
            adapter.SelectCommand.Parameters.AddWithValue("@excludedId", id);
            ((DbDataAdapter)adapter).Fill(table);
        }

        public static void FillCollectionCode(DataTable table, object code, MySqlConnection connection)
        {
            var adapter = new MySqlDataAdapter(
                "select ID,Code,Article from TABLE_ARTICLES WHERE Code = @code AND @code <> ''", connection);
            // Imported collection rows can carry DBNull for an optional barcode.
            // VB Conversions.ToString(DBNull.Value) throws before the lookup.
            adapter.SelectCommand.Parameters.AddWithValue("@code", (object)NormalizeCode(code == null || code == DBNull.Value ? "" : Conversions.ToString(code)));
            ((DbDataAdapter)adapter).Fill(table);
        }

        private static string NormalizeCode(string code)
        {
            return Strings.Trim(code ?? "") ?? "";
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
