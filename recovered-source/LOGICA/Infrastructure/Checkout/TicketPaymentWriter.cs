using LOGICA.Infrastructure.Compatibility;
using LOGICA.ApplicationLayer.Checkout;
using System;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class TicketPaymentWriter
    {
        // Preserve each legacy SQL/conversion path; caller owns connection and transaction.
        public static void WriteCash(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, string amountText)
        {
            command.CommandText = CheckoutTicketPostingSql.Cash(context, amountText, VisualBasicTicketPostingSemantics.Instance);
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public static void WriteTendered(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, object amount, object mode)
        {
            command.CommandText = CheckoutTicketPostingSql.Tendered(context, amount, mode, VisualBasicTicketPostingSemantics.Instance);
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public static void WriteChange(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, string amountText)
        {
            command.CommandText = CheckoutTicketPostingSql.Change(context, amountText, VisualBasicTicketPostingSemantics.Instance);
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
