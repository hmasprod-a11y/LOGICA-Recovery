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
        Status = OriginalSaleId is null ? "Select a persisted original sale" : "Review the complete original ticket for a full cash refund";
    }
    public bool SetQuantity(string text)
    {
        Confirmed = false;
        Quantity = 0m;
        // Moroccan French/Arabic keyboards commonly enter comma decimals. Accept
        // exactly one decimal separator without accepting grouping or mixed syntax.
        var raw = text?.Trim();
        // A trailing separator is an unfinished keyboard edit, not an approved
        // return amount. Reject incomplete, signed, grouped and mixed formats.
        // Decimal.TryParse alone accepts some incomplete forms (e.g. "1.").
        var separatorSeen = false;
        var digitsAfterSeparator = 0;
        var validSyntax = !string.IsNullOrEmpty(raw);
        if (validSyntax)
        {
            for (var i = 0; i < raw!.Length; i++)
            {
                var c = raw[i];
                if (c >= '0' && c <= '9')
                {
                    if (separatorSeen) digitsAfterSeparator++;
                }
                else if ((c == '.' || c == ',') && !separatorSeen && i > 0)
                    separatorSeen = true;
                else { validSyntax = false; break; }
            }
            if (separatorSeen && digitsAfterSeparator == 0) validSyntax = false;
        }
        var normalized = validSyntax ? raw!.Replace(',', '.') : null;
        if (OriginalSaleId is null || string.IsNullOrEmpty(normalized) ||
            !decimal.TryParse(normalized, System.Globalization.NumberStyles.AllowDecimalPoint,
            System.Globalization.CultureInfo.InvariantCulture, out var amount) || amount <= 0m ||
            (decimal.GetBits(amount)[3] >> 16 & 0xFF) > 3)
        {
            Status = "Invalid return quantity";
            return false;
        }
        Quantity = amount;
        Status = "Review original sale and confirm quantity";
        return true;
    }
    public void ClearQuantity(string reason)
    {
        Quantity = 0m;
        Confirmed = false;
        Status = reason;
    }
    public bool ConfirmFullTicket(bool cashierActive, bool unresolvedOperation)
    {
        Quantity = 0m;
        Confirmed = cashierActive && !unresolvedOperation && OriginalSaleId is not null;
        Status = Confirmed ? "Full-ticket cash refund confirmed for checkout authorization" :
            "Refund confirmation refused — verify cashier and reconciliation";
        return Confirmed;
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
