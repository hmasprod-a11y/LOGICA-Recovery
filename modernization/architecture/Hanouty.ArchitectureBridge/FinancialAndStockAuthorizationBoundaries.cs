using System;

namespace Hanouty.ArchitectureBridge;

// Contract only: Checkout owns durable MariaDB reads, locking, quantities and posting.
// Never infer original-sale eligibility from a UI ticket number or article ID.
public sealed record OriginalSaleLineReference(string SaleId, string SaleLineId);
public sealed record OriginalSaleReturnEvidence(
    OriginalSaleLineReference Original,
    string ArticleId,
    int OriginallySoldQuantity,
    int PreviouslyReturnedQuantity);

public interface IOriginalSaleReturnEvidenceReader
{
    // Must read authoritative persisted sale and returns under the SAME
    // transaction/lock as the eventual return write; null means no grant.
    OriginalSaleReturnEvidence? ReadForUpdate(OriginalSaleLineReference original);
}

public static class OriginalSaleReturnGuard
{
    public static void RequireAvailable(OriginalSaleLineReference original,
        OriginalSaleReturnEvidence? evidence, string articleId, int quantity)
    {
        ArgumentNullException.ThrowIfNull(original);
        if (string.IsNullOrWhiteSpace(original.SaleId) ||
            string.IsNullOrWhiteSpace(original.SaleLineId) ||
            string.IsNullOrWhiteSpace(articleId) || quantity <= 0 ||
            evidence is null || evidence.Original != original ||
            !string.Equals(evidence.ArticleId, articleId, StringComparison.Ordinal) ||
            evidence.OriginallySoldQuantity <= 0 ||
            evidence.PreviouslyReturnedQuantity < 0 ||
            evidence.PreviouslyReturnedQuantity >= evidence.OriginallySoldQuantity ||
            quantity > evidence.OriginallySoldQuantity - evidence.PreviouslyReturnedQuantity)
            throw new InvalidOperationException("Original sale return is not durably authorized.");
    }
}

// Identity comes from a verified server-side session, never a caller-supplied
// UserId, ADMIN label or legacy MODIF_QTE flag.
public sealed record VerifiedStockActor(string SessionId, string ActorId);
public interface IVerifiedStockActorSource
{
    VerifiedStockActor? CurrentVerifiedActor();
}
public interface IManualStockPermissionReader
{
    // Implementation must verify actor and permission in trusted persistence.
    // No result, unknown session or storage failure means DENY.
    bool CanAdjustStock(VerifiedStockActor actor);
}
public static class ManualStockAuthorizationBoundary
{
    public static VerifiedStockActor RequireAuthorized(
        IVerifiedStockActorSource actors, IManualStockPermissionReader permissions)
    {
        ArgumentNullException.ThrowIfNull(actors);
        ArgumentNullException.ThrowIfNull(permissions);
        var actor = actors.CurrentVerifiedActor();
        if (actor is null || string.IsNullOrWhiteSpace(actor.SessionId) ||
            string.IsNullOrWhiteSpace(actor.ActorId) || !permissions.CanAdjustStock(actor))
            throw new UnauthorizedAccessException("Verified manual stock adjustment permission required.");
        return actor;
    }
}
