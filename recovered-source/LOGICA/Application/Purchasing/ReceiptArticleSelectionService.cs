using System;
using System.Collections.Generic;
using System.Data;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // Used by the real purchase-receipt barcode and article-grid handlers.
    // A barcode is not a unique article identity; a grid choice must retain ID_ARTICLE.
    internal static class ReceiptArticleSelectionService
    {
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
            foreach (DataRow row in barcodeMatches.Rows)
            {
                if (row == null || row.RowState == DataRowState.Deleted ||
                    row.RowState == DataRowState.Detached ||
                    row.IsNull("ID_ARTICLE") || row.IsNull("Code"))
                    return null;
                string id = Convert.ToString(row["ID_ARTICLE"]);
                if (String.IsNullOrWhiteSpace(id) || !seenIds.Add(id))
                    return null;
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
    // Validate the event row, then recheck the same article after confirmation.
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

}
