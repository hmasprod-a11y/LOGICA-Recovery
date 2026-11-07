using System;
using LOGICA.ApplicationLayer.Checkout;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class TicketHeaderWriter
    {
        // Preserve the record mapping and VB decimal conversion, but bind values
        // so valid cashier/customer names and culture-specific decimals are data.
        public static void Write(MySqlCommand command, MySqlConnection connection, TicketHeaderRecord header)
        {
            command.Parameters.Clear();
            try
            {
                command.Connection = connection;
                command.CommandText = "INSERT INTO TABLE_VENTES_ENTETE (ID_TICKET,TICKET,DATES,CAISSIER,ID_CLIENT,CODE_CLIENT,CLIENT,POSTE,Total_NET,OPERATION) VALUES (@id,@ticket,@date,@cashier,@clientId,@clientCode,@client,@poste,@total,@operation)";
                command.Parameters.AddWithValue("@id", header.TicketId ?? "");
                command.Parameters.AddWithValue("@ticket", header.TicketNumber ?? "");
                command.Parameters.AddWithValue("@date", header.SaleDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@cashier", header.Cashier ?? "");
                command.Parameters.AddWithValue("@clientId", Convert.ToString(header.ClientId) ?? "");
                command.Parameters.AddWithValue("@clientCode", Convert.ToString(header.ClientCode) ?? "");
                command.Parameters.AddWithValue("@client", header.ClientName ?? "");
                command.Parameters.AddWithValue("@poste", header.Workstation ?? "");
                command.Parameters.AddWithValue("@total", Conversions.ToDecimal(header.TotalText));
                command.Parameters.AddWithValue("@operation", header.Operation ?? "");
                if (command.ExecuteNonQuery() != 1) throw new InvalidOperationException("Ticket header was not persisted.");
            }
            finally { command.Parameters.Clear(); }
        }
    }
}
