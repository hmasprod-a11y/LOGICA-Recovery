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
var offline = new CatalogueViewModel(new EmptyCatalogueReader(), new RecordingSelection());
Check(offline.VisibleProducts.Count == 0, "offline startup does not invent products");
offline.ScannerText = "123";
offline.ScanBarcode();
Check(offline.ScanFeedback == "Local catalogue unavailable", "offline scan fails closed with actionable unavailable status");
vm.SearchText = "Milk";
Check(vm.SelectedProduct is null, "filter clears stale selection");
var preview = new CatalogueViewModel(new Reader(items), new PreviewProductSelection());
preview.ScannerText = "456";
preview.ScanBarcode();
Check(preview.ScanFeedback == "Selection rejected" && preview.ScannerText == "456", "rejected selection retains scanner input");
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
Check(reloaded.ScanFeedback == "Local catalogue unavailable", "unavailable catalogue must not select");
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
Check(typeof(CatalogueViewModel).GetConstructors().All(ctor =>
    ctor.GetParameters().Any(p => p.ParameterType == typeof(IProductSelection) && !p.IsOptional)),
    "checkout selection dependency must be explicit for every viewmodel constructor");
Check(typeof(Hanouty.Desktop.Wpf.MainWindow).GetConstructors().All(ctor =>
    ctor.GetParameters().Any(p => p.ParameterType == typeof(IProductSelection))),
    "production WPF window must require checkout dependency");
// Value-equal stale objects must be rejected even when WPF SelectedItem changes.
var staleVm = new CatalogueViewModel(new Reader(items), new RecordingSelection());
staleVm.SelectedProduct = items[0];
staleVm.SelectedProduct = items[0] with { };
staleVm.SelectCurrent();
Check(staleVm.ScanFeedback == "Product no longer in catalogue",
    "WPF SelectedItem must retain new reference so stale object cannot dispatch");
var failingVm = new CatalogueViewModel(new Reader(items), new ThrowingSelection());
failingVm.SelectedProduct = items[0];
failingVm.SelectCurrent();
Check(failingVm.ScanFeedback == "Checkout status unknown — reconcile before retry",
    "unknown checkout result must never be reported as a successful selection");
var uncertainSelection = new CountingUncertainSelection();
var blockedVm = new CatalogueViewModel(new Reader(items), uncertainSelection);
blockedVm.ScannerText = "123";
blockedVm.ScanBarcode();
Check(blockedVm.CheckoutUncertain && uncertainSelection.Calls == 1,
    "uncertain acknowledgement must latch checkout safety state");
blockedVm.ScanBarcode();
blockedVm.SelectedProduct = items[1];
blockedVm.SelectCurrent();
blockedVm.ReloadCatalogue();
blockedVm.SelectedProduct = items[1];
blockedVm.SelectCurrent();
Check(uncertainSelection.Calls == 1 && blockedVm.CheckoutUncertain,
    "scanner, button and catalogue reload cannot replay uncertain operation");
var tileSelection = new RecordingSelection();
var tileVm = new CatalogueViewModel(new Reader(items), tileSelection, new ImageFixture());
Check(tileVm.PhotoProducts.Count == 2, "photo tiles must only contain image-backed articles");
tileVm.SelectCommand.Execute(tileVm.PhotoProducts[0]);
Check(tileSelection.Selected.Count == 1 && tileSelection.Selected[0].Id == "1",
    "touch tile command parameter must dispatch exact article");
tileVm.SelectCommand.Execute(new ProductSummary("1", "Milk", "123", "milk.png"));
Check(tileSelection.Selected.Count == 1 && tileVm.ScanFeedback == "Product no longer in catalogue",
    "forged touch tile article must not dispatch");
var duplicatedIdentity = new CatalogueViewModel(new Reader(new[] {
    new ProductSummary("SAME", "A", "1"), new ProductSummary("same", "B", "2")
}), new RecordingSelection());
Check(!duplicatedIdentity.CatalogueAvailable && duplicatedIdentity.VisibleProducts.Count == 0,
    "duplicate article IDs must fail closed regardless of case");
var missingIdentity = new CatalogueViewModel(new Reader(new[] {
    new ProductSummary("", "Broken", "99")
}), new RecordingSelection());
Check(!missingIdentity.CatalogueAvailable && missingIdentity.PhotoProducts.Count == 0,
    "missing article identity must not silently drop a row and expose partial catalogue");
var duplicateSelection = new RecordingSelection();
var duplicateVm = new CatalogueViewModel(new Reader(items), duplicateSelection);
duplicateVm.ScannerText = "777";
duplicateVm.ScanBarcode();
duplicateVm.SelectedProduct = items[0];
duplicateVm.SelectCurrent();
Check(duplicateSelection.Selected.Count == 0 && duplicateVm.ScanFeedback == "Choose a matching barcode variant explicitly",
    "active duplicate barcode chooser must reject an unrelated product");
duplicateVm.SelectedProduct = duplicateVm.BarcodeCandidates[1];
duplicateVm.SelectCurrent();
Check(duplicateSelection.Selected.Count == 1 && duplicateSelection.Selected[0].Id == "5",
    "explicit matching variant must dispatch its stable article identity");
var keyboardSelection = new RecordingSelection();
var keyboardVm = new CatalogueViewModel(new Reader(items), keyboardSelection);
keyboardVm.ScannerText = "777";
keyboardVm.ScanCommand.Execute(null);
Check(keyboardVm.BarcodeCandidates.Count == 2 && keyboardSelection.Selected.Count == 0, "duplicate scan waits for explicit choice");
keyboardVm.SelectedProduct = keyboardVm.BarcodeCandidates[0];
keyboardVm.SelectCommand.Execute(null);
Check(keyboardSelection.Selected.Count == 1 && keyboardSelection.Selected[0].Id == "4", "Enter choice selects exact variant");
var resolving = new CatalogueViewModel(new Reader(items), new RecordingSelection());
resolving.ScannerText = "777";
resolving.ScanBarcode();
Check(resolving.HasBarcodeAmbiguity && resolving.BarcodeCandidates.Count == 2,
    "duplicate scan must expose active ambiguity state");
resolving.SelectedProduct = resolving.BarcodeCandidates[1];
resolving.SelectCurrent();
Check(!resolving.HasBarcodeAmbiguity && resolving.BarcodeCandidates.Count == 0 && resolving.ScannerText == "",
    "acknowledged explicit variant clears candidates and scanner for next scan");
var refusing = new CatalogueViewModel(new Reader(items), new PreviewProductSelection());
refusing.ScannerText = "777";
refusing.ScanBarcode();
refusing.SelectedProduct = refusing.BarcodeCandidates[0];
refusing.SelectCurrent();
Check(refusing.HasBarcodeAmbiguity && refusing.ScannerText == "777",
    "rejected explicit variant preserves candidate list and scanner for correction");
var controlState = new CatalogueViewModel(new Reader(items), new RecordingSelection());
Check(controlState.CanSelectProduct, "valid offline catalogue permits selection");
controlState.ScannerText = "777";
controlState.ScanBarcode();
Check(controlState.HasBarcodeAmbiguity, "duplicate candidates activate chooser");
controlState.SearchText = "Milk";
Check(!controlState.HasBarcodeAmbiguity, "filter invalidates duplicate candidate chooser");
var controlFail = new CatalogueViewModel(new Reader(items), new ThrowingSelection());
controlFail.SelectedProduct = items[0];
controlFail.SelectCurrent();
Check(!controlFail.CanSelectProduct && controlFail.CheckoutUncertain,
    "uncertain checkout must disable UI selection controls");
var controlOffline = new CatalogueViewModel(new ChangingReader(items) { Fail = true }, new RecordingSelection());
Check(!controlOffline.CanSelectProduct, "failed local catalogue must disable selection controls");
var uncertainReloadReader = new ChangingReader(items);
var uncertainReloadSelection = new CountingUncertainSelection();
var uncertainReloadVm = new CatalogueViewModel(uncertainReloadReader, uncertainReloadSelection);
uncertainReloadVm.ScannerText = "123";
uncertainReloadVm.ScanBarcode();
Check(uncertainReloadVm.CheckoutUncertain && uncertainReloadVm.ScannerText == "123",
    "uncertain checkout must preserve the scanned barcode");
uncertainReloadVm.ReloadCatalogue();
Check(uncertainReloadVm.CheckoutUncertain && uncertainReloadVm.ScannerText == "123" &&
    uncertainReloadVm.ScanFeedback == "Checkout status unknown — reconcile before retry",
    "successful catalogue reload must not erase checkout uncertainty or scanned barcode");
uncertainReloadReader.Fail = true;
uncertainReloadVm.ReloadCatalogue();
Check(!uncertainReloadVm.CatalogueAvailable && uncertainReloadVm.CheckoutUncertain &&
    uncertainReloadVm.ScannerText == "123" && uncertainReloadSelection.Calls == 1,
    "failed reload must not erase uncertain operation evidence or replay checkout");
var reentrantPort = new ReentrantSelection();
var reentrantVm = new CatalogueViewModel(new Reader(items), reentrantPort);
reentrantPort.ViewModel = reentrantVm;
reentrantVm.SelectedProduct = items[0];
reentrantVm.SelectCurrent();
Check(reentrantPort.Calls == 1 && reentrantPort.DisabledDuringCall &&
    reentrantVm.CanSelectProduct && reentrantVm.ScanFeedback == "Selection accepted",
    "nested touch/scanner invocation must not stage a second checkout selection");
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

sealed class ThrowingSelection : IProductSelection
{
    public bool Select(ProductSummary product) => throw new InvalidOperationException("transport acknowledgement lost");
}

sealed class CountingUncertainSelection : IProductSelection
{
    public int Calls { get; private set; }
    public bool Select(ProductSummary product)
    {
        Calls++;
        throw new InvalidOperationException("acknowledgement lost");
    }
}

sealed class ReentrantSelection : IProductSelection
{
    public CatalogueViewModel? ViewModel { get; set; }
    public int Calls { get; private set; }
    public bool DisabledDuringCall { get; private set; }
    public bool Select(ProductSummary product)
    {
        Calls++;
        DisabledDuringCall = ViewModel is not null && !ViewModel.CanSelectProduct;
        ViewModel!.SelectCurrent();
        return true;
    }
}
