using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Domain;

internal static class StockValidationFlowTests
{
    private sealed class Semantics : ILegacyCheckoutSemantics
    {
        internal readonly List<string> Events;
        internal Semantics(List<string> events) { Events = events; }
        public bool EqualsText(string a, string b) { throw new NotSupportedException(); }
        public double ToDouble(string a) { throw new NotSupportedException(); }
        public decimal ToDecimal(string a) { throw new NotSupportedException(); }
        public double Val(object a) { throw new NotSupportedException(); }
        public bool IsStockBelow(object available, object requested)
        {
            Events.Add("compare");
            return Convert.ToDecimal(available) < Convert.ToDecimal(requested);
        }
    }
    private sealed class Lookup : IStockAvailabilityLookup
    {
        internal readonly List<string> Events;
        internal Lookup(List<string> events) { Events = events; }
        public StockLookupResult FindByCode(object code)
        {
            string id = (string)code;
            Events.Add("lookup:" + id);
            if (id == "missing") return new StockLookupResult { Found = false };
            return new StockLookupResult {
                Found = true, AvailableStock = 2m,
                ReadArticleName = delegate { Events.Add("name:" + id); return id; }
            };
        }
    }
    private static void Same(List<string> actual, string expected)
    {
        string joined = String.Join(",", actual.ToArray());
        if (joined != expected) throw new Exception("Stock read order changed: " + joined + " != " + expected);
    }
    public static int Main()
    {
        var events = new List<string>();
        var rows = new[] {
            new StockValidationRow { ArticleCode = "missing", ReadQuantity = delegate {
                throw new Exception("Missing stock must not read quantity");
            }},
            new StockValidationRow { ArticleCode = "enough", ReadQuantity = delegate {
                events.Add("quantity:enough"); return 1m;
            }},
            new StockValidationRow { ArticleCode = "short", ReadQuantity = delegate {
                events.Add("quantity:short"); return 3m;
            }},
            new StockValidationRow { ArticleCode = "unreachable", ReadQuantity = delegate {
                throw new Exception("Rows after shortage must not be read");
            }}
        };
        StockShortage shortage = StockValidationService.FindFirstShortage(
            new Lookup(events), rows, new Semantics(events));
        if (shortage == null || !Object.Equals(shortage.ArticleName, "short"))
            throw new Exception("First shortage changed");
        Same(events, "lookup:missing,lookup:enough,quantity:enough,compare,lookup:short,quantity:short,compare,name:short");

        events.Clear();
        StockShortage none = StockValidationService.FindFirstShortage(
            new Lookup(events), new[] { rows[0], rows[1] }, new Semantics(events));
        if (none != null) throw new Exception("Unexpected shortage");
        Same(events, "lookup:missing,lookup:enough,quantity:enough,compare");

        events.Clear();
        bool failed = false;
        try {
            StockValidationService.FindFirstShortage(new Lookup(events), new[] {
                new StockValidationRow { ArticleCode = "short", ReadQuantity = delegate {
                    events.Add("quantity:fail"); throw new InvalidOperationException("quantity");
                }}
            }, new Semantics(events));
        }
        catch (InvalidOperationException ex) { failed = ex.Message == "quantity"; }
        if (!failed) throw new Exception("Quantity exception swallowed");
        Same(events, "lookup:short,quantity:fail");
        Console.WriteLine("PASS stock lookup: missing rows, lazy quantities, first shortage and exception propagation");
        return 0;
    }
}
