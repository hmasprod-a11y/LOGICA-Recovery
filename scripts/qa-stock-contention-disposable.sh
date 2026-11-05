#!/usr/bin/env bash
# QA-only disposable MariaDB stock contention fixture. Never point at a shop DB.
set -euo pipefail
: "${CHECKOUT_TEST_CONNECTION:?Set disposable connection string for the existing Checkout test DB}"
: "${HANOUTY_DISPOSABLE_DB_ONLY:?Explicitly acknowledge a disposable database}"
[[ "$HANOUTY_DISPOSABLE_DB_ONLY" == "YES" ]] || { echo "Disposable acknowledgement required" >&2; exit 2; }
: "${MYSQL_HOST:=127.0.0.1}" "${MYSQL_PORT:=3306}" "${MYSQL_USER:=checkout_test}" "${MYSQL_DATABASE:=checkout_disposable}"
mysql=(mariadb --batch --skip-column-names --host="$MYSQL_HOST" --port="$MYSQL_PORT" --user="$MYSQL_USER" "$MYSQL_DATABASE")
# Distinct fixture tables prevent interference with production Inventory schema.
"${mysql[@]}" <<'SQL'
CREATE TABLE qa_stock_contention (id INT PRIMARY KEY, qty INT NOT NULL) ENGINE=InnoDB;
CREATE TABLE qa_stock_contention_audit (operation_id VARCHAR(32) PRIMARY KEY, qty INT NOT NULL) ENGINE=InnoDB;
INSERT INTO qa_stock_contention VALUES (1,1);
SQL
cleanup() { "${mysql[@]}" -e 'DROP TABLE IF EXISTS qa_stock_contention_audit; DROP TABLE IF EXISTS qa_stock_contention' >/dev/null || true; }
trap cleanup EXIT
# First transaction owns the row lock; competing update must not oversell.
( "${mysql[@]}" <<'SQL'
START TRANSACTION;
UPDATE qa_stock_contention SET qty=qty-1 WHERE id=1 AND qty>=1;
INSERT INTO qa_stock_contention_audit VALUES ('sale-1',1);
DO SLEEP(3);
COMMIT;
SQL
) &
first=$!
sleep 1
"${mysql[@]}" <<'SQL'
SET innodb_lock_wait_timeout=10;
START TRANSACTION;
UPDATE qa_stock_contention SET qty=qty-1 WHERE id=1 AND qty>=1;
SET @changed=ROW_COUNT();
INSERT INTO qa_stock_contention_audit SELECT 'sale-2',1 WHERE @changed=1;
COMMIT;
SQL
wait "$first"
stock=$("${mysql[@]}" -e 'SELECT qty FROM qa_stock_contention WHERE id=1')
writes=$("${mysql[@]}" -e 'SELECT COUNT(*) FROM qa_stock_contention_audit')
[[ "$stock" == "0" && "$writes" == "1" ]] || { echo "FAIL contention stock=$stock writes=$writes" >&2; exit 1; }
# A forced rollback must restore the row and leave no journal.
"${mysql[@]}" <<'SQL'
START TRANSACTION;
UPDATE qa_stock_contention SET qty=qty+1 WHERE id=1;
INSERT INTO qa_stock_contention_audit VALUES ('rollback',1);
ROLLBACK;
SQL
stock=$("${mysql[@]}" -e 'SELECT qty FROM qa_stock_contention WHERE id=1')
writes=$("${mysql[@]}" -e 'SELECT COUNT(*) FROM qa_stock_contention_audit')
[[ "$stock" == "0" && "$writes" == "1" ]] || { echo "FAIL rollback stock=$stock writes=$writes" >&2; exit 1; }
echo 'PASS disposable InnoDB contention and rollback fixture (not production Checkout acceptance)'
