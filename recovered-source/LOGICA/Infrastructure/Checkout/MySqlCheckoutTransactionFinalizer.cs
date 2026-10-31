using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    // No new transaction or connection: use the same instances already owned by Form_3_VENTE.
    internal sealed class MySqlCheckoutTransactionFinalizer : ICheckoutTransactionFinalizer
    {
        private readonly MySqlTransaction transaction;
        private readonly MySqlConnection connection;

        internal MySqlCheckoutTransactionFinalizer(MySqlTransaction transaction, MySqlConnection connection)
        {
            this.transaction = transaction;
            this.connection = connection;
        }

        public void Commit() { transaction.Commit(); }
        public void Close() { connection.Close(); }
    }
}
