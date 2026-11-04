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
    private Func<string, CheckoutResolution, Func<string>, bool>? reviewedReset;

    // The WPF reviewed-reset command invokes this only on explicit cashier
    // confirmation; PIN is freshly provided, never stored in ViewModel state.
    public bool TryReviewResolvedCheckout(string stableOperationId,
        CheckoutResolution expected, Func<string> transientReviewPin) =>
        reviewedReset?.Invoke(stableOperationId, expected, transientReviewPin) ?? false;

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
        var result = new CatalogueHost(window, vm, binding.Session);
        string? lastReviewed = null;
        var reviewing = false;
        result.reviewedReset = (operation, expected, reviewPin) =>
        {
            if (reviewing || reviewPin is null || string.IsNullOrWhiteSpace(operation) ||
                operation == lastReviewed ||
                expected is not (CheckoutResolution.Persisted or CheckoutResolution.Absent) ||
                !vm.CanReviewResolvedCheckout || vm.ReviewedResolution != expected ||
                !string.Equals(vm.PendingOperationId, operation, StringComparison.Ordinal) ||
                vm.PaymentContext != context || binding.Session.State != CheckoutCommitState.Ready)
                return false;
            reviewing = true;
            try
            {
                var outcome = expected == CheckoutResolution.Persisted
                    ? CheckoutOperationOutcome.Persisted : CheckoutOperationOutcome.Absent;
                if (journal.Lookup(operation) != outcome) return false;
                MariaDbCashCheckoutServices.VerifyCashierSession(connections, captured.CashierId, reviewPin);
                // PIN entry can pump UI events. Recheck durable/session identity
                // after reauthorization before touching even the staged draft.
                if (journal.Lookup(operation) != outcome ||
                    !vm.CanReviewResolvedCheckout || vm.ReviewedResolution != expected ||
                    !string.Equals(vm.PendingOperationId, operation, StringComparison.Ordinal) ||
                    vm.PaymentContext != context || binding.Session.State != CheckoutCommitState.Ready)
                    return false;
                binding.Session.DiscardInvalidated();
                lastReviewed = operation;
                return true; // UI owner may now explicitly reset its review state.
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            {
                return false; // No UI unlock, automatic retry or financial posting.
            }
            finally { reviewing = false; }
        };
        return result;
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
