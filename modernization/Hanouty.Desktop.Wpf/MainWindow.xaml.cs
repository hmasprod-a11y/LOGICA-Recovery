using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class MainWindow : Window
{
    // Test assembly only: permits recording adapters for STA view tests. Production callers
    // still require a complete authorized financial registration before accepting payment context.
    internal static bool TestOnlyAllowUnauthorizedPaymentContext { get; set; }

    // Existing Host owns context authorization and trusted price readback.
    // The UI only collects a draft and never grants financial authority.
    private bool _cashierEntryOpen;
    private string? _entryPinCashier;
    private bool _reviewOpen;
    private bool _logoutOpen;
    private bool _pinOpen;
    private bool _trustedTotalReadBusy;
    private long _trustedTotalRevision;
    private Func<string, string, decimal, bool>? _setFinancialContext;
    private Func<decimal?>? _readTrustedCashTotal;
    private Func<bool>? _endFinancialSession;
    private Func<string>? _readBasketIdentity;
    private readonly ReturnReviewDraft _returnDraft = new();
    private OriginalSaleSelection? _originalSaleSelection;
    private IReadOnlyList<OriginalSaleCandidate> _originalSaleResults = Array.Empty<OriginalSaleCandidate>();
    private bool _originalSaleLookupBusy;
    private long _originalSaleQueryRevision;
    private CashierPaymentContext? _originalSaleLookupContext;
    // A reviewed original-sale reference is only valid within its cashier context.
    // VM state transitions can originate from Host reconciliation, not just clicks.
    private void InvalidateOriginalSaleOnSessionChange(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        // Any checkout outcome (including Unknown/failed posting) invalidates
        // the previously displayed quote. Only a new Host read can restore it.
        if (e.PropertyName == nameof(CatalogueViewModel.CommitFeedback))
        {
            _trustedTotalRevision++;
            TrustedBasketTotal.Text = "Checkout state changed — refresh trusted total after resolution";
            // A cash checkout outcome invalidates any separately prepared return.
            // Never allow a previous cashier review to survive a posted sale,
            // rejected payment or Unknown outcome, even with the same receipt row.
            _returnDraft.Invalidate("Checkout state changed — review original sale again");
            ReturnDraftStatus.Text = _returnDraft.Status;
            _originalSaleSelection?.Clear();
            _originalSaleLookupContext = null;
            _originalSaleResults = Array.Empty<OriginalSaleCandidate>();
            OriginalSaleResults.ItemsSource = null;
            OriginalSaleStatus.Text = "Checkout state changed — search original sale again";
            return;
        }
        if (e.PropertyName == nameof(CatalogueViewModel.ScanFeedback) &&
            DataContext is CatalogueViewModel selectionVm &&
            selectionVm.ScanFeedback == "Selection accepted")
        {
            _trustedTotalRevision++;
            TrustedBasketTotal.Text = "Basket changed — refresh trusted total";
            return;
        }
        if (e.PropertyName is not (nameof(CatalogueViewModel.FinancialSessionActive) or
            nameof(CatalogueViewModel.CheckoutUncertain) or nameof(CatalogueViewModel.PaymentContext))) return;
        if (DataContext is not CatalogueViewModel vm) return;
        _trustedTotalRevision++;
        TrustedBasketTotal.Text = "Trusted basket total unavailable";
        // A valid-looking replacement cashier context is not the context that
        // authorized these receipt results. Invalidate on every identity change,
        // including cashier A -> cashier B without an intermediate null.
        if (vm.FinancialSessionActive && !vm.CheckoutUncertain &&
            vm.PendingOperationId is null && vm.PaymentContext is not null &&
            (_originalSaleLookupContext is null ||
             ReferenceEquals(vm.PaymentContext, _originalSaleLookupContext))) return;
        _originalSaleSelection?.Clear();
        _returnDraft.Invalidate("Cashier context changed — return draft revoked");
        ReturnDraftStatus.Text = _returnDraft.Status;
        _originalSaleLookupContext = null;
        _originalSaleResults = Array.Empty<OriginalSaleCandidate>();
        OriginalSaleResults.ItemsSource = null;
        OriginalSaleStatus.Text = "Cashier context changed — search again";
    }

    public void ConfigureOriginalSaleLookup(IOriginalSaleLookup lookup)
    {
        ArgumentNullException.ThrowIfNull(lookup);
        if (_originalSaleSelection is not null) throw new InvalidOperationException("Original-sale lookup already configured.");
        _originalSaleSelection = new OriginalSaleSelection(lookup);
    }

    public bool SearchOriginalSales(string receipt)
    {
        if (_originalSaleLookupBusy || _cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen) return false;
        OriginalSaleResults.ItemsSource = null;
        _originalSaleResults = Array.Empty<OriginalSaleCandidate>();
        _originalSaleSelection?.Clear();
        _returnDraft.Invalidate("New receipt lookup — review quantity again");
        ReturnDraftStatus.Text = _returnDraft.Status;
        _originalSaleLookupContext = null;
        OriginalSaleStatus.Text = "No original sale selected — refunds unavailable";
        if (_originalSaleLookupBusy || _cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen ||
            _originalSaleSelection is null || DataContext is not CatalogueViewModel vm ||
            !vm.FinancialSessionActive || vm.PaymentContext is null || vm.CheckoutBusy || vm.CheckoutUncertain ||
            vm.PendingOperationId is not null) return false;
        _originalSaleLookupBusy = true;
        try
        {
            var context = vm.PaymentContext;
            var queryRevision = _originalSaleQueryRevision;
            var results = _originalSaleSelection.Search(receipt);
            // A Host lookup may pump the dispatcher, revoke the session, or
            // initiate Unknown. Never publish rows obtained under stale authority.
            if (queryRevision != _originalSaleQueryRevision || _cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen ||
                !vm.FinancialSessionActive || vm.CheckoutBusy || vm.CheckoutUncertain ||
                vm.PendingOperationId is not null || !ReferenceEquals(vm.PaymentContext, context))
            {
                _originalSaleSelection.Clear();
                OriginalSaleStatus.Text = "Cashier context changed — search again";
                return false;
            }
            _originalSaleResults = results;
            _originalSaleLookupContext = context;
            OriginalSaleResults.ItemsSource = _originalSaleResults;
            OriginalSaleStatus.Text = _originalSaleResults.Count == 0 ? "No persisted sale found" :
                "Select a persisted full-cash sale; only full-ticket refunds are supported";
            return _originalSaleResults.Count > 0;
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            OriginalSaleStatus.Text = "Original-sale evidence unavailable";
            return false;
        }
        finally { _originalSaleLookupBusy = false; }
    }

    public bool SelectOriginalSale(OriginalSaleCandidate candidate)
    {
        // Modal dialogs pump the dispatcher; a nested selection must not alter
        // the receipt evidence during PIN, login, logout or durable review.
        if (_cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen ||
            _originalSaleLookupBusy || _originalSaleSelection is null || DataContext is not CatalogueViewModel vm ||
            !vm.FinancialSessionActive || vm.PaymentContext is null || vm.CheckoutBusy || vm.CheckoutUncertain ||
            vm.PendingOperationId is not null || _originalSaleLookupContext is null ||
            !ReferenceEquals(vm.PaymentContext, _originalSaleLookupContext)) return false;
        // The candidate must still belong to the current, visible Host snapshot.
        // A stale selection event after a new search cannot authorize a return.
        if (!ReferenceEquals(OriginalSaleResults.ItemsSource, _originalSaleResults) ||
            !ReferenceEquals(OriginalSaleResults.SelectedItem, candidate)) return false;
        var accepted = _originalSaleSelection.Select(candidate, _originalSaleResults);
        _returnDraft.SetOriginalSale(accepted ? candidate.SaleId : null);
        ReturnDraftStatus.Text = _returnDraft.Status;
        OriginalSaleStatus.Text = accepted ?
            $"Original sale: {candidate.SaleId} — full-ticket cash refund only" :
            "Invalid original-sale selection";
        return accepted;
    }

    private void OriginalSaleResults_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        // A highlighted receipt is not the previously reviewed receipt. A row
        // switch must revoke the draft even without pressing Select again.
        if (_originalSaleSelection?.Selected is { } selected &&
            !ReferenceEquals(OriginalSaleResults.SelectedItem, selected))
        {
            _originalSaleSelection.ClearSelection();
            _returnDraft.Invalidate("Original sale selection changed — review again");
            ReturnDraftStatus.Text = _returnDraft.Status;
        }
    }

    public bool ReviewReturnQuantity(string quantity)
    {
        if (_cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen || _originalSaleLookupBusy ||
            _originalSaleSelection?.Selected is null || DataContext is not CatalogueViewModel vm ||
            !vm.FinancialSessionActive || vm.PaymentContext is null || vm.CheckoutBusy ||
            vm.CheckoutUncertain || vm.PendingOperationId is not null ||
            !ReferenceEquals(vm.PaymentContext, _originalSaleLookupContext))
        {
            _returnDraft.Invalidate("Return quantity refused — cashier or original sale unavailable");
            ReturnDraftStatus.Text = _returnDraft.Status;
            return false;
        }
        var valid = _returnDraft.SetQuantity(quantity);
        ReturnDraftStatus.Text = _returnDraft.Status;
        return valid;
    }

    public bool ConfirmReturnDraft()
    {
        if (_cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen || _originalSaleLookupBusy ||
            DataContext is not CatalogueViewModel vm || _originalSaleSelection?.Selected is null ||
            _returnDraft.OriginalSaleId != _originalSaleSelection.Selected.SaleId ||
            !ReferenceEquals(OriginalSaleResults.ItemsSource, _originalSaleResults) ||
            !_originalSaleResults.Any(row => ReferenceEquals(row, _originalSaleSelection.Selected)) ||
            !ReferenceEquals(OriginalSaleResults.SelectedItem, _originalSaleSelection.Selected) ||
            !ReferenceEquals(vm.PaymentContext, _originalSaleLookupContext))
        {
            _returnDraft.Invalidate("Return confirmation refused — original sale or session changed");
            ReturnDraftStatus.Text = _returnDraft.Status;
            return false;
        }
        if (!_returnDraft.ConfirmFullTicket(vm.FinancialSessionActive && !vm.CheckoutBusy,
            vm.CheckoutUncertain || vm.PendingOperationId is not null))
        { ReturnDraftStatus.Text = _returnDraft.Status; return false; }
        ReturnDraftStatus.Text = _returnDraft.Status;
        var committed = vm.CommitFullCashReturn(_originalSaleSelection.Selected.SaleId);
        if (committed)
        {
            _returnDraft.Invalidate("Full-ticket refund submitted");
            _originalSaleSelection.Clear();
            _originalSaleLookupContext = null;
            _originalSaleResults = Array.Empty<OriginalSaleCandidate>();
            OriginalSaleResults.ItemsSource = null;
            OriginalSaleStatus.Text = "Refund submitted";
        }
        else ReturnDraftStatus.Text = vm.CommitFeedback;
        return committed;
    }

    private void ConfirmReturnDraft_Click(object sender, RoutedEventArgs e) => ConfirmReturnDraft();

    private void OriginalSaleSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
    {
        // A previously returned receipt is no longer evidence for the edited
        // query. Do not leave a selectable row from a different receipt visible.
        _originalSaleQueryRevision++;
        _originalSaleSelection?.Clear();
        _returnDraft.Invalidate("Receipt query changed — return draft revoked");
        ReturnDraftStatus.Text = _returnDraft.Status;
        _originalSaleLookupContext = null;
        _originalSaleResults = Array.Empty<OriginalSaleCandidate>();
        OriginalSaleResults.ItemsSource = null;
        OriginalSaleStatus.Text = "Receipt query changed — search persisted sales again";
    }

    private void SearchOriginalSales_Click(object sender, RoutedEventArgs e) =>
        SearchOriginalSales(OriginalSaleSearch.Text);
    private void SelectOriginalSale_Click(object sender, RoutedEventArgs e)
    {
        if (OriginalSaleResults.SelectedItem is OriginalSaleCandidate candidate)
            SelectOriginalSale(candidate);
    }

    // Display-only authoritative basket total: never calculate a price in WPF.
    // A dispatcher-reentrant Host callback cannot publish an amount from an old
    // cashier, basket, or unresolved operation.
    public bool RefreshTrustedBasketTotal()
    {
        // Host callbacks can pump the dispatcher. A nested refresh must not
        // overwrite the in-flight result or clear the current status.
        if (_trustedTotalReadBusy) return false;
        TrustedBasketTotal.Text = "Trusted basket total unavailable";
        if (_cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen ||
            _originalSaleLookupBusy || _readTrustedCashTotal is null ||
            DataContext is not CatalogueViewModel vm || !vm.FinancialSessionActive ||
            vm.PaymentContext is null || vm.CheckoutBusy || vm.CheckoutUncertain ||
            vm.PendingOperationId is not null) return false;
        _trustedTotalReadBusy = true;
        var context = vm.PaymentContext;
        var revision = _trustedTotalRevision;
        try
        {
            var basketIdentity = _readBasketIdentity?.Invoke();
            var total = _readTrustedCashTotal();
            if (total is null || total < 0m || decimal.Round(total.Value, 2) != total.Value ||
                revision != _trustedTotalRevision ||
                !vm.FinancialSessionActive || vm.CheckoutBusy || vm.CheckoutUncertain ||
                vm.PendingOperationId is not null || !ReferenceEquals(vm.PaymentContext, context) ||
                _readBasketIdentity?.Invoke() != basketIdentity) return false;
            TrustedBasketTotal.Text = "Trusted basket total (MAD): " +
                total.Value.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        { return false; }
        finally { _trustedTotalReadBusy = false; }
    }
    private void RefreshTrustedBasketTotal_Click(object sender, RoutedEventArgs e) => RefreshTrustedBasketTotal();

    public void ConfigureCashierEntry(Func<string, string, decimal, bool> setFinancialContext,
        Func<decimal?> readTrustedCashTotal, Func<bool>? endFinancialSession = null,
        Func<string>? readBasketIdentity = null)
    {
        ArgumentNullException.ThrowIfNull(setFinancialContext);
        ArgumentNullException.ThrowIfNull(readTrustedCashTotal);
        if (_setFinancialContext is not null) throw new InvalidOperationException("Cashier entry already configured.");
        _setFinancialContext = setFinancialContext;
        _readTrustedCashTotal = readTrustedCashTotal;
        _endFinancialSession = endFinancialSession;
        _readBasketIdentity = readBasketIdentity;
    }

    public bool EndFinancialSession()
    {
        if (_cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen || _trustedTotalReadBusy || _originalSaleLookupBusy || DataContext is not CatalogueViewModel vm ||
            vm.CheckoutBusy || vm.CheckoutUncertain || vm.PendingOperationId is not null ||
            _endFinancialSession is null) return false;
        _logoutOpen = true;
        try
        {
            if (!_endFinancialSession()) return false;
            _returnDraft.Invalidate("Cashier session ended — return draft revoked");
            ReturnDraftStatus.Text = _returnDraft.Status;
            _originalSaleSelection?.Clear();
            _originalSaleLookupContext = null;
            OriginalSaleResults.ItemsSource = null;
            _originalSaleResults = Array.Empty<OriginalSaleCandidate>();
            OriginalSaleStatus.Text = "No original sale selected — refunds unavailable";
            // The Host has confirmed logout. Revoke the WPF session locally even
            // when a Host callback does not mutate the ViewModel itself.
            // This also invalidates stale product/scanner and cash context.
            vm.FinancialSessionActive = false;
            // A Host callback may have synchronously moved the ViewModel into
            // an unresolved operation. The setter deliberately refuses logout
            // in that state; never report a successful local session revocation.
            return !vm.FinancialSessionActive && !vm.CheckoutUncertain &&
                vm.PendingOperationId is null;
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            // A failed Host logout must not crash the cashier window or claim success.
            // The Host remains the sole owner of session state and authorization.
            return false;
        }
        finally { _logoutOpen = false; }
    }

    private void EndFinancialSession_Click(object sender, RoutedEventArgs e) => EndFinancialSession();

    public bool ShowCashierEntry()
    {
        if (_cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen || _trustedTotalReadBusy || _originalSaleLookupBusy || DataContext is not CatalogueViewModel vm ||
            vm.CheckoutBusy || vm.CheckoutUncertain || vm.PendingOperationId is not null ||
            _setFinancialContext is null || _readTrustedCashTotal is null) return false;
        // Lock BEFORE calling Host-provided delegates: those may pump the WPF
        // dispatcher and otherwise reenter login, logout or financial review.
        _cashierEntryOpen = true;
        try
        {
            var total = _readTrustedCashTotal();
            if (total is null || total < 0m) return false;
            var identity = _readBasketIdentity?.Invoke();
            var dialog = new CashierEntryDialog(total) { Owner = this };
            if (dialog.ShowDialog() != true || dialog.Draft is not { } draft) return false;
            if (vm.CheckoutBusy || vm.CheckoutUncertain || vm.PendingOperationId is not null ||
                _readTrustedCashTotal() != total || _readBasketIdentity?.Invoke() != identity)
                return false;
            // The Host may request a fresh PIN while authorizing this explicit
            // cashier-entry draft. Scope that prompt to this cashier and modal call.
            bool accepted;
            _entryPinCashier = draft.Cashier;
            try { accepted = _setFinancialContext(draft.Cashier, draft.Register, draft.CashMad); }
            finally { _entryPinCashier = null; }
            if (!accepted) return false;
            return IsAuthorizedEntry(vm, draft.Cashier, draft.CashMad) &&
                IsAuthorizedRegister(vm, draft.Register);
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        { return false; }
        finally { _cashierEntryOpen = false; }
    }

    internal static bool IsAuthorizedEntry(CatalogueViewModel vm, string cashier, decimal tender)
    {
        return vm.FinancialSessionActive && !vm.CheckoutBusy &&
            !vm.CheckoutUncertain && vm.PendingOperationId is null &&
            vm.PaymentContext is { } authorized &&
            authorized.CashierId == cashier && authorized.TenderedAmount == tender &&
            string.Equals(authorized.TenderCode, "Cash", StringComparison.OrdinalIgnoreCase) &&
            string.Equals(authorized.CurrencyCode, "MAD", StringComparison.Ordinal);
    }

    // Double-click on the real catalogue stages the selected article through the
    // same Host-owned IProductSelection as the explicit Select button.
    internal static bool IsAuthorizedRegister(CatalogueViewModel vm, string register) =>
        vm.FinancialSessionActive && !vm.CheckoutUncertain && !vm.CheckoutBusy &&
        vm.PendingOperationId is null && vm.PaymentContext is { } context &&
        string.Equals(context.RegisterId, register, StringComparison.Ordinal) &&
        string.Equals(context.CurrencyCode, "MAD", StringComparison.Ordinal);

    public bool SelectHighlightedProduct()
    {
        if (DataContext is not CatalogueViewModel vm || !vm.CanSelectProduct ||
            vm.SelectedProduct is null) return false;
        var selected = vm.SelectedProduct;
        if (!vm.SelectCommand.CanExecute(selected)) return false;
        vm.SelectCommand.Execute(selected);
        // The production selection port can deny a stale article or unavailable
        // variant. Never report success merely because the command ran.
        return vm.ScanFeedback == "Selection accepted";
    }

    private void ProductList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        // Header, scrollbar and empty-space double-clicks are not product actions.
        if (e.OriginalSource is not System.Windows.DependencyObject origin) return;
        for (var node = origin; node is not null; node = GetInteractionParent(node))
        {
            if (node is System.Windows.Controls.DataGridRow row)
            {
                if (row.Item is ProductSummary product &&
                    DataContext is CatalogueViewModel vm && vm.SelectedProduct == product)
                    SelectHighlightedProduct();
                return;
            }
            if (node is System.Windows.Controls.DataGrid) return;
        }
    }

    // DataGrid templates may raise input from a ContentElement, not a Visual.
    // VisualTreeHelper.GetParent(ContentElement) throws and would interrupt the
    // cashier scanner/selection flow. Walk the appropriate WPF tree safely.
    internal static System.Windows.DependencyObject? GetInteractionParent(System.Windows.DependencyObject node)
    {
        if (node is System.Windows.FrameworkContentElement content)
            return content.Parent;
        if (node is System.Windows.Media.Visual or System.Windows.Media.Media3D.Visual3D)
            return System.Windows.Media.VisualTreeHelper.GetParent(node);
        return System.Windows.LogicalTreeHelper.GetParent(node);
    }

    private void CashierEntry_Click(object sender, RoutedEventArgs e) => ShowCashierEntry();

    private Func<string, CheckoutResolution, Func<string>, bool>? _review;
    public void ConfigureReviewedCheckout(Func<string, CheckoutResolution, Func<string>, bool> review)
    {
        ArgumentNullException.ThrowIfNull(review);
        if (_review is not null) throw new InvalidOperationException("Review authority already configured.");
        _review = review;
    }

    // Same path for the UI and executable acceptance; the Host owns authorization.
    public bool ReviewResolvedCheckout(Func<string> transientPin)
    {
        ArgumentNullException.ThrowIfNull(transientPin);
        if (_reviewOpen || _cashierEntryOpen || _logoutOpen || _pinOpen || _originalSaleLookupBusy || _review is null ||
            DataContext is not CatalogueViewModel vm || !vm.CanReviewResolvedCheckout)
            return false;
        _reviewOpen = true;
        try
        {
            // Host alone rechecks durable outcome and authenticates the fresh cashier.
            // No second PIN prompt, cashier entry or logout may overlap this review.
            return vm.TryReviewResolvedCheckout((id, outcome) => _review(id, outcome, transientPin));
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            // A Host/PIN-provider failure is NOT evidence of a reviewed result.
            // Keep the durable operation locked for a fresh explicit review.
            return false;
        }
        finally { _reviewOpen = false; }
    }

    private void ReviewResolvedCheckout_Click(object sender, RoutedEventArgs e) =>
        ReviewResolvedCheckout(ReadReviewPin);

    public string PromptCashierPin() => PromptCashierPin((DataContext as CatalogueViewModel)?.PaymentContext?.CashierId ?? "");
    public string PromptCashierPin(string cashier)
    {
        var cashierEntryPin = _cashierEntryOpen &&
            string.Equals(_entryPinCashier, cashier, StringComparison.Ordinal);
        if ((_cashierEntryOpen && !cashierEntryPin) || _logoutOpen || _reviewOpen ||
            _pinOpen || _originalSaleLookupBusy || DataContext is not CatalogueViewModel vm ||
            vm.CheckoutUncertain ||
            (cashierEntryPin
                ? vm.CheckoutBusy || vm.PendingOperationId is not null
                : !vm.FinancialSessionActive ||
                  (vm.PendingOperationId is not null && !vm.CheckoutBusy) ||
                  vm.PaymentContext is null ||
                  !string.Equals(vm.PaymentContext.CashierId, cashier, StringComparison.Ordinal)))
            return "";
        return ReadPin(cashierEntryPin ? "Authorize cashier session" : "Authorize cash checkout",
            $"Cashier: {cashier}\nConfirm this cashier session for the displayed cash payment.",
            cashierEntryPin ? cashier : null);
    }

    private string ReadReviewPin()
    {
        var vm = (CatalogueViewModel)DataContext;
        return ReadPin("Review checkout result",
            $"Authenticate the originally authorized cashier.\nOperation: {vm.PendingOperationId}\nResult: {vm.ReviewedResolution}\nConfirm this result to discard the old basket.");
    }

    private string ReadPin(string title, string message, string? cashierEntryPin = null)
    {
        var pin = new System.Windows.Controls.PasswordBox {
            Margin = new Thickness(0, 12, 0, 12), MaxLength = 256
        };
        System.Windows.Automation.AutomationProperties.SetName(pin, "Cashier review PIN");
        var confirm = new System.Windows.Controls.Button {
            Content = "Confirm", IsDefault = true, MinHeight = 40
        };
        var cancel = new System.Windows.Controls.Button {
            Content = "Cancel", IsCancel = true, MinHeight = 40
        };
        var panel = new System.Windows.Controls.StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(new System.Windows.Controls.TextBlock {
            Text = message,
            TextWrapping = TextWrapping.Wrap
        });
        panel.Children.Add(pin); panel.Children.Add(confirm); panel.Children.Add(cancel);
        var dialog = new Window {
            Title = title, Owner = this, Content = panel,
            Width = 420, SizeToContent = SizeToContent.Height,
            WindowStartupLocation = WindowStartupLocation.CenterOwner,
            ResizeMode = ResizeMode.NoResize, ShowInTaskbar = false
        };
        confirm.Click += (_, _) => dialog.DialogResult = true;
        dialog.Loaded += (_, _) => pin.Focus();
        // Modal WPF dialogs pump the dispatcher. Prevent nested sale PIN prompts
        // and session transitions until the transient secret is cleared.
        if (_pinOpen) return "";
        _pinOpen = true;
        // A modal PIN dialog pumps the dispatcher: the Host can revoke the
        // session or transition into Unknown while the dialog is displayed.
        // Never release a secret captured under a different cashier context.
        var vmAtPrompt = DataContext as CatalogueViewModel;
        var contextAtPrompt = vmAtPrompt?.PaymentContext;
        var sessionAtPrompt = vmAtPrompt?.FinancialSessionActive;
        var pendingAtPrompt = vmAtPrompt?.PendingOperationId;
        var uncertainAtPrompt = vmAtPrompt?.CheckoutUncertain;
        var busyAtPrompt = vmAtPrompt?.CheckoutBusy;
        try
        {
            if (dialog.ShowDialog() != true || vmAtPrompt is null ||
                !ReferenceEquals(DataContext, vmAtPrompt))
                return "";
            if (cashierEntryPin is not null)
            {
                if (!_cashierEntryOpen ||
                    !string.Equals(_entryPinCashier, cashierEntryPin, StringComparison.Ordinal) ||
                    !ReferenceEquals(vmAtPrompt.PaymentContext, contextAtPrompt) ||
                    vmAtPrompt.FinancialSessionActive != sessionAtPrompt ||
                    vmAtPrompt.PendingOperationId != pendingAtPrompt ||
                    vmAtPrompt.CheckoutUncertain != uncertainAtPrompt ||
                    vmAtPrompt.CheckoutBusy != busyAtPrompt)
                    return "";
            }
            else if (!IsPinContextStillValid(vmAtPrompt, contextAtPrompt, pendingAtPrompt,
                uncertainAtPrompt == true, busyAtPrompt == true))
                return "";
            return pin.Password;
        }
        finally { pin.Clear(); _pinOpen = false; }
    }

    // A cash posting legitimately holds CheckoutBusy=true while Host requests PIN.
    // Compare with the state at prompt opening rather than requiring idle state.
    internal static bool IsPinContextStillValid(CatalogueViewModel vm,
        CashierPaymentContext? context, string? pendingOperation,
        bool uncertain, bool busy) =>
        vm.FinancialSessionActive &&
        ReferenceEquals(vm.PaymentContext, context) &&
        vm.CheckoutUncertain == uncertain &&
        vm.PendingOperationId == pendingOperation &&
        vm.CheckoutBusy == busy;

    // The production host must supply real Application adapters from its composition root.
    // No EmptyCatalogueReader or PreviewProductSelection may silently enter a sale workflow.
    public MainWindow(ICatalogueReader catalogue, IProductSelection checkout, ICheckoutSubmission submission)
        : this(catalogue, checkout, submission, null)
    {
    }

    // Architecture-owned CreateFinancial host supplies the authenticated, trusted
    // cash-session context. This constructor does not read PIN or calculate prices.
    public MainWindow(ICatalogueReader catalogue, IProductSelection checkout,
        ICheckoutSubmission submission, CashierPaymentContext? paymentContext, bool requireFreshPaymentContext = false)
    {
        ArgumentNullException.ThrowIfNull(catalogue);
        ArgumentNullException.ThrowIfNull(checkout);
        ArgumentNullException.ThrowIfNull(submission);
        if (paymentContext is not null && !TestOnlyAllowUnauthorizedPaymentContext &&
            !App.HasAuthorizedFinancialRegistration(catalogue, checkout, submission, paymentContext))
            throw new InvalidOperationException("Authorized financial checkout services are incomplete.");
        InitializeComponent();
        // The host-provided adapter may implement durable journal reconciliation.
        // Pass the same production instance: never create a second journal or host.
        DataContext = new CatalogueViewModel(catalogue, checkout,
            submission: submission,
            reconciliation: submission as ICheckoutOutcomeReconciliation)
        {
            RequireFreshPaymentContext = requireFreshPaymentContext,
            PaymentContext = paymentContext,
            // A production window with no authenticated cashier must start locked.
            // Catalogue remains visible, but scanning and basket staging wait for
            // the Host to authorize a new cashier session explicitly.
            FinancialSessionActive = !requireFreshPaymentContext || paymentContext is not null
        };
        ((CatalogueViewModel)DataContext).PropertyChanged += InvalidateOriginalSaleOnSessionChange;
    }
}
