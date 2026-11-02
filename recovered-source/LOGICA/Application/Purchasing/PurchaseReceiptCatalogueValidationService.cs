using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // Authoritative catalogue snapshot supplied by the caller; barcode is not unique.
    internal sealed class ReceiptCatalogueArticle
    {
        internal readonly string ArticleId;
        internal readonly string Barcode;

        internal ReceiptCatalogueArticle(string articleId, string barcode)
        {
            ArticleId = articleId;
            Barcode = barcode;
        }
    }

    internal sealed class PurchaseReceiptCatalogueValidation
    {
        internal readonly IList<string> MatchedArticleIds;
        internal readonly IList<string> UnknownArticleIds;
        internal readonly IList<string> BarcodeChangedArticleIds;

        internal PurchaseReceiptCatalogueValidation(IList<string> matched,
            IList<string> unknown, IList<string> changed)
        {
            MatchedArticleIds = new List<string>(matched).AsReadOnly();
            UnknownArticleIds = new List<string>(unknown).AsReadOnly();
            BarcodeChangedArticleIds = new List<string>(changed).AsReadOnly();
        }

        internal bool IsValid
        {
            get { return UnknownArticleIds.Count == 0 && BarcodeChangedArticleIds.Count == 0; }
        }
    }

    // Preview-only identity verification before any receipt is allowed to reach
    // a future stock posting boundary. Does not access a DB or authorize posting.
    internal static class PurchaseReceiptCatalogueValidationService
    {
        internal static PurchaseReceiptCatalogueValidation Compare(
            PurchaseReceiptPreview receipt, IEnumerable<ReceiptCatalogueArticle> catalogue)
        {
            if (receipt == null) throw new ArgumentNullException("receipt");
            if (catalogue == null) throw new ArgumentNullException("catalogue");

            var current = new Dictionary<string, string>(StringComparer.Ordinal);
            foreach (ReceiptCatalogueArticle article in catalogue)
            {
                if (article == null)
                    throw new ArgumentException("Catalogue row cannot be null.", "catalogue");
                if (String.IsNullOrWhiteSpace(article.ArticleId))
                    throw new ArgumentException("Catalogue article ID is required.", "catalogue");
                if (current.ContainsKey(article.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in catalogue snapshot.");
                current.Add(article.ArticleId, article.Barcode);
            }

            var matched = new List<string>();
            var unknown = new List<string>();
            var changed = new List<string>();
            foreach (PurchaseReceiptArticleTotal line in receipt.Articles)
            {
                string barcode;
                if (!current.TryGetValue(line.ArticleId, out barcode))
                    unknown.Add(line.ArticleId);
                else if (!String.Equals(barcode, line.Barcode, StringComparison.Ordinal))
                    changed.Add(line.ArticleId);
                else
                    matched.Add(line.ArticleId);
            }

            return new PurchaseReceiptCatalogueValidation(matched, unknown, changed);
        }
    }
}
