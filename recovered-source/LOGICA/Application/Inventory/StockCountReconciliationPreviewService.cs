using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Inventory
{
    internal sealed class StockCountReconciliationPreview
    {
        internal readonly StockCountFreshnessPreview Freshness;
        internal readonly StockCountAdjustmentPlan ProposedAdjustments;

        internal StockCountReconciliationPreview(StockCountFreshnessPreview freshness,
            StockCountAdjustmentPlan proposedAdjustments)
        {
            Freshness = freshness;
            ProposedAdjustments = proposedAdjustments;
        }

        internal bool CanPreviewAdjustments
        {
            get { return Freshness.IsFresh && ProposedAdjustments != null; }
        }
    }

    // Read-only gate: never turn a stale physical count into stock adjustment commands.
    internal static class StockCountReconciliationPreviewService
    {
        internal static StockCountReconciliationPreview Review(StockCountCoveragePreview completed,
            IEnumerable<StockBaselineLine> currentStock)
        {
            if (completed == null) throw new ArgumentNullException("completed");
            if (currentStock == null) throw new ArgumentNullException("currentStock");
            StockCountFreshnessPreview freshness =
                StockCountFreshnessService.Compare(completed, currentStock);
            // Even an unchanged zero-delta article must be revalidated.
            if (!freshness.IsFresh)
                return new StockCountReconciliationPreview(freshness, null);
            return new StockCountReconciliationPreview(freshness,
                StockCountAdjustmentProposalService.Create(completed));
        }
    }
}
