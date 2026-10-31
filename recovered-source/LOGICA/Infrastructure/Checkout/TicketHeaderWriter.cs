using LOGICA.Infrastructure.Compatibility;
using LOGICA.ApplicationLayer.Checkout;
using System;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class TicketHeaderWriter
    {
        // Retains the original SQL and culture conversion; caller owns transaction/lifetime.
        public static void Write(MySqlCommand command, MySqlConnection connection, TicketHeaderRecord header)
        {
            command.CommandText = CheckoutTicketPostingSql.Header(header, VisualBasicTicketPostingSemantics.Instance);
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
