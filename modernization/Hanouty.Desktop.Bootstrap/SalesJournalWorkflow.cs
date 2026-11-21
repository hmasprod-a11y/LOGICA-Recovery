using Hanouty.Desktop.Wpf;

namespace Hanouty.Desktop.Bootstrap;
internal sealed class SalesJournalWorkflow(SalesJournalReader reader, SalesJournalReader.Access access,
    Func<bool> active, Action<SalesJournalTicket>? reprint = null) : ISalesJournalWorkflow
{
    public bool CanStatistics => access.Statistics;
    private void Check() { if (!active()) throw new UnauthorizedAccessException("La session du journal a changé."); }
    public SalesJournalOptions Options() { Check(); return reader.Options(access); }
    public SalesJournalResult Read(SalesJournalFilter filter) { Check(); return reader.Read(access, filter); }
    public SalesJournalDetail Details(SalesJournalTicket ticket) { Check(); return reader.Details(access, ticket); }
    public void Reprint(SalesJournalTicket ticket)
    {
        Check(); var current = reader.Details(access, ticket).Ticket;
        if (!current.CanReprint || reprint is null) throw new InvalidOperationException("Réimpression de ce ticket indisponible.");
        reprint(current);
    }
}
