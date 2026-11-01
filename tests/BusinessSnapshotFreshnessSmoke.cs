using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;
using LOGICA.ApplicationLayer.Purchasing;

internal static class BusinessSnapshotFreshnessSmoke
{
    private static int assertions;

    private static void Require(bool condition, string label)
    {
        assertions++;
        if (!condition) throw new Exception("Business snapshot regression: " + label);
    }

    private static void Throws<T>(Action action, string label) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name + ": " + label);
    }

    private static IEnumerable<StockBaselineLine> BrokenStock(Exception failure)
    {
        yield return new StockBaselineLine("A", 10m);
        throw failure;
    }

    private static IEnumerable<ReceiptSupplierSnapshotLine> BrokenSuppliers(Exception failure)
    {
        yield return new ReceiptSupplierSnapshotLine("SUP-1");
        throw failure;
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var baseline = new[] {
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("B", 0m),
                new StockBaselineLine("C", -2m)
            };
            var coverage = StockCountCoverageService.Compare(baseline, new[] {
                new StockCountLine("C", 99m, 1m),
                new StockCountLine("A", 99m, 8m),
                new StockCountLine("B", 99m, 0m)
            });
            Require(coverage.IsComplete, "physical count complete");
            var plan = StockCountAdjustmentProposalService.Create(coverage);
            Require(plan.Adjustments.Count == 2, "zero-delta B omitted from proposals");

            var current = new List<StockBaselineLine> {
                new StockBaselineLine("B", 0m),
                new StockBaselineLine("C", -2m),
                new StockBaselineLine("A", 10m)
            };
            var fresh = StockCountFreshnessService.Compare(coverage, current);
            Require(fresh.IsFresh, "unchanged stock despite reordered rows");
            Require(fresh.ChangedQuantityArticleIds.Count == 0, "no changed quantities");
            Require(fresh.MissingArticleIds.Count == 0, "no missing identities");
            Require(fresh.AddedArticleIds.Count == 0, "no newly added identities");

            var changed = StockCountFreshnessService.Compare(coverage, new[] {
                new StockBaselineLine("A", 11m),
                new StockBaselineLine("B", 1m),
                new StockBaselineLine("C", -1m)
            });
            Require(!changed.IsFresh, "any changed quantity invalidates snapshot");
            Require(changed.ChangedQuantityArticleIds.Count == 3, "all changes detected");
            Require(changed.ChangedQuantityArticleIds[0] == "C" &&
                changed.ChangedQuantityArticleIds[1] == "A" &&
                changed.ChangedQuantityArticleIds[2] == "B",
                "changed IDs retain physical count order");
            Require(changed.ChangedQuantityArticleIds.Contains("B"),
                "zero-delta article B still protected against concurrent stock change");

            var structural = StockCountFreshnessService.Compare(coverage, new[] {
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("C", -2m),
                new StockBaselineLine("NEW", 5m)
            });
            Require(!structural.IsFresh, "missing and added stock identities invalidate snapshot");
            Require(structural.MissingArticleIds.Count == 1 &&
                structural.MissingArticleIds[0] == "B", "deleted article detected");
            Require(structural.AddedArticleIds.Count == 1 &&
                structural.AddedArticleIds[0] == "NEW", "new article detected");
            Require(structural.ChangedQuantityArticleIds.Count == 0,
                "unchanged remaining quantities not marked stale");

            var ordinal = StockCountFreshnessService.Compare(coverage, new[] {
                new StockBaselineLine("a", 10m),
                new StockBaselineLine("B", 0m),
                new StockBaselineLine("C", -2m)
            });
            Require(ordinal.MissingArticleIds.Count == 1 &&
                ordinal.MissingArticleIds[0] == "A", "case-sensitive original ID missing");
            Require(ordinal.AddedArticleIds.Count == 1 &&
                ordinal.AddedArticleIds[0] == "a", "case-sensitive new ID detected");

            current.Clear();
            Require(fresh.IsFresh && fresh.MissingArticleIds.Count == 0,
                "result detached from caller collection");
            Throws<NotSupportedException>(delegate {
                structural.AddedArticleIds.Add("X");
            }, "added IDs read-only");
            Throws<NotSupportedException>(delegate {
                structural.MissingArticleIds.Add("X");
            }, "missing IDs read-only");
            Throws<NotSupportedException>(delegate {
                changed.ChangedQuantityArticleIds.Add("X");
            }, "changed IDs read-only");

            var empty = StockCountCoverageService.Compare(new StockBaselineLine[0],
                new StockCountLine[0]);
            Require(StockCountFreshnessService.Compare(empty,
                new StockBaselineLine[0]).IsFresh, "empty-to-empty count stays fresh");
            Require(!StockCountFreshnessService.Compare(empty, new[] {
                new StockBaselineLine("NEW", 0m)
            }).IsFresh, "even zero-stock newly added article invalidates empty count");
            Require(StockCountFreshnessService.Compare(coverage, new[] {
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("B", 0m),
                new StockBaselineLine("C", -2m)
            }).IsFresh, "negative legacy stock preserved without normalization");
            Throws<ArgumentNullException>(delegate {
                StockCountFreshnessService.Compare(null, current);
            }, "null completed count");
            Throws<ArgumentNullException>(delegate {
                StockCountFreshnessService.Compare(coverage, null);
            }, "null current stock");
            Throws<InvalidOperationException>(delegate {
                StockCountFreshnessService.Compare(StockCountCoverageService.Compare(
                    baseline, new[] { new StockCountLine("A", 0m, 8m) }), current);
            }, "partial count cannot be freshness-approved");
            Throws<ArgumentException>(delegate {
                StockCountFreshnessService.Compare(coverage, new StockBaselineLine[] { null });
            }, "null current stock row");
            Throws<ArgumentException>(delegate {
                StockCountFreshnessService.Compare(coverage, new[] {
                    new StockBaselineLine(" ", 0m)
                });
            }, "blank current article ID");
            Throws<InvalidOperationException>(delegate {
                StockCountFreshnessService.Compare(coverage, new[] {
                    new StockBaselineLine("A", 10m),
                    new StockBaselineLine("A", 10m)
                });
            }, "duplicate current stock identity fails closed");
            var stockFailure = new InvalidOperationException("stock iterator failure");
            Exception observed = null;
            try { StockCountFreshnessService.Compare(coverage, BrokenStock(stockFailure)); }
            catch (Exception e) { observed = e; }
            Require(Object.ReferenceEquals(observed, stockFailure),
                "current stock iterator exception propagated unchanged");
            Require(!StockCountFreshnessService.Compare(coverage, new[] {
                new StockBaselineLine("A", decimal.MaxValue),
                new StockBaselineLine("B", 0m),
                new StockBaselineLine("C", -2m)
            }).IsFresh, "decimal extremes compared without arithmetic overflow");

            var receipt = PurchaseReceiptPreviewService.Build("SUP-1", new[] {
                new PurchaseReceiptLine("A", "DUPLICATE-BARCODE", 1.5m, 0.125m),
                new PurchaseReceiptLine("B", "DUPLICATE-BARCODE", 2m, 1m)
            });
            var suppliers = new List<ReceiptSupplierSnapshotLine> {
                new ReceiptSupplierSnapshotLine("SUP-2"),
                new ReceiptSupplierSnapshotLine("SUP-1"),
                new ReceiptSupplierSnapshotLine("sup-1")
            };
            var supplierValid = PurchaseReceiptSupplierValidationService.Compare(receipt, suppliers);
            Require(supplierValid.IsKnown, "exact supplier ID known");
            Require(supplierValid.SupplierId == "SUP-1", "original supplier identity retained");
            Require(receipt.TotalQuantity == 3.5m && receipt.TotalCost == 2.1875m,
                "supplier validation never changes receipt quantity or cost");
            suppliers.Clear();
            Require(supplierValid.IsKnown, "supplier result detached from caller list");
            Require(!PurchaseReceiptSupplierValidationService.Compare(receipt,
                new ReceiptSupplierSnapshotLine[0]).IsKnown, "unknown supplier not accepted");
            Require(!PurchaseReceiptSupplierValidationService.Compare(receipt, new[] {
                new ReceiptSupplierSnapshotLine("sup-1")
            }).IsKnown, "supplier ID case-sensitive");
            Require(PurchaseReceiptSupplierValidationService.Compare(receipt, new[] {
                new ReceiptSupplierSnapshotLine("SUP-1"),
                new ReceiptSupplierSnapshotLine("SUP-2")
            }).IsKnown, "unique unrelated supplier permitted");
            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptSupplierValidationService.Compare(null, suppliers);
            }, "null receipt");
            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptSupplierValidationService.Compare(receipt, null);
            }, "null supplier snapshot");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptSupplierValidationService.Compare(receipt,
                    new ReceiptSupplierSnapshotLine[] { null });
            }, "null supplier row");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptSupplierValidationService.Compare(receipt, new[] {
                    new ReceiptSupplierSnapshotLine("")
                });
            }, "blank supplier identity");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptSupplierValidationService.Compare(receipt, new[] {
                    new ReceiptSupplierSnapshotLine("SUP-1"),
                    new ReceiptSupplierSnapshotLine("SUP-1")
                });
            }, "duplicate supplier ID fails closed");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptSupplierValidationService.Compare(receipt, new[] {
                    new ReceiptSupplierSnapshotLine("SUP-2"),
                    new ReceiptSupplierSnapshotLine("SUP-2")
                });
            }, "duplicate unrelated supplier ID also fails closed");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptSupplierValidationService.Compare(
                    new PurchaseReceiptPreview(" ", new List<PurchaseReceiptArticleTotal>(),
                        0m, 0m), new ReceiptSupplierSnapshotLine[0]);
            }, "invalid receipt supplier identity rejected");
            var supplierFailure = new InvalidOperationException("supplier iterator failure");
            observed = null;
            try { PurchaseReceiptSupplierValidationService.Compare(receipt,
                BrokenSuppliers(supplierFailure)); }
            catch (Exception e) { observed = e; }
            Require(Object.ReferenceEquals(observed, supplierFailure),
                "supplier iterator failure propagated unchanged");

            Console.WriteLine("PASS business stock freshness and supplier identity: " + assertions +
                " assertions; stale zero-delta rows, additions, deletions, duplicates, no writes");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
