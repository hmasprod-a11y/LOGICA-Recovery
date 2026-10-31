using System;
using System.Collections.Generic;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;
using LOGICA.Infrastructure.Checkout;
using LOGICA.Infrastructure.Compatibility;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal static class CheckoutTicketSequenceTests
{
    private sealed class Source : ICheckoutTicketSequenceSource
    {
        internal readonly List<string> Events = new List<string>();
        internal object First, Second;
        internal string FailAt;
        internal readonly Exception Failure = new InvalidOperationException("injected");
        internal int Reads;
        public void Prepare()
        {
            Events.Add("prepare");
            if (FailAt == "prepare") throw Failure;
        }
        public object ExecuteScalar()
        {
            Reads++;
            string stage = "read" + Reads;
            Events.Add(stage);
            if (FailAt == stage) throw Failure;
            return Reads == 1 ? First : Second;
        }
    }

    private static string Legacy(Source source)
    {
        source.Prepare();
        if (source.ExecuteScalar() == DBNull.Value)
            return Conversions.ToString(0);
        return Strings.Format(Conversions.ToDouble(source.ExecuteScalar()), "000000");
    }

    private static string Outcome(Func<string> action)
    {
        try { return "ok:" + action(); }
        catch (Exception error) { return "error:" + error.GetType().FullName + ":" + error.Message; }
    }

    private static void Compare(object first, object second, string failAt, string label)
    {
        var oldSource = new Source { First = first, Second = second, FailAt = failAt };
        var newSource = new Source { First = first, Second = second, FailAt = failAt };
        string oldResult = Outcome(delegate { return Legacy(oldSource); });
        string newResult = Outcome(delegate {
            return CheckoutTicketSequenceService.ReadCurrent(newSource,
                VisualBasicCheckoutTicketSequenceSemantics.Instance);
        });
        string oldEvents = String.Join(",", oldSource.Events.ToArray());
        string newEvents = String.Join(",", newSource.Events.ToArray());
        if (oldResult != newResult || oldEvents != newEvents)
            throw new Exception(label + ": legacy=" + oldResult + " [" + oldEvents +
                "] extracted=" + newResult + " [" + newEvents + "]");
    }

    private static void CheckExceptionIdentity(string stage)
    {
        var source = new Source { First = "1", Second = "42", FailAt = stage };
        Exception caught = null;
        try {
            CheckoutTicketSequenceService.ReadCurrent(source,
                VisualBasicCheckoutTicketSequenceSemantics.Instance);
        }
        catch (Exception error) { caught = error; }
        if (!Object.ReferenceEquals(caught, source.Failure))
            throw new Exception("Exception identity changed at " + stage);
    }

    public static int Main()
    {
        if (CheckoutTicketSequenceSql.SelectCurrent != "Select CL from TABLE_NUM  where ID = 0 ")
            throw new Exception("Original ticket SELECT text changed");
        CultureInfo oldCulture = CultureInfo.CurrentCulture;
        CultureInfo oldUiCulture = CultureInfo.CurrentUICulture;
        int cases = 0;
        try
        {
            object[] firstValues = { DBNull.Value, null, "42", 0, true };
            object[] secondValues = { null, DBNull.Value, "", " ", "42", "000009",
                "-1", "1.5", "2,5", "abc", "1e4", "1e309", "NaN",
                0, 42, 1.5, -1m, true, false };
            foreach (string culture in new[] { "en-US", "fr-FR", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                foreach (object first in firstValues)
                foreach (object second in secondValues)
                {
                    Compare(first, second, null, culture);
                    cases++;
                }
                foreach (string failure in new[] { "prepare", "read1", "read2" })
                {
                    Compare("1", "42", failure, culture + ":" + failure);
                    CheckExceptionIdentity(failure);
                    cases++;
                }
            }
            var zero = new Source { First = DBNull.Value, Second = "999" };
            if (CheckoutTicketSequenceService.ReadCurrent(zero,
                VisualBasicCheckoutTicketSequenceSemantics.Instance) != "0" || zero.Reads != 1)
                throw new Exception("DBNull zero branch must not read twice");
            var twice = new Source { First = "1", Second = "42" };
            if (CheckoutTicketSequenceService.ReadCurrent(twice,
                VisualBasicCheckoutTicketSequenceSemantics.Instance) != "000042" || twice.Reads != 2)
                throw new Exception("Ticket sequence must use second scalar result");
            Console.WriteLine("PASS checkout ticket sequence: " + cases +
                " VB culture/DBNull/exception parity cases, original SQL and two-read semantics");
            return 0;
        }
        finally
        {
            CultureInfo.CurrentCulture = oldCulture;
            CultureInfo.CurrentUICulture = oldUiCulture;
        }
    }
}
