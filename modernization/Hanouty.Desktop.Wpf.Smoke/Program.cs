using Hanouty.Desktop.Wpf.Presentation;

var products = new[]
{
    new ProductSummary("1", "No barcode photo", "", "exists.png"),
    new ProductSummary("2", "Missing image", "ABC", "missing.png"),
    new ProductSummary("3", "Shared A", "DUP"),
    new ProductSummary("4", "Shared B", "DUP"),
    new ProductSummary("5", "Ordinary", "SINGLE")
};
var reader = new StubReader(products);
var selection = new RecordingSelection();
var vm = new CatalogueViewModel(reader, selection, new StubImages());
Assert(vm.VisibleProducts.Count == 5, "full catalogue including barcode-free products");
Assert(vm.PhotoProducts.Count == 1 && vm.PhotoProducts[0].Id == "1", "photo file existence and barcode-free photo");
vm.SearchText = "DUP";
Assert(vm.VisibleProducts.Count == 2 && vm.PhotoProducts.Count == 0, "search and photo filter");
vm.SearchText = "";
vm.ScannerText = "DUP";
vm.ScanBarcode();
Assert(vm.BarcodeCandidates.Count == 2 && selection.Count == 0, "ambiguous barcode must not post selection");
vm.ScannerText = "SINGLE";
vm.ScanBarcode();
Assert(vm.SelectedProduct?.Id == "5" && selection.Count == 1, "scanner single match selection");
vm.IsRightToLeft = true;
Assert(vm.LayoutDirection == System.Windows.FlowDirection.RightToLeft, "RTL binding");
vm.IsRightToLeft = false;
Assert(vm.LayoutDirection == System.Windows.FlowDirection.LeftToRight, "LTR binding");
vm.ScannerText = "UNKNOWN";
vm.ScanBarcode();
Assert(vm.BarcodeCandidates.Count == 0 && selection.Count == 1, "unknown barcode cannot select");
Console.WriteLine("PASS: WPF catalogue, photo, barcode, selection and RTL smoke");

static void Assert(bool condition, string label)
{
    if (!condition) throw new Exception("FAIL: " + label);
}
sealed class StubReader(ProductSummary[] products) : ICatalogueReader
{
    public IReadOnlyList<ProductSummary> ReadProducts() => products;
}
sealed class StubImages : IProductImageAvailability
{
    public bool Exists(string path) => path == "exists.png";
}
sealed class RecordingSelection : IProductSelection
{
    public int Count { get; private set; }
    public bool Select(ProductSummary product) { Count++; return true; }
}
