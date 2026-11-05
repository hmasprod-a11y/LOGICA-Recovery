using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    // Transactional consumption primitive for a full-ticket cash return.
    // Requires an explicitly provisioned InnoDB table with a UNIQUE original_ticket_id.
    // No schema creation or migration occurs on a shop database.
    internal static class CashReturnConsumptionClaim
    {
        // The only supported full-ticket return preflight: authoritative original
        // journal and settlement are locked before the durable consumption claim.
        // Call inside the SAME transaction that posts signed refund/payment/stock.
        internal static decimal VerifyAndClaimFullOriginal(
            MySqlConnection connection, MySqlTransaction transaction,
            string originalTicketId, string returnOperationId,
            string articleId, decimal originalQuantity)
        {
            if (string.Equals(originalTicketId, returnOperationId, StringComparison.Ordinal))
                throw new InvalidOperationException("A refund cannot reuse the original sale operation.");
            decimal amount = CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLineAmount(
                connection, transaction, originalTicketId, articleId, originalQuantity);
            ClaimFullOriginal(connection, transaction, originalTicketId,
                returnOperationId, originalQuantity);
            return amount;
        }

        internal static void ClaimFullOriginal(
            MySqlConnection connection, MySqlTransaction transaction,
            string originalTicketId, string returnOperationId, decimal quantity)
        {
            if (connection == null || transaction == null ||
                !ReferenceEquals(transaction.Connection, connection) ||
                connection.State != ConnectionState.Open)
                throw new InvalidOperationException("Return claim requires the active checkout transaction.");
            if (string.IsNullOrWhiteSpace(originalTicketId) || originalTicketId.Length > 64 ||
                originalTicketId.Trim() != originalTicketId ||
                string.IsNullOrWhiteSpace(returnOperationId) || returnOperationId.Length > 64 ||
                returnOperationId.Trim() != returnOperationId || quantity <= 0m)
                throw new InvalidOperationException("Canonical return identifiers and positive quantity are required.");
            foreach (char c in originalTicketId + returnOperationId)
                if (char.IsControl(c))
                    throw new InvalidOperationException("Return identifier contains a control character.");

            // Fail closed when the dedicated ledger is absent or nontransactional.
            using (var engine = connection.CreateCommand())
            {
                engine.Transaction = transaction;
                engine.CommandText =
                    "SELECT ENGINE FROM information_schema.TABLES " +
                    "WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='hanouty_cash_return_consumption'";
                if (!string.Equals(Convert.ToString(engine.ExecuteScalar()), "InnoDB", StringComparison.Ordinal))
                    throw new InvalidOperationException("Durable InnoDB return consumption ledger is required.");
            }
            // The original header is locked by CashReturnOriginalSaleEvidence before this call.
            // The unique original_ticket_id index serializes competing return IDs,
            // including independent sessions and after process restart.
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText =
                    "INSERT INTO hanouty_cash_return_consumption " +
                    "(original_ticket_id, return_operation_id, consumed_quantity) " +
                    "VALUES (@original,@return,@quantity)";
                command.Parameters.AddWithValue("@original", originalTicketId);
                command.Parameters.AddWithValue("@return", returnOperationId);
                command.Parameters.AddWithValue("@quantity", quantity);
                try
                {
                    if (command.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("Original sale consumption was not persisted.");
                }
                catch (MySqlException ex) when (ex.Number == 1062)
                {
                    throw new InvalidOperationException("Original sale was already returned.", ex);
                }
            }
        }
    }
}
