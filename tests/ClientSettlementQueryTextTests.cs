using System;
using System.Globalization;
using System.Threading;
using LOGICA.Infrastructure.Clients;
using LOGICA.Infrastructure.Compatibility;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal static class ClientSettlementQueryTextTests
{
    private static int assertions;
    private static string OriginalDateRange(string table, DateTime from, DateTime to)
    {
        return "select * from     TABLE_" + table + "      Where       Dates   between   ' " +
            Strings.Format(from, "yyyy-MM-dd") + " '     And      ' " + Strings.Format(to, "yyyy-MM-dd") +
            " '               order by   ID    desc ";
    }
    private static string OriginalDatePrefix(DateTime from, DateTime to)
    {
        return "        Dates   between   ' " + Strings.Format(from, "yyyy-MM-dd") +
            " '     And      ' " + Strings.Format(to, "yyyy-MM-dd") + " '         AND     ";
    }
    private static string OriginalLike(string table, object prefix, object column, object term, bool exact)
    {
        object sql = string.Concat("select * from     TABLE_" + table, "      Where            ");
        sql = Operators.ConcatenateObject(sql, prefix);
        sql = Operators.ConcatenateObject(sql, "            (");
        sql = Operators.ConcatenateObject(sql, column);
        sql = Operators.ConcatenateObject(sql, exact ? "  like  '" : "  like  '%");
        sql = Operators.ConcatenateObject(sql, term);
        sql = Operators.ConcatenateObject(sql, exact ?
            "'     )                                order by   ID    desc " :
            "%'   )                                order by   ID    desc ");
        return Conversions.ToString(sql);
    }
    private static string OriginalRefresh(string table)
    {
        return "select * from      TABLE_" + table + "                  order by   ID    desc ";
    }
    private static void Compare(Func<string> original, Func<string> extracted)
    {
        string expected = null, actual = null;
        Exception expectedError = null, actualError = null;
        try { expected = original(); } catch (Exception ex) { expectedError = ex; }
        try { actual = extracted(); } catch (Exception ex) { actualError = ex; }
        if (expectedError == null && actualError == null)
        {
            if (!String.Equals(expected, actual, StringComparison.Ordinal))
                throw new Exception("Client SQL changed: " + expected + " / " + actual);
        }
        else if (expectedError == null || actualError == null ||
            expectedError.GetType() != actualError.GetType())
            throw new Exception("Legacy SQL exception behavior changed");
        assertions++;
    }
    public static int Main()
    {
        CultureInfo previous = Thread.CurrentThread.CurrentCulture;
        var semantics = VisualBasicClientSearchSemantics.Instance;
        try
        {
            foreach (string culture in new[] { "fr-FR", "en-US", "ar-MA" })
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                foreach (string table in new[] { "CLIENTS_REGLE", "", "X' OR 1=1", null })
                {
                    string t = table;
                    Compare(delegate { return OriginalRefresh(t); },
                        delegate { return ClientSettlementQueryText.Refresh(t); });
                    foreach (DateTime from in new[] { new DateTime(2026, 1, 2), new DateTime(2024, 2, 29) })
                    {
                        DateTime end = from.AddDays(12);
                        Compare(delegate { return OriginalDateRange(t, from, end); },
                            delegate { return ClientSettlementQueryText.DateRange(t, from, end, semantics); });
                        Compare(delegate { return OriginalDatePrefix(from, end); },
                            delegate { return ClientSettlementQueryText.DatePrefix(from, end, semantics); });
                    }
                    foreach (object prefix in new object[] { "", " Dates > '2026-01-01' AND ", null, DBNull.Value })
                        foreach (object column in new object[] { "CLIENT", null, "DATES" })
                            foreach (object term in new object[] { "O'Hare", "", null, 1.25m, DBNull.Value, "أحمد" })
                            {
                                object p = prefix, c = column, v = term;
                                Compare(delegate { return OriginalLike(t, p, c, v, false); },
                                    delegate { return ClientSettlementQueryText.Contains(t, p, c, v, semantics); });
                                Compare(delegate { return OriginalLike(t, p, c, v, true); },
                                    delegate { return ClientSettlementQueryText.ExactLike(t, p, c, v, semantics); });
                            }
                }
            }
        }
        finally { Thread.CurrentThread.CurrentCulture = previous; }
        Console.WriteLine("PASS: " + assertions + " client settlement SQL legacy-equivalence cases");
        return 0;
    }
}
