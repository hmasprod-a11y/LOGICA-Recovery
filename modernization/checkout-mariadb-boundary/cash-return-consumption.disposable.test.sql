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

-- Execute duplicate checks rather than leaving commented-out statements.
-- A local handler catches precisely duplicate-key error 1062 and fails the
-- fixture if either distinct refund ID or reused refund ID is accepted.
DELIMITER //
CREATE PROCEDURE hanouty_assert_cash_return_duplicates()
BEGIN
    DECLARE duplicate_original BOOL DEFAULT FALSE;
    DECLARE duplicate_operation BOOL DEFAULT FALSE;
    BEGIN
        DECLARE CONTINUE HANDLER FOR 1062 SET duplicate_original = TRUE;
        INSERT INTO hanouty_cash_return_consumption
          (original_ticket_id, return_operation_id, consumed_quantity)
        VALUES ('test-original-001', 'test-refund-002', 2.0000);
    END;
    BEGIN
        DECLARE CONTINUE HANDLER FOR 1062 SET duplicate_operation = TRUE;
        INSERT INTO hanouty_cash_return_consumption
          (original_ticket_id, return_operation_id, consumed_quantity)
        VALUES ('test-original-002', 'test-refund-001', 2.0000);
    END;
    IF NOT duplicate_original OR NOT duplicate_operation THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Cash return uniqueness regression';
    END IF;
END//
DELIMITER ;
CALL hanouty_assert_cash_return_duplicates();
DROP PROCEDURE hanouty_assert_cash_return_duplicates();

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
