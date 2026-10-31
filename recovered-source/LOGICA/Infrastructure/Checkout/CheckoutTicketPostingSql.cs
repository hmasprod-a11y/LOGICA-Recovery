using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;

namespace LOGICA.Infrastructure.Checkout
{
    // Exact legacy SQL text and evaluation order. Parameterization is a separate
    // migration requiring acceptance against existing shop databases.
    internal static class CheckoutTicketPostingSql
    {
        internal static string Header(TicketHeaderRecord header, ILegacyTicketPostingSemantics semantics)
        {
            return "INSERT  INTO   TABLE_VENTES_ENTETE               (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, Total_NET, OPERATION)         values           ('" + header.TicketId + "' ,'" + header.TicketNumber + "' ,'" + header.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + header.Cashier + "'   ,'" + header.ClientId + "', '" + header.ClientCode + "'  ,'" + header.ClientName + "'  ,'" + header.Workstation + "'  , '" + semantics.DecimalText(header.TotalText) + "'  , '" + header.Operation + "'    )        ";
        }

        internal static string Journal(TicketJournalRecord journal)
        {
            return "INSERT  INTO   TABLE_VENTES_JOURNAL              (ID_TICKET, Ticket, Dates , Heure,ID_ARTICLE, Code, Article, Famille, PRIX_A, PRIX_MP, PRIX_V, Qté, Remise, Total_NET ,TAUX_TVA  , GROUPE,  Caissier, Vendeur , ID_CLIENT, CODE_CLIENT, CLIENT , POSTE, OPERATION, NOTES  ,NOTES_TYPE_PRIX  ,NOTES_MODE_P   )          SELECT        '" + journal.TicketId + "' ,'" + journal.TicketNumber + "', '" + journal.SaleDate.ToString("yyyy-MM-dd") + "', '" + journal.SaleDate.ToString("HH:mm:ss") + "', TABLE_" + journal.Workstation + ".ID_ARTICLE, TABLE_" + journal.Workstation + ".Code, TABLE_" + journal.Workstation + ".Article, TABLE_" + journal.Workstation + ".Famille, TABLE_" + journal.Workstation + ".PRIX_A, TABLE_" + journal.Workstation + ".PRIX_MP, TABLE_" + journal.Workstation + ".PRIX_V, TABLE_" + journal.Workstation + ".Qté, TABLE_" + journal.Workstation + ".Remise, TABLE_" + journal.Workstation + ".TOTAL_NET,  TABLE_" + journal.Workstation + ".TAUX_TVA,  TABLE_" + journal.Workstation + ".GROUPE,          '" + journal.Cashier + "' , '" + journal.Seller + "' ,'" + journal.ClientId + "', '" + journal.ClientCode + "'  ,'" + journal.ClientName + "'  ,'" + journal.Workstation + "'   , '" + journal.Operation + "' , ''       , '" + journal.PriceType + "'      , '" + journal.PaymentModes + "'       FROM TABLE_" + journal.Workstation + "";
        }

        internal static string Cash(TicketPaymentContext context, string amountText,
            ILegacyTicketPostingSemantics semantics)
        {
            return "INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId + "' ,'" + context.TicketNumber + "' ,'" + context.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + context.Cashier + "'   ,'" + context.ClientId + "', '" + context.ClientCode + "'  ,'" + context.ClientName + "' ,'" + context.Workstation + "'  , '" + semantics.DecimalText(amountText) + "'  ,'ESPECES'   , '" + context.Operation + "'   , '" + context.Remark + "'  )          ";
        }

        internal static string Tendered(TicketPaymentContext context, object amount, object mode,
            ILegacyTicketPostingSemantics semantics)
        {
            return semantics.ToText(semantics.Concatenate(semantics.Concatenate(semantics.Concatenate(semantics.Concatenate(semantics.Concatenate(semantics.Concatenate(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId, "' ,'"), context.TicketNumber), "' ,'"), context.SaleDate.ToString("yyyy-MM-dd")), "'  ,'"), context.Cashier), "'   ,'"), context.ClientId), "', '"), context.ClientCode), "'  ,'"), context.ClientName), "' ,'"), context.Workstation), "'  , '"), semantics.DecimalText(amount)), "'  ,'"), mode), "' , '"), context.Operation), "'   , '"), context.Remark), "'   )          "));
        }

        internal static string Change(TicketPaymentContext context, string amountText,
            ILegacyTicketPostingSemantics semantics)
        {
            return "INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId + "' ,'" + context.TicketNumber + "' ,'" + context.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + context.Cashier + "'   ,'" + context.ClientId + "', '" + context.ClientCode + "'  ,'" + context.ClientName + "' ,'" + context.Workstation + "'  , '" + semantics.DecimalText(amountText) + "'  ,'ESPECES' , '" + context.Operation + "'   , '" + context.Remark + "'   )          ";
        }
    }
}
