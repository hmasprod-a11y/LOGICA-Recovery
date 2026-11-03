using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Inventory
{
    // Read-only flow report over a caller-supplied, complete movement window.
    // No SQL, stock posting, costing, or assumptions about movement timestamps.
    internal sealed class StockMovementFlowLine
    {
        internal readonly string ArticleId;
        internal readonly decimal OpeningQuantity;
        internal readonly decimal ReceivedQuantity;
        internal readonly decimal IssuedQuantity;
        internal readonly decimal NetQuantity;
        internal readonly decimal ExpectedClosingQuantity;
        internal readonly bool HasActualClosingQuantity;
        internal readonly decimal ActualClosingQuantity;
        internal readonly decimal ClosingDifference;
        internal readonly int ReceiptEvents;
        internal readonly int IssueEvents;
        internal readonly int ZeroEvents;

        internal StockMovementFlowLine(StockMovementAuditLine audit, decimal received,
            decimal issued, int receipts, int issues, int zero)
        {
            ArticleId = audit.ArticleId;
            OpeningQuantity = audit.BaselineQuantity;
            ReceivedQuantity = received;
            IssuedQuantity = issued;
            NetQuantity = checked(received - issued);
            ExpectedClosingQuantity = audit.ExpectedQuantity;
            HasActualClosingQuantity = audit.HasCurrentStock;
            ActualClosingQuantity = audit.CurrentQuantity;
            ClosingDifference = audit.Difference;
            ReceiptEvents = receipts;
            IssueEvents = issues;
            ZeroEvents = zero;
            if (NetQuantity != audit.MovementDelta)
                throw new InvalidOperationException("Movement flow and audit delta disagree.");
        }

        internal bool IsMatched { get { return HasActualClosingQuantity && ClosingDifference == 0m; } }
    }

    internal sealed class StockMovementFlowReport
    {
        internal readonly IList<StockMovementFlowLine> Lines;
        internal readonly StockMovementAuditPreview Audit;
        internal readonly decimal TotalReceived;
        internal readonly decimal TotalIssued;
        internal readonly decimal TotalNetQuantity;
        internal readonly int KnownMovementEvents;

        internal StockMovementFlowReport(IList<StockMovementFlowLine> lines,
            StockMovementAuditPreview audit, decimal received, decimal issued, int events)
        {
            Lines = new List<StockMovementFlowLine>(lines).AsReadOnly();
            Audit = audit;
            TotalReceived = received;
            TotalIssued = issued;
            TotalNetQuantity = checked(received - issued);
            KnownMovementEvents = events;
        }

        // A report with unknown journal articles or missing/unexpected closing
        // stock is never considered reconciled, even when known rows balance.
        internal bool IsReconciled { get { return Audit.IsBalanced; } }
    }

    internal static class StockMovementFlowReportService
    {
        private sealed class Flow
        {
            internal decimal Received;
            internal decimal Issued;
            internal int Receipts;
            internal int Issues;
            internal int Zero;
        }

        internal static StockMovementFlowReport Summarize(
            IEnumerable<StockBaselineLine> opening,
            IEnumerable<StockMovementAuditEvent> journal,
            IEnumerable<StockBaselineLine> closing)
        {
            if (opening == null) throw new ArgumentNullException("opening");
            if (journal == null) throw new ArgumentNullException("journal");
            if (closing == null) throw new ArgumentNullException("closing");

            // Materialize a one-shot journal exactly once. The audit validates
            // every identity before any report is returned.
            var events = new List<StockMovementAuditEvent>();
            foreach (StockMovementAuditEvent movement in journal) events.Add(movement);
            StockMovementAuditPreview audit = StockMovementAuditService.Compare(opening, events, closing);

            var byId = new Dictionary<string, Flow>(StringComparer.Ordinal);
            foreach (StockMovementAuditLine line in audit.Lines)
                byId.Add(line.ArticleId, new Flow());

            int knownEvents = 0;
            foreach (StockMovementAuditEvent movement in events)
            {
                Flow flow;
                if (!byId.TryGetValue(movement.ArticleId, out flow))
                    continue; // Unknown IDs remain visible in Audit, never counted as known flow.
                knownEvents = checked(knownEvents + 1);
                if (movement.QuantityDelta > 0m)
                {
                    flow.Received = checked(flow.Received + movement.QuantityDelta);
                    flow.Receipts = checked(flow.Receipts + 1);
                }
                else if (movement.QuantityDelta < 0m)
                {
                    flow.Issued = checked(flow.Issued - movement.QuantityDelta);
                    flow.Issues = checked(flow.Issues + 1);
                }
                else flow.Zero = checked(flow.Zero + 1);
            }

            var lines = new List<StockMovementFlowLine>();
            decimal totalReceived = 0m;
            decimal totalIssued = 0m;
            foreach (StockMovementAuditLine audited in audit.Lines)
            {
                Flow flow = byId[audited.ArticleId];
                lines.Add(new StockMovementFlowLine(audited, flow.Received,
                    flow.Issued, flow.Receipts, flow.Issues, flow.Zero));
                totalReceived = checked(totalReceived + flow.Received);
                totalIssued = checked(totalIssued + flow.Issued);
            }
            return new StockMovementFlowReport(lines, audit, totalReceived, totalIssued, knownEvents);
        }
    }
}
