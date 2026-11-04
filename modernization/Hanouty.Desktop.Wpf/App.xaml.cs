using System;
using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;

public partial class App : Application
{
    // Registered by the approved production composition root, never a demo fallback.
    public static Func<(ICatalogueReader Catalogue, IProductSelection Checkout, ICheckoutSubmission Submission)>? ResolveServices { get; set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        if (ResolveServices is null)
        {
            MessageBox.Show("Production catalogue/checkout services are not configured. No sale can be started.",
                "Hanouty — startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown(2);
            return;
        }
        try
        {
            var (catalogue, checkout, submission) = ResolveServices();
            // Reject incomplete host registrations without entering a cashier session.
            if (catalogue is null || checkout is null || submission is null)
                throw new InvalidOperationException("Incomplete production service registration.");
            MainWindow = new MainWindow(catalogue, checkout, submission);
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
