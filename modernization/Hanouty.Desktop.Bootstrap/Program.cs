using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

public static class Program
{
    [STAThread]
    public static int Main(string[] args)
    {
        #if HANOUTY_FINANCIAL
        if (args.Length == 2 && args[0] == "--verify-disposable-cash-sale")
            return DisposableCashSaleAcceptance.Run(Path.GetFullPath(args[1]));
#endif
        #if HANOUTY_FINANCIAL
        // Financial builds open the real cashier workstation on double-click, initially locked.
        if (args.Length == 0)
        {
            try
            {
                var settings = CatalogueSettings.FromEnvironment();
                var workstationId = Environment.GetEnvironmentVariable("HANOUTY_WORKSTATION") ?? "01";
                if (!System.Text.RegularExpressions.Regex.IsMatch(workstationId, "^[0-9]{2}$"))
                    throw new InvalidOperationException("HANOUTY_WORKSTATION must contain exactly two digits.");
                var application = new Application { ShutdownMode = ShutdownMode.OnMainWindowClose };
                var workstation = CatalogueHost.CreateCashierWorkstation(settings, workstationId);
                application.MainWindow = workstation.Window;
                application.Run(workstation.Window);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine +
                    "Configure the local HANOUTY_CATALOGUE_CONNECTION, HANOUTY_DATA_DIRECTORY and HANOUTY_WORKSTATION.",
                    "Hanouty — cashier startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
                return 2;
            }
        }
        if (args.Length == 2 && args[0] == "--cashier-development")
        {
            try
            {
                var settings = CatalogueSettings.FromEnvironment();
                var endpoint = new MySqlConnectionStringBuilder(settings.ConnectionString);
                if (Environment.GetEnvironmentVariable("HANOUTY_W2_DISPOSABLE_MARKER") != "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY" ||
                    endpoint.Server != "127.0.0.1" || endpoint.Port != 3307 || endpoint.Database != "logica_ci")
                    throw new InvalidOperationException("Development cashier requires an explicitly disposable loopback database.");
                var app = new Application { ShutdownMode = ShutdownMode.OnMainWindowClose };
                var workstation = CatalogueHost.CreateCashierWorkstation(settings, args[1]);
                app.Run(workstation.Window);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hanouty — cashier startup blocked", MessageBoxButton.OK, MessageBoxImage.Error);
                return 2;
            }
        }
        #endif
        string? evidence = args.Length == 3 && args[0] == "--catalogue-only" &&
            args[1] == "--verify-disposable-catalogue" ? Path.GetFullPath(args[2]) : null;
        try
        {
            // A double-click starts the same safe, read-only WPF production graph.
            // Command-line acceptance remains explicit and financially disabled.
            if (args.Length != 0 && !(args.Length == 1 && args[0] == "--catalogue-only") && evidence is null)
                throw new InvalidOperationException("Unsupported startup arguments. Launch without arguments for read-only catalogue mode.");
            var settings = CatalogueSettings.FromEnvironment();
            if (evidence is not null) RequireDisposable(settings);
            var application = new Application { ShutdownMode = ShutdownMode.OnMainWindowClose };
            var host = CatalogueHost.CreateReadOnly(settings);
            application.MainWindow = host.Window;
            var result = 0;
            if (evidence is not null)
                host.Window.ContentRendered += (_, _) =>
                {
                    try { VerifyDisplayedCatalogue(host, evidence); }
                    catch (Exception ex)
                    {
                        result = 1;
                        Directory.CreateDirectory(evidence);
                        File.WriteAllText(Path.Combine(evidence, "failure.txt"), ex.ToString());
                    }
                    finally { host.Window.Close(); }
                };
            application.Run(host.Window);
            return result;
        }
        catch (Exception ex)
        {
            if (evidence is not null)
            {
                Directory.CreateDirectory(evidence);
                File.WriteAllText(Path.Combine(evidence, "failure.txt"), ex.ToString());
            }
            else MessageBox.Show(
                ex.Message + Environment.NewLine + Environment.NewLine +
                "Configure HANOUTY_CATALOGUE_CONNECTION for a local SELECT-only MariaDB account " +
                "and HANOUTY_DATA_DIRECTORY for an existing local data directory. " +
                "Financial operations remain disabled in this mode.",
                "Hanouty — local catalogue setup required",
                MessageBoxButton.OK, MessageBoxImage.Error);
            return 2;
        }
    }

    private static void RequireDisposable(CatalogueSettings settings)
    {
        var db = new MySqlConnectionStringBuilder(settings.ConnectionString);
        if (Environment.GetEnvironmentVariable("HANOUTY_W1_DISPOSABLE_MARKER") !=
                "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY" ||
            db.Server != "127.0.0.1" || db.Port != 3307 || db.Database != "logica_ci")
            throw new InvalidOperationException("Acceptance requires explicit disposable loopback:3307/logica_ci.");
    }

    private static void VerifyDisplayedCatalogue(CatalogueHost host, string directory)
    {
        static void Require(bool value, string message)
        {
            if (!value) throw new InvalidOperationException(message);
        }
        var vm = host.ViewModel;
        Require(host.Window.IsVisible && host.Window.IsLoaded, "The actual WPF window did not load.");
        Require(vm.CatalogueAvailable && vm.VisibleProducts.Count == 4, "Real catalogue rows were not displayed.");
        Require(vm.PhotoProducts.Count == 1 && vm.PhotoProducts[0].Id == "A-4", "Image-only catalogue semantics failed.");
        Require(!vm.CanCommit, "Read-only candidate must disable financial submission.");
        vm.ScannerText = "SINGLE";
        vm.ScanCommand.Execute(null);
        Require(vm.ScanFeedback == "Selection accepted" && host.Session.PendingCount == 1,
            "Scanner did not reach the actual Architecture session.");
        vm.ScannerText = "DUP";
        vm.ScanCommand.Execute(null);
        Require(vm.HasBarcodeAmbiguity && host.Session.PendingCount == 1, "Duplicate barcode was selected implicitly.");
        vm.SelectedProduct = vm.BarcodeCandidates.Single(p => p.Id == "A-3");
        vm.SelectCommand.Execute(vm.SelectedProduct);
        Require(host.Session.PendingCount == 2 && vm.ScannerText == "" && !vm.HasBarcodeAmbiguity,
            "Acknowledged duplicate selection did not stage the article and reset the scanner.");
        vm.SelectCommand.Execute(vm.PhotoProducts.Single());
        Require(host.Session.PendingCount == 3, "Barcode-free image selection failed.");
        vm.CommitCommand.Execute(null);
        Require(!vm.CanCommit && !vm.CheckoutUncertain && vm.PendingOperationId is null &&
                vm.CommitFeedback is "Cashier session required" or
                    "Cashier and payment context required" or "Authorized payment adapter unavailable",
            "A read-only candidate must reject checkout before allocating or posting an operation.");
        vm.SearchText = "Image-only";
        Require(vm.VisibleProducts.Count == 1, "Real catalogue search failed.");
        vm.SearchText = "";
        host.Window.UpdateLayout();
        Directory.CreateDirectory(directory);
        var bitmap = new RenderTargetBitmap((int)Math.Ceiling(host.Window.ActualWidth),
            (int)Math.Ceiling(host.Window.ActualHeight), 96, 96, PixelFormats.Pbgra32);
        bitmap.Render(host.Window);
        var png = new PngBitmapEncoder();
        png.Frames.Add(BitmapFrame.Create(bitmap));
        using (var file = File.Create(Path.Combine(directory, "wpf-catalogue.png"))) png.Save(file);
        File.WriteAllText(Path.Combine(directory, "acceptance.json"), JsonSerializer.Serialize(new
        {
            Gate = "W1 catalogue host", WindowLoaded = true, Rows = vm.VisibleProducts.Count,
            PhotoRows = vm.PhotoProducts.Count, StagedSelections = host.Session.PendingCount,
            FinancialSubmissionEnabled = vm.CanCommit, W2Accepted = false
        }, new JsonSerializerOptions { WriteIndented = true }));
    }
}

