using System;
using System.Globalization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Domain;

internal static class CatalogueRequiredFieldsTests
{
    private static bool Legacy(string value)
    {
        return Operators.CompareString(Strings.Trim(value), "", false) == 0;
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
                foreach (string value in new[] { null, "", " ", "   " })
                {
                    assertions++;
                    if (!CatalogueRequiredFields.IsMissingIdentifier(value)) throw new Exception("Required identifier baseline changed");
                }
                foreach (string value in new[] { "0", "False", " CI ", "CI's article", "\0" })
                {
                    assertions++;
                    if (CatalogueRequiredFields.IsMissingIdentifier(value)) throw new Exception("Nonempty identifier baseline changed");
                }
                // Include all single UTF-16 code units, both alone and space-padded.
                // VB Trim has its own whitespace semantics: retain the legacy oracle.
                for (int code = 0; code <= char.MaxValue; code++)
                {
                    string value = ((char)code).ToString();
                    foreach (string input in new[] { value, " " + value + " " })
                    {
                        assertions++;
                        if (CatalogueRequiredFields.IsMissingIdentifier(input) != Legacy(input))
                            throw new Exception("Identifier predicate differs at U+" + code.ToString("X4"));
                    }
                }
            }
            Console.WriteLine("PASS catalogue required identifiers: " + assertions + " assertions; legacy VB trim and empty semantics");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
