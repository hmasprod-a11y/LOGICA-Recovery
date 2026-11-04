using System;
using System.Collections.Generic;

namespace Hanouty.ArchitectureBridge;

// Application-level session consumed by a WPF ViewModel. It uses the EXISTING
// approved composition/ports and does not perform SQL or price arithmetic.
// The host owns the durable operation ID and must preserve it across timeouts.
public sealed class CheckoutSession
{
    private readonly CheckoutComposition _composition;
    private readonly CheckoutBatchController _batch;
    private string? _operationId;

    internal CheckoutSession(CheckoutComposition composition, CheckoutBatchController batch)
    {
        _composition = composition ?? throw new ArgumentNullException(nameof(composition));
        _batch = batch ?? throw new ArgumentNullException(nameof(batch));
    }

    public IReadOnlyList<ProductSummary> Products => _composition.AllProducts();
    public IReadOnlyList<ProductSummary> ImageProducts => _composition.ImageProducts();
    public int PendingCount => _batch.PendingCount;
    public CheckoutCommitState State => _batch.State;
    public string? OperationId => _operationId ?? _batch.UncertainOperationId;

    public SelectionResponse Scan(string barcode, int quantity = 1)
    {
        EnsureNoSubmission();
        return _batch.StageBarcode(barcode, quantity);
    }

    public SelectionResponse SelectImage(ProductSummary product, int quantity = 1)
    {
        EnsureNoSubmission();
        ArgumentNullException.ThrowIfNull(product);
        if (!product.HasImage)
            return new SelectionResponse(SelectionOutcome.InvalidCandidates, null);
        return _batch.StageImage(new ArticleCandidate(product.ArticleId, product.Barcode ?? ""), quantity);
    }

    public void Clear()
    {
        EnsureNoSubmission();
        _batch.Clear();
    }

    public CheckoutBatchStatus Submit(string operationId)
    {
        if (string.IsNullOrWhiteSpace(operationId))
            throw new ArgumentException("Stable operation ID required.", nameof(operationId));
        if (_operationId is not null && !string.Equals(_operationId, operationId, StringComparison.Ordinal))
            throw new InvalidOperationException("An existing operation must be reconciled before changing its ID.");
        if (_operationId is null) _operationId = operationId;
        var result = _batch.Commit(operationId);
        if (result == CheckoutBatchStatus.Committed || result == CheckoutBatchStatus.Empty)
            _operationId = null;
        // Invalidated retains operation ID until the operator clears/rebuilds.
        return result;
    }

    public CheckoutOperationOutcome Reconcile()
    {
        if (_batch.State != CheckoutCommitState.OutcomeUnknown)
            throw new InvalidOperationException("No uncertain checkout outcome.");
        var result = _composition.Reconcile(_batch);
        if (result != CheckoutOperationOutcome.Unknown) _operationId = null;
        return result;
    }

    public void DiscardInvalidated()
    {
        if (_batch.State != CheckoutCommitState.Ready)
            throw new InvalidOperationException("Cannot discard an uncertain operation.");
        _batch.Clear();
        _operationId = null;
    }

    private void EnsureNoSubmission()
    {
        if (_operationId is not null || _batch.State == CheckoutCommitState.OutcomeUnknown)
            throw new InvalidOperationException("Resolve the current checkout operation before editing.");
    }
}
