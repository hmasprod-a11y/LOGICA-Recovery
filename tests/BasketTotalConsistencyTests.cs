using System;
using System.Globalization;
using LOGICA.Domain;

internal static class BasketTotalConsistencyTests
{
    private static int assertions;
    private static void Check(decimal basket, decimal displayed, bool different)
    {
        assertions++;
        if (BasketTotalConsistency.AreDifferent(basket, displayed.ToString("N2")) != different)
            throw new Exception("Rounded consistency behavior changed");
    }
    private static void Bad(string displayed)
    {
        assertions++;
        try { BasketTotalConsistency.AreDifferent(25m, displayed); }
        catch (InvalidCastException) { return; }
        throw new Exception("Expected legacy conversion failure");
    }
    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                Check(25m,25m,false);
                Check(27m,25m,true);
                Check(25.4m,25m,false);
                Check(24.5m,24m,false);
                Check(25.5m,26m,false);
                Check(25.5m,25m,true);
                Check(-24.5m,-24m,false);
                Check(-25.5m,-26m,false);
                Check(15.625m,15.63m,false);
                Check(0m,0m,false);
                Check(0.5m,0m,false);
                Check(1.5m,2m,false);
                Check(1234.5m,1234m,false);
                Check(decimal.MaxValue,decimal.MaxValue,false);
                // The original Val comparison loses a unit at this magnitude; preserve it.
                Check(decimal.MaxValue-1m,decimal.MaxValue,false);
                Check(decimal.MaxValue,decimal.MinValue,true);
                assertions++;
                if (BasketTotalConsistency.AreDifferent(0m,null)) throw new Exception("Null converts to zero");
                assertions++;
                if (!BasketTotalConsistency.AreDifferent(1m,null)) throw new Exception("Nonzero versus null must differ");
                Bad("bad-amount");
                Bad("");
            }
            Console.WriteLine("PASS basket total consistency: " + assertions + " assertions; midpoint, cultures and legacy conversion boundaries");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
