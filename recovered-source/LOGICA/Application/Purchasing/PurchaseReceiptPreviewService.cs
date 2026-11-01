using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // A side-effect-free preview: no stock writes, supplier updates or SQL.
    // The legacy catalogue identifies a variant by ID_ARTICLE, not by Code.
    internal sealed class PurchaseReceiptLine
    {
        internal readonly string ArticleId;
        internal readonly string Barcode;
        internal readonly decimal Quantity;
        internal readonly decimal UnitCost;

        internal PurchaseReceiptLine(string articleId, string barcode, decimal quantity, decimal unitCost)
        {
            ArticleId = articleId;
            Barcode = barcode;
            Quantity = quantity;
            UnitCost = unitCost;
        }
    }

    internal sealed class PurchaseReceiptArticleTotal
    {
        internal readonly string ArticleId;
        internal readonly string Barcode;
        internal readonly decimal Quantity;
        internal readonly decimal ExtendedCost;

        internal PurchaseReceiptArticleTotal(string articleId, string barcode, decimal quantity, decimal extendedCost)
        {
            ArticleId = articleId;
            Barcode = barcode;
            Quantity = quantity;
            ExtendedCost = extendedCost;
        }
    }

    internal sealed class PurchaseReceiptPreview
    {
        internal readonly string SupplierId;
        internal readonly IList<PurchaseReceiptArticleTotal> Articles;
        internal readonly decimal TotalQuantity;
        internal readonly decimal TotalCost;

        internal PurchaseReceiptPreview(string supplierId, IList<PurchaseReceiptArticleTotal> articles,
            decimal totalQuantity, decimal totalCost)
        {
            SupplierId = supplierId;
            Articles = new List<PurchaseReceiptArticleTotal>(articles).AsReadOnly();
            TotalQuantity = totalQuantity;
            TotalCost = totalCost;
        }
    }

    internal static class PurchaseReceiptPreviewService
    {
        // Exact IDs and barcodes are retained. Different IDs may share a barcode;
        // conflicting barcodes for one ID fail closed instead of guessing.
        internal static PurchaseReceiptPreview Build(string supplierId, IEnumerable<PurchaseReceiptLine> lines)
        {
            if (String.IsNullOrWhiteSpace(supplierId))
                throw new ArgumentException("A supplier identity is required.", "supplierId");
            if (lines == null) throw new ArgumentNullException("lines");

            var articles = new List<PurchaseReceiptArticleTotal>();
            var positions = new Dictionary<string, int>(StringComparer.Ordinal);
            decimal totalQuantity = 0m;
            decimal totalCost = 0m;
            foreach (PurchaseReceiptLine line in lines)
            {
                if (line == null) throw new ArgumentException("A receipt line cannot be null.", "lines");
                if (String.IsNullOrWhiteSpace(line.ArticleId))
                    throw new ArgumentException("A receipt line requires an article ID.", "lines");
                if (line.Quantity <= 0m)
                    throw new ArgumentOutOfRangeException("lines", "Received quantity must be positive.");
                if (line.UnitCost < 0m)
                    throw new ArgumentOutOfRangeException("lines", "Purchase cost cannot be negative.");

                decimal extended = checked(line.Quantity * line.UnitCost);
                int position;
                if (positions.TryGetValue(line.ArticleId, out position))
                {
                    PurchaseReceiptArticleTotal old = articles[position];
                    if (!String.Equals(old.Barcode, line.Barcode, StringComparison.Ordinal))
                        throw new InvalidOperationException("One article ID has conflicting barcodes.");
                    articles[position] = new PurchaseReceiptArticleTotal(old.ArticleId, old.Barcode,
                        checked(old.Quantity + line.Quantity), checked(old.ExtendedCost + extended));
                }
                else
                {
                    positions.Add(line.ArticleId, articles.Count);
                    articles.Add(new PurchaseReceiptArticleTotal(line.ArticleId, line.Barcode,
                        line.Quantity, extended));
                }
                totalQuantity = checked(totalQuantity + line.Quantity);
                totalCost = checked(totalCost + extended);
            }
            if (articles.Count == 0)
                throw new ArgumentException("A receipt must contain at least one line.", "lines");
            return new PurchaseReceiptPreview(supplierId, articles, totalQuantity, totalCost);
        }
    }
}
