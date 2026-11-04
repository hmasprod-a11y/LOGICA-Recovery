-- DISPOSABLE TEST SCHEMA ONLY. Never run automatically against shop databases.
-- The claim must share the SAME InnoDB transaction as ticket/payment/stock.
CREATE TABLE hanouty_checkout_operations (
    operation_id VARCHAR(128) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
    created_utc TIMESTAMP(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
    PRIMARY KEY (operation_id)
) ENGINE=InnoDB;
