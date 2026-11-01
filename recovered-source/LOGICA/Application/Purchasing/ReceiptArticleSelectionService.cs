using System;
using System.Collections.Generic;
using System.Data;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // Used by the real purchase-receipt barcode and article-grid handlers.
    // A barcode is not a unique article identity; a grid choice must retain ID_ARTICLE.
    internal static class ReceiptArticleSelectionService
    {
        // An explicit grid selection that disappeared after a fresh barcode read
        // must never be treated as a request to create a different article.
        // This decision is read-only and does not change legacy creation flow.
        internal static bool CanOfferCreation(DataTable barcodeMatches, string selectedArticleId)
        {
            if (barcodeMatches == null) throw new ArgumentNullException("barcodeMatches");
            return selectedArticleId == null && barcodeMatches.Rows.Count == 0;
        }

        // The scanner must not query the blank barcode shared by unrelated
        // products. An explicit article-grid click is different: its ID_ARTICLE
        // disambiguates even a genuinely barcode-free product. The real receipt
        // Find button calls this before its existing local catalogue query.
        internal static bool ShouldLookupBarcode(string code, string selectedArticleId)
        {
            return selectedArticleId != null || !String.IsNullOrWhiteSpace(code);
        }

        // Returns null on missing, ambiguous, deleted or malformed rows.
        // No SQL, price, quantity or stock mutations.
        internal static DataRow Resolve(DataTable barcodeMatches, string selectedArticleId)
        {
            if (barcodeMatches == null) throw new ArgumentNullException("barcodeMatches");
            if (!barcodeMatches.Columns.Contains("ID_ARTICLE") ||
                !barcodeMatches.Columns.Contains("Code"))
                return null;

            var seenIds = new HashSet<string>(StringComparer.Ordinal);
            DataRow selected = null;
            int validCount = 0;
            string exactBarcode = null;
            foreach (DataRow row in barcodeMatches.Rows)
            {
                if (row == null || row.RowState == DataRowState.Deleted ||
                    row.RowState == DataRowState.Detached ||
                    row.IsNull("ID_ARTICLE") || row.IsNull("Code"))
                    return null;
                string id = Convert.ToString(row["ID_ARTICLE"]);
                string code = Convert.ToString(row["Code"]);
                // The receipt barcode lookup must return candidates for one
                // exact Code. A mixed result cannot be trusted even when a
                // grid-selected ID happens to match; fail before copying prices.
                if (String.IsNullOrWhiteSpace(id) || !seenIds.Add(id) ||
                    (exactBarcode != null && !String.Equals(exactBarcode, code, StringComparison.Ordinal)))
                    return null;
                exactBarcode = code;
                validCount++;
                if (selectedArticleId == null ||
                    String.Equals(selectedArticleId, id, StringComparison.Ordinal))
                    selected = row;
            }

            // Barcode-only entry must have exactly one candidate.
            if (selectedArticleId == null && validCount != 1)
                return null;
            return selected;
        }
    }


    // Shared with the actual purchase receipt DataGrid_BODY event handlers.
    // Index validation prevents a header/new-row click from being interpreted
    // as an article line; identity recheck protects a pending delete dialog.
    internal static class ReceiptLineGridGuard
    {
        internal static bool HasExistingRow(int rowIndex, int rowCount)
        {
            return rowIndex >= 0 && rowCount > 0 && rowIndex < rowCount;
        }

        internal static bool MatchesLine(string confirmedArticleId, string confirmedCode,
            string currentArticleId, string currentCode)
        {
            return !String.IsNullOrWhiteSpace(confirmedArticleId) &&
                String.Equals(confirmedArticleId, currentArticleId, StringComparison.Ordinal) &&
                String.Equals(confirmedCode, currentCode, StringComparison.Ordinal);
        }
    }

    // The receipt currently displayed for consultation must be the one that the
    // operator confirmed. This guards the real WinForms validation handler
    // against a stale binding position without changing transaction SQL.
    internal static class ReceiptDocumentSelectionGuard
    {
        // A sorted/filtered WinForms DataGridView row does not necessarily have
        // the same index as the underlying DataTable or BindingContext cursor.
        // Resolve the actual bound record and verify the visible receipt ID;
        // never consult, edit or delete a different receipt via DT.Rows[position].
        internal static DataRow ResolveBoundRow(DataRowView clickedView, string displayedReceiptId)
        {
            if (clickedView == null || clickedView.Row == null ||
                clickedView.Row.RowState == DataRowState.Deleted ||
                clickedView.Row.RowState == DataRowState.Detached ||
                !clickedView.Row.Table.Columns.Contains("ID_BR") ||
                clickedView.Row.IsNull("ID_BR"))
                return null;
            string actualId = Convert.ToString(clickedView.Row["ID_BR"]);
            return Matches(displayedReceiptId, actualId) ? clickedView.Row : null;
        }

        internal static bool Matches(string confirmedReceiptId, string loadedReceiptId)
        {
            return !String.IsNullOrWhiteSpace(confirmedReceiptId) &&
                !String.IsNullOrWhiteSpace(loadedReceiptId) &&
                String.Equals(confirmedReceiptId, loadedReceiptId, StringComparison.Ordinal);
        }

        // Preserve the original confirmation behavior for unvalidated legacy
        // states (including EN_COURS). Only a now-validated or missing state
        // must stop posting after the consultation refresh. This UI guard is
        // NOT a substitute for an atomic database claim across clients.
        internal static bool MayValidate(string confirmedReceiptId, string loadedReceiptId,
            string displayedState, string loadedState)
        {
            return Matches(confirmedReceiptId, loadedReceiptId) &&
                !String.IsNullOrWhiteSpace(displayedState) &&
                !String.IsNullOrWhiteSpace(loadedState) &&
                !String.Equals(displayedState, "VALIDER", StringComparison.Ordinal) &&
                !String.Equals(loadedState, "VALIDER", StringComparison.Ordinal);
        }
    }
}
