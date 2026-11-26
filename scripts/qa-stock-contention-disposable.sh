#!/usr/bin/env bash
# QA-only disposable MariaDB stock contention fixture. Never point at a shop DB.
set -euo pipefail
: "${HANOUTY_DISPOSABLE_DB_ONLY:?Explicitly acknowledge a disposable database}"
[[ "$HANOUTY_DISPOSABLE_DB_ONLY" == "YES" ]] || { echo "Disposable acknowledgement required" >&2; exit 2; }
: "${MYSQL_HOST:=127.0.0.1}" "${MYSQL_PORT:=3306}" "${MYSQL_USER:=checkout_test}" "${MYSQL_DATABASE:=checkout_disposable}"
[[ ("$MYSQL_HOST" == "127.0.0.1" || "$MYSQL_HOST" == "localhost") &&
   "$MYSQL_PORT" == "3306" && "$MYSQL_DATABASE" == "checkout_disposable" ]] || {
  echo "Fixture requires explicit disposable loopback:3306/checkout_disposable" >&2; exit 2;
}

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
DO GET_LOCK('hanouty_qa_stock_row_locked',10);
DO SLEEP(3);
COMMIT;
SQL
) &
first=$!
# Wait for a signal acquired AFTER the first UPDATE owns the actual row lock.
# A fixed sleep alone could accidentally reverse the winner on a busy runner.
locked=false
for ((attempt=0; attempt<100; attempt++)); do
  owner=$("${mysql[@]}" -e "SELECT COALESCE(IS_USED_LOCK('hanouty_qa_stock_row_locked'),0)")
  if [[ "$owner" != "0" ]]; then locked=true; break; fi
  if ! kill -0 "$first" 2>/dev/null; then wait "$first"; echo 'First transaction exited before lock signal' >&2; exit 1; fi
  sleep 0.05
done
[[ "$locked" == "true" ]] || { echo 'First transaction lock was not observed' >&2; exit 1; }
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
