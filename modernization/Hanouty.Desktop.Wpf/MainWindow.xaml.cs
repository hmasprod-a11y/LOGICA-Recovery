using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class MainWindow : Window
{
    // Existing Host owns context authorization and trusted price readback.
    // The UI only collects a draft and never grants financial authority.
    private bool _cashierEntryOpen;
    private Func<string, string, decimal, bool>? _setFinancialContext;
    private Func<decimal?>? _readTrustedCashTotal;

    public void ConfigureCashierEntry(Func<string, string, decimal, bool> setFinancialContext,
        Func<decimal?> readTrustedCashTotal)
    {
        ArgumentNullException.ThrowIfNull(setFinancialContext);
        ArgumentNullException.ThrowIfNull(readTrustedCashTotal);
        if (_setFinancialContext is not null) throw new InvalidOperationException("Cashier entry already configured.");
        _setFinancialContext = setFinancialContext;
        _readTrustedCashTotal = readTrustedCashTotal;
    }

    public bool ShowCashierEntry()
    {
        if (_cashierEntryOpen || DataContext is not CatalogueViewModel vm || vm.CheckoutBusy || vm.CheckoutUncertain ||
            vm.PendingOperationId is not null || _setFinancialContext is null || _readTrustedCashTotal is null)
            return false;
        decimal? trustedTotal;
        try { trustedTotal = _readTrustedCashTotal(); }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException) { return false; }
        if (trustedTotal is null || trustedTotal < 0m) return false;
        (string Cashier, string Register, decimal CashMad)? draft;
        _cashierEntryOpen = true;
        try
        {
            var dialog = new CashierEntryDialog(trustedTotal) { Owner = this };
            if (dialog.ShowDialog() != true) return false;
            draft = dialog.Draft;
        }
        finally { _cashierEntryOpen = false; }
        if (draft is null) return false;
        // Recheck after the modal interaction; Host independently rejects busy/unknown.
        if (vm.CheckoutBusy || vm.CheckoutUncertain || vm.PendingOperationId is not null) return false;
        try
        {
            // The basket may have changed during a modal dialog. Never approve a stale quote.
            if (_readTrustedCashTotal() != trustedTotal) return false;
            if (!_setFinancialContext(draft.Value.Cashier, draft.Value.Register, draft.Value.CashMad)) return false;
            // Host has authorized the new session; UI state follows, never leads.
            vm.FinancialSessionActive = true;
            vm.PaymentContext = new CashierPaymentContext(draft.Value.Cashier, draft.Value.Register, "MAD", "Cash", draft.Value.CashMad);
            return true;
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException) { return false; }
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
    public bool ReviewResolvedCheckout(Func<string> transientPin) =>
        DataContext is CatalogueViewModel vm && _review is not null &&
        vm.TryReviewResolvedCheckout((id, outcome) => _review(id, outcome, transientPin));

    private void ReviewResolvedCheckout_Click(object sender, RoutedEventArgs e) =>
        ReviewResolvedCheckout(ReadReviewPin);

    public string PromptCashierPin() => ReadPin("Authorize cash checkout",
        $"Cashier: {((CatalogueViewModel)DataContext).PaymentContext?.CashierId}\nConfirm this cashier session for the displayed cash payment.");

    private string ReadReviewPin()
    {
        var vm = (CatalogueViewModel)DataContext;
        return ReadPin("Review checkout result",
            $"Cashier: {vm.PaymentContext?.CashierId}\nOperation: {vm.PendingOperationId}\nResult: {vm.ReviewedResolution}\nConfirm this result to discard the old basket.");
    }

    private string ReadPin(string title, string message)
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
        try { return dialog.ShowDialog() == true ? pin.Password : ""; }
        finally { pin.Clear(); }
    }

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
        InitializeComponent();
        // The host-provided adapter may implement durable journal reconciliation.
        // Pass the same production instance: never create a second journal or host.
        DataContext = new CatalogueViewModel(catalogue, checkout,
            submission: submission,
            reconciliation: submission as ICheckoutOutcomeReconciliation)
        {
            RequireFreshPaymentContext = requireFreshPaymentContext,
            PaymentContext = paymentContext
        };
    }
}
