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
            if (matches.Rows.Count == 1) return matches.Rows[0];
            if (chooseDuplicate == null) throw new ArgumentNullException("chooseDuplicate");
            int index = chooseDuplicate(matches);
            if (index == -1) return null;
            if (index < 0 || index >= matches.Rows.Count)
                throw new ArgumentOutOfRangeException("index", "Duplicate barcode selection is outside the result set.");
            return matches.Rows[index];
        }
    }
}
