using System;
using LOGICA.Domain;

internal static class SalesLinePricingTests
{
    private static int assertions;
    private static void Equal(decimal price, decimal quantity, decimal discount, decimal expected)
    {
        assertions++;
        decimal actual = SalesLinePricing.CalculateNetAmount(price, quantity, discount);
        if (actual != expected) throw new Exception("Unexpected line amount: " + actual + " != " + expected);
    }
    private static decimal Legacy(decimal price, decimal quantity, decimal discount)
    {
        return decimal.Subtract(decimal.Multiply(price, quantity),
            decimal.Divide(decimal.Multiply(decimal.Multiply(price, quantity), discount), 100m));
    }
    public static int Main()
    {
        try
        {
            Equal(25m, 2m, 10m, 45m);
            Equal(12.5m, 1.25m, 0m, 15.625m);
            Equal(12.5m, -2m, 10m, -22.5m);
            Equal(25m, 2m, 100m, 0m);
            Equal(25m, 0m, 10m, 0m);
            Equal(25m, 2m, -10m, 55m);
            Equal(25m, 2m, 150m, -25m);
            Equal(0.01m, 0.5m, 0m, 0.005m);
            Equal(decimal.MaxValue, 1m, 0m, decimal.MaxValue);
            Equal(decimal.MinValue, 1m, 0m, decimal.MinValue);
            for (int price = 0; price <= 50; price++)
                for (int quantity = -20; quantity <= 20; quantity++)
                    foreach (decimal discount in new[] { -10m, 0m, 5.5m, 50m, 100m, 150m })
                        Equal(price / 10m, quantity / 4m, discount,
                            Legacy(price / 10m, quantity / 4m, discount));
            // Preserve failure boundaries instead of silently changing the calculation order.
            foreach (decimal[] input in new[] {
                new[] { decimal.MaxValue, 2m, 0m },
                new[] { decimal.MaxValue, 1m, 100m } })
            {
                bool overflow = false;
                try { SalesLinePricing.CalculateNetAmount(input[0], input[1], input[2]); }
                catch (OverflowException) { overflow = true; }
                assertions++;
                if (!overflow) throw new Exception("Expected legacy intermediate overflow");
            }
            Console.WriteLine("PASS sales line pricing: " + assertions + " assertions; no UI or database");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
