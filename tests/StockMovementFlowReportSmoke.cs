using System;
using System.Collections;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;

internal static class StockMovementFlowReportSmoke
{
    private static int assertions;

    private static void Require(bool condition, string label)
    {
        assertions++;
        if (!condition) throw new Exception("Stock flow report regression: " + label);
    }

    private static void Throws<T>(Action action, string label) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name + ": " + label);
    }

    private sealed class OneShotJournal : IEnumerable<StockMovementAuditEvent>
    {
        private readonly StockMovementAuditEvent[] rows;
        private int enumerations;
        internal OneShotJournal(params StockMovementAuditEvent[] rowsToRead) { rows = rowsToRead; }
        public IEnumerator<StockMovementAuditEvent> GetEnumerator()
        {
            if (++enumerations != 1) throw new InvalidOperationException("Journal enumerated twice.");
            return ((IEnumerable<StockMovementAuditEvent>)rows).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var opening = new List<StockBaselineLine> {
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("B", -3m),
                new StockBaselineLine("a", 0m)
            };
            var journal = new List<StockMovementAuditEvent> {
                new StockMovementAuditEvent("r1", "A", 5.5m),
                new StockMovementAuditEvent("s1", "A", -2m),
                new StockMovementAuditEvent("s2", "A", -1.5m),
                new StockMovementAuditEvent("z1", "A", 0m),
                new StockMovementAuditEvent("r2", "B", 1m),
                new StockMovementAuditEvent("r3", "a", 0.25m)
            };
            var closing = new List<StockBaselineLine> {
                new StockBaselineLine("a", 0.25m),
                new StockBaselineLine("B", -2m),
                new StockBaselineLine("A", 12m)
            };
            var report = StockMovementFlowReportService.Summarize(opening, journal, closing);
            Require(report.IsReconciled, "balanced journal reconciles");
            Require(report.Lines.Count == 3, "all opening articles represented");
            Require(report.Lines[0].ArticleId == "A" && report.Lines[1].ArticleId == "B" &&
                report.Lines[2].ArticleId == "a", "opening order and ordinal IDs preserved");
            Require(report.Lines[0].OpeningQuantity == 10m &&
                report.Lines[0].ReceivedQuantity == 5.5m &&
                report.Lines[0].IssuedQuantity == 3.5m, "gross receipts and issues not netted away");
            Require(report.Lines[0].NetQuantity == 2m &&
                report.Lines[0].ExpectedClosingQuantity == 12m &&
                report.Lines[0].ActualClosingQuantity == 12m, "expected and actual closing quantities");
            Require(report.Lines[0].ReceiptEvents == 1 && report.Lines[0].IssueEvents == 2 &&
                report.Lines[0].ZeroEvents == 1, "per-article event counts");
            Require(report.Lines[1].OpeningQuantity == -3m &&
                report.Lines[1].ExpectedClosingQuantity == -2m, "negative legacy stock preserved");
            Require(report.Lines[2].ReceivedQuantity == 0.25m &&
                report.Lines[2].IssuedQuantity == 0m, "fractional case-distinct article");
            Require(report.TotalReceived == 6.75m && report.TotalIssued == 3.5m &&
                report.TotalNetQuantity == 3.25m, "gross report totals");
            Require(report.KnownMovementEvents == 6, "known movement count includes zero events");
            Require(report.Lines[0].IsMatched && report.Lines[1].IsMatched,
                "matched lines identified");
            Require(report.Audit.UnknownMovementArticleIds.Count == 0 &&
                report.Audit.DriftedArticleIds.Count == 0, "no false audit exceptions");

            opening.Clear(); journal.Clear(); closing.Clear();
            Require(report.Lines[0].ExpectedClosingQuantity == 12m && report.IsReconciled,
                "immutable report detached from caller collections");
            Throws<NotSupportedException>(delegate {
                report.Lines.Add(report.Lines[0]);
            }, "report lines read-only");
            Throws<NotSupportedException>(delegate {
                report.Audit.DriftedArticleIds.Add("X");
            }, "audit exception lists read-only");

            var one = new[] { new StockBaselineLine("A", 10m) };
            var current = new[] { new StockBaselineLine("A", 10m) };
            var empty = new StockMovementAuditEvent[0];
            var zero = StockMovementFlowReportService.Summarize(one, empty, current);
            Require(zero.IsReconciled && zero.Lines[0].ReceivedQuantity == 0m &&
                zero.Lines[0].IssuedQuantity == 0m, "no movement means zero gross flow");
            Require(zero.KnownMovementEvents == 0 && zero.TotalNetQuantity == 0m,
                "empty journal counts zero events");

            var single = StockMovementFlowReportService.Summarize(one,
                new OneShotJournal(new StockMovementAuditEvent("once", "A", 1m)),
                new[] { new StockBaselineLine("A", 11m) });
            Require(single.IsReconciled && single.TotalReceived == 1m,
                "one-shot journal enumerated exactly once");

            var unknown = StockMovementFlowReportService.Summarize(one,
                new[] { new StockMovementAuditEvent("u", "UNKNOWN", 100m) }, current);
            Require(!unknown.IsReconciled &&
                unknown.Audit.UnknownMovementArticleIds.Count == 1, "unknown article fails reconciliation");
            Require(unknown.TotalReceived == 0m && unknown.KnownMovementEvents == 0,
                "unknown movements excluded from known gross totals");

            var drift = StockMovementFlowReportService.Summarize(one,
                new[] { new StockMovementAuditEvent("r", "A", 2m) }, current);
            Require(!drift.IsReconciled && drift.Lines[0].ClosingDifference == -2m,
                "closing drift visible without silently balancing");
            Require(!drift.Lines[0].IsMatched, "drifted line not matched");

            var missing = StockMovementFlowReportService.Summarize(one, empty,
                new StockBaselineLine[0]);
            Require(!missing.IsReconciled && !missing.Lines[0].HasActualClosingQuantity,
                "missing closing row never interpreted as zero");
            Require(missing.Audit.MissingCurrentArticleIds.Count == 1,
                "missing row retained in audit");
            var extra = StockMovementFlowReportService.Summarize(one, empty,
                new[] { new StockBaselineLine("A", 10m), new StockBaselineLine("NEW", 0m) });
            Require(!extra.IsReconciled && extra.Audit.UnexpectedCurrentArticleIds.Count == 1,
                "new zero-stock article fails reconciliation");
            Require(StockMovementFlowReportService.Summarize(
                new StockBaselineLine[0], empty, new StockBaselineLine[0]).IsReconciled,
                "empty consistent snapshots reconcile");

            Throws<ArgumentNullException>(delegate {
                StockMovementFlowReportService.Summarize(null, empty, current);
            }, "null opening");
            Throws<ArgumentNullException>(delegate {
                StockMovementFlowReportService.Summarize(one, null, current);
            }, "null journal");
            Throws<ArgumentNullException>(delegate {
                StockMovementFlowReportService.Summarize(one, empty, null);
            }, "null closing");
            Throws<ArgumentException>(delegate {
                StockMovementFlowReportService.Summarize(one,
                    new StockMovementAuditEvent[] { null }, current);
            }, "invalid movement row");
            Throws<InvalidOperationException>(delegate {
                StockMovementFlowReportService.Summarize(one,
                    new[] { new StockMovementAuditEvent("dup", "A", 1m),
                            new StockMovementAuditEvent("dup", "A", -1m) }, current);
            }, "duplicate movement identity");
            Throws<InvalidOperationException>(delegate {
                StockMovementFlowReportService.Summarize(
                    new[] { new StockBaselineLine("A", 1m), new StockBaselineLine("A", 2m) },
                    empty, current);
            }, "duplicate opening article");
            Throws<InvalidOperationException>(delegate {
                StockMovementFlowReportService.Summarize(one, empty,
                    new[] { new StockBaselineLine("A", 10m), new StockBaselineLine("A", 10m) });
            }, "duplicate closing article");
            var minimum = StockMovementFlowReportService.Summarize(
                new[] { new StockBaselineLine("A", 0m) },
                new[] { new StockMovementAuditEvent("min", "A", decimal.MinValue) },
                new[] { new StockBaselineLine("A", decimal.MinValue) });
            Require(minimum.IsReconciled && minimum.Lines[0].IssuedQuantity == decimal.MaxValue &&
                minimum.Lines[0].NetQuantity == decimal.MinValue,
                "decimal minimum issue magnitude is representable");
            Throws<OverflowException>(delegate {
                StockMovementFlowReportService.Summarize(
                    new[] { new StockBaselineLine("A", 0m), new StockBaselineLine("B", 0m) },
                    new[] { new StockMovementAuditEvent("a", "A", decimal.MaxValue),
                            new StockMovementAuditEvent("b", "B", decimal.MaxValue) },
                    new[] { new StockBaselineLine("A", decimal.MaxValue),
                            new StockBaselineLine("B", decimal.MaxValue) });
            }, "gross totals overflow checked across articles");

            Console.WriteLine("PASS stock movement flow report: " + assertions + " assertions");
            return 0;
        }
        catch (Exception error)
        {
            Console.Error.WriteLine(error);
            return 1;
        }
    }
}
