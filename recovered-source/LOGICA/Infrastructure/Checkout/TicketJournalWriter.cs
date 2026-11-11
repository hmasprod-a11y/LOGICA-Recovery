using System;
using System.Linq;
using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class TicketJournalWriter
    {
        public static void Write(MySqlCommand command, MySqlConnection connection, TicketJournalRecord journal)
        {
            // SQL identifiers cannot be parameters; permit only the existing
            // workstation identifier alphabet, never arbitrary SQL.
            if (string.IsNullOrEmpty(journal.Workstation) ||
                journal.Workstation.Any(c => !(((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')) || c == '_')))
                throw new InvalidOperationException("Invalid workstation identifier.");
            command.Parameters.Clear();
            try
            {
                command.Connection = connection;
                command.CommandText = "INSERT INTO TABLE_VENTES_JOURNAL (ID_TICKET,Ticket,Dates,Heure,ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,Qté,Remise,Total_NET,TAUX_TVA,GROUPE,Caissier,Vendeur,ID_CLIENT,CODE_CLIENT,CLIENT,POSTE,OPERATION,NOTES,NOTES_TYPE_PRIX,NOTES_MODE_P) SELECT @id,@ticket,@date,@time,ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V,Qté,Remise,TOTAL_NET,TAUX_TVA,GROUPE,@cashier,@seller,@clientId,@clientCode,@client,@poste,@operation,'',@priceType,@paymentModes FROM TABLE_" + journal.Workstation;
                command.Parameters.AddWithValue("@id", journal.TicketId ?? "");
                command.Parameters.AddWithValue("@ticket", journal.TicketNumber ?? "");
                command.Parameters.AddWithValue("@date", journal.SaleDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@time", journal.SaleDate.ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@cashier", journal.Cashier ?? "");
                command.Parameters.AddWithValue("@seller", journal.Seller ?? "");
                command.Parameters.AddWithValue("@clientId", Convert.ToString(journal.ClientId) ?? "");
                command.Parameters.AddWithValue("@clientCode", Convert.ToString(journal.ClientCode) ?? "");
                command.Parameters.AddWithValue("@client", journal.ClientName ?? "");
                command.Parameters.AddWithValue("@poste", journal.Workstation);
                command.Parameters.AddWithValue("@operation", journal.Operation ?? "");
                command.Parameters.AddWithValue("@priceType", journal.PriceType ?? "");
                command.Parameters.AddWithValue("@paymentModes", journal.PaymentModes ?? "");
                command.ExecuteNonQuery();
            }
            finally { command.Parameters.Clear(); }
        }
    }
}
