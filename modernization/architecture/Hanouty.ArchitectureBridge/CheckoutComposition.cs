using System;
using System.Collections.Generic;
using System.Linq;

namespace Hanouty.ArchitectureBridge;

// Shared Application-facing read contract; implemented by Inventory's local MariaDB
// infrastructure, not by a ViewModel or a second SQL implementation here.
public sealed record ProductSummary(
    string ArticleId, string Barcode, string DisplayName,
    string? ImagePath, string? VariantId = null)
{
    public bool HasImage => !string.IsNullOrWhiteSpace(ImagePath);
}

public interface ICatalogueReader
{
    IReadOnlyList<ProductSummary> ListAll();
    IReadOnlyList<ProductSummary> FindBarcode(string barcode);
    IReadOnlyList<ProductSummary> RefreshBarcode(string barcode);
    IReadOnlyList<ProductSummary> RefreshArticle(string articleId);
}

public interface ICheckoutOperationJournal
{
    // Unknown is NOT absent. Never allow a new write on an unknown outcome.
    CheckoutOperationOutcome Lookup(string operationId);
}
public enum CheckoutOperationOutcome { Unknown, Persisted, Absent }

// No implicit demo fallback. The host must explicitly supply all production
// dependencies; these are the seams for Inventory, Checkout and WPF owners.
public sealed class CheckoutComposition
{
    private readonly ICatalogueReader _reader;
    private readonly ICheckoutVariantPrompt _variantPrompt;
    private readonly IAtomicCheckoutBatchPort _cart;
    private readonly ICheckoutOperationJournal _journal;

    public CheckoutComposition(ICatalogueReader reader, ICheckoutVariantPrompt variantPrompt,
        IAtomicCheckoutBatchPort cart, ICheckoutOperationJournal journal)
    {
        _reader = reader ?? throw new ArgumentNullException(nameof(reader));
        _variantPrompt = variantPrompt ?? throw new ArgumentNullException(nameof(variantPrompt));
        _cart = cart ?? throw new ArgumentNullException(nameof(cart));
        _journal = journal ?? throw new ArgumentNullException(nameof(journal));
    }

    public IReadOnlyList<ProductSummary> AllProducts() => Validate(_reader.ListAll());
    public IReadOnlyList<ProductSummary> ImageProducts() =>
        AllProducts().Where(p => p.HasImage).ToArray();

    public CheckoutBatchController CreateCheckoutBatch() =>
        new(new CatalogueSelectionAdapter(_reader), _variantPrompt, _cart);

    public CheckoutOperationOutcome Reconcile(CheckoutBatchController batch)
    {
        ArgumentNullException.ThrowIfNull(batch);
        var id = batch.UncertainOperationId;
        if (id is null) throw new InvalidOperationException("No uncertain checkout operation.");
        var outcome = _journal.Lookup(id);
        if (outcome == CheckoutOperationOutcome.Unknown) return outcome;
        batch.ReconcileUnknownOutcome(id, outcome == CheckoutOperationOutcome.Persisted);
        return outcome;
    }

    private static IReadOnlyList<ProductSummary> Validate(IReadOnlyList<ProductSummary> products)
    {
        ArgumentNullException.ThrowIfNull(products);
        var ids = new HashSet<string>(StringComparer.Ordinal);
        foreach (var product in products)
        {
            if (product is null || string.IsNullOrWhiteSpace(product.ArticleId))
                throw new InvalidOperationException("Catalogue returned a product without stable identity.");
            if (!ids.Add(product.ArticleId))
                throw new InvalidOperationException("Catalogue returned duplicate article identity.");
        }
        return products.ToArray();
    }

    private sealed class CatalogueSelectionAdapter : ICheckoutSelectionCatalogue
    {
        private readonly ICatalogueReader _source;
        public CatalogueSelectionAdapter(ICatalogueReader source) => _source = source;
        public IReadOnlyList<ArticleCandidate> FindBarcode(string barcode) =>
            Convert(_source.FindBarcode(barcode));
        public IReadOnlyList<ArticleCandidate> RefreshBarcode(string barcode) =>
            Convert(_source.RefreshBarcode(barcode));
        public IReadOnlyList<ArticleCandidate> RefreshArticle(string articleId) =>
            Convert(_source.RefreshArticle(articleId));

        private static IReadOnlyList<ArticleCandidate> Convert(IReadOnlyList<ProductSummary> products)
        {
            ArgumentNullException.ThrowIfNull(products);
            return products.Select(p => p is not null && !string.IsNullOrWhiteSpace(p.ArticleId)
                ? new ArticleCandidate(p.ArticleId, p.Barcode ?? "")
                : throw new InvalidOperationException("Invalid catalogue identity.")).ToArray();
        }
    }
}
