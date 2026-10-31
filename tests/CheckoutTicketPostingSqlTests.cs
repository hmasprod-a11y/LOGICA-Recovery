using System;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;
using LOGICA.Infrastructure.Checkout;
using LOGICA.Infrastructure.Compatibility;
using Microsoft.VisualBasic.CompilerServices;

internal static class CheckoutTicketPostingSqlTests
{
    private static string LegacyHeader(TicketHeaderRecord header)
    {
        return "INSERT  INTO   TABLE_VENTES_ENTETE               (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, Total_NET, OPERATION)         values           ('" + header.TicketId + "' ,'" + header.TicketNumber + "' ,'" + header.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + header.Cashier + "'   ,'" + header.ClientId + "', '" + header.ClientCode + "'  ,'" + header.ClientName + "'  ,'" + header.Workstation + "'  , '" + Conversions.ToString(Conversions.ToDecimal(header.TotalText)) + "'  , '" + header.Operation + "'    )        ";
    }

    private static string LegacyJournal(TicketJournalRecord journal)
    {
        return "INSERT  INTO   TABLE_VENTES_JOURNAL              (ID_TICKET, Ticket, Dates , Heure,ID_ARTICLE, Code, Article, Famille, PRIX_A, PRIX_MP, PRIX_V, Qté, Remise, Total_NET ,TAUX_TVA  , GROUPE,  Caissier, Vendeur , ID_CLIENT, CODE_CLIENT, CLIENT , POSTE, OPERATION, NOTES  ,NOTES_TYPE_PRIX  ,NOTES_MODE_P   )          SELECT        '" + journal.TicketId + "' ,'" + journal.TicketNumber + "', '" + journal.SaleDate.ToString("yyyy-MM-dd") + "', '" + journal.SaleDate.ToString("HH:mm:ss") + "', TABLE_" + journal.Workstation + ".ID_ARTICLE, TABLE_" + journal.Workstation + ".Code, TABLE_" + journal.Workstation + ".Article, TABLE_" + journal.Workstation + ".Famille, TABLE_" + journal.Workstation + ".PRIX_A, TABLE_" + journal.Workstation + ".PRIX_MP, TABLE_" + journal.Workstation + ".PRIX_V, TABLE_" + journal.Workstation + ".Qté, TABLE_" + journal.Workstation + ".Remise, TABLE_" + journal.Workstation + ".TOTAL_NET,  TABLE_" + journal.Workstation + ".TAUX_TVA,  TABLE_" + journal.Workstation + ".GROUPE,          '" + journal.Cashier + "' , '" + journal.Seller + "' ,'" + journal.ClientId + "', '" + journal.ClientCode + "'  ,'" + journal.ClientName + "'  ,'" + journal.Workstation + "'   , '" + journal.Operation + "' , ''       , '" + journal.PriceType + "'      , '" + journal.PaymentModes + "'       FROM TABLE_" + journal.Workstation + "";
    }

    private static string LegacyCash(TicketPaymentContext context, string amountText)
    {
        return "INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId + "' ,'" + context.TicketNumber + "' ,'" + context.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + context.Cashier + "'   ,'" + context.ClientId + "', '" + context.ClientCode + "'  ,'" + context.ClientName + "' ,'" + context.Workstation + "'  , '" + Conversions.ToString(Conversions.ToDecimal(amountText)) + "'  ,'ESPECES'   , '" + context.Operation + "'   , '" + context.Remark + "'  )          ";
    }

    private static string LegacyTendered(TicketPaymentContext context, object amount, object mode)
    {
        return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId, "' ,'"), context.TicketNumber), "' ,'"), context.SaleDate.ToString("yyyy-MM-dd")), "'  ,'"), context.Cashier), "'   ,'"), context.ClientId), "', '"), context.ClientCode), "'  ,'"), context.ClientName), "' ,'"), context.Workstation), "'  , '"), Conversions.ToString(Conversions.ToDecimal(amount))), "'  ,'"), mode), "' , '"), context.Operation), "'   , '"), context.Remark), "'   )          "));
    }

    private static string LegacyChange(TicketPaymentContext context, string amountText)
    {
        return "INSERT  INTO   TABLE_VENTES_REGLEMENTS       (ID_TICKET, TICKET, DATES , CAISSIER , ID_CLIENT , CODE_CLIENT, CLIENT, POSTE, MONTANT, MODE_P, OPERATION ,NOTES_REMARQUE)         values           ('" + context.TicketId + "' ,'" + context.TicketNumber + "' ,'" + context.SaleDate.ToString("yyyy-MM-dd") + "'  ,'" + context.Cashier + "'   ,'" + context.ClientId + "', '" + context.ClientCode + "'  ,'" + context.ClientName + "' ,'" + context.Workstation + "'  , '" + Conversions.ToString(Conversions.ToDecimal(amountText)) + "'  ,'ESPECES' , '" + context.Operation + "'   , '" + context.Remark + "'   )          ";
    }

    private static string Outcome(Func<string> action)
    {
        try { return "ok:" + action(); }
        catch (Exception error) { return "error:" + error.GetType().FullName + ":" + error.Message; }
    }

    private static void Same(Func<string> original, Func<string> extracted, string label)
    {
        string before = Outcome(original), after = Outcome(extracted);
        if (before != after) throw new Exception(label + " legacy=[" + before + "] extracted=[" + after + "]");
    }

    private sealed class FaultPort : ILegacyTicketPostingSemantics
    {
        internal readonly Exception Failure = new InvalidOperationException("injected");
        internal int Calls;
        public string DecimalText(string value) { Calls++; throw Failure; }
        public string DecimalText(object value) { Calls++; throw Failure; }
        public object Concatenate(object left, object right) { Calls++; throw Failure; }
        public string ToText(object value) { Calls++; throw Failure; }
    }

    private static void FirstFailure(Func<FaultPort, string> action, string label)
    {
        var port = new FaultPort();
        Exception caught = null;
        try { action(port); } catch (Exception error) { caught = error; }
        if (!Object.ReferenceEquals(caught, port.Failure) || port.Calls != 1)
            throw new Exception(label + " changed first conversion exception identity");
    }

    public static int Main()
    {
        CultureInfo oldCulture = CultureInfo.CurrentCulture, oldUiCulture = CultureInfo.CurrentUICulture;
        int cases = 0;
        try
        {
            foreach (string culture in new[] { "en-US", "fr-FR", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                var header = new TicketHeaderRecord { TicketId = "T'1", TicketNumber = "000042",
                    SaleDate = new DateTime(2026, 10, 31, 12, 34, 56), Cashier = "C",
                    ClientId = DBNull.Value, ClientCode = 7, ClientName = "O'Hara",
                    Workstation = "P1", Operation = "VENTE" };
                var journal = new TicketJournalRecord { TicketId = header.TicketId,
                    TicketNumber = header.TicketNumber, SaleDate = header.SaleDate,
                    Cashier = header.Cashier, Seller = "V", ClientId = header.ClientId,
                    ClientCode = header.ClientCode, ClientName = header.ClientName,
                    Operation = header.Operation, PriceType = "DETAIL", PaymentModes = "ESPECES" };
                var context = new TicketPaymentContext { TicketId = header.TicketId,
                    TicketNumber = header.TicketNumber, SaleDate = header.SaleDate,
                    Cashier = header.Cashier, ClientId = header.ClientId,
                    ClientCode = header.ClientCode, ClientName = header.ClientName,
                    Workstation = header.Workstation, Operation = header.Operation, Remark = "note '" };
                foreach (string workstation in new[] { null, "", "P1", "O'H", "X Y", "é" })
                {
                    journal.Workstation = workstation;
                    Same(delegate { return LegacyJournal(journal); },
                        delegate { return CheckoutTicketPostingSql.Journal(journal); }, culture + "/journal");
                    cases++;
                }
                foreach (string amount in new[] { null, "", " ", "0", "42", "42.50", "-1",
                    "1,5", "2,5", "1.234,5", "1,234.5", "1e4", "1e309", "abc", "NaN" })
                {
                    header.TotalText = amount;
                    Same(delegate { return LegacyHeader(header); },
                        delegate { return CheckoutTicketPostingSql.Header(header, VisualBasicTicketPostingSemantics.Instance); },
                        culture + "/header/" + amount);
                    Same(delegate { return LegacyCash(context, amount); },
                        delegate { return CheckoutTicketPostingSql.Cash(context, amount, VisualBasicTicketPostingSemantics.Instance); },
                        culture + "/cash/" + amount);
                    Same(delegate { return LegacyChange(context, amount); },
                        delegate { return CheckoutTicketPostingSql.Change(context, amount, VisualBasicTicketPostingSemantics.Instance); },
                        culture + "/change/" + amount);
                    cases += 3;
                }
                foreach (object amount in new object[] { null, DBNull.Value, "42", "2,5",
                    "abc", 0, 42, 1.5, 3.25m, -1m, true, false, new object() })
                foreach (object mode in new object[] { null, DBNull.Value, "ESPECES", "CARTE", 7, true })
                {
                    object currentAmount = amount, currentMode = mode;
                    Same(delegate { return LegacyTendered(context, currentAmount, currentMode); },
                        delegate { return CheckoutTicketPostingSql.Tendered(context, currentAmount, currentMode,
                            VisualBasicTicketPostingSemantics.Instance); }, culture + "/tendered");
                    cases++;
                }
            }
            var exampleHeader = new TicketHeaderRecord { TotalText = "42" };
            var exampleContext = new TicketPaymentContext();
            FirstFailure(delegate(FaultPort port) { return CheckoutTicketPostingSql.Header(exampleHeader, port); }, "header");
            FirstFailure(delegate(FaultPort port) { return CheckoutTicketPostingSql.Cash(exampleContext, "42", port); }, "cash");
            FirstFailure(delegate(FaultPort port) { return CheckoutTicketPostingSql.Change(exampleContext, "42", port); }, "change");
            FirstFailure(delegate(FaultPort port) { return CheckoutTicketPostingSql.Tendered(exampleContext, 42, "ESPECES", port); }, "tendered");
            Console.WriteLine("PASS ticket posting SQL: " + cases +
                " original-VB parity cases in 3 cultures, exception identity, 5 paths");
            return 0;
        }
        finally { CultureInfo.CurrentCulture = oldCulture; CultureInfo.CurrentUICulture = oldUiCulture; }
    }
}
