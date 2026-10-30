using System;
using System.Globalization;
using Microsoft.VisualBasic;
using LOGICA.Domain;

internal static class ClientSettlementAmountRuleTests
{
    public static int Main()
    {
        string[] inputs = { null, "", " ", "0", "0.00", "-1", "-0.01", "1", "0.001", "12.50", "+12", "  10", "12abc", "1,5", "1.5", "abc", "&H10", "1e2", "-1e2", "1.2.3", "NaN", "999999999999999999999999" };
        foreach (string culture in new [] { "fr-MA", "fr-FR", "en-US" })
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
            foreach (string input in inputs)
            {
                string expected;
                try { expected = (Conversion.Val(input) <= 0.0).ToString(); }
                catch(Exception ex) { expected = ex.GetType().FullName; }
                string actual;
                try { actual = ClientSettlementAmountRule.IsRejected(input).ToString(); }
                catch(Exception ex) { actual = ex.GetType().FullName; }
                if (expected != actual)
                    throw new Exception("Settlement amount guard changed under " + culture + " for '" + input + "': expected " + expected + ", actual " + actual);
            }
        }
        Console.WriteLine("PASS settlement amount guard legacy Val parity across 3 cultures and 22 input cases");
        return 0;
    }
}
