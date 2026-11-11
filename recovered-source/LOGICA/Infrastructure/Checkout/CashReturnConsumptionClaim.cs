using System;
using System.Data;
using System.Collections.Generic;
using Hanouty.ArchitectureBridge;
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
        // Verify the caller supplied every original line exactly once, then
        // reserve the original ticket once for the whole return.
        internal static decimal VerifyAndClaimFullOriginal(
            MySqlConnection connection, MySqlTransaction transaction,
            string originalTicketId, string returnOperationId,
            IReadOnlyList<CheckoutBatchLine> requestedLines)
        {
            if (string.Equals(originalTicketId, returnOperationId, StringComparison.Ordinal))
                throw new InvalidOperationException("A refund cannot reuse the original sale operation.");
            if (requestedLines == null || requestedLines.Count == 0)
                throw new InvalidOperationException("A complete original sale line set is required.");

            var originalLines = CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLines(
                connection, transaction, originalTicketId);
            if (requestedLines.Count != originalLines.Count)
                throw new InvalidOperationException("Refund request must contain every original sale line.");

            var requested = new Dictionary<string, decimal>(StringComparer.Ordinal);
            foreach (CheckoutBatchLine line in requestedLines)
            {
                if (line == null || string.IsNullOrWhiteSpace(line.ArticleId) || line.Quantity <= 0 ||
                    !requested.TryAdd(line.ArticleId, line.Quantity))
                    throw new InvalidOperationException("Refund request contains an invalid or duplicate article line.");
            }

            decimal amount = 0m;
            decimal consumedQuantity = 0m;
            foreach (var original in originalLines)
            {
                decimal quantity;
                if (!requested.TryGetValue(original.ArticleId, out quantity) ||
                    quantity != original.Quantity)
                    throw new InvalidOperationException("Refund request does not match the complete original line set.");
                amount = checked(amount + original.Amount);
                consumedQuantity = checked(consumedQuantity + original.Quantity);
            }

            ClaimFullOriginal(connection, transaction, originalTicketId,
                returnOperationId, consumedQuantity);
            return amount;
        }

        // Retain the one-line helper for existing isolated evidence callers.
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
            if (string.Equals(originalTicketId, returnOperationId, StringComparison.Ordinal))
                throw new InvalidOperationException("A refund cannot consume its own operation as an original sale.");
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
            // Both identifiers must be independently unique, not merely a composite pair.
            // Otherwise two return operation IDs could consume the same original sale.
            foreach (string column in new[] { "original_ticket_id", "return_operation_id" })
            {
                using (var index = connection.CreateCommand())
                {
                    index.Transaction = transaction;
                    index.CommandText =
                        "SELECT COUNT(*) FROM (" +
                        "SELECT INDEX_NAME FROM information_schema.STATISTICS " +
                        "WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='hanouty_cash_return_consumption' " +
                        "AND NON_UNIQUE=0 GROUP BY INDEX_NAME " +
                        "HAVING COUNT(*)=1 AND MAX(COLUMN_NAME)=@column AND MAX(SUB_PART) IS NULL" +
                        ") AS unique_single_column";
                    index.Parameters.AddWithValue("@column", column);
                    if (Convert.ToInt64(index.ExecuteScalar()) < 1L)
                        throw new InvalidOperationException("Return ledger requires a full-column unique index on " + column + ".");
                }
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
            // Verify the actual durable claim before financial posting continues.
            // A trigger or schema drift must not silently alter the original,
            // operation identity or consumed quantity inside this transaction.
            using (var verify = connection.CreateCommand())
            {
                verify.Transaction = transaction;
                verify.CommandText =
                    "SELECT original_ticket_id, return_operation_id, consumed_quantity " +
                    "FROM hanouty_cash_return_consumption " +
                    "WHERE BINARY original_ticket_id=BINARY @original FOR UPDATE";
                verify.Parameters.AddWithValue("@original", originalTicketId);
                using (var reader = verify.ExecuteReader())
                {
                    if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) || reader.IsDBNull(2) ||
                        !string.Equals(Convert.ToString(reader.GetValue(0)), originalTicketId, StringComparison.Ordinal) ||
                        !string.Equals(Convert.ToString(reader.GetValue(1)), returnOperationId, StringComparison.Ordinal) ||
                        Convert.ToDecimal(reader.GetValue(2)) != quantity || reader.Read())
                        throw new InvalidOperationException("Persisted cash return consumption claim changed.");
                }
            }
        }
    }
}
