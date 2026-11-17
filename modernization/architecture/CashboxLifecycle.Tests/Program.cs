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
cashbox.Open("cashier-2/session-2", 0m);
if (cashbox.ExpectedCash != 0m || cashbox.Entries.Count != 0)
    throw new Exception("New session reused prior cashbox.");
Console.WriteLine("CashboxLifecycle isolated assertions passed.");
