using System;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal sealed class TicketPaymentContext
    {
        public string TicketId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; }
        public object ClientId { get; set; }
        public object ClientCode { get; set; }
        public string ClientName { get; set; }
        public string Workstation { get; set; }
        public string Operation { get; set; }
        public string Remark { get; set; }
    }

    internal static class TicketPaymentWriter
    {
        // Preserve each legacy SQL/conversion path; caller owns connection and transaction.
        public static void WriteCash(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, string amountText)
        {
            command.CommandText = "INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId + "' ,'" + context.TicketNumber + "' ,'" + context.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + context.Cashier + "'   ,'" + context.ClientId + "', '" + context.ClientCode + "'  ,'" + context.ClientName + "' ,'" + context.Workstation + "'  , '" + Conversions.ToString(Conversions.ToDecimal(amountText)) + "'  ,'ESPECES'   , '" + context.Operation + "'   , '" + context.Remark + "'  )          ";
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public static void WriteTendered(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, object amount, object mode)
        {
            command.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId, "' ,'"), context.TicketNumber), "' ,'"), context.SaleDate.ToString("yyyy-MM-dd")), "'  ,'"), context.Cashier), "'   ,'"), context.ClientId), "', '"), context.ClientCode), "'  ,'"), context.ClientName), "' ,'"), context.Workstation), "'  , '"), Conversions.ToString(Conversions.ToDecimal(amount))), "'  ,'"), mode), "' , '"), context.Operation), "'   , '"), context.Remark), "'   )          "));
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public static void WriteChange(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, string amountText)
        {
            command.CommandText = "INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId + "' ,'" + context.TicketNumber + "' ,'" + context.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + context.Cashier + "'   ,'" + context.ClientId + "', '" + context.ClientCode + "'  ,'" + context.ClientName + "' ,'" + context.Workstation + "'  , '" + Conversions.ToString(Conversions.ToDecimal(amountText)) + "'  ,'ESPECES' , '" + context.Operation + "'   , '" + context.Remark + "'   )          ";
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
