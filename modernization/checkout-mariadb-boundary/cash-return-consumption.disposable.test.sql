-- Disposable MariaDB fixture only. Execute in an isolated scratch database.
-- Requires hanouty_cash_return_consumption DDL from
-- recovered-source/LOGICA/Infrastructure/Checkout/hanouty_checkout_operations.disposable.sql
-- Exercises durable original identity, repeat, rollback and restart semantics.
START TRANSACTION;
INSERT INTO hanouty_cash_return_consumption
(original_ticket_id, return_operation_id, consumed_quantity)
VALUES ('test-original-001', 'test-refund-001', 2.0000);
COMMIT;

-- The original must remain consumed after reconnect/restart.
SELECT CASE WHEN COUNT(*)=1 THEN 'PASS durable consumption' ELSE 'FAIL' END AS result
FROM hanouty_cash_return_consumption
WHERE original_ticket_id='test-original-001'
  AND return_operation_id='test-refund-001' AND consumed_quantity=2.0000;

-- The following two inserts MUST fail with duplicate key 1062 when executed
-- individually. Do not use INSERT IGNORE or ON DUPLICATE KEY UPDATE.
-- INSERT INTO hanouty_cash_return_consumption
-- (original_ticket_id,return_operation_id,consumed_quantity)
-- VALUES ('test-original-001','test-refund-002',2.0000);
-- INSERT INTO hanouty_cash_return_consumption
-- (original_ticket_id,return_operation_id,consumed_quantity)
-- VALUES ('test-original-002','test-refund-001',2.0000);

START TRANSACTION;
INSERT INTO hanouty_cash_return_consumption
(original_ticket_id, return_operation_id, consumed_quantity)
VALUES ('test-original-rollback', 'test-refund-rollback', 1.0000);
ROLLBACK;
SELECT CASE WHEN COUNT(*)=0 THEN 'PASS rollback' ELSE 'FAIL' END AS result
FROM hanouty_cash_return_consumption
WHERE original_ticket_id='test-original-rollback';

-- Cleanup is intentionally scoped to fixture identifiers.
DELETE FROM hanouty_cash_return_consumption
WHERE original_ticket_id IN ('test-original-001','test-original-rollback');
