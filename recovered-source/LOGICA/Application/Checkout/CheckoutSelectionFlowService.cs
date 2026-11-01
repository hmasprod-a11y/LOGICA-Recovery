using System;
using System.Collections.Generic;
using System.Data;
using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Opt-in orchestration for a future sales-screen adapter. It composes the
    // same production identity, basket and total-consistency boundaries used
    // by LOGICA; the existing WinForms handlers and posting stay untouched.
    internal sealed class CheckoutBasketPreview
    {
        internal CheckoutVariantChoiceStatus Status { get; private set; }
        internal DataRow SelectedRow { get; private set; }
        internal decimal? LineNet { get; private set; }
        internal decimal? BasketNet { get; private set; }
        internal bool? DisplayedTotalDiffers { get; private set; }

        internal CheckoutBasketPreview(CheckoutVariantChoiceStatus status, DataRow selectedRow,
            decimal? lineNet, decimal? basketNet, bool? displayedTotalDiffers)
        {
            Status = status;
            SelectedRow = selectedRow;
            LineNet = lineNet;
            BasketNet = basketNet;
            DisplayedTotalDiffers = displayedTotalDiffers;
        }
    }

    internal static class CheckoutSelectionFlowService
    {
        // The caller supplies the *exact barcode query* from the local store.
        // The chooser sees immutable ID+Code snapshots, never mutable DataRows.
        // A single candidate needs no dialog. Duplicate barcodes require an
        // explicit choice; the live table is revalidated after the dialog.
        internal static CheckoutVariantChoiceResult ChooseBarcode(
            DataTable exactBarcodeMatches, Func<IList<CheckoutVariantSnapshot>, int> chooseDuplicate)
        {
            // Preserve the existing in-memory caller contract while sharing
            // exactly one choice/identity implementation with the live-query
            // adapter. No additional SQL or UI action is performed here.
            return ChooseBarcodeWithRefresh(exactBarcodeMatches, chooseDuplicate,
                delegate { return exactBarcodeMatches; });
        }

        // Opt-in local-store refresh boundary for the real scanner handler.
        // The first query supplies the rows the cashier actually saw; a fresh
        // query AFTER the dialog supplies the rows eligible for the basket.
        // The callback belongs to the Windows/local DB adapter, never this core.
        // A single displayed article is refreshed too: its identity may have
        // changed between the initial barcode lookup and selection.
        internal static CheckoutVariantChoiceResult ChooseBarcodeWithRefresh(
            DataTable displayedMatches,
            Func<IList<CheckoutVariantSnapshot>, int> chooseDuplicate,
            Func<DataTable> readCurrentMatches)
        {
            if (readCurrentMatches == null)
                throw new ArgumentNullException("readCurrentMatches");
            CheckoutVariantSnapshotReadResult read =
                CheckoutVariantSnapshotService.EvaluateSnapshot(displayedMatches);
            if (read.Status != CheckoutVariantSnapshotReadStatus.Ready)
                return new CheckoutVariantChoiceResult(
                    read.Status == CheckoutVariantSnapshotReadStatus.Ambiguous
                        ? CheckoutVariantChoiceStatus.Ambiguous
                        : CheckoutVariantChoiceStatus.InvalidCandidates, null);
            if (read.Snapshots.Count == 0)
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.Missing, null);
            if (read.Snapshots.Count > 1 && chooseDuplicate == null)
                throw new ArgumentNullException("chooseDuplicate",
                    "Duplicate barcodes require an explicit article choice.");

            int index = read.Snapshots.Count == 1 ? 0 : chooseDuplicate(read.Snapshots);
            if (index == -1)
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.Cancelled, null);
            if (index < 0 || index >= read.Snapshots.Count)
                throw new ArgumentOutOfRangeException("selectedIndex",
                    "The chosen article is outside the displayed variant list.");

            DataTable live = readCurrentMatches();
            // A failed/empty refresh is never permission to use the stale
            // displayed row. DB exceptions still propagate to the UI handler.
            if (live == null)
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.InvalidCandidates, null);
            return CheckoutVariantSnapshotService.EvaluateChoice(live, read.Snapshots, index);
        }

        // Bridge for the ACTUAL WinForms CheckoutBarcodeChoiceDialog, which takes
        // the original DataTable (not IList<CheckoutVariantSnapshot>). Preserve
        // its row-index contract, but resolve the chosen ID against a fresh local
        // query before Form_3_VENTE copies price, discount, tax or other fields.
        // The caller still owns the SQL read, modal dialog and legacy Button_GO.
        internal static CheckoutVariantChoiceResult ChooseBarcodeWithLegacyDialog(
            DataTable displayedMatches, Func<DataTable, int> chooseDuplicate,
            Func<DataTable> readCurrentMatches)
        {
            if (displayedMatches == null)
                throw new ArgumentNullException("displayedMatches");
            if (readCurrentMatches == null)
                throw new ArgumentNullException("readCurrentMatches");

            // A pending-deleted row occupies DataTable.Rows but is omitted from
            // the immutable snapshot. Passing the dialog's index through would
            // select a different article. Fail closed before opening the modal.
            CheckoutVariantSnapshotReadResult initial =
                CheckoutVariantSnapshotService.EvaluateSnapshot(displayedMatches);
            if (initial.Status == CheckoutVariantSnapshotReadStatus.Ready &&
                initial.Snapshots.Count != displayedMatches.Rows.Count)
                return new CheckoutVariantChoiceResult(
                    CheckoutVariantChoiceStatus.InvalidCandidates, null);

            // The dialog index refers to the ORIGINAL displayed rows, even if
            // an unrelated row is removed or moved while the modal is open.
            // Preserve that safe legacy behavior: snapshot ID resolution still
            // finds the originally chosen article. Reject only when the chosen
            // DataRow itself was deleted, replaced, or reassigned to another ID
            // or barcode. A lookalike replacement must never inherit its index.
            DataRow[] originalRows = new DataRow[displayedMatches.Rows.Count];
            for (int i = 0; i < originalRows.Length; i++)
                originalRows[i] = displayedMatches.Rows[i];
            bool selectedRowChanged = false;
            CheckoutVariantChoiceResult result = ChooseBarcodeWithRefresh(displayedMatches,
                chooseDuplicate == null ? null :
                    new Func<IList<CheckoutVariantSnapshot>, int>(
                        delegate(IList<CheckoutVariantSnapshot> ignored) {
                            int selectedIndex = chooseDuplicate(displayedMatches);
                            if (selectedIndex >= 0 && selectedIndex < initial.Snapshots.Count &&
                                !MatchesOriginalSelectedRow(displayedMatches,
                                    initial.Snapshots[selectedIndex], originalRows[selectedIndex]))
                            {
                                selectedRowChanged = true;
                                return -1;
                            }
                            return selectedIndex;
                        }),
                readCurrentMatches);
            return selectedRowChanged
                ? new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.InvalidCandidates, null)
                : result;
        }

        private static bool MatchesOriginalSelectedRow(
            DataTable displayed, CheckoutVariantSnapshot selected, DataRow originalRow)
        {
            return originalRow.RowState != DataRowState.Deleted &&
                originalRow.RowState != DataRowState.Detached &&
                displayed.Rows.IndexOf(originalRow) >= 0 &&
                displayed.Columns.Contains("Code") &&
                displayed.Columns.Contains("ID_ARTICLE") &&
                !originalRow.IsNull("Code") && !originalRow.IsNull("ID_ARTICLE") &&
                String.Equals(Convert.ToString(originalRow["Code"]), selected.Code,
                    StringComparison.Ordinal) &&
                String.Equals(Convert.ToString(originalRow["ID_ARTICLE"]), selected.ArticleId,
                    StringComparison.Ordinal);
        }

        // Image tiles must be resolved from a live catalogue result by article
        // identity, not from an exact-barcode query: an image-only product can
        // legitimately have Code == "". No query, UI or database work here.
        internal static CheckoutVariantChoiceResult ChooseImage(
            DataTable currentCatalogue, CheckoutArticleTileReference tile)
        {
            return CheckoutArticleTileSelectionService.EvaluateExact(currentCatalogue, tile);
        }

        // Opt-in adapter for a click on an image tile. Read the live catalogue
        // by article identity, NOT by barcode: Code may be blank. A missing or
        // reused identity fails closed before any price/basket operation.
        internal static CheckoutVariantChoiceResult ChooseImageWithRefresh(
            CheckoutArticleTileReference tile, Func<DataTable> readCurrentCatalogue)
        {
            if (tile == null) throw new ArgumentNullException("tile");
            if (readCurrentCatalogue == null)
                throw new ArgumentNullException("readCurrentCatalogue");
            DataTable live = readCurrentCatalogue();
            if (live == null)
                return new CheckoutVariantChoiceResult(CheckoutVariantChoiceStatus.InvalidCandidates, null);
            return CheckoutArticleTileSelectionService.EvaluateExact(live, tile);
        }

        // The pricing delegate MUST be the existing caller's legacy net-line
        // calculation (including its VB conversions/formatting, tiers, discount,
        // sale/return sign). Do not silently replace it with decimal pricing:
        // the recovered WinForms path uses VB Double and FormatNumber.
        // This preview only composes a selected row with the production basket
        // consistency rule; it does not write basket, stock, payment or ticket.
        internal static CheckoutBasketPreview Preview(
            CheckoutVariantChoiceResult choice, decimal existingBasketNet,
            Func<DataRow, decimal> calculateLegacyLineNet, string displayedTotal,
            ILegacyCheckoutSemantics legacy)
        {
            if (choice == null) throw new ArgumentNullException("choice");
            if (choice.Status != CheckoutVariantChoiceStatus.Selected)
                return new CheckoutBasketPreview(choice.Status, null, null, null, null);
            if (choice.SelectedRow == null)
                throw new InvalidOperationException("A selected article must have a live row.");
            if (calculateLegacyLineNet == null)
                throw new ArgumentNullException("calculateLegacyLineNet");
            if (legacy == null) throw new ArgumentNullException("legacy");

            decimal lineNet = calculateLegacyLineNet(choice.SelectedRow);
            decimal basketNet = decimal.Add(existingBasketNet, lineNet);
            bool differs = BasketTotalConsistency.AreDifferent(basketNet, displayedTotal, legacy);
            return new CheckoutBasketPreview(
                choice.Status, choice.SelectedRow, lineNet, basketNet, differs);
        }
    }
}
