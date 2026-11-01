using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // Minimal caller-supplied supplier identity: no assumptions about legacy schema.
    internal sealed class ReceiptSupplierSnapshotLine
    {
        internal readonly string SupplierId;

        internal ReceiptSupplierSnapshotLine(string supplierId)
        {
            SupplierId = supplierId;
        }
    }

    internal sealed class PurchaseReceiptSupplierValidation
    {
        internal readonly string SupplierId;
        internal readonly bool IsKnown;

        internal PurchaseReceiptSupplierValidation(string supplierId, bool known)
        {
            SupplierId = supplierId;
            IsKnown = known;
        }
    }

    internal static class PurchaseReceiptSupplierValidationService
    {
        // A known supplier ID is necessary but not sufficient for posting.
        // Future DB integration must re-read the supplier inside the transaction.
        internal static PurchaseReceiptSupplierValidation Compare(PurchaseReceiptPreview receipt,
            IEnumerable<ReceiptSupplierSnapshotLine> suppliers)
        {
            if (receipt == null) throw new ArgumentNullException("receipt");
            if (suppliers == null) throw new ArgumentNullException("suppliers");
            if (String.IsNullOrWhiteSpace(receipt.SupplierId))
                throw new ArgumentException("Receipt supplier ID is required.", "receipt");

            var identities = new HashSet<string>(StringComparer.Ordinal);
            foreach (ReceiptSupplierSnapshotLine supplier in suppliers)
            {
                if (supplier == null)
                    throw new ArgumentException("Supplier snapshot row cannot be null.", "suppliers");
                if (String.IsNullOrWhiteSpace(supplier.SupplierId))
                    throw new ArgumentException("Supplier snapshot ID is required.", "suppliers");
                if (!identities.Add(supplier.SupplierId))
                    throw new InvalidOperationException("Duplicate supplier ID in snapshot.");
            }
            return new PurchaseReceiptSupplierValidation(receipt.SupplierId,
                identities.Contains(receipt.SupplierId));
        }
    }
}
