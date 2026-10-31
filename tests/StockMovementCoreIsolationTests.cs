using System;
using System.Collections.Generic;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Inventory;

internal static class StockMovementCoreIsolationTests
{
    private sealed class Semantics : ILegacyStockMovementSemantics
    {
        public readonly List<string> Calls = new List<string>();
        public int FailAt;
        public readonly Exception Failure = new InvalidOperationException("comparison");
        public bool EqualsText(string left, string right)
        {
            Calls.Add(right);
            if (FailAt == Calls.Count) throw Failure;
            return String.Equals(left ?? "", right ?? "", StringComparison.Ordinal);
        }
    }

    private sealed class Context : IStockMovementSearchContext
    {
        public readonly List<string> Calls = new List<string>();
        public string ColumnValue = "ARTICLE", TextValue = "x";
        public bool Dates, FirstExact, SecondExact;
        private int exactReads;
        public string Column { get { Calls.Add("column"); return ColumnValue; } }
        public string Text { get { Calls.Add("text"); return TextValue; } }
        public bool UseDates { get { Calls.Add("dateFlag"); return Dates; } }
        public bool Exact { get { Calls.Add("exact"); return exactReads++ == 0 ? FirstExact : SecondExact; } }
        public void LoadDateRange() { Calls.Add("date"); }
        public void SetDatePrefix() { Calls.Add("setPrefix"); }
        public void ClearDatePrefix() { Calls.Add("clearPrefix"); }
        public void LoadContains() { Calls.Add("contains"); }
        public void LoadExactLike() { Calls.Add("exactLoad"); }
        public void BindResults() { Calls.Add("bind"); }
    }

    private static void Check(Context c, string expected, string comparisons)
    {
        var s = new Semantics();
        StockMovementSearchService.Search(c, s);
        if (String.Join(",", c.Calls.ToArray()) != expected)
            throw new Exception("Inventory read/effect order changed: " + String.Join(",", c.Calls.ToArray()));
        if (String.Join(",", s.Calls.ToArray()) != comparisons)
            throw new Exception("Inventory comparison order changed: " + String.Join(",", s.Calls.ToArray()));
    }

    public static int Main()
    {
        Check(new Context { ColumnValue = "DATES" }, "column,date,bind", "DATES");
        Check(new Context { TextValue = "" }, "column,text,bind", "DATES,");
        Check(new Context { TextValue = null }, "column,text,bind", "DATES,");
        Check(new Context(), "column,text,dateFlag,clearPrefix,exact,contains,bind", "DATES,");
        Check(new Context { Dates = true, FirstExact = true, SecondExact = true },
            "column,text,dateFlag,setPrefix,exact,exact,exactLoad,bind", "DATES,");
        Check(new Context { FirstExact = true, SecondExact = false },
            "column,text,dateFlag,clearPrefix,exact,exact,bind", "DATES,");
        for (int fail = 1; fail <= 2; fail++)
        {
            var c = new Context();
            var s = new Semantics { FailAt = fail };
            Exception caught = null;
            try { StockMovementSearchService.Search(c, s); } catch (Exception ex) { caught = ex; }
            if (!Object.ReferenceEquals(caught, s.Failure) || c.Calls.Count != fail)
                throw new Exception("Comparison failure must stop before later effects");
        }
        Console.WriteLine("PASS isolated stock movement search core without Visual Basic, UI or database");
        return 0;
    }
}
