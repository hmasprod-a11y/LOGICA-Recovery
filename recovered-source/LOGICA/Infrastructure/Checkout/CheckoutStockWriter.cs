using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class CheckoutStockWriter
    {
        // Apply the existing stock update and movement on the caller's transaction.
        public static void Apply(MySqlCommand command, MySqlConnection connection, string ticket,
            object articleId, object articleCode, object articleName, object basketQuantity)
        {
            command.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE     TABLE_ARTICLES    SET STOCK = STOCK - ", basketQuantity), "    WHERE    ID_ARTICLE = '"), articleId), "'                           "));
            command.Connection = connection;
            command.ExecuteNonQuery();
            StockMovementWriter.Write(command, connection, ticket, articleId, articleCode, articleName, basketQuantity);
        }
    }
}
