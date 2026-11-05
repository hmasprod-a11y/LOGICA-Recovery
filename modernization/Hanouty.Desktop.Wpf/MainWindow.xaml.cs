using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class MainWindow : Window
{
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

    private string ReadReviewPin()
    {
        var pin = new System.Windows.Controls.PasswordBox {
            Margin = new Thickness(0, 12, 0, 12), MaxLength = 256
        };
        System.Windows.Automation.AutomationProperties.SetName(pin, "Cashier review PIN");
        var confirm = new System.Windows.Controls.Button {
            Content = "Confirm reviewed result", IsDefault = true, MinHeight = 40
        };
        var cancel = new System.Windows.Controls.Button {
            Content = "Cancel", IsCancel = true, MinHeight = 40
        };
        var panel = new System.Windows.Controls.StackPanel { Margin = new Thickness(20) };
        var vm = (CatalogueViewModel)DataContext;
        panel.Children.Add(new System.Windows.Controls.TextBlock {
            Text = $"Cashier: {vm.PaymentContext?.CashierId}\nOperation: {vm.PendingOperationId}\nResult: {vm.ReviewedResolution}\nConfirm this result to discard the old basket.",
            TextWrapping = TextWrapping.Wrap
        });
        panel.Children.Add(pin); panel.Children.Add(confirm); panel.Children.Add(cancel);
        var dialog = new Window {
            Title = "Review checkout result", Owner = this, Content = panel,
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
        ICheckoutSubmission submission, CashierPaymentContext? paymentContext)
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
            PaymentContext = paymentContext
        };
    }
}
