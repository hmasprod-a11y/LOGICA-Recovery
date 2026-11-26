using System;
using System.Collections.Generic;

namespace Hanouty.Architecture.Cashbox;

// Pure state contract only. Checkout, returns and expenses keep ownership of
// their durable transactions; this type must never be used as a posting engine.
public enum CashboxPhase { Closed, Open, ReconciliationRequired }

public enum CashboxEntryKind
{
    SaleCash, SaleCard, ReturnCash, ReturnCard,
    CustomerSettlementCash, CustomerSettlementCard, ExpenseCash
}

public sealed record CashboxEntry(string OperationId, CashboxEntryKind Kind, decimal Amount);

public sealed record CashboxClosePreview(string SessionId, decimal ExpectedCash, decimal CountedCash, decimal Difference);

// Host/WPF can render this read-only state without accessing mutable journal internals.
public sealed record CashboxStatus(string? SessionId, CashboxPhase Phase, decimal OpeningCash,
    decimal ExpectedCash, int PersistedOperationCount);

public sealed class CashboxLifecycle
{
    private readonly HashSet<string> _operations = new(StringComparer.Ordinal);
    private readonly HashSet<string> _usedSessionIds = new(StringComparer.Ordinal);
    private readonly List<CashboxEntry> _entries = new();
    private decimal _openingCash;
    private string? _sessionId;

    public CashboxPhase Phase { get; private set; } = CashboxPhase.Closed;
    public string? SessionId => _sessionId;
    public IReadOnlyList<CashboxEntry> Entries => _entries.AsReadOnly();
    public decimal ExpectedCash { get; private set; }

    public CashboxStatus GetStatus() => new(_sessionId, Phase, _openingCash,
        ExpectedCash, _entries.Count);

    public void Open(string sessionId, decimal openingCash)
    {
        if (Phase != CashboxPhase.Closed)
            throw new InvalidOperationException("Close the current cashbox before opening another.");
        if (string.IsNullOrWhiteSpace(sessionId))
            throw new ArgumentException("Session identity required.", nameof(sessionId));
        if (openingCash < 0m)
            throw new ArgumentOutOfRangeException(nameof(openingCash));
        // Reopening a previously closed identity would mix independent cashbox journals.
        if (!_usedSessionIds.Add(sessionId))
            throw new InvalidOperationException("Cashbox session identity already used.");
        _sessionId = sessionId;
        _openingCash = openingCash;
        ExpectedCash = openingCash;
        _operations.Clear();
        _entries.Clear();
        Phase = CashboxPhase.Open;
    }

    // Only invoke after the authoritative journal confirms durable persistence.
    // Unknown outcomes MUST NOT be recorded as posted or retried here.
    public void RecordPersisted(CashboxEntry entry)
    {
        if (Phase != CashboxPhase.Open)
            throw new InvalidOperationException("Cashbox is not ready for posting.");
        ArgumentNullException.ThrowIfNull(entry);
        if (string.IsNullOrWhiteSpace(entry.OperationId) || entry.Amount <= 0m)
            throw new ArgumentException("A positive amount and durable operation identity are required.");
        if (!Enum.IsDefined(entry.Kind))
            throw new ArgumentOutOfRangeException(nameof(entry));
        if (!_operations.Add(entry.OperationId))
            throw new InvalidOperationException("Operation already recorded in this cashbox.");
        try
        {
            var signedCash = entry.Kind switch
            {
                CashboxEntryKind.SaleCash or CashboxEntryKind.CustomerSettlementCash => entry.Amount,
                CashboxEntryKind.ReturnCash or CashboxEntryKind.ExpenseCash => -entry.Amount,
                _ => 0m
            };
            var next = checked(ExpectedCash + signedCash);
            _entries.Add(entry);
            ExpectedCash = next;
        }
        catch
        {
            _operations.Remove(entry.OperationId);
            throw;
        }
    }

    public void MarkOutcomeUnknown()
    {
        if (Phase != CashboxPhase.Open)
            throw new InvalidOperationException("No open cashbox.");
        Phase = CashboxPhase.ReconciliationRequired;
    }

    // The caller must verify the durable operation journal before unlocking.
    public void ConfirmJournalReconciled(bool allOutcomesResolved)
    {
        if (Phase != CashboxPhase.ReconciliationRequired)
            throw new InvalidOperationException("No reconciliation is pending.");
        if (!allOutcomesResolved)
            throw new InvalidOperationException("Unresolved financial outcome.");
        Phase = CashboxPhase.Open;
    }

    // Read-only close preview for the Host/UI; never changes the session state.
    public CashboxClosePreview PreviewClose(decimal countedCash)
    {
        if (Phase != CashboxPhase.Open)
            throw new InvalidOperationException("Cashbox cannot close while outcomes are unresolved.");
        if (countedCash < 0m)
            throw new ArgumentOutOfRangeException(nameof(countedCash));
        // Overflow must not silently corrupt the closing variance or close the session.
        var difference = checked(countedCash - ExpectedCash);
        return new CashboxClosePreview(_sessionId!, ExpectedCash, countedCash, difference);
    }

    // Safer close entry point for adapters with a complete durable journal readback.
    // The caller must fetch the journal in a consistent database snapshot and
    // independently establish that no unresolved outcomes remain. No mutation
    // happens when exact replay, totals or the current phase disagree.
    // Read-only UI preview backed by the exact durable journal, not merely
    // by the in-memory cash balance. Host must supply a consistent snapshot.
    public CashboxClosePreview PreviewCloseVerified(
        IEnumerable<CashboxEntry> persistedEntries, decimal countedCash)
    {
        return CashboxJournalReplay.VerifyCloseExact(
            GetStatus(), Entries, persistedEntries, countedCash);
    }

    public CashboxClosePreview CloseVerified(
        IEnumerable<CashboxEntry> persistedEntries, decimal countedCash)
    {
        var preview = CashboxJournalReplay.VerifyCloseExact(
            GetStatus(), Entries, persistedEntries, countedCash);
        // Verification and close must be serialized by the Host against posting.
        Close(countedCash);
        return preview;
    }

    public decimal Close(decimal countedCash)
    {
        var preview = PreviewClose(countedCash);
        Phase = CashboxPhase.Closed;
        _sessionId = null;
        return preview.Difference;
    }
}
