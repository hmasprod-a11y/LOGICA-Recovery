using System;
using System.Globalization;
using LOGICA.Infrastructure.Inventory;
using LOGICA.Infrastructure.Compatibility;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal static class StockMovementQueryTextTests
{
    private static string LegacyContains(string table, object prefix, object column, object term)
    {
        return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(
            Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(
            Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + table,
            "      Where            "), prefix), "            ("), column), "  like  '%"),
            term), "%'   )                                order by   ID    desc "));
    }

    private static string LegacyExact(string table, object prefix, object column, object term)
    {
        return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(
            Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(
            Operators.ConcatenateObject(string.Concat("select * from     TABLE_" + table,
            "      Where            "), prefix), "            ("), column), "  like  '"),
            term), "'     )                                order by   ID    desc "));
    }

    private static string LegacyRange(string table, DateTime from, DateTime to)
    {
        return "select * from     TABLE_" + table + "      Where       Dates   between   ' " +
            Strings.Format(from, "yyyy-MM-dd") + " '     And      ' " +
            Strings.Format(to, "yyyy-MM-dd") + " '               order by   ID    desc ";
    }

    private static string LegacyPrefix(DateTime from, DateTime to)
    {
        return "        Dates   between   ' " + Strings.Format(from, "yyyy-MM-dd") +
            " '     And      ' " + Strings.Format(to, "yyyy-MM-dd") + " '         AND     ";
    }

    private static string Outcome(Func<string> action)
    {
        try { return "ok:" + action(); }
        catch (Exception error) { return "error:" + error.GetType().FullName; }
    }

    private static void Compare(string label, Func<string> original, Func<string> extracted)
    {
        string oldResult = Outcome(original);
        string newResult = Outcome(extracted);
        if (oldResult != newResult)
            throw new Exception(label + " SQL or exception mismatch: [" + oldResult + "] vs [" + newResult + "]");
    }

    private sealed class TracingSemantics : LOGICA.Domain.ILegacyStockMovementQuerySemantics
    {
        internal int Calls;
        internal int FailAt;
        internal readonly Exception Failure = new InvalidOperationException("injected");
        private void Step() { Calls++; if (Calls == FailAt) throw Failure; }
        public string FormatDate(DateTime value) { Step(); return "2000-01-01"; }
        public object Concat(object left, object right) { Step(); return String.Concat(left, right); }
        public string ToText(object value) { Step(); return Convert.ToString(value); }
    }

    private static void VerifyLazyFailure()
    {
        for (int stage = 1; stage <= 7; stage++)
        {
            var port = new TracingSemantics { FailAt = stage };
            Exception caught = null;
            try { StockMovementQueryText.Contains("A", "", "CODE", "x", port); }
            catch (Exception error) { caught = error; }
            if (!Object.ReferenceEquals(caught, port.Failure) || port.Calls != stage)
                throw new Exception("Contains lost lazy first-failure ordering at stage " + stage);
            port = new TracingSemantics { FailAt = stage };
            caught = null;
            try { StockMovementQueryText.ExactLike("A", "", "CODE", "x", port); }
            catch (Exception error) { caught = error; }
            if (!Object.ReferenceEquals(caught, port.Failure) || port.Calls != stage)
                throw new Exception("ExactLike lost lazy first-failure ordering at stage " + stage);
        }
        for (int stage = 1; stage <= 2; stage++)
        {
            var port = new TracingSemantics { FailAt = stage };
            Exception caught = null;
            try { StockMovementQueryText.DateRange("A", DateTime.Today, DateTime.Today, port); }
            catch (Exception error) { caught = error; }
            if (!Object.ReferenceEquals(caught, port.Failure) || port.Calls != stage)
                throw new Exception("DateRange date formatting order changed");
        }
    }

    public static int Main()
    {
        var originalCulture = CultureInfo.CurrentCulture;
        var originalUiCulture = CultureInfo.CurrentUICulture;
        int cases = 0;
        try
        {
            foreach (string culture in new[] { "en-US", "fr-FR", "tr-TR" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                foreach (string table in new[] { null, "", "STOCK", "MOUVEMENTS", "A B", "O'H" })
                {
                    Compare("refresh", delegate { return "select * from      TABLE_" + table +
                        "                  order by   ID    desc "; },
                        delegate { return StockMovementQueryText.Refresh(table); });
                    cases++;
                    foreach (object prefix in new object[] { null, "", " AND ", 1, false, DBNull.Value })
                    foreach (object column in new object[] { null, "DATES", "CODE", 0, true })
                    foreach (object term in new object[] { null, "", "O'H", "é", 3.5, false, DBNull.Value })
                    {
                        object p = prefix, c = column, t = term;
                        string tab = table;
                        Compare("contains " + culture, delegate { return LegacyContains(tab, p, c, t); },
                            delegate { return StockMovementQueryText.Contains(tab, p, c, t,
                                VisualBasicStockMovementQuerySemantics.Instance); });
                        Compare("exact " + culture, delegate { return LegacyExact(tab, p, c, t); },
                            delegate { return StockMovementQueryText.ExactLike(tab, p, c, t,
                                VisualBasicStockMovementQuerySemantics.Instance); });
                        cases += 2;
                    }
                    foreach (DateTime from in new[] { new DateTime(2020, 2, 29), new DateTime(2026, 10, 31) })
                    {
                        DateTime to = new DateTime(2027, 1, 2);
                        string tab = table;
                        Compare("date range", delegate { return LegacyRange(tab, from, to); },
                            delegate { return StockMovementQueryText.DateRange(tab, from, to,
                                VisualBasicStockMovementQuerySemantics.Instance); });
                        Compare("date prefix", delegate { return LegacyPrefix(from, to); },
                            delegate { return StockMovementQueryText.DatePrefix(from, to,
                                VisualBasicStockMovementQuerySemantics.Instance); });
                        cases += 2;
                    }
                }
            }
            VerifyLazyFailure();
            Console.WriteLine("PASS inventory SQL text: " + cases +
                " original VB query parity cases across three cultures, plus first-failure ordering");
            return 0;
        }
        finally
        {
            CultureInfo.CurrentCulture = originalCulture;
            CultureInfo.CurrentUICulture = originalUiCulture;
        }
    }
}
