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
