using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Purchasing
{
    // Opt-in transaction primitive, NOT wired to the legacy receipt handler.
    // The caller must own one InnoDB transaction spanning this claim, stock,
    // stock movements, receipt details and Commit/Rollback. ID_BR must have
    // a UNIQUE index: without it, a concurrent header insertion is not excluded.
    // Do not call this until QA/Checkout approve the posting contract/schema.
    internal static class ReceiptValidationClaim
    {
        private static void EnsureTransactionalSchema(MySqlConnection connection,
            MySqlTransaction transaction)
        {
            var required = new HashSet<string>(StringComparer.OrdinalIgnoreCase) {
                "TABLE_RECEPTIONS_ENTETE", "TABLE_RECEPTIONS_DETAILS",
                "TABLE_ARTICLES", "TABLE_MOUVEMENTS_STOCK"
            };
            using (var command = new MySqlCommand(
                "SELECT TABLE_NAME, ENGINE FROM information_schema.TABLES " +
                "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME IN " +
                "('TABLE_RECEPTIONS_ENTETE','TABLE_RECEPTIONS_DETAILS'," +
                "'TABLE_ARTICLES','TABLE_MOUVEMENTS_STOCK')",
                connection, transaction))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = Convert.ToString(reader.GetValue(0));
                    string engine = reader.IsDBNull(1) ? "" : Convert.ToString(reader.GetValue(1));
                    if (!required.Remove(name) ||
                        !String.Equals(engine, "InnoDB", StringComparison.OrdinalIgnoreCase))
                        throw new InvalidOperationException("Receipt posting requires transactional InnoDB tables.");
                }
            }
            if (required.Count != 0)
                throw new InvalidOperationException("Receipt posting schema is incomplete.");

            // A unique composite index does not protect ID_BR alone.
            bool uniqueReceiptNumber = false;
            using (var command = new MySqlCommand(
                "SELECT COUNT(*), SUM(CASE WHEN COLUMN_NAME = 'ID_BR' THEN 1 ELSE 0 END) " +
                "FROM information_schema.STATISTICS WHERE TABLE_SCHEMA = DATABASE() " +
                "AND TABLE_NAME = 'TABLE_RECEPTIONS_ENTETE' AND NON_UNIQUE = 0 " +
                "GROUP BY INDEX_NAME",
                connection, transaction))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                    if (!reader.IsDBNull(0) && !reader.IsDBNull(1) &&
                        Convert.ToInt32(reader.GetValue(0)) == 1 &&
                        Convert.ToInt32(reader.GetValue(1)) == 1)
                        uniqueReceiptNumber = true;
            }
            if (!uniqueReceiptNumber)
                throw new InvalidOperationException("Receipt ID_BR requires a single-column UNIQUE index.");
        }

        // Must be the FIRST write before applying stock or movements.
        // A false result means missing/already validated; caller must not post.
        // Throws on malformed/duplicate headers or a broken transaction boundary.
        internal static bool TryClaim(MySqlConnection connection,
            MySqlTransaction transaction, string receiptId)
        {
            if (connection == null) throw new ArgumentNullException("connection");
            if (transaction == null) throw new ArgumentNullException("transaction");
            if (String.IsNullOrWhiteSpace(receiptId))
                throw new ArgumentException("Receipt ID is required.", "receiptId");
            if (connection.State != ConnectionState.Open ||
                !Object.ReferenceEquals(transaction.Connection, connection))
                throw new InvalidOperationException("Receipt claim requires its caller's open transaction.");

            // Fail closed if a legacy/non-transactional table or non-unique
            // receipt number would invalidate exactly-once/rollback guarantees.
            EnsureTransactionalSchema(connection, transaction);
            string state;
            using (var select = new MySqlCommand(
                "SELECT ETAT FROM TABLE_RECEPTIONS_ENTETE WHERE ID_BR = @receiptId FOR UPDATE",
                connection, transaction))
            {
                select.Parameters.AddWithValue("@receiptId", receiptId);
                using (MySqlDataReader reader = select.ExecuteReader())
                {
                    if (!reader.Read()) return false;
                    state = reader.IsDBNull(0) ? null : Convert.ToString(reader.GetValue(0));
                    if (reader.Read())
                        throw new InvalidOperationException("Duplicate receipt header number; refusing stock posting.");
                }
            }

            if (String.IsNullOrWhiteSpace(state))
                throw new InvalidOperationException("Receipt header has no valid state.");
            if (String.Equals(state, "VALIDER", StringComparison.OrdinalIgnoreCase))
                return false;
            // The legacy receipt editor persists a pending receipt as ENREGISTRER.
            // Do not turn cancelled, draft or unknown states into a stock posting.
            if (!String.Equals(state, "ENREGISTRER", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Only registered receipts can be validated.");

            using (var update = new MySqlCommand(
                "UPDATE TABLE_RECEPTIONS_ENTETE SET ETAT = 'VALIDER' " +
                "WHERE ID_BR = @receiptId AND ETAT = 'ENREGISTRER'",
                connection, transaction))
            {
                update.Parameters.AddWithValue("@receiptId", receiptId);
                if (update.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("Receipt validation claim lost; rollback required.");
            }
            return true;
        }
    }
}
