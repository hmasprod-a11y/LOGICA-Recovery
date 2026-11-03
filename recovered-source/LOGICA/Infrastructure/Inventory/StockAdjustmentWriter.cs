using System;
using System.Data;
using System.Globalization;
using System.Text;
using MySql.Data.MySqlClient;
using LOGICA.Application.Inventory;

namespace LOGICA.Infrastructure.Inventory
{
    // Opt-in writer. The caller owns Commit/Rollback and MUST NOT reuse a sale transaction.
    // Legacy WinForms is not yet wired to this entry point.
    internal static class StockAdjustmentWriter
    {
        internal static void Apply(MySqlConnection connection, MySqlTransaction transaction,
            StockAdjustmentPlan plan)
        {
            if (connection == null) throw new ArgumentNullException("connection");
            if (transaction == null) throw new ArgumentNullException("transaction");
            if (plan == null) throw new ArgumentNullException("plan");
            if (connection.State != ConnectionState.Open ||
                !Object.ReferenceEquals(transaction.Connection, connection))
                throw new InvalidOperationException("An open caller-owned transaction is required.");

            // Validate the audit payload before any database mutation. A too-long
            // reason/user must never leave an uncommittable stock update behind.
            string audit = "Ajustement [" + plan.UserId + "] " +
                plan.BeforeStock.ToString(CultureInfo.InvariantCulture) + " -> " +
                plan.AfterStock.ToString(CultureInfo.InvariantCulture) + " : " + plan.Reason;
            if (Encoding.UTF8.GetByteCount(audit) > 255)
                throw new InvalidOperationException("Stock adjustment audit exceeds legacy column size.");
            if (plan.ArticleId.Length > 128)
                throw new InvalidOperationException("Article identity exceeds supported length.");

            // Fail closed if rollback cannot cover both the stock row and its audit entry.
            using (var schema = new MySqlCommand(
                "SELECT TABLE_NAME, ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA = DATABASE() " +
                "AND TABLE_NAME IN ('TABLE_ARTICLES','TABLE_MOUVEMENTS_STOCK','TABLE_PARAMETRES')",
                connection, transaction))
            using (var reader = schema.ExecuteReader())
            {
                int count = 0;
                while (reader.Read())
                {
                    if (!String.Equals(Convert.ToString(reader.GetValue(1)), "InnoDB",
                        StringComparison.OrdinalIgnoreCase))
                        throw new InvalidOperationException("Stock adjustment requires InnoDB.");
                    count++;
                }
                if (count != 3) throw new InvalidOperationException("Incomplete stock adjustment schema.");
            }

            // Read the persisted permission inside the same transaction, not a stale UI flag.
            using (var permission = new MySqlCommand(
                "SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET = 'MODIF_STOCK_MANUEL' FOR UPDATE",
                connection, transaction))
            using (var reader = permission.ExecuteReader())
            {
                if (!reader.Read()) throw new InvalidOperationException("Manual stock permission missing.");
                string value = reader.IsDBNull(0) ? null : Convert.ToString(reader.GetValue(0));
                if (reader.Read() || !String.Equals(value, "True", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidOperationException("Manual stock adjustment disabled or ambiguous.");
            }

            string code, name;
            decimal current;
            using (var select = new MySqlCommand(
                "SELECT STOCK, Code, Article FROM TABLE_ARTICLES WHERE ID_ARTICLE = @id FOR UPDATE",
                connection, transaction))
            {
                select.Parameters.AddWithValue("@id", plan.ArticleId);
                using (var reader = select.ExecuteReader())
                {
                    if (!reader.Read()) throw new InvalidOperationException("Article not found.");
                    if (reader.IsDBNull(0)) throw new InvalidOperationException("Article stock is NULL.");
                    current = Convert.ToDecimal(reader.GetValue(0), CultureInfo.InvariantCulture);
                    code = reader.IsDBNull(1) ? "" : Convert.ToString(reader.GetValue(1));
                    name = reader.IsDBNull(2) ? "" : Convert.ToString(reader.GetValue(2));
                    if (reader.Read()) throw new InvalidOperationException("Duplicate article identity.");
                }
            }
            if (current != plan.BeforeStock)
                throw new InvalidOperationException("Stale stock snapshot; refresh before adjustment.");

            // A caller might catch an audit failure and accidentally commit its
            // outer transaction. A local savepoint makes the stock + audit pair
            // indivisible even under that misuse; caller still owns final commit.
            // A fixed savepoint name can overwrite a caller savepoint or an earlier
            // nested adjustment. Generate an SQL-safe identifier per invocation.
            string savepointName = "hanouty_sa_" + Guid.NewGuid().ToString("N");
            using (var savepoint = new MySqlCommand("SAVEPOINT " + savepointName, connection, transaction))
                savepoint.ExecuteNonQuery();
            try
            {
                using (var update = new MySqlCommand(
                    "UPDATE TABLE_ARTICLES SET STOCK = @after WHERE ID_ARTICLE = @id AND STOCK = @before",
                    connection, transaction))
                {
                    update.Parameters.AddWithValue("@after", plan.AfterStock);
                    update.Parameters.AddWithValue("@before", plan.BeforeStock);
                    update.Parameters.AddWithValue("@id", plan.ArticleId);
                    if (update.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("Concurrent stock change; rollback required.");
                }
    
                // A legacy STOCK column may round a decimal quantity on write.
                // Never record a movement delta that differs from the persisted stock.
                using (var verify = new MySqlCommand(
                    "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE = @id FOR UPDATE",
                    connection, transaction))
                {
                    verify.Parameters.AddWithValue("@id", plan.ArticleId);
                    using (var reader = verify.ExecuteReader())
                    {
                        if (!reader.Read() || reader.IsDBNull(0) ||
                            Convert.ToDecimal(reader.GetValue(0), CultureInfo.InvariantCulture) != plan.AfterStock ||
                            reader.Read())
                            throw new InvalidOperationException(
                                "Persisted stock differs from adjustment; rollback required.");
                    }
                }

                // Legacy movement schema has no dedicated before/after/user columns.
                // Keep a bounded, explicit audit in LIBELLE without changing shop schema.
                using (var movement = new MySqlCommand(
                    "INSERT INTO TABLE_MOUVEMENTS_STOCK " +
                    "(DATES, HEURE, LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE) " +
                    "VALUES (@date, @time, @audit, @id, @code, @name, @delta)",
                    connection, transaction))
                {
                    DateTime now = DateTime.Now;
                    movement.Parameters.AddWithValue("@date", now);
                    movement.Parameters.AddWithValue("@time", now.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
                    movement.Parameters.AddWithValue("@audit", audit);
                    movement.Parameters.AddWithValue("@id", plan.ArticleId);
                    movement.Parameters.AddWithValue("@code", code);
                    movement.Parameters.AddWithValue("@name", name);
                    movement.Parameters.AddWithValue("@delta", plan.Delta);
                    if (movement.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("Stock movement audit failed; rollback required.");
                }
                using (var release = new MySqlCommand("RELEASE SAVEPOINT " + savepointName, connection, transaction))
                    release.ExecuteNonQuery();
            }
            catch
            {
                // ROLLBACK TO retains the savepoint in MariaDB. Release it after
                // undoing the adjustment, so callers may continue the transaction.
                using (var rollback = new MySqlCommand("ROLLBACK TO SAVEPOINT " + savepointName, connection, transaction))
                    rollback.ExecuteNonQuery();
                using (var release = new MySqlCommand("RELEASE SAVEPOINT " + savepointName, connection, transaction))
                    release.ExecuteNonQuery();
                throw;
            }
        }
    }
}
