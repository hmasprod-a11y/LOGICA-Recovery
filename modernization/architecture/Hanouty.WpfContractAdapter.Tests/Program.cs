using Hanouty.ArchitectureBridge;
using Hanouty.WpfContractAdapter;
using Wpf = Hanouty.Desktop.Wpf.Presentation;

var reader = new TestCatalogue();
var port = new TestPort();
var binding = ProductionWpfServices.Create(new CheckoutComposition(
    reader, new TestPrompt(), port, new TestJournal()));
var products = binding.Catalogue.ReadProducts();
Check(products.Count == 3 && products[0].Id == "a" && products[1].Id == "b",
    "all products mapped to existing WPF ReadProducts");
Check(products[0].Name == "Apple" && products[0].ImagePath is null,
    "display name and missing image mapped");
Check(!binding.Checkout.Select(products[0]), "ambiguous barcode cannot silently choose first variant");
Check(binding.Checkout.Select(products[2]), "barcode-free photo product stages");
Check(binding.Session.PendingCount == 1, "WPF selection stages without posting");
Check(port.Writes == 0, "WPF selection must not write a sale");
Check(!binding.Checkout.Select(new Wpf.ProductSummary("c", "Photo", "", "forged.png")),
    "forged photo is rejected");
Check(binding.Session.Submit("wpf-adapter-001") == CheckoutBatchStatus.Committed &&
    port.Writes == 1 && port.Lines!.Single() == new CheckoutBatchLine("c", 1),
    "explicit stable-ID submission posts one validated atomic batch");
reader.ChangeVariant = true;
var fresh = binding.Catalogue.ReadProducts();
Check(!binding.Checkout.Select(fresh[2]), "changed variant cannot be staged from stale WPF DTO");
Console.WriteLine("WPF adapter integration contract regression passed.");
static void Check(bool ok, string reason) { if (!ok) throw new Exception(reason); }

sealed class TestCatalogue : ICatalogueReader
{
    public bool ChangeVariant { get; set; }
    public IReadOnlyList<ProductSummary> ListAll() => new[] {
        new ProductSummary("a", "111", "Apple", null, "v1"),
        new ProductSummary("b", "111", "Apple variant", null, "v2"),
        new ProductSummary("c", "", "Photo", "photo.png", ChangeVariant ? "v2" : "v1")
    };
    public IReadOnlyList<ProductSummary> FindBarcode(string barcode) => ListAll().Where(x => x.Barcode == barcode).ToArray();
    public IReadOnlyList<ProductSummary> RefreshBarcode(string barcode) => FindBarcode(barcode);
    public IReadOnlyList<ProductSummary> RefreshArticle(string id) => ListAll().Where(x => x.ArticleId == id).ToArray();
}
sealed class TestPrompt : ICheckoutVariantPrompt
{
    public int Choose(IReadOnlyList<ArticleCandidate> items) => 0;
}
sealed class TestPort : IAtomicCheckoutBatchPort
{
    public int Writes { get; private set; }
    public IReadOnlyList<CheckoutBatchLine>? Lines { get; private set; }
    public void AddBatch(IReadOnlyList<CheckoutBatchLine> lines, string operationId) { Writes++; Lines = lines; }
}
sealed class TestJournal : ICheckoutOperationJournal
{
    public CheckoutOperationOutcome Lookup(string operationId) => CheckoutOperationOutcome.Absent;
}
