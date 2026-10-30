using LOGICA.ApplicationLayer.Checkout;
using System;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class TicketHeaderWriter
    {
        // Retains the original SQL and culture conversion; caller owns transaction/lifetime.
        public static void Write(MySqlCommand command, MySqlConnection connection, TicketHeaderRecord header)
        {
            command.CommandText = "INSERT  INTO   TABLE_VENTES_ENTETE               (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, Total_NET, OPERATION)         values           ('" + header.TicketId + "' ,'" + header.TicketNumber + "' ,'" + header.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + header.Cashier + "'   ,'" + header.ClientId + "', '" + header.ClientCode + "'  ,'" + header.ClientName + "'  ,'" + header.Workstation + "'  , '" + Conversions.ToString(Conversions.ToDecimal(header.TotalText)) + "'  , '" + header.Operation + "'    )        ";
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
