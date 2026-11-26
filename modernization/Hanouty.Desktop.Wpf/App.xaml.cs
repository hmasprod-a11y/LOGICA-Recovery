using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class App : Application
{
    // Legacy diagnostic seam only; production startup must not fall back to this registration.
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

    // Allows Windows STA tests to assert that the diagnostic resolver cannot
    // unlock a production process, without displaying a modal startup dialog.
    public static bool HasProductionStartupResolver => ResolveFinancialServices is not null;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        if (!HasProductionStartupResolver)
        {
            MessageBox.Show("Local MariaDB and authorized cashier services are not configured. Launch HANOUTY through its installed local setup; catalogue-only diagnostics cannot process sales.",
                "Hanouty — startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown(2);
            return;
        }
        try
        {
            var services = ResolveFinancialServices?.Invoke();
            // A diagnostic catalogue registration is not a production startup path.
            // QA Bootstrap must provide the authorized local financial composition.
            if (services is not { } financial ||
                !HasAuthorizedFinancialRegistration(financial.Catalogue, financial.Checkout,
                    financial.Submission, financial.Payment))
                throw new InvalidOperationException("Incomplete authorized local checkout registration.");
            MainWindow = new MainWindow(financial.Catalogue, financial.Checkout,
                financial.Submission, financial.Payment, requireFreshPaymentContext: true);
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
