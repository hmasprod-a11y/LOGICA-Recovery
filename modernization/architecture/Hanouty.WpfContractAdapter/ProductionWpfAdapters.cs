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
        return _session.Products.Select(p => new Wpf.ProductSummary(
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
        var current = _session.Products.SingleOrDefault(p =>
            string.Equals(p.ArticleId, product.Id, StringComparison.Ordinal));
        if (current is null ||
            !string.Equals(current.Barcode, product.Barcode, StringComparison.Ordinal) ||
            !string.Equals(current.DisplayName, product.Name, StringComparison.Ordinal) ||
            !string.Equals(current.ImagePath, product.ImagePath, StringComparison.Ordinal))
            return false;
        if (current.HasImage)
            return _session.SelectImage(current).Outcome == SelectionOutcome.Selected;
        if (string.IsNullOrWhiteSpace(current.Barcode)) return false;
        // WPF's present selection API has no explicit duplicate-barcode variant
        // command; don't silently select the first duplicate.
        var matching = _session.Products.Count(p =>
            string.Equals(p.Barcode, current.Barcode, StringComparison.Ordinal));
        if (matching != 1) return false;
        return _session.Scan(current.Barcode).Outcome == SelectionOutcome.Selected;
    }
}

public sealed record WpfProductionBinding(CheckoutSession Session,\n    Wpf.ICatalogueReader Catalogue, Wpf.IProductSelection Checkout);\n\npublic static class ProductionWpfServices
{
    // Host invokes this at App.ResolveServices using concrete Inventory,
    // Checkout and cashier variant-prompt adapters. No empty fallback.
    public static (Wpf.ICatalogueReader Catalogue, Wpf.IProductSelection Checkout)
        Create(CheckoutComposition composition)
    {
        ArgumentNullException.ThrowIfNull(composition);
        var session = composition.CreateSession();
        return (new ProductionWpfCatalogueReader(session),
                new ProductionWpfProductSelection(session));
    }
}
