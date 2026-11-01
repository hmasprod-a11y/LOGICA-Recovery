using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Purchasing
{
    // Read-only purchase order / received goods comparison. No SQL, inventory
    // posting, price changes or authorization to receive goods.
    internal sealed class PurchaseOrderLine
    {
        internal readonly string ArticleId;
        internal readonly string Barcode;
        internal readonly decimal OrderedQuantity;
        internal readonly decimal AgreedUnitCost;

        internal PurchaseOrderLine(string articleId, string barcode, decimal orderedQuantity,
            decimal agreedUnitCost)
        {
            ArticleId = articleId;
            Barcode = barcode;
            OrderedQuantity = orderedQuantity;
            AgreedUnitCost = agreedUnitCost;
        }
    }

    internal sealed class PurchaseOrderReceiptReconciliationLine
    {
        internal readonly string ArticleId;
        internal readonly string Barcode;
        internal readonly decimal OrderedQuantity;
        internal readonly decimal ReceivedQuantity;
        internal readonly decimal RemainingQuantity;
        internal readonly decimal AgreedUnitCost;
        internal readonly decimal ExpectedCostOfReceived;
        internal readonly decimal ActualReceivedCost;
        internal readonly decimal CostVariance;

        internal PurchaseOrderReceiptReconciliationLine(string id, string barcode,
            decimal ordered, decimal received, decimal agreedCost,
            decimal expectedCost, decimal actualCost)
        {
            ArticleId = id;
            Barcode = barcode;
            OrderedQuantity = ordered;
            ReceivedQuantity = received;
            RemainingQuantity = checked(ordered - received);
            AgreedUnitCost = agreedCost;
            ExpectedCostOfReceived = expectedCost;
            ActualReceivedCost = actualCost;
            CostVariance = checked(actualCost - expectedCost);
        }

        internal bool IsOverReceived { get { return RemainingQuantity < 0m; } }
        internal bool HasCostVariance { get { return CostVariance != 0m; } }
    }

    internal sealed class PurchaseOrderReceiptReconciliationPreview
    {
        internal readonly string SupplierId;
        internal readonly IList<PurchaseOrderReceiptReconciliationLine> Lines;
        internal readonly IList<string> UnexpectedReceivedArticleIds;
        internal readonly decimal TotalOrderedQuantity;
        internal readonly decimal TotalReceivedQuantity;
        // Expected cost excludes unexpected articles; actual cost includes them.
        internal readonly decimal TotalExpectedCostOfMatchedReceipts;
        internal readonly decimal TotalActualReceivedCost;

        internal PurchaseOrderReceiptReconciliationPreview(string supplierId,
            IList<PurchaseOrderReceiptReconciliationLine> lines, IList<string> unexpected,
            decimal totalOrdered, decimal totalReceived, decimal expected, decimal actual)
        {
            SupplierId = supplierId;
            Lines = new List<PurchaseOrderReceiptReconciliationLine>(lines).AsReadOnly();
            UnexpectedReceivedArticleIds = new List<string>(unexpected).AsReadOnly();
            TotalOrderedQuantity = totalOrdered;
            TotalReceivedQuantity = totalReceived;
            TotalExpectedCostOfMatchedReceipts = expected;
            TotalActualReceivedCost = actual;
        }

        internal bool IsQuantityComplete
        {
            get
            {
                if (UnexpectedReceivedArticleIds.Count != 0) return false;
                foreach (PurchaseOrderReceiptReconciliationLine line in Lines)
                    if (line.RemainingQuantity != 0m) return false;
                return true;
            }
        }

        internal bool HasDiscrepancies
        {
            get
            {
                if (!IsQuantityComplete) return true;
                foreach (PurchaseOrderReceiptReconciliationLine line in Lines)
                    if (line.HasCostVariance) return true;
                return false;
            }
        }
    }

    internal static class PurchaseOrderReceiptReconciliationService
    {
        private sealed class OrderedAggregate
        {
            internal readonly string ArticleId;
            internal readonly string Barcode;
            internal readonly decimal AgreedUnitCost;
            internal decimal Quantity;

            internal OrderedAggregate(PurchaseOrderLine line)
            {
                ArticleId = line.ArticleId;
                Barcode = line.Barcode;
                AgreedUnitCost = line.AgreedUnitCost;
                Quantity = line.OrderedQuantity;
            }
        }

        // Exact ID_ARTICLE is the identity, NOT barcode. Partial deliveries are
        // diagnostic rather than silently treated as zero or completed orders.
        // A future MariaDB integration must revalidate under its own transaction.
        internal static PurchaseOrderReceiptReconciliationPreview Compare(
            string supplierId, IEnumerable<PurchaseOrderLine> orderedLines,
            PurchaseReceiptPreview receipt)
        {
            if (String.IsNullOrWhiteSpace(supplierId))
                throw new ArgumentException("Order supplier ID is required.", "supplierId");
            if (orderedLines == null) throw new ArgumentNullException("orderedLines");
            if (receipt == null) throw new ArgumentNullException("receipt");
            if (!String.Equals(supplierId, receipt.SupplierId, StringComparison.Ordinal))
                throw new InvalidOperationException("Order and receipt suppliers differ.");

            var ordered = new Dictionary<string, OrderedAggregate>(StringComparer.Ordinal);
            var order = new List<string>();
            decimal totalOrdered = 0m;
            foreach (PurchaseOrderLine line in orderedLines)
            {
                if (line == null || String.IsNullOrWhiteSpace(line.ArticleId))
                    throw new ArgumentException("Invalid purchase order line.", "orderedLines");
                if (line.OrderedQuantity <= 0m || line.AgreedUnitCost < 0m)
                    throw new ArgumentOutOfRangeException("orderedLines",
                        "Ordered quantity must be positive and agreed cost nonnegative.");
                OrderedAggregate existing;
                if (ordered.TryGetValue(line.ArticleId, out existing))
                {
                    if (!String.Equals(existing.Barcode, line.Barcode, StringComparison.Ordinal) ||
                        existing.AgreedUnitCost != line.AgreedUnitCost)
                        throw new InvalidOperationException(
                            "One ordered article ID has conflicting barcode or unit cost.");
                    existing.Quantity = checked(existing.Quantity + line.OrderedQuantity);
                }
                else
                {
                    ordered.Add(line.ArticleId, new OrderedAggregate(line));
                    order.Add(line.ArticleId);
                }
                totalOrdered = checked(totalOrdered + line.OrderedQuantity);
            }
            if (order.Count == 0)
                throw new ArgumentException("Purchase order must contain an article.", "orderedLines");

            // Validate the entire receipt before comparing any order line. These
            // objects are internal and could otherwise be constructed inconsistently.
            if (receipt.Articles == null || receipt.Articles.Count == 0)
                throw new InvalidOperationException("Receipt has no articles.");
            var received = new Dictionary<string, PurchaseReceiptArticleTotal>(StringComparer.Ordinal);
            var receivedOrder = new List<string>();
            decimal totalReceived = 0m;
            decimal totalCost = 0m;
            foreach (PurchaseReceiptArticleTotal line in receipt.Articles)
            {
                if (line == null || String.IsNullOrWhiteSpace(line.ArticleId) ||
                    line.Quantity <= 0m || line.ExtendedCost < 0m)
                    throw new InvalidOperationException("Receipt contains invalid article totals.");
                if (received.ContainsKey(line.ArticleId))
                    throw new InvalidOperationException("Receipt contains duplicate article IDs.");
                received.Add(line.ArticleId, line);
                receivedOrder.Add(line.ArticleId);
                totalReceived = checked(totalReceived + line.Quantity);
                totalCost = checked(totalCost + line.ExtendedCost);
            }
            if (totalReceived != receipt.TotalQuantity || totalCost != receipt.TotalCost)
                throw new InvalidOperationException("Receipt aggregate totals are inconsistent.");

            var lines = new List<PurchaseOrderReceiptReconciliationLine>();
            decimal expectedTotal = 0m;
            foreach (string id in order)
            {
                OrderedAggregate planned = ordered[id];
                PurchaseReceiptArticleTotal actual;
                bool present = received.TryGetValue(id, out actual);
                if (present && !String.Equals(planned.Barcode, actual.Barcode, StringComparison.Ordinal))
                    throw new InvalidOperationException("Ordered article barcode changed.");
                decimal quantity = present ? actual.Quantity : 0m;
                decimal cost = present ? actual.ExtendedCost : 0m;
                decimal expected = checked(quantity * planned.AgreedUnitCost);
                expectedTotal = checked(expectedTotal + expected);
                lines.Add(new PurchaseOrderReceiptReconciliationLine(id, planned.Barcode,
                    planned.Quantity, quantity, planned.AgreedUnitCost, expected, cost));
            }

            var unexpected = new List<string>();
            foreach (string id in receivedOrder)
                if (!ordered.ContainsKey(id)) unexpected.Add(id);
            return new PurchaseOrderReceiptReconciliationPreview(supplierId, lines,
                unexpected, totalOrdered, totalReceived, expectedTotal, totalCost);
        }
    }
}
