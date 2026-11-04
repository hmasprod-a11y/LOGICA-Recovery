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

// Maps WPF's existing context to Architecture's EXISTING AuthorizedCheckoutRequest.
// No local DB reads, pricing, posting implementation, or implicit host registration.
public sealed class AuthorizedWpfCheckoutAdapter : IContextualCheckoutSubmission, ICheckoutOutcomeReconciliation
{
    private readonly ITrustedWpfCheckoutPreparation _preparation;
    private readonly AuthorizedCheckoutCommitGate _gate;
    private readonly ICheckoutOperationJournal _journal;

    public AuthorizedWpfCheckoutAdapter(ITrustedWpfCheckoutPreparation preparation,
        AuthorizedCheckoutCommitGate gate, ICheckoutOperationJournal journal)
    {
        _preparation = preparation ?? throw new ArgumentNullException(nameof(preparation));
        _gate = gate ?? throw new ArgumentNullException(nameof(gate));
        _journal = journal ?? throw new ArgumentNullException(nameof(journal));
    }

    public CheckoutSubmissionResult Submit(string stableOperationId) =>
        throw new InvalidOperationException("Cashier/payment context and trusted preparation are required.");

    public CheckoutSubmissionResult Submit(string stableOperationId, CashierPaymentContext context)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId) || context?.IsWellFormed != true)
            return CheckoutSubmissionResult.Invalidated;

        // No posting until the application's trusted preparation exists.
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
            request.Payments[0].Kind == CheckoutPaymentKind.Credit)
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

    public CheckoutResolution Reconcile(string stableOperationId)
    {
        if (string.IsNullOrWhiteSpace(stableOperationId)) return CheckoutResolution.Unknown;
        // Query the authoritative durable journal only. A UI reconciliation
        // cannot unlock the basket or authorize a new payment attempt.
        return _journal.Lookup(stableOperationId) switch
        {
            CheckoutOperationOutcome.Persisted => CheckoutResolution.Persisted,
            CheckoutOperationOutcome.Absent => CheckoutResolution.Absent,
            _ => CheckoutResolution.Unknown
        };
    }
}
