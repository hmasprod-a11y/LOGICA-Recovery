using System;
using System.Collections.Generic;
using System.Linq;
using Hanouty.ArchitectureBridge;
using Wpf = Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.WpfContractAdapter;

// Exact adapter for the existing WPF ReadProducts() contract; never reads SQL.
// The authoritative variant identity stays in the Application session and is
// not inferred from the WPF display DTO (which currently lacks VariantId).
public sealed class ProductionWpfCatalogueReader : Wpf.ICatalogueReader
{
    private readonly CheckoutSession _session;
    public ProductionWpfCatalogueReader(CheckoutSession session) =>
        _session = session ?? throw new ArgumentNullException(nameof(session));

    public IReadOnlyList<Wpf.ProductSummary> ReadProducts()
    {
        _session.RefreshCatalogue();
        var source = _session.Products;
        if (source.Any(p => string.IsNullOrWhiteSpace(p.ArticleId)) ||
            source.GroupBy(p => p.ArticleId, StringComparer.OrdinalIgnoreCase).Any(g => g.Count() > 1))
            throw new InvalidOperationException("Catalogue contains invalid or duplicate WPF article identities.");
        return source.Select(p => new Wpf.ProductSummary(
            p.ArticleId, p.DisplayName, p.Barcode, p.ImagePath)).ToArray();
    }
}

// A WPF selection is staged, NOT posted. Actual sale/payment/return commands
// must explicitly call CheckoutSession.Submit with a stable operation ID.
public sealed class ProductionWpfProductSelection : Wpf.IProductSelection
{
    private readonly CheckoutSession _session;
    public ProductionWpfProductSelection(CheckoutSession session) =>
        _session = session ?? throw new ArgumentNullException(nameof(session));

    public bool Select(Wpf.ProductSummary product)
    {
        ArgumentNullException.ThrowIfNull(product);
        var matches = _session.Products.Where(p =>
            string.Equals(p.ArticleId, product.Id, StringComparison.OrdinalIgnoreCase)).ToArray();
        if (matches.Length != 1) return false;
        var current = matches[0];
        if (current is null ||
            !string.Equals(current.ArticleId, product.Id, StringComparison.Ordinal)) return false;
        if (!string.Equals(current.Barcode, product.Barcode, StringComparison.Ordinal) ||
            !string.Equals(current.DisplayName, product.Name, StringComparison.Ordinal) ||
            !string.Equals(current.ImagePath, product.ImagePath, StringComparison.Ordinal))
            return false;
        // An explicitly clicked tile carries a stable article ID. Duplicate
        // barcodes MUST preserve that identity even when the tile has a photo;
        // a barcode scan alone cannot silently choose a variant.
        if (string.IsNullOrWhiteSpace(current.Barcode))
            return _session.SelectArticle(current).Outcome == SelectionOutcome.Selected;
        var matching = _session.Products.Count(p =>
            string.Equals(p.Barcode, current.Barcode, StringComparison.Ordinal));
        if (matching > 1)
            return _session.SelectVariant(current).Outcome == SelectionOutcome.Selected;
        if (matching != 1) return false;
        if (current.HasImage)
            return _session.SelectImage(current).Outcome == SelectionOutcome.Selected;
        return _session.Scan(current.Barcode).Outcome == SelectionOutcome.Selected;
    }
}

// Application-owned submission adapter: WPF only supplies the stable operation ID.
// No financial posting is authorized by this adapter without a configured
// IAtomicCheckoutBatchPort and durable operation journal in CheckoutComposition.
public sealed class ProductionWpfCheckoutSubmission : Wpf.ICheckoutSubmission
{
    private readonly CheckoutSession _session;
    public ProductionWpfCheckoutSubmission(CheckoutSession session) =>
        _session = session ?? throw new ArgumentNullException(nameof(session));

    public Wpf.CheckoutSubmissionResult Submit(string stableOperationId)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId))
            throw new ArgumentException("Stable operation ID required.", nameof(stableOperationId));
        return _session.Submit(stableOperationId) switch
        {
            CheckoutBatchStatus.Committed => Wpf.CheckoutSubmissionResult.Committed,
            CheckoutBatchStatus.Empty => Wpf.CheckoutSubmissionResult.Empty,
            CheckoutBatchStatus.Invalidated => Wpf.CheckoutSubmissionResult.Invalidated,
            _ => Wpf.CheckoutSubmissionResult.Unknown
        };
    }
}

public sealed record WpfProductionBinding(CheckoutSession Session,
    Wpf.ICatalogueReader Catalogue, Wpf.IProductSelection Checkout,
    Wpf.ICheckoutSubmission Submission);

public static class ProductionWpfServices
{
    // Explicit payment-enabled composition. The host supplies Inventory's real
    // catalogue, Checkout's MariaDbCashCheckoutServices posting/journal and
    // authenticated cashier/tender context; this never runs on product selection.
    public static WpfProductionBinding CreateFinancial(
        ICatalogueReader catalogue, ICheckoutVariantPrompt variants,
        IAuthorizedCheckoutPort posting, ICheckoutOperationJournal journal,
        Func<AuthorizedCheckoutPaymentContext> paymentContext)
    {
        ArgumentNullException.ThrowIfNull(posting);
        ArgumentNullException.ThrowIfNull(journal);
        var gate = new AuthorizedCheckoutCommitGate(posting, journal);
        var financialBatch = new AuthorizedCheckoutBatchAdapter(gate, paymentContext);
        return Create(new CheckoutComposition(catalogue, variants, financialBatch, journal));
    }

    // Host invokes this at App.ResolveServices using concrete Inventory,
    // Checkout and cashier variant-prompt adapters. No empty fallback.
    public static WpfProductionBinding Create(CheckoutComposition composition)
    {
        ArgumentNullException.ThrowIfNull(composition);
        var session = composition.CreateSession();
        return new WpfProductionBinding(session,
            new ProductionWpfCatalogueReader(session),
            new ProductionWpfProductSelection(session),
            new ProductionWpfCheckoutSubmission(session));
    }
}
