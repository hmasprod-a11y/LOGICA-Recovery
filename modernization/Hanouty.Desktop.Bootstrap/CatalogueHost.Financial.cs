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
    private sealed class CashierBasketReader(Func<MySqlConnection> connections, CheckoutSession session)
        : ICurrentBasketReader
    {
        public IReadOnlyList<BasketDisplayLine> ReadCurrentBasket() =>
            MariaDbCashCheckoutServices.ReadCashSaleBasket(connections, session.PendingLines)
                .Select(line => new BasketDisplayLine(line.ArticleId, line.ArticleName, line.Quantity, line.UnitPrice))
                .ToArray();
    }

    private Func<string, CheckoutResolution, Func<string>, bool>? reviewedReset;
    private Func<AuthorizedCheckoutPaymentContext, bool>? setFinancialContext;
    private Func<bool>? endFinancialSession;

    // The existing Host owns one basket and one fixed register. A new payment
    // expectation is explicit for EACH sale; SQL still authorizes and prices it.
    public bool TrySetFinancialContext(AuthorizedCheckoutPaymentContext next) =>
        setFinancialContext?.Invoke(next) ?? false;
    public bool TryEndFinancialSession() => endFinancialSession?.Invoke() ?? false;

    private static AuthorizedCheckoutPaymentContext FreezeCashContext(
        AuthorizedCheckoutPaymentContext value)
    {
        ArgumentNullException.ThrowIfNull(value);
        // Freeze caller-owned lists before validating: callers cannot change
        // captured tender while a PIN dialog pumps Windows messages.
        var frozen = value with {
            Payments = Array.AsReadOnly(value.Payments?.ToArray() ?? Array.Empty<CheckoutPayment>())
        };
        if (string.IsNullOrWhiteSpace(frozen.CashierId) ||
            frozen.Currency != "MAD" || frozen.IsReturn ||
            frozen.Payments.Count != 1 ||
            frozen.Payments[0] is not { Kind: CheckoutPaymentKind.Cash, Amount: > 0m } ||
            frozen.ExpectedTotal <= 0m ||
            frozen.ExpectedTotal > frozen.Payments[0].Amount ||
            decimal.Round(frozen.Payments[0].Amount, 2) != frozen.Payments[0].Amount)
            throw new ArgumentException("Explicit MAD cash context required.", nameof(value));
        return frozen;
    }

    // The WPF reviewed-reset command invokes this only on explicit cashier
    // confirmation; PIN is freshly provided, never stored in ViewModel state.
    public bool TryReviewResolvedCheckout(string stableOperationId,
        CheckoutResolution expected, Func<string> transientReviewPin) =>
        reviewedReset?.Invoke(stableOperationId, expected, transientReviewPin) ?? false;

    // Interactive production composition: request a fresh masked PIN only at
    // posting time, never capture a credential in session/ViewModel state.
    public static CatalogueHost CreateInteractiveFinancial(CatalogueSettings settings,
        string twoDigitWorkstation, AuthorizedCheckoutPaymentContext paymentContext)
    {
        MainWindow? window = null;
        var host = CreateFinancial(settings, twoDigitWorkstation,
            () => window?.PromptCashierPin() ??
                throw new InvalidOperationException("Cashier window unavailable."),
            paymentContext);
        window = host.Window;
        return host;
    }

    // Real development cashier entry uses the SAME production graph, initially
    // signed out and without a dummy payment/identity/price.
    public static CatalogueHost CreateCashierWorkstation(CatalogueSettings settings,
        string twoDigitWorkstation)
    {
        MainWindow? window = null;
        var host = CreateFinancialCore(settings, twoDigitWorkstation,
            () => window?.PromptCashierPin() ??
                throw new InvalidOperationException("Cashier window unavailable."),
            null, null, null);
        window = host.Window;
        return host;
    }

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
        return CreateFinancialCore(settings, twoDigitWorkstation, transientPinProvider,
            FreezeCashContext(paymentContext), afterCommitAcknowledgementFault, postingFailureDiagnostic);
    }

    private static CatalogueHost CreateFinancialCore(CatalogueSettings settings,
        string twoDigitWorkstation, Func<string> transientPinProvider,
        AuthorizedCheckoutPaymentContext? initialContext, Action? afterCommitAcknowledgementFault,
        Action<Exception>? postingFailureDiagnostic)
    {
        ArgumentNullException.ThrowIfNull(settings);
        ArgumentNullException.ThrowIfNull(transientPinProvider);
        AuthorizedCheckoutPaymentContext? captured = initialContext;
        string? activeCashierId = captured?.CashierId;
        var contextConsumed = false;
        Func<MySqlConnection> connections = () => new MySqlConnection(settings.ConnectionString);
        var posting = MariaDbCashCheckoutServices.CreatePostingPort(
            connections, twoDigitWorkstation, transientPinProvider);
        posting = new AcknowledgementFaultPort(posting, () => {
            // Consume at the real financial boundary, not merely in UI state.
            // Retain the immutable context for lost-ack journal review only.
            contextConsumed = true;
            afterCommitAcknowledgementFault?.Invoke();
        }, postingFailureDiagnostic);
        var journal = MariaDbCashCheckoutServices.CreateOperationJournal(connections);
        var returnHost = new MariaDbFullCashReturnHost(connections, twoDigitWorkstation);
        var binding = ProductionWpfServices.CreateFinancial(
            new MariaDbCatalogueReader(settings.ConnectionString, settings.DataDirectory),
            new ExplicitVariantChoice(), posting, journal, () => !contextConsumed && captured is not null
                ? captured : throw new InvalidOperationException("Fresh payment context required."),
            returnHost);
        CashierPaymentContext? context = captured is null ? null : new CashierPaymentContext(captured.CashierId,
            twoDigitWorkstation, captured.Currency, "Cash", captured.Payments[0].Amount);
        // Reuse WPF's single-session adapter rather than maintain a second
        // contextual implementation in the Host. SQL still authenticates on commit.
        var services = AuthorizedWpfServiceRegistration.CreateSessionBound(
            binding.Catalogue, binding.Checkout, binding.Submission,
            () => contextConsumed && context?.TenderedAmount != 0m ? null! : context!);
        var basketReader = new CashierBasketReader(connections, binding.Session);
        var window = new MainWindow(services.Catalogue, services.Checkout, services.Submission, context,
            requireFreshPaymentContext: true, basketReader: basketReader);
        window.ConfigureOriginalSaleLookup(returnHost);
        var vm = (CatalogueViewModel)window.DataContext;
        vm.FinancialSessionActive = captured is not null;
        if (!vm.CatalogueAvailable)
            throw new InvalidOperationException("Local financial catalogue could not be loaded.");
        var result = new CatalogueHost(window, vm, binding.Session);
        string? lastReviewed = null;
        var reviewing = false;
        bool CanChangeContext() => !reviewing && !vm.CheckoutBusy &&
            !vm.CheckoutUncertain && vm.PendingOperationId is null &&
            binding.Session.OperationId is null && binding.Session.State == CheckoutCommitState.Ready;
        result.setFinancialContext = next =>
        {
            if (!CanChangeContext()) return false;
            AuthorizedCheckoutPaymentContext frozen;
            try { frozen = FreezeCashContext(next); }
            catch (ArgumentException) { return false; }
            // A staged basket belongs to its current cashier; changing amount
            // is allowed before submission, changing identity is not.
            if (binding.Session.PendingCount != 0 &&
                (activeCashierId is null || frozen.CashierId != activeCashierId))
                return false;
            captured = frozen;
            activeCashierId = frozen.CashierId;
            contextConsumed = false;
            context = new CashierPaymentContext(frozen.CashierId,
                twoDigitWorkstation, frozen.Currency, "Cash", frozen.Payments[0].Amount);
            vm.FinancialSessionActive = true;
            vm.PaymentContext = context;
            return true;
        };
        result.endFinancialSession = () =>
        {
            if (!CanChangeContext() || binding.Session.PendingCount != 0) return false;
            captured = null;
            activeCashierId = null;
            contextConsumed = true;
            context = null;
            vm.PaymentContext = null;
            vm.FinancialSessionActive = false;
            return true;
        };
        result.reviewedReset = (operation, expected, reviewPin) =>
        {
            if (reviewing || captured is null || context is null || reviewPin is null || string.IsNullOrWhiteSpace(operation) ||
                operation == lastReviewed ||
                expected is not (CheckoutResolution.Persisted or CheckoutResolution.Absent) ||
                !vm.CanReviewResolvedCheckout || vm.ReviewedResolution != expected ||
                !string.Equals(vm.PendingOperationId, operation, StringComparison.Ordinal) ||
                binding.Session.State != CheckoutCommitState.Ready)
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
                    binding.Session.State != CheckoutCommitState.Ready ||
                    !vm.RestoreAuthorizedPaymentContextAfterReview(context))
                    return false;
                binding.Session.DiscardInvalidated();
                contextConsumed = true;
                lastReviewed = operation;
                return true; // UI owner may now explicitly reset its review state.
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            {
                return false; // No UI unlock, automatic retry or financial posting.
            }
            finally { reviewing = false; }
        };
        decimal? ReadTrustedTotal()
        {
            if (!CanChangeContext()) return null;
            return MariaDbCashCheckoutServices.ReadCashSaleTotal(connections, binding.Session.PendingLines);
        }
        window.ConfigureBasketQuantity((articleId, quantity) =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive ||
                activeCashierId is null || !binding.Session.SetPendingQuantity(articleId, quantity))
                return false;
            captured = null;
            contextConsumed = true;
            context = new CashierPaymentContext(activeCashierId, twoDigitWorkstation, "MAD", "Cash", 0m);
            vm.PaymentContext = context;
            return true;
        });
        window.ConfigureCashierEntry((cashier, register, tender) => {
            if (!CanChangeContext() || register != twoDigitWorkstation ||
                string.IsNullOrWhiteSpace(cashier) || tender < 0m) return false;
            var total = ReadTrustedTotal();
            if (total is null) return false;
            if (binding.Session.PendingCount == 0)
            {
                // Empty-basket session entry is authentication, NOT a dummy sale.
                // Zero tender cannot mint a financial request.
                if (tender != 0m || total != 0m) return false;
                reviewing = true;
                try
                {
                    MariaDbCashCheckoutServices.VerifyCashierSession(connections, cashier,
                        () => window.PromptCashierPin(cashier));
                }
                catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
                { return false; }
                finally { reviewing = false; }
                if (!CanChangeContext() || binding.Session.PendingCount != 0) return false;
                activeCashierId = cashier;
                captured = null;
                contextConsumed = true;
                // A zero-tender context proves the authenticated cashier session
                // for read-only receipt selection. It can never authorize a sale;
                // Checkout sale preparation requires a positive cash settlement.
                context = new CashierPaymentContext(cashier, twoDigitWorkstation, "MAD", "Cash", 0m);
                vm.PaymentContext = context;
                vm.FinancialSessionActive = true;
                return true;
            }
            if (cashier != activeCashierId || total <= 0m || tender < total) return false;
            return result.TrySetFinancialContext(new AuthorizedCheckoutPaymentContext(
                cashier, "MAD", false, new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, tender) }, total.Value));
        }, ReadTrustedTotal, result.TryEndFinancialSession,
            () => System.Text.Json.JsonSerializer.Serialize(binding.Session.PendingLines));
        var cashClosing = new CashDrawerClosing(settings.ConnectionString);
        window.ConfigureCashDrawerClosing((counted, cashierOnly) =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive ||
                activeCashierId is not { } cashier || binding.Session.PendingCount != 0)
            {
                System.Windows.MessageBox.Show(window, "Terminez le panier en cours avant la clôture.", "Clôture");
                return false;
            }

            reviewing = true;
            try
            {
                var pin = window.PromptCashierPin(cashier);
                if (string.IsNullOrEmpty(pin)) return false;
                var preview = cashClosing.Read(cashier, pin, cashierOnly);
                var summary = $"Fond de caisse : {preview.Opening:N2} MAD\n" +
                    $"Ventes nettes : {preview.NetSales:N2} MAD\n" +
                    $"Espèces ventes et retours : {preview.CashSales:N2} MAD\n" +
                    $"Règlements clients en espèces : {preview.ClientCash:N2} MAD\n" +
                    $"Règlements fournisseurs en espèces : {preview.SupplierCash:N2} MAD\n" +
                    $"Dépenses : {preview.Expenses:N2} MAD\n" +
                    $"Attendu : {preview.Expected:N2} MAD\nCompté : {counted:N2} MAD\n" +
                    $"Écart : {counted - preview.Expected:N2} MAD\n\nValider la clôture n° {preview.Number} ?";
                if (System.Windows.MessageBox.Show(window, summary, cashierOnly ? "Clôture caissier" : "Clôture globale",
                        System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Question,
                        System.Windows.MessageBoxResult.No) != System.Windows.MessageBoxResult.Yes) return false;
                cashClosing.Close(cashier, pin, preview);
                var report = new System.Windows.Controls.TextBlock
                {
                    Text = summary[..summary.LastIndexOf("\n\n", StringComparison.Ordinal)],
                    Margin = new System.Windows.Thickness(20),
                    TextWrapping = System.Windows.TextWrapping.Wrap
                };
                var reportWindow = new System.Windows.Window
                {
                    Title = $"Clôture n° {preview.Number} enregistrée",
                    Owner = window, Width = 440, SizeToContent = System.Windows.SizeToContent.Height,
                    WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner
                };
                var layout = new System.Windows.Controls.StackPanel();
                layout.Children.Add(report);
                var print = new System.Windows.Controls.Button
                {
                    Content = "Imprimer le rapport", MinHeight = 38, Margin = new System.Windows.Thickness(20)
                };
                print.Click += (_, _) =>
                {
                    try
                    {
                        var dialog = new System.Windows.Controls.PrintDialog();
                        if (dialog.ShowDialog() == true)
                            dialog.PrintVisual(report, reportWindow.Title);
                    }
                    catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
                    {
                        System.Windows.MessageBox.Show(reportWindow,
                            "Impression indisponible. La clôture est enregistrée.", "Impression");
                    }
                };
                layout.Children.Add(print);
                reportWindow.Content = layout;
                reportWindow.ShowDialog();
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                System.Windows.MessageBox.Show(window, "Clôture non autorisée.", "Clôture");
                return false;
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException)
            {
                System.Windows.MessageBox.Show(window,
                    "La clôture n’a pas pu être confirmée. Vérifiez l’état des mouvements avant une nouvelle tentative.", "Clôture");
                return false;
            }
            finally { reviewing = false; }
        }, opening =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive ||
                activeCashierId is not { } cashier || binding.Session.PendingCount != 0) return false;

            reviewing = true;
            try
            {
                var pin = window.PromptCashierPin(cashier);
                if (string.IsNullOrEmpty(pin) || System.Windows.MessageBox.Show(window,
                    $"Enregistrer {opening:N2} MAD comme fond de caisse ?", "Fond de caisse",
                    System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Question,
                    System.Windows.MessageBoxResult.No) != System.Windows.MessageBoxResult.Yes) return false;
                cashClosing.SetOpening(cashier, pin, opening);
                return true;
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or UnauthorizedAccessException)
            {
                System.Windows.MessageBox.Show(window, "Le fond de caisse n’a pas pu être enregistré.", "Fond de caisse");
                return false;
            }
            finally { reviewing = false; }
        });
        window.ConfigureReviewedCheckout(result.TryReviewResolvedCheckout);
        return result;
    }

    private sealed class MariaDbFullCashReturnHost(
        Func<MySqlConnection> connections, string workstation) :
        IOriginalSaleLookup, ITrustedWpfFullCashReturnPreparation
    {
        public IReadOnlyList<OriginalSaleCandidate> FindPersistedSales(string receiptSearch) =>
            MariaDbCashCheckoutServices.FindFullCashReturnCandidates(connections, receiptSearch)
                .Select(sale => new OriginalSaleCandidate(sale.SaleId,
                    sale.SaleId + " — full cash ticket", sale.PaidMad))
                .ToArray();

        public AuthorizedCheckoutRequest PrepareFullCashReturn(
            string stableOperationId, string originalTicketId, CashierPaymentContext cashierContext)
        {
            ArgumentNullException.ThrowIfNull(cashierContext);
            if (!cashierContext.IsWellFormed ||
                !string.Equals(cashierContext.RegisterId, workstation, StringComparison.Ordinal) ||
                !string.Equals(cashierContext.CurrencyCode, "MAD", StringComparison.Ordinal) ||
                !string.Equals(cashierContext.TenderCode, "Cash", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Authorized local cashier context required.");
            return MariaDbCashCheckoutServices.PrepareFullCashReturnRequest(
                connections, stableOperationId, cashierContext.CashierId,
                cashierContext.CurrencyCode, originalTicketId);
        }
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
