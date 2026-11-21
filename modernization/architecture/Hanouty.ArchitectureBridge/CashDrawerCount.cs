using System.Globalization;
using LOGICA.Domain;

namespace Hanouty.ArchitectureBridge;

public static class CashDrawerCount
{
    private static readonly IReadOnlyList<decimal> denominations =
        Array.AsReadOnly(new[] { 200m, 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.5m, 0.2m, 0.1m });

    public static IReadOnlyList<decimal> Denominations => denominations;

    public static decimal Calculate(IReadOnlyList<int> counts)
    {
        ArgumentNullException.ThrowIfNull(counts);
        if (counts.Count != denominations.Count || counts.Any(count => count < 0))
            throw new ArgumentException("Enter a nonnegative count for each denomination.", nameof(counts));

        return CashDenominationTotal.Calculate(index => counts[index].ToString(CultureInfo.InvariantCulture),
            CountSemantics.Instance);
    }

    private sealed class CountSemantics : ILegacyCashSemantics
    {
        public static readonly CountSemantics Instance = new();

        public decimal ToDecimal(string text) => decimal.Parse(text, CultureInfo.InvariantCulture);
        public bool IsTrimmedEmpty(object text) => string.IsNullOrWhiteSpace(text as string);
        public bool IsNumeric(object value) => int.TryParse(value as string, out _);
        public bool IsCashPaymentMode(object value) => value is string mode && mode == "ESPECES";
    }
}
