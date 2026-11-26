using System;
using System.Globalization;

namespace Hanouty.Desktop.Wpf.Presentation;

// Input validation only. Never an authorization decision or a price source.
// The Host must resolve cashier/register identity and trusted basket totals.
public static class CashierEntryDraft
{
    private static bool HasControlCharacters(string value)
    {
        foreach (var character in value)
            if (char.IsControl(character) || char.IsSurrogate(character)) return true;
        return false;
    }

    public static bool TryParse(string? cashier, string? register, string? cashMad,
        out string cashierId, out string registerId, out decimal tender)
    {
        cashierId = "";
        registerId = "";
        tender = 0m;
        if (string.IsNullOrWhiteSpace(cashier) || string.IsNullOrWhiteSpace(register) ||
            cashier != cashier.Trim() || register != register.Trim() ||
            cashier.Length > 64 || register.Length > 64 ||
            HasControlCharacters(cashier) || HasControlCharacters(register) ||
            string.IsNullOrWhiteSpace(cashMad) || cashMad != cashMad.Trim()) return false;
        // Accept only complete unsigned MAD amounts: digits, optionally followed
        // by one separator and one or two fractional digits. Decimal.TryParse
        // alone accepts unfinished keyboard input such as "1." and ".5".
        var separatorSeen = false;
        var fractionalDigits = 0;
        if (cashMad.Length > 32) return false;
        for (var i = 0; i < cashMad.Length; i++)
        {
            var c = cashMad[i];
            if (c >= '0' && c <= '9')
            {
                if (separatorSeen) fractionalDigits++;
            }
            else if (c == '.' && !separatorSeen && i > 0)
                separatorSeen = true;
            else return false;
        }
        if (separatorSeen && (fractionalDigits == 0 || fractionalDigits > 2)) return false;
        // Explicit invariant decimal entry; never locale-dependent thousands grouping.
        if (!decimal.TryParse(cashMad, NumberStyles.AllowDecimalPoint,
            CultureInfo.InvariantCulture, out tender) || tender < 0m ||
            decimal.Round(tender, 2) != tender) return false;
        cashierId = cashier;
        registerId = register;
        return true;
    }
}
