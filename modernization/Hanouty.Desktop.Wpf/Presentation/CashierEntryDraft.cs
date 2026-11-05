using System;
using System.Globalization;

namespace Hanouty.Desktop.Wpf.Presentation;

// Input validation only. Never an authorization decision or a price source.
// The Host must resolve cashier/register identity and trusted basket totals.
public static class CashierEntryDraft
{
    public static bool TryParse(string? cashier, string? register, string? cashMad,
        out string cashierId, out string registerId, out decimal tender)
    {
        cashierId = "";
        registerId = "";
        tender = 0m;
        if (string.IsNullOrWhiteSpace(cashier) || string.IsNullOrWhiteSpace(register) ||
            cashier != cashier.Trim() || register != register.Trim() ||
            cashier.Length > 64 || register.Length > 64 ||
            string.IsNullOrWhiteSpace(cashMad) || cashMad != cashMad.Trim()) return false;
        // Explicit invariant decimal entry; never locale-dependent thousands grouping.
        if (!decimal.TryParse(cashMad, NumberStyles.AllowDecimalPoint,
            CultureInfo.InvariantCulture, out tender) || tender < 0m ||
            decimal.Round(tender, 2) != tender) return false;
        cashierId = cashier;
        registerId = register;
        return true;
    }
}
