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
    private sealed class CashierBasketReader(Func<MySqlConnection> connections, CheckoutSession session,
        Func<ApprovedManualDiscount?> currentManualDiscount)
        : ICurrentBasketReader
    {
        public IReadOnlyList<BasketDisplayLine> ReadCurrentBasket() =>
            MariaDbCashCheckoutServices.ReadCashSaleBasket(connections, session.PendingLines, currentManualDiscount())
                .Select(line => new BasketDisplayLine(line.ArticleId, line.ArticleName, line.Quantity, line.UnitPrice,
                    line.DiscountPercent, line.Amount))
                .ToArray();
    }

    private sealed class ManualDiscountReview(
        Func<ManualDiscountChoice, ManualDiscountPreviewData> preview,
        Func<ManualDiscountChoice, bool> apply, Action release) : IManualDiscountReview
    {
        private bool disposed;
        public ManualDiscountPreviewData Preview(ManualDiscountChoice choice)
        {
            if (disposed) throw new ObjectDisposedException(nameof(ManualDiscountReview));
            return preview(choice);
        }
        public bool Apply(ManualDiscountChoice choice)
        {
            if (disposed) throw new ObjectDisposedException(nameof(ManualDiscountReview));
            return apply(choice);
        }
        public void Dispose() { if (!disposed) { disposed = true; release(); } }
    }

    private Func<string, CheckoutResolution, Func<string>, bool>? reviewedReset;
    private Func<AuthorizedCheckoutPaymentContext, bool>? setFinancialContext;
    private Func<bool>? endFinancialSession;

    // The existing Host owns one basket and one fixed register. A new payment
    // expectation is explicit for EACH sale; SQL still authorizes and prices it.
    public bool TrySetFinancialContext(AuthorizedCheckoutPaymentContext next) =>
        setFinancialContext?.Invoke(next) ?? false;
    public bool TryEndFinancialSession() => endFinancialSession?.Invoke() ?? false;

    private static AuthorizedCheckoutPaymentContext FreezePaymentContext(
        AuthorizedCheckoutPaymentContext value)
    {
        ArgumentNullException.ThrowIfNull(value);
        // Freeze caller-owned lists before validating: callers cannot change
        // captured tender while a PIN dialog pumps Windows messages.
        var frozen = value with {
            Payments = Array.AsReadOnly(value.Payments?.ToArray() ?? Array.Empty<CheckoutPayment>())
        };
        var credit = frozen.Payments.Count == 1 && frozen.Payments[0]?.Kind == CheckoutPaymentKind.Credit;
        if (credit)
        {
            if (string.IsNullOrWhiteSpace(frozen.CashierId) || frozen.Currency != "MAD" || frozen.IsReturn ||
                frozen.Customer is null || frozen.ExpectedTotal <= 0m || frozen.Payments[0].Amount != frozen.ExpectedTotal ||
                decimal.Round(frozen.ExpectedTotal, 2) != frozen.ExpectedTotal)
                throw new ArgumentException("Le crédit doit correspondre au net du ticket.");
            frozen.Customer.Validate();
            return frozen;
        }
        if (frozen.Customer is not null) throw new ArgumentException("Client inattendu pour ce mode de vente.");
        if (string.IsNullOrWhiteSpace(frozen.CashierId) || frozen.Currency != "MAD" || frozen.IsReturn ||
            frozen.ExpectedTotal <= 0m || frozen.Payments.Count is < 1 or > 2 ||
            frozen.Payments.Any(payment => payment is null || payment.Amount <= 0m ||
                decimal.Round(payment.Amount, 2) != payment.Amount ||
                payment.Kind is not (CheckoutPaymentKind.Cash or CheckoutPaymentKind.Card)) ||
            frozen.Payments.Select(payment => payment.Kind).Distinct().Count() != frozen.Payments.Count)
            throw new ArgumentException("Explicit cash/card context required.", nameof(value));
        decimal paid;
        try { paid = frozen.Payments.Sum(payment => payment.Amount); }
        catch (OverflowException ex) { throw new ArgumentException("Payment allocation exceeds the supported range.", nameof(value), ex); }
        var card = frozen.Payments.Where(payment => payment.Kind == CheckoutPaymentKind.Card).Sum(payment => payment.Amount);
        if (paid < frozen.ExpectedTotal ||
            (frozen.Payments.Count == 1 && card > 0m && card != frozen.ExpectedTotal) ||
            (frozen.Payments.Count == 2 && card >= frozen.ExpectedTotal))
            throw new ArgumentException("Payment allocation does not cover the authoritative total.", nameof(value));
        return frozen;
    }

    private static CashierPaymentContext ToWpfContext(AuthorizedCheckoutPaymentContext value, string register)
    {
        if (value.Payments.Count == 1)
            return new CashierPaymentContext(value.CashierId, register, value.Currency,
                value.Payments[0].Kind.ToString(), value.Payments[0].Amount);
        return new CashierPaymentContext(value.CashierId, register, value.Currency, "Mixed",
            value.Payments.Single(payment => payment.Kind == CheckoutPaymentKind.Cash).Amount,
            value.Payments.Single(payment => payment.Kind == CheckoutPaymentKind.Card).Amount);
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
        string twoDigitWorkstation, Func<System.Windows.Window, string?>? selectImportFile = null) =>
        CreateWorkstationCore(settings, twoDigitWorkstation, selectImportFile, null);

    // Daily LOGICA flow: authenticate once at entry, then use that session for
    // ordinary operations. Explicit engineering APIs retain their fresh-PIN seam.
    public static CatalogueHost CreateDailyCashierWorkstation(CatalogueSettings settings,
        string twoDigitWorkstation, Func<System.Windows.Window, string?>? selectImportFile = null) =>
        CreateWorkstationCore(settings, twoDigitWorkstation, selectImportFile, null, true);

    internal static CatalogueHost CreateCashierWorkstationWithAcknowledgementFault(
        CatalogueSettings settings, string twoDigitWorkstation, Action afterCommitFault) =>
        CreateWorkstationCore(settings, twoDigitWorkstation, null, afterCommitFault);

    private static CatalogueHost CreateWorkstationCore(CatalogueSettings settings,
        string twoDigitWorkstation, Func<System.Windows.Window, string?>? selectImportFile, Action? afterCommitFault, bool sessionAuthorization = false)
    {
        MainWindow? window = null;
        var credentials = sessionAuthorization ? new CashierSessionCredentials() : null;
        var host = CreateFinancialCore(settings, twoDigitWorkstation,
            () => credentials?.Read() ?? window?.PromptCashierPin() ??
                throw new InvalidOperationException("Cashier window unavailable."),
            null, afterCommitFault, afterCommitFault is null ? null : ex => Console.Error.WriteLine(ex), selectImportFile, credentials);
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
            FreezePaymentContext(paymentContext), afterCommitAcknowledgementFault, postingFailureDiagnostic);
    }

    private static CatalogueHost CreateFinancialCore(CatalogueSettings settings,
        string twoDigitWorkstation, Func<string> transientPinProvider,
        AuthorizedCheckoutPaymentContext? initialContext, Action? afterCommitAcknowledgementFault,
        Action<Exception>? postingFailureDiagnostic,
        Func<System.Windows.Window, string?>? selectImportFile = null, CashierSessionCredentials? sessionCredentials = null)
    {
        ArgumentNullException.ThrowIfNull(settings);
        ArgumentNullException.ThrowIfNull(transientPinProvider);
        AuthorizedCheckoutPaymentContext? captured = initialContext;
        string? activeCashierId = captured?.CashierId;
        var contextConsumed = false;
        string? waitingSaleId = null;
        ApprovedManualDiscount? manualDiscount = null;
        var utf8Connection = new MySqlConnectionStringBuilder(settings.ConnectionString) { CharacterSet = "utf8mb4" }.ConnectionString;
        Func<MySqlConnection> connections = () => new MySqlConnection(utf8Connection);
        var posting = MariaDbCashCheckoutServices.CreatePostingPort(
            connections, twoDigitWorkstation, transientPinProvider, () => waitingSaleId, () => manualDiscount, WorkstationPrinterProfile.FeatureDirectory(settings));
        posting = new AcknowledgementFaultPort(posting, () => {
            // Consume at the real financial boundary, not merely in UI state.
            // Retain the immutable context for lost-ack journal review only.
            contextConsumed = true;
            waitingSaleId = null;
            manualDiscount = null;
            afterCommitAcknowledgementFault?.Invoke();
        }, postingFailureDiagnostic);
        var journal = MariaDbCashCheckoutServices.CreateOperationJournal(connections);
        var returnHost = new MariaDbFullCashReturnHost(connections, twoDigitWorkstation);
        var binding = ProductionWpfServices.CreateFinancial(
            new MariaDbCatalogueReader(settings.ConnectionString, settings.DataDirectory),
            new ExplicitVariantChoice(), posting, journal, () => !contextConsumed && captured is not null
                ? captured : throw new InvalidOperationException("Fresh payment context required."),
            returnHost);
        CashierPaymentContext? context = captured is null ? null : ToWpfContext(captured, twoDigitWorkstation);
        // Reuse WPF's single-session adapter rather than maintain a second
        // contextual implementation in the Host. SQL still authenticates on commit.
        var services = AuthorizedWpfServiceRegistration.CreateSessionBound(
            binding.Catalogue, binding.Checkout, binding.Submission,
            () => contextConsumed && context?.TenderedAmount != 0m ? null! : context!);
        ApprovedManualDiscount? CurrentManualDiscount()
        {
            manualDiscount = MariaDbCashCheckoutServices.RetainManualDiscountForBasket(manualDiscount, binding.Session.PendingLines);
            if (manualDiscount?.CashierId != activeCashierId) manualDiscount = null;
            return manualDiscount;
        }
        var basketReader = new CashierBasketReader(connections, binding.Session, CurrentManualDiscount);
        var window = new MainWindow(services.Catalogue, services.Checkout, services.Submission, context,
            requireFreshPaymentContext: true, basketReader: basketReader);
        var vm = (CatalogueViewModel)window.DataContext;
        vm.FinancialSessionActive = captured is not null;
        if (!vm.CatalogueAvailable)
            throw new InvalidOperationException("Local financial catalogue could not be loaded.");
        var result = new CatalogueHost(window, vm, binding.Session);
        string ReadCashierPin(string actor) => sessionCredentials?.Read(actor) ?? window.PromptCashierPin(actor);
        window.Closed += (_, _) => sessionCredentials?.Dispose();
        string? lastReviewed = null;
        var reviewing = false;
        var customerFilesOpen = false;
        var businessDocumentsOpen = false;
        var dailyStockOpen = false;
        var dailyStockChild = false;
        bool CanChangeContext() => !dailyStockOpen && ReadyContext();
        bool CanChangeStockContext() => (!dailyStockOpen || dailyStockChild) && ReadyContext();
        bool ReadyContext() => !businessDocumentsOpen && !customerFilesOpen && !reviewing && !vm.CheckoutBusy &&
            !vm.CheckoutUncertain && vm.PendingOperationId is null &&
            binding.Session.OperationId is null && binding.Session.State == CheckoutCommitState.Ready;
        window.ConfigureManualDiscounts(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } cashier ||
                binding.Session.PendingCount == 0) return null;
            reviewing = true;
            try
            {
                var snapshot = binding.Session.PendingLines.ToArray();
                var previous = CurrentManualDiscount();
                var authorization = MariaDbCashCheckoutServices.AuthorizeManualDiscount(connections, cashier,
                    twoDigitWorkstation, window.PromptDiscountApprovalPin);
                ManualDiscountChoice? reviewedChoice = null;
                Hanouty.Checkout.MariaDb.ManualDiscountPreview? reviewedPreview = null;
                void RequireSameReview()
                {
                    if (!reviewing || !vm.FinancialSessionActive || activeCashierId != cashier ||
                        vm.CheckoutBusy || vm.CheckoutUncertain || vm.PendingOperationId is not null ||
                        !snapshot.SequenceEqual(binding.Session.PendingLines))
                        throw new InvalidOperationException("Le panier ou la session a changé. Revoyez la remise.");
                }
                return new ManualDiscountReview(choice =>
                {
                    RequireSameReview();
                    var preview = MariaDbCashCheckoutServices.PreviewManualDiscount(connections, authorization,
                        snapshot, previous, choice.ArticleId, choice.Percentage, choice.Value);
                    reviewedChoice = choice;
                    reviewedPreview = preview;
                    return new ManualDiscountPreviewData(preview.Percentage, preview.NetTotal, preview.Savings, preview.Conditions);
                }, choice =>
                {
                    RequireSameReview();
                    if (reviewedChoice != choice || reviewedPreview is null)
                        throw new InvalidOperationException("Vérifiez le calcul de la remise avant de confirmer.");
                    var approved = MariaDbCashCheckoutServices.ApplyManualDiscount(connections, authorization,
                        snapshot, previous, choice.ArticleId, choice.Percentage, choice.Value, reviewedPreview);
                    manualDiscount = approved;
                    captured = null;
                    contextConsumed = true;
                    context = new CashierPaymentContext(cashier, twoDigitWorkstation, "MAD", "Cash", 0m);
                    vm.PaymentContext = context;
                    return true;
                }, () => reviewing = false);
            }
            catch { reviewing = false; throw; }
        }, () => activeCashierId is { } cashier && vm.FinancialSessionActive &&
            MariaDbCashCheckoutServices.CanUseManualDiscount(connections, cashier));
        window.ConfigureReturnPaymentMode(mode =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is null || binding.Session.PendingCount != 0) return false;
            returnHost.Mode = mode;
            return true;
        });
        returnHost.Confirm = request =>
        {
            var printedNumber = request.Payments[0].Kind == CheckoutPaymentKind.Card
                ? MariaDbCashCheckoutServices.FindFullCardReturnCandidatesByReceipt(connections, request.OriginalTicketId!).Single(row => row.SaleId == request.OriginalTicketId).TicketNumber
                : null;
            return ConfirmCashDrawer(window,
            request.Payments[0].Kind == CheckoutPaymentKind.Credit
                ? $"Retour crédit de {request.ExpectedTotal:N2} MAD pour {request.Customer?.Name}.\nCette opération réduit la dette et remet le stock. Aucun remboursement espèces."
                : $"Ticket {printedNumber} : remboursement CARTE de {request.ExpectedTotal:N2} MAD.\nConfirmez que le remboursement a été effectué sur le terminal externe. Aucun remboursement espèces.",
            request.Payments[0].Kind == CheckoutPaymentKind.Credit ? "Confirmer le retour crédit" : "Confirmer le remboursement CARTE");
        };
        returnHost.SelectPartial = (candidate, operation, cashier) =>
        {
            var dialog = new PartialCashReturnDialog(candidate.TicketNumber, candidate.Lines,
                MariaDbCashCheckoutServices.IsPartialCashReturnLineSupported,
                selections => MariaDbCashCheckoutServices.PreparePartialCashReturnRequest(connections, operation, cashier, "MAD", candidate.SaleId, selections).ExpectedTotal) { Owner = window };
            return dialog.ShowDialog() == true ? dialog.Selections : null;
        };
        window.ConfigureOriginalSaleLookup(returnHost, () =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is null ||
                binding.Session.PendingCount != 0) return false;
            // A return uses persisted original amounts, never a consumed sale tender.
            contextConsumed = true;
            manualDiscount = null;
            context = new CashierPaymentContext(activeCashierId, twoDigitWorkstation, "MAD", returnHost.Mode == "PartialCash" ? "Cash" : returnHost.Mode, 0m);
            vm.PaymentContext = context;
            return true;
        });
        result.setFinancialContext = next =>
        {
            if (!CanChangeContext()) return false;
            AuthorizedCheckoutPaymentContext frozen;
            try { frozen = FreezePaymentContext(next); }
            catch (ArgumentException) { return false; }
            // A staged basket belongs to its current cashier; changing amount
            // is allowed before submission, changing identity is not.
            if (binding.Session.PendingCount != 0 &&
                (activeCashierId is null || frozen.CashierId != activeCashierId))
                return false;
            captured = frozen;
            if (binding.Session.PendingCount == 0 || activeCashierId != frozen.CashierId) manualDiscount = null;
            activeCashierId = frozen.CashierId;
            contextConsumed = false;
            context = ToWpfContext(frozen, twoDigitWorkstation);
            vm.FinancialSessionActive = true;
            vm.PaymentContext = context;
            return true;
        };
        result.endFinancialSession = () =>
        {
            if (!CanChangeContext() || binding.Session.PendingCount != 0) return false;
            captured = null;
            activeCashierId = null;
            sessionCredentials?.Clear();
            manualDiscount = null;
            waitingSaleId = null;
            contextConsumed = true;
            context = null;
            vm.PaymentContext = null;
            vm.FinancialSessionActive = false;
            return true;
        };
        result.reviewedReset = (operation, expected, reviewPin) =>
        {
            var actor = activeCashierId;
            var reviewedContext = context;
            if (reviewing || actor is null || reviewedContext is null || reviewedContext.CashierId != actor ||
                reviewPin is null || string.IsNullOrWhiteSpace(operation) ||
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
                MariaDbCashCheckoutServices.VerifyCashierSession(connections, actor, reviewPin);
                // PIN entry can pump UI events. Recheck durable/session identity
                // after reauthorization before touching even the staged draft.
                if (activeCashierId != actor || !ReferenceEquals(context, reviewedContext) ||
                    journal.Lookup(operation) != outcome ||
                    !vm.CanReviewResolvedCheckout || vm.ReviewedResolution != expected ||
                    !string.Equals(vm.PendingOperationId, operation, StringComparison.Ordinal) ||
                    binding.Session.State != CheckoutCommitState.Ready ||
                    !vm.RestoreAuthorizedPaymentContextAfterReview(reviewedContext))
                    return false;
                binding.Session.DiscardInvalidated();
                waitingSaleId = null;
                manualDiscount = null;
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
            return MariaDbCashCheckoutServices.ReadCashSaleTotal(connections, binding.Session.PendingLines, CurrentManualDiscount());
        }
        window.ConfigureBasketQuantity((articleId, quantity) =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive ||
                activeCashierId is null)
                return false;
            if(sessionCredentials is not null)
            {
                try
                {
                    MariaDbCashCheckoutServices.VerifyCashierSession(connections,activeCashierId,()=>ReadCashierPin(activeCashierId));
                    if(!OriginalCashierPermissions.Authorize(connections,activeCashierId,quantity==0?"ANNULATION":"MODIF_QTE",window.PromptCashDrawerApproval))
                    {window.SetBasketActionFeedback("Cette modification n’est pas autorisée pour le caissier.");return false;}
                }
                catch(Exception ex)when(ex is not OutOfMemoryException and not StackOverflowException){window.SetBasketActionFeedback("La session ou les droits ont changé. Reconnectez le caissier.");return false;}
            }
            if(!binding.Session.SetPendingQuantity(articleId,quantity))return false;
            if (binding.Session.PendingCount == 0) waitingSaleId = null;
            CurrentManualDiscount();
            captured = null;
            contextConsumed = true;
            context = new CashierPaymentContext(activeCashierId, twoDigitWorkstation, "MAD", "Cash", 0m);
            vm.PaymentContext = context;
            return true;
        });
        window.ConfigureBasketClear(()=>
        {
            if(!CanChangeContext()||!vm.FinancialSessionActive||activeCashierId is not {} actor||binding.Session.PendingCount==0)return false;
            try
            {
                MariaDbCashCheckoutServices.VerifyCashierSession(connections,actor,()=>ReadCashierPin(actor));
                if(sessionCredentials is not null&&!OriginalCashierPermissions.Authorize(connections,actor,"ANNULATION",window.PromptCashDrawerApproval))return false;
                binding.Session.DiscardInvalidated();manualDiscount=null;waitingSaleId=null;captured=null;contextConsumed=true;
                context=new CashierPaymentContext(actor,twoDigitWorkstation,"MAD","Cash",0m);vm.PaymentContext=context;return true;
            }
            catch(Exception ex)when(ex is not OutOfMemoryException and not StackOverflowException){window.SetBasketActionFeedback("Le panier n’a pas été annulé. Vérifiez la session et les droits.");return false;}
        });
        window.ConfigurePinLogin(pin =>
        {
            if (!CanChangeContext() || binding.Session.PendingCount != 0 || ReadTrustedTotal() != 0m) return false;
            string cashier;
            reviewing = true;
            try
            {
                cashier = LogicaPinLogin.Resolve(connections, pin);
                MariaDbCashCheckoutServices.VerifyCashierSession(connections, cashier, () => pin);
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { window.SetLoginFeedback("Code d’accès incorrect ou utilisateur indisponible."); return false; }
            finally { reviewing = false; }
            if (!CanChangeContext() || binding.Session.PendingCount != 0 || ReadTrustedTotal() != 0m) return false;
            sessionCredentials?.Bind(cashier, pin);
            activeCashierId = cashier; captured = null; contextConsumed = true; manualDiscount = null; waitingSaleId = null;
            context = new CashierPaymentContext(cashier, twoDigitWorkstation, "MAD", "Cash", 0m);
            vm.PaymentContext = context; vm.FinancialSessionActive = true;
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
                        () => ReadCashierPin(cashier));
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
            () => System.Text.Json.JsonSerializer.Serialize(binding.Session.PendingLines), () =>
            {
                if (!vm.FinancialSessionActive || activeCashierId is null) return null;
                return new CashierPaymentContext(activeCashierId, twoDigitWorkstation, "MAD", "Cash", 0m);
            });
        window.ConfigureCardPayment(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor ||
                binding.Session.PendingCount == 0) return false;
            if (!MariaDbCashCheckoutServices.IsCardPaymentAvailable(connections))
            {
                window.SetCardPaymentFeedback("Le mode CARTE n’est pas disponible dans la configuration des paiements.");
                return false;
            }
            var total = ReadTrustedTotal();
            if (total is null or <= 0m) return false;
            var basket = binding.Session.PendingLines.ToArray();
            reviewing = true;
            bool confirmed;
            try { confirmed = new CardPaymentDialog(total.Value) { Owner = window }.ShowDialog() == true; }
            finally { reviewing = false; }
            if (!confirmed || !CanChangeContext() || activeCashierId != actor ||
                !vm.FinancialSessionActive || !binding.Session.PendingLines.SequenceEqual(basket) ||
                ReadTrustedTotal() != total) return false;
            if (!result.TrySetFinancialContext(new AuthorizedCheckoutPaymentContext(actor, "MAD", false,
                new[] { new CheckoutPayment(CheckoutPaymentKind.Card, total.Value) }, total.Value))) return false;
            vm.CommitCheckout();
            return !vm.CheckoutUncertain && binding.Session.PendingCount == 0;
        });
        window.ConfigureMixedPayment(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor ||
                binding.Session.PendingCount == 0) return false;
            if (!MariaDbCashCheckoutServices.IsCardPaymentAvailable(connections))
            {
                window.SetCardPaymentFeedback("Le mode CARTE n’est pas disponible dans la configuration des paiements.");
                return false;
            }
            var total = ReadTrustedTotal();
            if (total is null or <= 0m) return false;
            var basket = binding.Session.PendingLines.ToArray();
            reviewing = true;
            var dialog = new MixedPaymentDialog(total.Value) { Owner = window };
            bool confirmed;
            try { confirmed = dialog.ShowDialog() == true; }
            finally { reviewing = false; }
            if (!confirmed || dialog.Draft is not { } draft || !CanChangeContext() || activeCashierId != actor ||
                !vm.FinancialSessionActive || !binding.Session.PendingLines.SequenceEqual(basket) ||
                ReadTrustedTotal() != total) return false;
            if (!result.TrySetFinancialContext(new AuthorizedCheckoutPaymentContext(actor, "MAD", false,
                new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, draft.Cash),
                    new CheckoutPayment(CheckoutPaymentKind.Card, draft.Card) }, total.Value))) return false;
            vm.CommitCheckout();
            return !vm.CheckoutUncertain && binding.Session.PendingCount == 0;
        });
        window.ConfigureCreditSales(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor ||
                binding.Session.PendingCount == 0) return false;
            if (!MariaDbCashCheckoutServices.IsCreditSaleEnabled(WorkstationPrinterProfile.FeatureDirectory(settings)))
            {
                window.SetCardPaymentFeedback("La gestion du crédit est désactivée dans la configuration LOGICA.");
                window.RefreshCreditSaleAvailability();
                return false;
            }
            var total = ReadTrustedTotal();
            if (total is null or <= 0m) return false;
            var basket = binding.Session.PendingLines.ToArray();
            reviewing = true;
            var dialog = new CreditSaleDialog(total.Value, search =>
                MariaDbCashCheckoutServices.FindCreditCustomers(connections, search)
                    .Select(customer => new CreditCustomerChoice(customer.Id, customer.Code, customer.Name, customer.Telephone)).ToArray()) { Owner = window };
            bool confirmed;
            try { confirmed = dialog.ShowDialog() == true; }
            finally { reviewing = false; }
            if (!confirmed || dialog.Customer is not { } selected || !CanChangeContext() || activeCashierId != actor ||
                !vm.FinancialSessionActive || !binding.Session.PendingLines.SequenceEqual(basket) ||
                ReadTrustedTotal() != total || !MariaDbCashCheckoutServices.IsCreditSaleEnabled(WorkstationPrinterProfile.FeatureDirectory(settings))) return false;
            if (!result.TrySetFinancialContext(new AuthorizedCheckoutPaymentContext(actor, "MAD", false,
                new[] { new CheckoutPayment(CheckoutPaymentKind.Credit, total.Value) }, total.Value,
                new CheckoutCustomerIdentity(selected.Id, selected.Code, selected.Name)))) return false;
            vm.CommitCheckout();
            return !vm.CheckoutUncertain && binding.Session.PendingCount == 0;
        }, () => MariaDbCashCheckoutServices.IsCreditSaleEnabled(WorkstationPrinterProfile.FeatureDirectory(settings)));
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
                var pin = ReadCashierPin(cashier);
                if (string.IsNullOrEmpty(pin)) return false;
                var role = cashClosing.RequiredApprovalRole(cashier, pin);
                var approvalPin = role is null ? null : window.PromptCashDrawerApproval(role);
                if (role is not null && string.IsNullOrEmpty(approvalPin)) return false;
                var preview = cashClosing.Read(cashier, pin, cashierOnly, approvalPin);
                var summary = $"Fond de caisse : {preview.Opening:N2} MAD\n" +
                    $"Ventes nettes : {preview.NetSales:N2} MAD\n" +
                    $"Espèces ventes et retours : {preview.CashSales:N2} MAD\n" +
                    $"Règlements clients en espèces : {preview.ClientCash:N2} MAD\n" +
                    $"Règlements fournisseurs en espèces : {preview.SupplierCash:N2} MAD\n" +
                    $"Dépenses : {preview.Expenses:N2} MAD\n" +
                    $"Attendu : {preview.Expected:N2} MAD\nCompté : {counted:N2} MAD\n" +
                    $"Écart : {counted - preview.Expected:N2} MAD\n\nValider la clôture n° {preview.Number} ?";
                if (!ConfirmCashDrawer(window, summary, cashierOnly ? "Clôture caissier" : "Clôture globale")) return false;
                cashClosing.Close(cashier, pin, preview, approvalPin);
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
                var pin = ReadCashierPin(cashier);
                if (string.IsNullOrEmpty(pin) || !ConfirmCashDrawer(window,
                    $"Enregistrer {opening:N2} MAD comme fond de caisse ?", "Fond de caisse")) return false;
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
        window.ConfigureExpenses(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive ||
                activeCashierId is not { } cashier || binding.Session.PendingCount != 0) return;
            reviewing = true;
            try
            {
                var pin = ReadCashierPin(cashier);
                if (string.IsNullOrEmpty(pin)) return;
                var role = cashClosing.RequiredApprovalRole(cashier, pin, expense: true);
                var approval = role is null ? null : window.PromptCashDrawerApproval(role);
                if (role is not null && string.IsNullOrEmpty(approval)) return;
                cashClosing.CheckExpenseAccess(cashier, pin, approval);
                new CashExpenseDialog(cashier,
                    (date, description, amount) => cashClosing.RecordExpense(cashier, pin, approval, date, description, amount))
                    { Owner = window }.ShowDialog();
            }
            catch (UnauthorizedAccessException)
            {
                System.Windows.MessageBox.Show(window, "Dépenses non autorisées pour cet utilisateur.", "Dépenses");
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException)
            {
                System.Windows.MessageBox.Show(window, "Impossible d’ouvrir les dépenses de caisse.", "Dépenses");
            }
            finally { reviewing = false; }
        });
        window.ConfigureInventory(() =>
        {
            if (!CanChangeStockContext() || !vm.FinancialSessionActive ||
                activeCashierId is not { } actor || binding.Session.PendingCount != 0)
                return null;
            return new InventoryCountWorkflow(settings.ConnectionString, actor, () =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return "";
                reviewing = true;
                try { return ReadCashierPin(actor); }
                finally { reviewing = false; }
            });
        });
        window.ConfigureStockIssues(() =>
        {
            if (!CanChangeStockContext() || activeCashierId is not { } actor || binding.Session.PendingCount != 0)
                return;
            var dialog = new StockIssueDialog(new StockIssueValidation(settings.ConnectionString), actor, () =>
            {
                if (!CanChangeStockContext() || activeCashierId != actor || binding.Session.PendingCount != 0) return "";
                reviewing = true;
                try { return ReadCashierPin(actor); }
                finally { reviewing = false; }
            }) { Owner = window };
            dialog.ShowDialog();
        });
        window.ConfigurePurchaseReceipt(() =>
        {
            if (!CanChangeStockContext() || activeCashierId is not { } actor || binding.Session.PendingCount != 0)
                return;
            var receipt = new PurchaseReceiptValidation(settings.ConnectionString);
            var dialog = new PurchaseReceiptDialog(receipt, reviewed =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return false;
                reviewing = true;
                try
                {
                    var pin = ReadCashierPin(actor);
                    if (string.IsNullOrWhiteSpace(pin)) return false;
                    receipt.Validate(reviewed, actor, pin);
                    return true;
                }
                finally { reviewing = false; }
            }, (order, lines) =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return null;
                reviewing = true;
                try
                {
                    var pin = ReadCashierPin(actor);
                    return string.IsNullOrWhiteSpace(pin) ? null :
                        receipt.CreateFromOrder(order, lines, actor, pin);
                }
                finally { reviewing = false; }
            }, reviewed =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return false;
                reviewing = true;
                try
                {
                    var pin = ReadCashierPin(actor);
                    if (string.IsNullOrWhiteSpace(pin) ||
                        !ConfirmCashDrawer(window, $"Annuler le bon {reviewed.Id} et libérer la quantité réservée ?",
                            "Annulation du bon")) return false;
                    receipt.Cancel(reviewed, actor, pin);
                    return true;
                }
                finally { reviewing = false; }
            }, (supplier, lines) =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return null;
                reviewing = true;
                try
                {
                    var pin = ReadCashierPin(actor);
                    return string.IsNullOrWhiteSpace(pin) ? null :
                        receipt.CreateOrder(supplier, lines, actor, pin);
                }
                finally { reviewing = false; }
            });
            dialog.Owner = window;
            dialog.ShowDialog();
        });
        window.ConfigureSupplierSettlements(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor ||
                binding.Session.PendingCount != 0) return;
            var service = new SupplierSettlementWriter(settings.ConnectionString);
            try
            {
                var dialog = new SupplierAccountsDialog(() =>
                {
                    if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                        binding.Session.PendingCount != 0)
                        throw new InvalidOperationException("Session fournisseur indisponible.");
                    return service.ReadAccounts();
                }, service.PaymentModes(), request =>
                {
                    if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                        binding.Session.PendingCount != 0) return false;
                    reviewing = true;
                    try
                    {
                        var pin = ReadCashierPin(actor);
                        if (string.IsNullOrWhiteSpace(pin) || !vm.FinancialSessionActive || activeCashierId != actor ||
                            vm.CheckoutBusy || vm.CheckoutUncertain || binding.Session.PendingCount != 0) return false;
                        return service.Record(request, actor, pin);
                    }
                    finally { reviewing = false; }
                }) { Owner = window };
                dialog.ShowDialog();
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show(window, "Impossible d’ouvrir les règlements fournisseurs.",
                    "Règlement fournisseur", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
            }
        });
        window.ConfigureDailyStock(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor || binding.Session.PendingCount != 0) return;
            dailyStockOpen = true;
            var stockContext = context;
            try
            {
                bool Active() => dailyStockOpen && vm.FinancialSessionActive && activeCashierId == actor &&
                    ReferenceEquals(context, stockContext) && !vm.CheckoutBusy && !vm.CheckoutUncertain &&
                    vm.PendingOperationId is null && binding.Session.PendingCount == 0 && binding.Session.State == CheckoutCommitState.Ready;
                void Child(Action action)
                {
                    if (!Active() || dailyStockChild) throw new InvalidOperationException("La session du stock a changé.");
                    dailyStockChild = true;
                    try { action(); }
                    finally { dailyStockChild = false; }
                }
                var reader = new DailyStockReader(settings.ConnectionString);
                var access = reader.Authorize(actor, role => Active() ? window.PromptCashDrawerApproval(role) : "");
                if (!Active()) throw new InvalidOperationException("La session du stock a changé.");
                new DailyStockDialog(reader, access, new DailyStockHooks(
                    OpenArticle: selected => Child(() => OpenCatalogue(selected.Id)),
                    NewArticle: () => Child(() => OpenCatalogue(creating: true)),
                    OpenInventory: () => Child(window.ShowInventoryFromStock),
                    OpenReceipts: () => Child(window.ShowReceiptsFromStock),
                    OpenStockIssues: () => Child(window.ShowStockIssuesFromStock),
                    OpenCatalogue: () => Child(window.ShowCatalogueFromStock),
                    AdjustStock: sessionCredentials is null ? null : selected => Child(()=>
                    {
                        var service=new DailyStockAdjustmentService(settings.ConnectionString,
                            ()=>Active()&&dailyStockChild?sessionCredentials.VerifiedActor:null,()=>ReadCashierPin(actor));
                        var authorization=service.Authorize(window.PromptCashDrawerApproval);
                        new DailyStockAdjustmentDialog(service,authorization,selected,settings.DataDirectory){Owner=window}.ShowDialog();
                    }))) { Owner = window }.ShowDialog();
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { window.SetBasketActionFeedback(ex is UnauthorizedAccessException or InvalidOperationException ? ex.Message : "Stock indisponible. Vérifiez la connexion et les données du poste."); }
            finally { dailyStockChild = false; dailyStockOpen = false; vm.ReloadCatalogue(); }
        });
        window.ConfigureWorkstationSettings(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor || binding.Session.PendingCount != 0) return;
            businessDocumentsOpen = true;
            var settingsContext = context;
            try
            {
                var settingsStore = new DailyLogicaSettingsStore(settings.ConnectionString);
                // LOGICA FUN_CAT_ACCES grants PARAMETRES to ADMIN only.
                var access = settingsStore.Authorize(actor, () => ReadCashierPin(actor));
                void Authorize()
                {
                    if (!businessDocumentsOpen || !vm.FinancialSessionActive || activeCashierId != actor ||
                        !ReferenceEquals(context, settingsContext) || vm.CheckoutBusy || vm.CheckoutUncertain ||
                        vm.PendingOperationId is not null || binding.Session.PendingCount != 0 || binding.Session.State != CheckoutCommitState.Ready)
                        throw new UnauthorizedAccessException("La session des paramètres a changé.");
                    settingsStore.Read(access); // Recheck exact current ADMIN role without retaining the PIN.
                }
                Authorize();
                new WorkstationSettingsMenu(
                    () =>
                    {
                        Authorize();
                        if(sessionCredentials is not null)
                        {
                            var originalStore=new OriginalWorkstationSettingsStore(settings.ConnectionString,
                                ()=>businessDocumentsOpen&&vm.FinancialSessionActive&&activeCashierId==actor&&ReferenceEquals(context,settingsContext)?actor:null,
                                ()=>ReadCashierPin(actor));
                            new OriginalWorkstationSettingsDialog(new OriginalWorkstationSettingsWorkflow(originalStore)){Owner=window}.ShowDialog();
                            return;
                        }
                        var workflow = new DailyLogicaSettingsWorkflow(settingsStore, access, () =>
                            businessDocumentsOpen && vm.FinancialSessionActive && activeCashierId == actor && ReferenceEquals(context, settingsContext) &&
                            !vm.CheckoutBusy && !vm.CheckoutUncertain && vm.PendingOperationId is null && binding.Session.PendingCount == 0 && binding.Session.State == CheckoutCommitState.Ready,
                            () => ReadCashierPin(actor));
                        new DailyLogicaSettingsDialog(workflow) { Owner = window }.ShowDialog();
                    },
                    () => { Authorize(); new WorkstationPrinterDialog(settings, twoDigitWorkstation, Authorize) { Owner = window }.ShowDialog(); },sessionCredentials is not null)
                    { Owner = window }.ShowDialog();
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { System.Windows.MessageBox.Show(window, ex is UnauthorizedAccessException or InvalidOperationException ? ex.Message : "Paramètres indisponibles.", "Paramètres du poste"); }
            finally { businessDocumentsOpen = false; }
        });
        window.ConfigureSalesJournal(statistics =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor || binding.Session.PendingCount != 0) return;
            businessDocumentsOpen = true;
            var journalContext = context;
            try
            {
                bool Active() => businessDocumentsOpen && vm.FinancialSessionActive && activeCashierId == actor &&
                    ReferenceEquals(context, journalContext) && !vm.CheckoutBusy && !vm.CheckoutUncertain &&
                    vm.PendingOperationId is null && binding.Session.PendingCount == 0 && binding.Session.State == CheckoutCommitState.Ready;
                var reader = new SalesJournalReader(settings.ConnectionString);
                var access = reader.Authorize(actor, () => ReadCashierPin(actor), statistics);
                if (!Active()) throw new InvalidOperationException("La session du journal a changé.");
                var workflow = new SalesJournalWorkflow(reader, access, Active, selected =>
                {
                    using var db = connections(); db.Open();
                    LogicaCashReceiptPrinter.Print(db, WorkstationPrinterProfile.DirectoryFor(settings, twoDigitWorkstation), selected.Id, selected.Cashier, selected.Register);
                });
                new SalesJournalDialog(workflow) { Owner = window }.ShowDialog();
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { System.Windows.MessageBox.Show(window, ex is UnauthorizedAccessException or InvalidOperationException ? ex.Message : "Journal indisponible.", statistics ? "Statistiques" : "Journal des ventes"); }
            finally { businessDocumentsOpen = false; }
        });
        window.ConfigureBusinessDocuments(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor || binding.Session.PendingCount != 0) return;
            businessDocumentsOpen = true;
            try
            {
                bool Active() => businessDocumentsOpen && vm.FinancialSessionActive && activeCashierId == actor &&
                    !vm.CheckoutBusy && !vm.CheckoutUncertain && vm.PendingOperationId is null && binding.Session.PendingCount == 0 && binding.Session.State == CheckoutCommitState.Ready;
                var workflow = new BusinessDocumentsWorkflow(new BusinessDocumentStore(settings.ConnectionString, actor), Active, () => ReadCashierPin(actor));
                new BusinessDocumentsDialog(workflow) { Owner = window }.ShowDialog();
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { System.Windows.MessageBox.Show(window, ex is UnauthorizedAccessException or InvalidOperationException ? ex.Message : "Documents indisponibles.", "Documents commerciaux"); }
            finally { businessDocumentsOpen = false; }
        });
        window.ConfigureCustomerFiles(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor || binding.Session.PendingCount != 0) return;
            customerFilesOpen = true;
            try
            {
                var store = new CustomerFileStore(settings.ConnectionString);
                var access = store.Authorize(actor, window.PromptCustomerFilesApproval);
                bool Active() => customerFilesOpen && vm.FinancialSessionActive && activeCashierId == actor &&
                    !vm.CheckoutBusy && !vm.CheckoutUncertain && vm.PendingOperationId is null &&
                    binding.Session.PendingCount == 0 && binding.Session.State == CheckoutCommitState.Ready;
                using var workflow = new CustomerFilesWorkflow(store, access, settings.ConnectionString, twoDigitWorkstation,
                    settings.DataDirectory, Active, () => ReadCashierPin(actor));
                new CustomerFilesDialog(workflow) { Owner = window }.ShowDialog();
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { System.Windows.MessageBox.Show(window, ex is UnauthorizedAccessException or InvalidOperationException ? ex.Message : "Fichiers clients indisponibles.", "Fichiers clients"); }
            finally { customerFilesOpen = false; }
        });
        var customerCredits = new CustomerCreditStatementReader(settings.ConnectionString);
        var customerSettlements = new CustomerSettlementWriter(settings.ConnectionString);
        window.ConfigureCustomerSettlements(customerSettlements.PaymentModes, request =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } actor ||
                binding.Session.PendingCount != 0) return false;
            reviewing = true;
            try
            {
                var pin = ReadCashierPin(actor);
                if (string.IsNullOrWhiteSpace(pin) || !vm.FinancialSessionActive || activeCashierId != actor ||
                    vm.CheckoutBusy || vm.CheckoutUncertain || binding.Session.PendingCount != 0) return false;
                return customerSettlements.Record(request, actor, pin);
            }
            finally { reviewing = false; }
        });
        window.ConfigureCustomerCreditStatement((from, to) =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is null ||
                binding.Session.PendingCount != 0)
                throw new InvalidOperationException("Ouvrez une session et terminez le panier en cours.");
            return customerCredits.Read(from, to);
        });

        void OpenCatalogue(string? selectedId = null, bool creating = false)
        {
            if (!CanChangeStockContext() || activeCashierId is not { } actor || binding.Session.PendingCount != 0)
                return;
            var editor = new CataloguePriceEditor(settings.ConnectionString);
            var dialog = new CataloguePriceDialog(editor, (reviewed, price) =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return false;
                reviewing = true;
                try
                {
                    var pin = ReadCashierPin(actor);
                    if (string.IsNullOrWhiteSpace(pin)) return false;
                    editor.Update(reviewed, price, actor, pin);
                    return true;
                }
                finally { reviewing = false; }
            }, (name, barcode, family, price, variantOf) =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return null;
                reviewing = true;
                try
                {
                    var pin = ReadCashierPin(actor);
                    return string.IsNullOrWhiteSpace(pin) ? null :
                        editor.Create(name, barcode, family, price, actor, pin, variantOf);
                }
                finally { reviewing = false; }
            }, (card, name, barcode, family, details) =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return false;
                reviewing = true;
                try
                {
                    var pin = ReadCashierPin(actor);
                    if (string.IsNullOrWhiteSpace(pin)) return false;
                    editor.UpdateCard(card, name, barcode, family, details, actor, pin);
                    return true;
                }
                finally { reviewing = false; }
            }, lines =>
            {
                if (!CanChangeStockContext() || !vm.FinancialSessionActive || activeCashierId != actor ||
                    binding.Session.PendingCount != 0) return null;
                reviewing = true;
                try
                {
                    var pin = ReadCashierPin(actor);
                    return string.IsNullOrWhiteSpace(pin) ? null : editor.Import(lines, actor, pin).Count;
                }
                finally { reviewing = false; }
            }, selectImportFile, selectedId, creating) { Owner = window };
            dialog.ShowDialog();
            vm.ReloadCatalogue();
        }
        window.ConfigureCataloguePrices(() => OpenCatalogue());
        vm.PrintCommittedSale = (operation, payment) =>
        {
            var directory = WorkstationPrinterProfile.DirectoryFor(settings, twoDigitWorkstation);
            using var connection = connections();
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();
            var ticket = LogicaPostedTicket.Read(connection, operation, payment.CashierId, payment.RegisterId)
                ?? throw new InvalidOperationException("Le ticket enregistré est introuvable.");
            var change = -ticket.Payments.Where(row => row.Mode == "ESPECES" && row.Amount < 0m).Sum(row => row.Amount);
            window.SetLastSaleSummary(ticket.Operation.StartsWith("RETOUR", StringComparison.Ordinal)
                ? $"{ticket.Operation} {ticket.Number} · {ticket.Total:F2} MAD"
                : ticket.Operation == "CREDIT"
                ? $"Crédit {ticket.Number} · {ticket.CustomerName} · {ticket.Total:F2} MAD"
                : $"Dernier ticket {ticket.Number} · À rendre {change:F2} MAD");
            if (!System.IO.File.Exists(System.IO.Path.Combine(directory, "PRINTER_CL.sni"))) return;
            LogicaCashReceiptPrinter.Print(connection, directory, operation, payment.CashierId, payment.RegisterId);
        };
        window.ConfigureWaitingSale(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } cashier ||
                binding.Session.PendingCount == 0) return null;
            if (waitingSaleId is not null)
                throw new InvalidOperationException("Cette vente figure déjà dans les attentes.");
            reviewing = true;
            try
            {
                var waitingId = LogicaWaitingSale.Save(connections, binding.Session.PendingLines, cashier,
                    twoDigitWorkstation, CurrentManualDiscount());
                binding.Session.Clear();
                manualDiscount = null;
                captured = null;
                contextConsumed = true;
                context = new CashierPaymentContext(cashier, twoDigitWorkstation, "MAD", "Cash", 0m);
                vm.PaymentContext = context;
                return waitingId;
            }
            finally { reviewing = false; }
        });
        window.ConfigureRestoreWaitingSale(() =>
        {
            if (!CanChangeContext() || !vm.FinancialSessionActive || activeCashierId is not { } cashier ||
                binding.Session.PendingCount != 0) return false;
            reviewing = true;
            try
            {
                var list = new System.Windows.Controls.ListBox
                {
                    ItemsSource = LogicaWaitingSale.List(connections),
                    DisplayMemberPath = "Label"
                };
                var resume = new System.Windows.Controls.Button { Content = "Reprendre", MinHeight = 40 };
                var panel = new System.Windows.Controls.DockPanel { Margin = new System.Windows.Thickness(12) };
                System.Windows.Controls.DockPanel.SetDock(resume, System.Windows.Controls.Dock.Bottom);
                panel.Children.Add(resume);
                panel.Children.Add(list);
                var dialog = new System.Windows.Window { Owner = window, Title = "Attentes", Content = panel,
                    Width = 520, Height = 350, WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner };
                resume.Click += (_, _) =>
                {
                    if (list.SelectedItem is LogicaWaitingSale.Waiting) dialog.DialogResult = true;
                };
                if (dialog.ShowDialog() != true || list.SelectedItem is not LogicaWaitingSale.Waiting selected)
                    return false;

                var restored = MariaDbCashCheckoutServices.ReadWaitingBasketForAuthorizedResume(connections,
                    selected.Id, cashier, twoDigitWorkstation, window.PromptDiscountApprovalPin);
                var lines = restored.Lines;
                binding.Session.RefreshCatalogue();
                try
                {
                    foreach (var line in lines)
                    {
                        var product = binding.Session.Products.SingleOrDefault(x => x.ArticleId == line.ArticleId);
                        if (product is null || binding.Session.SelectArticle(product, line.Quantity).Outcome != SelectionOutcome.Selected)
                            throw new InvalidOperationException("Un article en attente n’est plus disponible.");
                    }
                }
                catch
                {
                    binding.Session.Clear();
                    manualDiscount = null;
                    throw;
                }

                waitingSaleId = selected.Id;
                manualDiscount = restored.Approval;
                captured = null;
                contextConsumed = true;
                context = new CashierPaymentContext(cashier, twoDigitWorkstation, "MAD", "Cash", 0m);
                vm.PaymentContext = context;
                return true;
            }
            finally { reviewing = false; }
        });
        window.ConfigureReviewedCheckout(result.TryReviewResolvedCheckout);
        return result;
    }

    private static bool ConfirmCashDrawer(System.Windows.Window owner, string text, string title)
    {
        var dialog = new System.Windows.Window
        {
            Title = title, Owner = owner, Width = 440,
            SizeToContent = System.Windows.SizeToContent.Height,
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner
        };
        var layout = new System.Windows.Controls.StackPanel { Margin = new System.Windows.Thickness(20) };
        layout.Children.Add(new System.Windows.Controls.TextBlock { Text = text,
            TextWrapping = System.Windows.TextWrapping.Wrap });
        var cancel = new System.Windows.Controls.Button { Content = "Annuler", IsCancel = true,
            IsDefault = true, MinHeight = 36, Margin = new System.Windows.Thickness(0, 12, 0, 4) };
        var confirm = new System.Windows.Controls.Button { Content = "Confirmer", MinHeight = 36 };
        confirm.Click += (_, _) => dialog.DialogResult = true;
        layout.Children.Add(cancel);
        layout.Children.Add(confirm);
        dialog.Content = layout;
        return dialog.ShowDialog() == true;
    }

    private sealed class MariaDbFullCashReturnHost(
        Func<MySqlConnection> connections, string workstation) :
        IOriginalSaleLookup, ITrustedWpfFullCashReturnPreparation, ITrustedWpfFullTicketReturnPreparation
    {
        public string Mode { get; set; } = "Cash";
        public Func<AuthorizedCheckoutRequest, bool>? Confirm { get; set; }
        public Func<MariaDbCashCheckoutServices.PartialCashReturnCandidate, string, string, IReadOnlyList<CheckoutPartialReturnSelection>?>? SelectPartial { get; set; }
        public IReadOnlyList<OriginalSaleCandidate> FindPersistedSales(string receiptSearch) =>
            Mode == "PartialCash" ? MariaDbCashCheckoutServices.FindPartialCashReturnCandidatesByReceipt(connections, receiptSearch)
                .Select(sale => new OriginalSaleCandidate(sale.SaleId, $"Ticket {sale.TicketNumber} — solde à reprendre {sale.RemainingNetMad:N2} MAD", sale.RemainingNetMad)).ToArray()
            : Mode == "Credit" ? MariaDbCashCheckoutServices.FindFullCreditReturnCandidatesByReceipt(connections, receiptSearch)
                .Select(sale => new OriginalSaleCandidate(sale.SaleId, $"Ticket {sale.TicketNumber} · {sale.Customer.Name} — dette {sale.CreditMad:N2} MAD", sale.CreditMad)).ToArray()
            : Mode == "Card" ? MariaDbCashCheckoutServices.FindFullCardReturnCandidatesByReceipt(connections, receiptSearch)
                .Select(sale => new OriginalSaleCandidate(sale.SaleId, $"Ticket {sale.TicketNumber} — CARTE {sale.RefundMad:N2} MAD", sale.RefundMad)).ToArray()
            : MariaDbCashCheckoutServices.FindFullCashReturnCandidatesByReceipt(connections, receiptSearch)
                .Select(sale => new OriginalSaleCandidate(sale.SaleId,
                    $"Ticket {sale.TicketNumber} · {sale.ReceiptDate} · poste {sale.Register} — {sale.PaidMad:N2} MAD", sale.PaidMad))
                .ToArray();

        public AuthorizedCheckoutRequest PrepareFullTicketReturn(string operationId, string originalId, CashierPaymentContext context)
        {
            if (context?.IsWellFormed != true || context.TenderCode != (Mode == "PartialCash" ? "Cash" : Mode) || context.RegisterId != workstation || context.CurrencyCode != "MAD")
                throw new InvalidOperationException("La session du retour a changé.");
            if (Mode == "Cash") return PrepareFullCashReturn(operationId, originalId, context);
            if (Mode == "PartialCash")
            {
                var candidate = MariaDbCashCheckoutServices.FindPartialCashReturnCandidatesByReceipt(connections, originalId).Single(row => row.SaleId == originalId);
                var selections = SelectPartial?.Invoke(candidate, operationId, context.CashierId) ?? throw new InvalidOperationException("Retour partiel annulé.");
                return MariaDbCashCheckoutServices.PreparePartialCashReturnRequest(connections, operationId, context.CashierId, "MAD", originalId, selections);
            }
            var request = Mode == "Credit" ? MariaDbCashCheckoutServices.PrepareFullCreditReturnRequest(connections, operationId, context.CashierId, "MAD", originalId)
                : Mode == "Card" ? MariaDbCashCheckoutServices.PrepareFullCardReturnRequest(connections, operationId, context.CashierId, "MAD", originalId, externalRefundConfirmed: true)
                : throw new InvalidOperationException("Mode de retour invalide.");
            if (Confirm?.Invoke(request) != true) throw new InvalidOperationException("Retour annulé avant écriture.");
            return request;
        }

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
