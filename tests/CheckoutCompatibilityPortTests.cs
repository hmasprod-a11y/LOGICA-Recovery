using System;
using System.Globalization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using LOGICA.Domain;
using LOGICA.Infrastructure.Compatibility;

internal static class CheckoutCompatibilityPortTests
{
    private static int assertions;
    private static readonly ILegacyCheckoutSemantics Port = VisualBasicCheckoutSemantics.Instance;
    private static void Same(string name, Func<object> original, Func<object> extracted)
    {
        object expected = null, actual = null;
        Type oldError = null, newError = null;
        try { expected = original(); } catch (Exception error) { oldError = error.GetType(); }
        try { actual = extracted(); } catch (Exception error) { newError = error.GetType(); }
        assertions++;
        if (oldError != newError || (oldError == null && !Object.Equals(expected, actual)))
            throw new Exception(name + " parity failed: " + expected + "/" + oldError + " versus " + actual + "/" + newError);
    }
    public static int Main()
    {
        CultureInfo originalCulture = CultureInfo.CurrentCulture;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                foreach (string operation in new[] { "VENTE", "RETOUR", "RETOUR CREDIT", "CREDIT", "", null, "vente" })
                foreach (string amount in new[] { "-5", "0", "5", "bad", "", null, "1,5", "1.5" })
                {
                    string op = operation, text = amount;
                    Same("sale guard", delegate { return (Operators.CompareString(op, "VENTE", false) == 0) & (Conversions.ToDouble(text) < 0.0); },
                        delegate { return CheckoutAmountGuards.IsNegativeSale(op, text, Port); });
                    Same("return guard", delegate { return op.Contains("RETOUR") & (Conversions.ToDouble(text) > 0.0); },
                        delegate { return CheckoutAmountGuards.IsPositiveReturn(op, text, Port); });
                }
                foreach (string name in new[] { null, "", " ", "\t", "Client", "0" })
                {
                    string n = name;
                    Same("selection", delegate { return Operators.CompareString(n, "", false) == 0; },
                        delegate { return CheckoutSelectionRules.IsMissing(n, Port); });
                }
                foreach (decimal basket in new[] { -25.5m, 0m, 0.5m, 25.5m, 1234.5m, decimal.MaxValue })
                foreach (string displayed in new[] { "-26", "0", "26", "bad", "", null, "1234,5", "1234.5" })
                {
                    decimal b = basket; string d = displayed;
                    Same("basket consistency", delegate {
                        return Conversion.Val(Math.Round(Conversions.ToDecimal(b.ToString()))) !=
                            Conversion.Val(Math.Round(Conversions.ToDecimal(d)));
                    }, delegate { return BasketTotalConsistency.AreDifferent(b, d, Port); });
                }
                foreach (decimal quantity in new[] { 0m, 1.25m, 10m, 9007199254740992m, decimal.MaxValue })
                foreach (decimal minimum in new[] { 0m, 1.25m, 10m, 9007199254740993m })
                foreach (decimal tier in new[] { -1m, 0m, 8.125m })
                {
                    decimal q = quantity, min = minimum, t = tier;
                    Same("tier price", delegate {
                        if (Conversion.Val(t) <= 0.0) return (object)null;
                        return Convert.ToDouble(q) >= Conversion.Val(min) ? (object)t : 12m;
                    }, delegate { return SalesLinePricing.SelectQuantityPrice(q, min, t, 12m, Port); });
                }
                object[] stocks = { null, 0m, 1m, 2m, "2", "10", "bad", DBNull.Value };
                foreach (object available in stocks)
                foreach (object requested in stocks)
                {
                    object a = available, q = requested;
                    Same("stock comparison", delegate { return Operators.ConditionalCompareObjectLess(a, q, false); },
                        delegate { return StockAvailability.IsBelowRequested(a, q, Port); });
                }
            }
            Console.WriteLine("PASS checkout VB adapter parity: " + assertions + " comparisons across 3 cultures");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = originalCulture; }
    }
}
