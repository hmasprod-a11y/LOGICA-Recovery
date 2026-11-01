using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // Diagnostic only: a fresh preview is NOT permission to post or a database lock.
    internal sealed class PurchaseReceiptFreshnessPreview
    {
        internal readonly bool SupplierMissing;
        internal readonly IList<string> MissingCatalogueArticleIds;
        internal readonly IList<string> ChangedBarcodeArticleIds;
        internal readonly IList<string> MissingStockArticleIds;
        internal readonly IList<string> ChangedStockArticleIds;

        internal PurchaseReceiptFreshnessPreview(bool supplierMissing, IList<string> missingCatalogue,
            IList<string> changedBarcode, IList<string> missingStock, IList<string> changedStock)
        {
            SupplierMissing = supplierMissing;
            MissingCatalogueArticleIds = new List<string>(missingCatalogue).AsReadOnly();
            ChangedBarcodeArticleIds = new List<string>(changedBarcode).AsReadOnly();
            MissingStockArticleIds = new List<string>(missingStock).AsReadOnly();
            ChangedStockArticleIds = new List<string>(changedStock).AsReadOnly();
        }

        internal bool IsFresh
        {
            get { return !SupplierMissing && MissingCatalogueArticleIds.Count == 0 &&
                ChangedBarcodeArticleIds.Count == 0 && MissingStockArticleIds.Count == 0 &&
                ChangedStockArticleIds.Count == 0; }
        }
    }

    internal static class PurchaseReceiptFreshnessService
    {
        // Recheck the EXACT received article identities, not shared barcodes. Unrelated
        // catalogue/stock changes do not invalidate a receipt; corrupt snapshots do.
        // Caller must repeat this check inside a future owned MariaDB transaction.
        internal static PurchaseReceiptFreshnessPreview Compare(PurchaseReceiptStockProjection projection,
            IEnumerable<ReceiptCatalogueArticle> currentCatalogue,
            IEnumerable<ReceiptSupplierSnapshotLine> currentSuppliers,
            IEnumerable<StockBaselineLine> currentStock)
        {
            if (projection == null) throw new ArgumentNullException("projection");
            if (currentCatalogue == null) throw new ArgumentNullException("currentCatalogue");
            if (currentSuppliers == null) throw new ArgumentNullException("currentSuppliers");
            if (currentStock == null) throw new ArgumentNullException("currentStock");
            if (String.IsNullOrWhiteSpace(projection.SupplierId) || projection.Lines == null ||
                projection.Lines.Count == 0)
                throw new ArgumentException("Invalid purchase projection.", "projection");

            var totals = new List<PurchaseReceiptArticleTotal>();
            var baseline = new Dictionary<string, decimal>(StringComparer.Ordinal);
            decimal totalQuantity = 0m;
            decimal totalCost = 0m;
            foreach (PurchaseReceiptStockProjectionLine line in projection.Lines)
            {
                if (line == null || String.IsNullOrWhiteSpace(line.ArticleId) ||
                    line.ReceivedQuantity <= 0m || line.ExtendedCost < 0m)
                    throw new ArgumentException("Invalid projected receipt line.", "projection");
                if (baseline.ContainsKey(line.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in purchase projection.");
                if (checked(line.RecordedQuantity + line.ReceivedQuantity) != line.ProjectedQuantity)
                    throw new InvalidOperationException("Inconsistent projected stock quantity.");
                baseline.Add(line.ArticleId, line.RecordedQuantity);
                totals.Add(new PurchaseReceiptArticleTotal(line.ArticleId, line.Barcode,
                    line.ReceivedQuantity, line.ExtendedCost));
                totalQuantity = checked(totalQuantity + line.ReceivedQuantity);
                totalCost = checked(totalCost + line.ExtendedCost);
            }
            if (totalQuantity != projection.TotalReceivedQuantity ||
                totalCost != projection.TotalReceiptCost)
                throw new InvalidOperationException("Inconsistent purchase projection totals.");

            var receipt = new PurchaseReceiptPreview(projection.SupplierId, totals,
                totalQuantity, totalCost);
            PurchaseReceiptCatalogueValidation catalogue =
                PurchaseReceiptCatalogueValidationService.Compare(receipt, currentCatalogue);
            PurchaseReceiptSupplierValidation supplier =
                PurchaseReceiptSupplierValidationService.Compare(receipt, currentSuppliers);

            var stock = new Dictionary<string, decimal>(StringComparer.Ordinal);
            foreach (StockBaselineLine line in currentStock)
            {
                if (line == null || String.IsNullOrWhiteSpace(line.ArticleId))
                    throw new ArgumentException("Invalid current stock row.", "currentStock");
                if (stock.ContainsKey(line.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in current stock.");
                stock.Add(line.ArticleId, line.RecordedQuantity);
            }

            var missingStock = new List<string>();
            var changedStock = new List<string>();
            foreach (PurchaseReceiptStockProjectionLine line in projection.Lines)
            {
                decimal currentQuantity;
                if (!stock.TryGetValue(line.ArticleId, out currentQuantity))
                    missingStock.Add(line.ArticleId);
                else if (currentQuantity != baseline[line.ArticleId])
                    changedStock.Add(line.ArticleId);
            }
            return new PurchaseReceiptFreshnessPreview(!supplier.IsKnown,
                catalogue.UnknownArticleIds, catalogue.BarcodeChangedArticleIds,
                missingStock, changedStock);
        }
    }
}
