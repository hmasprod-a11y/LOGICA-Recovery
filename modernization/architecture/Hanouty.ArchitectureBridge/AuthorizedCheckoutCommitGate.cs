using System;

namespace Hanouty.ArchitectureBridge;

// Financial orchestration: Checkout's injected production port performs the
// durable transaction. This class never prices, writes SQL or stages cart rows.
public enum FinancialCommitOutcome { Committed, AlreadyCommitted, Unknown }

public sealed class AuthorizedCheckoutCommitGate
{
    private readonly IAuthorizedCheckoutPort _posting;
    private readonly ICheckoutOperationJournal _journal;
    private string? _uncertainId;

    public string? UncertainOperationId => _uncertainId;

    public AuthorizedCheckoutCommitGate(IAuthorizedCheckoutPort posting,
        ICheckoutOperationJournal journal)
    {
        _posting = posting ?? throw new ArgumentNullException(nameof(posting));
        _journal = journal ?? throw new ArgumentNullException(nameof(journal));
    }

    public FinancialCommitOutcome Commit(AuthorizedCheckoutRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);
        if (_uncertainId is not null)
            throw new InvalidOperationException("Financial outcome unknown; reconcile before another commit.");
        request.Validate();
        var prior = _journal.Lookup(request.OperationId);
        if (prior == CheckoutOperationOutcome.Persisted)
            return FinancialCommitOutcome.AlreadyCommitted;
        if (prior == CheckoutOperationOutcome.Unknown)
        {
            _uncertainId = request.OperationId;
            return FinancialCommitOutcome.Unknown;
        }
        try
        {
            _posting.Commit(request);
            return FinancialCommitOutcome.Committed;
        }
        catch
        {
            // Commit may have persisted before the acknowledgement was lost.
            // Never retry automatically, even when the exception looks transient.
            _uncertainId = request.OperationId;
            throw;
        }
    }

    public CheckoutOperationOutcome Reconcile(string operationId)
    {
        if (_uncertainId is null ||
            !string.Equals(_uncertainId, operationId, StringComparison.Ordinal))
            throw new InvalidOperationException("No matching uncertain financial operation.");
        var outcome = _journal.Lookup(operationId);
        if (outcome != CheckoutOperationOutcome.Unknown)
            _uncertainId = null;
        return outcome;
    }
}
