using System;
using System.Globalization;
using LOGICA.Infrastructure.Checkout;
using LOGICA.Infrastructure.Compatibility;
using LOGICA.Domain;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal static class CheckoutCompletionSqlTests
{
    private static string LegacyAdvance(string ticket)
    {
        return "UPDATE     TABLE_NUM    SET CL =  " +
            Strings.Format(Conversions.ToDouble(ticket) + 1.0, "000000") + "  ";
    }

    private static string Outcome(Func<string> action)
    {
        try { return "ok:" + action(); }
        catch (Exception error) { return "error:" + error.GetType().FullName; }
    }

    private sealed class TracingSemantics : ILegacyCheckoutCompletionSemantics
    {
        internal readonly Exception Failure = new InvalidOperationException("injected");
        internal int Calls, FailAt;
        public double ToDouble(string text)
        {
            Calls++;
            if (Calls == FailAt) throw Failure;
            return 42.0;
        }
        public string FormatSequence(double value)
        {
            Calls++;
            if (Calls == FailAt) throw Failure;
            if (value != 43.0) throw new Exception("Sequence arithmetic changed");
            return "000043";
        }
    }

    public static int Main()
    {
        var oldCulture = CultureInfo.CurrentCulture;
        var oldUiCulture = CultureInfo.CurrentUICulture;
        int cases = 0;
        try
        {
            foreach (string culture in new[] { "en-US", "fr-FR", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                foreach (string ticket in new[] { null, "", " ", "0", "42", "-1", "1.5",
                    "2,5", "123456", "999999", "9999999", "000009", "abc",
                    "1e4", "1e309", "NaN", "Infinity", "1.234,5", "1,234.5" })
                {
                    string value = ticket;
                    string original = Outcome(delegate { return LegacyAdvance(value); });
                    string extracted = Outcome(delegate {
                        return CheckoutCompletionSql.AdvanceSequence(value,
                            VisualBasicCheckoutCompletionSemantics.Instance);
                    });
                    if (original != extracted)
                        throw new Exception("Sequence SQL parity changed for [" + culture + "] [" +
                            ticket + "]: " + original + " != " + extracted);
                    cases++;
                }
                foreach (string workstation in new[] { null, "", "1", "A B", "O'H", "TABLE_X" })
                {
                    string oldSql = "Delete  from TABLE_" + workstation + "";
                    if (CheckoutCompletionSql.DeleteWorkstation(workstation) != oldSql)
                        throw new Exception("Delete workstation SQL changed");
                    cases++;
                }
            }
            if (CheckoutCompletionSql.AdvanceSequence("42",
                VisualBasicCheckoutCompletionSemantics.Instance) !=
                "UPDATE     TABLE_NUM    SET CL =  000043  ")
                throw new Exception("Known next ticket sequence changed");
            for (int stage = 1; stage <= 2; stage++)
            {
                var port = new TracingSemantics { FailAt = stage };
                Exception caught = null;
                try { CheckoutCompletionSql.AdvanceSequence("42", port); }
                catch (Exception error) { caught = error; }
                if (!Object.ReferenceEquals(caught, port.Failure) || port.Calls != stage)
                    throw new Exception("First exception identity/order changed at stage " + stage);
            }
            Console.WriteLine("PASS checkout completion SQL: " + cases +
                " VB conversion/formatting parity cases and lazy failure ordering");
            return 0;
        }
        finally
        {
            CultureInfo.CurrentCulture = oldCulture;
            CultureInfo.CurrentUICulture = oldUiCulture;
        }
    }
}
