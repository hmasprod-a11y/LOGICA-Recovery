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
Check(binding.Checkout.Select(products[1]), "explicit WPF variant choice stages exact article identity");
Check(!binding.Checkout.Select(new Wpf.ProductSummary("b", "Forged", "111")),
    "forged duplicate barcode candidate rejected");
Check(binding.Checkout.Select(products[2]), "barcode-free photo product stages");
Check(binding.Session.PendingCount == 2, "explicit variant and photo stage without posting");
Check(port.Writes == 0, "WPF selection must not write a sale");
Check(!binding.Checkout.Select(new Wpf.ProductSummary("c", "Photo", "", "forged.png")),
    "forged photo is rejected");
Check(binding.Session.Submit("wpf-adapter-001") == CheckoutBatchStatus.Committed &&
    port.Writes == 1 && port.Lines!.Count == 2 &&
    port.Lines[0] == new CheckoutBatchLine("b", 1) &&
    port.Lines[1] == new CheckoutBatchLine("c", 1),
    "explicit stable-ID submission posts one validated atomic batch");
reader.ChangeVariant = true;
Check(!binding.Checkout.Select(products[2]), "changed variant cannot be staged from stale WPF DTO");
var changingReader = new TestCatalogue();
var changingPort = new TestPort();
var changing = ProductionWpfServices.Create(new CheckoutComposition(
    changingReader, new TestPrompt(), changingPort, new TestJournal()));
var changingProducts = changing.Catalogue.ReadProducts();
Check(changing.Checkout.Select(changingProducts[1]), "variant staged before inventory update");
changingReader.ChangeVariantB = true;
Check(changing.Session.Submit("changed-variant-001") == CheckoutBatchStatus.Invalidated &&
    changingPort.Writes == 0, "changed duplicate variant invalidates entire batch before write");
changing.Session.DiscardInvalidated();
Check(changing.Session.PendingCount == 0, "explicit discard clears invalidated variant");
var barcodeReader = new TestCatalogue();
var barcodePort = new TestPort();
var barcodeBinding = ProductionWpfServices.Create(new CheckoutComposition(
    barcodeReader, new TestPrompt(), barcodePort, new TestJournal()));
var barcodeProducts = barcodeBinding.Catalogue.ReadProducts();
Check(barcodeBinding.Checkout.Select(barcodeProducts[1]), "explicit variant accepted before barcode change");
barcodeReader.ChangeBarcodeB = true;
Check(barcodeBinding.Session.Submit("barcode-change-001") == CheckoutBatchStatus.Invalidated &&
    barcodePort.Writes == 0, "changed barcode blocks explicit variant atomic write");
barcodeBinding.Session.DiscardInvalidated();
Check(!barcodeBinding.Checkout.Select(barcodeProducts[1]), "stale variant barcode refused at selection");
var duplicateReader = new TestCatalogue();
var duplicatePort = new TestPort();
var duplicate = ProductionWpfServices.Create(new CheckoutComposition(
    duplicateReader, new TestPrompt(), duplicatePort, new TestJournal()));
var duplicateProducts = duplicate.Catalogue.ReadProducts();
Check(duplicate.Checkout.Select(duplicateProducts[1]), "explicit duplicate staged before competing barcode removed");
duplicateReader.RemoveCompetingBarcode = true;
Check(duplicate.Session.Submit("duplicate-removed-001") == CheckoutBatchStatus.Invalidated &&
    duplicatePort.Writes == 0, "disappearing competing barcode invalidates explicit variant before write");
duplicate.Session.DiscardInvalidated();
Check(!duplicate.Checkout.Select(duplicateProducts[1]),
    "stale WPF duplicate selection rejected when barcode becomes unique");
var directReader = new TestCatalogue();
var directBinding = ProductionWpfServices.Create(new CheckoutComposition(
    directReader, new TestPrompt(), new TestPort(), new TestJournal()));
var directProducts = directBinding.Catalogue.ReadProducts();
Check(directBinding.Session.SelectVariant(new ProductSummary("c", "", "Photo", "photo.png", "v1")).Outcome == SelectionOutcome.InvalidCandidates,
    "explicit variant API refuses barcode-free photo bypass");
Check(directBinding.Session.SelectVariant(new ProductSummary("b", "111", "Apple variant", null, "forged")).Outcome == SelectionOutcome.InvalidCandidates,
    "explicit variant API refuses forged variant identity");
reader.CaseCollision = true;
try { binding.Catalogue.ReadProducts(); throw new Exception("case collision accepted"); }
catch (InvalidOperationException ex) when (ex.Message.Contains("duplicate WPF article")) { }
Console.WriteLine("WPF adapter integration contract regression passed.");
static void Check(bool ok, string reason) { if (!ok) throw new Exception(reason); }

sealed class TestCatalogue : ICatalogueReader
{
    public bool ChangeVariant { get; set; }
    public bool ChangeVariantB { get; set; }
    public bool ChangeBarcodeB { get; set; }
    public bool CaseCollision { get; set; }
    public bool RemoveCompetingBarcode { get; set; }
    public IReadOnlyList<ProductSummary> ListAll() => new[] {
        new ProductSummary("a", RemoveCompetingBarcode ? "333" : "111", "Apple", null, "v1"),
        new ProductSummary(CaseCollision ? "A" : "b", ChangeBarcodeB ? "222" : "111", "Apple variant", null, ChangeVariantB ? "v3" : "v2"),
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
