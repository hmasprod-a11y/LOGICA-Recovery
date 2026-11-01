using System;
using LOGICA.ApplicationLayer.Checkout;

internal static class PortableArticleImageSmoke
{
    public static int Run()
    {
        int probes = 0;
        Func<string, bool> exists = delegate(string name) {
            probes++;
            return name == "real.png";
        };
        if (!CheckoutArticleImageSelectionService.IsEligible("real.png", exists) ||
            CheckoutArticleImageSelectionService.IsEligible("missing.png", exists) ||
            CheckoutArticleImageSelectionService.IsEligible("0.png", exists) ||
            CheckoutArticleImageSelectionService.IsEligible("0X.png", exists) ||
            CheckoutArticleImageSelectionService.IsEligible("../real.png", exists) ||
            CheckoutArticleImageSelectionService.IsEligible(null, exists) ||
            probes != 2)
            throw new Exception("Portable image-only selection or filesystem laziness changed");
        Console.WriteLine("PASS .NET 10 checkout real-image selection and placeholder exclusion");
        return 0;
    }
}
