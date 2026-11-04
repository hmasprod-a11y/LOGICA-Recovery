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
    private IReadOnlyList<ProductSummary> _all;
    private readonly ICatalogueReader _reader;
    private bool _catalogueAvailable;
    public bool CatalogueAvailable { get => _catalogueAvailable; private set { _catalogueAvailable = value; OnPropertyChanged(); } }
    private string _searchText = "";
    private ProductSummary? _selectedProduct;
    private string _scannerText = "";
    private string _scanFeedback = "";
    private readonly IProductSelection _selection;
    private readonly IProductImageAvailability _images;

    public CatalogueViewModel(ICatalogueReader reader, IProductSelection? selection = null, IProductImageAvailability? images = null)
    {
        ArgumentNullException.ThrowIfNull(reader);
        _reader = reader;
        _all = Array.Empty<ProductSummary>();
        _selection = selection ?? new PreviewProductSelection();
        _images = images ?? new LocalProductImageAvailability();
        ScanCommand = new DelegateCommand(_ => ScanBarcode());
        SelectCommand = new DelegateCommand(_ => SelectCurrent());
        ReloadCommand = new DelegateCommand(_ => ReloadCatalogue());
        PhotoProducts = new ObservableCollection<ProductSummary>(_all.Where(HasPhoto));
        VisibleProducts = new ObservableCollection<ProductSummary>(_all);
        ReloadCatalogue();
    }

    public ObservableCollection<ProductSummary> VisibleProducts { get; }
    public ObservableCollection<ProductSummary> PhotoProducts { get; }
    public System.Windows.Input.ICommand ScanCommand { get; }
    public System.Windows.Input.ICommand SelectCommand { get; }
    public System.Windows.Input.ICommand ReloadCommand { get; }
    public string ScannerText { get => _scannerText; set { _scannerText = value ?? ""; OnPropertyChanged(); } }
    public string ScanFeedback { get => _scanFeedback; private set { _scanFeedback = value; OnPropertyChanged(); } }
    private bool _isRightToLeft;
    public bool IsRightToLeft
    {
        get => _isRightToLeft;
        set { if (_isRightToLeft == value) return; _isRightToLeft = value; OnPropertyChanged(); OnPropertyChanged(nameof(LayoutDirection)); }
    }
    public System.Windows.FlowDirection LayoutDirection => IsRightToLeft ? System.Windows.FlowDirection.RightToLeft : System.Windows.FlowDirection.LeftToRight;
    public IReadOnlyList<ProductSummary> BarcodeCandidates { get; private set; } = Array.Empty<ProductSummary>();

    public void ReloadCatalogue()
    {
        // A failed local read must never leave a stale product available for sale.
        IReadOnlyList<ProductSummary> loaded;
        try { loaded = _reader.ReadProducts() ?? Array.Empty<ProductSummary>(); }
        catch (Exception ex) when (ex is System.IO.IOException or UnauthorizedAccessException or InvalidOperationException)
        {
            _all = Array.Empty<ProductSummary>();
            CatalogueAvailable = false;
            SelectedProduct = null;
            ScannerText = "";
            Refresh();
            ScanFeedback = "Local catalogue unavailable";
            return;
        }
        _all = loaded.Where(p => p is not null && !string.IsNullOrWhiteSpace(p.Id)).ToArray();
        CatalogueAvailable = true;
        SelectedProduct = null;
        ScannerText = "";
        Refresh();
        ScanFeedback = _all.Count == 0 ? "No products loaded" : "Catalogue ready";
    }

    public void ScanBarcode()
    {
        var code = ScannerText.Trim();
        if (code.Length == 0) { BarcodeCandidates = Array.Empty<ProductSummary>(); SelectedProduct = null; OnPropertyChanged(nameof(BarcodeCandidates)); ScanFeedback = "Empty barcode"; return; }
        var matches = _all.Where(p => string.Equals(p.Barcode, code, StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(p.Barcode)).ToArray();
        BarcodeCandidates = matches;
        OnPropertyChanged(nameof(BarcodeCandidates));
        if (matches.Length != 1)
        {
            SelectedProduct = null;
            ScanFeedback = matches.Length == 0 ? "Product not found" : "Ambiguous barcode";
            return;
        }
        SelectedProduct = matches[0];
        SelectCurrent();
        ScannerText = "";
    }

    public void SelectCurrent()
    {
        if (SelectedProduct is null) { ScanFeedback = "No product selected"; return; }
        // A candidate must belong to the current snapshot, not merely share its value.
        // This prevents stale UI objects from being sent to the checkout boundary.
        if (!CatalogueAvailable || !_all.Any(p => ReferenceEquals(p, SelectedProduct))) { ScanFeedback = "Product no longer in catalogue"; SelectedProduct = null; return; }
        if (string.IsNullOrWhiteSpace(SelectedProduct.Id)) { ScanFeedback = "Invalid product identity"; return; }
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

    private bool HasPhoto(ProductSummary product) => !string.IsNullOrWhiteSpace(product.ImagePath) && _images.Exists(product.ImagePath);

    private void Refresh()
    {
        var term = SearchText ?? "";
        var matches = _all.Where(p => (p.Name ?? "").Contains(term, StringComparison.OrdinalIgnoreCase)
            || (p.Barcode ?? "").Contains(term, StringComparison.OrdinalIgnoreCase)).ToArray();
        VisibleProducts.Clear();
        foreach (var product in matches) VisibleProducts.Add(product);
        PhotoProducts.Clear();
        foreach (var product in matches.Where(HasPhoto)) PhotoProducts.Add(product);
        if (SelectedProduct is not null && !matches.Any(p => ReferenceEquals(p, SelectedProduct))) SelectedProduct = null;
        BarcodeCandidates = Array.Empty<ProductSummary>();
        OnPropertyChanged(nameof(BarcodeCandidates));
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

// The view-model does not load or decode images. An image tile is only shown
// when the resolved local file exists; barcode-free products remain eligible.
public interface IProductImageAvailability
{
    bool Exists(string path);
}

public sealed class LocalProductImageAvailability : IProductImageAvailability
{
    public bool Exists(string path)
    {
        if (string.IsNullOrWhiteSpace(path)) return false;
        try { return System.IO.File.Exists(path); }
        catch (ArgumentException) { return false; }
        catch (System.IO.IOException) { return false; }
        catch (UnauthorizedAccessException) { return false; }
        catch (NotSupportedException) { return false; }
    }
}
