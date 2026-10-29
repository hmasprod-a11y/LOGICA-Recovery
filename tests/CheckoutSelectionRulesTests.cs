using System;
using System.Globalization;
using LOGICA.Domain;

internal static class CheckoutSelectionRulesTests
{
    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        int assertions = 0;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                string[] inputs = { null, "", " ", "\t", "\r\n", "  client  ", "Client", "0", "False", "\0" };
                for (int i = 0; i < inputs.Length; i++)
                {
                    assertions++;
                    if (CheckoutSelectionRules.IsMissing(inputs[i]) != (i < 2))
                        throw new Exception("Selection-empty behavior changed");
                }
            }
            Console.WriteLine("PASS checkout selection rules: " + assertions + " assertions; null, empty and untrimmed display names");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
