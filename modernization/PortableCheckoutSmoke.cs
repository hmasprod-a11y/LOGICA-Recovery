using System;
using System.Collections.Generic;
using System.Globalization;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Checkout;

// Portable test implementation is deliberately NOT the production VB adapter.
// It proves source isolation and orchestration, not cross-runtime VB parity.
internal static class PortableCheckoutSmoke
{
    private sealed class Semantics : ILegacyCheckoutSemantics
    {
        public bool EqualsText(string a, string b) { return String.Equals(a ?? "", b ?? "", StringComparison.Ordinal); }
        public double ToDouble(string value) { return Convert.ToDouble(value, CultureInfo.InvariantCulture); }
        public decimal ToDecimal(string value) { return Convert.ToDecimal(value, CultureInfo.InvariantCulture); }
        public double Val(object value) { return Convert.ToDouble(value, CultureInfo.InvariantCulture); }
        public bool IsStockBelow(object a, object b)
        {
            return Convert.ToDouble(a, CultureInfo.InvariantCulture) < Convert.ToDouble(b, CultureInfo.InvariantCulture);
        }
    }
    private sealed class Lookup : IStockAvailabilityLookup
    {
        public int Calls;
        public int Names;
        public StockLookupResult FindByCode(object articleCode)
        {
            Calls++;
            return new StockLookupResult {
                Found = true,
                AvailableStock = 1m,
                ReadArticleName = delegate { Names++; return "First"; }
            };
        }
    }
    private static void Require(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
    public static int Run()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var port = new Semantics();
            Require(CheckoutAmountGuards.IsNegativeSale("VENTE", "-1", port), "Negative sale");
            Require(!CheckoutAmountGuards.IsNegativeSale("RETOUR", "-1", port), "Sale operation");
            Require(CheckoutAmountGuards.IsPositiveReturn("RETOUR CREDIT", "2", port), "Positive return");
            Require(CheckoutSelectionRules.IsMissing("", port) && !CheckoutSelectionRules.IsMissing(" ", port),
                "Selection must not trim");
            Require(!BasketTotalConsistency.AreDifferent(25.5m, "26", port), "Rounded basket");
            Require(BasketTotalConsistency.AreDifferent(25.5m, "25", port), "Basket mismatch");
            Require(SalesLinePricing.SelectQuantityPrice(10m, 10m, 8m, 12m, port) == 8m, "Tier threshold");
            Require(SalesLinePricing.SelectQuantityPrice(9m, 10m, 8m, 12m, port) == 12m, "Below tier");
            Require(!SalesLinePricing.SelectQuantityPrice(10m, 10m, 0m, 12m, port).HasValue, "Disabled tier");
            Require(SalesLinePricing.CalculateNetAmount(25m, 2m, 10m) == 45m, "Net amount");
            Require(StockAvailability.IsBelowRequested(1m, 2m, port), "Stock shortage");
            Require(!StockAvailability.IsBelowRequested(2m, 2m, port), "Stock equality");

            int quantities = 0;
            var lookup = new Lookup();
            var rows = new[] {
                new StockValidationRow { ArticleCode = "A", ReadQuantity = delegate { quantities++; return 2m; } },
                new StockValidationRow { ArticleCode = "B", ReadQuantity = delegate { throw new Exception("Second row must not be read"); } }
            };
            StockShortage shortage = StockValidationService.FindFirstShortage(lookup, rows, port);
            Require(shortage != null && Object.Equals(shortage.ArticleName, "First"), "First shortage name");
            Require(lookup.Calls == 1 && lookup.Names == 1 && quantities == 1, "Lazy first-shortage order");
            Console.WriteLine("PASS portable checkout guards, basket, pricing and stock validation");
            return 0;
        }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
