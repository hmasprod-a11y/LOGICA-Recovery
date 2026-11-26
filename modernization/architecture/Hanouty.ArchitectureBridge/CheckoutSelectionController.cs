using System;
using System.Collections.Generic;

namespace Hanouty.ArchitectureBridge;

// Host-facing application coordinator. The host supplies its real catalogue reader,
// variant dialog and cart port; the bridge never performs SQL or financial arithmetic.
public interface ICheckoutSelectionCatalogue
{
    IReadOnlyList<ArticleCandidate> FindBarcode(string barcode);
    IReadOnlyList<ArticleCandidate> RefreshBarcode(string barcode);
    IReadOnlyList<ArticleCandidate> RefreshArticle(string articleId);
}
public interface ICheckoutVariantPrompt
{
    // Return -1 for cancellation. The legacy selection service validates the index.
    int Choose(IReadOnlyList<ArticleCandidate> candidates);
}

public sealed class CheckoutSelectionController
{
    private readonly ICheckoutSelectionCatalogue _catalogue;
    private readonly ICheckoutVariantPrompt _prompt;
    private readonly CheckoutSelectionWorkflow _workflow;

    public CheckoutSelectionController(
        ICheckoutSelectionCatalogue catalogue,
        ICheckoutVariantPrompt prompt,
        ICheckoutArticlePort cart)
    {
        _catalogue = catalogue ?? throw new ArgumentNullException(nameof(catalogue));
        _prompt = prompt ?? throw new ArgumentNullException(nameof(prompt));
        _workflow = new CheckoutSelectionWorkflow(cart);
    }

    // The barcode must be captured once and reused for the live refresh; a changed
    // textbox cannot silently substitute a different article during selection.
    public SelectionResponse ScanBarcode(string barcode, int quantity = 1)
    {
        if (string.IsNullOrWhiteSpace(barcode))
            return new SelectionResponse(SelectionOutcome.Missing, null);
        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity));
        var captured = barcode;
        var displayed = _catalogue.FindBarcode(captured);
        return _workflow.AddBarcode(displayed, _prompt.Choose,
            () => _catalogue.RefreshBarcode(captured), quantity);
    }

    // The article identity comes from the selected tile, never its mutable index.
    // An image tile may have no barcode; the original selection rules check the ID.
    public SelectionResponse SelectImage(ArticleCandidate tile, int quantity = 1)
    {
        ArgumentNullException.ThrowIfNull(tile);
        if (string.IsNullOrWhiteSpace(tile.ArticleId))
            return new SelectionResponse(SelectionOutcome.InvalidCandidates, null);
        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity));
        var capturedId = tile.ArticleId;
        return _workflow.AddImage(tile, () => _catalogue.RefreshArticle(capturedId), quantity);
    }
}
