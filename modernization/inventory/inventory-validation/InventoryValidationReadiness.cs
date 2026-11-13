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
        // Materialize exactly once after authorization: reject a changed UI count
        // that no longer matches the immutable inventory request identities.
        var countSnapshot = new List<StockCountLine>(counted);
        EnsureCountIdentitiesMatchRequest(request, countSnapshot);
        return InventoryValidationPreparation.RequireCompleteFreshCount(
            originalBaseline, countSnapshot, lockedCurrentBaseline);
    }
    // Pure guard; also exercised independently while grant issuance is disabled.
    internal static void EnsureCountIdentitiesMatchRequest(
        InventoryValidationRequest request, IReadOnlyList<StockCountLine> countSnapshot)
    {
        if (request is null || countSnapshot is null)
            throw new ArgumentNullException(request is null ? nameof(request) : nameof(countSnapshot));
        if (request.ArticleIds is null || request.ArticleIds.Count != countSnapshot.Count)
            throw new InvalidOperationException("Inventory count identities changed since request snapshot.");
        var expected = new HashSet<string>(request.ArticleIds, StringComparer.Ordinal);
        foreach (var line in countSnapshot)
            if (line is null || string.IsNullOrWhiteSpace(line.ArticleId) ||
                !expected.Remove(line.ArticleId))
                throw new InvalidOperationException("Inventory count contains unexpected or duplicate article identity.");
        if (expected.Count != 0)
            throw new InvalidOperationException("Inventory count is missing requested article identities.");
    }
}
