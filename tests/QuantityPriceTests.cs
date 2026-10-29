using System;
using System.Globalization;
using LOGICA.Domain;

internal static class QuantityPriceTests
{
    private static int assertions;
    private static void Check(decimal quantity, decimal minimum, decimal tier, decimal standard, decimal? expected)
    {
        decimal? actual = SalesLinePricing.SelectQuantityPrice(quantity, minimum, tier, standard);
        assertions++;
        if (actual != expected) throw new Exception("Quantity price mismatch");
    }
    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                Check(9m, 10m, 8m, 12m, 12m);
                Check(10m, 10m, 8m, 12m, 8m);
                Check(11m, 10m, 8m, 12m, 8m);
                Check(1.249m, 1.25m, 8.125m, 12.345m, 12.345m);
                Check(1.25m, 1.25m, 8.125m, 12.345m, 8.125m);
                Check(10m, 10m, 0m, 12m, null);
                Check(10m, 10m, -1m, 12m, null);
                Check(1m, 10m, 0m, 12m, null);
                Check(0m, 0m, 8m, 12m, 8m);
                Check(0m, 10m, 8m, 12m, 12m);
                Check(10m, 10m, 15m, 12m, 15m);
                Check(1m, 10m, 8m, 0m, 0m);
                // The original double comparison treats these adjacent integers as equal.
                Check(9007199254740992m, 9007199254740993m, 8m, 12m, 8m);
                Check(decimal.MaxValue, decimal.MaxValue, 8m, 12m, 8m);
                decimal? price = SalesLinePricing.SelectQuantityPrice(2m, 2m, 8m, 12m);
                assertions++;
                if (!price.HasValue || SalesLinePricing.CalculateNetAmount(price.Value, 2m, 10m) != 14.4m)
                    throw new Exception("Selected tier must feed the existing net calculation");
            }
            Console.WriteLine("PASS quantity price selection: " + assertions + " assertions; no UI or database");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
