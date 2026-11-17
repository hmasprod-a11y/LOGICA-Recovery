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
        var replay = Preview(live.SessionId, live.OpeningCash, persistedEntries, countedCash);
        var replayCount = 0;
        foreach (var _ in persistedEntries)
            replayCount++;
        if (replay.ExpectedCash != live.ExpectedCash ||
            replayCount != live.PersistedOperationCount)
            throw new InvalidOperationException("Durable cashbox journal does not match live projection.");
        return replay;
    }
}
