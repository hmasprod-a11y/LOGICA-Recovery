using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class App : Application
{
    // Diagnostic seam only; never authorizes production startup.
    public static Func<(ICatalogueReader Catalogue, IProductSelection Checkout, ICheckoutSubmission Submission)>? ResolveServices { get; set; }

    // Financial host registers a fresh authenticated cash context together with
    // its durable transaction adapter. No PIN or payment authority lives in WPF.
    public static Func<(ICatalogueReader Catalogue, IProductSelection Checkout,
        ICheckoutSubmission Submission, CashierPaymentContext Payment)>? ResolveFinancialServices { get; set; }

    public static bool HasProductionStartupResolver => ResolveFinancialServices is not null;

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
        if (!HasProductionStartupResolver)
        {
            MessageBox.Show("Production catalogue/checkout services are not configured. No sale can be started.",
                "Hanouty — startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown(2);
            return;
        }
        try
        {
            var financial = ResolveFinancialServices?.Invoke();
            if (financial is not { } authorized ||
                !HasAuthorizedFinancialRegistration(authorized.Catalogue, authorized.Checkout,
                    authorized.Submission, authorized.Payment))
                throw new InvalidOperationException("Authorized cash registration is incomplete.");
            MainWindow = new MainWindow(authorized.Catalogue, authorized.Checkout,
                authorized.Submission, authorized.Payment);
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
