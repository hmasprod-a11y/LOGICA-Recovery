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

    // The authorized host supplies this context; the view never fabricates one.
    public MainWindow(ICatalogueReader catalogue, IProductSelection checkout,
        ICheckoutSubmission submission, CashierPaymentContext? paymentContext)
    {
        ArgumentNullException.ThrowIfNull(catalogue);
        ArgumentNullException.ThrowIfNull(checkout);
        ArgumentNullException.ThrowIfNull(submission);
        // Direct window construction must not bypass the production startup gate.
        // A supplied payment context is authority-sensitive and requires the same
        // durable, contextual and reconcilable checkout contracts as App.OnStartup.
        if (paymentContext is not null &&
            !App.HasAuthorizedFinancialRegistration(catalogue, checkout, submission, paymentContext))
            throw new InvalidOperationException("Authorized financial checkout services are incomplete.");
        InitializeComponent();
        DataContext = new CatalogueViewModel(catalogue, checkout, submission: submission)
        {
            PaymentContext = paymentContext
        };
    }
}
