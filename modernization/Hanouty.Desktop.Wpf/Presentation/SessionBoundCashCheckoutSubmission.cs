using System;

namespace Hanouty.Desktop.Wpf.Presentation;

// The approved Architecture CreateFinancial binding owns the only CheckoutSession,
// posting port, journal and trusted preparation. This adapter is UI plumbing only:
// it never creates a second basket, prices articles or handles a PIN.
public sealed class SessionBoundCashCheckoutSubmission :
    IContextualCheckoutSubmission, IContextualWpfCashReturnSubmission, ICheckoutOutcomeReconciliation
{
    private readonly ICheckoutSubmission _session;
    private readonly ICheckoutOutcomeReconciliation _reconciliation;
    private readonly Func<CashierPaymentContext> _authorizedContext;

    public SessionBoundCashCheckoutSubmission(ICheckoutSubmission financialSessionSubmission,
        Func<CashierPaymentContext> currentAuthorizedCashContext)
    {
        _session = financialSessionSubmission ??
            throw new ArgumentNullException(nameof(financialSessionSubmission));
        _reconciliation = financialSessionSubmission as ICheckoutOutcomeReconciliation ??
            throw new ArgumentException("Financial session must support durable reconciliation.",
                nameof(financialSessionSubmission));
        _authorizedContext = currentAuthorizedCashContext ??
            throw new ArgumentNullException(nameof(currentAuthorizedCashContext));
    }

    public CheckoutSubmissionResult Submit(string stableOperationId) =>
        throw new InvalidOperationException("Authorized cashier/payment context is required.");

    public CheckoutSubmissionResult Submit(string stableOperationId, CashierPaymentContext context)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId) ||
            context?.IsWellFormed != true ||
            !string.Equals(context.TenderCode, "Cash", StringComparison.OrdinalIgnoreCase))
            return CheckoutSubmissionResult.Invalidated;

        // Re-read the host's authenticated context on every attempt; never trust
        // a stale or UI-edited cashier, workstation, currency or tender amount.
        // Checkout independently validates PIN, pricing, payment and cart atomically.
        CashierPaymentContext? trusted;
        try { trusted = _authorizedContext(); }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            // A failed/expired Host session lookup is never authorization.
            // No posting is attempted and the PIN is not inspected by WPF.
            return CheckoutSubmissionResult.Invalidated;
        }
        if (trusted?.IsWellFormed != true ||
            !string.Equals(trusted.TenderCode, "Cash", StringComparison.OrdinalIgnoreCase) ||
            !string.Equals(context.CashierId, trusted.CashierId, StringComparison.Ordinal) ||
            !string.Equals(context.RegisterId, trusted.RegisterId, StringComparison.Ordinal) ||
            !string.Equals(context.CurrencyCode, trusted.CurrencyCode, StringComparison.Ordinal) ||
            context.TenderedAmount != trusted.TenderedAmount)
            return CheckoutSubmissionResult.Invalidated;

        // This is the same financial CheckoutSession populated by WPF selection.
        return _session.Submit(stableOperationId);
    }

    public CheckoutSubmissionResult SubmitFullCashReturn(string stableOperationId,
        string originalTicketId, CashierPaymentContext context)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId) ||
            string.IsNullOrWhiteSpace(originalTicketId) ||
            context?.IsWellFormed != true ||
            !string.Equals(context.TenderCode, "Cash", StringComparison.OrdinalIgnoreCase) ||
            _session is not IContextualWpfCashReturnSubmission returnSubmission)
            return CheckoutSubmissionResult.Invalidated;
        CashierPaymentContext? trusted;
        try { trusted = _authorizedContext(); }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        { return CheckoutSubmissionResult.Invalidated; }
        if (trusted?.IsWellFormed != true ||
            !string.Equals(context.CashierId, trusted.CashierId, StringComparison.Ordinal) ||
            !string.Equals(context.RegisterId, trusted.RegisterId, StringComparison.Ordinal) ||
            !string.Equals(context.CurrencyCode, trusted.CurrencyCode, StringComparison.Ordinal) ||
            !string.Equals(context.TenderCode, trusted.TenderCode, StringComparison.Ordinal))
            return CheckoutSubmissionResult.Invalidated;
        return returnSubmission.SubmitFullCashReturn(stableOperationId, originalTicketId, context);
    }

    public CheckoutResolution Reconcile(string stableOperationId) =>
        string.IsNullOrWhiteSpace(stableOperationId)
            ? CheckoutResolution.Unknown
            : _reconciliation.Reconcile(stableOperationId);
}
