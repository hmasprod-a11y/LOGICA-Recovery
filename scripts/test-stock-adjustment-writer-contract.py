#!/usr/bin/env python3
"""Fail-closed source contract for opt-in transactional inventory writer.

This is NOT a substitute for disposable MariaDB concurrency tests.
"""
from pathlib import Path

root = Path(__file__).resolve().parents[1]
source = (root / "recovered-source/LOGICA/Infrastructure/Inventory/StockAdjustmentWriter.cs").read_text(encoding="utf-8")
required = {
    "transaction ownership": "ReferenceEquals(transaction.Connection, connection)",
    "transactional engine": '"InnoDB"',
    "persisted permission": "MODIF_STOCK_MANUEL",
    "permission row lock": "TABLE_PARAMETRES WHERE OBJET = 'MODIF_STOCK_MANUEL' FOR UPDATE",
    "article row lock": "WHERE ID_ARTICLE = @id FOR UPDATE",
    "duplicate identity guard": "Duplicate article identity.",
    "stale stock guard": "Stale stock snapshot",
    "optimistic update": "AND STOCK = @before",
    "movement in same transaction": "INSERT INTO TABLE_MOUVEMENTS_STOCK",
    "reason": "plan.Reason",
    "user identity": "plan.UserId",
    "before": "plan.BeforeStock",
    "after": "plan.AfterStock",
    "rollback on failed movement": "Stock movement audit failed; rollback required.",
}
for label, needle in required.items():
    assert needle in source, f"missing {label}: {needle}"
assert "Commit()" not in source, "writer must never commit caller-owned transaction"
assert "Rollback()" not in source, "caller owns rollback"
assert "ALTER TABLE" not in source and "DROP TABLE" not in source
print("PASS: stock adjustment writer source safety contract (not a MariaDB integration test)")

# Preflight rejection must happen before any stock write; an oversized audit
# must never rely on a later SQL error and a caller remembering to roll back.
preflight = source.index("Stock adjustment audit exceeds legacy column size.")
update = source.index("UPDATE TABLE_ARTICLES SET STOCK")
assert preflight < update, "audit must be validated before stock mutation"
assert source.index("Article identity exceeds supported length.") < update
assert source.count("string audit =") == 1, "audit must be constructed once"
print("PASS: audit and identity validation precede stock update")

# A movement insert can fail after a successful stock UPDATE. The writer must
# undo its own partial work even if the caller later commits the outer transaction.
assert 'Guid.NewGuid().ToString("N")' in source, "savepoint must be unique per call"
assert 'string savepointName = "hanouty_sa_"' in source
assert '"SAVEPOINT " + savepointName' in source
assert '"ROLLBACK TO SAVEPOINT " + savepointName' in source
assert '"RELEASE SAVEPOINT " + savepointName' in source
assert source.index('"SAVEPOINT " + savepointName') < source.index('UPDATE TABLE_ARTICLES SET STOCK')
assert source.index('"ROLLBACK TO SAVEPOINT " + savepointName') > source.index('INSERT INTO TABLE_MOUVEMENTS_STOCK')
assert 'SAVEPOINT hanouty_stock_adjustment' not in source, "fixed name could overwrite caller savepoint"
assert 'catch\n            {' in source, 'rollback must run on write/audit exceptions'
print('PASS: failed audit rolls back local stock update without committing outer transaction')
