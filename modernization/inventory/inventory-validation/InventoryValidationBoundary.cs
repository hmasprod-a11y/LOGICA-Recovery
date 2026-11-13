using System;
using System.Collections.Generic;

namespace Hanouty.Inventory.Validation;

// Fail-closed authorization boundary. This is NOT a mapping from legacy grants.
// Only a trusted adapter may provide a verified grant; no production adapter exists yet.
internal sealed class VerifiedInventoryValidationGrant
{
    internal string ActorId { get; }
    internal string SessionId { get; }
    internal string InventoryId { get; }
    internal DateTimeOffset ExpiresAt { get; }

    private VerifiedInventoryValidationGrant(string actorId, string sessionId,
        string inventoryId, DateTimeOffset expiresAt)
    {
        ActorId = actorId;
        SessionId = sessionId;
        InventoryId = inventoryId;
        ExpiresAt = expiresAt;
    }

    // Intentionally no public or internal factory. Mapping approval is a prerequisite.
}

internal sealed class InventoryValidationRequest
{
    internal string InventoryId { get; }
    internal IReadOnlyList<string> ArticleIds { get; }

    internal InventoryValidationRequest(string inventoryId, IReadOnlyList<string> articleIds)
    {
        InventoryId = inventoryId;
        // Snapshot the caller's mutable UI list at the boundary.
        // A scan/edit cannot change authorized identities after validation (TOCTOU).
        ArticleIds = articleIds is null ? null! : Array.AsReadOnly(new List<string>(articleIds).ToArray());
    }
}

internal static class InventoryValidationBoundary
{
    // No transaction/stock/movement/header/detail operation may be invoked before this.
    internal static void DemandVerifiedGrant(InventoryValidationRequest request,
        VerifiedInventoryValidationGrant? grant, DateTimeOffset now)
    {
        if (request is null) throw new ArgumentNullException(nameof(request));
        if (string.IsNullOrWhiteSpace(request.InventoryId) ||
            request.ArticleIds is null || request.ArticleIds.Count == 0)
            throw new InvalidOperationException("Inventory identity and count lines required.");
        var seen = new HashSet<string>(StringComparer.Ordinal);
        foreach (string articleId in request.ArticleIds)
            if (string.IsNullOrWhiteSpace(articleId) || !seen.Add(articleId))
                throw new InvalidOperationException("Missing or duplicate article identity.");

        if (grant is null || string.IsNullOrWhiteSpace(grant.ActorId) ||
            string.IsNullOrWhiteSpace(grant.SessionId) ||
            !StringComparer.Ordinal.Equals(grant.InventoryId, request.InventoryId) ||
            grant.ExpiresAt <= now)
            throw new UnauthorizedAccessException("Inventory validation capability not verified.");
    }
}
