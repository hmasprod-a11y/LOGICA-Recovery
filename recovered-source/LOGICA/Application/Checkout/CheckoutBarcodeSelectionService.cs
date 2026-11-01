using System;
using System.Data;

namespace LOGICA.ApplicationLayer.Checkout
{
    // A duplicate scan is never silently posted: the UI must return an explicit
    // row index or -1 for cancellation. No quantity, price or stock is mutated here.
    internal static class CheckoutBarcodeSelectionService
    {
        // A chosen variant must not increment a different article merely because
        // both share a barcode. Use the caller's original VB equality semantics,
        // preserving code-first short-circuit and exception propagation.
        internal static bool IsSameBasketArticle(
            DataRow basketLine, object scannedCode, object selectedArticleId,
            Func<object, object, bool> legacyEquals)
        {
            if (basketLine == null) throw new ArgumentNullException("basketLine");
            if (legacyEquals == null) throw new ArgumentNullException("legacyEquals");
            return legacyEquals(basketLine["Code"], scannedCode) &&
                   legacyEquals(basketLine["ID_ARTICLE"], selectedArticleId);
        }

        // This is called by the existing Form_3_VENTE handler. Keep the original
        // DataTable modal callback and nullable DataRow result; centralize its
        // identity rules in the same flow used by the refreshed adapter.
        internal static DataRow Select(DataTable matches, Func<DataTable, int> chooseDuplicate)
        {
            // The original WinForms handler has no second SQL read yet. Keep
            // that legacy in-memory behavior until Track C wires a real refresh.
            // Do not pretend this fallback has fresh catalogue prices.
            return CheckoutSelectionFlowService.ChooseBarcodeWithLegacyDialog(
                matches, chooseDuplicate, delegate { return matches; }).SelectedRow;
        }

        // Scanner-owned overload: the barcode captured from Text_CODE BEFORE
        // opening the modal is authoritative. A different barcode in the
        // displayed SQL result must not become the sale's selected identity,
        // even if every returned row agrees with each other. The original
        // overload remains for callers that only have the displayed table.
        internal static CheckoutVariantChoiceResult SelectWithRefresh(
            string scannedBarcode, DataTable displayedMatches,
            Func<DataTable, int> chooseDuplicate, Func<DataTable> readCurrentMatches)
        {
            if (displayedMatches == null)
                throw new ArgumentNullException("displayedMatches");
            if (readCurrentMatches == null)
                throw new ArgumentNullException("readCurrentMatches");
            if (String.IsNullOrWhiteSpace(scannedBarcode))
                return new CheckoutVariantChoiceResult(
                    CheckoutVariantChoiceStatus.InvalidCandidates, null);
            CheckoutVariantSnapshotReadResult initial =
                CheckoutVariantSnapshotService.EvaluateSnapshot(displayedMatches);
            if (initial.Status == CheckoutVariantSnapshotReadStatus.Ready)
                foreach (CheckoutVariantSnapshot candidate in initial.Snapshots)
                    if (!String.Equals(candidate.Code, scannedBarcode,
                        StringComparison.Ordinal))
                        return new CheckoutVariantChoiceResult(
                            CheckoutVariantChoiceStatus.InvalidCandidates, null);
            return SelectWithRefresh(displayedMatches, chooseDuplicate, readCurrentMatches);
        }

        // Drop-in bridge for the Windows barcode handler once its local SQL
        // reader is available: show the existing modal over the displayed
        // table, then requery by exact barcode BEFORE copying current price,
        // discount, tax or stock fields to the legacy sale screen. The core
        // never performs SQL, basket mutations or monetary conversions.
        // The caller owns the fresh local query and handles non-Selected status.
        internal static CheckoutVariantChoiceResult SelectWithRefresh(
            DataTable displayedMatches, Func<DataTable, int> chooseDuplicate,
            Func<DataTable> readCurrentMatches)
        {
            if (displayedMatches == null)
                throw new ArgumentNullException("displayedMatches");
            if (readCurrentMatches == null)
                throw new ArgumentNullException("readCurrentMatches");
            // A refresh adapter that hands back the same mutable table cannot
            // guarantee fresh price/discount/tax data. Reject that misuse rather
            // than silently advertising an in-memory row as a live SQL read.
            // Capture the scanned barcode BEFORE the modal: it can reorder or
            // remove displayed rows. The original SQL query is exact-barcode,
            // so a refreshed result containing unrelated codes is not safe to
            // copy into the basket even if the chosen ID still exists.
            CheckoutVariantSnapshotReadResult initial =
                CheckoutVariantSnapshotService.EvaluateSnapshot(displayedMatches);
            string scannedCode = initial.Status == CheckoutVariantSnapshotReadStatus.Ready &&
                initial.Snapshots.Count > 0 ? initial.Snapshots[0].Code : null;
            CheckoutVariantChoiceResult choice =
                CheckoutSelectionFlowService.ChooseBarcodeWithLegacyDialog(
                    displayedMatches, chooseDuplicate, delegate {
                        DataTable live = readCurrentMatches();
                        if (live == null || Object.ReferenceEquals(live, displayedMatches) ||
                            !live.Columns.Contains("Code"))
                            return null;
                        // Validate the ENTIRE exact-barcode SQL result before
                        // resolving the selected ID. Otherwise an unrelated
                        // result with the chosen ID missing is reported as
                        // Missing instead of an unsafe query/filter mismatch.
                        // No stale row may be used for price, discount or tax.
                        foreach (DataRow row in live.Rows)
                        {
                            if (row.RowState == DataRowState.Deleted ||
                                row.RowState == DataRowState.Detached)
                                continue;
                            if (row.IsNull("Code") ||
                                !String.Equals(Convert.ToString(row["Code"]), scannedCode,
                                    StringComparison.Ordinal))
                                return null;
                        }
                        return live;
                    });
            if (choice.Status != CheckoutVariantChoiceStatus.Selected)
                return choice;
            if (String.IsNullOrWhiteSpace(scannedCode))
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.InvalidCandidates, null);
            foreach (DataRow row in choice.SelectedRow.Table.Rows)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
                    continue;
                if (row.IsNull("Code") ||
                    !String.Equals(Convert.ToString(row["Code"]), scannedCode,
                        StringComparison.Ordinal))
                    return new CheckoutVariantChoiceResult(
                        CheckoutVariantChoiceStatus.InvalidCandidates, null);
            }
            return choice;
        }

    }
}
