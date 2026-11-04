using Hanouty.Desktop.Wpf.Presentation;

static void Check(bool value, string reason)
{
    if (!value) throw new Exception(reason);
}
var items = new[]
{
    new ProductSummary("1", "Milk", "123", "milk.png"),
    new ProductSummary("2", "Bread", "", null),
    new ProductSummary("3", "Milk Chocolate", "456", null),
    new ProductSummary("4", "Duplicate A", "777", "a.png"),
    new ProductSummary("5", "Duplicate B", "777", null)
};
var selection = new RecordingSelection();
var vm = new CatalogueViewModel(new Reader(items), selection, new ImageFixture());
Check(vm.VisibleProducts.Count == 5, "all catalogue products must appear, including barcode-free");
Check(vm.PhotoProducts.Count == 2, "only image-backed products in photo list");
vm.SearchText = "milk";
Check(vm.VisibleProducts.Count == 2 && vm.PhotoProducts.Count == 1, "search must preserve photo subset");
vm.SearchText = "";
vm.ScannerText = "123";
vm.ScanCommand.Execute(null);
Check(vm.SelectedProduct?.Id == "1" && selection.Selected.Count == 1, "scanner Enter dispatches selected product");
Check(vm.ScannerText == "", "successful scan clears scanner input");
vm.ScannerText = "777";
vm.ScanBarcode();
Check(vm.ScanFeedback == "Ambiguous barcode" && selection.Selected.Count == 1 && vm.BarcodeCandidates.Count == 2 && vm.SelectedProduct is null, "duplicate barcode must expose candidates and not select silently");
vm.ScannerText = "not-found";
vm.ScanBarcode();
Check(vm.ScanFeedback == "Product not found" && selection.Selected.Count == 1, "unknown barcode must not post");
vm.SelectedProduct = items[1];
vm.SelectCommand.Execute(null);
Check(selection.Selected.Last().Id == "2", "barcode-free product selectable by UI");
vm.SelectedProduct = new ProductSummary("", "Bad identity", "x");
vm.SelectCommand.Execute(null);
Check(vm.ScanFeedback == "Product no longer in catalogue" && selection.Selected.Count == 2, "missing article ID must never post");
int rtlNotifications = 0;
vm.PropertyChanged += (_, args) => { if (args.PropertyName == nameof(vm.IsRightToLeft)) rtlNotifications++; };
vm.IsRightToLeft = true;
Check(rtlNotifications == 1, "RTL changes notify WPF binding");
var offline = new CatalogueViewModel(new EmptyCatalogueReader());
Check(offline.VisibleProducts.Count == 0, "offline startup does not invent products");
offline.ScannerText = "123";
offline.ScanBarcode();
Check(offline.ScanFeedback == "Product not found", "offline scan fails closed");
vm.SearchText = "Milk";
Check(vm.SelectedProduct is null, "filter clears stale selection");
var preview = new CatalogueViewModel(new Reader(items));
preview.ScannerText = "456";
preview.ScanBarcode();
Check(preview.ScanFeedback == "Checkout unavailable in preview", "default host must fail closed");
Check(vm.LayoutDirection == System.Windows.FlowDirection.RightToLeft, "RTL must change actual WPF layout direction");
vm.IsRightToLeft = false;
Check(vm.LayoutDirection == System.Windows.FlowDirection.LeftToRight, "LTR must restore actual WPF layout direction");
vm.ScannerText = "";
vm.ScanBarcode();
Check(vm.BarcodeCandidates.Count == 0, "empty scanner input must clear stale barcode candidates");
vm.SearchText = "";
vm.ScannerText = "777";
vm.ScanBarcode();
vm.SelectedProduct = vm.BarcodeCandidates[1];
vm.SelectCommand.Execute(null);
Check(selection.Selected.Last().Id == "5", "explicit ambiguous barcode candidate must dispatch selected article");
var changing = new ChangingReader(items);
var reloaded = new CatalogueViewModel(changing, new RecordingSelection());
reloaded.SelectedProduct = items[0];
reloaded.ScannerText = "123";
changing.Products = new[] { items[1] };
reloaded.ReloadCommand.Execute(null);
Check(reloaded.VisibleProducts.Count == 1 && reloaded.SelectedProduct is null && reloaded.ScannerText == "", "reload must replace catalogue and discard stale selection/scanner");
reloaded.SelectedProduct = items[0];
reloaded.SelectCurrent();
Check(reloaded.ScanFeedback == "Product no longer in catalogue", "stale product cannot dispatch");
changing.Fail = true;
reloaded.ReloadCatalogue();
Check(!reloaded.CatalogueAvailable && reloaded.VisibleProducts.Count == 0 && reloaded.PhotoProducts.Count == 0 && reloaded.SelectedProduct is null, "failed local read clears all sale-facing state");
reloaded.ScannerText = "123";
reloaded.ScanBarcode();
Check(reloaded.ScanFeedback == "Product not found", "unavailable catalogue must not select");
changing.Fail = false;
changing.Products = items;
reloaded.ReloadCatalogue();
Check(reloaded.CatalogueAvailable && reloaded.VisibleProducts.Count == items.Length, "recovered local read restores all products");
reloaded.SelectedProduct = items[0];
reloaded.ScannerText = "";
reloaded.ScanBarcode();
Check(reloaded.SelectedProduct is null && reloaded.BarcodeCandidates.Count == 0, "empty scan clears previous selection");
// A reconstructed object with identical values is not the loaded catalogue row.
// Only an object from the active snapshot may cross the selection port.
vm.SearchText = "";
vm.SelectedProduct = items[0] with { };
var beforeStale = selection.Selected.Count;
vm.SelectCurrent();
Check(vm.ScanFeedback == "Product no longer in catalogue" && selection.Selected.Count == beforeStale,
    "value-equal stale article must not be sent to checkout");
var legacyNulls = new[] { new ProductSummary("N", null!, null!, null) };
var nullVm = new CatalogueViewModel(new Reader(legacyNulls), new RecordingSelection());
nullVm.SearchText = "anything";
Check(nullVm.VisibleProducts.Count == 0, "legacy null name/barcode must not crash catalogue search");
nullVm.SearchText = "";
Check(nullVm.VisibleProducts.Count == 1, "legacy nullable article stays visible in full catalogue");
Console.WriteLine("PASS: WPF MVVM catalogue, image, scanner, duplicate, selection and fail-closed regression");

sealed class Reader(IReadOnlyList<ProductSummary> products) : ICatalogueReader
{
    public IReadOnlyList<ProductSummary> ReadProducts() => products;
}
sealed class RecordingSelection : IProductSelection
{
    public List<ProductSummary> Selected { get; } = new();
    public bool Select(ProductSummary product) { Selected.Add(product); return true; }
}

sealed class ChangingReader(ProductSummary[] products) : ICatalogueReader
{
    public ProductSummary[] Products { get; set; } = products;
    public bool Fail { get; set; }
    public IReadOnlyList<ProductSummary> ReadProducts() => Fail ? throw new InvalidOperationException("offline") : Products;
}

sealed class ImageFixture : IProductImageAvailability
{
    public bool Exists(string path) => path is "milk.png" or "a.png";
}
