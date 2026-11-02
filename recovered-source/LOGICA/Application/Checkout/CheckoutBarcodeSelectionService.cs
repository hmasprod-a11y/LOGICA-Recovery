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

        internal static DataRow Select(DataTable matches, Func<DataTable, int> chooseDuplicate)
        {
            if (matches == null) throw new ArgumentNullException("matches");
            if (matches.Rows.Count == 0) return null;

            // This is the real Form_3_VENTE barcode path. The modal chooser
            // receives the original DataTable, so its row index describes the
            // rows displayed BEFORE ShowDialog, not a potentially reordered
            // or edited table AFTER the dialog. Reuse the modern identity guard
            // rather than returning matches.Rows[index] after user interaction.
            CheckoutVariantSnapshotReadResult displayed =
                CheckoutVariantSnapshotService.EvaluateSnapshot(matches);
            // A deleted row still occupies DataRowCollection but is not shown
            // by the modern snapshot. Refuse index drift instead of guessing.
            if (displayed.Status != CheckoutVariantSnapshotReadStatus.Ready ||
                displayed.Snapshots.Count != matches.Rows.Count)
                return null;
            if (displayed.Snapshots.Count == 0) return null;
            if (displayed.Snapshots.Count > 1 && chooseDuplicate == null)
                throw new ArgumentNullException("chooseDuplicate");

            int index = displayed.Snapshots.Count == 1 ? 0 : chooseDuplicate(matches);
            if (index == -1) return null;
            if (index < 0 || index >= displayed.Snapshots.Count)
                throw new ArgumentOutOfRangeException("index", "Duplicate barcode selection is outside the result set.");

            // Resolve by exact ID_ARTICLE + Code from the displayed snapshot.
            // A removed, changed, duplicated or malformed live article never
            // reaches Button_GO_Click. A reordering alone keeps the intended
            // variant. No SQL, price, quantity or posting semantics change.
            return CheckoutVariantSnapshotService.EvaluateChoice(
                matches, displayed.Snapshots, index).SelectedRow;
        }
    }
}
