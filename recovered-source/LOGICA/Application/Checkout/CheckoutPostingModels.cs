using System;
using System.Collections.Generic;

namespace LOGICA.ApplicationLayer.Checkout
{
    internal sealed class TicketHeaderRecord
    {
        public string TicketId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; }
        public object ClientId { get; set; }
        public object ClientCode { get; set; }
        public string ClientName { get; set; }
        public string Workstation { get; set; }
        public string TotalText { get; set; }
        public string Operation { get; set; }
    }

    internal sealed class TicketJournalRecord
    {
        public string TicketId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string Workstation { get; set; }
        public string Cashier { get; set; }
        public string Seller { get; set; }
        public object ClientId { get; set; }
        public object ClientCode { get; set; }
        public string ClientName { get; set; }
        public string Operation { get; set; }
        public string PriceType { get; set; }
        public string PaymentModes { get; set; }
    }

    internal sealed class TicketPaymentContext
    {
        public string TicketId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string Cashier { get; set; }
        public object ClientId { get; set; }
        public object ClientCode { get; set; }
        public string ClientName { get; set; }
        public string Workstation { get; set; }
        public string Operation { get; set; }
        public string Remark { get; set; }
    }

    internal enum TicketPaymentKind { Cash, Tendered, Change }

    internal sealed class TicketPaymentWrite
    {
        public TicketPaymentKind Kind { get; set; }
        public TicketPaymentContext Context { get; set; }
        public string AmountText { get; set; }
        public object Amount { get; set; }
        public object Mode { get; set; }
    }

    internal sealed class CheckoutCompletionRecord
    {
        public string Workstation { get; set; }
        public string TicketNumber { get; set; }
    }

    // Readers run at their original stages; payment rows are read lazily between writes.
    internal sealed class CheckoutPostingInput
    {
        public Func<TicketHeaderRecord> ReadHeader { get; set; }
        public Func<TicketJournalRecord> ReadJournal { get; set; }
        public Func<IEnumerable<TicketPaymentWrite>> ReadPayments { get; set; }
        public Action Print { get; set; }
        public Func<CheckoutCompletionRecord> ReadCompletion { get; set; }
    }
}
