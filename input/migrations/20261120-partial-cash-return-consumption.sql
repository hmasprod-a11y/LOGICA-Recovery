-- Explicit additive migration on a backed-up intended database only.
-- No startup schema initialization. Full-return consumption keeps its existing table.
CREATE TABLE IF NOT EXISTS hanouty_return_line_consumption (
 original_ticket_id VARCHAR(64) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
 article_id VARCHAR(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
 returned_quantity DECIMAL(19,4) NOT NULL,
 returned_net DECIMAL(19,2) NOT NULL,
 last_operation_id VARCHAR(64) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
 PRIMARY KEY (original_ticket_id, article_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
