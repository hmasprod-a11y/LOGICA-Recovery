using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Pure adversarial checks. They do not exercise a SQL transaction or write stock.
internal static class ReceiptArithmeticRegressionChecks
{
    [ModuleInitializer]
    internal static void Run()
    {
        int assertions = 0;
        static Dictionary<string, decimal> Q(params (string id, decimal qty)[] lines)
        {
            var result = new Dictionary<string, decimal>(StringComparer.Ordinal);
            foreach (var line in lines) result.Add(line.id, line.qty);
            return result;
        }
        void Equal(decimal actual, decimal expected, string label)
        {
            assertions++;
            if (actual != expected) throw new InvalidOperationException(label);
        }
        void Reject(Action action, string label)
        {
            assertions++;
            try { action(); }
            catch (InvalidOperationException) { return; }
            throw new InvalidOperationException("Expected rejection: " + label);
        }

        // A negative stock snapshot is allowed by LOGICA; purchase quantity capacity
        // depends on ordered/received quantities, never on normalizing stock to zero.
        var order = Q(("A", 10m), ("B", 2m));
        var prior = Q(("A", 9m));
        var proposed = Q(("A", 1m), ("B", 0.125m));
        var remaining = MultiArticleReceiptQuantityPreflight.Remaining(order, prior, proposed);
        Equal(remaining["A"], 0m, "exact A boundary");
        Equal(remaining["B"], 1.875m, "fractional B capacity");

        // A failed batch must leave all caller-supplied quantities untouched.
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(order, prior,
            Q(("B", 0.125m), ("A", 1.0001m))), "second article over capacity");
        Equal(order["A"], 10m, "order unchanged");
        Equal(prior["A"], 9m, "prior unchanged");
        Equal(proposed["A"], 1m, "proposal unchanged");

        // Decimal arithmetic must not wrap, truncate or silently grant capacity.
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            Q(("A", decimal.MaxValue)), Q(), Q(("A", decimal.MaxValue), ("X", 1m))),
            "unknown article even at max decimal capacity");
        Reject(() => MultiArticleReceiptQuantityPreflight.Remaining(
            Q(("A", 1m)), Q(("A", decimal.MaxValue)), Q(("A", 1m))),
            "corrupt prior maximum quantity");

        // A replay cannot alter a previously committed line through decimal scale.
        var committed = new Dictionary<string, IReadOnlyDictionary<string, decimal>>(
            StringComparer.Ordinal) { ["R-1"] = Q(("A", 1.25m), ("B", 0.125m)) };
        assertions++;
        if (ReceiptReplayPreflight.ShouldPost("R-1", Q(("B", 0.1250m), ("A", 1.250m)), committed))
            throw new InvalidOperationException("Equivalent decimal replay must be idempotent");
        Reject(() => ReceiptReplayPreflight.ShouldPost(
            "R-1", Q(("A", 1.25m), ("B", 0.126m)), committed),
            "changed fractional replay");
        Console.WriteLine("PASS: " + assertions +
            " arithmetic and batch-integrity assertions (in memory, no SQL).");
    }
}
