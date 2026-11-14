using System;

namespace Hanouty.Desktop.Wpf.Presentation;

// UI-only immutable cashier/payment context. The Application boundary remains
// authoritative for authorization, pricing, currency and durable posting.
public sealed record CashierPaymentContext(
    string CashierId, string RegisterId, string CurrencyCode,
    string TenderCode, decimal TenderedAmount)
{
    private static bool IsCleanIdentifier(string? value, int maximumLength) =>
        !string.IsNullOrWhiteSpace(value) &&
        value.Length <= maximumLength &&
        string.Equals(value, value.Trim(), StringComparison.Ordinal) &&
        !ContainsControlOrSurrogate(value);

    private static bool ContainsControlOrSurrogate(string value)
    {
        foreach (var character in value)
            if (char.IsControl(character) || char.IsSurrogate(character)) return true;
        return false;
    }

    public bool IsWellFormed =>
        IsCleanIdentifier(CashierId, 64) &&
        IsCleanIdentifier(RegisterId, 64) &&
        IsCleanIdentifier(CurrencyCode, 8) &&
        IsCleanIdentifier(TenderCode, 32) &&
        TenderedAmount >= 0m &&
        decimal.Round(TenderedAmount, 2) == TenderedAmount;
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
