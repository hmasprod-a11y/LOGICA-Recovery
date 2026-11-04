using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class MainWindow : Window
{
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
