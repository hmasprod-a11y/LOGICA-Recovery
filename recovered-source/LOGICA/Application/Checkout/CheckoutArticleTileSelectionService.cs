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
            // A tile must not be created from a pending-deleted article or an
            // incomplete identity. Blank barcodes remain valid for image tiles.
            if (article.RowState == DataRowState.Deleted ||
                article.RowState == DataRowState.Detached ||
                article.Table == null ||
                !article.Table.Columns.Contains("Code") ||
                !article.Table.Columns.Contains("ID_ARTICLE") ||
                article.IsNull("Code") || article.IsNull("ID_ARTICLE") ||
                String.IsNullOrEmpty(Convert.ToString(article["ID_ARTICLE"])))
                throw new InvalidOperationException("Image tile article identity is incomplete.");
            return new CheckoutArticleTileReference(
                Convert.ToString(article["Code"]), Convert.ToString(article["ID_ARTICLE"]));
        }

        // Typed result for a future UI: distinguish missing, ambiguous and
        // malformed catalogue results without touching the original WinForms.
        // Reuse the same candidate validation as barcode variant selection.
        internal static CheckoutVariantChoiceResult EvaluateExact(
            DataTable candidates, CheckoutArticleTileReference tile)
        {
            if (candidates == null) throw new ArgumentNullException("candidates");
            if (tile == null) throw new ArgumentNullException("tile");
            return CheckoutVariantSnapshotService.EvaluateChoice(
                candidates, new[] { new CheckoutVariantSnapshot(tile.Code, tile.ArticleId) }, 0);
        }

        // Preserve the legacy null-or-row surface, but never return a deleted
        // row, a reused article ID, or a match from a corrupt result set.
        internal static DataRow FindExact(DataTable candidates, CheckoutArticleTileReference tile)
        {
            return EvaluateExact(candidates, tile).SelectedRow;
        }
    }
}
