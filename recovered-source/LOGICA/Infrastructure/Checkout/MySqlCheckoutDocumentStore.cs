using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal sealed class MySqlCheckoutDocumentStore : ICheckoutDocumentStore
    {
        private readonly MySqlCommand command;
        private readonly MySqlConnection connection;

        public MySqlCheckoutDocumentStore(MySqlCommand command, MySqlConnection connection)
        {
            this.command = command;
            this.connection = connection;
        }

        public void WriteHeader(TicketHeaderRecord header) { TicketHeaderWriter.Write(command, connection, header); }
        public void WriteJournal(TicketJournalRecord journal) { TicketJournalWriter.Write(command, connection, journal); }
        public void WritePayment(TicketPaymentWrite payment)
        {
            switch (payment.Kind)
            {
                case TicketPaymentKind.Cash:
                    TicketPaymentWriter.WriteCash(command, connection, payment.Context, payment.AmountText);
                    break;
                case TicketPaymentKind.Tendered:
                    TicketPaymentWriter.WriteTendered(command, connection, payment.Context, payment.Amount, payment.Mode);
                    break;
                case TicketPaymentKind.Change:
                    TicketPaymentWriter.WriteChange(command, connection, payment.Context, payment.AmountText);
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException("payment.Kind");
            }
        }
        public void Complete(CheckoutCompletionRecord completion)
        {
            CheckoutCompletionWriter.Complete(command, connection, completion.Workstation, completion.TicketNumber);
        }
    }
}
