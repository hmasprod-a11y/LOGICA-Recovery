using LOGICA.ApplicationLayer.Checkout;
using System;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class TicketJournalWriter
    {
        // Keep the original INSERT ... SELECT and caller-owned transaction unchanged.
        public static void Write(MySqlCommand command, MySqlConnection connection, TicketJournalRecord journal)
        {
            command.CommandText = "INSERT  INTO   TABLE_VENTES_JOURNAL              (ID_TICKET, Ticket, Dates , Heure,ID_ARTICLE, Code, Article, Famille, PRIX_A, PRIX_MP, PRIX_V, Qté, Remise, Total_NET ,TAUX_TVA  , GROUPE,  Caissier, Vendeur , ID_CLIENT, CODE_CLIENT, CLIENT , POSTE, OPERATION, NOTES  ,NOTES_TYPE_PRIX  ,NOTES_MODE_P   )          SELECT        '" + journal.TicketId + "' ,'" + journal.TicketNumber + "', '" + journal.SaleDate.ToString("yyyy-MM-dd") + "', '" + journal.SaleDate.ToString("HH:mm:ss") + "', TABLE_" + journal.Workstation + ".ID_ARTICLE, TABLE_" + journal.Workstation + ".Code, TABLE_" + journal.Workstation + ".Article, TABLE_" + journal.Workstation + ".Famille, TABLE_" + journal.Workstation + ".PRIX_A, TABLE_" + journal.Workstation + ".PRIX_MP, TABLE_" + journal.Workstation + ".PRIX_V, TABLE_" + journal.Workstation + ".Qté, TABLE_" + journal.Workstation + ".Remise, TABLE_" + journal.Workstation + ".TOTAL_NET,  TABLE_" + journal.Workstation + ".TAUX_TVA,  TABLE_" + journal.Workstation + ".GROUPE,          '" + journal.Cashier + "' , '" + journal.Seller + "' ,'" + journal.ClientId + "', '" + journal.ClientCode + "'  ,'" + journal.ClientName + "'  ,'" + journal.Workstation + "'   , '" + journal.Operation + "' , ''       , '" + journal.PriceType + "'      , '" + journal.PaymentModes + "'       FROM TABLE_" + journal.Workstation + "";
            command.Connection = connection;
            command.ExecuteNonQuery();
        }
    }
}
