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
            return CheckoutSelectionFlowService.ChooseBarcodeWithLegacyDialog(
                displayedMatches, chooseDuplicate, delegate {
                    DataTable live = readCurrentMatches();
                    return Object.ReferenceEquals(live, displayedMatches) ? null : live;
                });
        }

    }
}
