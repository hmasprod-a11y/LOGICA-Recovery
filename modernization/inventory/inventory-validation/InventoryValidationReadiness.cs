using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;

namespace Hanouty.Inventory.Validation;

// This entry point is deliberately read-only. The future SQL adapter must call it
// again after locking and re-reading authoritative rows inside its own transaction.
// A missing grant must reject BEFORE any supplied count/baseline is enumerated.
internal static class InventoryValidationReadiness
{
    internal static StockCountAdjustmentPlan RequireAuthorizedCompleteFreshCount(
        InventoryValidationRequest request,
        VerifiedInventoryValidationGrant? grant,
        DateTimeOffset now,
        IEnumerable<StockBaselineLine> originalBaseline,
        IEnumerable<StockCountLine> counted,
        IEnumerable<StockBaselineLine> lockedCurrentBaseline)
    {
        InventoryValidationBoundary.DemandVerifiedGrant(request, grant, now);
        return InventoryValidationPreparation.RequireCompleteFreshCount(
            originalBaseline, counted, lockedCurrentBaseline);
    }
}
