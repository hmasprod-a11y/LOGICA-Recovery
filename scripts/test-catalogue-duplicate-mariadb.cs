// Runs only against the disposable logica_ci database on loopback.
// Uses a connection-scoped TEMPORARY table: no production article is read or changed.
using System;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Reflection;

internal static class CatalogueDuplicateMariaDbSmoke
{
    private const BindingFlags Static = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;
    private static void Require(bool ok, string message)
    {
        if (!ok) throw new InvalidOperationException(message);
    }

    private static DataTable Invoke(Type type, string method, DbConnection connection,
        string value, string excludedId = null, bool collection = false)
    {
        DataTable result = new DataTable();
        MethodInfo target = type.GetMethod(method, Static);
        Require(target != null, "Missing production method " + method);
        object[] args = collection ? new object[] { result, (object)value, connection } :
            excludedId == null ? new object[] { result, value, connection } :
            new object[] { result, value, excludedId, connection };
        target.Invoke(null, args);
        return result;
    }

    private static void ExpectIds(DataTable table, string expected, string description)
    {
        System.Collections.Generic.List<string> ids = new System.Collections.Generic.List<string>();
        foreach (DataRow row in table.Rows)
            ids.Add(row.IsNull("ID") ? "NULL" : Convert.ToString(row["ID"], CultureInfo.InvariantCulture));
        string actual = string.Join(",", ids.ToArray());
        Require(actual == expected, description + ": expected [" + expected + "] got [" + actual + "]");
        Console.WriteLine("PASS " + description);
    }

    private static void Execute(DbConnection connection, string sql, params object[] values)
    {
        using (DbCommand command = connection.CreateCommand())
        {
            command.CommandText = sql;
            for (int i = 0; i < values.Length; i += 2)
            {
                DbParameter p = command.CreateParameter();
                p.ParameterName = (string)values[i];
                p.Value = values[i + 1] ?? DBNull.Value;
                command.Parameters.Add(p);
            }
            command.ExecuteNonQuery();
        }
    }

    [STAThread]
    private static int Main()
    {
        DbConnection connection = null;
        try
        {
            Assembly assembly = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGICA.exe"));
            Type module = assembly.GetType("LOGICA.Module1", true);
            connection = (DbConnection)module.GetField("cn_SQL", Static).GetValue(null);
            string cs = connection.ConnectionString.ToLowerInvariant();
            Require((cs.Contains("127.0.0.1") || cs.Contains("localhost")) &&
                    cs.Contains("logica_ci"), "Refusing non-isolated MariaDB connection");
            Type lookup = assembly.GetType("LOGICA.Infrastructure.Catalogue.CatalogueDuplicateLookup", true);
            if (connection.State != ConnectionState.Open) connection.Open();
            Execute(connection, "CREATE TEMPORARY TABLE TABLE_ARTICLES (" +
                "ID BIGINT NULL, Code VARCHAR(128), Article VARCHAR(255), ID_ARTICLE VARCHAR(128))");
            string insert = "INSERT INTO TABLE_ARTICLES (ID,Code,Article,ID_ARTICLE) " +
                "VALUES (@id,@code,@article,@articleId)";
            Execute(connection, insert, "@id", 1L, "@code", "ABC'123", "@article", "First", "@articleId", "A'1");
            Execute(connection, insert, "@id", 2L, "@code", "ABC'123", "@article", "Variant", "@articleId", "B");
            Execute(connection, insert, "@id", 3L, "@code", "NORMAL", "@article", "Third", "@articleId", "C");
            Execute(connection, insert, "@id", 4L, "@code", "", "@article", "Image A", "@articleId", "IMG-A");
            Execute(connection, insert, "@id", 5L, "@code", "", "@article", "Image B", "@articleId", "IMG-B");
            Execute(connection, insert, "@id", null, "@code", "NULL-ID", "@article", "Orphan", "@articleId", "NULL-ARTICLE");
            ExpectIds(Invoke(lookup, "FillNewCode", connection, "ABC'123"), "1,2", "duplicate quoted barcode variants");
            ExpectIds(Invoke(lookup, "FillEditedCode", connection, "ABC'123", "1"), "2", "edit excludes only selected ID");
            ExpectIds(Invoke(lookup, "FillEditedCode", connection, "ABC'123", "2"), "1", "reverse edit variant");
            ExpectIds(Invoke(lookup, "FillEditedArticleId", connection, "A'1", "2"), "1", "quoted article identity");
            ExpectIds(Invoke(lookup, "FillEditedArticleId", connection, "A'1", "1"), "", "own identity excluded");
            ExpectIds(Invoke(lookup, "FillCollectionCode", connection, "ABC'123", collection: true), "1,2", "collection variants");
            ExpectIds(Invoke(lookup, "FillNewCode", connection, " NORMAL "), "3", "create trims barcode");
            ExpectIds(Invoke(lookup, "FillEditedCode", connection, " NORMAL ", "1"), "3", "edit trims barcode");
            ExpectIds(Invoke(lookup, "FillCollectionCode", connection, " NORMAL ", collection: true), "3", "collection trims barcode");
            ExpectIds(Invoke(lookup, "FillNewCode", connection, ""), "", "blank barcode not unique");
            ExpectIds(Invoke(lookup, "FillEditedCode", connection, "  ", "4"), "", "blank edit not unique");
            ExpectIds(Invoke(lookup, "FillCollectionCode", connection, "", collection: true), "", "blank collection not unique");
            ExpectIds(Invoke(lookup, "FillEditedArticleId", connection, "IMG-A", "5"), "4", "image-only article ID still unique");
            ExpectIds(Invoke(lookup, "FillEditedCode", connection, "NULL-ID", "1"), "NULL", "null database ID cannot hide barcode collision");
            ExpectIds(Invoke(lookup, "FillEditedArticleId", connection, "NULL-ARTICLE", "1"), "NULL", "null database ID cannot hide article collision");
            string injection = "' OR 1=1 --";
            ExpectIds(Invoke(lookup, "FillNewCode", connection, injection), "", "create SQL injection stays data");
            ExpectIds(Invoke(lookup, "FillEditedCode", connection, injection, "1"), "", "edit SQL injection stays data");
            ExpectIds(Invoke(lookup, "FillEditedArticleId", connection, injection, "1"), "", "article ID SQL injection stays data");
            ExpectIds(Invoke(lookup, "FillCollectionCode", connection, injection, collection: true), "", "collection SQL injection stays data");
            bool rejected = false;
            try { Invoke(lookup, "FillEditedCode", connection, "NORMAL", "1 OR 1=1"); }
            catch (TargetInvocationException ex) { rejected = ex.InnerException is ArgumentException; }
            Require(rejected, "Malformed excluded ID must be rejected before querying");
            Console.WriteLine("PASS malformed excluded ID rejected; 20 MariaDB checks");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
            return 1;
        }
        finally
        {
            if (connection != null)
            {
                try
                {
                    if (connection.State == ConnectionState.Open)
                        Execute(connection, "DROP TEMPORARY TABLE IF EXISTS TABLE_ARTICLES");
                }
                finally { connection.Close(); }
            }
        }
    }
}
