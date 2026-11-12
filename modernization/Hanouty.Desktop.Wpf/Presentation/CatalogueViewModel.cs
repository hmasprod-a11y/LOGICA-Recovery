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
    public bool CatalogueAvailable { get => _catalogueAvailable; private set { _catalogueAvailable = value; OnPropertyChanged(); OnPropertyChanged(nameof(CanSelectProduct)); OnPropertyChanged(nameof(CanCommit)); } }
    private string _searchText = "";
    private ProductSummary? _selectedProduct;
    private string _scannerText = "";
    private string _scanFeedback = "";
    private bool _checkoutUncertain;
    public bool CheckoutUncertain { get => _checkoutUncertain; private set { if (_checkoutUncertain == value) return; _checkoutUncertain = value; OnPropertyChanged(); OnPropertyChanged(nameof(CanSelectProduct)); OnPropertyChanged(nameof(CanCommit)); OnPropertyChanged(nameof(CanReviewResolvedCheckout)); } }
    private readonly IProductSelection _selection;
    private bool _selectionInFlight;
    public bool CheckoutBusy => _selectionInFlight;
    public bool RequireFreshPaymentContext { get; init; }
    private bool _financialSessionActive = true;
    public bool FinancialSessionActive {
        get => _financialSessionActive;
        set {
            if (_selectionInFlight || CheckoutUncertain) return;
            _financialSessionActive = value;
            // A fresh-session host must reissue the authorized payment context.
            // Logging out must not leave a previously authorized tender reusable on login.
            if (!value)
            {
                ClearConsumedPaymentContext();
                // Logout invalidates the selection/variant choice from the old cashier.
                // Never allow a re-login to submit a previously staged article.
                _selectedProduct = null;
                OnPropertyChanged(nameof(SelectedProduct));
                BarcodeCandidates = Array.Empty<ProductSummary>();
                OnPropertyChanged(nameof(BarcodeCandidates));
                OnPropertyChanged(nameof(HasBarcodeAmbiguity));
                _scannerText = "";
                OnPropertyChanged(nameof(ScannerText));
            }
            OnPropertyChanged();
            OnPropertyChanged(nameof(CanCommit));
            OnPropertyChanged(nameof(CanSelectProduct));
        }
    }
    private void ClearConsumedPaymentContext()
    {
        if (!RequireFreshPaymentContext) return;
        _paymentContext = null;
        OnPropertyChanged(nameof(PaymentContext));
        OnPropertyChanged(nameof(CanCommit));
    }
    private readonly ICheckoutSubmission? _submission;
    private string? _pendingOperationId;
    private string _commitFeedback = "Checkout submission unavailable";
    private CashierPaymentContext? _paymentContext;
    public CashierPaymentContext? PaymentContext { get => _paymentContext; set { if (_selectionInFlight || CheckoutUncertain) return; _paymentContext = value; OnPropertyChanged(); OnPropertyChanged(nameof(CanCommit)); } }
    public string? PendingOperationId => _pendingOperationId;
    private CheckoutResolution _reviewedResolution = CheckoutResolution.Unknown;
    // A durable result is evidence for a cashier review, never permission to retry.
    public CheckoutResolution ReviewedResolution { get => _reviewedResolution; private set { _reviewedResolution = value; OnPropertyChanged(); OnPropertyChanged(nameof(CanReviewResolvedCheckout)); } }
    public bool CanReviewResolvedCheckout => CheckoutUncertain && ReviewedResolution != CheckoutResolution.Unknown;

    public System.Windows.Input.ICommand ReconcileCommand { get; }
    private readonly ICheckoutOutcomeReconciliation? _reconciliation;
    public string CommitFeedback { get => _commitFeedback; private set { _commitFeedback = value; OnPropertyChanged(); } }
    public bool CanCommit => FinancialSessionActive && _submission is IContextualCheckoutSubmission && PaymentContext?.IsWellFormed == true && CatalogueAvailable && !CheckoutUncertain && !_selectionInFlight;
    public System.Windows.Input.ICommand CommitCommand { get; }
    private readonly IProductImageAvailability _images;

    public CatalogueViewModel(ICatalogueReader reader, IProductSelection selection, IProductImageAvailability? images = null, ICheckoutSubmission? submission = null, ICheckoutOutcomeReconciliation? reconciliation = null)
    {
        ArgumentNullException.ThrowIfNull(reader);
        _reader = reader;
        _all = Array.Empty<ProductSummary>();
        _selection = selection ?? throw new ArgumentNullException(nameof(selection));
        _images = images ?? new LocalProductImageAvailability();
        _submission = submission;
        _reconciliation = reconciliation;
        ReconcileCommand = new DelegateCommand(_ => ReconcileCheckout());
        CommitCommand = new DelegateCommand(_ => CommitCheckout());
        ScanCommand = new DelegateCommand(_ => ScanBarcode());
        SelectCommand = new DelegateCommand(product =>
        {
            // A nested touch event must not replace the in-flight article.
            if (_selectionInFlight) { ScanFeedback = "Selection already in progress"; return; }
            if (CheckoutUncertain) { ScanFeedback = "Checkout status unknown — reconcile before retry"; return; }
            if (!FinancialSessionActive) { ScanFeedback = "Cashier session required"; return; }
            if (!CatalogueAvailable) { ScanFeedback = "Local catalogue unavailable"; return; }
            // A non-null command parameter must be a catalogue article.
            // Never fall back to a previously selected row on malformed input.
            if (product is not null && product is not ProductSummary)
            {
                ScanFeedback = "Invalid product selection";
                return;
            }
            if (product is ProductSummary article) SelectedProduct = article;
            SelectCurrent();
        });
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
    public string ScannerText {
        get => _scannerText;
        set {
            if (_selectionInFlight || CheckoutUncertain) return;
            var next = value ?? "";
            if (string.Equals(_scannerText, next, StringComparison.Ordinal)) return;
            _scannerText = next;
            // A variant chosen for an earlier barcode must not remain selectable
            // after the cashier edits or replaces the scanner input.
            if (BarcodeCandidates.Count != 0)
            {
                BarcodeCandidates = Array.Empty<ProductSummary>();
                SelectedProduct = null;
                OnPropertyChanged(nameof(BarcodeCandidates));
                OnPropertyChanged(nameof(HasBarcodeAmbiguity));
            }
            // A new scan query must not leave the previous scan's accepted or
            // ambiguous feedback visible as though it described the new code.
            if (!string.IsNullOrEmpty(_scanFeedback) &&
                (_scanFeedback == "Ambiguous barcode" ||
                 _scanFeedback == "Product not found" ||
                 _scanFeedback == "Empty barcode" ||
                 _scanFeedback == "Barcode contains control characters" ||
                 _scanFeedback == "Barcode contains leading or trailing whitespace"))
                ScanFeedback = "";
            OnPropertyChanged();
        }
    }
    public string ScanFeedback { get => _scanFeedback; private set { _scanFeedback = value; OnPropertyChanged(); } }
    private bool _isRightToLeft;
    public bool IsRightToLeft
    {
        get => _isRightToLeft;
        set { if (_isRightToLeft == value) return; _isRightToLeft = value; OnPropertyChanged(); OnPropertyChanged(nameof(LayoutDirection)); }
    }
    public System.Windows.FlowDirection LayoutDirection => IsRightToLeft ? System.Windows.FlowDirection.RightToLeft : System.Windows.FlowDirection.LeftToRight;
    public IReadOnlyList<ProductSummary> BarcodeCandidates { get; private set; } = Array.Empty<ProductSummary>();
    public bool HasBarcodeAmbiguity => BarcodeCandidates.Count > 1;
    public bool CanSelectProduct => FinancialSessionActive && CatalogueAvailable && !CheckoutUncertain && !_selectionInFlight;

    public void ReloadCatalogue()
    {
        if (_selectionInFlight) { ScanFeedback = "Selection already in progress"; return; }
        // Re-reading products never reconciles an uncertain checkout operation.
        // A failed local read must never leave a stale product available for sale.
        var pendingScannerText = CheckoutUncertain ? ScannerText : "";
        IReadOnlyList<ProductSummary> loaded;
        try { loaded = _reader.ReadProducts() ?? throw new InvalidOperationException("Catalogue reader returned null."); }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            _all = Array.Empty<ProductSummary>();
            CatalogueAvailable = false;
            SelectedProduct = null;
            ScannerText = pendingScannerText;
            Refresh();
            ScanFeedback = CheckoutUncertain ? "Checkout status unknown — reconcile before retry" : "Local catalogue unavailable";
            return;
        }
        var valid = loaded.Where(p => p is not null && !string.IsNullOrWhiteSpace(p.Id)).ToArray();
        if (valid.Length != loaded.Count || valid.GroupBy(p => p.Id, StringComparer.OrdinalIgnoreCase).Any(g => g.Count() > 1))
        {
            _all = Array.Empty<ProductSummary>();
            CatalogueAvailable = false;
            SelectedProduct = null;
            ScannerText = pendingScannerText;
            Refresh();
            ScanFeedback = CheckoutUncertain ? "Checkout status unknown — reconcile before retry" : "Invalid catalogue identities — reload required";
            return;
        }
        _all = valid;
        CatalogueAvailable = true;
        SelectedProduct = null;
        ScannerText = pendingScannerText;
        Refresh();
        ScanFeedback = CheckoutUncertain ? "Checkout status unknown — reconcile before retry" :
            _all.Count == 0 ? "No products loaded" : "Catalogue ready";
    }

    public void ScanBarcode()
    {
        if (_selectionInFlight) { ScanFeedback = "Selection already in progress"; return; }
        if (CheckoutUncertain) { ScanFeedback = "Checkout status unknown — reconcile before retry"; return; }
        if (!FinancialSessionActive) { ScanFeedback = "Cashier session required"; return; }
        if (!CatalogueAvailable) { ScanFeedback = "Local catalogue unavailable"; return; }
        // Barcode identity is exact: silently trimming scanner input could
        // select a different article from the code actually received.
        var code = ScannerText;
        if (code.Length != 0 && !string.Equals(code, code.Trim(), StringComparison.Ordinal))
        {
            BarcodeCandidates = Array.Empty<ProductSummary>();
            SelectedProduct = null;
            OnPropertyChanged(nameof(BarcodeCandidates));
            OnPropertyChanged(nameof(HasBarcodeAmbiguity));
            ScanFeedback = "Barcode contains leading or trailing whitespace";
            return;
        }
        // Never normalize scanner control characters into another article identity.
        if (code.Any(char.IsControl))
        {
            BarcodeCandidates = Array.Empty<ProductSummary>();
            SelectedProduct = null;
            OnPropertyChanged(nameof(BarcodeCandidates));
            OnPropertyChanged(nameof(HasBarcodeAmbiguity));
            ScanFeedback = "Barcode contains control characters";
            return;
        }
        if (code.Length == 0) { BarcodeCandidates = Array.Empty<ProductSummary>(); SelectedProduct = null; OnPropertyChanged(nameof(BarcodeCandidates)); OnPropertyChanged(nameof(HasBarcodeAmbiguity)); ScanFeedback = "Empty barcode"; return; }
        // Preserve the exact barcode identity used by the Application checkout gateway.
        // Case-folding here could select a different article than the live catalogue.
        var matches = _all.Where(p => string.Equals(p.Barcode, code, StringComparison.Ordinal) && !string.IsNullOrWhiteSpace(p.Barcode)).ToArray();
        BarcodeCandidates = matches;
        OnPropertyChanged(nameof(BarcodeCandidates));
        OnPropertyChanged(nameof(HasBarcodeAmbiguity));
        if (matches.Length != 1)
        {
            SelectedProduct = null;
            ScanFeedback = matches.Length == 0 ? "Product not found" : "Ambiguous barcode";
            return;
        }
        SelectedProduct = matches[0];
        SelectCurrent();
        // Clear only after an acknowledged selection; retain the code on uncertainty.
        if (ScanFeedback == "Selection accepted" && !CheckoutUncertain)
        {
            // An acknowledged scan resets only the input. The public ScannerText
            // setter intentionally revokes stale selections on cashier edits;
            // using it here would also erase the newly accepted product.
            _scannerText = "";
            OnPropertyChanged(nameof(ScannerText));
        }
    }

    public void SelectCurrent()
    {
        if (!FinancialSessionActive) { ScanFeedback = "Cashier session required"; return; }
        if (CheckoutUncertain) { ScanFeedback = "Checkout status unknown — reconcile before retry"; return; }
        if (_selectionInFlight) { ScanFeedback = "Selection already in progress"; return; }
        if (!CatalogueAvailable) { ScanFeedback = "Local catalogue unavailable"; return; }
        if (SelectedProduct is null) { ScanFeedback = "No product selected"; return; }
        if (BarcodeCandidates.Count > 1 && !BarcodeCandidates.Any(p => ReferenceEquals(p, SelectedProduct)))
        {
            ScanFeedback = "Choose a matching barcode variant explicitly";
            return;
        }
        // A candidate must belong to the current snapshot, not merely share its value.
        // This prevents stale UI objects from being sent to the checkout boundary.
        if (!CatalogueAvailable || !_all.Any(p => ReferenceEquals(p, SelectedProduct))) { ScanFeedback = "Product no longer in catalogue"; SelectedProduct = null; return; }
        if (string.IsNullOrWhiteSpace(SelectedProduct.Id)) { ScanFeedback = "Invalid product identity"; return; }
        // Selection is delegated to the injected Application boundary; WPF never posts directly.
        var clearAcknowledgedVariantScan = false;
        try
        {
            _selectionInFlight = true;
            OnPropertyChanged(nameof(CanSelectProduct));
            OnPropertyChanged(nameof(CanCommit));
            ScanFeedback = _selection.Select(SelectedProduct) ? "Selection accepted" : "Selection rejected";
            if (ScanFeedback == "Selection accepted" && HasBarcodeAmbiguity)
            {
                BarcodeCandidates = Array.Empty<ProductSummary>();
                OnPropertyChanged(nameof(BarcodeCandidates));
                OnPropertyChanged(nameof(HasBarcodeAmbiguity));
                // ScannerText setter is intentionally locked while the port is running.
                // Clear only after the acknowledged call has finished.
                clearAcknowledgedVariantScan = true;
            }
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            // Do not retry a potentially committed operation on transport failure.
            CheckoutUncertain = true;
            ScanFeedback = "Checkout status unknown — reconcile before retry";
        }
        finally
        {
            _selectionInFlight = false;
            if (clearAcknowledgedVariantScan && !CheckoutUncertain)
            {
                // Internal acknowledgement owns the reset; external scanner edits
                // remain blocked during selection and unknown checkout states.
                _scannerText = "";
                OnPropertyChanged(nameof(ScannerText));
            }
            OnPropertyChanged(nameof(CanSelectProduct));
            OnPropertyChanged(nameof(CanCommit));
        }
    }

    public void ReconcileCheckout()
    {
        if (!CheckoutUncertain || _pendingOperationId is null || _reconciliation is null || _selectionInFlight) return;
        try
        {
            var resolution = _reconciliation.Reconcile(_pendingOperationId);
            ReviewedResolution = resolution;
            CommitFeedback = resolution switch
            {
                CheckoutResolution.Persisted => "Sale persisted — cashier review required before a new checkout",
                CheckoutResolution.Absent => "Sale absent — cashier review required before a new checkout",
                _ => "Checkout status unknown — reconcile before retry"
            };
            // A journal result is informational until Application supplies an
            // explicit safe session reset. Never unlock or replay here.
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            ReviewedResolution = CheckoutResolution.Unknown;
            CommitFeedback = "Checkout status unknown — reconcile before retry";
        }
    }

    // Called only by the explicit review UI. A journal read alone never unlocks.
    // Authorization must recheck the durable outcome and clear the same draft.
    public bool TryReviewResolvedCheckout(Func<string, CheckoutResolution, bool> authorize)
    {
        if (authorize is null || _selectionInFlight || !CanReviewResolvedCheckout ||
            _pendingOperationId is null) return false;
        var operation = _pendingOperationId;
        var resolution = ReviewedResolution;
        try
        {
            _selectionInFlight = true;
            OnPropertyChanged(nameof(CanCommit));
            OnPropertyChanged(nameof(CanSelectProduct));
            if (!authorize(operation, resolution) ||
                _pendingOperationId != operation || ReviewedResolution != resolution ||
                !CheckoutUncertain) return false;
            // Discard the old UI identity too: never retry the resolved operation.
            _pendingOperationId = null;
            OnPropertyChanged(nameof(PendingOperationId));
            _selectedProduct = null;
            OnPropertyChanged(nameof(SelectedProduct));
            _scannerText = "";
            OnPropertyChanged(nameof(ScannerText));
            BarcodeCandidates = Array.Empty<ProductSummary>();
            OnPropertyChanged(nameof(BarcodeCandidates));
            OnPropertyChanged(nameof(HasBarcodeAmbiguity));
            ReviewedResolution = CheckoutResolution.Unknown;
            ClearConsumedPaymentContext();
            CheckoutUncertain = false;
            CommitFeedback = resolution == CheckoutResolution.Persisted
                ? "Persisted sale reviewed — select products for a new checkout"
                : "Absent sale reviewed — select products for a new checkout";
            return true;
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            CommitFeedback = "Cashier review failed — checkout remains locked";
            return false;
        }
        finally
        {
            _selectionInFlight = false;
            OnPropertyChanged(nameof(CanCommit));
            OnPropertyChanged(nameof(CanSelectProduct));
        }
    }

    public void CommitCheckout()
    {
        if (_selectionInFlight) { CommitFeedback = "Checkout already in progress"; return; }
        // ICommand.Execute can be invoked while the visual button is disabled.
        // Logout must fail closed at the ViewModel boundary, before allocating an operation ID.
        if (!FinancialSessionActive) { CommitFeedback = "Cashier session required"; return; }
        if (_submission is not IContextualCheckoutSubmission contextual) { CommitFeedback = "Authorized payment adapter unavailable"; return; }
        if (PaymentContext?.IsWellFormed != true) { CommitFeedback = "Cashier and payment context required"; return; }
        if (CheckoutUncertain) { CommitFeedback = "Checkout status unknown — reconcile before retry"; return; }
        if (!CatalogueAvailable) { CommitFeedback = "Local catalogue unavailable"; return; }
        ReviewedResolution = CheckoutResolution.Unknown;
        // Stable operation identity is retained for invalidation and unknown outcomes.
        _pendingOperationId ??= Guid.NewGuid().ToString("N");
        try
        {
            _selectionInFlight = true;
            OnPropertyChanged(nameof(CanSelectProduct));
            OnPropertyChanged(nameof(CanCommit));
            var result = contextual.Submit(_pendingOperationId, PaymentContext);
            CommitFeedback = result switch
            {
                CheckoutSubmissionResult.Committed => "Checkout committed",
                CheckoutSubmissionResult.Empty => "Cart is empty",
                CheckoutSubmissionResult.Invalidated => "Cart invalidated — cashier must review",
                _ => "Checkout status unknown — reconcile before retry"
            };
            if (result is CheckoutSubmissionResult.Committed or CheckoutSubmissionResult.Empty)
            {
                _pendingOperationId = null;
                OnPropertyChanged(nameof(PendingOperationId));
                ClearConsumedPaymentContext();
            }
            // Invalidated means the Host rejected the previously authorized draft.
            // Keep its stable operation ID locked for explicit durable reconciliation:
            // never silently resubmit the same stale cashier/basket context.
            // Unknown and future/unrecognized results are likewise fail-closed.
            if (result is not (CheckoutSubmissionResult.Committed or CheckoutSubmissionResult.Empty))
                CheckoutUncertain = true;
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            CheckoutUncertain = true;
            CommitFeedback = "Checkout status unknown — reconcile before retry";
        }
        finally
        {
            _selectionInFlight = false;
            OnPropertyChanged(nameof(CanSelectProduct));
            OnPropertyChanged(nameof(CanCommit));
        }
    }

    public bool CommitFullCashReturn(string originalTicketId)
    {
        if (_selectionInFlight || CheckoutUncertain || !FinancialSessionActive ||
            PaymentContext?.IsWellFormed != true || string.IsNullOrWhiteSpace(originalTicketId) ||
            _submission is not IContextualWpfCashReturnSubmission returnSubmission)
        { CommitFeedback = "Authorized full-ticket cash return unavailable"; return false; }
        ReviewedResolution = CheckoutResolution.Unknown;
        _pendingOperationId ??= Guid.NewGuid().ToString("N");
        try
        {
            _selectionInFlight = true;
            OnPropertyChanged(nameof(CanSelectProduct));
            OnPropertyChanged(nameof(CanCommit));
            var result = returnSubmission.SubmitFullCashReturn(_pendingOperationId, originalTicketId, PaymentContext);
            if (result == CheckoutSubmissionResult.Committed)
            {
                CommitFeedback = "Full-ticket cash return committed";
                _pendingOperationId = null;
                OnPropertyChanged(nameof(PendingOperationId));
                ClearConsumedPaymentContext();
                return true;
            }
            CheckoutUncertain = true;
            CommitFeedback = result == CheckoutSubmissionResult.Invalidated
                ? "Cash return invalidated — durable cashier review required"
                : "Cash return outcome unknown — reconcile before retry";
            return false;
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            CheckoutUncertain = true;
            CommitFeedback = "Cash return outcome unknown — reconcile before retry";
            return false;
        }
        finally
        {
            _selectionInFlight = false;
            OnPropertyChanged(nameof(CanSelectProduct));
            OnPropertyChanged(nameof(CanCommit));
        }
    }

    public string SearchText
    {
        get => _searchText;
        set
        {
            if (_selectionInFlight || CheckoutUncertain || _searchText == value) return;
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
            if (ReferenceEquals(_selectedProduct, value)) return;
            if (_selectionInFlight) return;
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
        OnPropertyChanged(nameof(HasBarcodeAmbiguity));
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

public enum CheckoutSubmissionResult { Committed, Empty, Invalidated, Unknown }

// WPF only owns the user command; the Application adapter owns the transaction,
// durable operation journal, cashier authorization and monetary calculations.
public interface ICheckoutSubmission
{
    CheckoutSubmissionResult Submit(string stableOperationId);
}
