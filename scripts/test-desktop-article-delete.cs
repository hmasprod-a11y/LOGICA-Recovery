// Isolated MariaDB regression for the WinForms article deletion movement.
// Uses a TEMPORARY table shadowing the original table; never deletes shop data.
using System;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

internal static class DesktopArticleDeleteSmoke
{
    private const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
    private static void Expect(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
    [STAThread]
    private static int Main()
    {
        CultureInfo previous = Thread.CurrentThread.CurrentCulture;
        try
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
            Assembly assembly = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGICA.exe"));
            Type module = assembly.GetType("LOGICA.Module1", true);
            DbConnection connection = (DbConnection)module.GetField("cn_SQL", Flags).GetValue(null);
            string connectionString = connection.ConnectionString.ToLowerInvariant();
            Expect(connectionString.Contains("127.0.0.1") && connectionString.Contains("logica_ci"),
                "Article delete regression requires the disposable local CI MariaDB");
            Type form = assembly.GetType("LOGICA.Form_2_ARTICLES", true);
            MethodInfo insert = form.GetMethod("InsertDeletionStockMovement", Flags);
            Expect(insert != null, "Parameterized article deletion movement helper missing");
            if (connection.State != ConnectionState.Open) connection.Open();
            try
            {
                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "CREATE TEMPORARY TABLE TABLE_MOUVEMENTS_STOCK (" +
                        "DATES DATE, HEURE TIME, LIBELLE VARCHAR(128), ID_ARTICLE VARCHAR(64), " +
                        "CODE_ARTICLE VARCHAR(128), ARTICLE VARCHAR(255), QUANTITE DECIMAL(18,4))";
                    cmd.ExecuteNonQuery();
                }
                // Inventory #86 resolves the clicked DataRow by unique identity;
                // exercise that same row contract, not a mutable grid CurrentRow.
                DataTable articles = new DataTable();
                articles.Columns.Add("ID_ARTICLE");
                articles.Columns.Add("Code");
                articles.Columns.Add("Article");
                articles.Columns.Add("STOCK");
                articles.Rows.Add("CI_DECOY", "WRONG", "Other row", "999");
                DataRow clicked = articles.Rows.Add("CI_QUOTED_DELETE", "SKU'O-1", "L'eau d'orange", "12,50");
                insert.Invoke(null, new object[] { connection, clicked });
                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT LIBELLE,CODE_ARTICLE,ARTICLE,QUANTITE FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE='CI_QUOTED_DELETE'";
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        Expect(reader.Read(), "Quoted deletion movement was not written");
                        Expect(reader.GetString(0) == "Suppression d'article", "Deletion movement label changed");
                        Expect(reader.GetString(1) == "SKU'O-1", "Quoted barcode was altered");
                        Expect(reader.GetString(2) == "L'eau d'orange", "Quoted article name was altered");
                        Expect(reader.GetDecimal(3) == -12.50m, "Fractional French stock was truncated");
                        Expect(!reader.Read(), "Deletion movement inserted more than once");
                    }
                }
                Console.WriteLine("PASS isolated deletion movement: quoted barcode/article, exact fractional stock, one row");
            }
            finally
            {
                using (DbCommand cleanup = connection.CreateCommand())
                {
                    cleanup.CommandText = "DROP TEMPORARY TABLE IF EXISTS TABLE_MOUVEMENTS_STOCK";
                    cleanup.ExecuteNonQuery();
                }
                connection.Close();
            }
            return 0;
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine(exception.ToString());
            return 1;
        }
        finally
        {
            Thread.CurrentThread.CurrentCulture = previous;
        }
    }
}
