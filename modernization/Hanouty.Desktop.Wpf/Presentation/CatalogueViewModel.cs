using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hanouty.Desktop.Wpf.Presentation;

public sealed record ProductSummary(string Id, string Name, string Barcode, string? ImagePath = null);

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
    private string _scannerText = "";
    private string _scanFeedback = "";
    private readonly IProductSelection _selection;

    public CatalogueViewModel(ICatalogueReader reader, IProductSelection? selection = null)
    {
        ArgumentNullException.ThrowIfNull(reader);
        _all = reader.ReadProducts() ?? throw new InvalidOperationException("Catalogue unavailable");
        _selection = selection ?? new PreviewProductSelection();
        ScanCommand = new DelegateCommand(_ => ScanBarcode());
        SelectCommand = new DelegateCommand(_ => SelectCurrent());
        PhotoProducts = new ObservableCollection<ProductSummary>(_all.Where(p => !string.IsNullOrWhiteSpace(p.ImagePath)));
        VisibleProducts = new ObservableCollection<ProductSummary>(_all);
    }

    public ObservableCollection<ProductSummary> VisibleProducts { get; }
    public ObservableCollection<ProductSummary> PhotoProducts { get; }
    public System.Windows.Input.ICommand ScanCommand { get; }
    public System.Windows.Input.ICommand SelectCommand { get; }
    public string ScannerText { get => _scannerText; set { _scannerText = value ?? ""; OnPropertyChanged(); } }
    public string ScanFeedback { get => _scanFeedback; private set { _scanFeedback = value; OnPropertyChanged(); } }
    public bool IsRightToLeft { get; set; }

    public void ScanBarcode()
    {
        var code = ScannerText.Trim();
        if (code.Length == 0) { ScanFeedback = "Empty barcode"; return; }
        var matches = _all.Where(p => string.Equals(p.Barcode, code, StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(p.Barcode)).ToArray();
        if (matches.Length != 1) { ScanFeedback = matches.Length == 0 ? "Product not found" : "Ambiguous barcode"; return; }
        SelectedProduct = matches[0];
        SelectCurrent();
        ScannerText = "";
    }

    public void SelectCurrent()
    {
        if (SelectedProduct is null) { ScanFeedback = "No product selected"; return; }
        // Preview port explicitly never posts a sale or updates stock.
        ScanFeedback = _selection.Select(SelectedProduct) ? "Selection accepted" : "Checkout unavailable in preview";
    }

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
        PhotoProducts.Clear();
        foreach (var product in matches.Where(p => !string.IsNullOrWhiteSpace(p.ImagePath))) PhotoProducts.Add(product);
        if (SelectedProduct is not null && !matches.Contains(SelectedProduct)) SelectedProduct = null;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

public interface IProductSelection
{
    // Selection only; checkout posting is owned by the Application team.
    bool Select(ProductSummary product);
}

public sealed class PreviewProductSelection : IProductSelection
{
    public bool Select(ProductSummary product) => false;
}

public sealed class DelegateCommand : System.Windows.Input.ICommand
{
    private readonly Action<object?> _action;
    public DelegateCommand(Action<object?> action) => _action = action;
    public bool CanExecute(object? parameter) => true;
    public void Execute(object? parameter) => _action(parameter);
    public event EventHandler? CanExecuteChanged { add { } remove { } }
}
