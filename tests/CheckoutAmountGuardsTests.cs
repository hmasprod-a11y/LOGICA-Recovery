using System;
using System.Globalization;
using LOGICA.Domain;

internal static class CheckoutAmountGuardsTests
{
    private static int assertions;
    private static void Check(string operation, string amount, bool negativeSale, bool positiveReturn)
    {
        assertions++;
        if (CheckoutAmountGuards.IsNegativeSale(operation, amount) != negativeSale)
            throw new Exception("Negative-sale guard changed");
        assertions++;
        if (CheckoutAmountGuards.IsPositiveReturn(operation, amount) != positiveReturn)
            throw new Exception("Positive-return guard changed");
    }
    private static void Throws<T>(Action action) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name);
    }

    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                string positive = 1234.5m.ToString("N2");
                string negative = (-1234.5m).ToString("N2");
                Check("VENTE", negative, true, false);
                Check("VENTE", positive, false, false);
                Check("VENTE", "0", false, false);
                Check("RETOUR", positive, false, true);
                Check("RETOUR", negative, false, false);
                Check("RETOUR REMBOURSEMENT", positive, false, true);
                Check("RETOUR CREDIT", positive, false, true);
                Check("RETOUR AVOIR", positive, false, true);
                Check("RETOUR", "0", false, false);
                Check("CREDIT", negative, false, false);
                Check("vente", negative, false, false);
                Check("retour", positive, false, false);
                Check("", positive, false, false);
                Check("VENTE", null, false, false);
                // '&' converts even for nonmatching operations; do not change this to '&&'.
                Throws<InvalidCastException>(delegate { CheckoutAmountGuards.IsNegativeSale("CREDIT", "bad-amount"); });
                Throws<InvalidCastException>(delegate { CheckoutAmountGuards.IsPositiveReturn("VENTE", "bad-amount"); });
                Throws<NullReferenceException>(delegate { CheckoutAmountGuards.IsPositiveReturn(null, "bad-amount"); });
                assertions++;
                if (CheckoutAmountGuards.IsNegativeSale(null, negative))
                    throw new Exception("Null operation is not VENTE");
            }
            Console.WriteLine("PASS checkout amount guards: " + assertions + " assertions; signs, cultures and legacy eager failures");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
