using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;
using LOGICA.ApplicationLayer.Purchasing;

internal static class BusinessRevalidationSmoke
{
    private static int assertions;

    private static void Require(bool condition, string label)
    {
        assertions++;
        if (!condition) throw new Exception("Business revalidation regression: " + label);
    }

    private static void Throws<T>(Action action, string label) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name + ": " + label);
    }

    private static PurchaseReceiptStockProjection Forged(PurchaseReceiptStockProjectionLine line,
        decimal quantity, decimal cost)
    {
        var article = new PurchaseReceiptArticleTotal("A", "SAME", quantity, cost);
        var receipt = new PurchaseReceiptPreview("SUP", new[] { article }, quantity, cost);
        return new PurchaseReceiptStockProjection(receipt, new[] { line });
    }

    private static IEnumerable<StockBaselineLine> BrokenStock(Exception failure)
    {
        yield return new StockBaselineLine("A", 10m);
        throw failure;
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var receipt = PurchaseReceiptPreviewService.Build("SUP", new[] {
                new PurchaseReceiptLine("A", "SAME", 1.5m, 0.125m),
                new PurchaseReceiptLine("B", "SAME", 2m, 3m),
                new PurchaseReceiptLine("C", null, 1m, 0m)
            });
            var catalogue = new[] {
                new ReceiptCatalogueArticle("B", "SAME"),
                new ReceiptCatalogueArticle("A", "SAME"),
                new ReceiptCatalogueArticle("C", null),
                new ReceiptCatalogueArticle("UNRELATED", "SAME")
            };
            var suppliers = new[] {
                new ReceiptSupplierSnapshotLine("OTHER"),
                new ReceiptSupplierSnapshotLine("SUP")
            };
            var stock = new List<StockBaselineLine> {
                new StockBaselineLine("C", 0m),
                new StockBaselineLine("B", -4m),
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("UNRELATED", 900m)
            };
            var projection = PurchaseReceiptStockProjectionService.Build(receipt, catalogue, stock);
            var fresh = PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers, stock);
            Require(fresh.IsFresh, "unchanged supplier, catalogue and stock");
            Require(!fresh.SupplierMissing, "supplier still known");
            Require(fresh.MissingCatalogueArticleIds.Count == 0, "no missing catalogue");
            Require(fresh.ChangedBarcodeArticleIds.Count == 0, "no barcode changes");
            Require(fresh.MissingStockArticleIds.Count == 0, "no missing stock");
            Require(fresh.ChangedStockArticleIds.Count == 0, "no changed stock");
            Require(projection.Lines[0].RecordedQuantity == 10m &&
                projection.Lines[1].RecordedQuantity == -4m,
                "negative legacy stock and duplicate barcode variants remain distinct");
            Require(projection.TotalReceiptCost == 6.1875m,
                "receipt cost remains unrounded");

            var stale = PurchaseReceiptFreshnessService.Compare(projection, new[] {
                new ReceiptCatalogueArticle("A", "CHANGED"),
                new ReceiptCatalogueArticle("B", "SAME"),
                new ReceiptCatalogueArticle("UNRELATED", "SAME")
            }, new[] { new ReceiptSupplierSnapshotLine("OTHER") }, new[] {
                new StockBaselineLine("A", 11m),
                new StockBaselineLine("C", 0m),
                new StockBaselineLine("UNRELATED", 999m)
            });
            Require(!stale.IsFresh, "stale receipt fails closed");
            Require(stale.SupplierMissing, "supplier removed");
            Require(stale.MissingCatalogueArticleIds.Count == 1 &&
                stale.MissingCatalogueArticleIds[0] == "C", "missing catalogue C");
            Require(stale.ChangedBarcodeArticleIds.Count == 1 &&
                stale.ChangedBarcodeArticleIds[0] == "A", "changed barcode A");
            Require(stale.MissingStockArticleIds.Count == 1 &&
                stale.MissingStockArticleIds[0] == "B", "missing stock B");
            Require(stale.ChangedStockArticleIds.Count == 1 &&
                stale.ChangedStockArticleIds[0] == "A", "changed stock A");
            Require(projection.Lines[0].ProjectedQuantity == 11.5m,
                "stale comparison does not mutate projected quantity");
            Throws<NotSupportedException>(delegate {
                stale.ChangedStockArticleIds.Add("X");
            }, "changed stock result immutable");
            Throws<NotSupportedException>(delegate {
                stale.MissingCatalogueArticleIds.Add("X");
            }, "missing catalogue result immutable");

            var unrelated = PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers,
                new[] {
                    new StockBaselineLine("A", 10m),
                    new StockBaselineLine("B", -4m),
                    new StockBaselineLine("C", 0m),
                    new StockBaselineLine("NEW", 1000m)
                });
            Require(unrelated.IsFresh, "unrelated stock changes do not stale received IDs");
            Require(PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers,
                new[] {
                    new StockBaselineLine("A", 10m),
                    new StockBaselineLine("B", -4m),
                    new StockBaselineLine("C", 0m)
                }).IsFresh, "unrelated deleted stock does not stale receipt");
            Require(!PurchaseReceiptFreshnessService.Compare(projection, new[] {
                new ReceiptCatalogueArticle("A", "SAME"),
                new ReceiptCatalogueArticle("B", "SAME"),
                new ReceiptCatalogueArticle("C", "")
            }, suppliers, stock).IsFresh, "null and empty barcodes differ");
            Require(!PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers,
                new[] {
                    new StockBaselineLine("A", decimal.MaxValue),
                    new StockBaselineLine("B", -4m),
                    new StockBaselineLine("C", 0m)
                }).IsFresh, "extreme stock values compared without overflow");
            stock.Clear();
            Require(fresh.IsFresh && stale.ChangedStockArticleIds.Count == 1,
                "results detached from caller collections");

            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptFreshnessService.Compare(null, catalogue, suppliers, stock);
            }, "null projection");
            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptFreshnessService.Compare(projection, null, suppliers, stock);
            }, "null catalogue");
            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptFreshnessService.Compare(projection, catalogue, null, stock);
            }, "null suppliers");
            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers, null);
            }, "null stock");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptFreshnessService.Compare(projection, new[] {
                    new ReceiptCatalogueArticle("A", "SAME"),
                    new ReceiptCatalogueArticle("A", "SAME")
                }, suppliers, stock);
            }, "duplicate catalogue identity rejected");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptFreshnessService.Compare(projection, catalogue, new[] {
                    new ReceiptSupplierSnapshotLine("SUP"),
                    new ReceiptSupplierSnapshotLine("SUP")
                }, stock);
            }, "duplicate supplier identity rejected");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers, new[] {
                    new StockBaselineLine("A", 10m),
                    new StockBaselineLine("A", 10m)
                });
            }, "duplicate stock identity rejected");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers,
                    new StockBaselineLine[] { null });
            }, "null stock row rejected");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers,
                    new[] { new StockBaselineLine(" ", 1m) });
            }, "blank stock ID rejected");
            var failure = new InvalidOperationException("stock iterator failed");
            Exception observed = null;
            try { PurchaseReceiptFreshnessService.Compare(projection, catalogue, suppliers,
                BrokenStock(failure)); }
            catch (Exception e) { observed = e; }
            Require(Object.ReferenceEquals(observed, failure),
                "iterator failure propagated unchanged");

            var validLine = projection.Lines[0];
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptFreshnessService.Compare(Forged(validLine, 2m, validLine.ExtendedCost),
                    catalogue, suppliers, new StockBaselineLine[0]);
            }, "forged total quantity rejected");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptFreshnessService.Compare(Forged(validLine, validLine.ReceivedQuantity, 9m),
                    catalogue, suppliers, new StockBaselineLine[0]);
            }, "forged total cost rejected");
            var brokenLine = new PurchaseReceiptStockProjectionLine(
                new PurchaseReceiptArticleTotal("A", "SAME", 1m, 2m), 10m, 12m);
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptFreshnessService.Compare(Forged(brokenLine, 1m, 2m),
                    catalogue, suppliers, new StockBaselineLine[0]);
            }, "forged projected stock rejected");
            var negativeLine = new PurchaseReceiptStockProjectionLine(
                new PurchaseReceiptArticleTotal("A", "SAME", -1m, 2m), 10m, 9m);
            Throws<ArgumentException>(delegate {
                PurchaseReceiptFreshnessService.Compare(Forged(negativeLine, -1m, 2m),
                    catalogue, suppliers, new StockBaselineLine[0]);
            }, "negative received quantity rejected");
            var duplicateReceipt = new PurchaseReceiptPreview("SUP", new[] {
                new PurchaseReceiptArticleTotal("A", "SAME", 1m, 1m),
                new PurchaseReceiptArticleTotal("A", "SAME", 1m, 1m)
            }, 2m, 2m);
            var duplicateProjection = new PurchaseReceiptStockProjection(duplicateReceipt, new[] {
                new PurchaseReceiptStockProjectionLine(duplicateReceipt.Articles[0], 10m, 11m),
                new PurchaseReceiptStockProjectionLine(duplicateReceipt.Articles[1], 10m, 11m)
            });
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptFreshnessService.Compare(duplicateProjection, catalogue,
                    suppliers, new StockBaselineLine[0]);
            }, "duplicate projected article IDs rejected");

            var count = StockCountCoverageService.Compare(new[] {
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("B", 0m)
            }, new[] {
                new StockCountLine("A", 10m, 8m),
                new StockCountLine("B", 0m, 0m)
            });
            var ready = StockCountReconciliationPreviewService.Review(count, new[] {
                new StockBaselineLine("B", 0m), new StockBaselineLine("A", 10m)
            });
            Require(ready.CanPreviewAdjustments, "complete fresh count may preview adjustments");
            Require(ready.Freshness.IsFresh, "freshness included in result");
            Require(ready.ProposedAdjustments != null &&
                ready.ProposedAdjustments.Adjustments.Count == 1 &&
                ready.ProposedAdjustments.Adjustments[0].ArticleId == "A" &&
                ready.ProposedAdjustments.Adjustments[0].Delta == -2m,
                "only changed article proposed");
            var noAdjustments = StockCountReconciliationPreviewService.Review(
                StockCountCoverageService.Compare(new[] {
                    new StockBaselineLine("B", 0m)
                }, new[] { new StockCountLine("B", 0m, 0m) }),
                new[] { new StockBaselineLine("B", 0m) });
            Require(noAdjustments.CanPreviewAdjustments &&
                noAdjustments.ProposedAdjustments.Adjustments.Count == 0,
                "fresh zero-delta count yields empty plan, not null");

            var staleCount = StockCountReconciliationPreviewService.Review(count, new[] {
                new StockBaselineLine("A", 10m),
                new StockBaselineLine("B", 1m)
            });
            Require(!staleCount.CanPreviewAdjustments, "stale zero-delta row blocks plan");
            Require(staleCount.ProposedAdjustments == null, "stale count has no adjustment proposal");
            Require(staleCount.Freshness.ChangedQuantityArticleIds.Count == 1 &&
                staleCount.Freshness.ChangedQuantityArticleIds[0] == "B",
                "changed zero-delta ID reported");
            var addedCount = StockCountReconciliationPreviewService.Review(count, new[] {
                new StockBaselineLine("A", 10m), new StockBaselineLine("B", 0m),
                new StockBaselineLine("NEW", 0m)
            });
            Require(!addedCount.CanPreviewAdjustments &&
                addedCount.Freshness.AddedArticleIds.Count == 1,
                "even newly added zero-stock article blocks plan");
            var missingCount = StockCountReconciliationPreviewService.Review(count, new[] {
                new StockBaselineLine("A", 10m)
            });
            Require(!missingCount.CanPreviewAdjustments &&
                missingCount.Freshness.MissingArticleIds[0] == "B",
                "missing zero-delta article blocks plan");
            Throws<InvalidOperationException>(delegate {
                StockCountReconciliationPreviewService.Review(
                    StockCountCoverageService.Compare(new[] {
                        new StockBaselineLine("A", 10m), new StockBaselineLine("B", 0m)
                    }, new[] { new StockCountLine("A", 10m, 8m) }),
                    new[] { new StockBaselineLine("A", 10m) });
            }, "partial stocktake never produces plan");
            Throws<ArgumentNullException>(delegate {
                StockCountReconciliationPreviewService.Review(null,
                    new StockBaselineLine[0]);
            }, "null completed count");
            Throws<ArgumentNullException>(delegate {
                StockCountReconciliationPreviewService.Review(count, null);
            }, "null current stock");
            Throws<InvalidOperationException>(delegate {
                StockCountReconciliationPreviewService.Review(count, new[] {
                    new StockBaselineLine("A", 10m), new StockBaselineLine("A", 10m)
                });
            }, "duplicate stock identity blocks reconciliation");
            Throws<NotSupportedException>(delegate {
                ready.ProposedAdjustments.Adjustments.Add(
                    ready.ProposedAdjustments.Adjustments[0]);
            }, "adjustment proposals immutable");

            Console.WriteLine("PASS business revalidation: " + assertions +
                " assertions; purchase freshness, supplier, catalogue, stock, safe count proposals");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
