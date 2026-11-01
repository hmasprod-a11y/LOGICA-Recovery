using System;
using System.Data;

namespace LOGICA.ApplicationLayer.Checkout
{
    // A duplicate scan is never silently posted: the UI must return an explicit
    // row index or -1 for cancellation. No quantity, price or stock is mutated here.
    internal static class CheckoutBarcodeSelectionService
    {
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
