using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class App : Application
{
    // Registered by the approved production composition root, never a demo fallback.
    public static Func<(ICatalogueReader Catalogue, IProductSelection Checkout, ICheckoutSubmission Submission)>? ResolveServices { get; set; }

    // Architecture-owned CreateFinancial host registers this existing WPF startup
    // seam with its trusted cashier/payment context. PIN stays inside Checkout
    // preparation callback; never pass or retain it in WPF.
    public static Func<(ICatalogueReader Catalogue, IProductSelection Checkout,
        ICheckoutSubmission Submission, CashierPaymentContext Payment)>? ResolveFinancialServices { get; set; }

    public static bool HasAuthorizedFinancialRegistration(ICatalogueReader? catalogue,
        IProductSelection? checkout, ICheckoutSubmission? submission, CashierPaymentContext? payment) =>
        catalogue is not null && checkout is not null &&
        submission is IContextualCheckoutSubmission &&
        submission is ICheckoutOutcomeReconciliation &&
        payment?.IsWellFormed == true &&
        string.Equals(payment.TenderCode, "Cash", StringComparison.OrdinalIgnoreCase);

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        if (ResolveFinancialServices is null && ResolveServices is null)
        {
            MessageBox.Show("Local MariaDB and authorized cashier services are not configured. Launch HANOUTY through its installed local setup; catalogue-only diagnostics cannot process sales.",
                "Hanouty — startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown(2);
            return;
        }
        try
        {
            var services = ResolveFinancialServices?.Invoke();
            var (catalogue, checkout, submission) = services is { } financial
                ? (financial.Catalogue, financial.Checkout, financial.Submission)
                : ResolveServices!();
            // Reject incomplete host registrations without entering a cashier session.
            if (catalogue is null || checkout is null || submission is null)
                throw new InvalidOperationException("Incomplete production service registration.");
            if (services is { } configured &&
                !HasAuthorizedFinancialRegistration(catalogue, checkout, submission, configured.Payment))
                throw new InvalidOperationException("Incomplete authorized cash-sale registration.");
            MainWindow = services is { } authorized
                ? new MainWindow(catalogue, checkout, submission, authorized.Payment, requireFreshPaymentContext: true)
                : new MainWindow(catalogue, checkout, submission, null, requireFreshPaymentContext: true);
            MainWindow.Show();
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            // Never reveal connection strings, credentials or database internals on a POS terminal.
            MessageBox.Show("Unable to start authorized local services. Contact the administrator.",
                "Hanouty — startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown(2);
        }
    }
}
