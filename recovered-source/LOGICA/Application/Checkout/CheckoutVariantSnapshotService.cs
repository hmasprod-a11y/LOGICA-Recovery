using System;
using System.Collections.Generic;
using System.Data;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Read-only projection for a future .NET 10 shell. No database or basket writes.
    // Keep the exact selected ID: barcode alone is not a unique product identity.
    internal sealed class CheckoutVariantSnapshot
    {
        internal string Code { get; private set; }
        internal string ArticleId { get; private set; }
        internal CheckoutVariantSnapshot(string code, string articleId)
        {
            Code = code;
            ArticleId = articleId;
        }
    }

    internal static class CheckoutVariantSnapshotService
    {
        internal static IList<CheckoutVariantSnapshot> Read(DataTable matches)
        {
            if (matches == null) throw new ArgumentNullException("matches");
            var result = new List<CheckoutVariantSnapshot>(matches.Rows.Count);
            foreach (DataRow row in matches.Rows)
            {
                if (row.IsNull("Code") || row.IsNull("ID_ARTICLE"))
                    throw new InvalidOperationException("Article identity is incomplete.");
                result.Add(new CheckoutVariantSnapshot(
                    Convert.ToString(row["Code"]), Convert.ToString(row["ID_ARTICLE"])));
            }
            return result.AsReadOnly();
        }

        // Modern selection boundary: -1 is explicit cancellation; no implicit first
        // match for duplicate barcodes. Re-resolve against the current query so
        // removed, changed or ambiguous article identities cannot be sold.
        internal static DataRow ResolveChosenVariant(
            DataTable currentMatches, IList<CheckoutVariantSnapshot> displayed,
            int selectedIndex)
        {
            if (currentMatches == null) throw new ArgumentNullException("currentMatches");
            if (displayed == null) throw new ArgumentNullException("displayed");
            if (selectedIndex == -1) return null;
            if (selectedIndex < 0 || selectedIndex >= displayed.Count)
                throw new ArgumentOutOfRangeException("selectedIndex",
                    "The chosen article is outside the displayed variant list.");
            return Resolve(currentMatches, displayed[selectedIndex]);
        }

        internal static DataRow Resolve(DataTable matches, CheckoutVariantSnapshot selected)
        {
            if (matches == null) throw new ArgumentNullException("matches");
            if (selected == null) throw new ArgumentNullException("selected");
            return CheckoutArticleTileSelectionService.FindExact(
                matches, new CheckoutArticleTileReference(selected.Code, selected.ArticleId));
        }
    }
}
