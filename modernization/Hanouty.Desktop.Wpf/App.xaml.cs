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
            MainWindow = new MainWindow(catalogue, checkout, submission);
            MainWindow.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Unable to start local services: {ex.Message}",
                "Hanouty — startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
            Shutdown(2);
        }
    }
}
