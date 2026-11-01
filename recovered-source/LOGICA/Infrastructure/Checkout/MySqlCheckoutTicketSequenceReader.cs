using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    // Reuse the existing command, connection and transaction. Prepare assigns
    // CommandText before Connection exactly once, as in Form_3_VENTE.
    internal sealed class MySqlCheckoutTicketSequenceReader : ICheckoutTicketSequenceSource
    {
        private readonly MySqlCommand command;
        private readonly MySqlConnection connection;

        internal MySqlCheckoutTicketSequenceReader(MySqlCommand command, MySqlConnection connection)
        {
            this.command = command;
            this.connection = connection;
        }

        public void Prepare()
        {
            command.CommandText = CheckoutTicketSequenceSql.SelectCurrent;
            command.Connection = connection;
        }

        public object ExecuteScalar() { return command.ExecuteScalar(); }
    }
}
