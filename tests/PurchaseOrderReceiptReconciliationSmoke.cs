using System;
using System.Collections.Generic;
using LOGICA.ApplicationLayer.Purchasing;

internal static class PurchaseOrderReceiptReconciliationSmoke
{
    private static int assertions;

    private static void Require(bool condition, string label)
    {
        assertions++;
        if (!condition) throw new Exception("Purchase order reconciliation regression: " + label);
    }

    private static void Throws<T>(Action action, string label) where T : Exception
    {
        assertions++;
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name + ": " + label);
    }

    private static PurchaseReceiptPreview Receipt(string supplier,
        params PurchaseReceiptLine[] lines)
    {
        return PurchaseReceiptPreviewService.Build(supplier, lines);
    }

    private static PurchaseOrderLine Order(string id, string barcode,
        decimal quantity, decimal cost)
    {
        return new PurchaseOrderLine(id, barcode, quantity, cost);
    }

    internal static int Run()
    {
        assertions = 0;
        try
        {
            var order = new List<PurchaseOrderLine> {
                Order("A", "SHARED", 5m, 2m),
                Order("B", "SHARED", 3m, 4m),
                Order("a", "", 1m, 0m)
            };
            var receipt = Receipt("SUP", new PurchaseReceiptLine("A", "SHARED", 2m, 2m),
                new PurchaseReceiptLine("B", "SHARED", 3m, 4m),
                new PurchaseReceiptLine("a", "", 1m, 0m));
            var preview = PurchaseOrderReceiptReconciliationService.Compare("SUP", order, receipt);
            Require(preview.SupplierId == "SUP", "supplier identity preserved");
            Require(preview.Lines.Count == 3 && preview.Lines[0].ArticleId == "A" &&
                preview.Lines[1].ArticleId == "B" && preview.Lines[2].ArticleId == "a",
                "ordinal IDs and original order preserved");
            Require(preview.Lines[0].OrderedQuantity == 5m &&
                preview.Lines[0].ReceivedQuantity == 2m &&
                preview.Lines[0].RemainingQuantity == 3m, "partial delivery is visible");
            Require(preview.Lines[1].RemainingQuantity == 0m &&
                preview.Lines[1].ExpectedCostOfReceived == 12m &&
                preview.Lines[1].ActualReceivedCost == 12m, "exact delivery and cost");
            Require(preview.Lines[2].Barcode == "" &&
                preview.Lines[2].AgreedUnitCost == 0m, "barcode-free and free goods allowed");
            Require(preview.TotalOrderedQuantity == 9m &&
                preview.TotalReceivedQuantity == 6m, "aggregate quantities");
            Require(preview.TotalExpectedCostOfMatchedReceipts == 16m &&
                preview.TotalActualReceivedCost == 16m, "aggregate costs");
            Require(!preview.IsQuantityComplete && preview.HasDiscrepancies,
                "partial receipt cannot be marked complete");
            Require(preview.UnexpectedReceivedArticleIds.Count == 0,
                "different IDs with same barcode are not unexpected");

            var exact = PurchaseOrderReceiptReconciliationService.Compare("SUP",
                new[] { Order("A", "X", 2m, 3m) },
                Receipt("SUP", new PurchaseReceiptLine("A", "X", 2m, 3m)));
            Require(exact.IsQuantityComplete && !exact.HasDiscrepancies,
                "exact delivery is complete");
            Require(exact.Lines[0].CostVariance == 0m &&
                !exact.Lines[0].IsOverReceived && !exact.Lines[0].HasCostVariance,
                "exact line has no false variance");

            var over = PurchaseOrderReceiptReconciliationService.Compare("SUP",
                new[] { Order("A", "X", 2m, 3m) },
                Receipt("SUP", new PurchaseReceiptLine("A", "X", 4m, 3m)));
            Require(over.Lines[0].RemainingQuantity == -2m &&
                over.Lines[0].IsOverReceived && over.HasDiscrepancies,
                "overdelivery is signed and flagged");

            var costDrift = PurchaseOrderReceiptReconciliationService.Compare("SUP",
                new[] { Order("A", "X", 2m, 3m) },
                Receipt("SUP", new PurchaseReceiptLine("A", "X", 2m, 3.5m)));
            Require(costDrift.IsQuantityComplete && costDrift.HasDiscrepancies,
                "cost variance independent of quantity completion");
            Require(costDrift.Lines[0].CostVariance == 1m &&
                costDrift.Lines[0].HasCostVariance, "cost increase is reported");

            var costDecrease = PurchaseOrderReceiptReconciliationService.Compare("SUP",
                new[] { Order("A", "X", 2m, 3m) },
                Receipt("SUP", new PurchaseReceiptLine("A", "X", 2m, 2m)));
            Require(costDecrease.Lines[0].CostVariance == -2m,
                "cost decrease retains sign");

            var unknown = PurchaseOrderReceiptReconciliationService.Compare("SUP",
                new[] { Order("A", "X", 2m, 3m) },
                Receipt("SUP", new PurchaseReceiptLine("A", "X", 2m, 3m),
                    new PurchaseReceiptLine("EXTRA", "X", 1m, 10m)));
            Require(unknown.UnexpectedReceivedArticleIds.Count == 1 &&
                unknown.UnexpectedReceivedArticleIds[0] == "EXTRA",
                "unexpected article is not silently accepted");
            Require(unknown.TotalActualReceivedCost == 16m &&
                unknown.TotalExpectedCostOfMatchedReceipts == 6m,
                "unexpected article cost is not counted as agreed order cost");
            Require(!unknown.IsQuantityComplete && unknown.HasDiscrepancies,
                "unexpected article prevents exact reconciliation");

            var absent = PurchaseOrderReceiptReconciliationService.Compare("SUP",
                new[] { Order("A", "X", 2m, 3m), Order("B", "Y", 4m, 5m) },
                Receipt("SUP", new PurchaseReceiptLine("A", "X", 2m, 3m)));
            Require(absent.Lines[1].ReceivedQuantity == 0m &&
                absent.Lines[1].RemainingQuantity == 4m, "unreceived order line remains open");

            var grouped = PurchaseOrderReceiptReconciliationService.Compare("SUP",
                new[] { Order("A", "X", 1m, 3m), Order("A", "X", 2m, 3m) },
                Receipt("SUP", new PurchaseReceiptLine("A", "X", 3m, 3m)));
            Require(grouped.Lines.Count == 1 && grouped.Lines[0].OrderedQuantity == 3m &&
                grouped.IsQuantityComplete, "same ID and cost order lines aggregate");

            var fractional = PurchaseOrderReceiptReconciliationService.Compare("SUP",
                new[] { Order("A", null, 1.25m, 2.4m) },
                Receipt("SUP", new PurchaseReceiptLine("A", null, 1.25m, 2.4m)));
            Require(fractional.Lines[0].ExpectedCostOfReceived == 3.00m &&
                !fractional.HasDiscrepancies, "fractional quantities and null barcodes preserved");

            order.Clear();
            Require(preview.Lines.Count == 3 && preview.Lines[0].RemainingQuantity == 3m,
                "preview detached from mutable order input");
            Throws<NotSupportedException>(delegate { preview.Lines.Add(preview.Lines[0]); },
                "reconciliation lines immutable");
            Throws<NotSupportedException>(delegate { unknown.UnexpectedReceivedArticleIds.Add("BAD"); },
                "unexpected IDs immutable");

            var goodOrder = new[] { Order("A", "X", 1m, 2m) };
            var goodReceipt = Receipt("SUP", new PurchaseReceiptLine("A", "X", 1m, 2m));
            Throws<ArgumentException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare(" ", goodOrder, goodReceipt);
            }, "blank supplier");
            Throws<ArgumentNullException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", null, goodReceipt);
            }, "null order");
            Throws<ArgumentNullException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder, null);
            }, "null receipt");
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("sup", goodOrder, goodReceipt);
            }, "supplier IDs compared ordinally");
            Throws<ArgumentException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new PurchaseOrderLine[0], goodReceipt);
            }, "empty purchase order");
            Throws<ArgumentException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new PurchaseOrderLine[] { null }, goodReceipt);
            }, "null order line");
            Throws<ArgumentException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new[] { Order("", "X", 1m, 2m) }, goodReceipt);
            }, "blank order article ID");
            Throws<ArgumentOutOfRangeException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new[] { Order("A", "X", 0m, 2m) }, goodReceipt);
            }, "zero ordered quantity");
            Throws<ArgumentOutOfRangeException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new[] { Order("A", "X", -1m, 2m) }, goodReceipt);
            }, "negative ordered quantity");
            Throws<ArgumentOutOfRangeException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new[] { Order("A", "X", 1m, -1m) }, goodReceipt);
            }, "negative agreed cost");
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new[] { Order("A", "X", 1m, 2m), Order("A", "Y", 1m, 2m) }, goodReceipt);
            }, "one ordered ID with conflicting barcode");
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new[] { Order("A", "X", 1m, 2m), Order("A", "X", 1m, 3m) }, goodReceipt);
            }, "one ordered ID with conflicting agreed cost");
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder,
                    Receipt("SUP", new PurchaseReceiptLine("A", "Y", 1m, 2m)));
            }, "barcode drift on matched ID");
            Throws<OverflowException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new[] { Order("A", "X", decimal.MaxValue, 0m),
                        Order("A", "X", 1m, 0m) }, goodReceipt);
            }, "duplicate ordered quantity overflow");
            Throws<OverflowException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP",
                    new[] { Order("A", "X", 2m, decimal.MaxValue) },
                    Receipt("SUP", new PurchaseReceiptLine("A", "X", 2m, 0m)));
            }, "agreed extended cost overflow");

            var malformedTotals = new PurchaseReceiptPreview("SUP",
                new[] { new PurchaseReceiptArticleTotal("A", "X", 1m, 2m) }, 2m, 2m);
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder, malformedTotals);
            }, "forged receipt quantity totals");
            var malformedCost = new PurchaseReceiptPreview("SUP",
                new[] { new PurchaseReceiptArticleTotal("A", "X", 1m, 2m) }, 1m, 3m);
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder, malformedCost);
            }, "forged receipt cost totals");
            var duplicateReceipt = new PurchaseReceiptPreview("SUP",
                new[] { new PurchaseReceiptArticleTotal("A", "X", 1m, 2m),
                    new PurchaseReceiptArticleTotal("A", "X", 1m, 2m) }, 2m, 4m);
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder, duplicateReceipt);
            }, "duplicate receipt IDs rejected");
            var negativeCost = new PurchaseReceiptPreview("SUP",
                new[] { new PurchaseReceiptArticleTotal("A", "X", 1m, -1m) }, 1m, -1m);
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder, negativeCost);
            }, "negative receipt cost rejected");
            var zeroReceived = new PurchaseReceiptPreview("SUP",
                new[] { new PurchaseReceiptArticleTotal("A", "X", 0m, 0m) }, 0m, 0m);
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder, zeroReceived);
            }, "zero receipt quantity rejected");
            var blankReceipt = new PurchaseReceiptPreview("SUP",
                new[] { new PurchaseReceiptArticleTotal(" ", "X", 1m, 2m) }, 1m, 2m);
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder, blankReceipt);
            }, "blank receipt ID rejected");
            var emptyReceipt = new PurchaseReceiptPreview("SUP",
                new PurchaseReceiptArticleTotal[0], 0m, 0m);
            Throws<InvalidOperationException>(delegate {
                PurchaseOrderReceiptReconciliationService.Compare("SUP", goodOrder, emptyReceipt);
            }, "empty receipt rejected");
            Console.WriteLine("PASS purchase order reconciliation: " + assertions + " assertions");
            return 0;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.ToString());
            return 1;
        }
    }
}
