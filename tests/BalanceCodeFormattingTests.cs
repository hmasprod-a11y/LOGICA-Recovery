using System;
using System.Globalization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Domain;

internal static class BalanceCodeFormattingTests
{
    private static string Legacy(string width, Func<string> readCode)
    {
        int number = checked((int)Math.Round(Conversion.Val(width)));
        return Conversion.Val(readCode()).ToString(Strings.StrDup(number, "0"));
    }
    private static string Outcome(Func<string> action)
    {
        try { return "value:" + action(); }
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
                foreach (string code in new[] { null, "", " ", "123", " 123 ", "-12", "1.5", "1,5", "1e3", "&HFF", "CI_NOT_NUMERIC" })
                {
                    assertions++;
                    if (BalanceCodeFormatting.IsNumeric(code) != Versioned.IsNumeric(code))
                        throw new Exception("Legacy numeric guard changed");
                    foreach (string width in new[] { null, "", "0", "2", "6", "6.5", "7.5", "-1", "abc", "2147483648" })
                    {
                        string value = code;
                        int actualReads = 0, legacyReads = 0;
                        string actual = Outcome(delegate { return BalanceCodeFormatting.Format(width, delegate { actualReads++; return value; }); });
                        string expected = Outcome(delegate { return Legacy(width, delegate { legacyReads++; return value; }); });
                        assertions += 2;
                        if (actual != expected || actualReads != legacyReads)
                            throw new Exception("Balance conversion, formatting or read timing changed");
                    }
                }
                assertions += 3;
                if (BalanceCodeFormatting.Format("6", delegate { return "123"; }) != "000123" ||
                    BalanceCodeFormatting.Format("2", delegate { return "123456"; }) != "123456" ||
                    BalanceCodeFormatting.IsNumeric("CI_NOT_NUMERIC"))
                    throw new Exception("Known balance behavior changed");
                Exception marker = new InvalidOperationException("code read");
                Exception observed = null;
                try { BalanceCodeFormatting.Format("6", delegate { throw marker; }); } catch (Exception error) { observed = error; }
                assertions++;
                if (!Object.ReferenceEquals(marker, observed)) throw new Exception("Code-read exception identity changed");
            }
            Console.WriteLine("PASS balance code formatting: " + assertions + " assertions; VB numeric/Val, checked width, cultures, masks and deferred reads");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
