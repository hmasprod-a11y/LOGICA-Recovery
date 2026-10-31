using LOGICA.ApplicationLayer.Checkout;
using System;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class TicketJournalWriter
    {
        // Keep the original INSERT ... SELECT and caller-owned transaction unchanged.
        public static void Write(MySqlCommand command, MySqlConnection connection, TicketJournalRecord journal)
        {
            command.CommandText = CheckoutTicketPostingSql.Journal(journal);
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
