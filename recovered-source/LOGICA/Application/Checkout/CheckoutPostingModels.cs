using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Checkout
{
    internal sealed class TicketHeaderRecord
    {
        // Null-forgiving defaults preserve legacy runtime values while keeping the modern bridge warning-clean.
        // CheckoutPostingService.Validate and the writers enforce the required fields before persistence.
        public string TicketId { get; set; } = null!;
        public string TicketNumber { get; set; } = null!;
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; } = null!;
        public object ClientId { get; set; } = null!;
        public object ClientCode { get; set; } = null!;
        public string ClientName { get; set; } = null!;
        public string Workstation { get; set; } = null!;
        public string TotalText { get; set; } = null!;
        public string Operation { get; set; } = null!;
    }

    internal sealed class TicketJournalRecord
    {
        public string TicketId { get; set; } = null!;
        public string TicketNumber { get; set; } = null!;
        public DateTime SaleDate { get; set; }
        public string Workstation { get; set; } = null!;
        public string Cashier { get; set; } = null!;
        public string Seller { get; set; } = null!;
        public object ClientId { get; set; } = null!;
        public object ClientCode { get; set; } = null!;
        public string ClientName { get; set; } = null!;
        public string Operation { get; set; } = null!;
        public string PriceType { get; set; } = null!;
        public string PaymentModes { get; set; } = null!;
    }

    internal sealed class TicketPaymentContext
    {
        public string TicketId { get; set; } = null!;
        public string TicketNumber { get; set; } = null!;
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; } = null!;
        public object ClientId { get; set; } = null!;
        public object ClientCode { get; set; } = null!;
        public string ClientName { get; set; } = null!;
        public string Workstation { get; set; } = null!;
        public string Operation { get; set; } = null!;
        public string Remark { get; set; } = null!;
    }

    internal sealed class CheckoutStockLine
    {
        public string TicketNumber { get; set; } = null!;
        public object ArticleId { get; set; } = null!;
        public object ArticleCode { get; set; } = null!;
        public object ArticleName { get; set; } = null!;
        public object BasketQuantity { get; set; } = null!;
    }

    internal enum TicketPaymentKind { Cash, Tendered, Change }

    internal sealed class TicketPaymentWrite
    {
        public TicketPaymentKind Kind { get; set; }
        public TicketPaymentContext Context { get; set; } = null!;
        public string AmountText { get; set; } = null!;
        public object Amount { get; set; } = null!;
        public object Mode { get; set; } = null!;
    }

    internal sealed class CheckoutCompletionRecord
    {
        public string Workstation { get; set; } = null!;
        public string TicketNumber { get; set; } = null!;
    }

    // Readers run at their original stages; payment rows are read lazily between writes.
    internal sealed class CheckoutPostingInput
    {
        public Func<IEnumerable<CheckoutStockLine>> ReadStock { get; set; } = null!;
        public Func<TicketHeaderRecord> ReadHeader { get; set; } = null!;
        public Func<TicketJournalRecord> ReadJournal { get; set; } = null!;
        public Func<IEnumerable<TicketPaymentWrite>> ReadPayments { get; set; } = null!;
        public Action Print { get; set; } = null!;
        public Func<CheckoutCompletionRecord> ReadCompletion { get; set; } = null!;
    }
}
