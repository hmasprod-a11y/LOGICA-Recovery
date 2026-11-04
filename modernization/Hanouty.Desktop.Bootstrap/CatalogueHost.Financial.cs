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
        AuthorizedCheckoutPaymentContext paymentContext)
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
        var journal = MariaDbCashCheckoutServices.CreateOperationJournal(connections);
        var binding = ProductionWpfServices.CreateFinancial(
            new MariaDbCatalogueReader(settings.ConnectionString, settings.DataDirectory),
            new ExplicitVariantChoice(), posting, journal, () => captured);
        var context = new CashierPaymentContext(captured.CashierId,
            twoDigitWorkstation, captured.Currency, "Cash", captured.Payments[0].Amount);
        var submission = new FinancialSessionSubmission(binding, context);
        var window = new MainWindow(binding.Catalogue, binding.Checkout, submission, context);
        var vm = (CatalogueViewModel)window.DataContext;
        if (!vm.CatalogueAvailable)
            throw new InvalidOperationException("Local financial catalogue could not be loaded.");
        return new CatalogueHost(window, vm, binding.Session);
    }

    private sealed class FinancialSessionSubmission : IContextualCheckoutSubmission,
        ICheckoutOutcomeReconciliation
    {
        private readonly WpfProductionBinding binding;
        private readonly CashierPaymentContext context;
        internal FinancialSessionSubmission(WpfProductionBinding binding, CashierPaymentContext context)
        {
            this.binding = binding;
            this.context = context;
        }

        public CheckoutSubmissionResult Submit(string stableOperationId) =>
            throw new InvalidOperationException("Explicit cash-session context required.");

        public CheckoutSubmissionResult Submit(string stableOperationId, CashierPaymentContext supplied)
        {
            if (supplied != context) return CheckoutSubmissionResult.Invalidated;
            return binding.Submission.Submit(stableOperationId);
        }

        public CheckoutResolution Reconcile(string stableOperationId)
        {
            if (binding.Session.State != CheckoutCommitState.OutcomeUnknown ||
                !string.Equals(binding.Session.OperationId, stableOperationId, StringComparison.Ordinal))
                return CheckoutResolution.Unknown;
            return binding.Session.Reconcile() switch {
                CheckoutOperationOutcome.Persisted => CheckoutResolution.Persisted,
                CheckoutOperationOutcome.Absent => CheckoutResolution.Absent,
                _ => CheckoutResolution.Unknown
            };
        }
    }
}
