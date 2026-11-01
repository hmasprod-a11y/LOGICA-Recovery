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

    // The modern shell needs to distinguish a deliberate cancellation from a
    // stale or ambiguous variant. No sale, stock, price or database side effects.
    internal enum CheckoutVariantChoiceStatus
    {
        Selected,
        Cancelled,
        Missing,
        Ambiguous,
        InvalidCandidates
    }

    internal sealed class CheckoutVariantChoiceResult
    {
        internal CheckoutVariantChoiceStatus Status { get; private set; }
        internal DataRow SelectedRow { get; private set; }

        internal CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus status, DataRow selectedRow)
        {
            Status = status;
            SelectedRow = selectedRow;
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
                // DataRowCollection still contains rows marked Deleted until
                // AcceptChanges. A displayed snapshot must never include them.
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
                    continue;
                if (row.IsNull("Code") || row.IsNull("ID_ARTICLE") ||
                    String.IsNullOrEmpty(Convert.ToString(row["ID_ARTICLE"])))
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

        // Read-only modern UI outcome. Unlike a null-only API, a cancelled
        // chooser is never mistaken for a stale, ambiguous or corrupt result.
        // Resolve against the *current* query, not the displayed row index.
        internal static CheckoutVariantChoiceResult EvaluateChoice(
            DataTable currentMatches, IList<CheckoutVariantSnapshot> displayed,
            int selectedIndex)
        {
            if (currentMatches == null) throw new ArgumentNullException("currentMatches");
            if (displayed == null) throw new ArgumentNullException("displayed");
            if (selectedIndex == -1)
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.Cancelled, null);
            if (selectedIndex < 0 || selectedIndex >= displayed.Count)
                throw new ArgumentOutOfRangeException("selectedIndex",
                    "The chosen article is outside the displayed variant list.");
            CheckoutVariantSnapshot selected = displayed[selectedIndex];
            if (selected == null) throw new ArgumentException("The chosen variant cannot be null.", "displayed");
            return EvaluateSelected(currentMatches, selected);
        }

        // All modern selection entry points must share the same fail-closed
        // validation. In particular, a pending-deleted DataRow must never
        // escape through the null-only Resolve/ResolveChosenVariant APIs.
        private static CheckoutVariantChoiceResult EvaluateSelected(
            DataTable currentMatches, CheckoutVariantSnapshot selected)
        {
            if (String.IsNullOrEmpty(selected.ArticleId) || selected.Code == null ||
                !currentMatches.Columns.Contains("Code") ||
                !currentMatches.Columns.Contains("ID_ARTICLE"))
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.InvalidCandidates, null);

            DataRow found = null;
            bool ambiguous = false;
            bool invalidCandidates = false;
            foreach (DataRow row in currentMatches.Rows)
            {
                // Deleted rows may still be present until AcceptChanges; they
                // must not be offered to the modern checkout.
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
                    continue;
                if (row.IsNull("Code") || row.IsNull("ID_ARTICLE") ||
                    String.IsNullOrEmpty(Convert.ToString(row["ID_ARTICLE"])))
                {
                    invalidCandidates = true;
                    continue;
                }
                // ID_ARTICLE is the catalogue identity. A second row with the
                // same ID but a different barcode is also unsafe to select.
                if (String.Equals(row["ID_ARTICLE"].ToString(), selected.ArticleId, StringComparison.Ordinal))
                {
                    if (found != null || !String.Equals(row["Code"].ToString(), selected.Code, StringComparison.Ordinal))
                        ambiguous = true;
                    else
                        found = row;
                }
            }
            // Examine every active candidate before returning an outcome:
            // corrupt data must not be masked by an earlier duplicate match.
            if (invalidCandidates)
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.InvalidCandidates, null);
            if (ambiguous)
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.Ambiguous, null);
            return found == null
                ? new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.Missing, null)
                : new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.Selected, found);
        }

        internal static DataRow Resolve(DataTable matches, CheckoutVariantSnapshot selected)
        {
            if (matches == null) throw new ArgumentNullException("matches");
            if (selected == null) throw new ArgumentNullException("selected");
            return EvaluateSelected(matches, selected).SelectedRow;
        }
    }
}
