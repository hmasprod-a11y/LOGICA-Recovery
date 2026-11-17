using System;
using System.Collections.Generic;

namespace Hanouty.Architecture.Cashbox;

// A read-only replay of durable journal rows. This does not authorize unlocking:
// the persistence adapter must additionally prove that no unknown outcomes remain.
public static class CashboxJournalReplay
{
    public static CashboxClosePreview Preview(string sessionId, decimal openingCash,
        IEnumerable<CashboxEntry> persistedEntries, decimal countedCash)
    {
        if (string.IsNullOrWhiteSpace(sessionId))
            throw new ArgumentException("Session identity required.", nameof(sessionId));
        ArgumentNullException.ThrowIfNull(persistedEntries);
        var box = new CashboxLifecycle();
        box.Open(sessionId, openingCash);
        foreach (var entry in persistedEntries)
            box.RecordPersisted(entry);
        return box.PreviewClose(countedCash);
    }

    // Compares a live projection against a complete durable journal readback.
    // A mismatch means the UI must block close and investigate, not overwrite either side.
    public static CashboxClosePreview VerifyClose(CashboxStatus live,
        IEnumerable<CashboxEntry> persistedEntries, decimal countedCash)
    {
        ArgumentNullException.ThrowIfNull(live);
        if (live.Phase != CashboxPhase.Open || string.IsNullOrWhiteSpace(live.SessionId))
            throw new InvalidOperationException("Cashbox is not open for close verification.");
        // Materialize once: database readers may be single-pass enumerables.
        ArgumentNullException.ThrowIfNull(persistedEntries);
        var rows = new List<CashboxEntry>(persistedEntries);
        var replay = Preview(live.SessionId, live.OpeningCash, rows, countedCash);
        var replayCount = rows.Count;
        if (replay.ExpectedCash != live.ExpectedCash ||
            replayCount != live.PersistedOperationCount)
            throw new InvalidOperationException("Durable cashbox journal does not match live projection.");
        return replay;
    }
    // Strong verification for Host adapters that can supply both projections.
    // Matching totals and counts alone cannot detect substituted journal operations.
    public static CashboxClosePreview VerifyCloseExact(CashboxStatus live,
        IEnumerable<CashboxEntry> projectedEntries,
        IEnumerable<CashboxEntry> persistedEntries, decimal countedCash)
    {
        ArgumentNullException.ThrowIfNull(projectedEntries);
        ArgumentNullException.ThrowIfNull(persistedEntries);
        var projected = new Dictionary<string, CashboxEntry>(StringComparer.Ordinal);
        foreach (var entry in projectedEntries)
        {
            ArgumentNullException.ThrowIfNull(entry);
            if (string.IsNullOrWhiteSpace(entry.OperationId) ||
                !projected.TryAdd(entry.OperationId, entry))
                throw new InvalidOperationException("Invalid or duplicate projected operation identity.");
        }

        var persisted = new List<CashboxEntry>(persistedEntries);
        var preview = VerifyClose(live, persisted, countedCash);
        if (projected.Count != persisted.Count)
            throw new InvalidOperationException("Journal operation identities differ.");
        foreach (var entry in persisted)
        {
            if (entry is null || string.IsNullOrWhiteSpace(entry.OperationId))
                throw new InvalidOperationException("Invalid durable operation identity.");
            if (!projected.Remove(entry.OperationId, out var expected) ||
                expected.Kind != entry.Kind || expected.Amount != entry.Amount)
                throw new InvalidOperationException("Durable journal operation differs from projection.");
        }
        return preview;
    }

}
