using Hanouty.Architecture.Cashbox;

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
MustThrow(() => invalid.RecordPersisted(new("zero", CashboxEntryKind.SaleCash, 0m)));
MustThrow(() => invalid.RecordPersisted(new("negative", CashboxEntryKind.SaleCash, -1m)));
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

Console.WriteLine("CashboxLifecycle isolated assertions passed.");
