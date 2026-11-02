using System;
using System.Data;
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

            using (var update = new MySqlCommand(
                "UPDATE TABLE_RECEPTIONS_ENTETE SET ETAT = 'VALIDER' " +
                "WHERE ID_BR = @receiptId AND ETAT <> 'VALIDER'",
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
