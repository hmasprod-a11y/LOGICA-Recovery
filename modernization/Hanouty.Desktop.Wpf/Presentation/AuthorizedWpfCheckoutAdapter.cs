using System;
using System.Collections.Generic;
using Hanouty.ArchitectureBridge;

namespace Hanouty.Desktop.Wpf.Presentation;

// Application must provide a trusted snapshot of the authenticated cashier,
// current basket, authoritative prices and totals. WPF never derives prices.
public interface ITrustedWpfCheckoutPreparation
{
    AuthorizedCheckoutRequest Prepare(string stableOperationId, CashierPaymentContext uiContext);
}


public interface ITrustedWpfFullCashReturnPreparation
{
    AuthorizedCheckoutRequest PrepareFullCashReturn(
        string stableOperationId, string originalTicketId, CashierPaymentContext cashierContext);
}

public interface IContextualWpfCashReturnSubmission : ICheckoutOutcomeReconciliation
{
    CheckoutSubmissionResult SubmitFullCashReturn(
        string stableOperationId, string originalTicketId, CashierPaymentContext context);
}

// Maps WPF's existing context to Architecture's EXISTING AuthorizedCheckoutRequest.
// No local DB reads, pricing, posting implementation, or implicit host registration.
public sealed class AuthorizedWpfCheckoutAdapter : IContextualCheckoutSubmission, IContextualWpfCashReturnSubmission, ICheckoutOutcomeReconciliation
{
    private readonly ITrustedWpfCheckoutPreparation? _preparation;
    private readonly AuthorizedCheckoutCommitGate _gate;
    private readonly ICheckoutOperationJournal _journal;
    private readonly ITrustedWpfFullCashReturnPreparation? _returnPreparation;

    public AuthorizedWpfCheckoutAdapter(ITrustedWpfCheckoutPreparation preparation,
        AuthorizedCheckoutCommitGate gate, ICheckoutOperationJournal journal,
        ITrustedWpfFullCashReturnPreparation? returnPreparation = null)
    {
        _preparation = preparation ?? throw new ArgumentNullException(nameof(preparation));
        _gate = gate ?? throw new ArgumentNullException(nameof(gate));
        _journal = journal ?? throw new ArgumentNullException(nameof(journal));
        _returnPreparation = returnPreparation;
    }

    public AuthorizedWpfCheckoutAdapter(AuthorizedCheckoutCommitGate gate,
        ICheckoutOperationJournal journal, ITrustedWpfFullCashReturnPreparation returnPreparation)
    {
        _gate = gate ?? throw new ArgumentNullException(nameof(gate));
        _journal = journal ?? throw new ArgumentNullException(nameof(journal));
        _returnPreparation = returnPreparation ?? throw new ArgumentNullException(nameof(returnPreparation));
    }

    public CheckoutSubmissionResult Submit(string stableOperationId) =>
        throw new InvalidOperationException("Cashier/payment context and trusted preparation are required.");

    public CheckoutSubmissionResult Submit(string stableOperationId, CashierPaymentContext context)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId) || context?.IsWellFormed != true ||
            !string.Equals(context.TenderCode, nameof(CheckoutPaymentKind.Cash), StringComparison.OrdinalIgnoreCase))
            return CheckoutSubmissionResult.Invalidated;

        // No posting until the application's trusted preparation exists.
        if (_preparation is null) return CheckoutSubmissionResult.Invalidated;
        var request = _preparation.Prepare(stableOperationId, context);
        if (request is null || request.OperationId != stableOperationId ||
            request.CashierId != context.CashierId ||
            !string.Equals(request.Currency, context.CurrencyCode, StringComparison.Ordinal))
            return CheckoutSubmissionResult.Invalidated;
        // W2 cash-sale slice only: returns and credit must wait for their own
        // approved policy and real posting acceptance. Never silently route
        // these through a cash-only trusted preparation.
        if (request.IsReturn || request.Payments is null ||
            request.Payments.Count != 1 ||
            request.Payments[0].Kind != CheckoutPaymentKind.Cash)
            return CheckoutSubmissionResult.Invalidated;
        if (!Enum.TryParse<CheckoutPaymentKind>(context.TenderCode, true, out var tender) ||
            !Enum.IsDefined(tender) || request.Payments is null || request.Payments.Count != 1 ||
            request.Payments[0].Kind != tender || request.Payments[0].Amount != context.TenderedAmount)
            return CheckoutSubmissionResult.Invalidated;
        request.Validate();
        return _gate.Commit(request) switch
        {
            FinancialCommitOutcome.Committed or FinancialCommitOutcome.AlreadyCommitted => CheckoutSubmissionResult.Committed,
            _ => CheckoutSubmissionResult.Unknown
        };
    }


    public CheckoutSubmissionResult SubmitFullCashReturn(string stableOperationId,
        string originalTicketId, CashierPaymentContext context)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId) ||
            string.IsNullOrWhiteSpace(originalTicketId) || originalTicketId.Length > 64 ||
            context?.IsWellFormed != true ||
            !string.Equals(context.TenderCode, nameof(CheckoutPaymentKind.Cash), StringComparison.OrdinalIgnoreCase) ||
            _returnPreparation is null)
            return CheckoutSubmissionResult.Invalidated;
        AuthorizedCheckoutRequest request;
        try { request = _returnPreparation.PrepareFullCashReturn(stableOperationId, originalTicketId, context); }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        { return CheckoutSubmissionResult.Invalidated; }
        if (request is null || !request.IsReturn ||
            !string.Equals(request.OperationId, stableOperationId, StringComparison.Ordinal) ||
            !string.Equals(request.OriginalTicketId, originalTicketId, StringComparison.Ordinal) ||
            !string.Equals(request.CashierId, context.CashierId, StringComparison.Ordinal) ||
            !string.Equals(request.Currency, context.CurrencyCode, StringComparison.Ordinal) ||
            request.Payments is null || request.Payments.Count != 1 ||
            request.Payments[0] is not { Kind: CheckoutPaymentKind.Cash, Amount: > 0m } ||
            request.ExpectedTotal != request.Payments[0].Amount)
            return CheckoutSubmissionResult.Invalidated;
        try
        {
            request.Validate();
            return _gate.Commit(request) switch
            {
                FinancialCommitOutcome.Committed or FinancialCommitOutcome.AlreadyCommitted => CheckoutSubmissionResult.Committed,
                _ => CheckoutSubmissionResult.Unknown
            };
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        { return CheckoutSubmissionResult.Unknown; }
    }

    public CheckoutResolution Reconcile(string stableOperationId)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId)) return CheckoutResolution.Unknown;
        try
        {
            var outcome = string.Equals(_gate.UncertainOperationId, stableOperationId, StringComparison.Ordinal)
                ? _gate.Reconcile(stableOperationId)
                : _journal.Lookup(stableOperationId);
            return outcome switch
            {
                CheckoutOperationOutcome.Persisted => CheckoutResolution.Persisted,
                CheckoutOperationOutcome.Absent => CheckoutResolution.Absent,
                _ => CheckoutResolution.Unknown
            };
        }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        { return CheckoutResolution.Unknown; }
    }
}
