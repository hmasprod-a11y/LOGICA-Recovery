using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Presentation.Formatting;

internal static class CatalogueAggregateFormattingTests
{
    private static string LegacyCount(object value)
    {
        return value == DBNull.Value ? Conversions.ToString(0) :
            Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(value)));
    }
    private static string LegacyMoney(object value)
    {
        if (value == DBNull.Value) return (Conversions.ToString(0) + " DH").PadLeft(20, '#');
        decimal amount = Conversions.ToDecimal(value);
        decimal rounded = Conversions.ToDecimal(Math.Round(amount, 2, MidpointRounding.AwayFromZero).ToString("N2"));
        return (Conversions.ToString(rounded) + " DH").PadLeft(20, '#');
    }
    private static string Outcome(Func<string> action)
    {
        try { return "value:" + action(); }
        catch (Exception error) { return "error:" + error.GetType().FullName; }
    }
    public static int Main()
    {
        var original = CultureInfo.CurrentCulture; int assertions = 0;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                object[] values = { DBNull.Value, null, (short)3, 0, -1, 1.005m, -0.005m,
                    1234.567m, decimal.MaxValue, double.NaN, double.PositiveInfinity,
                    "1.25", "1,25", "", "abc", true, new DateTime(2026,1,1) };
                foreach (object value in values)
                {
                    object input = value;
                    assertions += 2;
                    if (Outcome(delegate { return CatalogueAggregateFormatting.Count(input); }) !=
                        Outcome(delegate { return LegacyCount(input); }) ||
                        Outcome(delegate { return CatalogueAggregateFormatting.Money(input); }) !=
                        Outcome(delegate { return LegacyMoney(input); }))
                        throw new Exception("Aggregate display value or exception changed: " + culture);
                }
                assertions += 4;
                string rounded = (12.35m.ToString(CultureInfo.CurrentCulture) + " DH").PadLeft(20, '#');
                if (CatalogueAggregateFormatting.Count(DBNull.Value) != "0" ||
                    CatalogueAggregateFormatting.Count(7) != "7" ||
                    CatalogueAggregateFormatting.Money(DBNull.Value) != new string('#',16)+"0 DH" ||
                    CatalogueAggregateFormatting.Money(12.345m) != rounded)
                    throw new Exception("Known aggregate label formatting changed");
            }
            Console.WriteLine("PASS catalogue aggregate formatting: " + assertions + " assertions; DBNull, cultures, masks, rounding and exception types");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
