using LOGICA.Infrastructure.Compatibility;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class CheckoutCompletionWriter
    {
        // Executes the original DELETE before converting/formatting the next ticket ID.
        // Transaction ownership, command reuse and failure behavior remain unchanged.
        public static void Complete(MySqlCommand command, MySqlConnection connection,
            string workstation, string ticketNumber)
        {
            command.CommandText = CheckoutCompletionSql.DeleteWorkstation(workstation);
            command.Connection = connection;
            command.ExecuteNonQuery();
            command.CommandText = CheckoutCompletionSql.AdvanceSequence(
                ticketNumber, VisualBasicCheckoutCompletionSemantics.Instance);
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
