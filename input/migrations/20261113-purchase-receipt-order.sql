-- Apply to an isolated, backed-up LOGICA schema before creating receipts from orders.
CREATE TABLE IF NOT EXISTS hanouty_purchase_receipt_order (
    RECEIPT_ID VARCHAR(255) COLLATE utf8mb4_bin NOT NULL,
    ORDER_ID VARCHAR(255) COLLATE utf8mb4_bin NOT NULL,
    ARTICLE_ID VARCHAR(255) COLLATE utf8mb4_bin NOT NULL,
    QUANTITY DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (RECEIPT_ID),
    KEY ix_purchase_receipt_order_article (ORDER_ID, ARTICLE_ID),
    CONSTRAINT ck_purchase_receipt_order_quantity CHECK (QUANTITY > 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;
