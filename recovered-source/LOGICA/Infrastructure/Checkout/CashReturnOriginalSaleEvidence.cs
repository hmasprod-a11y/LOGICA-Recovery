using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    // Fail-closed prerequisite for the future V1 cash-return posting path.
    // This deliberately does NOT authorize or post a refund: a durable original
    // reference and consumed-quantity lock must be proven before IsReturn opens.
    internal static class CashReturnOriginalSaleEvidence
    {
        // Validate the original payment evidence using the same locked transaction.
        // A positive header alone cannot establish eligibility for a cash refund.
        internal static decimal ReadExactCashTenderAmount(
            MySqlConnection connection, MySqlTransaction transaction, string originalTicketId)
        {
            decimal originalTotal = ReadExactCashSaleAmount(connection, transaction, originalTicketId);
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText =
                    "SELECT MONTANT,MODE_P,OPERATION FROM TABLE_VENTES_REGLEMENTS " +
                    "WHERE BINARY ID_TICKET=BINARY @original FOR UPDATE";
                command.Parameters.AddWithValue("@original", originalTicketId);
                using (var reader = command.ExecuteReader())
                {
                    decimal sum = 0m;
                    int count = 0;
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0) || reader.IsDBNull(1) || reader.IsDBNull(2) ||
                            !string.Equals(Convert.ToString(reader.GetValue(1)), "ESPECES", StringComparison.Ordinal) ||
                            !string.Equals(Convert.ToString(reader.GetValue(2)), "VENTE", StringComparison.Ordinal))
                            throw new InvalidOperationException("Original payment is not an exact cash sale.");
                        decimal amount = Convert.ToDecimal(reader.GetValue(0));
                        if (amount <= 0m)
                            throw new InvalidOperationException("Original cash payment must be positive.");
                        sum = checked(sum + amount);
                        count++;
                    }
                    if (count != 1 || sum != originalTotal ||
                        decimal.Round(sum, 2, MidpointRounding.AwayFromZero) != sum)
                        throw new InvalidOperationException("Original sale has no unique whole-cent exact cash settlement.");
                    return sum;
                }
            }
        }

        // Original journal is the only eligible price/quantity source for a
        // full-quantity return; never recalculate from current TABLE_ARTICLES.
        // The caller must separately enforce durable one-return-per-original.
        // Immutable, authoritative row from the original sale journal.
        internal sealed class CashReturnOriginalSaleLine
        {
            internal CashReturnOriginalSaleLine(string articleId, decimal quantity, decimal amount)
            {
                ArticleId = articleId;
                Quantity = quantity;
                Amount = amount;
            }

            internal string ArticleId { get; private set; }
            internal decimal Quantity { get; private set; }
            internal decimal Amount { get; private set; }
        }

        // Lock and validate the complete original ticket line set. Every line must
        // be an undiscounted exact-cash V1 sale line; no current catalogue value
        // or caller-supplied amount participates in the proof.
        internal static IReadOnlyList<CashReturnOriginalSaleLine> ReadOriginalFullQuantityLines(
            MySqlConnection connection, MySqlTransaction transaction, string originalTicketId)
        {
            decimal paid = ReadExactCashTenderAmount(connection, transaction, originalTicketId);
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText =
                    "SELECT ID_ARTICLE,Qté,PRIX_V,Remise,Total_NET,OPERATION FROM TABLE_VENTES_JOURNAL " +
                    "WHERE BINARY ID_TICKET=BINARY @original ORDER BY BINARY ID_ARTICLE FOR UPDATE";
                command.Parameters.AddWithValue("@original", originalTicketId);
                var result = new List<CashReturnOriginalSaleLine>();
                var identities = new HashSet<string>(StringComparer.Ordinal);
                decimal total = 0m;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0) || reader.IsDBNull(1) || reader.IsDBNull(2) ||
                            reader.IsDBNull(3) || reader.IsDBNull(4) || reader.IsDBNull(5))
                            throw new InvalidOperationException("Original sale contains an incomplete line.");
                        string articleId = Convert.ToString(reader.GetValue(0));
                        decimal quantity = Convert.ToDecimal(reader.GetValue(1));
                        decimal price = Convert.ToDecimal(reader.GetValue(2));
                        decimal discount = Convert.ToDecimal(reader.GetValue(3));
                        decimal lineAmount = Convert.ToDecimal(reader.GetValue(4));
                        string operation = Convert.ToString(reader.GetValue(5));
                        if (string.IsNullOrWhiteSpace(articleId) || !identities.Add(articleId))
                            throw new InvalidOperationException("Original sale contains a missing or duplicate article identity.");
                        decimal expectedNet = Math.Round(checked(price * quantity), 2,
                            MidpointRounding.AwayFromZero);
                        if (quantity <= 0m || price < 0m || discount != 0m ||
                            lineAmount <= 0m || lineAmount != expectedNet ||
                            !string.Equals(operation, "VENTE", StringComparison.Ordinal))
                            throw new InvalidOperationException("Original sale contains a line outside the exact-cash full-return policy.");
                        total = checked(total + lineAmount);
                        result.Add(new CashReturnOriginalSaleLine(articleId, quantity, lineAmount));
                    }
                }
                if (result.Count == 0 || total != paid ||
                    decimal.Round(total, 2, MidpointRounding.AwayFromZero) != total)
                    throw new InvalidOperationException("Original line set does not equal the exact cash settlement.");
                return result.AsReadOnly();
            }
        }

        // Backward-compatible one-line evidence helper. A multi-line ticket must
        // use the complete line-set contract; it can never be partially claimed.
        internal static decimal ReadOriginalFullQuantityLineAmount(
            MySqlConnection connection, MySqlTransaction transaction,
            string originalTicketId, string articleId, decimal originalQuantity)
        {
            var lines = ReadOriginalFullQuantityLines(connection, transaction, originalTicketId);
            if (lines.Count != 1 || string.IsNullOrWhiteSpace(articleId) ||
                !string.Equals(lines[0].ArticleId, articleId, StringComparison.Ordinal) ||
                lines[0].Quantity != originalQuantity || originalQuantity <= 0m)
                throw new InvalidOperationException("Full-ticket return requires the exact complete original line set.");
            return lines[0].Amount;
        }

        internal static decimal ReadExactCashSaleAmount(
            MySqlConnection connection, MySqlTransaction transaction, string originalTicketId)
        {
            if (connection == null || transaction == null ||
                !ReferenceEquals(transaction.Connection, connection) ||
                connection.State != ConnectionState.Open)
                throw new InvalidOperationException("Original sale verification requires the active checkout transaction.");
            if (string.IsNullOrWhiteSpace(originalTicketId) || originalTicketId.Length > 64 ||
                originalTicketId.Trim() != originalTicketId)
                throw new InvalidOperationException("A canonical persisted original sale identifier is required.");
            foreach (char character in originalTicketId)
                if (char.IsControl(character))
                    throw new InvalidOperationException("Original sale identifier contains a control character.");

            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText =
                    "SELECT Total_NET FROM TABLE_VENTES_ENTETE " +
                    "WHERE BINARY ID_TICKET=BINARY @original AND BINARY OPERATION=BINARY 'VENTE' FOR UPDATE";
                command.Parameters.AddWithValue("@original", originalTicketId);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read() || reader.IsDBNull(0))
                        throw new InvalidOperationException("Original cash sale is missing.");
                    decimal total = Convert.ToDecimal(reader.GetValue(0));
                    if (reader.Read() || total <= 0m ||
                        decimal.Round(total, 2, MidpointRounding.AwayFromZero) != total)
                        throw new InvalidOperationException("Original sale is not unique or has invalid whole-cent amount.");
                    return total;
                }
            }
        }
    }
}
