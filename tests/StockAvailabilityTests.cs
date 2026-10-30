using System;
using System.Globalization;
using LOGICA.Domain;

internal static class StockAvailabilityTests
{
    private static int assertions;
    private static void Check(object available, object requested, bool expected)
    {
        assertions++;
        if (StockAvailability.IsBelowRequested(available, requested) != expected)
            throw new Exception("Stock comparison changed");
    }
    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                Check(1m,2m,true);
                Check(2m,2m,false);
                Check(3m,2m,false);
                Check(0m,0m,false);
                Check(-1m,0m,true);
                Check(0m,-1m,false);
                Check(1.25m,1.5m,true);
                Check(1.5m,1.25m,false);
                Check(1.25d,1.5d,true);
                Check("1","2",true);
                Check("10","2",true);
                Check(10m,"2",false);
                Check("10",2m,false);
                Check(5m.ToString("N2"),6m,true);
                Check(6m,5m.ToString("N2"),false);
                Check(decimal.MaxValue,decimal.MaxValue,false);
                Check(decimal.MinValue,decimal.MaxValue,true);
                Check(null,1m,true);
                assertions++;
                try { StockAvailability.IsBelowRequested("bad-quantity",1m); }
                catch (InvalidCastException) { continue; }
                throw new Exception("Expected legacy numeric coercion failure");
            }
            Console.WriteLine("PASS stock availability: " + assertions + " assertions; exact, fractional, object and culture semantics");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
