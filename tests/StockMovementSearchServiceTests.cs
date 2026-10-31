using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;
using LOGICA.Infrastructure.Compatibility;

internal static class StockMovementSearchServiceTests
{
    private sealed class Context : IStockMovementSearchContext
    {
        public string ColumnValue, TextValue, FailAt;
        public bool Dates, FirstExact, SecondExact;
        private int exactReads;
        public readonly List<string> Calls = new List<string>();
        public readonly Exception Failure = new InvalidOperationException("context failure");
        private void Step(string name) { Calls.Add(name); if (name == FailAt) throw Failure; }
        public string Column { get { Step("column"); return ColumnValue; } }
        public string Text { get { Step("text"); return TextValue; } }
        public bool UseDates { get { Step("dateFlag"); return Dates; } }
        public bool Exact { get { Step("exact"); return exactReads++ == 0 ? FirstExact : SecondExact; } }
        public void LoadDateRange() { Step("date"); }
        public void SetDatePrefix() { Step("setPrefix"); }
        public void ClearDatePrefix() { Step("clearPrefix"); }
        public void LoadContains() { Step("contains"); }
        public void LoadExactLike() { Step("exactLoad"); }
        public void BindResults() { Step("bind"); }
    }
    private static int Check(Context context, string expected)
    {
        StockMovementSearchService.Search(context, VisualBasicStockMovementSemantics.Instance);
        if (String.Join(",", context.Calls.ToArray()) != expected)
            throw new Exception("Search lazy order changed: " + String.Join(",", context.Calls.ToArray()));
        return context.Calls.Count;
    }
    public static int Main()
    {
        int assertions = 0;
        try
        {
            assertions += Check(new Context { ColumnValue="DATES", TextValue="unused" }, "column,date,bind");
            assertions += Check(new Context { ColumnValue="ARTICLE", TextValue="" }, "column,text,bind");
            assertions += Check(new Context { ColumnValue=null, TextValue=null }, "column,text,bind");
            assertions += Check(new Context { ColumnValue="ARTICLE", TextValue="x" }, "column,text,dateFlag,clearPrefix,exact,contains,bind");
            assertions += Check(new Context { ColumnValue="ARTICLE", TextValue=" ", Dates=true }, "column,text,dateFlag,setPrefix,exact,contains,bind");
            assertions += Check(new Context { ColumnValue="ARTICLE", TextValue="x", Dates=true, FirstExact=true, SecondExact=true }, "column,text,dateFlag,setPrefix,exact,exact,exactLoad,bind");
            assertions += Check(new Context { ColumnValue="ARTICLE", TextValue="x", FirstExact=true, SecondExact=false }, "column,text,dateFlag,clearPrefix,exact,exact,bind");
            assertions += Check(new Context { ColumnValue="dates", TextValue="x" }, "column,text,dateFlag,clearPrefix,exact,contains,bind");
            string[] normal={"column","text","dateFlag","setPrefix","exact","exact","exactLoad","bind"};
            foreach (string failAt in new[]{"column","text","dateFlag","setPrefix","exact","exactLoad","bind"})
            {
                var context=new Context { ColumnValue="ARTICLE",TextValue="x",Dates=true,FirstExact=true,SecondExact=true,FailAt=failAt };
                Exception caught=null;
                try { StockMovementSearchService.Search(context, VisualBasicStockMovementSemantics.Instance); } catch(Exception error) { caught=error; }
                assertions += 2;
                int count=Array.IndexOf(normal,failAt)+1;
                if(!Object.ReferenceEquals(caught,context.Failure) || context.Calls.Count!=count)
                    throw new Exception("Search failure identity or later work changed");
                for(int index=0;index<count;index++) {
                    assertions++;
                    if(context.Calls[index]!=normal[index])throw new Exception("Search failed-step prefix changed");
                }
            }
            Console.WriteLine("PASS stock movement search service: "+assertions+" assertions; date/text branches, repeated exact read, lazy order and first failure");
            return 0;
        }
        catch(Exception error) {Console.Error.WriteLine(error);return 1;}
    }
}
