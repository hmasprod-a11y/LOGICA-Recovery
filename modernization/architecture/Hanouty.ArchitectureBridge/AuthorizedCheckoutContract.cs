using System;
using System.Collections.Generic;
using System.Linq;

namespace Hanouty.ArchitectureBridge;

// W2 financial authorization envelope. This is a contract, not a second
// posting engine: Checkout owns pricing, tax, rounding and durable writes.
// Legacy IAtomicCheckoutBatchPort remains a staging-only compatibility seam.
public enum CheckoutPaymentKind { Cash, Card, BankTransfer, Credit }

public sealed record CheckoutPayment(CheckoutPaymentKind Kind, decimal Amount);
public sealed record CheckoutOriginalReturnLineSnapshot(string ArticleId, string ArticleName, decimal OriginalQuantity,
    decimal OriginalUnitPrice, decimal OriginalDiscountPercent, decimal OriginalNet, decimal ReturnedQuantity, decimal ReturnedNet);
public sealed record CheckoutPartialReturnSelection(CheckoutOriginalReturnLineSnapshot Original, int Quantity);
public sealed record CheckoutPartialCashReturnReview(IReadOnlyList<CheckoutPartialReturnSelection> Selections);
public sealed record CheckoutCustomerIdentity(string Id, string Code, string Name)
{
    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Id) || Id.Length > 64 || Id != Id.Trim() || Id == "0" ||
            Id.Any(character => char.IsControl(character) || char.IsSurrogate(character)) ||
            Code is null || Code.Length > 255 || string.IsNullOrWhiteSpace(Name) || Name.Length > 255 ||
            Code.Any(character => char.IsControl(character) || char.IsSurrogate(character)) ||
            Name.Any(character => char.IsControl(character) || char.IsSurrogate(character)))
            throw new ArgumentException("A reviewed, complete customer identity is required.");
    }
}

public sealed record AuthorizedCheckoutRequest(
    string OperationId,
    string CashierId,
    string Currency,
    bool IsReturn,
    IReadOnlyList<CheckoutBatchLine> Lines,
    IReadOnlyList<CheckoutPayment> Payments,
    decimal ExpectedTotal,
    string? OriginalTicketId = null,
    CheckoutCustomerIdentity? Customer = null,
    bool ExternalCardRefundConfirmed = false,
    CheckoutPartialCashReturnReview? PartialCashReturn = null)
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
        if (IsReturn && string.IsNullOrWhiteSpace(OriginalTicketId))
            throw new ArgumentException("A durable original ticket reference is required for returns.", nameof(OriginalTicketId));
        if (!IsReturn && OriginalTicketId is not null)
            throw new ArgumentException("An original ticket reference is only valid for returns.", nameof(OriginalTicketId));
        if (ExpectedTotal <= 0)
            throw new ArgumentOutOfRangeException(nameof(ExpectedTotal));
        var cardReturn = IsReturn && Payments.Any(payment => payment.Kind == CheckoutPaymentKind.Card);
        if (cardReturn && (Payments.Count != 1 || !ExternalCardRefundConfirmed) || !cardReturn && ExternalCardRefundConfirmed)
            throw new ArgumentException("A single card-refund mode requires explicit confirmation of externally completed reimbursement.", nameof(ExternalCardRefundConfirmed));
        var credit = Payments.Any(payment => payment.Kind == CheckoutPaymentKind.Credit);
        if (credit && (Payments.Count != 1 || Customer is null))
            throw new ArgumentException("A reviewed customer and a single credit allocation are required.", nameof(Customer));
        if (credit) Customer!.Validate();
        if (!credit && Customer is not null)
            throw new ArgumentException("Named paid-sale metadata requires its own accepted flow.", nameof(Customer));
        if (PartialCashReturn is { } partial && (!IsReturn || Payments.Count != 1 || Payments[0].Kind != CheckoutPaymentKind.Cash ||
            partial.Selections is null || partial.Selections.Count != Lines.Count || partial.Selections.Any(item => item is null || item.Original is null || item.Quantity <= 0) ||
            partial.Selections.Select(item => item.Original.ArticleId).Distinct(StringComparer.OrdinalIgnoreCase).Count() != Lines.Count ||
            partial.Selections.Any(item => Lines.Count(line => line.ArticleId == item.Original.ArticleId && line.Quantity == item.Quantity) != 1)))
            throw new ArgumentException("A reviewed original snapshot and selected positive quantities are required for a cash partial return.", nameof(PartialCashReturn));
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
