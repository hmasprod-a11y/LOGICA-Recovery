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
