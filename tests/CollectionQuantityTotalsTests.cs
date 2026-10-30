using System;
using System.Globalization;
using LOGICA.Domain;
using Microsoft.VisualBasic.CompilerServices;

internal static class CollectionQuantityTotalsTests
{
    private static decimal Legacy(object[] values)
    {
        decimal total = 0m;
        for (int index = 0; index < values.Length; index++)
            total = Conversions.ToDecimal(Operators.AddObject(total, values[index]));
        return total;
    }
    private static string Outcome(Func<decimal> action)
    {
        try { return "value:" + action().ToString(CultureInfo.InvariantCulture); }
        catch (Exception error) { return "error:" + error.GetType().FullName; }
    }
    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        int assertions = 0;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                object[][] vectors = {
                    new object[0], new object[]{1.25m,-0.5m}, new object[]{"1.25","-0.5"},
                    new object[]{"1,25","-0,5"}, new object[]{2,(short)3,-1L}, new object[]{null,1m},
                    new object[]{DBNull.Value,1m}, new object[]{true,false}, new object[]{"",1m},
                    new object[]{"abc",1m}, new object[]{decimal.MaxValue,1m},
                    new object[]{double.NaN}, new object[]{double.PositiveInfinity},
                    new object[]{0.1d,0.2d}, new object[]{new DateTime(2026,1,1)},
                    new object[]{1m,DBNull.Value,"unvisited"}
                };
                foreach (object[] values in vectors)
                {
                    int reads = 0;
                    string actual = Outcome(delegate { return CollectionQuantityTotals.Accumulate(values.Length-1, delegate(int index) { reads++; return values[index]; }); });
                    string expected = Outcome(delegate { return Legacy(values); });
                    assertions++;
                    if (actual != expected) throw new Exception("Raw-object total conversion changed in " + culture);
                    assertions++;
                    if (actual.StartsWith("value:") && reads != values.Length)
                        throw new Exception("Quantity read count changed");
                }
                assertions += 2;
                if (CollectionQuantityTotals.Accumulate(1, delegate(int index) { return index==0?1.25m:-0.5m; }) != 0.75m ||
                    CollectionQuantityTotals.Accumulate(-1, delegate(int index) { throw new Exception("empty read"); }) != 0m)
                    throw new Exception("Known total or empty range changed");
                Exception marker = new InvalidOperationException("read failure"), caught = null;
                int calls = 0;
                try { CollectionQuantityTotals.Accumulate(2, delegate(int index) { calls++; if (index==1) throw marker; return 1m; }); }
                catch (Exception error) { caught = error; }
                assertions += 2;
                if (!Object.ReferenceEquals(marker,caught) || calls!=2) throw new Exception("Read exception identity or early stop changed");
                calls = 0;
                try { CollectionQuantityTotals.Accumulate(2, delegate(int index) { calls++; return index==0?(object)DBNull.Value:1m; }); } catch (Exception) { }
                assertions++;
                if (calls!=1) throw new Exception("Read continued after invalid raw value");
            }
            Console.WriteLine("PASS collection quantity totals: " + assertions + " assertions; raw types, cultures, empty, overflow and deferred failures");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
