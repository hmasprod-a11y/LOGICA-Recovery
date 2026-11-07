using ICatalogueReader = Hanouty.Desktop.Wpf.Presentation.ICatalogueReader;
using ProductSummary = Hanouty.Desktop.Wpf.Presentation.ProductSummary;
using Hanouty.Desktop.Wpf.Presentation;
using Hanouty.ArchitectureBridge;

// Top-level C# entry points do not carry [STAThread]. Run ALL real WPF window
// assertions on an explicit STA thread; rethrow failures to the process exit code.
System.Exception? staFailure = null;
var staThread = new System.Threading.Thread(() =>
{
    try { RunWpfAssertions(); }
    catch (System.Exception ex) { staFailure = ex; }
});
staThread.SetApartmentState(System.Threading.ApartmentState.STA);
staThread.Start();
staThread.Join();
if (staFailure is not null)
    System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(staFailure).Throw();

static void RunWpfAssertions()
{
static void Check(bool value, string reason)
{
    if (!value) throw new Exception(reason);
}
// A catalogue-only diagnostic resolver must never make the installed WPF app
// start a cashier process. The QA-owned Bootstrap must supply financial services.
Hanouty.Desktop.Wpf.App.ResolveFinancialServices = null;
Hanouty.Desktop.Wpf.App.ResolveServices = () =>
    (new EmptyCatalogueReader(), new RecordingSelection(), new RecordingSubmission());
Check(!Hanouty.Desktop.Wpf.App.HasProductionStartupResolver,
    "catalogue-only resolver must not unlock installed production startup");
Hanouty.Desktop.Wpf.App.ResolveServices = null;
// Production session adapter must not post if the Host session expires or
// its authorization callback fails. The same durable submission stays unused.
var expiredHostSession = new SessionFinancialSubmission();
var expiredAdapter = new SessionBoundCashCheckoutSubmission(expiredHostSession,
    () => throw new InvalidOperationException("Local cashier session expired"));
var expiredContext = new CashierPaymentContext("cashier-1", "register-1", "MAD", "Cash", 100m);
Check(expiredAdapter.Submit("expired-session-operation", expiredContext) == CheckoutSubmissionResult.Invalidated &&
    expiredHostSession.Ids.Count == 0,
    "expired Host cashier context must fail closed without financial posting");
// Host invalidation is not permission to retry the same operation or draft.
var invalidatedSubmission = new RecordingSubmission { Result = CheckoutSubmissionResult.Invalidated };
var invalidatedJournal = new RecordingReconciliation();
var invalidatedVm = new CatalogueViewModel(
    new Reader(new[] { new ProductSummary("invalidated-item", "Test", "INV-1") }),
    new RecordingSelection(), submission: invalidatedSubmission, reconciliation: invalidatedJournal);
invalidatedVm.PaymentContext = expiredContext;
invalidatedVm.CommitCheckout();
var invalidatedOperation = invalidatedVm.PendingOperationId;
Check(invalidatedVm.CheckoutUncertain && !invalidatedVm.CanCommit &&
    invalidatedOperation is not null && invalidatedSubmission.Ids.Count == 1,
    "invalidated Host draft must latch durable review and preserve operation identity");
invalidatedVm.CommitCheckout();
Check(invalidatedSubmission.Ids.Count == 1 &&
    invalidatedVm.PendingOperationId == invalidatedOperation,
    "invalidated draft cannot be silently submitted a second time");
invalidatedVm.ReconcileCheckout();
Check(invalidatedVm.CheckoutUncertain && !invalidatedVm.CanReviewResolvedCheckout,
    "unknown durable result cannot unlock invalidated cashier draft");
// Architecture CreateFinancial host registers the same financial adapter and
// authenticated cash context at WPF startup, without a second host or PIN copy.
var startupJournal = new FinancialJournal();
var startupAdapter = new AuthorizedWpfCheckoutAdapter(new FinancialPreparation(),
    new AuthorizedCheckoutCommitGate(new FinancialPort(startupJournal), startupJournal), startupJournal);
var startupCash = new CashierPaymentContext("cashier-1", "register-1", "MAD", "Cash", 100m);
Hanouty.Desktop.Wpf.App.ResolveFinancialServices = () =>
    (new EmptyCatalogueReader(), new RecordingSelection(), startupAdapter, startupCash);
Check(Hanouty.Desktop.Wpf.App.HasProductionStartupResolver, "financial host must enable startup");
var registered = Hanouty.Desktop.Wpf.App.ResolveFinancialServices();
Check(registered.Payment == startupCash &&
    ReferenceEquals(registered.Submission, startupAdapter) &&
    registered.Submission is ICheckoutOutcomeReconciliation &&
    registered.Submission is IContextualCheckoutSubmission,
    "CreateFinancial WPF startup must preserve same contextual submission and durable reconciliation");
Check(Hanouty.Desktop.Wpf.App.HasAuthorizedFinancialRegistration(
    registered.Catalogue, registered.Checkout, registered.Submission, registered.Payment),
    "production financial composition must be accepted");
Check(!Hanouty.Desktop.Wpf.App.HasAuthorizedFinancialRegistration(
    registered.Catalogue, registered.Checkout, new RecordingSubmission(), registered.Payment),
    "non-contextual preview submission must never pass production registration");
Check(!Hanouty.Desktop.Wpf.App.HasAuthorizedFinancialRegistration(
    registered.Catalogue, registered.Checkout, registered.Submission, null),
    "missing cashier registration must fail closed");
Check(!Hanouty.Desktop.Wpf.App.HasAuthorizedFinancialRegistration(
    registered.Catalogue, registered.Checkout, registered.Submission,
    new CashierPaymentContext("cashier-1", "register-1", "MAD", "Card", 100m)),
    "non-cash tender must not unlock cash-only production startup");
Check(!Hanouty.Desktop.Wpf.App.HasAuthorizedFinancialRegistration(
    null, registered.Checkout, registered.Submission, registered.Payment),
    "missing production catalogue must block startup");
Hanouty.Desktop.Wpf.App.ResolveFinancialServices = null;
// Production startup without a Host-authenticated cashier is read-only:
// a scanner or catalogue touch must not stage a basket before sign-in.
var lockedSelection = new RecordingSelection();
var lockedWindow = new Hanouty.Desktop.Wpf.MainWindow(
    new Reader(new[] { new ProductSummary("locked-1", "Locked article", "L001") }),
    lockedSelection, new RecordingSubmission(), null, requireFreshPaymentContext: true);
var cashierScroll = (System.Windows.Controls.ScrollViewer)lockedWindow.FindName("CashierWorkflowScroll");
Check(cashierScroll is not null && cashierScroll.VerticalScrollBarVisibility ==
    System.Windows.Controls.ScrollBarVisibility.Auto &&
    cashierScroll.HorizontalScrollBarVisibility == System.Windows.Controls.ScrollBarVisibility.Disabled,
    "cashier and return controls remain vertically reachable in compact high-DPI window");
lockedWindow.Width = lockedWindow.MinWidth;
lockedWindow.Height = lockedWindow.MinHeight;
lockedWindow.UpdateLayout();
Check(cashierScroll.ActualHeight >= 0 && lockedWindow.FlowDirection ==
    System.Windows.FlowDirection.LeftToRight,
    "compact WPF window measures cashier workflow without clipping horizontal controls");
var lockedVm = (CatalogueViewModel)lockedWindow.DataContext;
Check(!lockedVm.FinancialSessionActive && !lockedVm.CanSelectProduct && !lockedVm.CanCommit,
    "unauthenticated production window must start locked");
lockedVm.ScannerText = "L001";
lockedVm.ScanCommand.Execute(null);
lockedVm.SelectCommand.Execute(lockedVm.VisibleProducts[0]);
Check(lockedSelection.Selected.Count == 0 && lockedVm.ScanFeedback == "Cashier session required",
    "scanner and touch cannot stage items before cashier authentication");
lockedVm.FinancialSessionActive = true;
lockedVm.SelectCommand.Execute(lockedVm.VisibleProducts[0]);
Check(lockedSelection.Selected.Count == 1,
    "Host-authorized session enables the existing catalogue selection port");
// Actual STA MainWindow trusted readback: fail closed without cashier, then
// show only Host-provided amount and revoke it on logout/context transition.
int trustedReads = 0;
lockedWindow.ConfigureCashierEntry((_, _, _) => false,
    () => { trustedReads++; return 17.25m; }, () => true, () => "basket-a");
Check(!lockedWindow.RefreshTrustedBasketTotal() && trustedReads == 0,
    "no trusted basket readback without authenticated payment context");
lockedVm.PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "Cash", 17.25m);
Check(lockedWindow.RefreshTrustedBasketTotal() && trustedReads == 1 &&
    ((System.Windows.Controls.TextBlock)lockedWindow.FindName("TrustedBasketTotal")).Text.Contains("17.25"),
    "STA window displays Host-authoritative MAD total");
lockedVm.FinancialSessionActive = false;
Check(((System.Windows.Controls.TextBlock)lockedWindow.FindName("TrustedBasketTotal")).Text.Contains("unavailable") &&
    !lockedWindow.RefreshTrustedBasketTotal() && trustedReads == 1,
    "logout revokes trusted total and blocks another readback");
lockedWindow.Close();
var items = new[]
{
    new ProductSummary("1", "Milk", "123", "milk.png"),
    new ProductSummary("2", "Bread", "", null),
    new ProductSummary("3", "Milk Chocolate", "456", null),
    new ProductSummary("4", "Duplicate A", "777", "a.png"),
    new ProductSummary("5", "Duplicate B", "777", null)
};

// A successful or uncertain checkout must not leave the old basket quote on
// screen: readback requires a fresh authoritative Host call after resolution.
var quoteSubmission = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
var quoteWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
    new RecordingSelection(), quoteSubmission,
    new CashierPaymentContext("cashier", "register", "MAD", "Cash", 10m),
    requireFreshPaymentContext: true);
var quoteVm = (CatalogueViewModel)quoteWindow.DataContext;
quoteWindow.ConfigureCashierEntry((_, _, _) => false, () => 10m, () => true, () => "basket-before");
Check(quoteWindow.RefreshTrustedBasketTotal() &&
    quoteWindow.TrustedBasketTotal.Text.Contains("10.00"),
    "STA displays original Host quote before checkout");
quoteVm.CommitCheckout();
Check(quoteVm.CheckoutUncertain &&
    !quoteWindow.TrustedBasketTotal.Text.Contains("10.00") &&
    !quoteWindow.RefreshTrustedBasketTotal(),
    "Unknown checkout revokes old displayed quote and prevents a second read");
quoteWindow.Close();

// Actual STA window: nested Host callback cannot publish a stale amount.
var nestedWindow = new Hanouty.Desktop.Wpf.MainWindow(new EmptyCatalogueReader(),
    new RecordingSelection(), new RecordingSubmission(), null, requireFreshPaymentContext: true);
var nestedVm = (CatalogueViewModel)nestedWindow.DataContext;
nestedVm.PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "Cash", 12m);
int nestedReads = 0;
bool nestedDenied = false;
nestedWindow.ConfigureCashierEntry((_, _, _) => false, () => {
    nestedReads++;
    nestedDenied = !nestedWindow.RefreshTrustedBasketTotal();
    return 12m;
}, () => true, () => "basket-1");
Check(nestedWindow.RefreshTrustedBasketTotal() && nestedDenied && nestedReads == 1,
    "nested Host total callback is rejected without duplicate read");
nestedVm.FinancialSessionActive = false;
nestedWindow.Close();

// Real STA window: a Host total read may pump Dispatcher; it must not
// concurrently end the cashier session or open a second login dialog.
var readLockWindow = new Hanouty.Desktop.Wpf.MainWindow(new EmptyCatalogueReader(),
    new RecordingSelection(), new RecordingSubmission(), null, requireFreshPaymentContext: true);
var readLockVm = (CatalogueViewModel)readLockWindow.DataContext;
readLockVm.PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "Cash", 19m);
int logoutDuringRead = 0;
bool deniedLogoutDuringRead = false;
bool deniedLoginDuringRead = false;
readLockWindow.ConfigureCashierEntry((_, _, _) => false, () => {
    deniedLogoutDuringRead = !readLockWindow.EndFinancialSession();
    deniedLoginDuringRead = !readLockWindow.ShowCashierEntry();
    return 19m;
}, () => { logoutDuringRead++; return true; }, () => "basket-locked");
Check(readLockWindow.RefreshTrustedBasketTotal() && deniedLogoutDuringRead &&
    deniedLoginDuringRead && logoutDuringRead == 0 && readLockVm.FinancialSessionActive,
    "STA trusted read blocks reentrant logout and login without invoking Host logout");
readLockWindow.Close();

var precisionWindow = new Hanouty.Desktop.Wpf.MainWindow(new EmptyCatalogueReader(),
    new RecordingSelection(), new RecordingSubmission(), null, requireFreshPaymentContext: true);
var precisionVm = (CatalogueViewModel)precisionWindow.DataContext;
precisionVm.PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "Cash", 12m);
precisionWindow.ConfigureCashierEntry((_, _, _) => false, () => 12.345m, () => true, () => "basket-1");
Check(!precisionWindow.RefreshTrustedBasketTotal() &&
    ((System.Windows.Controls.TextBlock)precisionWindow.FindName("TrustedBasketTotal")).Text.Contains("unavailable"),
    "non-cent MAD amount is not rounded into a misleading trusted total");
precisionWindow.Close();

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
// Changing a duplicate barcode query revokes the old variant evidence immediately.
var changedVariantSelection = new RecordingSelection();
var changedVariantVm = new CatalogueViewModel(new Reader(items), changedVariantSelection);
changedVariantVm.ScannerText = "777";
changedVariantVm.ScanBarcode();
Check(changedVariantVm.HasBarcodeAmbiguity && changedVariantVm.BarcodeCandidates.Count > 1,
    "duplicate scan exposes explicit variants");
changedVariantVm.SelectedProduct = changedVariantVm.BarcodeCandidates[0];
changedVariantVm.ScannerText = "123";
Check(!changedVariantVm.HasBarcodeAmbiguity &&
    changedVariantVm.BarcodeCandidates.Count == 0 && changedVariantVm.SelectedProduct is null,
    "scanner edit revokes stale duplicate barcode variant and selection");
changedVariantVm.SelectCurrent();
Check(changedVariantSelection.Selected.Count == 0,
    "stale variant cannot be dispatched after scanner input changes");
changedVariantVm.ScanBarcode();
Check(changedVariantSelection.Selected.Count == 1 &&
    changedVariantSelection.Selected[0].Barcode == "123",
    "new scan selects only the new barcode after revocation");
// A disabled visual button is not a security boundary: keyboard/programmatic
// SelectCommand must also reject selection after logout, then allow a fresh session.
var logoutSelection = new RecordingSelection();
var logoutVm = new CatalogueViewModel(new Reader(new[] { new ProductSummary("logout-item", "Logout item", "900") }), logoutSelection);
logoutVm.SelectedProduct = logoutVm.VisibleProducts[0];
logoutVm.FinancialSessionActive = false;
Check(logoutVm.SelectedProduct is null && logoutVm.BarcodeCandidates.Count == 0 && logoutVm.ScannerText == "",
    "logout must discard stale selected article, variant choice and scanner text");
logoutVm.SelectedProduct = null;
logoutVm.SelectCommand.Execute(null);
logoutVm.SelectCommand.Execute(logoutVm.VisibleProducts[0]);
Check(logoutVm.SelectedProduct is null, "logged-out touch command must not stage a product for later reauthorization");
logoutVm.SelectCurrent();
Check(logoutSelection.Selected.Count == 0 && logoutVm.ScanFeedback == "Cashier session required",
    "logged-out direct and keyboard selection commands must not stage an article");
logoutVm.FinancialSessionActive = true;
logoutVm.SelectedProduct = logoutVm.VisibleProducts[0];
logoutVm.SelectCommand.Execute(null);
Check(logoutSelection.Selected.Count == 1,
    "authorized fresh session restores direct selection without stale action replay");
// A duplicate barcode chooser from the previous cashier must not survive logout.
var variantLogoutSelection = new RecordingSelection();
var variantLogoutVm = new CatalogueViewModel(new Reader(items), variantLogoutSelection);
variantLogoutVm.ScannerText = "777";
variantLogoutVm.ScanBarcode();
Check(variantLogoutVm.HasBarcodeAmbiguity, "duplicate barcode chooser must be visible before logout");
variantLogoutVm.FinancialSessionActive = false;
Check(!variantLogoutVm.HasBarcodeAmbiguity && variantLogoutVm.BarcodeCandidates.Count == 0 &&
    variantLogoutVm.ScannerText == "" && variantLogoutVm.SelectedProduct is null,
    "logout discards old cashier duplicate barcode choice and scanner input");
variantLogoutVm.FinancialSessionActive = true;
variantLogoutVm.SelectCommand.Execute(null);
Check(variantLogoutSelection.Selected.Count == 0,
    "re-login cannot silently dispatch a variant staged by previous cashier");
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
vm.ScannerText = " 123";
vm.ScanBarcode();
Check(vm.ScanFeedback == "Barcode contains leading or trailing whitespace" &&
    selection.Selected.Count == 1 && vm.SelectedProduct is null && vm.BarcodeCandidates.Count == 0,
    "scanner must not trim leading whitespace into another article identity");
vm.ScannerText = "123";
Check(vm.ScanFeedback == "" && vm.BarcodeCandidates.Count == 0 &&
    vm.SelectedProduct is null && selection.Selected.Count == 1,
    "editing rejected whitespace scan clears stale error without dispatching");
vm.ScannerText = "123 ";
vm.ScanBarcode();
Check(vm.ScanFeedback == "Barcode contains leading or trailing whitespace" &&
    selection.Selected.Count == 1 && vm.SelectedProduct is null,
    "scanner must not trim trailing whitespace into another article identity");

vm.ScannerText = "12\\u00003";
vm.ScanBarcode();
Check(vm.ScanFeedback == "Barcode contains control characters" &&
    selection.Selected.Count == 1 && vm.SelectedProduct is null &&
    vm.BarcodeCandidates.Count == 0,
    "scanner must reject embedded NUL without dispatching a different product");
vm.ScannerText = "12\\u001F3";
vm.ScanBarcode();
Check(vm.ScanFeedback == "Barcode contains control characters" &&
    selection.Selected.Count == 1 && vm.SelectedProduct is null,
    "scanner must reject embedded unit separator without dispatch");
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
Check(CashierEntryDraft.TryParse("cashier01", "register02", "10.25", out var enteredCashier, out var enteredRegister, out var enteredTender) &&
    enteredCashier == "cashier01" && enteredRegister == "register02" && enteredTender == 10.25m,
    "cashier/register and invariant MAD tender parse without authorization");
Check(!CashierEntryDraft.TryParse("cashier\n02", "register02", "10.00", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("cashier01", "register\t02", "10.00", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("cashier01", "register\uD800", "10.00", out _, out _, out _),
    "control and surrogate characters in cashier/register must fail closed");
Check(!CashierEntryDraft.TryParse("cashier01", "register02", "10,25", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("cashier01", "register02", "10.251", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("cashier01", "register02", "-1", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("", "register02", "10", out _, out _, out _),
    "invalid decimal, excess precision, negative tender and absent cashier fail closed");
Check(!CashierEntryDraft.TryParse("cashier01", "register02", "1.", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("cashier01", "register02", ".5", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("cashier01", "register02", "1..2", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("cashier01", "register02", "1 000", out _, out _, out _) &&
    !CashierEntryDraft.TryParse("cashier01", "register02", "+1", out _, out _, out _) &&
    CashierEntryDraft.TryParse("cashier01", "register02", "0.50", out _, out _, out var cents) &&
    cents == 0.50m,
    "cashier tender rejects unfinished, signed or grouped input before Host validation");
Check(!new CashierPaymentContext(" cashier01", "register02", "MAD", "Cash", 10m).IsWellFormed &&
    !new CashierPaymentContext("cashier01", "register\n02", "MAD", "Cash", 10m).IsWellFormed &&
    !new CashierPaymentContext("cashier01", "register02", "MAD", "Cash", 10.001m).IsWellFormed &&
    !new CashierPaymentContext("cashier01", "register02", "MAD ", "Cash", 10m).IsWellFormed &&
    new CashierPaymentContext("cashier01", "register02", "MAD", "Cash", 10.25m).IsWellFormed,
    "financial context refuses whitespace, controls and sub-cent tender before checkout");
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
Check(reconciliationVm.ReviewedResolution == CheckoutResolution.Persisted &&
    reconciliationVm.CanReviewResolvedCheckout && reconciliationVm.PendingOperationId == operationToReconcile,
    "persisted result must be reviewable without unlocking or dropping operation ID");
reconciliation.Result = CheckoutResolution.Absent;
reconciliationVm.ReconcileCheckout();
Check(reconciliationVm.ReviewedResolution == CheckoutResolution.Absent &&
    reconciliationVm.CanReviewResolvedCheckout && reconciliationVm.PendingOperationId == operationToReconcile,
    "absent result must be reviewable but cannot trigger blind retry");
reconciliation.Result = CheckoutResolution.Unknown;
reconciliationVm.ReconcileCheckout();
Check(reconciliationVm.ReviewedResolution == CheckoutResolution.Unknown &&
    !reconciliationVm.CanReviewResolvedCheckout && !reconciliationVm.CanCommit,
    "unknown journal result must revoke review eligibility and keep sale locked");
Check(reconciliationVm.CheckoutUncertain && reconciliationPort.Ids.Count == 1,
    "absent journal outcome still requires explicit Application session reset");
reconciliationVm.PaymentContext = new CashierPaymentContext("different", "register", "MAD", "cash", 10m);
Check(reconciliationVm.PaymentContext?.CashierId == "cashier",
    "uncertain checkout must freeze cashier identity");
// A disabled WPF button is not a transaction authorization boundary.
// Direct keyboard/programmatic commit after logout must not reach the production port.
var freshContextPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Committed };
var freshContextVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(),
    submission: freshContextPort) { RequireFreshPaymentContext = true,
    PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
Check(freshContextVm.CanCommit, "fresh authorized cashier payment context initially permits checkout");
freshContextVm.FinancialSessionActive = false;
Check(freshContextVm.PaymentContext is null && !freshContextVm.CanCommit,
    "logout expires the previous authorized payment context without submitting a sale");
freshContextVm.FinancialSessionActive = true;
freshContextVm.CommitCommand.Execute(null);
Check(freshContextPort.Ids.Count == 0 && freshContextVm.PaymentContext is null,
    "new cashier session cannot reuse the previous payment authorization");
freshContextVm.PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 11m);
freshContextVm.CommitCommand.Execute(null);
Check(freshContextPort.Ids.Count == 1,
    "fresh host-supplied payment context restores checkout after logout");
var loggedOutCommitPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Committed };
var loggedOutCommitVm = new CatalogueViewModel(new Reader(items), new RecordingSelection(),
    submission: loggedOutCommitPort) { PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m) };
loggedOutCommitVm.FinancialSessionActive = false;
loggedOutCommitVm.CommitCommand.Execute(null);
loggedOutCommitVm.CommitCheckout();
Check(loggedOutCommitPort.Ids.Count == 0 && loggedOutCommitVm.PendingOperationId is null &&
    loggedOutCommitVm.CommitFeedback == "Cashier session required",
    "logged-out direct commit must not allocate an operation or call the checkout port");
loggedOutCommitVm.FinancialSessionActive = true;
loggedOutCommitVm.CommitCommand.Execute(null);
Check(loggedOutCommitPort.Ids.Count == 1 && loggedOutCommitVm.PendingOperationId is null,
    "fresh active cashier session permits a new acknowledged operation");
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
// CreateFinancial's session-bound adapter must submit to the same selection
// session and preserve durable reconciliation, not construct a second basket.
var boundSession = new SessionFinancialSubmission();
var boundContext = new CashierPaymentContext("cashier-1", "register-1", "MAD", "Cash", 100m);
var boundServices = AuthorizedWpfServiceRegistration.CreateSessionBound(
    new Reader(items), new RecordingSelection(), boundSession, () => boundContext);
var boundAdapter = (IContextualCheckoutSubmission)boundServices.Submission;
var boundReconciliation = (ICheckoutOutcomeReconciliation)boundServices.Submission;
Check(boundAdapter.Submit("bound-op", boundContext) == CheckoutSubmissionResult.Committed &&
    boundSession.Ids.Count == 1 && boundSession.Ids[0] == "bound-op",
    "contextual commit must reach the existing financial session exactly once");
Check(boundReconciliation.Reconcile("bound-op") == CheckoutResolution.Persisted &&
    boundSession.Reconciled.Count == 1, "reconciliation must delegate to the same financial session");
Check(boundAdapter.Submit("wrong-register", boundContext with { RegisterId = "other" }) ==
    CheckoutSubmissionResult.Invalidated && boundSession.Ids.Count == 1,
    "changed register must never reach financial session");
Check(boundAdapter.Submit("wrong-amount", boundContext with { TenderedAmount = 99m }) ==
    CheckoutSubmissionResult.Invalidated && boundSession.Ids.Count == 1,
    "untrusted tender must never reach financial session");
Check(boundAdapter.Submit("wrong-tender", boundContext with { TenderCode = "Card" }) ==
    CheckoutSubmissionResult.Invalidated && boundSession.Ids.Count == 1,
    "noncash tender must never reach financial session");
Check(boundReconciliation.Reconcile("missing") == CheckoutResolution.Absent,
    "absent durable operation must remain distinct from unknown");
// Exercise the actual UI commands against the very same session-bound submission.
// This is a callsite test; QA still owns the real MariaDB W2 acceptance graph.
var boundSelection = new RecordingSelection();
var boundUiSession = new SessionFinancialSubmission();
var boundUiServices = AuthorizedWpfServiceRegistration.CreateSessionBound(
    new Reader(items), boundSelection, boundUiSession, () => boundContext);
var boundUi = new CatalogueViewModel(boundUiServices.Catalogue, boundUiServices.Checkout,
    submission: boundUiServices.Submission,
    reconciliation: (ICheckoutOutcomeReconciliation)boundUiServices.Submission)
{ PaymentContext = boundContext };
boundUi.ScannerText = "123";
boundUi.ScanCommand.Execute(null);
Check(boundSelection.Selected.Count == 1 && boundUi.ScannerText == "",
    "session-bound UI barcode command must select exactly once and reset scanner");
Check(boundUi.CanCommit, "registered authorized cash context must enable UI commit");
boundUi.CommitCommand.Execute(null);
Check(boundUiSession.Ids.Count == 1 && boundUi.CommitFeedback == "Checkout committed",
    "same ViewModel commit command must submit once to registered session");

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
Check(financialAdapter.Submit("card-blocked", financialContext with { TenderCode = "Card" }) == CheckoutSubmissionResult.Invalidated &&
    financialPrep.Calls == 1 && financialPort.Writes == 1,
    "card tender must fail before trusted preparation and financial posting");
Check(financialAdapter.Submit("transfer-blocked", financialContext with { TenderCode = "BankTransfer" }) == CheckoutSubmissionResult.Invalidated &&
    financialPrep.Calls == 1 && financialPort.Writes == 1,
    "bank transfer must fail before trusted preparation in cash-only W2 slice");
financialPrep.Mismatch = true;
Check(financialAdapter.Submit("operation-2", financialContext) == CheckoutSubmissionResult.Invalidated &&
    financialPort.Writes == 1, "cashier identity mismatch must never post");
financialPrep.Mismatch = false;
Check(financialAdapter.Submit("operation-3", financialContext with { TenderCode = "UnknownTender" }) == CheckoutSubmissionResult.Invalidated &&
    financialPort.Writes == 1, "unsupported payment kind must never post");
financialPrep.Return = true;
Check(financialAdapter.Submit("return-blocked", financialContext) == CheckoutSubmissionResult.Invalidated &&
    financialPort.Writes == 1, "returns are outside approved cash-sale slice");
financialPrep.Return = false;
financialPrep.Credit = true;
Check(financialAdapter.Submit("credit-blocked", financialContext with { TenderCode = "Credit" }) == CheckoutSubmissionResult.Invalidated &&
    financialPort.Writes == 1, "credit settlement is outside approved cash-sale slice");
financialPrep.Credit = false;
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
// Exercise the exact ViewModel that owns the payment command: select the
// article before submitting, rather than committing against a disconnected UI.
wiredVm.ScannerText = "123";
wiredVm.ScanCommand.Execute(null);
Check(wiredSelection.Selected.Count == 1 && wiredSelection.Selected[0].Id == "1" &&
    wiredVm.ScannerText == "" && wiredVm.ScanFeedback == "Selection accepted",
    "same cash-session ViewModel must route barcode selection before payment");
Check(wiredVm.CanCommit, "registered trusted adapter and context enable the command boundary");
wiredVm.CommitCommand.Execute(null);
Check(wiredPort.Writes == 1 && wiredPreparation.Calls == 1 &&
    wiredVm.CommitFeedback == "Checkout committed",
    "ViewModel command must call trusted preparation and durable gate exactly once");

// Explicit reviewed reset must never post, unlock Unknown, or reuse an old ID.
foreach (var outcome in new[] { CheckoutResolution.Persisted, CheckoutResolution.Absent })
{
    var submit = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
    var journal = new RecordingReconciliation { Result = outcome };
    var reviewed = new CatalogueViewModel(new Reader(items), new RecordingSelection(),
        submission: submit, reconciliation: journal) { PaymentContext = financialContext };
    reviewed.CommitCheckout();
    var oldId = reviewed.PendingOperationId;
    var calls = 0;
    Check(!reviewed.TryReviewResolvedCheckout((_, _) => { calls++; return true; }) && calls == 0,
        "Unknown must not invoke review authority");
    reviewed.ReconcileCheckout();
    Check(!reviewed.TryReviewResolvedCheckout((_, _) => false) && reviewed.CheckoutUncertain &&
        reviewed.PendingOperationId == oldId, "cancel or rejected PIN must retain review lock and identity");
    Check(!reviewed.TryReviewResolvedCheckout((_, _) => throw new System.IO.IOException()) &&
        reviewed.CheckoutUncertain, "review exception must fail closed");
    Check(reviewed.TryReviewResolvedCheckout((id, result) => {
        Check(id == oldId && result == outcome, "review must authorize the exact durable result");
        reviewed.CommitCheckout();
        reviewed.ReconcileCheckout();
        Check(!reviewed.TryReviewResolvedCheckout((_, _) => true), "nested review must be blocked");
        return true;
    }) && !reviewed.CheckoutUncertain && reviewed.PendingOperationId is null &&
        submit.Ids.Count == 1, "explicit authorized reset clears only UI identity without financial replay");
    Check(!reviewed.TryReviewResolvedCheckout((_, _) => true), "review cannot be repeated");
    submit.Result = CheckoutSubmissionResult.Committed;
    reviewed.CommitCheckout();
    Check(submit.Ids.Count == 2 && submit.Ids[1] != oldId,
        "next checkout must receive a fresh durable operation identity");
}

// Exercise the actual MainWindow review seam on an STA, not a mock ViewModel-only path.
// Host callback must not permit overlapping cashier entry, logout or nested review.
Exception? windowReviewError = null;
var reviewThread = new System.Threading.Thread(() =>
{
    try
    {
        var submit = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
        var journal = new RecordingReconciliation { Result = CheckoutResolution.Persisted };
        var window = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items), new RecordingSelection(), submit,
            new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m));
        var viewModel = (CatalogueViewModel)window.DataContext;
        viewModel.CommitCheckout();
        viewModel.ReconcileCheckout();
        Check(viewModel.CanReviewResolvedCheckout, "durable persisted result permits explicit review request");
        int authorityCalls = 0;
        int sessionEndCalls = 0;
        int entryCalls = 0;
        window.ConfigureCashierEntry((_, _, _) => { entryCalls++; return true; }, () => 10m,
            () => { sessionEndCalls++; return true; });
        window.ConfigureReviewedCheckout((id, outcome, readPin) =>
        {
            authorityCalls++;
            Check(!window.EndFinancialSession() && !window.ShowCashierEntry() &&
                !window.ReviewResolvedCheckout(() => "nested"),
                "review must serialize against logout, cashier entry and nested review");
            Check(id == viewModel.PendingOperationId && outcome == CheckoutResolution.Persisted &&
                readPin() == "transient", "host receives exact durable operation and transient PIN callback");
            return true;
        });
        Check(window.ReviewResolvedCheckout(() => "transient") && authorityCalls == 1 &&
            sessionEndCalls == 0 && entryCalls == 0 && !viewModel.CheckoutUncertain &&
            viewModel.PendingOperationId is null && submit.Ids.Count == 1,
            "review unlocks only after host authorization, without posting again");
        Check(!window.ReviewResolvedCheckout(() => "again") && authorityCalls == 1,
            "resolved operation cannot be reviewed a second time");
        window.Close();

        // Persisted result: Host denial must preserve the durable identity and
        // prevent any financial replay. Fresh authorization may then resolve it.
        var persistedPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
        var persistedJournal = new RecordingReconciliation { Result = CheckoutResolution.Persisted };
        var persistedWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new ReconciledSubmission(persistedPort, persistedJournal),
            financialContext, requireFreshPaymentContext: true);
        var persistedVm = (CatalogueViewModel)persistedWindow.DataContext;
        persistedVm.CommitCheckout();
        var persistedId = persistedVm.PendingOperationId;
        persistedVm.ReconcileCheckout();
        // A scanner/variant draft may be staged while the outcome is unresolved;
        // it must never survive a cashier-reviewed reset into the next session.
        persistedVm.ScannerText = "777";
        persistedVm.ScanBarcode();
        Check(persistedVm.CheckoutUncertain && persistedVm.PendingOperationId == persistedId,
            "unresolved checkout must retain durable identity despite scanner input");
        int persistedAuthority = 0;
        int persistedPinReads = 0;
        persistedWindow.ConfigureReviewedCheckout((id, result, readPin) =>
        {
            persistedAuthority++;
            Check(id == persistedId && result == CheckoutResolution.Persisted,
                "Host review must receive exact persisted identity");
            if (persistedAuthority == 1) return false;
            return readPin() == "fresh-session";
        });
        Check(!persistedWindow.ReviewResolvedCheckout(() => { persistedPinReads++; return "unused"; }) &&
            persistedPinReads == 0 && persistedVm.CheckoutUncertain &&
            persistedVm.PendingOperationId == persistedId && persistedPort.Ids.Count == 1,
            "denied persisted review must not read PIN, unlock or replay");
        Check(persistedWindow.ReviewResolvedCheckout(() => { persistedPinReads++; return "fresh-session"; }) &&
            persistedAuthority == 2 && persistedPinReads == 1 &&
            !persistedVm.CheckoutUncertain && persistedVm.PendingOperationId is null &&
            persistedVm.PaymentContext is null && persistedPort.Ids.Count == 1 &&
            persistedVm.ScannerText == "" && persistedVm.BarcodeCandidates.Count == 0 &&
            persistedVm.SelectedProduct is null,
            "authorized persisted review resets scanner and variant draft without financial replay");
        persistedWindow.Close();

        // The real WPF PIN entry point must fail closed without ever opening a
        // modal PasswordBox for a logged-out, wrong-cashier or unresolved sale.
        var pinWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new RecordingSubmission(), financialContext,
            requireFreshPaymentContext: true);
        var pinVm = (CatalogueViewModel)pinWindow.DataContext;
        Check(pinWindow.PromptCashierPin("other-cashier") == "",
            "checkout PIN must reject a different cashier without prompting");
        pinVm.FinancialSessionActive = false;
        Check(pinWindow.PromptCashierPin() == "" &&
            pinWindow.PromptCashierPin("cashier-1") == "",
            "checkout PIN must not prompt after logout");
        pinWindow.Close();

        // Trusted Host callbacks can synchronously reenter WPF before a dialog opens.
        var reentrantEntryWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new RecordingSubmission(), financialContext,
            requireFreshPaymentContext: true);
        int totalReads = 0;
        int nestedLogoutCalls = 0;
        int nestedEntryCalls = 0;
        reentrantEntryWindow.ConfigureCashierEntry((_, _, _) => true, () =>
        {
            totalReads++;
            if (totalReads == 1)
            {
                if (reentrantEntryWindow.ShowCashierEntry()) nestedEntryCalls++;
                if (reentrantEntryWindow.EndFinancialSession()) nestedLogoutCalls++;
            }
            return null;
        }, () => { nestedLogoutCalls++; return true; });
        Check(!reentrantEntryWindow.ShowCashierEntry() && totalReads == 1 &&
            nestedEntryCalls == 0 && nestedLogoutCalls == 0 &&
            reentrantEntryWindow.DataContext is CatalogueViewModel reentrantVm &&
            reentrantVm.FinancialSessionActive && reentrantVm.PaymentContext == financialContext,
            "trusted total callback cannot reenter cashier login or logout");
        reentrantEntryWindow.Close();

        // WPF DataGrid cell templates may raise a double-click from a Run
        // (FrameworkContentElement), which is not a Visual. Parent traversal
        // must not throw and must reach its containing TextBlock.
        var cellText = new System.Windows.Controls.TextBlock();
        var cellRun = new System.Windows.Documents.Run("product");
        cellText.Inlines.Add(cellRun);
        var parentMethod = typeof(Hanouty.Desktop.Wpf.MainWindow).GetMethod(
            "GetInteractionParent", System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);
        Check(parentMethod is not null && ReferenceEquals(parentMethod.Invoke(null,
            new object[] { cellRun }), cellText),
            "catalogue double-click must traverse WPF content-element parent safely");

        // Real catalogue list interaction uses the existing production selection
        // seam; double-click must not bypass cashier logout or select a stale row.
        var listSelection = new RecordingSelection();
        var listWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            listSelection, new RecordingSubmission(), financialContext,
            requireFreshPaymentContext: true);
        var listVm = (CatalogueViewModel)listWindow.DataContext;
        // Same real STA MainWindow VM used by cashier entry: Host returning true
        // cannot authorize a mismatched cashier, tender or expired session.
        var authorizedEntry = typeof(Hanouty.Desktop.Wpf.MainWindow).GetMethod(
            "IsAuthorizedEntry", System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);
        Check(authorizedEntry is not null, "cashier entry post-Host authorization guard exists");
        bool EntryAuthorized(string cashier, decimal tender) => (bool)authorizedEntry!.Invoke(null,
            new object[] { listVm, cashier, tender })!;
        Check(EntryAuthorized(financialContext.CashierId, financialContext.TenderedAmount),
            "real WPF window accepts exact live authorized cashier context");
        Check(!EntryAuthorized("other-cashier", financialContext.TenderedAmount) &&
            !EntryAuthorized(financialContext.CashierId, financialContext.TenderedAmount + 1m),
            "cashier entry rejects Host-claimed success with mismatched identity or tender");
        var authorizedRegister = typeof(Hanouty.Desktop.Wpf.MainWindow).GetMethod(
            "IsAuthorizedRegister", System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);
        Check(authorizedRegister is not null, "WPF Host register/currency guard exists");
        bool RegisterAuthorized(string register) => (bool)authorizedRegister!.Invoke(null,
            new object[] { listVm, register })!;
        Check(RegisterAuthorized(financialContext.RegisterId) &&
            !RegisterAuthorized("different-register") &&
            !RegisterAuthorized(""),
            "Host login must bind exact authorized register, not cashier and tender alone");
        var pinGuard = typeof(Hanouty.Desktop.Wpf.MainWindow).GetMethod(
            "IsPinContextStillValid", System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Static);
        Check(pinGuard is not null, "PIN context guard must be testable on STA");
        bool PinStable(bool uncertain, bool busy) => (bool)pinGuard!.Invoke(null,
            new object?[] { listVm, listVm.PaymentContext, listVm.PendingOperationId, uncertain, busy })!;
        Check(PinStable(false, false), "idle review PIN context remains valid");
        Check(!PinStable(false, true), "PIN context rejects busy transition after prompt");
        var oldPayment = listVm.PaymentContext;
        listVm.PaymentContext = new CashierPaymentContext(
            financialContext.CashierId, financialContext.RegisterId, "EUR", "Cash",
            financialContext.TenderedAmount);
        Check(!RegisterAuthorized(financialContext.RegisterId),
            "MAD cashier must reject a Host context with different currency");
        Check(!EntryAuthorized(financialContext.CashierId, financialContext.TenderedAmount),
            "cashier entry cannot accept EUR context even when cashier and tender match");
        listVm.PaymentContext = new CashierPaymentContext(
            financialContext.CashierId, financialContext.RegisterId, "MAD", "Credit",
            financialContext.TenderedAmount);
        Check(!EntryAuthorized(financialContext.CashierId, financialContext.TenderedAmount),
            "cashier entry cannot accept non-cash Host tender for cash payment");
        listVm.PaymentContext = oldPayment;
        Check(!listWindow.SelectHighlightedProduct() && listSelection.Selected.Count == 0,
            "empty catalogue highlight cannot stage an article");
        listVm.SelectedProduct = items[0];
        Check(listWindow.SelectHighlightedProduct() && listSelection.Selected.Count == 1 &&
            listSelection.Selected[0] == items[0],
            "highlighted catalogue article uses real injected Host selection port");
        listVm.FinancialSessionActive = false;
        Check(!EntryAuthorized(financialContext.CashierId, financialContext.TenderedAmount),
            "expired cashier session rejects even an otherwise matching Host quote");
        Check(!listWindow.SelectHighlightedProduct() && listSelection.Selected.Count == 1 &&
            listVm.SelectedProduct is null,
            "logged-out double-click cannot stage stale catalogue article");
        listWindow.Close();

        // A command dispatch is not a successful sale-basket selection: a real
        // Host can reject a stale article, and a lost acknowledgement must lock.
        var deniedWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new DenyingSelection(), new RecordingSubmission(), financialContext);
        var deniedVm = (CatalogueViewModel)deniedWindow.DataContext;
        deniedVm.SelectedProduct = deniedVm.VisibleProducts[0];
        Check(!deniedWindow.SelectHighlightedProduct() &&
            deniedVm.ScanFeedback == "Selection rejected" && !deniedVm.CheckoutUncertain,
            "rejected production selection must never appear acknowledged in WPF");
        deniedWindow.Close();
        var lostAckWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new ThrowingSelection(), new RecordingSubmission(), financialContext);
        var lostAckVm = (CatalogueViewModel)lostAckWindow.DataContext;
        lostAckVm.SelectedProduct = lostAckVm.VisibleProducts[0];
        Check(!lostAckWindow.SelectHighlightedProduct() && lostAckVm.CheckoutUncertain &&
            !lostAckVm.CanSelectProduct && !lostAckWindow.SelectHighlightedProduct(),
            "lost selection acknowledgement must lock WPF and forbid blind replay");
        lostAckWindow.Close();

        // A production Host can fail during durable review. The real WPF
        // window must not crash, unlock Unknown, or discard the operation ID.
        var throwingReviewPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
        var throwingReviewJournal = new RecordingReconciliation { Result = CheckoutResolution.Persisted };
        var throwingReviewWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new ReconciledSubmission(throwingReviewPort, throwingReviewJournal),
            financialContext, requireFreshPaymentContext: true);
        var throwingReviewVm = (CatalogueViewModel)throwingReviewWindow.DataContext;
        throwingReviewVm.CommitCheckout();
        var throwingReviewId = throwingReviewVm.PendingOperationId;
        throwingReviewVm.ReconcileCheckout();
        throwingReviewWindow.ConfigureReviewedCheckout((_, _, _) =>
            throw new System.IO.IOException("durable journal temporarily unavailable"));
        Check(!throwingReviewWindow.ReviewResolvedCheckout(() => "transient") &&
            throwingReviewVm.CheckoutUncertain && throwingReviewVm.PendingOperationId == throwingReviewId &&
            !throwingReviewVm.CanCommit && throwingReviewPort.Ids.Count == 1,
            "Host review exception must retain durable lock and prevent duplicate cash sale");
        throwingReviewWindow.Close();

        // Actual WPF window: an unresolved journal must never invoke the Host
        // review authority or read a transient PIN, and cannot release the operation.
        var unresolvedPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
        var unresolvedJournal = new RecordingReconciliation { Result = CheckoutResolution.Unknown };
        var unresolvedWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new ReconciledSubmission(unresolvedPort, unresolvedJournal), financialContext);
        var unresolvedVm = (CatalogueViewModel)unresolvedWindow.DataContext;
        unresolvedVm.CommitCheckout();
        var unresolvedId = unresolvedVm.PendingOperationId;
        unresolvedVm.ReconcileCheckout();
        int unresolvedAuthority = 0;
        int unresolvedPinReads = 0;
        unresolvedWindow.ConfigureReviewedCheckout((_, _, _) => { unresolvedAuthority++; return true; });
        Check(!unresolvedWindow.ReviewResolvedCheckout(() => { unresolvedPinReads++; return "PIN"; }) &&
            unresolvedAuthority == 0 && unresolvedPinReads == 0 && unresolvedVm.CheckoutUncertain &&
            unresolvedVm.PendingOperationId == unresolvedId && unresolvedPort.Ids.Count == 1,
            "real window must not authorize Unknown outcome, read PIN, reset or repost");
        unresolvedWindow.Close();

        // Durable Absent is reviewable only after explicit fresh Host authorization.
        var absentPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
        var absentJournal = new RecordingReconciliation { Result = CheckoutResolution.Absent };
        var absentWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new ReconciledSubmission(absentPort, absentJournal), financialContext,
            requireFreshPaymentContext: true);
        var absentVm = (CatalogueViewModel)absentWindow.DataContext;
        absentVm.CommitCheckout();
        var absentId = absentVm.PendingOperationId;
        absentVm.ReconcileCheckout();
        int absentAuthority = 0;
        absentWindow.ConfigureReviewedCheckout((id, outcome, readPin) =>
        {
            absentAuthority++;
            Check(id == absentId && outcome == CheckoutResolution.Absent,
                "Host must receive exact Absent journal identity");
            return absentAuthority > 1 && readPin() == "fresh";
        });
        Check(!absentWindow.ReviewResolvedCheckout(() => "cancel") && absentVm.CheckoutUncertain &&
            absentVm.PendingOperationId == absentId && absentPort.Ids.Count == 1,
            "denied Absent review must retain lock and original operation");
        Check(absentWindow.ReviewResolvedCheckout(() => "fresh") && absentAuthority == 2 &&
            !absentVm.CheckoutUncertain && absentVm.PendingOperationId is null &&
            absentVm.PaymentContext is null && absentPort.Ids.Count == 1 && !absentVm.CanCommit,
            "authorized Absent reset must expire old tender without posting or enabling checkout");
        absentVm.PaymentContext = financialContext;
        Check(absentVm.CanCommit, "fresh host-issued context is required for next checkout");
        absentWindow.Close();

        // Real MainWindow: logout after an acknowledged sale must expire the
        // previous cashier's tender, even if the old context is still well formed.
        var logoutPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Committed };
        var logoutWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), logoutPort, financialContext, requireFreshPaymentContext: true);
        var logoutWindowVm = (CatalogueViewModel)logoutWindow.DataContext;
        int logoutHostCalls = 0;
        logoutWindow.ConfigureCashierEntry((_, _, _) => true, () => 10m,
            () => { logoutHostCalls++; logoutWindowVm.FinancialSessionActive = false; return true; });
        Check(logoutWindow.EndFinancialSession() && logoutHostCalls == 1 &&
            !logoutWindowVm.FinancialSessionActive && logoutWindowVm.PaymentContext is null &&
            !logoutWindowVm.CanCommit, "real window logout must revoke the previous tender");
        logoutWindowVm.CommitCommand.Execute(null);
        Check(logoutPort.Ids.Count == 0 && logoutWindowVm.PendingOperationId is null,
            "real window logged-out command must not post or allocate an operation");
        logoutWindowVm.FinancialSessionActive = true;
        logoutWindowVm.CommitCommand.Execute(null);
        Check(logoutPort.Ids.Count == 0 && !logoutWindowVm.CanCommit,
            "re-login alone cannot reuse the expired cashier payment context");
        logoutWindowVm.PaymentContext = new CashierPaymentContext("cashier", "register", "MAD", "cash", 10m);
        logoutWindowVm.CommitCommand.Execute(null);
        Check(logoutPort.Ids.Count == 1 && logoutWindowVm.PendingOperationId is null,
            "fresh authorized context restores exactly one acknowledged checkout");
        logoutWindow.Close();

        // Host logout can synchronously discover an unresolved durable sale.
        // In that case the ViewModel rejects session revocation; WPF must not
        // falsely acknowledge logout or erase the pending operation identity.
        var unresolvedLogoutPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
        var unresolvedLogoutWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), unresolvedLogoutPort, financialContext,
            requireFreshPaymentContext: true);
        var unresolvedLogoutVm = (CatalogueViewModel)unresolvedLogoutWindow.DataContext;
        unresolvedLogoutWindow.ConfigureCashierEntry((_, _, _) => true, () => 10m,
            () => { unresolvedLogoutVm.CommitCheckout(); return true; });
        Check(!unresolvedLogoutWindow.EndFinancialSession() &&
            unresolvedLogoutVm.FinancialSessionActive && unresolvedLogoutVm.CheckoutUncertain &&
            unresolvedLogoutVm.PendingOperationId is not null && unresolvedLogoutPort.Ids.Count == 1,
            "logout must not claim success when Host callback exposes unresolved durable checkout");
        unresolvedLogoutWindow.Close();

        // A synchronous Host logout callback must not reenter logout, sign-in
        // or cashier review before the authoritative revocation is complete.
        var reentrantLogoutWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new RecordingSubmission(), financialContext,
            requireFreshPaymentContext: true);
        var reentrantLogoutVm = (CatalogueViewModel)reentrantLogoutWindow.DataContext;
        int reentrantLogoutCalls = 0;
        reentrantLogoutWindow.ConfigureCashierEntry((_, _, _) => true, () => 10m,
            () => {
                reentrantLogoutCalls++;
                Check(!reentrantLogoutWindow.EndFinancialSession() &&
                    !reentrantLogoutWindow.ShowCashierEntry() &&
                    !reentrantLogoutWindow.ReviewResolvedCheckout(() => "unused"),
                    "Host logout callback cannot reenter financial session UI");
                return true;
            });
        Check(reentrantLogoutWindow.EndFinancialSession() && reentrantLogoutCalls == 1 &&
            !reentrantLogoutVm.FinancialSessionActive && reentrantLogoutVm.PaymentContext is null,
            "single successful Host logout expires UI session and tender exactly once");
        reentrantLogoutWindow.Close();

        // The production logout callback can fail (offline/session backend error).
        // The actual WPF window must fail closed without throwing or inventing a logout.
        var failedLogoutWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new RecordingSubmission(), financialContext,
            requireFreshPaymentContext: true);
        var failedLogoutVm = (CatalogueViewModel)failedLogoutWindow.DataContext;
        int failedLogoutCalls = 0;
        failedLogoutWindow.ConfigureCashierEntry((_, _, _) => true, () => 10m,
            () => { failedLogoutCalls++; throw new System.IO.IOException("offline"); });
        Check(!failedLogoutWindow.EndFinancialSession() && failedLogoutCalls == 1 &&
            failedLogoutVm.FinancialSessionActive && failedLogoutVm.PaymentContext == financialContext,
            "Host logout exception must not crash WPF or falsely expire the cashier session");
        failedLogoutWindow.Close();

        // Production Host callback may only acknowledge revocation; the WPF
        // window itself must invalidate the previous cashier's tender and row.
        var acknowledgedLogoutSelection = new RecordingSelection();
        var acknowledgedLogoutWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            acknowledgedLogoutSelection, new RecordingSubmission(), financialContext,
            requireFreshPaymentContext: true);
        var acknowledgedLogoutVm = (CatalogueViewModel)acknowledgedLogoutWindow.DataContext;
        acknowledgedLogoutVm.SelectedProduct = items[0];
        int acknowledgedLogoutCalls = 0;
        acknowledgedLogoutWindow.ConfigureCashierEntry((_, _, _) => true, () => 10m,
            () => { acknowledgedLogoutCalls++; return true; });
        Check(acknowledgedLogoutWindow.EndFinancialSession() && acknowledgedLogoutCalls == 1 &&
            !acknowledgedLogoutVm.FinancialSessionActive &&
            acknowledgedLogoutVm.PaymentContext is null &&
            acknowledgedLogoutVm.SelectedProduct is null &&
            !acknowledgedLogoutWindow.SelectHighlightedProduct() &&
            acknowledgedLogoutSelection.Selected.Count == 0 && !acknowledgedLogoutVm.CanCommit,
            "Host-acknowledged logout must revoke WPF tender and stale selection without callback side effects");
        acknowledgedLogoutWindow.Close();

        // A Host denial is not a successful logout, and an unresolved sale must
        // not even invoke the Host logout callback (including on direct calls).
        var deniedLogoutWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new RecordingSubmission(), financialContext,
            requireFreshPaymentContext: true);
        var deniedLogoutVm = (CatalogueViewModel)deniedLogoutWindow.DataContext;
        int deniedLogoutCalls = 0;
        deniedLogoutWindow.ConfigureCashierEntry((_, _, _) => true, () => 10m,
            () => { deniedLogoutCalls++; return false; });
        Check(!deniedLogoutWindow.EndFinancialSession() && deniedLogoutCalls == 1 &&
            deniedLogoutVm.FinancialSessionActive && deniedLogoutVm.PaymentContext == financialContext,
            "Host denial must retain authorized session without reporting logout");
        deniedLogoutWindow.Close();

        var lockedLogoutPort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
        var lockedLogoutWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), lockedLogoutPort, financialContext,
            requireFreshPaymentContext: true);
        var lockedLogoutVm = (CatalogueViewModel)lockedLogoutWindow.DataContext;
        int lockedLogoutCalls = 0;
        lockedLogoutWindow.ConfigureCashierEntry((_, _, _) => true, () => 10m,
            () => { lockedLogoutCalls++; return true; });
        lockedLogoutVm.CommitCheckout();
        var lockedOperation = lockedLogoutVm.PendingOperationId;
        Check(lockedLogoutVm.CheckoutUncertain && !lockedLogoutWindow.EndFinancialSession() &&
            lockedLogoutCalls == 0 && lockedLogoutVm.PendingOperationId == lockedOperation &&
            lockedLogoutPort.Ids.Count == 1,
            "unknown financial outcome blocks real window logout without touching Host or operation");
        lockedLogoutWindow.Close();

        // WPF modal PIN windows pump the dispatcher: a second PIN or session
        // transition must be rejected while the first transient PIN is open.
        var modalPinWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new RecordingSubmission(), financialContext,
            requireFreshPaymentContext: true);
        var pinFlag = typeof(Hanouty.Desktop.Wpf.MainWindow).GetField("_pinOpen",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)!;
        int modalLogoutCalls = 0;
        int modalTotalReads = 0;
        modalPinWindow.ConfigureCashierEntry((_, _, _) => true,
            () => { modalTotalReads++; return null; },
            () => { modalLogoutCalls++; return true; });
        pinFlag.SetValue(modalPinWindow, true);
        Check(modalPinWindow.PromptCashierPin(financialContext.CashierId) == "" &&
            !modalPinWindow.ShowCashierEntry() && !modalPinWindow.EndFinancialSession() &&
            modalLogoutCalls == 0 && modalTotalReads == 0 &&
            ((CatalogueViewModel)modalPinWindow.DataContext).FinancialSessionActive,
            "open transient PIN dialog must reject nested PIN/login/logout without Host calls");
        pinFlag.SetValue(modalPinWindow, false);
        modalPinWindow.Close();

        // Host PIN rejection and exceptions must never consume the durable
        // review identity. PIN is supplied lazily and is never retained by WPF.
        var reviewFailurePort = new RecordingSubmission { Result = CheckoutSubmissionResult.Unknown };
        var reviewFailureJournal = new RecordingReconciliation { Result = CheckoutResolution.Persisted };
        var reviewFailureWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
            new RecordingSelection(), new ReconciledSubmission(reviewFailurePort, reviewFailureJournal),
            financialContext, requireFreshPaymentContext: true);
        var reviewFailureVm = (CatalogueViewModel)reviewFailureWindow.DataContext;
        reviewFailureVm.CommitCheckout();
        reviewFailureVm.ReconcileCheckout();
        var reviewFailureId = reviewFailureVm.PendingOperationId;
        int reviewFailureHostCalls = 0;
        int reviewFailurePinReads = 0;
        reviewFailureWindow.ConfigureReviewedCheckout((id, outcome, readPin) =>
        {
            reviewFailureHostCalls++;
            Check(id == reviewFailureId && outcome == CheckoutResolution.Persisted,
                "review failure must preserve exact durable operation and result");
            if (reviewFailureHostCalls == 1) return false; // Host rejects PIN without reading it.
            Check(readPin() == "transient-pin", "PIN callback is evaluated only by Host");
            if (reviewFailureHostCalls == 2) throw new System.IO.IOException("host unavailable");
            return true;
        });
        Func<string> transientPin = () => { reviewFailurePinReads++; return "transient-pin"; };
        Check(!reviewFailureWindow.ReviewResolvedCheckout(transientPin) &&
            reviewFailurePinReads == 0 && reviewFailureVm.CheckoutUncertain &&
            reviewFailureVm.PendingOperationId == reviewFailureId,
            "Host PIN rejection must not read PIN or unlock checkout");
        Check(!reviewFailureWindow.ReviewResolvedCheckout(transientPin) &&
            reviewFailurePinReads == 1 && reviewFailureVm.CheckoutUncertain &&
            reviewFailureVm.PendingOperationId == reviewFailureId,
            "Host exception after transient PIN read must keep operation locked");
        Check(reviewFailureWindow.ReviewResolvedCheckout(transientPin) &&
            reviewFailureHostCalls == 3 && reviewFailurePinReads == 2 &&
            !reviewFailureVm.CheckoutUncertain && reviewFailureVm.PendingOperationId is null &&
            reviewFailurePort.Ids.Count == 1,
            "fresh Host authorization alone unlocks reviewed result without reposting");
        reviewFailureWindow.Close();
    }
    catch (Exception ex) { windowReviewError = ex; }
});
reviewThread.SetApartmentState(System.Threading.ApartmentState.STA);
reviewThread.Start();
reviewThread.Join();
if (windowReviewError is not null) throw new Exception("MainWindow reviewed reset regression", windowReviewError);

// Actual STA window interactions: original-sale lookup is disabled without a
// registered Host, respects cashier session, and survives RTL layout switching.
var originalWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
    new RecordingSelection(), new RecordingSubmission(), financialContext,
    requireFreshPaymentContext: true);
Check(!originalWindow.SearchOriginalSales("receipt-1"),
    "unregistered Host lookup must fail closed in real window");
// WPF modal PIN/session transitions must not permit receipt evidence changes.
// This exercises the real window guard without displaying a blocking modal dialog.
var modalPinField = typeof(Hanouty.Desktop.Wpf.MainWindow).GetField("_pinOpen",
    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
    ?? throw new Exception("WPF modal PIN guard missing");
modalPinField.SetValue(originalWindow, true);
Check(!originalWindow.SearchOriginalSales("receipt-1") &&
    originalWindow.OriginalSaleResults.Items.Count == 0,
    "PIN modal blocks original-sale lookup before Host registration");
modalPinField.SetValue(originalWindow, false);
originalWindow.ConfigureOriginalSaleLookup(new OriginalSaleLookupFixture());
var originalWindowVm = (CatalogueViewModel)originalWindow.DataContext;
modalPinField.SetValue(originalWindow, true);
Check(!originalWindow.SearchOriginalSales("receipt-1"),
    "registered Host lookup remains blocked during transient PIN prompt");
modalPinField.SetValue(originalWindow, false);
Check(originalWindow.SearchOriginalSales("receipt-1"),
    "authenticated window must query registered persisted-sale Host reader");
var persistedRow = (OriginalSaleCandidate)originalWindow.OriginalSaleResults.Items[0];
originalWindow.OriginalSaleResults.SelectedItem = persistedRow;
Check(originalWindow.SelectOriginalSale(persistedRow),
    "persisted original-sale row is selectable for read-only review");
modalPinField.SetValue(originalWindow, true);
Check(!originalWindow.SelectOriginalSale(persistedRow) &&
    originalWindow.OriginalSaleResults.Items.Count == 1,
    "PIN modal denies original-sale selection without discarding trusted receipt evidence");
modalPinField.SetValue(originalWindow, false);
Check(originalWindow.SelectOriginalSale(persistedRow),
    "after PIN modal closes the same persisted evidence can be reviewed");
// WPF modal dispatcher reentrancy: cashier entry, durable review and logout
// must also refuse the same persisted row without silently clearing evidence.
foreach (var modalFieldName in new[] { "_cashierEntryOpen", "_reviewOpen", "_logoutOpen" })
{
    var modalField = typeof(Hanouty.Desktop.Wpf.MainWindow).GetField(modalFieldName,
        System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)!;
    modalField.SetValue(originalWindow, true);
    try
    {
        Check(!originalWindow.SelectOriginalSale(persistedRow) &&
            originalWindow.OriginalSaleResults.Items.Count == 1,
            "financial modal boundary must block original-sale selection: " + modalFieldName);
    }
    finally { modalField.SetValue(originalWindow, false); }
    Check(originalWindow.SelectOriginalSale(persistedRow),
        "receipt selection resumes only after modal exits: " + modalFieldName);
}

// Real STA TextBox event: incomplete quantity input must never inherit a
// previously reviewed return amount after a keyboard edit.
originalWindow.ReturnQuantity.Text = "1.";
Check(!originalWindow.ReviewReturnQuantity(originalWindow.ReturnQuantity.Text) &&
    !originalWindow.ConfirmReturnDraft(),
    "unfinished decimal separator must not confirm a return in real WPF window");
originalWindow.ReturnQuantity.Text = "0,250";
Check(originalWindow.ReviewReturnQuantity(originalWindow.ReturnQuantity.Text) &&
    originalWindow.ConfirmReturnDraft(),
    "Moroccan comma decimal quantity can be reviewed explicitly in STA window");
originalWindow.ReturnQuantity.Text = "0,2500";
Check(!originalWindow.ConfirmReturnDraft() &&
    !originalWindow.ReviewReturnQuantity(originalWindow.ReturnQuantity.Text),
    "editing reviewed quantity to overprecision revokes confirmation in STA window");

// Actual STA ListBox interaction: changing highlighted receipt invalidates the
// previously reviewed quantity even before a second Select button click.
Check(originalWindow.ReviewReturnQuantity("1") && originalWindow.ConfirmReturnDraft(),
    "trusted receipt can prepare a non-posting return draft");
originalWindow.OriginalSaleResults.SelectedItem = null;
Check(!originalWindow.ConfirmReturnDraft() &&
    !originalWindow.ReviewReturnQuantity("1"),
    "clearing highlighted receipt revokes previously confirmed return");
originalWindow.OriginalSaleResults.SelectedItem = persistedRow;
Check(originalWindow.SelectOriginalSale(persistedRow) &&
    originalWindow.ReviewReturnQuantity("1"),
    "fresh explicit receipt selection restores quantity review");
modalPinField.SetValue(originalWindow, true);
Check(!originalWindow.ConfirmReturnDraft() && !originalWindow.ReviewReturnQuantity("1"),
    "transient PIN modal blocks return review and confirmation");
modalPinField.SetValue(originalWindow, false);

// A rejected cash checkout still changes financial state. The same real
// MainWindow must revoke an already reviewed original-sale return draft.
Check(originalWindow.SearchOriginalSales("receipt-1"),
    "return evidence available before checkout outcome");
persistedRow = (OriginalSaleCandidate)originalWindow.OriginalSaleResults.Items[0];
originalWindow.OriginalSaleResults.SelectedItem = persistedRow;
Check(originalWindow.SelectOriginalSale(persistedRow) &&
    originalWindow.ReviewReturnQuantity("1") && originalWindow.ConfirmReturnDraft(),
    "original sale and quantity reviewed before checkout state transition");
originalWindowVm.CommitCheckout(); // no contextual port: fail closed, not posted
Check(originalWindow.OriginalSaleResults.Items.Count == 0 &&
    !originalWindow.ConfirmReturnDraft() &&
    !originalWindow.SelectOriginalSale(persistedRow),
    "cash checkout rejection revokes previously reviewed return evidence");

// Actual WPF TextChanged must invalidate the previous receipt evidence.
originalWindow.OriginalSaleSearch.Text = "different-receipt";
Check(originalWindow.OriginalSaleResults.Items.Count == 0 &&
    !originalWindow.SelectOriginalSale(persistedRow),
    "editing original receipt query invalidates stale Host rows");
Check(originalWindow.SearchOriginalSales("receipt-1"),
    "fresh explicit Host lookup restores only newly queried evidence");
persistedRow = (OriginalSaleCandidate)originalWindow.OriginalSaleResults.Items[0];
originalWindow.OriginalSaleResults.SelectedItem = persistedRow;
Check(originalWindow.SelectOriginalSale(persistedRow),
    "new persisted receipt evidence can be selected after query edit");
originalWindowVm.PaymentContext = null;
Check(originalWindow.OriginalSaleResults.Items.Count == 0 &&
    !originalWindow.SelectOriginalSale(persistedRow),
    "Host-revoked payment context invalidates original-sale selection without a refund");
originalWindowVm.PaymentContext = financialContext;
Check(originalWindow.SearchOriginalSales("receipt-1"),
    "fresh authorized cashier context can search again");
var replacedContext = new CashierPaymentContext("cashier-2", "register-2", "MAD", "Cash", 100m);
originalWindowVm.PaymentContext = replacedContext;
Check(originalWindow.OriginalSaleResults.Items.Count == 0 &&
    !originalWindow.SelectOriginalSale(persistedRow),
    "direct valid cashier replacement invalidates persisted original receipt rows");
Check(originalWindow.SearchOriginalSales("receipt-1"),
    "new cashier must explicitly query authoritative Host again");
originalWindowVm.IsRightToLeft = true;
Check(originalWindow.FlowDirection == System.Windows.FlowDirection.RightToLeft ||
    originalWindowVm.LayoutDirection == System.Windows.FlowDirection.RightToLeft,
    "RTL selection path preserves layout direction");
originalWindowVm.FinancialSessionActive = false;
Check(!originalWindow.SearchOriginalSales("receipt-1"),
    "logged-out cashier cannot query original sale");
originalWindow.Close();

// Host read can reenter the WPF dispatcher: a nested lookup must be denied,
// and results must be discarded if the cashier logs out during the callback.
var reentrantWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
    new RecordingSelection(), new RecordingSubmission(), financialContext,
    requireFreshPaymentContext: true);
var reentrantVm = (CatalogueViewModel)reentrantWindow.DataContext;
var nestedBlocked = false;
var reentrantReader = new CallbackOriginalSaleLookup(() =>
{
    nestedBlocked = !reentrantWindow.SearchOriginalSales("nested");
    reentrantVm.FinancialSessionActive = false;
});
reentrantWindow.ConfigureOriginalSaleLookup(reentrantReader);
Check(!reentrantWindow.SearchOriginalSales("receipt-1") && nestedBlocked &&
    reentrantReader.Calls == 1 &&
    reentrantWindow.OriginalSaleResults.Items.Count == 0,
    "reentrant Host read must not expose stale original sale after logout");
reentrantWindow.Close();

// A receipt edit while the authoritative reader is still executing must
// invalidate that in-flight query, even if the cashier session stays valid.
var editedDuringReadWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
    new RecordingSelection(), new RecordingSubmission(), financialContext,
    requireFreshPaymentContext: true);
editedDuringReadWindow.OriginalSaleSearch.Text = "receipt-1";
var editedDuringReadHost = new CallbackOriginalSaleLookup(() =>
    editedDuringReadWindow.OriginalSaleSearch.Text = "receipt-2");
editedDuringReadWindow.ConfigureOriginalSaleLookup(editedDuringReadHost);
Check(!editedDuringReadWindow.SearchOriginalSales("receipt-1") &&
    editedDuringReadHost.Calls == 1 &&
    editedDuringReadWindow.OriginalSaleResults.Items.Count == 0,
    "editing receipt during Host read must reject stale result on unchanged cashier session");
Check(editedDuringReadWindow.SearchOriginalSales("receipt-2") &&
    editedDuringReadWindow.OriginalSaleResults.Items.Count == 1,
    "explicit new receipt query can display fresh persisted Host evidence");
editedDuringReadWindow.Close();

// A Host reader pumping the dispatcher cannot switch cashier context while its
// persisted-sale result is still in flight. No extra Host/logout authority is minted.
var lockedWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
    new RecordingSelection(), new RecordingSubmission(), financialContext,
    requireFreshPaymentContext: true);
var lockedVm = (CatalogueViewModel)lockedWindow.DataContext;
var logoutCallsDuringLookup = 0;
lockedWindow.ConfigureCashierEntry((_, _, _) => true, () => 0m,
    () => { logoutCallsDuringLookup++; return true; });
var deniedDuringLookup = false;
lockedWindow.ConfigureOriginalSaleLookup(new CallbackOriginalSaleLookup(() =>
{
    deniedDuringLookup = !lockedWindow.EndFinancialSession() &&
        !lockedWindow.SelectOriginalSale(new OriginalSaleCandidate("sale-1", "receipt-1", 10m));
}));
Check(lockedWindow.SearchOriginalSales("receipt-1") && deniedDuringLookup &&
    logoutCallsDuringLookup == 0 && lockedVm.FinancialSessionActive,
    "reentrant original-sale reader cannot logout or select during in-flight lookup");
lockedWindow.Close();

// A reentrant Host callback can replace the payment context with a NEW object
// carrying the SAME cashier identity. Results belong to the exact authorization,
// not merely the cashier name, and must be discarded on context rotation.
var rotatedWindow = new Hanouty.Desktop.Wpf.MainWindow(new Reader(items),
    new RecordingSelection(), new RecordingSubmission(), financialContext,
    requireFreshPaymentContext: true);
var rotatedVm = (CatalogueViewModel)rotatedWindow.DataContext;
rotatedWindow.ConfigureOriginalSaleLookup(new CallbackOriginalSaleLookup(() =>
    rotatedVm.PaymentContext = new CashierPaymentContext("cashier-1", "register-1", "MAD", "Cash", 100m)));
Check(!rotatedWindow.SearchOriginalSales("receipt-1") &&
    rotatedWindow.OriginalSaleResults.Items.Count == 0,
    "same cashier but new authorization context must reject stale persisted-sale readback");
rotatedWindow.Close();

// Read-only original sale selection: authoritative Host lookup only, no financial
// command, duplicate persisted IDs fail closed and stale candidates cannot be reused.
var originalLookup = new OriginalSaleLookupFixture();
var originalSelection = new OriginalSaleSelection(originalLookup);
Check(originalSelection.Search("").Count == 0 && originalLookup.Calls == 0,
    "empty original receipt query must not call Host");
var originalRows = originalSelection.Search("  receipt-1  ");
Check(originalLookup.LastQuery == "receipt-1" && originalRows.Count == 1 &&
    originalSelection.Select(originalRows[0], originalRows) &&
    originalSelection.Selected == originalRows[0],
    "persisted original sale selected from trusted Host snapshot");
Check(!originalSelection.Select(new OriginalSaleCandidate("sale-1", "receipt-1", 10m), originalRows) &&
    originalSelection.Selected is null,
    "detached or forged original-sale row cannot be selected");
originalSelection.Select(originalRows[0], originalRows);
originalSelection.Search("");
Check(originalSelection.Selected is null, "new search clears stale original-sale selection");
originalLookup.Duplicate = true;
try { originalSelection.Search("receipt-1"); throw new Exception("duplicate sale ID accepted"); }
catch (InvalidOperationException) { }

var returnDraft = new ReturnReviewDraft();
Check(!returnDraft.SetQuantity("1") && !returnDraft.Confirm(true, false),
    "return requires persisted original sale");
returnDraft.SetOriginalSale("sale-verified");
Check(!returnDraft.SetQuantity("0") && !returnDraft.SetQuantity("-1") &&
    !returnDraft.SetQuantity("1.0001") && !returnDraft.SetQuantity("1.0000") &&
    !returnDraft.SetQuantity("1.2500") && !returnDraft.SetQuantity("1,2.5") &&
    !returnDraft.SetQuantity("1,2500") && !returnDraft.SetQuantity("1.") &&
    !returnDraft.SetQuantity("1,") && !returnDraft.SetQuantity(".5") &&
    !returnDraft.SetQuantity("1 000") && !returnDraft.SetQuantity("1..5") &&
    !returnDraft.SetQuantity("+1") && returnDraft.SetQuantity("0,250") &&
    returnDraft.SetQuantity("1,250") &&
    returnDraft.Quantity == 1.250m && returnDraft.SetQuantity("1.250"),
    "return quantity requires positive, bounded precision");
Check(!returnDraft.Confirm(false, false) && !returnDraft.Confirm(true, true) &&
    returnDraft.Confirm(true, false), "return confirmation requires active cashier and no Unknown");
returnDraft.ClearQuantity("Quantity edited");
Check(!returnDraft.Confirmed && returnDraft.Quantity == 0m &&
    !returnDraft.Confirm(true, false) && returnDraft.OriginalSaleId == "sale-verified",
    "editing confirmed quantity revokes amount without forging a new original sale");
returnDraft.Invalidate("Cashier changed");
Check(!returnDraft.Confirmed && returnDraft.OriginalSaleId is null &&
    returnDraft.Quantity == 0m, "cashier transition revokes confirmed return draft");

Console.WriteLine("PASS: WPF MVVM catalogue, image, scanner, duplicate, selection and fail-closed regression");
}

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

sealed class DenyingSelection : IProductSelection
{
    public bool Select(ProductSummary product) => false;
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

// Real MainWindow constructor receives one production-style port implementing both
// submission and durable reconciliation; the same object must serve both paths.
sealed class ReconciledSubmission(RecordingSubmission submission, RecordingReconciliation journal)
    : IContextualCheckoutSubmission, ICheckoutOutcomeReconciliation
{
    public CheckoutSubmissionResult Submit(string operationId) => throw new InvalidOperationException("legacy submission forbidden");
    public CheckoutSubmissionResult Submit(string operationId, CashierPaymentContext context) =>
        submission.Submit(operationId, context);
    public CheckoutResolution Reconcile(string operationId) => journal.Reconcile(operationId);
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
    public bool Return { get; set; }
    public bool Credit { get; set; }
    public AuthorizedCheckoutRequest Prepare(string operationId, CashierPaymentContext context)
    {
        Calls++;
        return new AuthorizedCheckoutRequest(operationId, Mismatch ? "wrong-cashier" : context.CashierId,
            context.CurrencyCode, Return, new[] { new CheckoutBatchLine("article-1", 1) },
            new[] { new CheckoutPayment(Credit ? CheckoutPaymentKind.Credit : CheckoutPaymentKind.Cash, context.TenderedAmount) }, 100m);
    }
}

sealed class SessionFinancialSubmission : ICheckoutSubmission, ICheckoutOutcomeReconciliation
{
    public List<string> Ids { get; } = new();
    public List<string> Reconciled { get; } = new();
    public CheckoutSubmissionResult Submit(string operationId)
    {
        Ids.Add(operationId);
        return CheckoutSubmissionResult.Committed;
    }
    public CheckoutResolution Reconcile(string operationId)
    {
        Reconciled.Add(operationId);
        return Ids.Contains(operationId) ? CheckoutResolution.Persisted : CheckoutResolution.Absent;
    }
}

sealed class OriginalSaleLookupFixture : IOriginalSaleLookup
{
    public int Calls { get; private set; }
    public string? LastQuery { get; private set; }
    public bool Duplicate { get; set; }
    public IReadOnlyList<OriginalSaleCandidate> FindPersistedSales(string receiptSearch)
    {
        Calls++;
        LastQuery = receiptSearch;
        var row = new OriginalSaleCandidate("sale-1", "receipt-1", 10m);
        return Duplicate ? new[] { row, row } : new[] { row };
    }
}

sealed class CallbackOriginalSaleLookup(Action callback) : IOriginalSaleLookup
{
    public int Calls { get; private set; }
    public IReadOnlyList<OriginalSaleCandidate> FindPersistedSales(string receiptSearch)
    {
        Calls++;
        callback();
        return new[] { new OriginalSaleCandidate("persisted-1", receiptSearch, 25m) };
    }
}
