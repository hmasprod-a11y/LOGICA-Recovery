namespace Hanouty.Desktop.Wpf;

public sealed record CustomerFileDraft(string Code, string Name, DateTime Date, string Ice, string Address,
    string City, string Country, string Telephone, string Notes, string Seller, decimal OpeningCredit);
public sealed record CustomerFile(long RowId, string Id, CustomerFileDraft Details);
public sealed record CustomerOpeningHistory(long Id, DateTime Date, string Time, string Actor, string CustomerId,
    string Customer, decimal Previous, decimal Current);
public sealed record CustomerFileCommand(string OperationId, string Kind, CustomerFile? Expected,
    CustomerFileDraft? Draft = null, decimal? OpeningCredit = null);

public interface ICustomerFilesWorkflow : IDisposable
{
    CustomerFileCommand? Pending { get; }
    IReadOnlyList<CustomerFile> Search(string query);
    IReadOnlyList<CustomerOpeningHistory> History(string customerId);
    IReadOnlyList<string> Sellers();
    CustomerFile Execute(CustomerFileCommand command);
}
public sealed class CustomerFileWriteRefusedException(string message, Exception? inner = null) : InvalidOperationException(message, inner);
