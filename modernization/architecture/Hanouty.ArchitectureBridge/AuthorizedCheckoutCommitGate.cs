using System;
using System.Linq;

namespace Hanouty.ArchitectureBridge;

// Financial orchestration: Checkout's injected production port performs the
// durable transaction. This class never prices, writes SQL or stages cart rows.
public enum FinancialCommitOutcome { Committed, AlreadyCommitted, Unknown }

public sealed class AuthorizedCheckoutCommitGate
{
    private readonly IAuthorizedCheckoutPort _posting;
    private readonly ICheckoutOperationJournal _journal;
    private string? _uncertainId;
    private bool _committing;
    private readonly object _sync = new();

    public string? UncertainOperationId
    {
        get { lock (_sync) return _uncertainId; }
    }

    public AuthorizedCheckoutCommitGate(IAuthorizedCheckoutPort posting,
        ICheckoutOperationJournal journal)
    {
        _posting = posting ?? throw new ArgumentNullException(nameof(posting));
        _journal = journal ?? throw new ArgumentNullException(nameof(journal));
    }

    public FinancialCommitOutcome Commit(AuthorizedCheckoutRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);
        lock (_sync)
        {
            if (_committing)
                throw new InvalidOperationException("Financial commit already in progress.");
            if (_uncertainId is not null)
                throw new InvalidOperationException("Financial outcome unknown; reconcile before another commit.");
            _committing = true;
        }
        try
        {
            // Freeze caller-owned mutable line/payment lists before any asynchronous
            // infrastructure boundary. The validated envelope is exactly the one posted.
            var snapshot = request with
            {
                Lines = Array.AsReadOnly(request.Lines?.ToArray() ?? Array.Empty<CheckoutBatchLine>()),
                Payments = Array.AsReadOnly(request.Payments?.ToArray() ?? Array.Empty<CheckoutPayment>())
            };
            snapshot.Validate();
            CheckoutOperationOutcome prior;
            try { prior = _journal.Lookup(snapshot.OperationId); }
            catch
            {
                lock (_sync) _uncertainId = snapshot.OperationId;
                throw;
            }
            // Reject invalid journal states; they cannot authorize a new write.
            if (!Enum.IsDefined(prior))
            {
                lock (_sync) _uncertainId = request.OperationId;
                throw new InvalidOperationException("Durable checkout journal returned an unsupported outcome.");
            }
            if (prior == CheckoutOperationOutcome.Persisted)
                return FinancialCommitOutcome.AlreadyCommitted;
            if (prior == CheckoutOperationOutcome.Unknown)
            {
                lock (_sync) _uncertainId = request.OperationId;
                return FinancialCommitOutcome.Unknown;
            }
            try
            {
                _posting.Commit(snapshot);
                // A returning port is not proof that the durable operation was
                // persisted. Verify against the same authoritative journal;
                // absence/uncertainty after acknowledgement must fail closed.
                CheckoutOperationOutcome confirmed;
                try { confirmed = _journal.Lookup(request.OperationId); }
                catch
                {
                    lock (_sync) _uncertainId = request.OperationId;
                    throw;
                }
                if (confirmed != CheckoutOperationOutcome.Persisted)
                {
                    lock (_sync) _uncertainId = request.OperationId;
                    return FinancialCommitOutcome.Unknown;
                }
                return FinancialCommitOutcome.Committed;
            }
            catch
            {
                lock (_sync) _uncertainId = request.OperationId;
                throw;
            }
        }
        finally
        {
            lock (_sync) _committing = false;
        }
    }

    public CheckoutOperationOutcome Reconcile(string operationId)
    {
        lock (_sync)
        {
            if (_committing)
                throw new InvalidOperationException("Financial commit already in progress.");
            if (_uncertainId is null ||
                !string.Equals(_uncertainId, operationId, StringComparison.Ordinal))
                throw new InvalidOperationException("No matching uncertain financial operation.");
            // Hold the gate while querying the durable journal: no competing
            // submission can start between reconciliation and state transition.
            var outcome = _journal.Lookup(operationId);
            if (!Enum.IsDefined(outcome))
                throw new InvalidOperationException("Durable checkout journal returned an unsupported outcome.");
            if (outcome != CheckoutOperationOutcome.Unknown)
                _uncertainId = null;
            return outcome;
        }
    }
}
