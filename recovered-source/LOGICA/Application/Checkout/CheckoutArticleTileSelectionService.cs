using System;
using System.Data;

namespace LOGICA.ApplicationLayer.Checkout
{
    // The tile remembers which article was displayed, not just its barcode.
    // A barcode may legitimately belong to several catalogue variants.
    internal sealed class CheckoutArticleTileReference
    {
        internal string Code { get; private set; }
        internal string ArticleId { get; private set; }

        internal CheckoutArticleTileReference(string code, string articleId)
        {
            Code = code;
            ArticleId = articleId;
        }

        // Retain the old Tag.ToString() barcode behavior for UI consumers.
        public override string ToString() { return Code; }
    }

    // Portable identity boundary. Never pick another variant when a tile's
    // original article is no longer in the scanner's current result set.
    internal static class CheckoutArticleTileSelectionService
    {
        internal static CheckoutArticleTileReference TagFor(DataRow article)
        {
            if (article == null) throw new ArgumentNullException("article");
            return new CheckoutArticleTileReference(
                article["Code"].ToString(), article["ID_ARTICLE"].ToString());
        }

        internal static DataRow FindExact(DataTable candidates, CheckoutArticleTileReference tile)
        {
            if (candidates == null) throw new ArgumentNullException("candidates");
            if (tile == null) throw new ArgumentNullException("tile");
            DataRow found = null;
            foreach (DataRow row in candidates.Rows)
            {
                if (String.Equals(row["Code"].ToString(), tile.Code, StringComparison.Ordinal) &&
                    String.Equals(row["ID_ARTICLE"].ToString(), tile.ArticleId, StringComparison.Ordinal))
                {
                    // Corrupt or ambiguous result sets must not silently post a sale.
                    if (found != null) return null;
                    found = row;
                }
            }
            return found;
        }
    }
}
