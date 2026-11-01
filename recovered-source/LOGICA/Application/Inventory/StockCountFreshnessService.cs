using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Inventory
{
    // A diagnostic comparison, never a stock posting authorization or lock.
    // A complete count can become stale while sales and purchases continue.
    internal sealed class StockCountFreshnessPreview
    {
        internal readonly IList<string> ChangedQuantityArticleIds;
        internal readonly IList<string> MissingArticleIds;
        internal readonly IList<string> AddedArticleIds;

        internal StockCountFreshnessPreview(IList<string> changed, IList<string> missing,
            IList<string> added)
        {
            ChangedQuantityArticleIds = new List<string>(changed).AsReadOnly();
            MissingArticleIds = new List<string>(missing).AsReadOnly();
            AddedArticleIds = new List<string>(added).AsReadOnly();
        }

        internal bool IsFresh
        {
            get { return ChangedQuantityArticleIds.Count == 0 &&
                MissingArticleIds.Count == 0 && AddedArticleIds.Count == 0; }
        }
    }

    internal static class StockCountFreshnessService
    {
        // Compare ALL counted identities, including zero-delta articles. Using only
        // StockCountAdjustmentPlan would miss changed articles without proposals.
        // A future MariaDB adapter must repeat this check inside its own transaction.
        internal static StockCountFreshnessPreview Compare(StockCountCoveragePreview completed,
            IEnumerable<StockBaselineLine> currentStock)
        {
            if (completed == null) throw new ArgumentNullException("completed");
            if (currentStock == null) throw new ArgumentNullException("currentStock");
            if (!completed.IsComplete)
                throw new InvalidOperationException("Cannot validate freshness of a partial stocktake.");

            var original = new Dictionary<string, decimal>(StringComparer.Ordinal);
            var originalOrder = new List<string>();
            foreach (StockCountVariance line in completed.MatchedVariances.Lines)
            {
                if (line == null || String.IsNullOrWhiteSpace(line.ArticleId))
                    throw new ArgumentException("Invalid completed count.", "completed");
                if (original.ContainsKey(line.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in completed count.");
                original.Add(line.ArticleId, line.RecordedQuantity);
                originalOrder.Add(line.ArticleId);
            }

            var current = new Dictionary<string, decimal>(StringComparer.Ordinal);
            var currentOrder = new List<string>();
            foreach (StockBaselineLine line in currentStock)
            {
                if (line == null)
                    throw new ArgumentException("Current stock row cannot be null.", "currentStock");
                if (String.IsNullOrWhiteSpace(line.ArticleId))
                    throw new ArgumentException("Current stock article ID is required.", "currentStock");
                if (current.ContainsKey(line.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in current stock.");
                current.Add(line.ArticleId, line.RecordedQuantity);
                currentOrder.Add(line.ArticleId);
            }

            var changed = new List<string>();
            var missing = new List<string>();
            var added = new List<string>();
            foreach (string id in originalOrder)
            {
                decimal quantity;
                if (!current.TryGetValue(id, out quantity)) missing.Add(id);
                else if (quantity != original[id]) changed.Add(id);
            }
            foreach (string id in currentOrder)
                if (!original.ContainsKey(id)) added.Add(id);

            return new StockCountFreshnessPreview(changed, missing, added);
        }
    }
}
