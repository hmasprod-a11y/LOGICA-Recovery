using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Independent adversarial tests of the existing read-only preflight.
// Does not grant a BC capability, mutate stock, or claim database concurrency.
internal static class ReceiptBoundaryRegressionChecks
{
    [ModuleInitializer]
    internal static void Run()
    {
        var order = Q(("SKU-A", 10m), ("sku-a", 5m));
        var remaining = MultiArticleReceiptQuantityPreflight.Remaining(
            order, Q(("SKU-A", 3m)), Q(("sku-a", 2m)));
        Assert(remaining["SKU-A"] == 7m && remaining["sku-a"] == 3m,
            "Article identity must be ordinal and case sensitive");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            order, Q(("UNKNOWN", 1m)), Q(("SKU-A", 1m))),
            "Unexpected previously received article");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            order, Q(("SKU-A", -1m)), Q(("sku-a", 1m))),
            "Negative prior receipt");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            order, Q(("SKU-A", 10.01m)), Q(("sku-a", 1m))),
            "Previously received quantity above order");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            order, Q(), Q(("SKU-A", 10.01m), ("sku-a", 1m))),
            "One over-capacity article rejects the entire multi-article proposal");
        Assert(order["SKU-A"] == 10m && order["sku-a"] == 5m,
            "Rejected preflights cannot mutate ordered input");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            Q(("SKU-A", 0m)), Q(), Q(("SKU-A", 1m))),
            "Zero ordered quantity");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            Q(("SKU-A", -1m)), Q(), Q(("SKU-A", 1m))),
            "Negative ordered quantity");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            order, Q(), Q()),
            "Empty receipt");
        var units = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["SKU-A"] = "piece", ["sku-a"] = "piece"
        };
        Reject(() => ReceiptUnitPreflight.Remaining(
            order, Q(), Q(("SKU-A", 1m)),
            units, new Dictionary<string, string>(StringComparer.Ordinal)
            { ["SKU-A"] = "PIECE" }),
            "No implicit unit normalization");
        var committed = new Dictionary<string, IReadOnlyDictionary<string, decimal>>(
            StringComparer.Ordinal)
        {
            ["R-A"] = Q(("SKU-A", 1m))
        };
        Assert(ReceiptReplayPreflight.ShouldPost("r-a", Q(("SKU-A", 1m)), committed),
            "Receipt IDs are case-sensitive; durable global uniqueness is a DB concern");
        Reject(() => ReceiptReplayPreflight.ShouldPost(
            "R-A", Q(("sku-a", 1m)), committed),
            "Replay cannot swap case-distinct article identities");
        Console.WriteLine("PASS: 12 adversarial receipt boundary assertions (pure model only).");
    }

    private static Dictionary<string, decimal> Q(params (string id, decimal quantity)[] lines)
    {
        var map = new Dictionary<string, decimal>(StringComparer.Ordinal);
        foreach (var line in lines) map.Add(line.id, line.quantity);
        return map;
    }

    private static void Assert(bool condition, string message)
    {
        if (!condition) throw new InvalidOperationException(message);
    }

    private static void Reject(Action action, string message)
    {
        try { action(); }
        catch (InvalidOperationException) { return; }
        throw new InvalidOperationException("Expected rejection: " + message);
    }
}
