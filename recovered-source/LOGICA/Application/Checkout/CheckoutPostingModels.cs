using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Checkout
{
    internal sealed class TicketHeaderRecord
    {
        public string TicketId { get; set; } = string.Empty;
        public string TicketNumber { get; set; } = string.Empty;
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; } = string.Empty;
        public object ClientId { get; set; } = DBNull.Value;
        public object ClientCode { get; set; } = DBNull.Value;
        public string ClientName { get; set; } = string.Empty;
        public string Workstation { get; set; } = string.Empty;
        public string TotalText { get; set; } = string.Empty;
        public string Operation { get; set; } = string.Empty;
    }

    internal sealed class TicketJournalRecord
    {
        public string TicketId { get; set; } = string.Empty;
        public string TicketNumber { get; set; } = string.Empty;
        public DateTime SaleDate { get; set; }
        public string Workstation { get; set; } = string.Empty;
        public string Cashier { get; set; } = string.Empty;
        public string Seller { get; set; } = string.Empty;
        public object ClientId { get; set; } = DBNull.Value;
        public object ClientCode { get; set; } = DBNull.Value;
        public string ClientName { get; set; } = string.Empty;
        public string Operation { get; set; } = string.Empty;
        public string PriceType { get; set; } = string.Empty;
        public string PaymentModes { get; set; } = string.Empty;
    }

    internal sealed class TicketPaymentContext
    {
        public string TicketId { get; set; } = string.Empty;
        public string TicketNumber { get; set; } = string.Empty;
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; } = string.Empty;
        public object ClientId { get; set; } = DBNull.Value;
        public object ClientCode { get; set; } = DBNull.Value;
        public string ClientName { get; set; } = string.Empty;
        public string Workstation { get; set; } = string.Empty;
        public string Operation { get; set; } = string.Empty;
        public string Remark { get; set; } = string.Empty;
    }

    internal sealed class CheckoutStockLine
    {
        public string TicketNumber { get; set; } = string.Empty;
        public object ArticleId { get; set; } = DBNull.Value;
        public object ArticleCode { get; set; } = DBNull.Value;
        public object ArticleName { get; set; } = DBNull.Value;
        public object BasketQuantity { get; set; } = DBNull.Value;
    }

    internal enum TicketPaymentKind { Cash, Tendered, Change }

    internal sealed class TicketPaymentWrite
    {
        public TicketPaymentKind Kind { get; set; }
        public TicketPaymentContext Context { get; set; } = new TicketPaymentContext();
        public string AmountText { get; set; } = string.Empty;
        public object Amount { get; set; } = DBNull.Value;
        public object Mode { get; set; } = DBNull.Value;
    }

    internal sealed class CheckoutCompletionRecord
    {
        public string Workstation { get; set; } = string.Empty;
        public string TicketNumber { get; set; } = string.Empty;
    }

    // Readers run at their original stages; payment rows are read lazily between writes.
    internal sealed class CheckoutPostingInput
    {
        public Func<IEnumerable<CheckoutStockLine>> ReadStock { get; set; } = () => throw new InvalidOperationException("Checkout posting reader is not configured.");
        public Func<TicketHeaderRecord> ReadHeader { get; set; } = () => throw new InvalidOperationException("Checkout posting reader is not configured.");
        public Func<TicketJournalRecord> ReadJournal { get; set; } = () => throw new InvalidOperationException("Checkout posting reader is not configured.");
        public Func<IEnumerable<TicketPaymentWrite>> ReadPayments { get; set; } = () => throw new InvalidOperationException("Checkout posting reader is not configured.");
        public Action Print { get; set; } = () => throw new InvalidOperationException("Checkout posting action is not configured.");
        public Func<CheckoutCompletionRecord> ReadCompletion { get; set; } = () => throw new InvalidOperationException("Checkout posting reader is not configured.");
    }
}
