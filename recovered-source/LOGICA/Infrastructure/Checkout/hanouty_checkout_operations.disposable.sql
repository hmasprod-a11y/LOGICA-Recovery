-- DISPOSABLE TEST SCHEMA ONLY. Never run automatically against shop databases.
-- The claim must share the SAME InnoDB transaction as ticket/payment/stock.
CREATE TABLE hanouty_checkout_operations (
    operation_id VARCHAR(128) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
    created_utc TIMESTAMP(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
    PRIMARY KEY (operation_id)
) ENGINE=InnoDB;

-- Cash refund consumption ledger, provisioned only in disposable CI fixtures.
-- Both identifiers are binary/case-sensitive to match canonical operation identity.
-- One original sale can be fully refunded once, even across distinct operation IDs.
-- The refund claim INSERT must be in the SAME transaction as signed ticket,
-- payment, stock and audit writes; rollback removes the claim as well.
CREATE TABLE hanouty_cash_return_consumption (
    original_ticket_id VARCHAR(64) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
    return_operation_id VARCHAR(64) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
    consumed_quantity DECIMAL(18,4) NOT NULL,
    created_utc TIMESTAMP(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
    PRIMARY KEY (original_ticket_id),
    UNIQUE KEY uq_cash_return_operation (return_operation_id),
    CONSTRAINT chk_cash_return_quantity CHECK (consumed_quantity > 0)
) ENGINE=InnoDB;
