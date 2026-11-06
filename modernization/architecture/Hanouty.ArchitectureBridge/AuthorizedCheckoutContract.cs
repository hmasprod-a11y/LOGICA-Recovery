using System;
using System.Collections.Generic;
using System.Linq;

namespace Hanouty.ArchitectureBridge;

// W2 financial authorization envelope. This is a contract, not a second
// posting engine: Checkout owns pricing, tax, rounding and durable writes.
// Legacy IAtomicCheckoutBatchPort remains a staging-only compatibility seam.
public enum CheckoutPaymentKind { Cash, Card, BankTransfer, Credit }

public sealed record CheckoutPayment(CheckoutPaymentKind Kind, decimal Amount);

public sealed record AuthorizedCheckoutRequest(
    string OperationId,
    string CashierId,
    string Currency,
    bool IsReturn,
    IReadOnlyList<CheckoutBatchLine> Lines,
    IReadOnlyList<CheckoutPayment> Payments,
    decimal ExpectedTotal,
    string? OriginalTicketId = null)
{
    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(OperationId))
            throw new ArgumentException("Stable operation ID is required.", nameof(OperationId));
        if (string.IsNullOrWhiteSpace(CashierId))
            throw new ArgumentException("Authenticated cashier identity is required.", nameof(CashierId));
        if (string.IsNullOrWhiteSpace(Currency))
            throw new ArgumentException("Currency is required.", nameof(Currency));
        if (Lines is null || Lines.Count == 0 || Lines.Any(x =>
            x is null || string.IsNullOrWhiteSpace(x.ArticleId) || x.Quantity <= 0))
            throw new ArgumentException("At least one valid article line is required.", nameof(Lines));
        if (Lines.GroupBy(x => x.ArticleId, StringComparer.OrdinalIgnoreCase).Any(g => g.Count() > 1))
            throw new ArgumentException("Duplicate article identities are not allowed.", nameof(Lines));
        if (Payments is null || Payments.Count == 0 || Payments.Any(x =>
            x is null || !Enum.IsDefined(x.Kind) || x.Amount <= 0))
            throw new ArgumentException("At least one positive supported payment is required.", nameof(Payments));
        if (IsReturn && Payments.Any(x => x.Kind == CheckoutPaymentKind.Credit))
            throw new ArgumentException("Credit settlement on returns requires explicit Checkout policy.", nameof(Payments));
        if (IsReturn && string.IsNullOrWhiteSpace(OriginalTicketId))
            throw new ArgumentException("A durable original ticket reference is required for returns.", nameof(OriginalTicketId));
        if (!IsReturn && OriginalTicketId is not null)
            throw new ArgumentException("An original ticket reference is only valid for returns.", nameof(OriginalTicketId));
        if (ExpectedTotal <= 0)
            throw new ArgumentOutOfRangeException(nameof(ExpectedTotal));
        // Never compare totals here: legacy checkout owns rounding, discounts,
        // credit settlement and cash change; the financial port verifies them.
    }
}

// Must atomically authorize cashier, recompute trusted prices/taxes, persist
// sale/return + payment + stock + durable operation ID in one DB transaction.
// Unknown outcome is reconciled by ICheckoutOperationJournal, not retried.
public interface IAuthorizedCheckoutPort
{
    void Commit(AuthorizedCheckoutRequest request);
}
