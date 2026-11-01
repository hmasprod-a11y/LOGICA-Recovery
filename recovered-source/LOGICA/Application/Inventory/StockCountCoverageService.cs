using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Inventory
{
    // Recorded stock is a snapshot supplied by a caller; no database reads or writes.
    internal sealed class StockBaselineLine
    {
        internal readonly string ArticleId;
        internal readonly decimal RecordedQuantity;

        internal StockBaselineLine(string articleId, decimal recordedQuantity)
        {
            ArticleId = articleId;
            RecordedQuantity = recordedQuantity;
        }
    }

    internal sealed class StockCountCoveragePreview
    {
        internal readonly StockCountPreview MatchedVariances;
        internal readonly IList<string> UncountedArticleIds;
        internal readonly IList<string> UnknownArticleIds;

        internal StockCountCoveragePreview(StockCountPreview matched, IList<string> uncounted,
            IList<string> unknown)
        {
            MatchedVariances = matched;
            UncountedArticleIds = new List<string>(uncounted).AsReadOnly();
            UnknownArticleIds = new List<string>(unknown).AsReadOnly();
        }

        // A partial physical count must never be mistaken for a complete stocktake.
        internal bool IsComplete { get { return UncountedArticleIds.Count == 0 &&
            UnknownArticleIds.Count == 0; } }
    }

    internal static class StockCountCoverageService
    {
        // Match exact ID_ARTICLE identities, not potentially duplicated barcodes.
        // Missing articles are reported, never implicitly counted as zero.
        internal static StockCountCoveragePreview Compare(IEnumerable<StockBaselineLine> baseline,
            IEnumerable<StockCountLine> counted)
        {
            if (baseline == null) throw new ArgumentNullException("baseline");
            if (counted == null) throw new ArgumentNullException("counted");

            var recorded = new Dictionary<string, decimal>(StringComparer.Ordinal);
            var baselineOrder = new List<string>();
            foreach (StockBaselineLine line in baseline)
            {
                if (line == null) throw new ArgumentException("Baseline line cannot be null.", "baseline");
                if (String.IsNullOrWhiteSpace(line.ArticleId))
                    throw new ArgumentException("Baseline article ID is required.", "baseline");
                if (recorded.ContainsKey(line.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in recorded stock.");
                recorded.Add(line.ArticleId, line.RecordedQuantity);
                baselineOrder.Add(line.ArticleId);
            }

            var observed = new HashSet<string>(StringComparer.Ordinal);
            var matched = new List<StockCountLine>();
            var unknown = new List<string>();
            foreach (StockCountLine line in counted)
            {
                if (line == null) throw new ArgumentException("Count line cannot be null.", "counted");
                if (String.IsNullOrWhiteSpace(line.ArticleId))
                    throw new ArgumentException("Count article ID is required.", "counted");
                if (line.CountedQuantity < 0m)
                    throw new ArgumentOutOfRangeException("counted", "Physical count cannot be negative.");
                if (!observed.Add(line.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in physical count.");
                decimal quantity;
                if (recorded.TryGetValue(line.ArticleId, out quantity))
                    matched.Add(new StockCountLine(line.ArticleId, quantity, line.CountedQuantity));
                else unknown.Add(line.ArticleId);
            }

            var uncounted = new List<string>();
            foreach (string id in baselineOrder)
                if (!observed.Contains(id)) uncounted.Add(id);

            return new StockCountCoveragePreview(StockCountVarianceService.Compare(matched),
                uncounted, unknown);
        }
    }
}
