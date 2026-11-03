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
var vm = new CatalogueViewModel(new Reader(items), selection);
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
Check(vm.ScanFeedback == "Invalid product identity" && selection.Selected.Count == 2, "missing article ID must never post");
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
