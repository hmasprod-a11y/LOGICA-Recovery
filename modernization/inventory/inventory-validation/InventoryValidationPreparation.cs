using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;

namespace Hanouty.Inventory.Validation;

// Read-only preparation. Never authorizes a write or replaces transaction-local SELECT ... FOR UPDATE.
internal static class InventoryValidationPreparation
{
    internal static StockCountAdjustmentPlan RequireCompleteFreshCount(
        IEnumerable<StockBaselineLine> originalBaseline,
        IEnumerable<StockCountLine> counted,
        IEnumerable<StockBaselineLine> lockedCurrentBaseline)
    {
        var coverage = StockCountCoverageService.Compare(originalBaseline, counted);
        if (!coverage.IsComplete)
            throw new InvalidOperationException("Inventory coverage incomplete: missing or unknown article identities.");
        var freshness = StockCountFreshnessService.Compare(coverage, lockedCurrentBaseline);
        if (!freshness.IsFresh)
            throw new InvalidOperationException("Inventory baseline stale: quantity or article set changed.");
        return StockCountAdjustmentProposalService.Create(coverage);
    }
}
