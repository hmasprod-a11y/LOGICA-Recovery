using System;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal sealed class TicketHeaderRecord
    {
        public string TicketId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; }
        public object ClientId { get; set; }
        public object ClientCode { get; set; }
        public string ClientName { get; set; }
        public string Workstation { get; set; }
        public string TotalText { get; set; }
        public string Operation { get; set; }
    }

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
