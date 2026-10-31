using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Checkout;

internal static class StockValidationServiceTests
{
    private static int assertions;
    private sealed class Spec
    {
        public string Code;
        public bool Found;
        public object Available;
        public object Requested;
        public readonly object Name = new object();
    }
    private sealed class Probe : IStockAvailabilityLookup
    {
        public Spec[] Specs;
        public string FailureAt;
        public readonly Exception Failure = new Exception("controlled validation failure");
        public readonly List<string> Events = new List<string>();
        public void Hit(string stage) { Events.Add(stage); if (stage == FailureAt) throw Failure; }
        public IEnumerable<StockValidationRow> Rows()
        {
            foreach (Spec spec in Specs)
            {
                Hit("read-" + spec.Code);
                yield return new StockValidationRow
                {
                    ArticleCode = spec.Code,
                    ReadQuantity = delegate { Hit("qty-" + spec.Code); return spec.Requested; }
                };
            }
        }
        public StockLookupResult FindByCode(object code)
        {
            Spec found = null;
            foreach (Spec spec in Specs) if (spec.Code == (string)code) { found = spec; break; }
            if (found == null) throw new Exception("Unexpected lookup");
            Hit("lookup-" + found.Code);
            return new StockLookupResult
            {
                Found = found.Found,
                AvailableStock = found.Available,
                ReadArticleName = delegate { Hit("name-" + found.Code); return found.Name; }
            };
        }
    }
    private static void Run(Spec[] specs, string[] order, object expectedName, string failureAt)
    {
        var probe = new Probe { Specs = specs, FailureAt = failureAt };
        StockShortage shortage = null;
        Exception caught = null;
        try { shortage = StockValidationService.FindFirstShortage(probe, probe.Rows(), LOGICA.Infrastructure.Compatibility.VisualBasicCheckoutSemantics.Instance); }
        catch (Exception error) { caught = error; }
        assertions++;
        if (failureAt == null ? caught != null : !object.ReferenceEquals(caught, probe.Failure))
            throw new Exception("Validation exception propagation changed");
        assertions++;
        if (failureAt != null || expectedName == null)
        {
            if (shortage != null) throw new Exception("Unexpected shortage");
        }
        else if (shortage == null || !object.ReferenceEquals(shortage.ArticleName, expectedName))
            throw new Exception("First shortage/raw name changed");
        var expected = new List<string>(order);
        if (failureAt != null) expected = expected.GetRange(0, expected.IndexOf(failureAt) + 1);
        assertions++;
        if (string.Join("|", probe.Events.ToArray()) != string.Join("|", expected.ToArray()))
            throw new Exception("Validation lazy order/short-circuit changed at " + failureAt);
    }
    public static int Main()
    {
        try
        {
            var missing = new Spec { Code = "M", Found = false, Requested = 99m };
            var equal = new Spec { Code = "E", Found = true, Available = 2m, Requested = 2m };
            var surplus = new Spec { Code = "S", Found = true, Available = 3m, Requested = 2m };
            var low = new Spec { Code = "L", Found = true, Available = 1m, Requested = 2m };
            var unread = new Spec { Code = "N", Found = true, Available = 0m, Requested = 2m };
            Run(new Spec[0], new string[0], null, null);
            Run(new[] { missing }, new[] { "read-M", "lookup-M" }, null, null);
            Run(new[] { equal, surplus }, new[] { "read-E", "lookup-E", "qty-E", "read-S", "lookup-S", "qty-S" }, null, null);
            var specs = new[] { missing, equal, low, unread };
            var order = new[] { "read-M", "lookup-M", "read-E", "lookup-E", "qty-E", "read-L", "lookup-L", "qty-L", "name-L" };
            Run(specs, order, low.Name, null);
            foreach (string stage in order) Run(specs, order, null, stage);
            Console.WriteLine("PASS stock validation service: " + assertions + " assertions; missing skip, first shortage, lazy order and exception identity");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
