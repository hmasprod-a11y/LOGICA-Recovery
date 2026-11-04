using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using Hanouty.Desktop.Wpf;
using Hanouty.Desktop.Wpf.Presentation;
using Hanouty.Inventory.MariaDb;
using Hanouty.WpfContractAdapter;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

// Included only when the build explicitly references the real Checkout library.
public sealed partial record CatalogueHost
{
    public static CatalogueHost CreateFinancial(CatalogueSettings settings,
        string twoDigitWorkstation, Func<string> transientPinProvider,
        AuthorizedCheckoutPaymentContext paymentContext) =>
        CreateFinancial(settings, twoDigitWorkstation, transientPinProvider, paymentContext, null);

    // Internal executable acceptance seam. Fault runs AFTER the real MariaDB
    // port returns from Commit; it cannot substitute posting or financial writers.
    internal static CatalogueHost CreateFinancial(CatalogueSettings settings,
        string twoDigitWorkstation, Func<string> transientPinProvider,
        AuthorizedCheckoutPaymentContext paymentContext, Action? afterCommitAcknowledgementFault,
        Action<Exception>? postingFailureDiagnostic = null)
    {
        ArgumentNullException.ThrowIfNull(settings);
        ArgumentNullException.ThrowIfNull(transientPinProvider);
        ArgumentNullException.ThrowIfNull(paymentContext);
        // Capture tender once. SQL preparation remains the sole price and
        // authentication authority; this context cannot grant a sale permission.
        if (string.IsNullOrWhiteSpace(paymentContext.CashierId) ||
            paymentContext.Currency != "MAD" || paymentContext.IsReturn ||
            paymentContext.Payments is null || paymentContext.Payments.Count != 1 ||
            paymentContext.Payments[0] is not { Kind: CheckoutPaymentKind.Cash, Amount: > 0m } ||
            paymentContext.ExpectedTotal != paymentContext.Payments[0].Amount)
            throw new ArgumentException("Explicit MAD exact-cash session context required.", nameof(paymentContext));
        var captured = paymentContext with {
            Payments = Array.AsReadOnly(paymentContext.Payments.ToArray())
        };
        Func<MySqlConnection> connections = () => new MySqlConnection(settings.ConnectionString);
        var posting = MariaDbCashCheckoutServices.CreatePostingPort(
            connections, twoDigitWorkstation, transientPinProvider);
        if (afterCommitAcknowledgementFault is not null || postingFailureDiagnostic is not null)
            posting = new AcknowledgementFaultPort(posting, afterCommitAcknowledgementFault, postingFailureDiagnostic);
        var journal = MariaDbCashCheckoutServices.CreateOperationJournal(connections);
        var binding = ProductionWpfServices.CreateFinancial(
            new MariaDbCatalogueReader(settings.ConnectionString, settings.DataDirectory),
            new ExplicitVariantChoice(), posting, journal, () => captured);
        var context = new CashierPaymentContext(captured.CashierId,
            twoDigitWorkstation, captured.Currency, "Cash", captured.Payments[0].Amount);
        // Reuse WPF's single-session adapter rather than maintain a second
        // contextual implementation in the Host. SQL still authenticates on commit.
        var services = AuthorizedWpfServiceRegistration.CreateSessionBound(
            binding.Catalogue, binding.Checkout, binding.Submission, () => context);
        var window = new MainWindow(services.Catalogue, services.Checkout, services.Submission, context);
        var vm = (CatalogueViewModel)window.DataContext;
        if (!vm.CatalogueAvailable)
            throw new InvalidOperationException("Local financial catalogue could not be loaded.");
        return new CatalogueHost(window, vm, binding.Session);
    }

    private sealed class AcknowledgementFaultPort(
        IAuthorizedCheckoutPort actualPosting, Action? afterCommit, Action<Exception>? diagnostic) : IAuthorizedCheckoutPort
    {
        public void Commit(AuthorizedCheckoutRequest request)
        {
            try { actualPosting.Commit(request); }
            catch (Exception ex) { diagnostic?.Invoke(ex); throw; }
            afterCommit?.Invoke();
        }
    }

}
