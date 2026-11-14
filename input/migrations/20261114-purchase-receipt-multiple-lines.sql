-- Run after 20261113-purchase-receipt-order.sql. Existing reservations are preserved.
ALTER TABLE hanouty_purchase_receipt_order
    DROP PRIMARY KEY, ADD PRIMARY KEY (RECEIPT_ID, ARTICLE_ID);
