using System;
using System.Globalization;
using LOGICA.Domain;
using Microsoft.VisualBasic.CompilerServices;

internal static class MonetaryRoundingTests
{
    private static int assertions;

    private static void Equal(decimal actual, decimal expected, string label)
    {
        assertions++;
        if (actual != expected)
            throw new Exception(label + ": expected " + expected + ", actual " + actual);
    }

    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        try
        {
            decimal[] inputs = { 0m, 1.004m, 1.005m, 12.345m, -1.005m, -12.345m,
                9999.995m, 0.0049m, -0.0049m, 1234567.895m, decimal.MaxValue, decimal.MinValue };
            decimal[] expected = { 0m, 1m, 1.01m, 12.35m, -1.01m, -12.35m,
                10000m, 0m, 0m, 1234567.90m, decimal.MaxValue, decimal.MinValue };
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                for (int i = 0; i < inputs.Length; i++)
                    Equal(MonetaryRounding.Round(inputs[i]), expected[i], culture + " known amount");
                // Characterize the original expression over positive/negative midpoint boundaries.
                for (int i = -10000; i <= 10000; i++)
                {
                    decimal amount = i / 1000m;
                    decimal legacy = Conversions.ToDecimal(
                        Math.Round(amount, 2, MidpointRounding.AwayFromZero).ToString("N2"));
                    Equal(MonetaryRounding.Round(amount), legacy, culture + " legacy compatibility");
                }
            }
            Console.WriteLine("PASS monetary rounding: " + assertions + " assertions; no UI or database");
            return 0;
        }
        catch (Exception error)
        {
            Console.Error.WriteLine(error);
            return 1;
        }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
