using System;

namespace LOGICA.Application.Inventory
{
    // Pure domain plan: no WinForms, SQL, clock, or implicit stock mutation.
    // Infrastructure must lock the article row and recheck BeforeStock inside
    // the SAME InnoDB transaction as the stock UPDATE and movement INSERT.
    internal sealed class StockAdjustmentPlan
    {
        internal string ArticleId { get; private set; }
        internal decimal BeforeStock { get; private set; }
        internal decimal AfterStock { get; private set; }
        internal decimal Delta { get { return AfterStock - BeforeStock; } }
        internal string Reason { get; private set; }
        internal string UserId { get; private set; }

        private StockAdjustmentPlan(string articleId, decimal beforeStock,
            decimal afterStock, string reason, string userId)
        {
            ArticleId = articleId;
            BeforeStock = beforeStock;
            AfterStock = afterStock;
            Reason = reason;
            UserId = userId;
        }

        private static bool ContainsControlCharacter(string value)
        {
            foreach (char character in value)
                if (Char.IsControl(character)) return true;
            return false;
        }

        internal static StockAdjustmentPlan Create(string articleId, decimal beforeStock,
            decimal afterStock, string reason, string userId)
        {
            if (String.IsNullOrWhiteSpace(articleId))
                throw new ArgumentException("Article identity is required.", "articleId");
            if (String.IsNullOrWhiteSpace(reason))
                throw new ArgumentException("A stock adjustment reason is required.", "reason");
            if (String.IsNullOrWhiteSpace(userId))
                throw new ArgumentException("A stock adjustment user is required.", "userId");
            if (ContainsControlCharacter(articleId) || ContainsControlCharacter(reason) ||
                ContainsControlCharacter(userId))
                throw new ArgumentException("Stock adjustment identity and audit fields must not contain control characters.");
            if (beforeStock < 0m || afterStock < 0m)
                throw new ArgumentOutOfRangeException("afterStock", "Stock cannot be negative.");
            if (beforeStock == afterStock)
                throw new ArgumentException("No-op adjustments must not create movements.", "afterStock");
            return new StockAdjustmentPlan(articleId.Trim(), beforeStock, afterStock,
                reason.Trim(), userId.Trim());
        }
    }
}
