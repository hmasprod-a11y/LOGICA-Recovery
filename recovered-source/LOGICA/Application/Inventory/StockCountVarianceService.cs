using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Inventory
{
    // Physical count preview only. The caller must separately authorize any
    // stock adjustment; this class never writes to LOGICA or MariaDB.
    internal sealed class StockCountLine
    {
        internal readonly string ArticleId;
        internal readonly decimal RecordedQuantity;
        internal readonly decimal CountedQuantity;

        internal StockCountLine(string articleId, decimal recordedQuantity, decimal countedQuantity)
        {
            ArticleId = articleId;
            RecordedQuantity = recordedQuantity;
            CountedQuantity = countedQuantity;
        }
    }

    internal sealed class StockCountVariance
    {
        internal readonly string ArticleId;
        internal readonly decimal RecordedQuantity;
        internal readonly decimal CountedQuantity;
        internal readonly decimal Difference;

        internal StockCountVariance(StockCountLine line, decimal difference)
        {
            ArticleId = line.ArticleId;
            RecordedQuantity = line.RecordedQuantity;
            CountedQuantity = line.CountedQuantity;
            Difference = difference;
        }
    }

    internal sealed class StockCountPreview
    {
        internal readonly IList<StockCountVariance> Lines;
        internal readonly decimal TotalShortage;
        internal readonly decimal TotalSurplus;

        internal StockCountPreview(IList<StockCountVariance> lines, decimal shortage, decimal surplus)
        {
            Lines = new List<StockCountVariance>(lines).AsReadOnly();
            TotalShortage = shortage;
            TotalSurplus = surplus;
        }
    }

    internal static class StockCountVarianceService
    {
        internal static StockCountPreview Compare(IEnumerable<StockCountLine> counts)
        {
            if (counts == null) throw new ArgumentNullException("counts");
            var seen = new HashSet<string>(StringComparer.Ordinal);
            var variances = new List<StockCountVariance>();
            decimal shortage = 0m;
            decimal surplus = 0m;
            foreach (StockCountLine line in counts)
            {
                if (line == null) throw new ArgumentException("Count line cannot be null.", "counts");
                if (String.IsNullOrWhiteSpace(line.ArticleId))
                    throw new ArgumentException("Count line requires an article ID.", "counts");
                if (!seen.Add(line.ArticleId))
                    throw new InvalidOperationException("Duplicate article ID in physical count.");
                if (line.CountedQuantity < 0m)
                    throw new ArgumentOutOfRangeException("counts", "Physical count cannot be negative.");
                // Negative recorded quantities can exist in the legacy POS;
                // do not silently normalize or reject them.
                decimal difference = checked(line.CountedQuantity - line.RecordedQuantity);
                if (difference < 0m) shortage = checked(shortage - difference);
                else surplus = checked(surplus + difference);
                variances.Add(new StockCountVariance(line, difference));
            }
            return new StockCountPreview(variances, shortage, surplus);
        }
    }
}
