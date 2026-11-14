using System;
using System.Collections.Generic;

// Isolated preflight for BC quantity invariants. No SQL, no posting, no permission grant.
internal static class MultiArticleReceiptQuantityPreflight
{
    internal static IReadOnlyDictionary<string, decimal> Remaining(
        IReadOnlyDictionary<string, decimal> ordered,
        IReadOnlyDictionary<string, decimal> alreadyReceived,
        IReadOnlyDictionary<string, decimal> proposed)
    {
        if (ordered == null || alreadyReceived == null || proposed == null)
            throw new ArgumentNullException("quantity maps");
        if (ordered.Count == 0 || proposed.Count == 0)
            throw new InvalidOperationException("Order and receipt must not be empty.");
        var result = new Dictionary<string, decimal>(StringComparer.Ordinal);
        foreach (var line in ordered)
        {
            if (String.IsNullOrWhiteSpace(line.Key) || line.Value <= 0m)
                throw new InvalidOperationException("Invalid BC line.");
            result.Add(line.Key, line.Value);
        }
        foreach (var line in alreadyReceived)
        {
            decimal quantity;
            if (!result.TryGetValue(line.Key, out quantity) || line.Value < 0m || line.Value > quantity)
                throw new InvalidOperationException("Invalid previously received quantity.");
            result[line.Key] = checked(quantity - line.Value);
        }
        foreach (var line in proposed)
        {
            decimal remaining;
            if (!result.TryGetValue(line.Key, out remaining) || line.Value <= 0m || line.Value > remaining)
                throw new InvalidOperationException("Unknown article, invalid quantity or over-receipt.");
            result[line.Key] = checked(remaining - line.Value);
        }
        return result;
    }
}

internal static class Program
{
    private static int assertions;
    private static Dictionary<string, decimal> Q(params object[] entries)
    {
        var map = new Dictionary<string, decimal>(StringComparer.Ordinal);
        for (int i = 0; i < entries.Length; i += 2)
            map.Add((string)entries[i], (decimal)entries[i + 1]);
        return map;
    }
    private static void Check(bool condition, string message)
    {
        assertions++;
        if (!condition) throw new Exception(message);
    }
    private static void Reject(Action action, string message)
    {
        assertions++;
        try { action(); }
        catch (InvalidOperationException) { return; }
        throw new Exception("Expected rejection: " + message);
    }
    public static int Main()
    {
        var ordered = Q("A", 10m, "B", 8m);
        var first = MultiArticleReceiptQuantityPreflight.Remaining(ordered, Q(), Q("A", 4m, "B", 3m));
        Check(first["A"] == 6m && first["B"] == 5m, "multi-article partial");
        var second = MultiArticleReceiptQuantityPreflight.Remaining(ordered,
            Q("A", 4m, "B", 3m), Q("A", 6m, "B", 5m));
        Check(second["A"] == 0m && second["B"] == 0m, "cumulative exact boundary");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, Q("A", 7m), Q("A", 4m)), "over-receipt");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, Q(), Q("A", 2m, "B", 9m)), "whole batch invalid");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, Q(), Q("A", 0m)), "zero");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, Q(), Q("A", -1m)), "negative");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, Q(), Q("X", 1m)), "unknown article");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, Q("A", 11m), Q("B", 1m)), "corrupt prior receipt");
        Check(MultiArticleReceiptQuantityPreflight.Remaining(Q("A", 1.25m), Q(), Q("A", 0.25m))["A"] == 1m,
            "fractional quantity allowed only after canonical-unit contract");
        Check(first["A"] == 6m && ordered["A"] == 10m, "pure preflight does not mutate inputs");
        Console.WriteLine("PASS: " + assertions + " isolated quantity assertions; no database writes.");
        return 0;
    }
}
