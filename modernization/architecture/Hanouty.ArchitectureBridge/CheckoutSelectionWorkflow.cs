using System;
using System.Collections.Generic;

namespace Hanouty.ArchitectureBridge;

// Application-facing executable selection -> cart boundary. The selection gateway
// invokes recovered production selection rules; only validated article IDs cross
// into the checkout port. This is not a pricing, persistence, or UI implementation.
public interface ICheckoutArticlePort
{
    void AddSelectedArticle(string articleId, int quantity);
}

public sealed class CheckoutSelectionWorkflow
{
    private readonly ICheckoutArticlePort _checkout;
    public CheckoutSelectionWorkflow(ICheckoutArticlePort checkout)
        => _checkout = checkout ?? throw new ArgumentNullException(nameof(checkout));

    public SelectionResponse AddBarcode(
        IReadOnlyList<ArticleCandidate> displayed,
        Func<IReadOnlyList<ArticleCandidate>, int>? chooseVariant,
        Func<IReadOnlyList<ArticleCandidate>> refresh,
        int quantity = 1)
    {
        EnsureQuantity(quantity);
        var selection = CheckoutSelectionGateway.ResolveBarcode(displayed, chooseVariant, refresh);
        Dispatch(selection, quantity);
        return selection;
    }

    public SelectionResponse AddImage(
        ArticleCandidate tile,
        Func<IReadOnlyList<ArticleCandidate>> refreshByArticleId,
        int quantity = 1)
    {
        EnsureQuantity(quantity);
        var selection = CheckoutSelectionGateway.ResolveImage(tile, refreshByArticleId);
        Dispatch(selection, quantity);
        return selection;
    }

    private void Dispatch(SelectionResponse selection, int quantity)
    {
        if (selection.Outcome != SelectionOutcome.Selected)
            return;
        var id = selection.Article?.ArticleId;
        if (string.IsNullOrWhiteSpace(id))
            throw new InvalidOperationException("Selected article must have a stable identity.");
        _checkout.AddSelectedArticle(id, quantity);
    }

    private static void EnsureQuantity(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be positive.");
    }
}
