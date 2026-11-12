using System;
using System.Collections.Generic;
using System.Linq;
using Hanouty.ArchitectureBridge;
using Wpf = Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.WpfContractAdapter;

// Exact adapter for the existing WPF ReadProducts() contract; never reads SQL.
// The authoritative variant identity stays in the Application session and is
// not inferred from the WPF display DTO (which currently lacks VariantId).
public sealed class ProductionWpfCatalogueReader : Wpf.ICatalogueReader
{
    private readonly CheckoutSession _session;
    public ProductionWpfCatalogueReader(CheckoutSession session) =>
        _session = session ?? throw new ArgumentNullException(nameof(session));

    public IReadOnlyList<Wpf.ProductSummary> ReadProducts()
    {
        _session.RefreshCatalogue();
        var source = _session.Products;
        if (source.Any(p => string.IsNullOrWhiteSpace(p.ArticleId)) ||
            source.GroupBy(p => p.ArticleId, StringComparer.OrdinalIgnoreCase).Any(g => g.Count() > 1))
            throw new InvalidOperationException("Catalogue contains invalid or duplicate WPF article identities.");
        return source.Select(p => new Wpf.ProductSummary(
            p.ArticleId, p.DisplayName, p.Barcode, p.ImagePath)).ToArray();
    }
}

// A WPF selection is staged, NOT posted. Actual sale/payment/return commands
// must explicitly call CheckoutSession.Submit with a stable operation ID.
public sealed class ProductionWpfProductSelection : Wpf.IProductSelection
{
    private readonly CheckoutSession _session;
    public ProductionWpfProductSelection(CheckoutSession session) =>
        _session = session ?? throw new ArgumentNullException(nameof(session));

    public bool Select(Wpf.ProductSummary product)
    {
        ArgumentNullException.ThrowIfNull(product);
        var matches = _session.Products.Where(p =>
            string.Equals(p.ArticleId, product.Id, StringComparison.OrdinalIgnoreCase)).ToArray();
        if (matches.Length != 1) return false;
        var current = matches[0];
        if (current is null ||
            !string.Equals(current.ArticleId, product.Id, StringComparison.Ordinal)) return false;
        if (!string.Equals(current.Barcode, product.Barcode, StringComparison.Ordinal) ||
            !string.Equals(current.DisplayName, product.Name, StringComparison.Ordinal) ||
            !string.Equals(current.ImagePath, product.ImagePath, StringComparison.Ordinal))
            return false;
        // An explicitly clicked tile carries a stable article ID. Duplicate
        // barcodes MUST preserve that identity even when the tile has a photo;
        // a barcode scan alone cannot silently choose a variant.
        if (string.IsNullOrWhiteSpace(current.Barcode))
            return _session.SelectArticle(current).Outcome == SelectionOutcome.Selected;
        var matching = _session.Products.Count(p =>
            string.Equals(p.Barcode, current.Barcode, StringComparison.Ordinal));
        if (matching > 1)
            return _session.SelectVariant(current).Outcome == SelectionOutcome.Selected;
        if (matching != 1) return false;
        if (current.HasImage)
            return _session.SelectImage(current).Outcome == SelectionOutcome.Selected;
        return _session.Scan(current.Barcode).Outcome == SelectionOutcome.Selected;
    }
}

// Application-owned submission adapter: WPF only supplies the stable operation ID.
// No financial posting is authorized by this adapter without a configured
// IAtomicCheckoutBatchPort and durable operation journal in CheckoutComposition.
public sealed class ProductionWpfCheckoutSubmission : Wpf.ICheckoutSubmission, Wpf.IContextualWpfCashReturnSubmission, Wpf.ICheckoutOutcomeReconciliation
{
    private readonly CheckoutSession _session;
    private readonly AuthorizedCheckoutCommitGate? _financialGate;
    private readonly Wpf.IContextualWpfCashReturnSubmission? _returnSubmission;
    private readonly ICheckoutOperationJournal? _operationJournal;
    private string? _returnOperationId;
    public ProductionWpfCheckoutSubmission(CheckoutSession session,
        AuthorizedCheckoutCommitGate? financialGate = null,
        Wpf.IContextualWpfCashReturnSubmission? returnSubmission = null,
        ICheckoutOperationJournal? operationJournal = null)
    {
        _session = session ?? throw new ArgumentNullException(nameof(session));
        _financialGate = financialGate;
        _returnSubmission = returnSubmission;
        _operationJournal = operationJournal;
    }

    public Wpf.CheckoutResolution Reconcile(string stableOperationId)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId))
            return Wpf.CheckoutResolution.Unknown;
        if (string.Equals(_financialGate?.UncertainOperationId, stableOperationId, StringComparison.Ordinal) &&
            string.Equals(_returnOperationId, stableOperationId, StringComparison.Ordinal))
            return _returnSubmission?.Reconcile(stableOperationId) ?? Wpf.CheckoutResolution.Unknown;
        if (string.Equals(_financialGate?.UncertainOperationId, stableOperationId, StringComparison.Ordinal))
        {
            try
            {
                if (_financialGate.Reconcile(stableOperationId) == CheckoutOperationOutcome.Unknown)
                    return Wpf.CheckoutResolution.Unknown;
            }
            catch (InvalidOperationException)
            { return Wpf.CheckoutResolution.Unknown; }
        }
        // CheckoutSession can reject a stale staged identity before entering
        // the financial gate. In that case it is Ready (not OutcomeUnknown)
        // while retaining the operation ID for cashier review. Reconcile that
        // ID against the durable journal; never infer Absent from local state.
        if (_session.State == CheckoutCommitState.Ready &&
            string.Equals(_session.OperationId, stableOperationId, StringComparison.Ordinal))
        {
            if (_operationJournal is null) return Wpf.CheckoutResolution.Unknown;
            try
            {
                return _operationJournal.Lookup(stableOperationId) switch
                {
                    CheckoutOperationOutcome.Persisted => Wpf.CheckoutResolution.Persisted,
                    CheckoutOperationOutcome.Absent => Wpf.CheckoutResolution.Absent,
                    _ => Wpf.CheckoutResolution.Unknown
                };
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            {
                return Wpf.CheckoutResolution.Unknown;
            }
        }
        if (_session.State != CheckoutCommitState.OutcomeUnknown ||
            !string.Equals(_session.OperationId, stableOperationId, StringComparison.Ordinal))
            return Wpf.CheckoutResolution.Unknown;
        return _session.Reconcile() switch {
            CheckoutOperationOutcome.Persisted => Wpf.CheckoutResolution.Persisted,
            CheckoutOperationOutcome.Absent => Wpf.CheckoutResolution.Absent,
            _ => Wpf.CheckoutResolution.Unknown
        };
    }

    public Wpf.CheckoutSubmissionResult SubmitFullCashReturn(string stableOperationId,
        string originalTicketId, Wpf.CashierPaymentContext context)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId) ||
            string.IsNullOrWhiteSpace(originalTicketId) || context?.IsWellFormed != true ||
            !string.Equals(context.TenderCode, "Cash", StringComparison.OrdinalIgnoreCase) ||
            _returnSubmission is null || _financialGate is null ||
            _session.PendingCount != 0 || _session.State != CheckoutCommitState.Ready ||
            _session.OperationId is not null || _financialGate.UncertainOperationId is not null)
            return Wpf.CheckoutSubmissionResult.Invalidated;
        _returnOperationId = stableOperationId;
        return _returnSubmission.SubmitFullCashReturn(stableOperationId, originalTicketId, context);
    }

    public Wpf.CheckoutSubmissionResult Submit(string stableOperationId)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId))
            throw new ArgumentException("Stable operation ID required.", nameof(stableOperationId));
        return _session.Submit(stableOperationId) switch
        {
            CheckoutBatchStatus.Committed => Wpf.CheckoutSubmissionResult.Committed,
            CheckoutBatchStatus.Empty => Wpf.CheckoutSubmissionResult.Empty,
            CheckoutBatchStatus.Invalidated => Wpf.CheckoutSubmissionResult.Invalidated,
            _ => Wpf.CheckoutSubmissionResult.Unknown
        };
    }
}

public sealed record WpfProductionBinding(CheckoutSession Session,
    Wpf.ICatalogueReader Catalogue, Wpf.IProductSelection Checkout,
    Wpf.ICheckoutSubmission Submission);

public static class ProductionWpfServices
{
    // Explicit payment-enabled composition. The host supplies Inventory's real
    // catalogue, Checkout's MariaDbCashCheckoutServices posting/journal and
    // authenticated cashier/tender context; this never runs on product selection.
    public static WpfProductionBinding CreateFinancial(
        ICatalogueReader catalogue, ICheckoutVariantPrompt variants,
        IAuthorizedCheckoutPort posting, ICheckoutOperationJournal journal,
        Func<AuthorizedCheckoutPaymentContext> paymentContext,
        Wpf.ITrustedWpfFullCashReturnPreparation? returnPreparation = null)
    {
        ArgumentNullException.ThrowIfNull(posting);
        ArgumentNullException.ThrowIfNull(journal);
        var gate = new AuthorizedCheckoutCommitGate(posting, journal);
        var financialBatch = new AuthorizedCheckoutBatchAdapter(gate, paymentContext);
        return CreateBinding(new CheckoutComposition(catalogue, variants, financialBatch, journal), gate, journal, returnPreparation);
    }

    // Host invokes this at App.ResolveServices using concrete Inventory,
    // Checkout and cashier variant-prompt adapters. No empty fallback.
    public static WpfProductionBinding Create(CheckoutComposition composition) =>
        CreateBinding(composition, null, null, null);

    private static WpfProductionBinding CreateBinding(CheckoutComposition composition,
        AuthorizedCheckoutCommitGate? financialGate, ICheckoutOperationJournal? journal,
        Wpf.ITrustedWpfFullCashReturnPreparation? returnPreparation)
    {
        ArgumentNullException.ThrowIfNull(composition);
        var session = composition.CreateSession();
        var returnSubmission = financialGate is not null && journal is not null && returnPreparation is not null
            ? new Wpf.AuthorizedWpfCheckoutAdapter(financialGate, journal, returnPreparation)
            : null;
        return new WpfProductionBinding(session,
            new ProductionWpfCatalogueReader(session),
            new ProductionWpfProductSelection(session),
            new ProductionWpfCheckoutSubmission(session, financialGate, returnSubmission, journal));
    }
}
