using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hanouty.Desktop.Wpf.Presentation;

public sealed record ProductSummary(string Id, string Name, string Barcode);

public interface ICatalogueReader
{
    IReadOnlyList<ProductSummary> ReadProducts();
}

// Fail-closed until the application-owned catalogue adapter is wired.
// No fake inventory, sample prices, shop database access or implicit sale posting.
public sealed class EmptyCatalogueReader : ICatalogueReader
{
    public IReadOnlyList<ProductSummary> ReadProducts() => Array.Empty<ProductSummary>();
}

public sealed class CatalogueViewModel : INotifyPropertyChanged
{
    private readonly IReadOnlyList<ProductSummary> _all;
    private string _searchText = "";
    private ProductSummary? _selectedProduct;

    public CatalogueViewModel(ICatalogueReader reader)
    {
        ArgumentNullException.ThrowIfNull(reader);
        _all = reader.ReadProducts() ?? throw new InvalidOperationException("Catalogue unavailable");
        VisibleProducts = new ObservableCollection<ProductSummary>(_all);
    }

    public ObservableCollection<ProductSummary> VisibleProducts { get; }

    public string SearchText
    {
        get => _searchText;
        set
        {
            if (_searchText == value) return;
            _searchText = value ?? "";
            OnPropertyChanged();
            Refresh();
        }
    }

    public ProductSummary? SelectedProduct
    {
        get => _selectedProduct;
        set
        {
            if (Equals(_selectedProduct, value)) return;
            _selectedProduct = value;
            OnPropertyChanged();
        }
    }

    private void Refresh()
    {
        var matches = _all.Where(p => p.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
            || p.Barcode.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).ToArray();
        VisibleProducts.Clear();
        foreach (var product in matches) VisibleProducts.Add(product);
        if (SelectedProduct is not null && !matches.Contains(SelectedProduct)) SelectedProduct = null;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
