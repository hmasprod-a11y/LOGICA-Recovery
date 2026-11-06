using System;

namespace Hanouty.Desktop.Wpf.Presentation;

// UI-only return intent. Checkout alone may validate persisted line, quantity,
// cashier grant, original ticket and post a durable return transaction.
public sealed class ReturnReviewDraft
{
    public string? OriginalSaleId { get; private set; }
    public decimal Quantity { get; private set; }
    public bool Confirmed { get; private set; }
    public string Status { get; private set; } = "Select a persisted original sale";
    public void SetOriginalSale(string? saleId)
    {
        OriginalSaleId = string.IsNullOrWhiteSpace(saleId) ? null : saleId;
        Quantity = 0m;
        Confirmed = false;
        Status = OriginalSaleId is null ? "Select a persisted original sale" : "Enter return quantity";
    }
    public bool SetQuantity(string text)
    {
        Confirmed = false;
        Quantity = 0m;
        if (OriginalSaleId is null || !decimal.TryParse(text, System.Globalization.NumberStyles.AllowDecimalPoint,
            System.Globalization.CultureInfo.InvariantCulture, out var amount) || amount <= 0m ||
            decimal.Round(amount, 3) != amount)
        {
            Status = "Invalid return quantity";
            return false;
        }
        Quantity = amount;
        Status = "Review original sale and confirm quantity";
        return true;
    }
    public bool Confirm(bool cashierActive, bool unresolvedOperation)
    {
        Confirmed = cashierActive && !unresolvedOperation && OriginalSaleId is not null && Quantity > 0m;
        Status = Confirmed ? "Return draft confirmed — financial posting unavailable until Checkout authorizes" :
            "Return confirmation refused — verify cashier, quantity and reconciliation";
        return Confirmed;
    }
    public void Invalidate(string reason)
    {
        OriginalSaleId = null;
        Quantity = 0m;
        Confirmed = false;
        Status = reason;
    }
}
