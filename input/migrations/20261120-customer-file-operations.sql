-- Explicit additive migration. Apply only after backing up the intended LOGICA database.
-- Customer identity, numbering and opening-credit history retain the original tables.
CREATE TABLE IF NOT EXISTS hanouty_customer_file_operations (
 OPERATION_ID VARCHAR(64) CHARACTER SET ascii COLLATE ascii_bin NOT NULL PRIMARY KEY,
 ACTOR VARCHAR(128) NOT NULL,
 KIND VARCHAR(16) NOT NULL,
 CUSTOMER_ID VARCHAR(64) NOT NULL,
 PAYLOAD LONGTEXT NOT NULL,
 RESULT LONGTEXT NOT NULL,
 CREATED_UTC DATETIME(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
