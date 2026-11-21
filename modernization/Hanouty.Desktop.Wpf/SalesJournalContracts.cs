namespace Hanouty.Desktop.Wpf;

public sealed record SalesJournalFilter(DateTime From, DateTime To, string Cashier = "", string Mode = "", string Operation = "", string Search = "");
public sealed record SalesJournalOptions(IReadOnlyList<string> Cashiers, IReadOnlyList<string> Modes, IReadOnlyList<string> Operations);
public sealed record SalesJournalTicket(string Id, string Number, DateTime Date, string Cashier, string Register,
    string Operation, string Customer, decimal Total, decimal Quantity, string Modes, bool CanReprint);
public sealed record SalesJournalLine(string ArticleId, string Code, string Article, string Family, decimal Quantity,
    decimal UnitPrice, decimal Discount, decimal Net, string Operation);
public sealed record SalesJournalPayment(string Mode, decimal Amount, string Operation);
public sealed record SalesJournalDetail(SalesJournalTicket Ticket, IReadOnlyList<SalesJournalLine> Lines, IReadOnlyList<SalesJournalPayment> Payments);
public sealed record SalesJournalTotals(int Tickets, decimal Sales, decimal Returns, decimal CreditSales, decimal CreditReturns, decimal Quantity)
{
    public decimal PaidNet => Sales + Returns;
    public decimal CreditNet => CreditSales + CreditReturns;
}
public sealed record SalesJournalPaymentTotal(string Mode, decimal Amount);
public sealed record SalesJournalDaily(DateTime Date, decimal Sales, decimal Returns, decimal CreditSales, decimal CreditReturns, decimal Quantity)
{
    public decimal PaidNet => Sales + Returns;
    public decimal CreditNet => CreditSales + CreditReturns;
}
public sealed record SalesJournalCashier(string Cashier, decimal PaidNet, decimal CreditNet, decimal Quantity);
public sealed record SalesJournalResult(IReadOnlyList<SalesJournalTicket> Tickets, SalesJournalTotals Totals,
    IReadOnlyList<SalesJournalPaymentTotal> Payments, IReadOnlyList<SalesJournalDaily> Days, IReadOnlyList<SalesJournalCashier> Cashiers)
{
    public decimal PaidPaymentGap => Totals.PaidNet - Payments.Sum(row => row.Amount);
}
public interface ISalesJournalWorkflow
{
    bool CanStatistics { get; }
    SalesJournalOptions Options();
    SalesJournalResult Read(SalesJournalFilter filter);
    SalesJournalDetail Details(SalesJournalTicket ticket);
    void Reprint(SalesJournalTicket ticket);
}
