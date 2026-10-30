using System;
using System.Globalization;
using LOGICA.Presentation.Input;

internal static class NumericEntryFilterTests
{
    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        int assertions = 0;
        try
        {
            char[] allowed = { '0','1','2','3','4','5','6','7','8','9','\b','.','-' };
            char[] blocked = { '+',',',' ','a','e','E','\t','\r','\n','\0',(char)127,(char)0x0661,(char)0xff11,'/',':',(char)0xa0,char.MaxValue };
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                foreach (char key in allowed)
                {
                    assertions++;
                    if (NumericEntryFilter.ShouldBlock(key)) throw new Exception("Blocked legacy allowed character");
                }
                foreach (char key in blocked)
                {
                    assertions++;
                    if (!NumericEntryFilter.ShouldBlock(key)) throw new Exception("Accepted legacy blocked character");
                }
            }
            Console.WriteLine("PASS numeric entry filter: " + assertions + " assertions; ASCII boundaries, culture and legacy editing keys");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
