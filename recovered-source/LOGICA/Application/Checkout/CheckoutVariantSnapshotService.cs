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

    // The modern chooser can render a useful error instead of crashing when
    // the catalogue query returns an incomplete schema or duplicate article IDs.
    internal enum CheckoutVariantSnapshotReadStatus
    {
        Ready,
        Ambiguous,
        InvalidCandidates
    }

    internal sealed class CheckoutVariantSnapshotReadResult
    {
        internal CheckoutVariantSnapshotReadStatus Status { get; private set; }
        internal IList<CheckoutVariantSnapshot> Snapshots { get; private set; }

        internal CheckoutVariantSnapshotReadResult(
            CheckoutVariantSnapshotReadStatus status, IList<CheckoutVariantSnapshot> snapshots)
        {
            Status = status;
            Snapshots = snapshots;
        }
    }

    internal static class CheckoutVariantSnapshotService
    {
        // Keep the historical throw-on-invalid snapshot API for existing
        // callers; modern shells can use EvaluateSnapshot for typed outcomes.
        internal static IList<CheckoutVariantSnapshot> Read(DataTable matches)
        {
            CheckoutVariantSnapshotReadResult read = EvaluateSnapshot(matches);
            if (read.Status != CheckoutVariantSnapshotReadStatus.Ready)
                throw new InvalidOperationException(read.Status == CheckoutVariantSnapshotReadStatus.Ambiguous
                    ? "Article identities are ambiguous."
                    : "Article identity is incomplete.");
            return read.Snapshots;
        }

        // Read-only, all-or-nothing projection. A repeated ID_ARTICLE is unsafe
        // even when the barcodes differ. Scan all active rows before deciding:
        // malformed rows take precedence over duplicates, as in EvaluateChoice.
        // Never expose a partial snapshot after any validation failure.
        internal static CheckoutVariantSnapshotReadResult EvaluateSnapshot(DataTable matches)
        {
            if (matches == null) throw new ArgumentNullException("matches");
            var result = new List<CheckoutVariantSnapshot>(matches.Rows.Count);
            if (!matches.Columns.Contains("Code") || !matches.Columns.Contains("ID_ARTICLE"))
                return new CheckoutVariantSnapshotReadResult(
                    CheckoutVariantSnapshotReadStatus.InvalidCandidates, result.AsReadOnly());

            var seenIds = new HashSet<string>(StringComparer.Ordinal);
            bool ambiguous = false;
            bool invalid = false;
            foreach (DataRow row in matches.Rows)
            {
                // Pending-deleted rows still exist in DataRowCollection; never
                // inspect their inaccessible current-version values.
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
                    continue;
                if (row.IsNull("Code") || row.IsNull("ID_ARTICLE"))
                {
                    invalid = true;
                    continue;
                }
                string articleId = Convert.ToString(row["ID_ARTICLE"]);
                if (String.IsNullOrEmpty(articleId))
                {
                    invalid = true;
                    continue;
                }
                if (!seenIds.Add(articleId))
                {
                    ambiguous = true;
                    continue;
                }
                result.Add(new CheckoutVariantSnapshot(Convert.ToString(row["Code"]), articleId));
            }
            if (invalid || ambiguous)
                return new CheckoutVariantSnapshotReadResult(
                    invalid ? CheckoutVariantSnapshotReadStatus.InvalidCandidates
                            : CheckoutVariantSnapshotReadStatus.Ambiguous,
                    new List<CheckoutVariantSnapshot>().AsReadOnly());
            return new CheckoutVariantSnapshotReadResult(
                CheckoutVariantSnapshotReadStatus.Ready, result.AsReadOnly());
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
            // A caller may supply an IList rather than the immutable output of
            // Read. Reject duplicate/malformed displayed identities before using
            // a valid-looking selected entry; never silently select one of them.
            // Preserve the historical null-selected argument exception.
            if (displayed[selectedIndex] == null)
                return Resolve(currentMatches, displayed[selectedIndex]);
            if (ValidateDisplayed(displayed) != CheckoutVariantSnapshotReadStatus.Ready)
                return null;
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
            CheckoutVariantSnapshotReadStatus displayedStatus = ValidateDisplayed(displayed);
            if (displayedStatus != CheckoutVariantSnapshotReadStatus.Ready)
                return new CheckoutVariantChoiceResult(
                    displayedStatus == CheckoutVariantSnapshotReadStatus.Ambiguous
                        ? CheckoutVariantChoiceStatus.Ambiguous
                        : CheckoutVariantChoiceStatus.InvalidCandidates, null);
            return EvaluateSelected(currentMatches, selected);
        }

        // The displayed list is supplied by a caller, not necessarily by Read.
        // Validate the whole list with the same ID uniqueness and malformed-row
        // precedence as EvaluateSnapshot. Two distinct IDs may share a barcode.
        private static CheckoutVariantSnapshotReadStatus ValidateDisplayed(
            IList<CheckoutVariantSnapshot> displayed)
        {
            var seenIds = new HashSet<string>(StringComparer.Ordinal);
            bool ambiguous = false;
            bool invalid = false;
            foreach (CheckoutVariantSnapshot snapshot in displayed)
            {
                if (snapshot == null || String.IsNullOrEmpty(snapshot.ArticleId) ||
                    snapshot.Code == null)
                {
                    invalid = true;
                    continue;
                }
                if (!seenIds.Add(snapshot.ArticleId))
                    ambiguous = true;
            }
            return invalid ? CheckoutVariantSnapshotReadStatus.InvalidCandidates
                : ambiguous ? CheckoutVariantSnapshotReadStatus.Ambiguous
                : CheckoutVariantSnapshotReadStatus.Ready;
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
