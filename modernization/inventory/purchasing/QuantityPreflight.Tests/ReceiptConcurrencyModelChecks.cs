using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Deterministic model of the concurrency boundary, NOT a database concurrency test.
// Both workers may pass an optimistic preview; only a transaction-local recheck
// against the latest committed aggregate can decide whether the next one posts.
internal static class ReceiptConcurrencyModelChecks
{
    [ModuleInitializer]
    internal static void Run()
    {
        var ordered = new Dictionary<string, decimal>(StringComparer.Ordinal)
        {
            ["A"] = 10m, ["B"] = 8m
        };
        var initial = new Dictionary<string, decimal>(StringComparer.Ordinal)
        {
            ["A"] = 6m, ["B"] = 1m
        };
        var workerOne = new Dictionary<string, decimal>(StringComparer.Ordinal)
        {
            ["A"] = 3m, ["B"] = 2m
        };
        var workerTwo = new Dictionary<string, decimal>(StringComparer.Ordinal)
        {
            ["A"] = 3m, ["B"] = 2m
        };
        // Two independent optimistic snapshots are both acceptable.
        var preview1 = MultiArticleReceiptQuantityPreflight.Remaining(ordered, initial, workerOne);
        var preview2 = MultiArticleReceiptQuantityPreflight.Remaining(ordered, initial, workerTwo);
        Assert(preview1["A"] == 1m && preview2["A"] == 1m,
            "Both stale snapshots must demonstrate the race");

        // Simulate the serial order of committed receipts after the BC lock.
        var afterOne = new Dictionary<string, decimal>(initial, StringComparer.Ordinal);
        foreach (var line in workerOne)
            afterOne[line.Key] = checked(afterOne[line.Key] + line.Value);
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, afterOne, workerTwo),
            "Second worker must fail when remaining A=1 and it requests 3");
        Assert(afterOne["A"] == 9m && afterOne["B"] == 3m,
            "Rejected second batch must not alter first committed quantities");

        // Reverse lock order yields the same capacity invariant.
        var afterTwo = new Dictionary<string, decimal>(initial, StringComparer.Ordinal);
        foreach (var line in workerTwo)
            afterTwo[line.Key] = checked(afterTwo[line.Key] + line.Value);
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, afterTwo, workerOne),
            "First worker must fail if second worker committed first");

        // A two-line proposal cannot partially consume the good article.
        var invalidBatch = new Dictionary<string, decimal>(StringComparer.Ordinal)
        {
            ["B"] = 1m, ["A"] = 2m
        };
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(ordered, afterOne, invalidBatch),
            "One over-capacity line invalidates entire batch regardless of line order");
        Assert(afterOne["B"] == 3m, "No in-memory partial consumption");
        Console.WriteLine("PASS: 7 deterministic receipt concurrency-model assertions (no SQL locks tested).");
    }

    private static void Assert(bool condition, string reason)
    {
        if (!condition) throw new InvalidOperationException(reason);
    }

    private static void Reject(Action action, string reason)
    {
        try { action(); }
        catch (InvalidOperationException) { return; }
        throw new InvalidOperationException("Expected rejection: " + reason);
    }
}
