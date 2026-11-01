using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;

internal static class StockMovementAuditSmoke
{
    private static int assertions;

    private static void Require(bool condition, string label)
    {
        assertions++;
        if (!condition) throw new Exception("Stock movement audit regression: " + label);
    }

    private static void Throws<T>(Action action, string label) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name + ": " + label);
    }

    private static IEnumerable<StockMovementAuditEvent> FailingJournal(Exception failure)
    {
        yield return new StockMovementAuditEvent("first", "A", 1m);
        throw failure;
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var baseline = new List<StockBaselineLine> {
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("B", -5m),
                new StockBaselineLine("a", 0m)
            };
            var movements = new List<StockMovementAuditEvent> {
                new StockMovementAuditEvent("purchase-1", "A", 3m),
                new StockMovementAuditEvent("sale-1", "A", -2m),
                new StockMovementAuditEvent("return-1", "B", 2m),
                new StockMovementAuditEvent("adjust-1", "a", 0.5m)
            };
            var current = new List<StockBaselineLine> {
                new StockBaselineLine("a", 0.5m),
                new StockBaselineLine("B", -3m),
                new StockBaselineLine("A", 11m)
            };
            var good = StockMovementAuditService.Compare(baseline, movements, current);
            Require(good.IsBalanced, "matched stock journal balances");
            Require(good.Lines.Count == 3, "one line per baseline identity");
            Require(good.Lines[0].ArticleId == "A" &&
                good.Lines[1].ArticleId == "B" && good.Lines[2].ArticleId == "a",
                "baseline order and ordinal identity preserved");
            Require(good.Lines[0].BaselineQuantity == 10m &&
                good.Lines[0].MovementDelta == 1m &&
                good.Lines[0].ExpectedQuantity == 11m,
                "purchase and sale movements net correctly");
            Require(good.Lines[1].BaselineQuantity == -5m &&
                good.Lines[1].ExpectedQuantity == -3m,
                "negative legacy stock preserved");
            Require(good.Lines[2].ExpectedQuantity == 0.5m,
                "fractional movements and case-distinct IDs preserved");
            Require(good.Lines[0].HasCurrentStock && good.Lines[0].IsMatched &&
                good.Lines[0].Difference == 0m, "matched line explicitly reported");
            Require(good.UnknownMovementArticleIds.Count == 0 &&
                good.MissingCurrentArticleIds.Count == 0 &&
                good.UnexpectedCurrentArticleIds.Count == 0 &&
                good.DriftedArticleIds.Count == 0, "no false discrepancies");

            var drift = StockMovementAuditService.Compare(baseline, movements,
                new[] {
                    new StockBaselineLine("A", 12m),
                    new StockBaselineLine("B", -4m),
                    new StockBaselineLine("a", 0.5m)
                });
            Require(!drift.IsBalanced, "quantity drift fails reconciliation");
            Require(drift.DriftedArticleIds.Count == 2 &&
                drift.DriftedArticleIds[0] == "A" &&
                drift.DriftedArticleIds[1] == "B", "drift IDs in baseline order");
            Require(drift.Lines[0].Difference == 1m &&
                drift.Lines[1].Difference == -1m,
                "positive and negative drift retained");

            var missing = StockMovementAuditService.Compare(baseline, movements,
                new[] { new StockBaselineLine("A", 11m), new StockBaselineLine("a", 0.5m) });
            Require(!missing.IsBalanced, "missing current stock fails closed");
            Require(missing.MissingCurrentArticleIds.Count == 1 &&
                missing.MissingCurrentArticleIds[0] == "B",
                "missing ID reported, not counted as zero");
            Require(!missing.Lines[1].HasCurrentStock &&
                !missing.Lines[1].IsMatched, "missing current stock has explicit flag");

            var unexpected = StockMovementAuditService.Compare(baseline, movements,
                new[] {
                    new StockBaselineLine("A", 11m),
                    new StockBaselineLine("B", -3m),
                    new StockBaselineLine("a", 0.5m),
                    new StockBaselineLine("NEW", 0m)
                });
            Require(!unexpected.IsBalanced && unexpected.UnexpectedCurrentArticleIds.Count == 1 &&
                unexpected.UnexpectedCurrentArticleIds[0] == "NEW",
                "new zero-stock article cannot be silently ignored");

            var unknown = StockMovementAuditService.Compare(baseline,
                new[] {
                    new StockMovementAuditEvent("x1", "MISSING", 4m),
                    new StockMovementAuditEvent("x2", "MISSING", -1m),
                    new StockMovementAuditEvent("x3", "OTHER", 1m)
                }, baseline);
            Require(!unknown.IsBalanced, "unknown movement article fails audit");
            Require(unknown.UnknownMovementArticleIds.Count == 2 &&
                unknown.UnknownMovementArticleIds[0] == "MISSING" &&
                unknown.UnknownMovementArticleIds[1] == "OTHER",
                "unknown movement IDs deduplicated in first-seen order");
            Require(unknown.Lines[0].ExpectedQuantity == 10m,
                "unknown movement does not affect a known article");
            Require(StockMovementAuditService.Compare(
                new StockBaselineLine[0], new StockMovementAuditEvent[0],
                new StockBaselineLine[0]).IsBalanced, "empty consistent snapshots balance");

            baseline.Clear();
            movements.Clear();
            current.Clear();
            Require(good.IsBalanced && good.Lines[0].ExpectedQuantity == 11m,
                "preview is detached from mutable input collections");
            Throws<NotSupportedException>(delegate { good.Lines.Add(good.Lines[0]); },
                "audit line collection immutable");
            Throws<NotSupportedException>(delegate { drift.DriftedArticleIds.Add("X"); },
                "drift ID collection immutable");
            Throws<NotSupportedException>(delegate { unknown.UnknownMovementArticleIds.Add("X"); },
                "unknown ID collection immutable");

            var one = new[] { new StockBaselineLine("A", 1m) };
            var now = new[] { new StockBaselineLine("A", 1m) };
            var none = new StockMovementAuditEvent[0];
            Throws<ArgumentNullException>(delegate {
                StockMovementAuditService.Compare(null, none, now);
            }, "null baseline");
            Throws<ArgumentNullException>(delegate {
                StockMovementAuditService.Compare(one, null, now);
            }, "null journal");
            Throws<ArgumentNullException>(delegate {
                StockMovementAuditService.Compare(one, none, null);
            }, "null current snapshot");
            Throws<ArgumentException>(delegate {
                StockMovementAuditService.Compare(new StockBaselineLine[] { null }, none, now);
            }, "null baseline row");
            Throws<ArgumentException>(delegate {
                StockMovementAuditService.Compare(new[] { new StockBaselineLine(" ", 0m) },
                    none, now);
            }, "blank baseline ID");
            Throws<InvalidOperationException>(delegate {
                StockMovementAuditService.Compare(new[] {
                    new StockBaselineLine("A", 1m), new StockBaselineLine("A", 2m)
                }, none, now);
            }, "duplicate baseline identity");
            Throws<ArgumentException>(delegate {
                StockMovementAuditService.Compare(one,
                    new StockMovementAuditEvent[] { null }, now);
            }, "null movement");
            Throws<ArgumentException>(delegate {
                StockMovementAuditService.Compare(one,
                    new[] { new StockMovementAuditEvent(" ", "A", 1m) }, now);
            }, "blank movement identity");
            Throws<ArgumentException>(delegate {
                StockMovementAuditService.Compare(one,
                    new[] { new StockMovementAuditEvent("id", " ", 1m) }, now);
            }, "blank movement article identity");
            Throws<InvalidOperationException>(delegate {
                StockMovementAuditService.Compare(one, new[] {
                    new StockMovementAuditEvent("same", "A", 1m),
                    new StockMovementAuditEvent("same", "A", -1m)
                }, now);
            }, "duplicate movement ID rejected, even if deltas cancel");
            Throws<InvalidOperationException>(delegate {
                StockMovementAuditService.Compare(one, new[] {
                    new StockMovementAuditEvent("same", "A", 1m),
                    new StockMovementAuditEvent("same", "UNKNOWN", 1m)
                }, now);
            }, "duplicate movement ID across articles rejected");
            Require(StockMovementAuditService.Compare(one, new[] {
                new StockMovementAuditEvent("x", "A", 1m),
                new StockMovementAuditEvent("X", "A", -1m)
            }, now).IsBalanced, "movement IDs use ordinal comparison");
            Throws<ArgumentException>(delegate {
                StockMovementAuditService.Compare(one, none,
                    new StockBaselineLine[] { null });
            }, "null current row");
            Throws<ArgumentException>(delegate {
                StockMovementAuditService.Compare(one, none,
                    new[] { new StockBaselineLine("", 1m) });
            }, "blank current ID");
            Throws<InvalidOperationException>(delegate {
                StockMovementAuditService.Compare(one, none, new[] {
                    new StockBaselineLine("A", 1m), new StockBaselineLine("A", 1m)
                });
            }, "duplicate current identity");
            Throws<OverflowException>(delegate {
                StockMovementAuditService.Compare(
                    new[] { new StockBaselineLine("A", decimal.MaxValue) },
                    new[] { new StockMovementAuditEvent("x", "A", 1m) }, now);
            }, "baseline plus movement overflow");
            Throws<OverflowException>(delegate {
                StockMovementAuditService.Compare(one, new[] {
                    new StockMovementAuditEvent("x", "A", decimal.MaxValue),
                    new StockMovementAuditEvent("y", "A", 1m)
                }, now);
            }, "movement aggregation overflow");
            Throws<OverflowException>(delegate {
                StockMovementAuditService.Compare(
                    new[] { new StockBaselineLine("A", decimal.MinValue) },
                    none, new[] { new StockBaselineLine("A", decimal.MaxValue) });
            }, "drift subtraction overflow");
            var failure = new InvalidOperationException("journal stream failed");
            Exception observed = null;
            try {
                StockMovementAuditService.Compare(one, FailingJournal(failure), now);
            } catch (Exception e) { observed = e; }
            Require(Object.ReferenceEquals(observed, failure),
                "journal iterator exception propagated unchanged");

            Console.WriteLine("PASS stock movement audit: " + assertions + " assertions");
            return 0;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.ToString());
            return 1;
        }
    }
}
