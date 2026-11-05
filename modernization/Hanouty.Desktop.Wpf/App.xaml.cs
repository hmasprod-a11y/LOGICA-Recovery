using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class App : Application
{
    // Registered by the approved production composition root, never a demo fallback.
    public static Func<(ICatalogueReader Catalogue, IProductSelection Checkout, ICheckoutSubmission Submission)>? ResolveServices { get; set; }

    // Financial host registers a fresh authenticated cash context together with
    // its durable transaction adapter. No PIN or payment authority lives in WPF.
    public static Func<(ICatalogueReader Catalogue, IProductSelection Checkout,
        ICheckoutSubmission Submission, CashierPaymentContext Payment)>? ResolveFinancialServices { get; set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        if (ResolveServices is null && ResolveFinancialServices is null)
        {
            MessageBox.Show("Production catalogue/checkout services are not configured. No sale can be started.",
                "Hanouty — startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown(2);
            return;
        }
        try
        {
            var financial = ResolveFinancialServices?.Invoke();
            var (catalogue, checkout, submission) = financial is { } authorized
                ? (authorized.Catalogue, authorized.Checkout, authorized.Submission)
                : ResolveServices!();
            if (catalogue is null || checkout is null || submission is null)
                throw new InvalidOperationException("Incomplete production host registration.");
            // A contextual cash adapter cannot silently fall back to a context-free
            // sale path. A durable journal is mandatory for financial sessions.
            if (financial is { } registered &&
                (registered.Payment?.IsWellFormed != true ||
                 !string.Equals(registered.Payment.TenderCode, "Cash", StringComparison.OrdinalIgnoreCase) ||
                 submission is not IContextualCheckoutSubmission ||
                 submission is not ICheckoutOutcomeReconciliation))
                throw new InvalidOperationException("Authorized cash registration is incomplete.");
            if (financial is null && submission is IContextualCheckoutSubmission)
                throw new InvalidOperationException("Financial host context is required.");
            MainWindow = new MainWindow(catalogue, checkout, submission, financial?.Payment);
            MainWindow.Show();
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            MessageBox.Show("Unable to start authorized local services. Contact the administrator.",
                "Hanouty — startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown(2);
        }
    }
}
