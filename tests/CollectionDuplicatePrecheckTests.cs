using System;
using System.Collections.Generic;
using System.Data;
using LOGICA.ApplicationLayer.Catalogue;

internal static class CollectionDuplicatePrecheckTests
{
    private static DataTable Result(bool match, object article)
    {
        var table = new DataTable(); table.Columns.Add("Article", typeof(object));
        if (match) table.Rows.Add(article);
        return table;
    }
    public static int Main()
    {
        int assertions = 0;
        try
        {
            object[] codes = { new object(), new object(), new object() };
            object article = new object();
            for (int matchAt = -1; matchAt < 3; matchAt++)
            {
                var calls = new List<string>(); int lookupIndex = 0;
                int target = matchAt;
                DataRow found = CollectionDuplicatePrecheck.FindFirst(2,
                    delegate(int index) { calls.Add("read" + index); return codes[index]; },
                    delegate(object code)
                    {
                        int index = lookupIndex++;
                        if (!Object.ReferenceEquals(code, codes[index])) throw new Exception("Raw code object changed");
                        calls.Add("lookup" + index); return Result(index == target, article);
                    },
                    delegate { calls.Add("selectLast"); });
                int queried = matchAt < 0 ? 3 : matchAt + 1, cursor = 0;
                for (int index = 0; index < queried; index++)
                {
                    assertions += 2;
                    if (calls[cursor++] != "read" + index || calls[cursor++] != "lookup" + index)
                        throw new Exception("Read/lookup order changed");
                    if (index != matchAt)
                    {
                        assertions++;
                        if (calls[cursor++] != "selectLast") throw new Exception("No-match selection timing changed");
                    }
                }
                assertions += 2;
                if (cursor != calls.Count || (matchAt < 0 ? found != null : !Object.ReferenceEquals(found["Article"], article)))
                    throw new Exception("First-match return or early stop changed");
            }
            assertions++;
            if (CollectionDuplicatePrecheck.FindFirst(-1,
                delegate(int index) { throw new Exception("empty read"); },
                delegate(object code) { throw new Exception("empty lookup"); },
                delegate { throw new Exception("empty selection"); }) != null)
                throw new Exception("Empty range changed");
            foreach (string failAt in new[] { "read", "lookup", "select" })
            {
                Exception marker = new InvalidOperationException(failAt), caught = null;
                int reads = 0, lookups = 0, selections = 0;
                try
                {
                    CollectionDuplicatePrecheck.FindFirst(2,
                        delegate(int index) { reads++; if (failAt == "read") throw marker; return codes[index]; },
                        delegate(object code) { lookups++; if (failAt == "lookup") throw marker; return Result(false, null); },
                        delegate { selections++; if (failAt == "select") throw marker; });
                }
                catch (Exception error) { caught = error; }
                assertions += 4;
                if (!Object.ReferenceEquals(caught, marker) || reads != 1 ||
                    lookups != (failAt == "read" ? 0 : 1) || selections != (failAt == "select" ? 1 : 0))
                    throw new Exception("Failure propagated differently or later work continued");
            }
            Console.WriteLine("PASS collection duplicate precheck: " + assertions + " assertions; raw objects, first match, empty range, UI timing and failure identity");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
