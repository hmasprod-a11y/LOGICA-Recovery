using System;
using System.Data;
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
                    if (count != 1 || sum != originalTotal)
                        throw new InvalidOperationException("Original sale has no unique exact cash settlement.");
                    return sum;
                }
            }
        }

        // Original journal is the only eligible price/quantity source for a
        // full-quantity return; never recalculate from current TABLE_ARTICLES.
        // The caller must separately enforce durable one-return-per-original.
        internal static decimal ReadOriginalFullQuantityLineAmount(
            MySqlConnection connection, MySqlTransaction transaction,
            string originalTicketId, string articleId, decimal originalQuantity)
        {
            decimal paid = ReadExactCashTenderAmount(connection, transaction, originalTicketId);
            if (string.IsNullOrWhiteSpace(articleId) || originalQuantity <= 0m)
                throw new InvalidOperationException("A positive original line quantity is required.");
            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText =
                    "SELECT Qté,PRIX_V,Remise,Total_NET,OPERATION FROM TABLE_VENTES_JOURNAL " +
                    "WHERE BINARY ID_TICKET=BINARY @original AND BINARY ID_ARTICLE=BINARY @article FOR UPDATE";
                command.Parameters.AddWithValue("@original", originalTicketId);
                command.Parameters.AddWithValue("@article", articleId);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read() || reader.IsDBNull(0) || reader.IsDBNull(1) ||
                        reader.IsDBNull(2) || reader.IsDBNull(3) || reader.IsDBNull(4))
                        throw new InvalidOperationException("Original sale line is missing.");
                    decimal quantity = Convert.ToDecimal(reader.GetValue(0));
                    decimal price = Convert.ToDecimal(reader.GetValue(1));
                    decimal discount = Convert.ToDecimal(reader.GetValue(2));
                    decimal lineTotal = Convert.ToDecimal(reader.GetValue(3));
                    string operation = Convert.ToString(reader.GetValue(4));
                    if (reader.Read() || quantity != originalQuantity || price < 0m ||
                        discount != 0m || lineTotal <= 0m || lineTotal != paid ||
                        operation != "VENTE")
                        throw new InvalidOperationException("Original line is not an eligible full-quantity exact-cash sale.");
                    return lineTotal;
                }
            }
        }

        internal static decimal ReadExactCashSaleAmount(
            MySqlConnection connection, MySqlTransaction transaction, string originalTicketId)
        {
            if (connection == null || transaction == null ||
                !ReferenceEquals(transaction.Connection, connection) ||
                connection.State != ConnectionState.Open)
                throw new InvalidOperationException("Original sale verification requires the active checkout transaction.");
            if (string.IsNullOrWhiteSpace(originalTicketId) || originalTicketId.Length > 64)
                throw new InvalidOperationException("A persisted original sale identifier is required.");

            using (var command = connection.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText =
                    "SELECT Total_NET FROM TABLE_VENTES_ENTETE " +
                    "WHERE BINARY ID_TICKET=BINARY @original AND OPERATION='VENTE' FOR UPDATE";
                command.Parameters.AddWithValue("@original", originalTicketId);
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read() || reader.IsDBNull(0))
                        throw new InvalidOperationException("Original cash sale is missing.");
                    decimal total = Convert.ToDecimal(reader.GetValue(0));
                    if (reader.Read() || total <= 0m)
                        throw new InvalidOperationException("Original sale is not unique or has invalid amount.");
                    return total;
                }
            }
        }
    }
}
