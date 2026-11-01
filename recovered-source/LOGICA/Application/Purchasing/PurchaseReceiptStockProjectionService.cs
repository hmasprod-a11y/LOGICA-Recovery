using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // Read-only projection of a received purchase against a caller-supplied stock snapshot.
    // NOT a stock mutation, posting authorization, reservation or transactional lock.
    internal sealed class PurchaseReceiptStockProjectionLine
    {
        internal readonly string ArticleId;
        internal readonly string Barcode;
        internal readonly decimal RecordedQuantity;
        internal readonly decimal ReceivedQuantity;
        internal readonly decimal ProjectedQuantity;
        internal readonly decimal ExtendedCost;

        internal PurchaseReceiptStockProjectionLine(PurchaseReceiptArticleTotal receipt,
            decimal recordedQuantity, decimal projectedQuantity)
        {
            ArticleId = receipt.ArticleId;
            Barcode = receipt.Barcode;
            RecordedQuantity = recordedQuantity;
            ReceivedQuantity = receipt.Quantity;
            ProjectedQuantity = projectedQuantity;
            ExtendedCost = receipt.ExtendedCost;
        }
    }

    internal sealed class PurchaseReceiptStockProjection
    {
        internal readonly string SupplierId;
        internal readonly IList<PurchaseReceiptStockProjectionLine> Lines;
        internal readonly decimal TotalReceivedQuantity;
        internal readonly decimal TotalReceiptCost;

        internal PurchaseReceiptStockProjection(PurchaseReceiptPreview receipt,
            IList<PurchaseReceiptStockProjectionLine> lines)
        {
            SupplierId = receipt.SupplierId;
            Lines = new List<PurchaseReceiptStockProjectionLine>(lines).AsReadOnly();
            TotalReceivedQuantity = receipt.TotalQuantity;
            TotalReceiptCost = receipt.TotalCost;
        }
    }

    internal static class PurchaseReceiptStockProjectionService
    {
        // Catalogue and stock MUST be authoritative snapshots taken in a consistent
        // transaction by a future adapter. This preview cannot prove their freshness.
        // Match exact ID_ARTICLE, never barcode (which may identify several variants).
        internal static PurchaseReceiptStockProjection Build(PurchaseReceiptPreview receipt,
            IEnumerable<ReceiptCatalogueArticle> catalogue,
            IEnumerable<StockBaselineLine> stockSnapshot)
        {
            if (receipt == null) throw new ArgumentNullException("receipt");
            if (catalogue == null) throw new ArgumentNullException("catalogue");
            if (stockSnapshot == null) throw new ArgumentNullException("stockSnapshot");

            PurchaseReceiptCatalogueValidation identity =
                PurchaseReceiptCatalogueValidationService.Compare(receipt, catalogue);
            if (!identity.IsValid)
                throw new InvalidOperationException(
                    "Receipt contains missing articles or changed barcodes; refresh the catalogue.");

            var recorded = new Dictionary<string, decimal>(StringComparer.Ordinal);
            foreach (StockBaselineLine row in stockSnapshot)
            {
                if (row == null)
                    throw new ArgumentException("Stock snapshot row cannot be null.", "stockSnapshot");
                if (String.IsNullOrWhiteSpace(row.ArticleId))
                    throw new ArgumentException("Stock snapshot article ID is required.", "stockSnapshot");
                if (recorded.ContainsKey(row.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in stock snapshot.");
                // Preserve legacy negative stock: no implicit normalization to zero.
                recorded.Add(row.ArticleId, row.RecordedQuantity);
            }

            var lines = new List<PurchaseReceiptStockProjectionLine>();
            foreach (PurchaseReceiptArticleTotal article in receipt.Articles)
            {
                decimal existing;
                if (!recorded.TryGetValue(article.ArticleId, out existing))
                    throw new InvalidOperationException(
                        "Receipt article is missing from stock snapshot; refresh before preview.");
                decimal projected = checked(existing + article.Quantity);
                lines.Add(new PurchaseReceiptStockProjectionLine(article, existing, projected));
            }
            return new PurchaseReceiptStockProjection(receipt, lines);
        }
    }
}
