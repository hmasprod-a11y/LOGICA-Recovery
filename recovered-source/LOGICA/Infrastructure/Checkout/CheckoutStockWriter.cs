using System;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class CheckoutStockWriter
    {
        // Keep the V1 signed-quantity rule: positive sale subtracts stock,
        // negative return restores it. Never interpolate article IDs into SQL.
        // Both stock and movement MUST use the caller-owned transaction.
        public static void Apply(MySqlCommand command, MySqlConnection connection, string ticket,
            object articleId, object articleCode, object articleName, object basketQuantity)
        {
            if (command == null) throw new ArgumentNullException("command");
            if (connection == null) throw new ArgumentNullException("connection");
            if (connection.State != ConnectionState.Open ||
                command.Transaction == null ||
                !Object.ReferenceEquals(command.Transaction.Connection, connection) ||
                (command.Connection != null && !Object.ReferenceEquals(command.Connection, connection)))
                throw new InvalidOperationException("Stock posting requires the active checkout transaction on the same open connection.");
            decimal quantity = Conversions.ToDecimal(basketQuantity);
            if (quantity == 0m) throw new InvalidOperationException("Zero-quantity stock posting is invalid.");
            if (articleId == null || articleId == DBNull.Value ||
                String.IsNullOrWhiteSpace(Conversions.ToString(articleId)))
                throw new InvalidOperationException("Stock posting requires a stable article identity.");
            command.Parameters.Clear();
            try
            {
                command.CommandText =
                    "UPDATE TABLE_ARTICLES SET STOCK = STOCK - @checkoutQuantity WHERE ID_ARTICLE = @checkoutArticleId";
                command.Connection = connection;
                command.Parameters.AddWithValue("@checkoutQuantity", quantity);
                command.Parameters.AddWithValue("@checkoutArticleId", articleId);
                if (command.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("Stock posting requires exactly one existing article.");
            }
            finally { command.Parameters.Clear(); }
            StockMovementWriter.Write(command, connection, ticket, articleId, articleCode, articleName, quantity);
        }
    }
}
