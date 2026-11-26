using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

internal static class CheckoutQuantityMariaDbSmoke
{
    private const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic |
                                      BindingFlags.Static | BindingFlags.Instance;

    [STAThread]
    private static int Main()
    {
        IDbConnection connection = null;
        try
        {
            var assembly = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGICA.exe"));
            var module = assembly.GetType("LOGICA.Module1", true);
            connection = (IDbConnection)module.GetField("cn_SQL", Flags).GetValue(null);
            if (!connection.ConnectionString.Contains("127.0.0.1") ||
                !connection.ConnectionString.Contains("logica_ci"))
                throw new InvalidOperationException("Refusing to test outside isolated logica_ci MariaDB");

            var forms = assembly.GetType("LOGICA.My.MyProject", true)
                .GetProperty("Forms", Flags).GetValue(null, null);
            var template = forms.GetType().GetProperty("Form_0_TEMPLATE", Flags)
                .GetValue(forms, null);
            var poste = (Control)template.GetType().GetProperty("Label_POSTE", Flags)
                .GetValue(template, null);
            poste.Text = "CI_QTE";

            var sale = assembly.GetType("LOGICA.Form_3_VENTE", true);
            var makeAdapter = sale.GetMethod("CreateCheckoutCartAdapter", Flags);
            var normalize = sale.GetMethod("NormalizeLoadedCheckoutQuantityColumn", Flags);
            var update = sale.GetMethod("UpdateCheckoutCart", Flags);

            // Exercise the exact physical mojibake identifier seen in the user screenshot.
            connection.Open();
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "DROP TABLE IF EXISTS TABLE_CI_QTE";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE TABLE_CI_QTE (" +
                    "ID INT NOT NULL PRIMARY KEY, `QtÃ©` DECIMAL(12,3) NOT NULL, " +
                    "Article VARCHAR(80), Prix_V DECIMAL(12,2))";
                cmd.ExecuteNonQuery();
            }
            connection.Close();

            var adapter = (DbDataAdapter)makeAdapter.Invoke(null, null);
            var table = new DataTable();
            adapter.Fill(table);
            module.GetField("da1", Flags).SetValue(null, adapter);
            module.GetField("dt1", Flags).SetValue(null, table);
            Console.WriteLine("TRACE quantity before normalization: " + ColumnNames(table));
            normalize.Invoke(null, null);
            Console.WriteLine("TRACE quantity after normalization: " + ColumnNames(table));
            if (!table.Columns.Contains("Qté") || table.Columns.Contains("QtÃ©"))
                throw new Exception("In-memory quantity normalization failed: " + ColumnNames(table));

            var row = table.NewRow();
            row["ID"] = 1;
            row["Qté"] = 2.5m;
            row["Article"] = "CAFE CASSE";
            row["Prix_V"] = 10m;
            table.Rows.Add(row);
            update.Invoke(null, null);
            CheckPhysical(connection, 1, 2.5m, "INSERT");
            table.AcceptChanges();

            table.Rows[0]["Qté"] = 3.75m;
            update.Invoke(null, null);
            CheckPhysical(connection, 1, 3.75m, "UPDATE FIRST CLICK");
            table.AcceptChanges();

            // Real cashier case: the same image tile is clicked a second time,
            // so the same workstation row must update twice without a false
            // DBConcurrencyException from legacy schema/value comparison.
            table.Rows[0]["Qté"] = 4.75m;
            update.Invoke(null, null);
            CheckPhysical(connection, 1, 4.75m, "UPDATE SECOND CLICK");
            table.AcceptChanges();

            table.Rows[0].Delete();
            update.Invoke(null, null);
            CheckPhysical(connection, 0, 0m, "DELETE");
            Console.WriteLine("PASS legacy QtÃ© insert/update/delete against isolated MariaDB");
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("FAIL legacy QtÃ© MariaDB checkout test: " + ex);
            return 1;
        }
        finally
        {
            if (connection != null)
            {
                try
                {
                    if (connection.State != ConnectionState.Open) connection.Open();
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "DROP TABLE IF EXISTS TABLE_CI_QTE";
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex) { Console.WriteLine("Cleanup warning: " + ex.Message); }
            }
        }
    }

    private static string ColumnNames(DataTable table)
    {
        var names = new System.Collections.Generic.List<string>();
        foreach (DataColumn col in table.Columns)
            names.Add(col.ColumnName + " [" + System.BitConverter.ToString(System.Text.Encoding.UTF8.GetBytes(col.ColumnName)) + "]");
        return string.Join(", ", names.ToArray());
    }

    private static void CheckPhysical(IDbConnection connection, int expectedRows,
                                      decimal expectedQuantity, string phase)
    {
        connection.Open();
        try
        {
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT `QtÃ©` FROM TABLE_CI_QTE WHERE ID = 1";
                var value = cmd.ExecuteScalar();
                if (expectedRows == 0)
                {
                    if (value != null) throw new Exception(phase + " did not delete the row");
                }
                else if (value == null || value == DBNull.Value ||
                         Convert.ToDecimal(value) != expectedQuantity)
                    throw new Exception(phase + " persisted wrong quantity: " + value);
                Console.WriteLine("PASS " + phase + " physical legacy quantity");
            }
        }
        finally { connection.Close(); }
    }
}
