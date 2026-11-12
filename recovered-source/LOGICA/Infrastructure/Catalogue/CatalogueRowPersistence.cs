using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueRowPersistence
    {
        private sealed class StockChange
        {
            public DataRow Row;
            public string Permission;
            public decimal Requested;
            public decimal Original;
            public bool IsNew;
        }

        public static void UpdateAndAccept(MySqlDataAdapter adapter, DataTable table)
        {
            if (adapter == null) throw new ArgumentNullException(nameof(adapter));
            if (table == null) throw new ArgumentNullException(nameof(table));

            var changes = FindStockChanges(table);
            if (changes.Count == 0)
            {
                // Preserve the original command-builder path when stock is unchanged.
                var unchangedBuilder = new MySqlCommandBuilder(adapter);
                ((DbDataAdapter)adapter).Update(table);
                table.AcceptChanges();
                return;
            }

            var connection = adapter.SelectCommand == null ? null : adapter.SelectCommand.Connection;
            if (connection == null)
                throw new InvalidOperationException("Stock changes require the catalogue database connection.");
            bool openedHere = connection.State != ConnectionState.Open;
            try
            {
                if (openedHere) connection.Open();
                RequireInnoDb(connection, "TABLE_ARTICLES");
                RequireInnoDb(connection, "TABLE_PARAMETRES");

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var change in changes)
                        {
                            if (!change.IsNew)
                                VerifyPersistedStock(connection, transaction, change);
                            RequireManualStockPermission(connection, transaction, change.Permission);
                        }

                        // Use the same locked permission transaction for the generated
                        // catalogue writes. A settings toggle cannot race between check
                        // and persistence.
                        var builder = new MySqlCommandBuilder(adapter);
                        var oldInsert = adapter.InsertCommand;
                        var oldUpdate = adapter.UpdateCommand;
                        var oldDelete = adapter.DeleteCommand;
                        bool oldAcceptChanges = adapter.AcceptChangesDuringUpdate;
                        var generated = new List<MySqlCommand>();
                        try
                        {
                            if (table.Rows.Cast<DataRow>().Any(row => row.RowState == DataRowState.Added))
                            {
                                if (adapter.InsertCommand == null)
                                {
                                    adapter.InsertCommand = builder.GetInsertCommand();
                                    generated.Add(adapter.InsertCommand);
                                }
                            }
                            if (table.Rows.Cast<DataRow>().Any(row => row.RowState == DataRowState.Modified))
                            {
                                if (adapter.UpdateCommand == null)
                                {
                                    adapter.UpdateCommand = builder.GetUpdateCommand();
                                    generated.Add(adapter.UpdateCommand);
                                }
                            }
                            if (table.Rows.Cast<DataRow>().Any(row => row.RowState == DataRowState.Deleted))
                            {
                                if (adapter.DeleteCommand == null)
                                {
                                    adapter.DeleteCommand = builder.GetDeleteCommand();
                                    generated.Add(adapter.DeleteCommand);
                                }
                            }

                            if (adapter.InsertCommand != null) adapter.InsertCommand.Transaction = transaction;
                            if (adapter.UpdateCommand != null) adapter.UpdateCommand.Transaction = transaction;
                            if (adapter.DeleteCommand != null) adapter.DeleteCommand.Transaction = transaction;
                            adapter.AcceptChangesDuringUpdate = false;
                            ((DbDataAdapter)adapter).Update(table);
                            transaction.Commit();
                            table.AcceptChanges();
                        }
                        finally
                        {
                            adapter.AcceptChangesDuringUpdate = oldAcceptChanges;
                            if (adapter.InsertCommand != oldInsert) adapter.InsertCommand = oldInsert;
                            if (adapter.UpdateCommand != oldUpdate) adapter.UpdateCommand = oldUpdate;
                            if (adapter.DeleteCommand != oldDelete) adapter.DeleteCommand = oldDelete;
                            foreach (var command in generated) command.Dispose();
                        }
                    }
                    catch
                    {
                        try { transaction.Rollback(); } catch { }
                        throw;
                    }
                }
            }
            finally
            {
                if (openedHere && connection.State == ConnectionState.Open) connection.Close();
            }
        }

        // Direct collection INSERTs use the same permission row lock as the
        // DataAdapter path and hold it through their caller-owned transaction.
        public static void RequireManualStockPermission(MySqlConnection connection,
            MySqlTransaction transaction, string settingName)
        {
            if (connection == null || transaction == null || String.IsNullOrWhiteSpace(settingName))
                throw new UnauthorizedAccessException("Manual stock configuration and transaction are required.");
            if (connection.State != ConnectionState.Open ||
                !Object.ReferenceEquals(transaction.Connection, connection))
                throw new UnauthorizedAccessException("Manual stock configuration requires the active local transaction.");
            if (!String.Equals(connection.DataSource, "127.0.0.1", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(connection.DataSource, "localhost", StringComparison.OrdinalIgnoreCase) &&
                !String.Equals(connection.DataSource, "::1", StringComparison.OrdinalIgnoreCase))
                throw new UnauthorizedAccessException("Manual stock configuration is local-only.");

            using (var active = new MySqlCommand("SELECT @@in_transaction", connection, transaction))
                if (Convert.ToInt32(active.ExecuteScalar(), CultureInfo.InvariantCulture) != 1)
                    throw new UnauthorizedAccessException("Manual stock configuration requires an active transaction.");

            var values = new List<string>();
            using (var command = new MySqlCommand(
                "SELECT VALEUR FROM TABLE_PARAMETRES WHERE BINARY OBJET=BINARY @setting FOR UPDATE",
                connection, transaction))
            {
                command.Parameters.AddWithValue("@setting", settingName);
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        values.Add(reader.IsDBNull(0) ? null : Convert.ToString(reader.GetValue(0), CultureInfo.InvariantCulture));
            }
            if (values.Count != 1 ||
                !String.Equals(values[0] == null ? null : values[0].Trim(), "True", StringComparison.OrdinalIgnoreCase))
                throw new UnauthorizedAccessException("Manual stock operation is disabled or its configuration is missing/ambiguous.");
        }

        private static List<StockChange> FindStockChanges(DataTable table)
        {
            var result = new List<StockChange>();
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    decimal requested = ReadStock(row, DataRowVersion.Current);
                    if (requested != 0m)
                        result.Add(new StockChange { Row = row, Permission = "AJOUT_STOCK_MANUEL", Requested = requested, IsNew = true });
                }
                else if (row.RowState == DataRowState.Modified &&
                    table.Columns.Contains("STOCK") &&
                    !row.IsNull("STOCK", DataRowVersion.Original) &&
                    !row.IsNull("STOCK", DataRowVersion.Current))
                {
                    decimal original = ReadStock(row, DataRowVersion.Original);
                    decimal requested = ReadStock(row, DataRowVersion.Current);
                    if (original != requested)
                        result.Add(new StockChange { Row = row, Permission = "MODIF_STOCK_MANUEL", Original = original, Requested = requested });
                }
                else if (row.RowState == DataRowState.Modified && table.Columns.Contains("STOCK") &&
                    row.IsNull("STOCK", DataRowVersion.Original) != row.IsNull("STOCK", DataRowVersion.Current))
                {
                    throw new UnauthorizedAccessException("A NULL stock value cannot be changed through catalogue editing.");
                }
            }
            return result;
        }

        private static decimal ReadStock(DataRow row, DataRowVersion version)
        {
            if (!row.Table.Columns.Contains("STOCK") || row.IsNull("STOCK", version))
                throw new UnauthorizedAccessException("Stock value is missing or NULL.");
            try { return Convert.ToDecimal(row["STOCK", version], CultureInfo.InvariantCulture); }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { throw new UnauthorizedAccessException("Stock value cannot be verified.", ex); }
        }

        private static void VerifyPersistedStock(MySqlConnection connection,
            MySqlTransaction transaction, StockChange change)
        {
            if (!change.Row.Table.Columns.Contains("ID_ARTICLE") ||
                change.Row.IsNull("ID_ARTICLE", DataRowVersion.Original))
                throw new UnauthorizedAccessException("Original article identity is unavailable.");
            string id = Convert.ToString(change.Row["ID_ARTICLE", DataRowVersion.Original], CultureInfo.InvariantCulture);
            decimal? persisted = null;
            int matches = 0;
            using (var command = new MySqlCommand(
                "SELECT STOCK FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id FOR UPDATE",
                connection, transaction))
            {
                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        matches++;
                        if (matches == 1 && !reader.IsDBNull(0))
                            persisted = Convert.ToDecimal(reader.GetValue(0), CultureInfo.InvariantCulture);
                    }
            }
            if (matches != 1 || persisted == null || persisted.Value != change.Original)
                throw new DBConcurrencyException("Article stock changed or its identity is ambiguous; refresh before saving.");
        }

        private static void RequireInnoDb(MySqlConnection connection, string table)
        {
            using (var command = new MySqlCommand(
                "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table",
                connection))
            {
                command.Parameters.AddWithValue("@table", table);
                if (!String.Equals(Convert.ToString(command.ExecuteScalar(), CultureInfo.InvariantCulture),
                    "InnoDB", StringComparison.OrdinalIgnoreCase))
                    throw new UnauthorizedAccessException("Stock changes require existing InnoDB catalogue/configuration tables.");
            }
        }
    }
}
