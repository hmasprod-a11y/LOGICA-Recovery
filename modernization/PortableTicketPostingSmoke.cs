using System;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;
using LOGICA.Infrastructure.Checkout;

internal static class PortableTicketPostingSmoke
{
    private sealed class Port : ILegacyTicketPostingSemantics
    {
        public string DecimalText(string value) { return Decimal.Parse(value, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture); }
        public string DecimalText(object value) { return Convert.ToDecimal(value, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture); }
        public object Concatenate(object left, object right) { return String.Concat(left, right); }
        public string ToText(object value) { return Convert.ToString(value, CultureInfo.InvariantCulture); }
    }

    internal static int Run()
    {
        var port = new Port();
        var date = new DateTime(2026, 10, 31, 12, 34, 56);
        var header = new TicketHeaderRecord { TicketId = "I1", TicketNumber = "42",
            SaleDate = date, Cashier = "C", ClientId = 7, ClientCode = "X",
            ClientName = "N", Workstation = "POS1", TotalText = "15.50", Operation = "VENTE" };
        var journal = new TicketJournalRecord { TicketId = "I1", TicketNumber = "42",
            SaleDate = date, Cashier = "C", Seller = "V", ClientId = 7, ClientCode = "X",
            ClientName = "N", Workstation = "POS1", Operation = "VENTE",
            PriceType = "DETAIL", PaymentModes = "ESPECES" };
        var context = new TicketPaymentContext { TicketId = "I1", TicketNumber = "42",
            SaleDate = date, Cashier = "C", ClientId = 7, ClientCode = "X",
            ClientName = "N", Workstation = "POS1", Operation = "VENTE", Remark = "R" };
        string h = CheckoutTicketPostingSql.Header(header, port);
        string j = CheckoutTicketPostingSql.Journal(journal);
        string cash = CheckoutTicketPostingSql.Cash(context, "15.50", port);
        string tendered = CheckoutTicketPostingSql.Tendered(context, 15.50m, "CARTE", port);
        string change = CheckoutTicketPostingSql.Change(context, "1.50", port);
        if (!h.Contains("TABLE_VENTES_ENTETE") || !h.Contains("'15.50'") ||
            !j.Contains("TABLE_VENTES_JOURNAL") || !j.Contains("TABLE_POS1") ||
            !j.Contains("12:34:56") || !cash.Contains("'ESPECES'") ||
            !tendered.Contains("'CARTE'") || !change.Contains("'ESPECES'"))
            throw new Exception("Portable ticket posting SQL changed");
        Console.WriteLine("PASS .NET 10 ticket posting SQL: header, journal, cash, tendered, change");
        return 0;
    }
}
