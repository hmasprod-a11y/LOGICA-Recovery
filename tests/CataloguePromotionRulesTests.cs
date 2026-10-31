using System;
using System.Globalization;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Domain;
using LOGICA.Infrastructure.Compatibility;

internal static class CataloguePromotionRulesTests
{
    private static bool Legacy(string text)
    {
        return Operators.CompareString(text, "", false) == 0 ||
            decimal.Compare(Conversions.ToDecimal(text), 100m) > 0;
    }

    private static string Outcome(Func<bool> rule)
    {
        try { return rule() ? "reject" : "continue"; }
        catch (Exception error) { return error.GetType().FullName; }
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
                foreach (string value in new[] { null, "", "101", "1000" })
                {
                    assertions++;
                    if (!CataloguePromotionRules.IsRejected(value, VisualBasicCatalogueSemantics.Instance))
                        throw new Exception("Required/upper-bound behavior changed");
                }
                foreach (decimal value in new[] { -100m, -1m, 0m, 1m, 99.99m, 100m })
                {
                    assertions++;
                    if (CataloguePromotionRules.IsRejected(value.ToString(CultureInfo.CurrentCulture), VisualBasicCatalogueSemantics.Instance))
                        throw new Exception("Legacy accepted promotion changed");
                }
                foreach (string value in new[] { null, "", " ", "\t", "abc", "-", ".", "0", "-1",
                    "100", "101", "100.01", "100,01", "99.99", "99,99", " 100 ", "+100",
                    "1e2", "1e3", "1,000", "1.000", "NaN", "Infinity", "\0",
                    decimal.MaxValue.ToString(), decimal.MinValue.ToString(),
                    "79228162514264337593543950336" })
                {
                    string input = value;
                    assertions++;
                    if (Outcome(delegate { return CataloguePromotionRules.IsRejected(input, VisualBasicCatalogueSemantics.Instance); }) !=
                        Outcome(delegate { return Legacy(input); }))
                        throw new Exception("Promotion conversion/exception changed: " + culture);
                }
                assertions++;
                if (Outcome(delegate { return CataloguePromotionRules.IsRejected("abc", VisualBasicCatalogueSemantics.Instance); }) ==
                    "reject" || Outcome(delegate { return CataloguePromotionRules.IsRejected("abc", VisualBasicCatalogueSemantics.Instance); }) == "continue")
                    throw new Exception("Malformed promotion must keep conversion failure");
            }
            Console.WriteLine("PASS catalogue promotion rules: " + assertions + " assertions; short circuit, upper bound, cultures and conversion failures");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
