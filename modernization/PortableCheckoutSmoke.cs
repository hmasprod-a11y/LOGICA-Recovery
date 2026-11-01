using System;
using System.Collections.Generic;
using System.Data;
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
            var variants = new DataTable();
            variants.Columns.Add("Code", typeof(string));
            variants.Columns.Add("ID_ARTICLE", typeof(string));
            variants.Rows.Add("123", "A");
            variants.Rows.Add("123", "B");
            var snapshots = CheckoutVariantSnapshotService.Read(variants);
            bool nullReadRejected = false;
            try { CheckoutVariantSnapshotService.Read(null); }
            catch (ArgumentNullException) { nullReadRejected = true; }
            Require(nullReadRejected, "Null variant source rejected");
            bool nullResolveRejected = false;
            try { CheckoutVariantSnapshotService.Resolve(null, snapshots[0]); }
            catch (ArgumentNullException) { nullResolveRejected = true; }
            Require(nullResolveRejected, "Null candidate table rejected");
            Require(snapshots.Count == 2, "Duplicate barcode variants retained");
            Require(Object.ReferenceEquals(CheckoutVariantSnapshotService.Resolve(variants, snapshots[1]),
                variants.Rows[1]), "Selected variant must resolve exact ID");
            Require(Object.ReferenceEquals(
                CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, 1),
                variants.Rows[1]), "Explicit duplicate-barcode choice must retain article ID");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, -1) == null,
                "Cancellation must not select the first variant");
            bool invalidIndexRejected = false;
            try { CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, 2); }
            catch (ArgumentOutOfRangeException) { invalidIndexRejected = true; }
            Require(invalidIndexRejected, "Out-of-range choice must be rejected");
            invalidIndexRejected = false;
            try { CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, -2); }
            catch (ArgumentOutOfRangeException) { invalidIndexRejected = true; }
            Require(invalidIndexRejected, "Negative index other than cancellation must be rejected");
            bool nullDisplayedRejected = false;
            try { CheckoutVariantSnapshotService.ResolveChosenVariant(variants, null, 0); }
            catch (ArgumentNullException) { nullDisplayedRejected = true; }
            Require(nullDisplayedRejected, "Missing displayed snapshot must be rejected");
            bool nullCurrentRejected = false;
            try { CheckoutVariantSnapshotService.ResolveChosenVariant(null, snapshots, -1); }
            catch (ArgumentNullException) { nullCurrentRejected = true; }
            Require(nullCurrentRejected, "Missing live query must be rejected even on cancellation");

            DataTable reordered = variants.Clone();
            reordered.Rows.Add("123", "B");
            reordered.Rows.Add("123", "A");
            Require(Object.ReferenceEquals(
                CheckoutVariantSnapshotService.ResolveChosenVariant(reordered, snapshots, 1),
                reordered.Rows[0]), "Reordered live query must resolve identity rather than index");
            reordered.Rows[0]["ID_ARTICLE"] = "C";
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(reordered, snapshots, 1) == null,
                "Changed article identity must fail closed");
            Require(snapshots[1].ArticleId == "B" && snapshots[1].Code == "123",
                "Displayed snapshot must not mutate when query rows change");
            DataTable ambiguous = variants.Clone();
            ambiguous.Rows.Add("123", "B");
            ambiguous.Rows.Add("123", "B");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(ambiguous, snapshots, 1) == null,
                "Ambiguous identical identities must never post a sale");
            DataTable missingIdentity = variants.Clone();
            missingIdentity.Rows.Add(DBNull.Value, "A");
            bool invalidIdentityRejected = false;
            try { CheckoutVariantSnapshotService.Read(missingIdentity); }
            catch (InvalidOperationException) { invalidIdentityRejected = true; }
            Require(invalidIdentityRejected, "Null barcode must not enter displayed snapshot");
            Require(variants.Rows.Count == 2 && variants.Rows[0]["ID_ARTICLE"].ToString() == "A",
                "Selection must never modify the live table");
            variants.Rows.RemoveAt(1);
            Require(CheckoutVariantSnapshotService.Resolve(variants, snapshots[1]) == null,
                "Stale variant must fail closed");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, 1) == null,
                "Stale explicit choice must fail closed");
            Console.WriteLine("PASS portable checkout modern variant selection: cancellation, index, identity, reorder, ambiguity and stale rows");
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
            const string familySql = "select      *     from      TABLE_ARTICLES        WHERE      Famille = @family            order by Article asc ";
            Require(String.Equals(LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText.Family(), familySql,
                StringComparison.Ordinal), "Family tile SQL must preserve exact equality and bound parameter");
            DataTable tiles = new DataTable();
            tiles.Columns.Add("ID_ARTICLE", typeof(string));
            tiles.Columns.Add("Code", typeof(string));
            tiles.Rows.Add("11", "DUP");
            tiles.Rows.Add("12", "DUP");
            CheckoutArticleTileReference tile = CheckoutArticleTileSelectionService.TagFor(tiles.Rows[1]);
            Require(CheckoutArticleTileSelectionService.FindExact(tiles, tile) == tiles.Rows[1],
                "Image tile must select exact variant instead of first duplicate barcode");
            tiles.Rows.RemoveAt(1);
            Require(CheckoutArticleTileSelectionService.FindExact(tiles, tile) == null,
                "Stale image tile must fail closed");
            Console.WriteLine("PASS portable checkout image tile identity and stale variant rejection");
            Console.WriteLine("PASS portable checkout family SQL parameter and original order");
            Console.WriteLine("PASS portable checkout guards, basket, pricing and stock validation");
            return 0;
        }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
