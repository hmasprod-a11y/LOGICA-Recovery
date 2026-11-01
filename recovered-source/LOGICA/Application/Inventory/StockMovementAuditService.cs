using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Inventory
{
    // A read-only journal reconciliation. The caller supplies one consistent
    // baseline, movement journal and current stock snapshot; no SQL or posting.
    internal sealed class StockMovementAuditEvent
    {
        internal readonly string MovementId;
        internal readonly string ArticleId;
        internal readonly decimal QuantityDelta;

        internal StockMovementAuditEvent(string movementId, string articleId, decimal quantityDelta)
        {
            MovementId = movementId;
            ArticleId = articleId;
            QuantityDelta = quantityDelta;
        }
    }

    internal sealed class StockMovementAuditLine
    {
        internal readonly string ArticleId;
        internal readonly decimal BaselineQuantity;
        internal readonly decimal MovementDelta;
        internal readonly decimal ExpectedQuantity;
        internal readonly bool HasCurrentStock;
        internal readonly decimal CurrentQuantity;
        internal readonly decimal Difference;

        internal StockMovementAuditLine(string articleId, decimal baseline, decimal movement,
            decimal expected, bool hasCurrent, decimal current, decimal difference)
        {
            ArticleId = articleId;
            BaselineQuantity = baseline;
            MovementDelta = movement;
            ExpectedQuantity = expected;
            HasCurrentStock = hasCurrent;
            CurrentQuantity = current;
            Difference = difference;
        }

        internal bool IsMatched { get { return HasCurrentStock && Difference == 0m; } }
    }

    internal sealed class StockMovementAuditPreview
    {
        internal readonly IList<StockMovementAuditLine> Lines;
        internal readonly IList<string> UnknownMovementArticleIds;
        internal readonly IList<string> MissingCurrentArticleIds;
        internal readonly IList<string> UnexpectedCurrentArticleIds;
        internal readonly IList<string> DriftedArticleIds;

        internal StockMovementAuditPreview(IList<StockMovementAuditLine> lines,
            IList<string> unknownMovements, IList<string> missingCurrent,
            IList<string> unexpectedCurrent, IList<string> drifted)
        {
            Lines = new List<StockMovementAuditLine>(lines).AsReadOnly();
            UnknownMovementArticleIds = new List<string>(unknownMovements).AsReadOnly();
            MissingCurrentArticleIds = new List<string>(missingCurrent).AsReadOnly();
            UnexpectedCurrentArticleIds = new List<string>(unexpectedCurrent).AsReadOnly();
            DriftedArticleIds = new List<string>(drifted).AsReadOnly();
        }

        internal bool IsBalanced
        {
            get
            {
                return UnknownMovementArticleIds.Count == 0 &&
                    MissingCurrentArticleIds.Count == 0 &&
                    UnexpectedCurrentArticleIds.Count == 0 &&
                    DriftedArticleIds.Count == 0;
            }
        }
    }

    internal static class StockMovementAuditService
    {
        // Exact ID_ARTICLE and movement IDs use ordinal comparison. A missing
        // current row is NOT interpreted as zero stock. Unrecognized movements
        // and unexpected current articles are reported rather than ignored.
        internal static StockMovementAuditPreview Compare(
            IEnumerable<StockBaselineLine> baseline,
            IEnumerable<StockMovementAuditEvent> movements,
            IEnumerable<StockBaselineLine> currentStock)
        {
            if (baseline == null) throw new ArgumentNullException("baseline");
            if (movements == null) throw new ArgumentNullException("movements");
            if (currentStock == null) throw new ArgumentNullException("currentStock");

            var baselineById = new Dictionary<string, decimal>(StringComparer.Ordinal);
            var baselineOrder = new List<string>();
            foreach (StockBaselineLine row in baseline)
            {
                if (row == null || String.IsNullOrWhiteSpace(row.ArticleId))
                    throw new ArgumentException("Invalid baseline stock row.", "baseline");
                if (baselineById.ContainsKey(row.ArticleId))
                    throw new InvalidOperationException("Duplicate baseline article ID.");
                baselineById.Add(row.ArticleId, row.RecordedQuantity);
                baselineOrder.Add(row.ArticleId);
            }

            var movementIds = new HashSet<string>(StringComparer.Ordinal);
            var deltas = new Dictionary<string, decimal>(StringComparer.Ordinal);
            var unknown = new List<string>();
            var unknownSeen = new HashSet<string>(StringComparer.Ordinal);
            foreach (StockMovementAuditEvent movement in movements)
            {
                if (movement == null || String.IsNullOrWhiteSpace(movement.MovementId) ||
                    String.IsNullOrWhiteSpace(movement.ArticleId))
                    throw new ArgumentException("Invalid stock movement.", "movements");
                if (!movementIds.Add(movement.MovementId))
                    throw new InvalidOperationException("Duplicate stock movement identity.");
                if (!baselineById.ContainsKey(movement.ArticleId))
                {
                    if (unknownSeen.Add(movement.ArticleId)) unknown.Add(movement.ArticleId);
                    continue;
                }
                decimal old;
                deltas.TryGetValue(movement.ArticleId, out old);
                deltas[movement.ArticleId] = checked(old + movement.QuantityDelta);
            }

            var current = new Dictionary<string, decimal>(StringComparer.Ordinal);
            var unexpected = new List<string>();
            foreach (StockBaselineLine row in currentStock)
            {
                if (row == null || String.IsNullOrWhiteSpace(row.ArticleId))
                    throw new ArgumentException("Invalid current stock row.", "currentStock");
                if (current.ContainsKey(row.ArticleId))
                    throw new InvalidOperationException("Duplicate current article ID.");
                current.Add(row.ArticleId, row.RecordedQuantity);
                if (!baselineById.ContainsKey(row.ArticleId)) unexpected.Add(row.ArticleId);
            }

            var lines = new List<StockMovementAuditLine>();
            var missing = new List<string>();
            var drifted = new List<string>();
            foreach (string id in baselineOrder)
            {
                decimal movementDelta;
                deltas.TryGetValue(id, out movementDelta);
                decimal expected = checked(baselineById[id] + movementDelta);
                decimal actual;
                bool hasCurrent = current.TryGetValue(id, out actual);
                decimal difference = hasCurrent ? checked(actual - expected) : 0m;
                if (!hasCurrent) missing.Add(id);
                else if (difference != 0m) drifted.Add(id);
                lines.Add(new StockMovementAuditLine(id, baselineById[id], movementDelta,
                    expected, hasCurrent, actual, difference));
            }

            return new StockMovementAuditPreview(lines, unknown, missing, unexpected, drifted);
        }
    }
}
