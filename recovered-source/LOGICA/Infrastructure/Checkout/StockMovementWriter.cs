using System;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class StockMovementWriter
    {
        // Uses the caller's existing command/transaction; does not own their lifetime.
        public static void Write(MySqlCommand command, MySqlConnection connection, string ticket,
            object articleId, object articleCode, object articleName, object basketQuantity)
        {
            command.CommandText = "INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES, HEURE, LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE) VALUES (@movementDate, @movementTime, @movementLabel, @movementId, @movementCode, @movementArticle, @movementQuantity)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@movementDate", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@movementTime", DateTime.Now.ToString("HH:mm:ss"));
            command.Parameters.AddWithValue("@movementLabel", "TICKET | " + ticket);
            command.Parameters.AddWithValue("@movementId", articleId);
            command.Parameters.AddWithValue("@movementCode", articleCode);
            command.Parameters.AddWithValue("@movementArticle", articleName);
            command.Parameters.AddWithValue("@movementQuantity", -Conversions.ToDecimal(basketQuantity));
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }
}
