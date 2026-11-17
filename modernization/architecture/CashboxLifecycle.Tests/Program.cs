using Hanouty.Architecture.Cashbox;

static void MustRejectInput(Action action)
{
    try { action(); }
    catch (ArgumentException) { return; }
    throw new Exception("Expected invalid financial input rejection.");
}

static void MustThrow(Action action)
{
    try { action(); }
    catch (InvalidOperationException) { return; }
    throw new Exception("Expected rejection.");
}

var cashbox = new CashboxLifecycle();
cashbox.Open("cashier-1/session-1", 100m);
cashbox.RecordPersisted(new("sale-1", CashboxEntryKind.SaleCash, 50m));
cashbox.RecordPersisted(new("card-1", CashboxEntryKind.SaleCard, 30m));
cashbox.RecordPersisted(new("return-1", CashboxEntryKind.ReturnCash, 10m));
cashbox.RecordPersisted(new("expense-1", CashboxEntryKind.ExpenseCash, 5m));
cashbox.RecordPersisted(new("settlement-1", CashboxEntryKind.CustomerSettlementCash, 20m));
if (cashbox.ExpectedCash != 155m) throw new Exception("Wrong expected cash.");
MustThrow(() => cashbox.RecordPersisted(new("sale-1", CashboxEntryKind.SaleCash, 50m)));
cashbox.MarkOutcomeUnknown();
MustThrow(() => cashbox.Close(155m));
MustThrow(() => cashbox.RecordPersisted(new("sale-2", CashboxEntryKind.SaleCash, 1m)));
MustThrow(() => cashbox.ConfirmJournalReconciled(false));
cashbox.ConfirmJournalReconciled(true);
if (cashbox.Close(153m) != -2m) throw new Exception("Wrong reconciliation difference.");
MustThrow(() => cashbox.Open("cashier-1/session-1", 0m));
if (cashbox.Phase != CashboxPhase.Closed || cashbox.SessionId is not null)
    throw new Exception("Reused session changed the closed state.");
cashbox.Open("cashier-2/session-2", 0m);
MustThrow(() => cashbox.Open("cashier-1/session-1", 0m));
if (cashbox.ExpectedCash != 0m || cashbox.Entries.Count != 0)
    throw new Exception("New session reused prior cashbox.");
// An overflowed variance must leave the cashbox open for investigation.
var extreme = new CashboxLifecycle();
extreme.Open("overflow-session", 0m);
extreme.RecordPersisted(new("extreme-return", CashboxEntryKind.ReturnCash, decimal.MaxValue));
try { extreme.Close(decimal.MaxValue); throw new Exception("Expected overflow rejection."); }
catch (OverflowException) { }
if (extreme.Phase != CashboxPhase.Open || extreme.SessionId != "overflow-session")
    throw new Exception("Overflow closed or reset the cashbox.");


// Posting overflow must be atomic: no phantom entry and no consumed operation id.
var postingOverflow = new CashboxLifecycle();
postingOverflow.Open("posting-overflow", decimal.MaxValue);
try
{
    postingOverflow.RecordPersisted(new("retryable-operation", CashboxEntryKind.SaleCash, 1m));
    throw new Exception("Expected posting overflow.");
}
catch (OverflowException) { }
if (postingOverflow.ExpectedCash != decimal.MaxValue ||
    postingOverflow.Entries.Count != 0 ||
    postingOverflow.Phase != CashboxPhase.Open)
    throw new Exception("Overflow mutated the cashbox.");
postingOverflow.RecordPersisted(new("retryable-operation", CashboxEntryKind.ReturnCash, 1m));
if (postingOverflow.ExpectedCash != decimal.MaxValue - 1m ||
    postingOverflow.Entries.Count != 1)
    throw new Exception("Overflow consumed the durable operation id.");

// Card operations are journaled but must not affect physical cash reconciliation.
var cardOnly = new CashboxLifecycle();
cardOnly.Open("card-only", 40m);
cardOnly.RecordPersisted(new("card-sale", CashboxEntryKind.SaleCard, 25m));
cardOnly.RecordPersisted(new("card-refund", CashboxEntryKind.ReturnCard, 10m));
cardOnly.RecordPersisted(new("card-settlement", CashboxEntryKind.CustomerSettlementCard, 5m));
if (cardOnly.ExpectedCash != 40m || cardOnly.Close(40m) != 0m)
    throw new Exception("Card movements affected cash reconciliation.");
MustThrow(() => cardOnly.RecordPersisted(new("after-close", CashboxEntryKind.SaleCash, 1m)));

// A preview must be repeatable and must not close or mutate the open session.
var previewBox = new CashboxLifecycle();
previewBox.Open("preview-session", 25m);
previewBox.RecordPersisted(new("preview-sale", CashboxEntryKind.SaleCash, 15m));
var preview = previewBox.PreviewClose(37m);
if (preview.SessionId != "preview-session" || preview.ExpectedCash != 40m ||
    preview.CountedCash != 37m || preview.Difference != -3m ||
    previewBox.Phase != CashboxPhase.Open || previewBox.Entries.Count != 1 ||
    previewBox.ExpectedCash != 40m)
    throw new Exception("Preview changed the session or returned an incorrect variance.");
if (previewBox.Close(37m) != preview.Difference)
    throw new Exception("Close and preview disagreed.");
MustThrow(() => previewBox.PreviewClose(37m));
var unknownPreview = new CashboxLifecycle();
unknownPreview.Open("unknown-preview", 0m);
unknownPreview.MarkOutcomeUnknown();
MustThrow(() => unknownPreview.PreviewClose(0m));
if (unknownPreview.Phase != CashboxPhase.ReconciliationRequired)
    throw new Exception("Preview bypassed the journal lock.");


// Invalid financial inputs must never change the journal or expected cash.
var invalid = new CashboxLifecycle();
invalid.Open("invalid-inputs", 12m);
MustRejectInput(() => invalid.RecordPersisted(new("zero", CashboxEntryKind.SaleCash, 0m)));
MustRejectInput(() => invalid.RecordPersisted(new("negative", CashboxEntryKind.SaleCash, -1m)));
try { invalid.RecordPersisted(new("unknown-kind", (CashboxEntryKind)999, 1m)); throw new Exception("Expected invalid kind rejection."); }
catch (ArgumentOutOfRangeException) { }
if (invalid.ExpectedCash != 12m || invalid.Entries.Count != 0)
    throw new Exception("Invalid input mutated the cashbox.");
invalid.RecordPersisted(new("zero", CashboxEntryKind.SaleCash, 1m));
if (invalid.ExpectedCash != 13m || invalid.Entries.Count != 1)
    throw new Exception("Rejected operation identity was consumed.");

// Closing preview overflow must leave the session intact.
var previewOverflow = new CashboxLifecycle();
previewOverflow.Open("preview-overflow", 0m);
previewOverflow.RecordPersisted(new("refund-max", CashboxEntryKind.ReturnCash, decimal.MaxValue));
try { previewOverflow.PreviewClose(decimal.MaxValue); throw new Exception("Expected preview overflow."); }
catch (OverflowException) { }
if (previewOverflow.Phase != CashboxPhase.Open || previewOverflow.Entries.Count != 1 ||
    previewOverflow.ExpectedCash != -decimal.MaxValue)
    throw new Exception("Overflowed preview mutated the journal.");


// Read-only Host/WPF projection must track lifecycle and journal count accurately.
var statusBox = new CashboxLifecycle();
var initialStatus = statusBox.GetStatus();
if (initialStatus.Phase != CashboxPhase.Closed || initialStatus.SessionId is not null ||
    initialStatus.PersistedOperationCount != 0)
    throw new Exception("Initial status is incorrect.");
statusBox.Open("status-session", 80m);
var openedStatus = statusBox.GetStatus();
if (openedStatus.Phase != CashboxPhase.Open || openedStatus.SessionId != "status-session" ||
    openedStatus.OpeningCash != 80m || openedStatus.ExpectedCash != 80m)
    throw new Exception("Open status is incorrect.");
statusBox.RecordPersisted(new("status-sale", CashboxEntryKind.SaleCash, 12m));
if (statusBox.GetStatus().PersistedOperationCount != 1 ||
    statusBox.GetStatus().ExpectedCash != 92m ||
    openedStatus.ExpectedCash != 80m)
    throw new Exception("Status projection was stale or mutable.");
statusBox.MarkOutcomeUnknown();
if (statusBox.GetStatus().Phase != CashboxPhase.ReconciliationRequired)
    throw new Exception("Status did not expose journal reconciliation lock.");
statusBox.ConfirmJournalReconciled(true);
statusBox.Close(92m);
if (statusBox.GetStatus().Phase != CashboxPhase.Closed ||
    statusBox.GetStatus().SessionId is not null)
    throw new Exception("Closed status leaked active session identity.");


// Durable replay must agree with the live projection before showing a close variance.
var durableBox = new CashboxLifecycle();
durableBox.Open("durable-session", 20m);
durableBox.RecordPersisted(new("durable-sale", CashboxEntryKind.SaleCash, 9m));
durableBox.RecordPersisted(new("durable-card", CashboxEntryKind.SaleCard, 6m));
var durableRows = new[]
{
    new CashboxEntry("durable-sale", CashboxEntryKind.SaleCash, 9m),
    new CashboxEntry("durable-card", CashboxEntryKind.SaleCard, 6m)
};
var verified = CashboxJournalReplay.VerifyClose(durableBox.GetStatus(), durableRows, 27m);
if (verified.ExpectedCash != 29m || verified.Difference != -2m)
    throw new Exception("Durable replay disagreed with cashbox close.");
MustThrow(() => CashboxJournalReplay.VerifyClose(durableBox.GetStatus(),
    new[] { durableRows[0] }, 27m));
MustThrow(() => CashboxJournalReplay.VerifyClose(durableBox.GetStatus(),
    new[] { durableRows[0], durableRows[0] }, 27m));
durableBox.MarkOutcomeUnknown();
MustThrow(() => CashboxJournalReplay.VerifyClose(durableBox.GetStatus(), durableRows, 27m));


// Identical totals and row counts must not hide substituted durable operation IDs.
var exact = CashboxJournalReplay.VerifyCloseExact(durableBox.GetStatus() with
{
    Phase = CashboxPhase.Open
}, durableRows, durableRows, 27m);
if (exact.ExpectedCash != 29m) throw new Exception("Exact replay failed.");
MustThrow(() => CashboxJournalReplay.VerifyCloseExact(
    durableBox.GetStatus() with { Phase = CashboxPhase.Open },
    durableRows,
    new[]
    {
        new CashboxEntry("substituted-sale", CashboxEntryKind.SaleCash, 9m),
        durableRows[1]
    }, 27m));
MustThrow(() => CashboxJournalReplay.VerifyCloseExact(
    durableBox.GetStatus() with { Phase = CashboxPhase.Open },
    durableRows,
    new[]
    {
        new CashboxEntry("durable-sale", CashboxEntryKind.CustomerSettlementCash, 9m),
        durableRows[1]
    }, 27m));


// Same total and row count can conceal compensating durable amount changes.
// Exact verification must reject them rather than accept a matching cash balance.
var offsetRows = new[]
{
    new CashboxEntry("durable-sale", CashboxEntryKind.SaleCash, 10m),
    new CashboxEntry("durable-card", CashboxEntryKind.SaleCard, 5m)
};
MustThrow(() => CashboxJournalReplay.VerifyCloseExact(
    durableBox.GetStatus() with { Phase = CashboxPhase.Open },
    durableRows, offsetRows, 27m));

// A correct journal does not override an unresolved financial outcome lock.
MustThrow(() => CashboxJournalReplay.VerifyCloseExact(
    durableBox.GetStatus(), durableRows, durableRows, 27m));

Console.WriteLine("CashboxLifecycle isolated assertions passed.");
