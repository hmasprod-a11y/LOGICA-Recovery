using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Purchasing;
using LOGICA.ApplicationLayer.Inventory;

internal static class BusinessOperationsSmoke
{
    private static int assertions;

    private static void Require(bool value, string label)
    {
        assertions++;
        if (!value) throw new Exception("Business operations regression: " + label);
    }

    private static void Throws<T>(Action action, string label) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name + ": " + label);
    }

    private static IEnumerable<PurchaseReceiptLine> FailingLines(Exception error)
    {
        yield return new PurchaseReceiptLine("A", "X", 1m, 1m);
        throw error;
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var receipt = PurchaseReceiptPreviewService.Build("SUP-01", new[] {
                new PurchaseReceiptLine("A", "123", 2m, 0.10m),
                new PurchaseReceiptLine("B", "123", 1m, 0.25m),
                new PurchaseReceiptLine("A", "123", 0.5m, 0.20m)
            });
            Require(receipt.SupplierId == "SUP-01", "supplier preserved");
            Require(receipt.Articles.Count == 2, "group by article ID, never barcode");
            Require(receipt.Articles[0].ArticleId == "A" && receipt.Articles[1].ArticleId == "B",
                "first-seen order and variant identities");
            Require(receipt.Articles[0].Quantity == 2.5m && receipt.Articles[1].Quantity == 1m,
                "fractional received quantities");
            Require(receipt.Articles[0].ExtendedCost == 0.30m &&
                    receipt.Articles[1].ExtendedCost == 0.25m, "decimal costs without rounding");
            Require(receipt.TotalQuantity == 3.5m && receipt.TotalCost == 0.55m,
                "receipt totals");
            Throws<NotSupportedException>(delegate {
                receipt.Articles.Add(new PurchaseReceiptArticleTotal("C", "123", 1m, 1m));
            }, "read-only preview");
            Require(PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("A", null, 1m, 0m)
            }).TotalCost == 0m, "barcode optional and zero-cost allowed");
            Require(PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("a", "X", 1m, 1m),
                new PurchaseReceiptLine("A", "X", 1m, 1m)
            }).Articles.Count == 2, "ordinal case-sensitive IDs");

            Throws<ArgumentException>(delegate { PurchaseReceiptPreviewService.Build("", new PurchaseReceiptLine[0]); },
                "missing supplier");
            Throws<ArgumentNullException>(delegate { PurchaseReceiptPreviewService.Build("S", null); },
                "null lines");
            Throws<ArgumentException>(delegate { PurchaseReceiptPreviewService.Build("S", new PurchaseReceiptLine[0]); },
                "empty receipt");
            Throws<ArgumentException>(delegate { PurchaseReceiptPreviewService.Build("S", new PurchaseReceiptLine[] { null }); },
                "null receipt line");
            Throws<ArgumentException>(delegate { PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine(" ", "X", 1m, 1m)
            }); }, "missing article ID");
            Throws<ArgumentOutOfRangeException>(delegate { PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("A", "X", 0m, 1m)
            }); }, "zero quantity");
            Throws<ArgumentOutOfRangeException>(delegate { PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("A", "X", -1m, 1m)
            }); }, "negative quantity");
            Throws<ArgumentOutOfRangeException>(delegate { PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("A", "X", 1m, -1m)
            }); }, "negative unit cost");
            Throws<InvalidOperationException>(delegate { PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("A", "X", 1m, 1m),
                new PurchaseReceiptLine("A", "Y", 1m, 1m)
            }); }, "conflicting barcode for same article");
            Throws<OverflowException>(delegate { PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("A", "X", decimal.MaxValue, 0m),
                new PurchaseReceiptLine("B", "X", 1m, 0m)
            }); }, "quantity overflow");
            Throws<OverflowException>(delegate { PurchaseReceiptPreviewService.Build("S", new[] {
                new PurchaseReceiptLine("A", "X", decimal.MaxValue, 2m)
            }); }, "extended cost overflow");
            var failure = new InvalidOperationException("iterator failure");
            Exception observed = null;
            try { PurchaseReceiptPreviewService.Build("S", FailingLines(failure)); }
            catch (Exception e) { observed = e; }
            Require(Object.ReferenceEquals(observed, failure), "enumeration exception identity");

            var count = StockCountVarianceService.Compare(new[] {
                new StockCountLine("A", 5m, 3.5m),
                new StockCountLine("B", 2m, 7m),
                new StockCountLine("C", -2m, 1m),
                new StockCountLine("D", 3m, 3m)
            });
            Require(count.Lines.Count == 4, "all counted articles retained");
            Require(count.Lines[0].Difference == -1.5m && count.Lines[1].Difference == 5m,
                "signed variance");
            Require(count.Lines[2].Difference == 3m && count.Lines[3].Difference == 0m,
                "negative legacy recorded stock and exact match");
            Require(count.TotalShortage == 1.5m && count.TotalSurplus == 8m,
                "shortages and surpluses not netted");
            Require(StockCountVarianceService.Compare(new StockCountLine[0]).Lines.Count == 0,
                "empty count is read-only preview");
            Throws<NotSupportedException>(delegate {
                count.Lines.Add(new StockCountVariance(new StockCountLine("E", 0m, 0m), 0m));
            }, "read-only count");
            Throws<ArgumentNullException>(delegate { StockCountVarianceService.Compare(null); },
                "null count");
            Throws<ArgumentException>(delegate { StockCountVarianceService.Compare(new StockCountLine[] { null }); },
                "null count line");
            Throws<ArgumentException>(delegate { StockCountVarianceService.Compare(new[] {
                new StockCountLine("", 0m, 0m)
            }); }, "missing count article ID");
            Throws<InvalidOperationException>(delegate { StockCountVarianceService.Compare(new[] {
                new StockCountLine("A", 1m, 1m),
                new StockCountLine("A", 2m, 2m)
            }); }, "duplicate physical count article ID");
            Throws<ArgumentOutOfRangeException>(delegate { StockCountVarianceService.Compare(new[] {
                new StockCountLine("A", 1m, -1m)
            }); }, "negative physical count");
            Throws<OverflowException>(delegate { StockCountVarianceService.Compare(new[] {
                new StockCountLine("A", decimal.MinValue, decimal.MaxValue)
            }); }, "variance overflow");
            Require(StockCountVarianceService.Compare(new[] {
                new StockCountLine("a", 1m, 1m),
                new StockCountLine("A", 1m, 1m)
            }).Lines.Count == 2, "count identity is ordinal");

            Console.WriteLine("PASS business receipt and physical stock count previews: " + assertions +
                " assertions; variants, fractional costs, fail-closed validation, overflow and no writes");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
