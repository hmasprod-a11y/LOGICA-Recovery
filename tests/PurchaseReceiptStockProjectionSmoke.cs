using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Inventory;
using LOGICA.ApplicationLayer.Purchasing;

internal static class PurchaseReceiptStockProjectionSmoke
{
    private static int assertions;

    private static void Require(bool condition, string label)
    {
        assertions++;
        if (!condition) throw new Exception("Purchase stock projection regression: " + label);
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
        yield return new StockBaselineLine("A", 1m);
        throw failure;
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var receipt = PurchaseReceiptPreviewService.Build("SUP-1", new[] {
                new PurchaseReceiptLine("A", "SAME", 1m, 2m),
                new PurchaseReceiptLine("B", "SAME", 2m, 3m),
                new PurchaseReceiptLine("A", "SAME", 0.5m, 4m),
                new PurchaseReceiptLine("C", null, 1m, 0m)
            });
            var catalogue = new[] {
                new ReceiptCatalogueArticle("B", "SAME"),
                new ReceiptCatalogueArticle("A", "SAME"),
                new ReceiptCatalogueArticle("C", null),
                new ReceiptCatalogueArticle("EXTRA", "SAME")
            };
            var stock = new List<StockBaselineLine> {
                new StockBaselineLine("B", -3m),
                new StockBaselineLine("EXTRA", 900m),
                new StockBaselineLine("C", 0m),
                new StockBaselineLine("A", 10m)
            };
            var result = PurchaseReceiptStockProjectionService.Build(receipt, catalogue, stock);
            Require(result.SupplierId == "SUP-1", "supplier identity");
            Require(result.Lines.Count == 3, "one projection per received ID");
            Require(result.Lines[0].ArticleId == "A" &&
                result.Lines[1].ArticleId == "B" && result.Lines[2].ArticleId == "C",
                "receipt order retained independently of catalogue and stock order");
            Require(result.Lines[0].Barcode == "SAME" && result.Lines[1].Barcode == "SAME",
                "duplicate barcodes remain distinct article identities");
            Require(result.Lines[0].RecordedQuantity == 10m &&
                result.Lines[0].ReceivedQuantity == 1.5m &&
                result.Lines[0].ProjectedQuantity == 11.5m,
                "aggregated fractional receipt projected from authoritative stock");
            Require(result.Lines[1].RecordedQuantity == -3m &&
                result.Lines[1].ReceivedQuantity == 2m &&
                result.Lines[1].ProjectedQuantity == -1m,
                "legacy negative stock preserved");
            Require(result.Lines[2].Barcode == null &&
                result.Lines[2].ProjectedQuantity == 1m, "barcode-free item");
            Require(result.Lines[0].ExtendedCost == 4m &&
                result.Lines[1].ExtendedCost == 6m &&
                result.Lines[2].ExtendedCost == 0m, "extended costs not rounded or re-priced");
            Require(result.TotalReceivedQuantity == 4.5m && result.TotalReceiptCost == 10m,
                "totals copied exactly from validated receipt");
            Require(stock.Count == 4 && stock[0].RecordedQuantity == -3m &&
                stock[1].RecordedQuantity == 900m, "input stock unchanged");
            stock.Clear();
            Require(result.Lines[0].ProjectedQuantity == 11.5m &&
                result.Lines[1].ProjectedQuantity == -1m, "result detached from mutable caller collection");
            Throws<NotSupportedException>(delegate {
                result.Lines.Add(result.Lines[0]);
            }, "projection list is read-only");

            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptStockProjectionService.Build(null, catalogue,
                    new StockBaselineLine[0]);
            }, "null receipt");
            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, null,
                    new StockBaselineLine[0]);
            }, "null catalogue");
            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, catalogue, null);
            }, "null stock snapshot");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, new[] {
                    new ReceiptCatalogueArticle("A", "SAME"),
                    new ReceiptCatalogueArticle("C", null)
                }, new StockBaselineLine[0]);
            }, "missing catalogue article fails closed");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, new[] {
                    new ReceiptCatalogueArticle("A", "SAME"),
                    new ReceiptCatalogueArticle("B", "CHANGED"),
                    new ReceiptCatalogueArticle("C", null)
                }, new StockBaselineLine[0]);
            }, "changed barcode fails closed");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, new[] {
                    new ReceiptCatalogueArticle("A", "SAME"),
                    new ReceiptCatalogueArticle("B", "SAME"),
                    new ReceiptCatalogueArticle("C", "")
                }, new StockBaselineLine[0]);
            }, "null and empty barcode differ");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, new[] {
                    new ReceiptCatalogueArticle("A", "SAME"),
                    new ReceiptCatalogueArticle("A", "SAME")
                }, new StockBaselineLine[0]);
            }, "duplicate catalogue identity rejected");

            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, catalogue, new[] {
                    new StockBaselineLine("A", 1m), new StockBaselineLine("B", 2m)
                });
            }, "missing stock row rejected");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, catalogue, new[] {
                    new StockBaselineLine("a", 1m), new StockBaselineLine("B", 2m),
                    new StockBaselineLine("C", 3m)
                });
            }, "case-sensitive stock identity");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, catalogue, new[] {
                    new StockBaselineLine("A", 1m), new StockBaselineLine("B", 2m),
                    new StockBaselineLine("C", 3m), new StockBaselineLine("EXTRA", 1m),
                    new StockBaselineLine("EXTRA", 2m)
                });
            }, "duplicate unrelated stock row also fails closed");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, catalogue,
                    new StockBaselineLine[] { null });
            }, "null stock row");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, catalogue,
                    new[] { new StockBaselineLine(" ", 1m) });
            }, "blank stock ID");
            Throws<OverflowException>(delegate {
                PurchaseReceiptStockProjectionService.Build(receipt, catalogue, new[] {
                    new StockBaselineLine("A", decimal.MaxValue),
                    new StockBaselineLine("B", 0m), new StockBaselineLine("C", 0m)
                });
            }, "projected stock overflow fails closed");

            var failure = new InvalidOperationException("stock enumeration failure");
            Exception observed = null;
            try {
                PurchaseReceiptStockProjectionService.Build(receipt, catalogue, BrokenStock(failure));
            }
            catch (Exception error) { observed = error; }
            Require(Object.ReferenceEquals(observed, failure),
                "stock enumeration failure propagated without swallowing");

            // Internal preview DTOs can be constructed without the receipt builder.
            // A corrupted snapshot must not reach stock projection as a valid total.
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(
                    new PurchaseReceiptPreview("SUP-1", new[] {
                        new PurchaseReceiptArticleTotal("A", "SAME", 1m, 2m)
                    }, 2m, 2m), catalogue, new[] { new StockBaselineLine("A", 5m) });
            }, "forged receipt quantity total rejected");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(
                    new PurchaseReceiptPreview("SUP-1", new[] {
                        new PurchaseReceiptArticleTotal("A", "SAME", 1m, 2m)
                    }, 1m, 3m), catalogue, new[] { new StockBaselineLine("A", 5m) });
            }, "forged receipt cost total rejected");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(
                    new PurchaseReceiptPreview("SUP-1", new[] {
                        new PurchaseReceiptArticleTotal("A", "SAME", 1m, 2m),
                        new PurchaseReceiptArticleTotal("A", "SAME", 1m, 2m)
                    }, 2m, 4m), catalogue, new[] { new StockBaselineLine("A", 5m) });
            }, "duplicate receipt article ID rejected");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(
                    new PurchaseReceiptPreview("SUP-1", new[] {
                        new PurchaseReceiptArticleTotal("A", "SAME", -1m, 2m)
                    }, -1m, 2m), catalogue, new[] { new StockBaselineLine("A", 5m) });
            }, "negative receipt quantity rejected");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptStockProjectionService.Build(
                    new PurchaseReceiptPreview(" ", new[] {
                        new PurchaseReceiptArticleTotal("A", "SAME", 1m, 2m)
                    }, 1m, 2m), catalogue, new[] { new StockBaselineLine("A", 5m) });
            }, "missing receipt supplier rejected");
            Throws<OverflowException>(delegate {
                PurchaseReceiptStockProjectionService.Build(
                    new PurchaseReceiptPreview("SUP-1", new[] {
                        new PurchaseReceiptArticleTotal("A", "SAME", decimal.MaxValue, 0m),
                        new PurchaseReceiptArticleTotal("B", "SAME", 1m, 0m)
                    }, decimal.MaxValue, 0m), catalogue, new StockBaselineLine[0]);
            }, "receipt quantity aggregate overflow rejected");

            var caseReceipt = PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("A", "X", 1m, 0.125m),
                new PurchaseReceiptLine("a", "X", 1m, 0.375m)
            });
            var caseResult = PurchaseReceiptStockProjectionService.Build(caseReceipt, new[] {
                new ReceiptCatalogueArticle("a", "X"), new ReceiptCatalogueArticle("A", "X")
            }, new[] { new StockBaselineLine("a", 2m), new StockBaselineLine("A", 4m) });
            Require(caseResult.Lines.Count == 2 &&
                caseResult.Lines[0].ProjectedQuantity == 5m &&
                caseResult.Lines[1].ProjectedQuantity == 3m,
                "ordinal case-sensitive variants and independent stock");
            Require(caseResult.TotalReceiptCost == 0.500m,
                "fractional costs preserved without rounding");

            Console.WriteLine("PASS purchase stock projection: " + assertions +
                " assertions; exact IDs, duplicate barcodes, catalogue/stock guards, no writes");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
