-- Explicit additive migration; never applied automatically to shop databases.
CREATE TABLE IF NOT EXISTS hanouty_stock_issue_create_operations (
 OPERATION_ID VARCHAR(32) CHARACTER SET ascii COLLATE ascii_bin NOT NULL PRIMARY KEY,
 ACTOR VARCHAR(255) NOT NULL,
 ISSUE_ID VARCHAR(255) NOT NULL,
 PAYLOAD LONGTEXT NOT NULL,
 CREATED_UTC DATETIME(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
