using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Purchasing;
using LOGICA.ApplicationLayer.Inventory;

internal static class BusinessOperationsSafetySmoke
{
    private static int assertions;

    private static void Require(bool condition, string message)
    {
        assertions++;
        if (!condition) throw new Exception("Business safety regression: " + message);
    }

    private static void Throws<T>(Action action, string message) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name + ": " + message);
    }

    private static IEnumerable<ReceiptCatalogueArticle> BrokenCatalogue(Exception failure)
    {
        yield return new ReceiptCatalogueArticle("A", "123");
        throw failure;
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var receipt = PurchaseReceiptPreviewService.Build("SUP-01", new[] {
                new PurchaseReceiptLine("A", "123", 1m, 2m),
                new PurchaseReceiptLine("B", "123", 2m, 3m),
                new PurchaseReceiptLine("A", "123", 0.5m, 4m),
                new PurchaseReceiptLine("C", null, 1m, 0m)
            });
            var catalogue = new[] {
                new ReceiptCatalogueArticle("A", "123"),
                new ReceiptCatalogueArticle("B", "123"),
                new ReceiptCatalogueArticle("C", null),
                new ReceiptCatalogueArticle("D", "extra")
            };
            var valid = PurchaseReceiptCatalogueValidationService.Compare(receipt, catalogue);
            Require(valid.IsValid, "identical catalogue identities accepted");
            Require(valid.MatchedArticleIds.Count == 3, "receipt aggregates repeated article IDs");
            Require(valid.MatchedArticleIds[0] == "A" && valid.MatchedArticleIds[1] == "B" &&
                valid.MatchedArticleIds[2] == "C", "receipt order preserved");
            Require(valid.UnknownArticleIds.Count == 0, "no unknown articles");
            Require(valid.BarcodeChangedArticleIds.Count == 0, "no barcode changes");
            Require(receipt.Articles[0].Quantity == 1.5m, "receipt totals unchanged");
            Throws<NotSupportedException>(delegate { valid.MatchedArticleIds.Add("D"); },
                "read-only matched IDs");
            Throws<NotSupportedException>(delegate { valid.UnknownArticleIds.Add("D"); },
                "read-only unknown IDs");
            Throws<NotSupportedException>(delegate { valid.BarcodeChangedArticleIds.Add("D"); },
                "read-only changed IDs");

            var stale = PurchaseReceiptCatalogueValidationService.Compare(receipt, new[] {
                new ReceiptCatalogueArticle("A", "123"),
                new ReceiptCatalogueArticle("B", "new barcode"),
                new ReceiptCatalogueArticle("D", "extra")
            });
            Require(!stale.IsValid, "stale receipt blocked");
            Require(stale.MatchedArticleIds.Count == 1 && stale.MatchedArticleIds[0] == "A",
                "matched identity retained");
            Require(stale.BarcodeChangedArticleIds.Count == 1 &&
                stale.BarcodeChangedArticleIds[0] == "B", "changed barcode reported by ID");
            Require(stale.UnknownArticleIds.Count == 1 &&
                stale.UnknownArticleIds[0] == "C", "unknown article reported by ID");
            Require(!PurchaseReceiptCatalogueValidationService.Compare(receipt,
                new ReceiptCatalogueArticle[0]).IsValid, "empty catalogue fails closed");
            Require(!PurchaseReceiptCatalogueValidationService.Compare(receipt, new[] {
                new ReceiptCatalogueArticle("a", "123"), new ReceiptCatalogueArticle("B", "123"),
                new ReceiptCatalogueArticle("C", null)
            }).IsValid, "case-sensitive article IDs");
            Require(!PurchaseReceiptCatalogueValidationService.Compare(receipt, new[] {
                new ReceiptCatalogueArticle("A", "123"), new ReceiptCatalogueArticle("B", "123"),
                new ReceiptCatalogueArticle("C", "")
            }).IsValid, "null and empty barcode remain distinct");

            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptCatalogueValidationService.Compare(null, catalogue);
            }, "null receipt");
            Throws<ArgumentNullException>(delegate {
                PurchaseReceiptCatalogueValidationService.Compare(receipt, null);
            }, "null catalogue");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptCatalogueValidationService.Compare(receipt,
                    new ReceiptCatalogueArticle[] { null });
            }, "null catalogue row");
            Throws<ArgumentException>(delegate {
                PurchaseReceiptCatalogueValidationService.Compare(receipt, new[] {
                    new ReceiptCatalogueArticle(" ", "123")
                });
            }, "blank catalogue ID");
            Throws<InvalidOperationException>(delegate {
                PurchaseReceiptCatalogueValidationService.Compare(receipt, new[] {
                    new ReceiptCatalogueArticle("A", "123"),
                    new ReceiptCatalogueArticle("A", "123")
                });
            }, "duplicate catalogue ID");
            var iteratorFailure = new InvalidOperationException("catalogue iterator failed");
            Exception observed = null;
            try { PurchaseReceiptCatalogueValidationService.Compare(receipt,
                BrokenCatalogue(iteratorFailure)); }
            catch (Exception error) { observed = error; }
            Require(Object.ReferenceEquals(observed, iteratorFailure),
                "catalogue enumeration failure identity");

            var complete = StockCountCoverageService.Compare(new[] {
                new StockBaselineLine("A", 10m), new StockBaselineLine("B", 5m),
                new StockBaselineLine("C", 1m)
            }, new[] {
                new StockCountLine("A", 0m, 8m), new StockCountLine("B", 0m, 7m),
                new StockCountLine("C", 0m, 1m)
            });
            var plan = StockCountAdjustmentProposalService.Create(complete);
            Require(plan.Adjustments.Count == 2, "only non-zero deltas proposed");
            Require(plan.Adjustments[0].ArticleId == "A" && plan.Adjustments[0].Delta == -2m,
                "shortage proposal");
            Require(plan.Adjustments[1].ArticleId == "B" && plan.Adjustments[1].Delta == 2m,
                "surplus proposal");
            Require(plan.Adjustments[0].RecordedQuantity == 10m &&
                plan.Adjustments[0].CountedQuantity == 8m, "authoritative baseline retained");
            Require(plan.TotalShortage == 2m && plan.TotalSurplus == 2m,
                "shortage and surplus separately retained");
            Throws<NotSupportedException>(delegate {
                plan.Adjustments.Add(new StockCountAdjustmentProposal(complete.MatchedVariances.Lines[0]));
            }, "read-only adjustment proposal");
            Throws<ArgumentNullException>(delegate {
                StockCountAdjustmentProposalService.Create(null);
            }, "null coverage");
            Throws<InvalidOperationException>(delegate {
                StockCountAdjustmentProposalService.Create(StockCountCoverageService.Compare(
                    new[] { new StockBaselineLine("A", 1m), new StockBaselineLine("B", 2m) },
                    new[] { new StockCountLine("A", 0m, 0m) }));
            }, "uncounted product cannot become zero stock");
            Throws<InvalidOperationException>(delegate {
                StockCountAdjustmentProposalService.Create(StockCountCoverageService.Compare(
                    new[] { new StockBaselineLine("A", 1m) },
                    new[] { new StockCountLine("A", 0m, 1m),
                        new StockCountLine("UNKNOWN", 0m, 4m) }));
            }, "unknown article blocks adjustment proposal");
            var empty = StockCountAdjustmentProposalService.Create(
                StockCountCoverageService.Compare(new StockBaselineLine[0], new StockCountLine[0]));
            Require(empty.Adjustments.Count == 0 && empty.TotalShortage == 0m,
                "empty catalogue produces empty proposal");
            var negative = StockCountAdjustmentProposalService.Create(
                StockCountCoverageService.Compare(new[] { new StockBaselineLine("NEG", -2m) },
                    new[] { new StockCountLine("NEG", 0m, 0m) }));
            Require(negative.Adjustments.Count == 1 && negative.Adjustments[0].Delta == 2m,
                "legacy negative recorded stock not normalized");
            Require(negative.TotalSurplus == 2m, "negative stock surplus preserved");

            Console.WriteLine("PASS business catalogue validation and complete-only adjustment proposals: " +
                assertions + " assertions; duplicate barcodes, stale identity, no stock writes");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
