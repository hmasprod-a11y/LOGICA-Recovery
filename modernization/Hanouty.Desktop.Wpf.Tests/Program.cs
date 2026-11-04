using ICatalogueReader = Hanouty.Desktop.Wpf.Presentation.ICatalogueReader;
using ProductSummary = Hanouty.Desktop.Wpf.Presentation.ProductSummary;
using Hanouty.Desktop.Wpf.Presentation;
using Hanouty.ArchitectureBridge;

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
// Barcode identity must agree with the production gateway (ordinal comparison).
// A case-folded scan must never stage an article that has a different live barcode.
var caseSelection = new RecordingSelection();
var caseVm = new CatalogueViewModel(new Reader(new[]
{
    new ProductSummary("case-a", "Case A", "AbC123"),
    new ProductSummary("case-b", "Case B", "abc123")
}), caseSelection);
caseVm.ScannerText = "ABC123";
caseVm.ScanBarcode();
Check(caseVm.ScanFeedback == "Product not found" && caseSelection.Selected.Count == 0,
    "barcode scan must not case-fold identity before production checkout");
caseVm.ScannerText = "AbC123";
caseVm.ScanBarcode();
Check(caseSelection.Selected.Count == 1 && caseSelection.Selected[0].Id == "case-a",
    "exact barcode scan must select only the matching live article");
caseVm.ScannerText = "abc123";
caseVm.ScanBarcode();
Check(caseSelection.Selected.Count == 2 && caseSelection.Selected[1].Id == "case-b",
    "case-distinct barcode must resolve independently");
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
Check(offline.CatalogueAvailable && offline.ScanFeedback == "Product not found",
    "successful empty catalogue must reject scan without reporting a connection failure");
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
Check(vm.ScannerText == "" && vm.BarcodeCandidates.Count == 0,
    "acknowledged duplicate variant must clear scanner internally and reset candidates");
vm.ScannerText = "777";
vm.ScanBarcode();
Check(vm.BarcodeCandidates.Count == 2 && vm.SelectedProduct is null,
    "same barcode must scan again and require a fresh explicit variant choice");
vm.SelectedProduct = vm.BarcodeCandidates[0];
vm.SelectCommand.Execute(null);
Check(selection.Selected.Last().Id == "4" && vm.ScannerText == "",
    "second variant acknowledgement must clear scanner without duplicate implicit sale");
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
    ctor.GetParameters().Any(p => p.ParameterType == typeof(IProductSelection)) &&
    ctor.GetParameters().Any(p => p.ParameterType == typeof(ICheckoutSubmission))),
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
// A malformed command parameter must never dispatch a previously selected row.
var malformedSelection = new RecordingSelection();
var malformedVm = new CatalogueViewModel(new Reader(items), malformedSelection);
malformedVm.SelectedProduct = items[0];
malformedVm.SelectCommand.Execute("not-a-product");
Check(malformedSelection.Selected.Count == 0 &&
    malformedVm.ScanFeedback == "Invalid product selection" &&
    ReferenceEquals(malformedVm.SelectedProduct, items[0]),
    "malformed touch command cannot accidentally sell a stale selected row");
malformedVm.SelectCommand.Execute(null);
Check(malformedSelection.Selected.Count == 1 && malformedSelection.Selected[0].Id == "1",
    "keyboard command with null parameter must retain selected-row behavior");
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
Check(resolving.ScanFeedback == "Selection accepted",
    "clearing acknowledged scanner input must preserve accepted feedback");
resolving.ScannerText = "777";
resolving.ScanBarcode();
Check(resolving.HasBarcodeAmbiguity && resolving.BarcodeCandidates.Count == 2,
    "same barcode can be scanned again only after previous choice completed");
resolving.SelectedProduct = resolving.BarcodeCandidates[0];
resolving.SelectCurrent();
Check(resolving.ScannerText == "" && !resolving.HasBarcodeAmbiguity,
    "second acknowledged variant must also clear scanner after selection guard releases");
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
Check(reentrantPort.Calls == 1 && reentrantPort.DisabledDuringCall && reentrantPort.NestedStatePreserved &&
    reentrantVm.CanSelectProduct && reentrantVm.ScanFeedback == "Selection accepted",
    "nested touch/scanner invocation must not stage a second checkout selection");
// Nested selection must not swap the active article before the port acknowledges it.
var nestedArticlePort = new ReentrantArticleSelection(items[1]);
var nestedArticleVm = new CatalogueViewModel(new Reader(items), nestedArticlePort);
nestedArticlePort.ViewModel = nestedArticleVm;
nestedArticleVm.SelectedProduct = items[0];
nestedArticleVm.SelectCurrent();
Check(nestedArticlePort.Calls == 1 &&
    ReferenceEquals(nestedArticleVm.SelectedProduct, items[0]) &&
    nestedArticlePort.SawOriginalArticle &&
    nestedArticleVm.ScanFeedback == "Selection accepted",
    "nested touch and SelectedProduct setter must not replace in-flight sale article");
var commitPort = new RecordingSubmission();
var commitVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(), submission: commitPort) { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
Check(commitVm.CanCommit, "contextual checkout port with valid payment context enables commit control");
commitPort.Result = CheckoutSubmissionResult.Invalidated;
commitVm.CommitCommand.Execute(null);
Check(commitPort.Ids.Count == 1 && !commitVm.CheckoutUncertain &&
    commitVm.CommitFeedback.Contains("invalidated"), "invalidated checkout must not claim success");
commitPort.Result = CheckoutSubmissionResult.Unknown;
commitVm.CommitCheckout();
Check(commitPort.Ids.Count == 2 && commitPort.Ids[0] == commitPort.Ids[1] &&
    commitVm.CheckoutUncertain && !commitVm.CanCommit,
    "unknown result retains stable operation ID and blocks retry");
commitVm.CommitCheckout();
Check(commitPort.Ids.Count == 2, "unknown checkout must never auto-retry");
var reconciliation = new RecordingReconciliation { Result = CheckoutResolution.Persisted };
var reconciliationPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
var reconciliationVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(),
    submission: reconciliationPort, reconciliation: reconciliation)
    { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
reconciliationVm.CommitCheckout();
var operationToReconcile = reconciliationVm.PendingOperationId;
Check(reconciliationVm.CheckoutUncertain && operationToReconcile is not null,
    "unknown checkout must retain operation identity for journal lookup");
reconciliationVm.ReconcileCommand.Execute(null);
Check(reconciliation.Ids.Count == 1 && reconciliation.Ids[0] == operationToReconcile &&
    reconciliationVm.CheckoutUncertain && !reconciliationVm.CanCommit && reconciliationPort.Ids.Count == 1,
    "persisted journal outcome must not unlock checkout or replay posting");
reconciliation.Result = CheckoutResolution.Absent;
reconciliationVm.ReconcileCheckout();
Check(reconciliationVm.CheckoutUncertain && reconciliationPort.Ids.Count == 1,
    "absent journal outcome still requires explicit Application session reset");
reconciliationVm.PaymentContext = new CashierPaymentContext("different", "register", "MAD", "cash", 10m);
Check(reconciliationVm.PaymentContext?.CashierId == "cashier",
    "uncertain checkout must freeze cashier identity");
var committedPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Committed };
var committedVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(), submission: committedPort) { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
committedVm.CommitCheckout();
committedVm.CommitCheckout();
Check(committedPort.Ids.Count == 2 && committedPort.Ids[0] != committedPort.Ids[1],
    "only acknowledged commit may release operation ID for next checkout");
var unregisteredVm = new CatalogueViewModel(new Reader(items), new RecordingSelection());
Check(!unregisteredVm.CanCommit, "unregistered checkout must fail closed");
unregisteredVm.CommitCheckout();
Check(unregisteredVm.CommitFeedback == "Authorized payment adapter unavailable", "no fake checkout fallback");
var nestedCommitPort = new ReentrantSubmission();
var nestedCommitVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(), submission: nestedCommitPort) { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
nestedCommitPort.ViewModel = nestedCommitVm;
var commitNotifications = 0;
nestedCommitVm.PropertyChanged += (_, e) => { if (e.PropertyName == nameof(CatalogueViewModel.CanCommit)) commitNotifications++; };
nestedCommitVm.CommitCheckout();
Check(nestedCommitPort.Calls == 1 && nestedCommitPort.BlockedWhileExecuting &&
    nestedCommitVm.CanCommit && commitNotifications >= 2,
    "nested checkout commit must be rejected and controls disabled until acknowledgement");
var uncertainCommitPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
var uncertainCommitVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(), submission: uncertainCommitPort) { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
uncertainCommitVm.CommitCheckout();
Check(!uncertainCommitVm.CanCommit && uncertainCommitVm.CheckoutUncertain,
    "unknown checkout disables commit controls without auto-retry");
var nullCatalogueVm = new CatalogueViewModel(new NullCatalogueReader(), new RecordingSelection());
Check(!nullCatalogueVm.CatalogueAvailable && nullCatalogueVm.VisibleProducts.Count == 0 &&
    !nullCatalogueVm.CanSelectProduct && !nullCatalogueVm.CanCommit,
    "null production catalogue response must fail closed rather than appear as valid empty stock");
var unexpectedReaderVm = new CatalogueViewModel(new UnexpectedReader(), new RecordingSelection());
Check(!unexpectedReaderVm.CatalogueAvailable && unexpectedReaderVm.VisibleProducts.Count == 0,
    "unexpected catalogue adapter failure must fail closed without showing stale rows");
var unexpectedSelectionVm = new CatalogueViewModel(new Reader(items), new UnexpectedSelection());
unexpectedSelectionVm.SelectedProduct = items[0];
unexpectedSelectionVm.SelectCurrent();
Check(unexpectedSelectionVm.CheckoutUncertain && !unexpectedSelectionVm.CanSelectProduct,
    "unexpected checkout selection failure must latch uncertainty");
var unexpectedSubmissionVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(),
    submission: new UnexpectedSubmission()) { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
unexpectedSubmissionVm.CommitCheckout();
Check(unexpectedSubmissionVm.CheckoutUncertain && !unexpectedSubmissionVm.CanCommit &&
    unexpectedSubmissionVm.CommitFeedback.Contains("unknown"),
    "unexpected transactional adapter failure must not enable checkout retry");
var invalidResultPort = new RecordingSubmission { Result = (CheckoutSubmissionResult)987 };
var invalidResultVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(), submission: invalidResultPort) { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
invalidResultVm.CommitCheckout();
Check(invalidResultVm.CheckoutUncertain && !invalidResultVm.CanCommit &&
    invalidResultVm.CommitFeedback.Contains("unknown") && invalidResultPort.Ids.Count == 1,
    "unrecognized checkout result must fail closed with unknown transaction outcome");
invalidResultVm.CommitCheckout();
Check(invalidResultPort.Ids.Count == 1, "unrecognized result must not retry transaction");
var frozenVm = new CatalogueViewModel(new Reader(items), new CountingUncertainSelection());
frozenVm.ScannerText = "123";
frozenVm.SearchText = "Milk";
frozenVm.ScanBarcode();
Check(frozenVm.CheckoutUncertain && frozenVm.ScannerText == "123", "unknown scan preserves barcode evidence");
frozenVm.ScannerText = "777";
frozenVm.SearchText = "Other";
Check(frozenVm.ScannerText == "123" && frozenVm.SearchText == "Milk",
    "unknown selection freezes scanner and search until reconciliation");
var frozenCommitVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(),
    submission: new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown }) { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
frozenCommitVm.ScannerText = "123";
frozenCommitVm.SearchText = "Milk";
frozenCommitVm.CommitCheckout();
frozenCommitVm.ScannerText = "777";
frozenCommitVm.SearchText = "Other";
Check(frozenCommitVm.ScannerText == "123" && frozenCommitVm.SearchText == "Milk" &&
    !frozenCommitVm.CanCommit, "unknown sale freezes cashier inputs and prevents replay");
// W2 UI contracts do not authorize a sale: cashier context must be explicit,
// and a durable Unknown outcome remains distinct from Absent or Persisted.
var paymentContext = new CashierPaymentContext("cashier-1", "register-1", "MAD", "cash", 100m);
Check(paymentContext.IsWellFormed, "valid cashier/payment context must be representable");
Check(!(paymentContext with { CashierId = "" }).IsWellFormed &&
    !(paymentContext with { TenderedAmount = -1m }).IsWellFormed &&
    !(paymentContext with { RegisterId = " " }).IsWellFormed,
    "missing cashier/register and negative tender must be rejected at UI boundary");
Check(CheckoutResolution.Unknown != CheckoutResolution.Absent &&
    CheckoutResolution.Unknown != CheckoutResolution.Persisted,
    "unknown durable outcome must never be interpreted as an absent sale");
// The real WPF callsite maps into Architecture's approved financial envelope;
// a durable journal acknowledgement, not a fake UI success, is required.
var financialJournal = new FinancialJournal();
var financialPort = new FinancialPort(financialJournal);
var financialPrep = new FinancialPreparation();
var financialAdapter = new AuthorizedWpfCheckoutAdapter(financialPrep,
    new AuthorizedCheckoutCommitGate(financialPort, financialJournal), financialJournal);
var financialContext = new CashierPaymentContext("cashier-1", "register-1", "MAD", "Cash", 100m);
Check(financialAdapter.Submit("operation-1", financialContext) == CheckoutSubmissionResult.Committed &&
    financialPort.Writes == 1 && financialPrep.Calls == 1,
    "authorized mapping must reach the approved gate exactly once");
Check(financialAdapter.Reconcile("operation-1") == CheckoutResolution.Persisted,
    "journal reconciliation must report actual persisted operation");
financialPrep.Mismatch = true;
Check(financialAdapter.Submit("operation-2", financialContext) == CheckoutSubmissionResult.Invalidated &&
    financialPort.Writes == 1, "cashier identity mismatch must never post");
financialPrep.Mismatch = false;
Check(financialAdapter.Submit("operation-3", financialContext with { TenderCode = "UnknownTender" }) == CheckoutSubmissionResult.Invalidated &&
    financialPort.Writes == 1, "unsupported payment kind must never post");
Check(financialAdapter.Reconcile("missing") == CheckoutResolution.Absent,
    "absent journal operation must be distinguishable from persisted");
// The same production adapter must reach the ViewModel command and its journal
// reconciliation path, rather than being exercised only as an isolated gate.
var wiredJournal = new FinancialJournal();
var wiredPort = new FinancialPort(wiredJournal);
var wiredPreparation = new FinancialPreparation();
var wiredReader = new Reader(items);
var wiredSelection = new RecordingSelection();
var wiredBinding = AuthorizedWpfServiceRegistration.Create(wiredReader, wiredSelection,
    wiredPreparation, new AuthorizedCheckoutCommitGate(wiredPort, wiredJournal), wiredJournal);
Check(ReferenceEquals(wiredBinding.Catalogue, wiredReader) &&
    ReferenceEquals(wiredBinding.Checkout, wiredSelection) &&
    wiredBinding.Submission is AuthorizedWpfCheckoutAdapter,
    "production registration must retain real catalogue/selection and install authorized submission");
var wiredAdapter = (AuthorizedWpfCheckoutAdapter)wiredBinding.Submission;
var wiredVm = new CatalogueViewModel(wiredBinding.Catalogue, wiredBinding.Checkout,
    submission: wiredBinding.Submission,
    reconciliation: wiredBinding.Submission as ICheckoutOutcomeReconciliation)
    { PaymentContext = financialContext };
Check(wiredVm.CanCommit, "registered trusted adapter and context enable the command boundary");
wiredVm.CommitCommand.Execute(null);
Check(wiredPort.Writes == 1 && wiredPreparation.Calls == 1 &&
    wiredVm.CommitFeedback == "Checkout committed",
    "ViewModel command must call trusted preparation and durable gate exactly once");
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
    public bool NestedStatePreserved { get; private set; }
    public bool Select(ProductSummary product)
    {
        Calls++;
        DisabledDuringCall = ViewModel is not null && !ViewModel.CanSelectProduct;
        var beforeRows = ViewModel!.VisibleProducts.Count;
        var beforeText = ViewModel.SearchText;
        var beforeScanner = ViewModel.ScannerText;
        ViewModel.ScannerText = "777";
        ViewModel.ScanBarcode();
        ViewModel.SearchText = "nothing";
        ViewModel.ReloadCatalogue();
        NestedStatePreserved = ViewModel.VisibleProducts.Count == beforeRows &&
            ViewModel.SearchText == beforeText && ViewModel.ScannerText == beforeScanner;
        ViewModel.SelectCurrent();
        return true;
    }
}

sealed class ReentrantArticleSelection(ProductSummary other) : IProductSelection
{
    public CatalogueViewModel? ViewModel { get; set; }
    public int Calls { get; private set; }
    public bool SawOriginalArticle { get; private set; }
    public bool Select(ProductSummary product)
    {
        Calls++;
        ViewModel!.SelectCommand.Execute(other);
        ViewModel.SelectedProduct = other;
        SawOriginalArticle = ReferenceEquals(ViewModel.SelectedProduct, product);
        return true;
    }
}

sealed class RecordingSubmission : IContextualCheckoutSubmission
{
    public CheckoutSubmissionResult Submit(string stableOperationId) => throw new InvalidOperationException("legacy submission forbidden");
    public List<string> Ids { get; } = new();
    public CheckoutSubmissionResult Result { get; set; }
    public CheckoutSubmissionResult Submit(string stableOperationId, CashierPaymentContext context)
    {
        Ids.Add(stableOperationId);
        return Result;
    }
}

sealed class ReentrantSubmission : IContextualCheckoutSubmission
{
    public CheckoutSubmissionResult Submit(string stableOperationId) => throw new InvalidOperationException("legacy submission forbidden");
    public CatalogueViewModel? ViewModel { get; set; }
    public int Calls { get; private set; }
    public bool BlockedWhileExecuting { get; private set; }
    public CheckoutSubmissionResult Submit(string stableOperationId, CashierPaymentContext context)
    {
        Calls++;
        BlockedWhileExecuting = ViewModel is not null && !ViewModel.CanCommit;
        ViewModel!.CommitCheckout();
        return CheckoutSubmissionResult.Committed;
    }
}

sealed class NullCatalogueReader : ICatalogueReader
{
    public IReadOnlyList<ProductSummary> ReadProducts() => null!;
}
sealed class UnexpectedReader : ICatalogueReader
{
    public IReadOnlyList<ProductSummary> ReadProducts() => throw new System.FormatException("corrupt local data");
}
sealed class UnexpectedSelection : IProductSelection
{
    public bool Select(ProductSummary product) => throw new System.FormatException("unexpected application adapter failure");
}
sealed class UnexpectedSubmission : IContextualCheckoutSubmission
{
    public CheckoutSubmissionResult Submit(string stableOperationId) => throw new InvalidOperationException("legacy submission forbidden");
    public CheckoutSubmissionResult Submit(string stableOperationId, CashierPaymentContext context) =>
        throw new System.FormatException("unexpected checkout adapter failure");
}

sealed class RecordingReconciliation : ICheckoutOutcomeReconciliation
{
    public CheckoutResolution Result { get; set; } = CheckoutResolution.Unknown;
    public List<string> Ids { get; } = new();
    public CheckoutResolution Reconcile(string stableOperationId)
    {
        Ids.Add(stableOperationId);
        return Result;
    }
}

sealed class FinancialJournal : ICheckoutOperationJournal
{
    public HashSet<string> Persisted { get; } = new();
    public CheckoutOperationOutcome Lookup(string operationId) => Persisted.Contains(operationId)
        ? CheckoutOperationOutcome.Persisted : CheckoutOperationOutcome.Absent;
}
sealed class FinancialPort(FinancialJournal journal) : IAuthorizedCheckoutPort
{
    public int Writes { get; private set; }
    public void Commit(AuthorizedCheckoutRequest request)
    {
        Writes++;
        journal.Persisted.Add(request.OperationId);
    }
}
sealed class FinancialPreparation : ITrustedWpfCheckoutPreparation
{
    public int Calls { get; private set; }
    public bool Mismatch { get; set; }
    public AuthorizedCheckoutRequest Prepare(string operationId, CashierPaymentContext context)
    {
        Calls++;
        return new AuthorizedCheckoutRequest(operationId, Mismatch ? "wrong-cashier" : context.CashierId,
            context.CurrencyCode, false, new[] { new CheckoutBatchLine("article-1", 1) },
            new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, context.TenderedAmount) }, 100m);
    }
}
