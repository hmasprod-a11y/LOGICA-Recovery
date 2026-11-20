namespace Hanouty.Desktop.Wpf;

public enum BusinessDocumentKind { Devis, BonLivraison, Facture }
public sealed record BusinessDocumentHeader(long RowId, string Number, DateTime Date, string CustomerId,
    string CustomerCode, string Customer, string Actor, string Notes, string State,
    decimal TotalHt, decimal TotalTax, decimal TotalTtc, decimal Discount);
public sealed record BusinessDocumentLine(long RowId, string ArticleId, string Code, string Article,
    decimal UnitTtc, decimal TaxRate, decimal UnitHt, decimal Quantity,
    decimal TotalTtc, decimal TotalTax, decimal TotalHt, decimal DiscountRate, string State);
public sealed record BusinessDocumentSnapshot(BusinessDocumentKind Kind, BusinessDocumentHeader Header,
    IReadOnlyList<BusinessDocumentLine> Lines, string CustomerName, string CustomerIce, string CustomerAddress, string Revision);
public interface IBusinessDocumentsWorkflow
{
    IReadOnlyList<BusinessDocumentHeader> Search(BusinessDocumentKind kind, DateTime from, DateTime to, string search);
    BusinessDocumentSnapshot Read(BusinessDocumentKind kind, long rowId);
    BusinessDocumentSnapshot Validate(BusinessDocumentSnapshot reviewed);
}
