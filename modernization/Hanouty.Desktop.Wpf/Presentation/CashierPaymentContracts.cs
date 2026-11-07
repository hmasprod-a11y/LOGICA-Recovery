using System;

namespace Hanouty.Desktop.Wpf.Presentation;

// UI-only immutable cashier/payment context. The Application boundary remains
// authoritative for authorization, pricing, currency and durable posting.
public sealed record CashierPaymentContext(
    string CashierId, string RegisterId, string CurrencyCode,
    string TenderCode, decimal TenderedAmount)
{
    public bool IsWellFormed =>
        !string.IsNullOrWhiteSpace(CashierId) &&
        !string.IsNullOrWhiteSpace(RegisterId) &&
        !string.IsNullOrWhiteSpace(CurrencyCode) &&
        !string.IsNullOrWhiteSpace(TenderCode) &&
        TenderedAmount >= 0m;
}

// An opt-in production submission seam: the UI supplies context, never grants
// cashier authorization itself. The adapter must validate against trusted state.
public interface IContextualCheckoutSubmission : ICheckoutSubmission
{
    CheckoutSubmissionResult Submit(string stableOperationId, CashierPaymentContext context);
}

public enum CheckoutResolution { Unknown, Persisted, Absent }

// Reconciliation must be backed by the durable operation journal; Unknown
// cannot unlock checkout or authorize a second operation.
public interface ICheckoutOutcomeReconciliation
{
    CheckoutResolution Reconcile(string stableOperationId);
}
