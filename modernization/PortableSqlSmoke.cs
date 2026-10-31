using System;
using System.Globalization;
using LOGICA.Domain;
using LOGICA.Infrastructure.Inventory;
using LOGICA.Infrastructure.Checkout;

internal static class PortableSqlSmoke
{
    private sealed class StockPort : ILegacyStockMovementQuerySemantics
    {
        public string FormatDate(DateTime value) { return value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture); }
        public object Concat(object left, object right) { return String.Concat(left, right); }
        public string ToText(object value) { return Convert.ToString(value, CultureInfo.InvariantCulture); }
    }

    private sealed class CheckoutPort : ILegacyCheckoutCompletionSemantics
    {
        public double ToDouble(string text) { return Double.Parse(text, CultureInfo.InvariantCulture); }
        public string FormatSequence(double next) { return next.ToString("000000", CultureInfo.InvariantCulture); }
    }

    internal static int Run()
    {
        var stock = new StockPort();
        var from = new DateTime(2026, 10, 31);
        var to = new DateTime(2026, 11, 1);
        string prefix = StockMovementQueryText.DatePrefix(from, to, stock);
        if (prefix.IndexOf("2026-10-31", StringComparison.Ordinal) < 0 ||
            prefix.IndexOf("2026-11-01", StringComparison.Ordinal) < 0)
            throw new Exception("Portable inventory date prefix changed");
        string contains = StockMovementQueryText.Contains("STOCK", prefix, "CODE", "needle", stock);
        string exact = StockMovementQueryText.ExactLike("STOCK", "", "CODE", "needle", stock);
        if (contains.IndexOf("like  '%needle%'", StringComparison.Ordinal) < 0 ||
            exact.IndexOf("like  'needle'", StringComparison.Ordinal) < 0)
            throw new Exception("Portable inventory SQL text changed");
        if (StockMovementQueryText.DateRange("STOCK", from, to, stock).IndexOf(
            "2026-10-31", StringComparison.Ordinal) < 0 ||
            StockMovementQueryText.Refresh("STOCK") !=
            "select * from      TABLE_STOCK                  order by   ID    desc ")
            throw new Exception("Portable inventory refresh/range SQL changed");
        if (CheckoutCompletionSql.DeleteWorkstation("POS1") != "Delete  from TABLE_POS1" ||
            CheckoutCompletionSql.AdvanceSequence("42", new CheckoutPort()) !=
            "UPDATE     TABLE_NUM    SET CL =  000043  ")
            throw new Exception("Portable checkout completion SQL changed");
        Console.WriteLine("PASS .NET 10 portable SQL boundaries: inventory query text and checkout completion");
        return 0;
    }
}
