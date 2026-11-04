using System.IO;
using System.Windows;
using Hanouty.ArchitectureBridge;
using Hanouty.Desktop.Wpf;
using Hanouty.Desktop.Wpf.Presentation;
using Hanouty.Inventory.MariaDb;
using Hanouty.WpfContractAdapter;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

// Composition belongs here: WPF must never reference its own adapter.
public sealed record CatalogueSettings(string ConnectionString, string DataDirectory)
{
    public static CatalogueSettings FromEnvironment()
    {
        var connection = Environment.GetEnvironmentVariable("HANOUTY_CATALOGUE_CONNECTION")
            ?? throw new InvalidOperationException("Local catalogue connection is not configured.");
        var builder = new MySqlConnectionStringBuilder(connection);
        if (builder.Server is not ("127.0.0.1" or "localhost" or "::1") ||
            string.IsNullOrWhiteSpace(builder.Database) || string.IsNullOrWhiteSpace(builder.UserID))
            throw new InvalidOperationException("An explicitly configured local MariaDB account is required.");
        var directory = Environment.GetEnvironmentVariable("HANOUTY_DATA_DIRECTORY");
        if (string.IsNullOrWhiteSpace(directory) || !Directory.Exists(directory))
            throw new InvalidOperationException("Local data directory is missing.");
        return new CatalogueSettings(connection, Path.GetFullPath(directory));
    }
}

public sealed record CatalogueHost(MainWindow Window, CatalogueViewModel ViewModel,
    CheckoutSession Session)
{
    // W1 is deliberately read-only. It stages real catalogue selections, but
    // cannot pretend that a missing financial adapter committed a sale.
    public static CatalogueHost CreateReadOnly(CatalogueSettings settings)
    {
        var unavailable = new UnavailablePosting();
        var composition = new CheckoutComposition(
            new MariaDbCatalogueReader(settings.ConnectionString, settings.DataDirectory),
            new ExplicitVariantChoice(), unavailable, unavailable);
        var binding = ProductionWpfServices.Create(composition);
        var window = new MainWindow(binding.Catalogue, binding.Checkout, binding.Submission);
        // The existing view-model supports an absent submission: CanCommit=false.
        // Keep that state explicit rather than allowing a fake checkout service.
        var vm = new CatalogueViewModel(binding.Catalogue, binding.Checkout);
        if (!vm.CatalogueAvailable)
            throw new InvalidOperationException("Local catalogue could not be loaded.");
        window.DataContext = vm;
        window.Title = "Hanouty — Catalogue (read-only)";
        return new CatalogueHost(window, vm, binding.Session);
    }

    // W2 composition requires the real caller-supplied posting service and
    // durable journal. There is no default or in-memory financial fallback.
    public static MainWindow CreateProduction(CatalogueSettings settings,
        ICheckoutVariantPrompt variants, IAtomicCheckoutBatchPort posting,
        ICheckoutOperationJournal journal)
    {
        ArgumentNullException.ThrowIfNull(posting);
        ArgumentNullException.ThrowIfNull(journal);
        var composition = new CheckoutComposition(
            new MariaDbCatalogueReader(settings.ConnectionString, settings.DataDirectory),
            variants, posting, journal);
        var binding = ProductionWpfServices.Create(composition);
        return new MainWindow(binding.Catalogue, binding.Checkout, binding.Submission);
    }

    // W2: caller supplies the Checkout production posting/journal from the
    // SAME ArchitectureBridge assembly, plus authenticated payment context.
    // Never call this for read-only startup or product selection.
    public static MainWindow CreateFinancial(CatalogueSettings settings,
        ICheckoutVariantPrompt variants, IAuthorizedCheckoutPort posting,
        ICheckoutOperationJournal journal,
        Func<AuthorizedCheckoutPaymentContext> paymentContext)
    {
        ArgumentNullException.ThrowIfNull(settings);
        ArgumentNullException.ThrowIfNull(variants);
        ArgumentNullException.ThrowIfNull(posting);
        ArgumentNullException.ThrowIfNull(journal);
        ArgumentNullException.ThrowIfNull(paymentContext);
        var binding = ProductionWpfServices.CreateFinancial(
            new MariaDbCatalogueReader(settings.ConnectionString, settings.DataDirectory),
            variants, posting, journal, paymentContext);
        return new MainWindow(binding.Catalogue, binding.Checkout, binding.Submission);
    }

    private sealed class ExplicitVariantChoice : ICheckoutVariantPrompt
    {
        // WPF already displays candidates and stages the explicitly chosen ID.
        // Never silently choose the first duplicate.
        public int Choose(IReadOnlyList<ArticleCandidate> candidates) => -1;
    }

    private sealed class UnavailablePosting : IAtomicCheckoutBatchPort, ICheckoutOperationJournal
    {
        public void AddBatch(IReadOnlyList<CheckoutBatchLine> lines, string operationId) =>
            throw new InvalidOperationException("Financial posting is not configured in read-only catalogue mode.");
        public CheckoutOperationOutcome Lookup(string operationId) => CheckoutOperationOutcome.Unknown;
    }
}

