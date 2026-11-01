using System;
using LOGICA.ApplicationLayer.Inventory;

internal static class StockCountCoverageSmoke
{
    private static int assertions;
    private static void Require(bool condition, string label)
    {
        assertions++;
        if (!condition) throw new Exception("Stocktake coverage regression: " + label);
    }
    private static void Throws<T>(Action action, string label) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name + ": " + label);
    }
    internal static int Run()
    {
        assertions = 0;
        try
        {
            var baseline = new[] {
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("B", 3m),
                new StockBaselineLine("C", -2m)
            };
            var preview = StockCountCoverageService.Compare(baseline, new[] {
                new StockCountLine("A", 999m, 8.5m),
                new StockCountLine("UNKNOWN", 0m, 7m),
                new StockCountLine("C", 100m, 0m)
            });
            Require(!preview.IsComplete, "partial count cannot be marked complete");
            Require(preview.UncountedArticleIds.Count == 1 &&
                preview.UncountedArticleIds[0] == "B", "uncounted baseline article retained");
            Require(preview.UnknownArticleIds.Count == 1 &&
                preview.UnknownArticleIds[0] == "UNKNOWN", "unknown article reported");
            Require(preview.MatchedVariances.Lines.Count == 2, "unknown excluded from variances");
            Require(preview.MatchedVariances.Lines[0].RecordedQuantity == 10m &&
                preview.MatchedVariances.Lines[0].CountedQuantity == 8.5m,
                "authoritative baseline used instead of stale UI count");
            Require(preview.MatchedVariances.TotalShortage == 1.5m &&
                preview.MatchedVariances.TotalSurplus == 2m, "matched shortage and negative baseline");
            Throws<NotSupportedException>(delegate { preview.UncountedArticleIds.Add("D"); },
                "missing IDs read-only");
            Throws<NotSupportedException>(delegate { preview.UnknownArticleIds.Add("D"); },
                "unknown IDs read-only");

            var complete = StockCountCoverageService.Compare(new[] {
                new StockBaselineLine("a", 1m), new StockBaselineLine("A", 2m)
            }, new[] {
                new StockCountLine("A", 0m, 2m), new StockCountLine("a", 0m, 1m)
            });
            Require(complete.IsComplete, "complete count recognized");
            Require(complete.MatchedVariances.Lines.Count == 2, "case-sensitive identities preserved");
            Require(complete.MatchedVariances.TotalShortage == 0m &&
                complete.MatchedVariances.TotalSurplus == 0m, "exact physical match");
            Require(!StockCountCoverageService.Compare(baseline,
                new StockCountLine[0]).IsComplete, "empty physical count never zeroes baseline");
            Require(StockCountCoverageService.Compare(new StockBaselineLine[0],
                new StockCountLine[0]).IsComplete, "empty catalogue and empty count");
            Throws<ArgumentNullException>(delegate {
                StockCountCoverageService.Compare(null, new StockCountLine[0]);
            }, "null baseline");
            Throws<ArgumentNullException>(delegate {
                StockCountCoverageService.Compare(baseline, null);
            }, "null physical count");
            Throws<ArgumentException>(delegate {
                StockCountCoverageService.Compare(new StockBaselineLine[] { null },
                    new StockCountLine[0]);
            }, "null baseline row");
            Throws<ArgumentException>(delegate {
                StockCountCoverageService.Compare(new[] { new StockBaselineLine(" ", 1m) },
                    new StockCountLine[0]);
            }, "blank baseline identity");
            Throws<InvalidOperationException>(delegate {
                StockCountCoverageService.Compare(new[] {
                    new StockBaselineLine("A", 1m), new StockBaselineLine("A", 2m)
                }, new StockCountLine[0]);
            }, "duplicate baseline identity");
            Throws<ArgumentException>(delegate {
                StockCountCoverageService.Compare(baseline, new StockCountLine[] { null });
            }, "null count row");
            Throws<ArgumentException>(delegate {
                StockCountCoverageService.Compare(baseline, new[] { new StockCountLine("", 0m, 0m) });
            }, "blank count identity");
            Throws<ArgumentOutOfRangeException>(delegate {
                StockCountCoverageService.Compare(baseline,
                    new[] { new StockCountLine("UNKNOWN", 0m, -1m) });
            }, "unknown article cannot bypass negative count validation");
            Throws<InvalidOperationException>(delegate {
                StockCountCoverageService.Compare(baseline, new[] {
                    new StockCountLine("UNKNOWN", 0m, 1m),
                    new StockCountLine("UNKNOWN", 0m, 2m)
                });
            }, "duplicate unknown identity");
            Throws<OverflowException>(delegate {
                StockCountCoverageService.Compare(new[] {
                    new StockBaselineLine("A", decimal.MinValue)
                }, new[] { new StockCountLine("A", 0m, decimal.MaxValue) });
            }, "variance overflow remains fail-closed");
            Console.WriteLine("PASS physical stocktake coverage: " + assertions +
                " assertions; no implicit zeroing, unknowns, case-sensitive identity, read-only snapshots");
            return 0;
        }
        catch (Exception e) { Console.Error.WriteLine(e); return 1; }
    }
}
