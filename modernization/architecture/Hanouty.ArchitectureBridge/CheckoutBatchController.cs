using System;
using System.Collections.Generic;

namespace Hanouty.ArchitectureBridge;

// An explicit atomic boundary: the host's Application cart implementation must
// persist ALL entries in one transaction or NONE. Never loop AddSelectedArticle.
public interface IAtomicCheckoutBatchPort
{
    void AddBatch(IReadOnlyList<CheckoutBatchLine> lines, string operationId);
}
public sealed record CheckoutBatchLine(string ArticleId, int Quantity);
public enum CheckoutBatchStatus { Committed, Empty, Invalidated }
public enum CheckoutCommitState { Ready, OutcomeUnknown }

// Staging does not mutate the cart. Every candidate is revalidated at commit,
// preventing a stale WPF tile or changed barcode from becoming a sale line.
public sealed class CheckoutBatchController
{
    private readonly ICheckoutSelectionCatalogue _catalogue;
    private readonly ICheckoutVariantPrompt _prompt;
    private readonly IAtomicCheckoutBatchPort _cart;
    private readonly List<PendingLine> _pending = new();
    private bool _committing;
    private string? _uncertainOperationId;

    public CheckoutCommitState State => _uncertainOperationId is null
        ? CheckoutCommitState.Ready : CheckoutCommitState.OutcomeUnknown;
    public string? UncertainOperationId => _uncertainOperationId;

    public CheckoutBatchController(ICheckoutSelectionCatalogue catalogue,
        ICheckoutVariantPrompt prompt, IAtomicCheckoutBatchPort cart)
    {
        _catalogue = catalogue ?? throw new ArgumentNullException(nameof(catalogue));
        _prompt = prompt ?? throw new ArgumentNullException(nameof(prompt));
        _cart = cart ?? throw new ArgumentNullException(nameof(cart));
    }

    public int PendingCount => _pending.Count;

    public SelectionResponse StageBarcode(string barcode, int quantity = 1)
    {
        EnsureMutable();
        EnsureQuantity(quantity);
        if (string.IsNullOrWhiteSpace(barcode))
            return new SelectionResponse(SelectionOutcome.Missing, null);
        var captured = barcode;
        var candidates = _catalogue.FindBarcode(captured);
        var result = CheckoutSelectionGateway.ResolveBarcode(
            candidates, _prompt.Choose,
            () => _catalogue.RefreshBarcode(captured));
        if (result.Outcome == SelectionOutcome.Selected)
            _pending.Add(new PendingLine(result.Article!, captured, quantity, false,
                candidates.Count > 1));
        return result;
    }

    public SelectionResponse StageImage(ArticleCandidate tile, int quantity = 1)
    {
        EnsureMutable();
        ArgumentNullException.ThrowIfNull(tile);
        EnsureQuantity(quantity);
        if (string.IsNullOrWhiteSpace(tile.ArticleId))
            return new SelectionResponse(SelectionOutcome.InvalidCandidates, null);
        var result = CheckoutSelectionGateway.ResolveImage(tile,
            () => _catalogue.RefreshArticle(tile.ArticleId));
        if (result.Outcome == SelectionOutcome.Selected)
            _pending.Add(new PendingLine(result.Article!, null, quantity, true, false));
        return result;
    }

    // Immutable identity/quantity input for the Host's authoritative price read.
    // This never authorizes a sale, calculates prices or touches persistence.
    public IReadOnlyList<CheckoutBatchLine> SnapshotLines()
    {
        if (_committing)
            throw new InvalidOperationException("Cannot quote a basket during financial commit.");
        if (_uncertainOperationId is not null)
            throw new InvalidOperationException("Resolve uncertain operation before requesting a fresh cart preview.");
        // Reads are safe during synchronous commit: mutation is already locked.
        var lines = new List<CheckoutBatchLine>(_pending.Count);
        var positions = new Dictionary<string, int>(StringComparer.Ordinal);
        foreach (var pending in _pending)
            AppendLine(lines, positions, pending.Candidate.ArticleId, pending.Quantity);
        return lines.AsReadOnly();
    }

    private static void AppendLine(List<CheckoutBatchLine> lines,
        Dictionary<string, int> positions, string articleId, int quantity)
    {
        if (positions.TryGetValue(articleId, out var position))
        {
            var existing = lines[position];
            lines[position] = existing with { Quantity = checked(existing.Quantity + quantity) };
        }
        else
        {
            positions.Add(articleId, lines.Count);
            lines.Add(new CheckoutBatchLine(articleId, quantity));
        }
    }

    internal bool SetQuantity(string articleId, int quantity)
    {
        EnsureMutable();
        if (quantity < 0) return false;
        var first = _pending.FindIndex(line => line.Candidate.ArticleId == articleId);
        if (first < 0) return false;
        var existing = _pending[first];
        _pending.RemoveAll(line => line.Candidate.ArticleId == articleId);
        if (quantity > 0) _pending.Insert(first, existing with { Quantity = quantity });
        return true;
    }

    public void Clear()
    {
        EnsureMutable();
        _pending.Clear();
    }

    // A failed revalidation does not clear staged data or touch the cart.
    // A failing port is not retried: the caller must reconcile operationId
    // with the Application layer before attempting a new commit.
    public CheckoutBatchStatus Commit(string operationId)
    {
        EnsureMutable();
        if (string.IsNullOrWhiteSpace(operationId))
            throw new ArgumentException("A stable operation ID is required.", nameof(operationId));
        if (_pending.Count == 0) return CheckoutBatchStatus.Empty;
        _committing = true;
        try
        {
            var lines = new List<CheckoutBatchLine>(_pending.Count);
            var positions = new Dictionary<string, int>(StringComparer.Ordinal);
            foreach (var pending in _pending)
            {
                SelectionResponse live = pending.IsImage
                    ? CheckoutSelectionGateway.ResolveImage(pending.Candidate,
                        () => _catalogue.RefreshArticle(pending.Candidate.ArticleId))
                    : RevalidateBarcode(pending);
                if (live.Outcome != SelectionOutcome.Selected ||
                    live.Article?.ArticleId != pending.Candidate.ArticleId ||
                    live.Article.Barcode != pending.Candidate.Barcode)
                    return CheckoutBatchStatus.Invalidated;
                AppendLine(lines, positions, pending.Candidate.ArticleId, pending.Quantity);
            }
            try { _cart.AddBatch(lines.AsReadOnly(), operationId); }
            catch
            {
                // A transaction may have committed before acknowledgement failed.
                // Fail closed until durable operation-ID reconciliation.
                _uncertainOperationId = operationId;
                throw;
            }
            _pending.Clear();
            return CheckoutBatchStatus.Committed;
        }
        finally { _committing = false; }
    }

    // Caller MUST verify durable operation ID with Checkout Application storage;
    // never infer persistence from a UI timeout or retry automatically.
    public void ReconcileUnknownOutcome(string operationId, bool persisted)
    {
        if (_committing) throw new InvalidOperationException("Checkout batch is committing.");
        if (_uncertainOperationId is null ||
            !string.Equals(operationId, _uncertainOperationId, StringComparison.Ordinal))
            throw new InvalidOperationException("No matching uncertain checkout operation.");
        if (persisted) _pending.Clear();
        _uncertainOperationId = null;
    }

    private SelectionResponse RevalidateBarcode(PendingLine pending)
    {
        // Use the complete live variant set. The original recovered selection
        // service still validates the chosen index and a second fresh snapshot.
        var live = _catalogue.RefreshBarcode(pending.Barcode!);
        // An explicit variant choice cannot silently degrade to a unique
        // barcode after another article is removed before commit.
        if (pending.WasDuplicate && live.Count < 2)
            return new SelectionResponse(SelectionOutcome.Missing, null);
        var index = -1;
        for (var i = 0; i < live.Count; i++)
        {
            if (live[i].ArticleId != pending.Candidate.ArticleId ||
                live[i].Barcode != pending.Candidate.Barcode) continue;
            if (index >= 0)
                return new SelectionResponse(SelectionOutcome.Ambiguous, null);
            index = i;
        }
        if (index < 0) return new SelectionResponse(SelectionOutcome.Missing, null);
        return CheckoutSelectionGateway.ResolveBarcode(live, _ => index,
            () => _catalogue.RefreshBarcode(pending.Barcode!));
    }

    private void EnsureMutable()
    {
        if (_committing) throw new InvalidOperationException("Checkout batch is committing.");
        if (_uncertainOperationId is not null)
            throw new InvalidOperationException("Checkout outcome unknown; reconcile before modifying batch.");
    }
    private static void EnsureQuantity(int quantity)
    {
        if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
    }
    private sealed record PendingLine(ArticleCandidate Candidate, string? Barcode,
        int Quantity, bool IsImage, bool WasDuplicate);
}
