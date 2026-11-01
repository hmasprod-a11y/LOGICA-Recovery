using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Inventory
{
    internal sealed class StockCountAdjustmentProposal
    {
        internal readonly string ArticleId;
        internal readonly decimal RecordedQuantity;
        internal readonly decimal CountedQuantity;
        internal readonly decimal Delta;

        internal StockCountAdjustmentProposal(StockCountVariance variance)
        {
            ArticleId = variance.ArticleId;
            RecordedQuantity = variance.RecordedQuantity;
            CountedQuantity = variance.CountedQuantity;
            Delta = variance.Difference;
        }
    }

    internal sealed class StockCountAdjustmentPlan
    {
        internal readonly IList<StockCountAdjustmentProposal> Adjustments;
        internal readonly decimal TotalShortage;
        internal readonly decimal TotalSurplus;

        internal StockCountAdjustmentPlan(IList<StockCountAdjustmentProposal> adjustments,
            decimal shortage, decimal surplus)
        {
            Adjustments = new List<StockCountAdjustmentProposal>(adjustments).AsReadOnly();
            TotalShortage = shortage;
            TotalSurplus = surplus;
        }
    }

    // Generates an informational proposal, NOT a stock write or approval.
    // Incomplete physical counts must never become stock adjustment commands.
    internal static class StockCountAdjustmentProposalService
    {
        internal static StockCountAdjustmentPlan Create(StockCountCoveragePreview coverage)
        {
            if (coverage == null) throw new ArgumentNullException("coverage");
            if (!coverage.IsComplete)
                throw new InvalidOperationException("Cannot propose adjustments for incomplete stocktake.");

            var adjustments = new List<StockCountAdjustmentProposal>();
            foreach (StockCountVariance variance in coverage.MatchedVariances.Lines)
                if (variance.Difference != 0m)
                    adjustments.Add(new StockCountAdjustmentProposal(variance));

            return new StockCountAdjustmentPlan(adjustments,
                coverage.MatchedVariances.TotalShortage,
                coverage.MatchedVariances.TotalSurplus);
        }
    }
}
