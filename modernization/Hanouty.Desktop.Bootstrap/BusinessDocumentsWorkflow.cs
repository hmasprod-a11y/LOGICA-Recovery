using Hanouty.Desktop.Wpf;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class BusinessDocumentsWorkflow(BusinessDocumentStore store, Func<bool> active, Func<string> readPin) : IBusinessDocumentsWorkflow
{
    private bool busy;
    private void Check() { if (!active() || busy) throw new InvalidOperationException("La session documentaire a changé."); }
    public IReadOnlyList<BusinessDocumentHeader> Search(BusinessDocumentKind kind, DateTime from, DateTime to, string search)
    { Check(); return store.Search(kind, from, to, search); }
    public BusinessDocumentSnapshot Read(BusinessDocumentKind kind, long rowId) { Check(); return store.Read(kind, rowId); }
    public BusinessDocumentSnapshot Validate(BusinessDocumentSnapshot reviewed)
    {
        Check(); busy = true;
        try
        {
            var pin = readPin();
            try { if (!active() || string.IsNullOrWhiteSpace(pin)) throw new UnauthorizedAccessException("Validation annulée."); return store.Validate(reviewed, pin); }
            finally { pin = ""; }
        }
        finally { busy = false; }
    }
}
