using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class CheckoutCompletionWriter
    {
        // Completes the existing writes only; the caller still commits or rolls back.
        public static void Complete(MySqlCommand command, MySqlConnection connection,
            string workstation, string ticketNumber)
        {
            command.CommandText = "Delete  from TABLE_" + workstation + "";
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.CommandText = "UPDATE     TABLE_NUM    SET CL =  " + Strings.Format(Conversions.ToDouble(ticketNumber) + 1.0, "000000") + "  ";
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
