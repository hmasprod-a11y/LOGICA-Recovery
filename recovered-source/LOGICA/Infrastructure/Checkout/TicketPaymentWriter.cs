using System;
using LOGICA.ApplicationLayer.Checkout;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class TicketPaymentWriter
    {
        public static void WriteCash(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, string amountText) =>
            Write(command, connection, context, Conversions.ToDecimal(amountText), "ESPECES");

        public static void WriteTendered(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, object amount, object mode) =>
            Write(command, connection, context, Conversions.ToDecimal(amount), Conversions.ToString(mode));

        public static void WriteChange(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, string amountText) =>
            Write(command, connection, context, Conversions.ToDecimal(amountText), "ESPECES");

        private static void Write(MySqlCommand command, MySqlConnection connection,
            TicketPaymentContext context, decimal amount, string mode)
        {
            command.Parameters.Clear();
            try
            {
                command.Connection = connection;
                command.CommandText = "INSERT INTO TABLE_VENTES_REGLEMENTS (ID_TICKET,TICKET,DATES,CAISSIER,ID_CLIENT,CODE_CLIENT,CLIENT,POSTE,MONTANT,MODE_P,OPERATION,NOTES_REMARQUE) VALUES (@id,@ticket,@date,@cashier,@clientId,@clientCode,@client,@poste,@amount,@mode,@operation,@remark)";
                command.Parameters.AddWithValue("@id", context.TicketId ?? "");
                command.Parameters.AddWithValue("@ticket", context.TicketNumber ?? "");
                command.Parameters.AddWithValue("@date", context.SaleDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@cashier", context.Cashier ?? "");
                command.Parameters.AddWithValue("@clientId", Convert.ToString(context.ClientId) ?? "");
                command.Parameters.AddWithValue("@clientCode", Convert.ToString(context.ClientCode) ?? "");
                command.Parameters.AddWithValue("@client", context.ClientName ?? "");
                command.Parameters.AddWithValue("@poste", context.Workstation ?? "");
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@mode", mode ?? "");
                command.Parameters.AddWithValue("@operation", context.Operation ?? "");
                command.Parameters.AddWithValue("@remark", context.Remark ?? "");
                if (command.ExecuteNonQuery() != 1) throw new InvalidOperationException("Ticket payment was not persisted.");
            }
            finally { command.Parameters.Clear(); }
        }
    }
}
