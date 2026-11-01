using System;
using System.Collections.Generic;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;

internal static class CheckoutArticleImageSelectionTests
{
    private static void Require(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }

    public static int Main()
    {
        int cases = 0;
        var original = CultureInfo.CurrentCulture;
        var originalUi = CultureInfo.CurrentUICulture;
        try
        {
            foreach (string culture in new[] { "en-US", "fr-FR", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                foreach (string invalid in new[] {
                    null, "", " ", "\t", "0.png", "0.PNG", "0X.png", "0x.PNG",
                    ".", "..", "../secret.png", "..\\secret.png",
                    "C:\\secret.png", "/absolute.png", "nested/image.png"
                })
                {
                    int calls = 0;
                    bool result = CheckoutArticleImageSelectionService.IsEligible(invalid,
                        delegate(string name) { calls++; return true; });
                    Require(!result && calls == 0, "Invalid filename reached filesystem: " + invalid);
                    cases++;
                }

                var present = new HashSet<string>(StringComparer.Ordinal) {
                    "item.png", "étiquette.webp", "item with spaces.jpg"
                };
                foreach (string name in new[] {
                    "item.png", "étiquette.webp", "item with spaces.jpg", "missing.png"
                })
                {
                    int calls = 0;
                    bool actual = CheckoutArticleImageSelectionService.IsEligible(name,
                        delegate(string value) { calls++; return present.Contains(value); });
                    Require(actual == present.Contains(name) && calls == 1,
                        "Image existence gate changed: " + name);
                    cases++;
                }

                var failure = new InvalidOperationException("filesystem failure");
                try
                {
                    CheckoutArticleImageSelectionService.IsEligible("valid.png",
                        delegate(string value) { throw failure; });
                    throw new Exception("Filesystem exception was swallowed");
                }
                catch (InvalidOperationException error)
                {
                    Require(Object.ReferenceEquals(error, failure), "Filesystem exception identity changed");
                    cases++;
                }
            }
        }
        finally
        {
            CultureInfo.CurrentCulture = original;
            CultureInfo.CurrentUICulture = originalUi;
        }
        Console.WriteLine("PASS checkout real-image selection: " + cases +
            " filename, placeholder, traversal, lazy filesystem and exception cases");
        return 0;
    }
}
