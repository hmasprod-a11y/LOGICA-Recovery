#!/usr/bin/env bash
set -euo pipefail
# Requires a disposable MariaDB database and mysql-compatible client.
# Example: MYSQL_PWD=test mariadb -h 127.0.0.1 -u checkout_test ...
: "${DB_HOST:?required disposable database host}"
: "${DB_NAME:?required disposable database name}"
: "${DB_USER:?required disposable database user}"
: "${MYSQL_PWD:?required disposable database password}"
client=(mariadb --protocol=tcp -h "$DB_HOST" -u "$DB_USER" "$DB_NAME" --batch --skip-column-names)
schema="$(dirname "$0")/../recovered-source/LOGICA/Infrastructure/Checkout/hanouty_checkout_operations.disposable.sql"
"${client[@]}" < "$schema"
# A claim, ticket, payment and stock movement must commit together.
"${client[@]}" <<'SQL'
CREATE TABLE test_checkout_stock (article_id VARCHAR(32) PRIMARY KEY, quantity INT NOT NULL) ENGINE=InnoDB;
CREATE TABLE test_checkout_ticket (operation_id VARCHAR(128) PRIMARY KEY, amount DECIMAL(12,2) NOT NULL) ENGINE=InnoDB;
CREATE TABLE test_checkout_payment (operation_id VARCHAR(128) PRIMARY KEY, amount DECIMAL(12,2) NOT NULL) ENGINE=InnoDB;
INSERT INTO test_checkout_stock VALUES ('A', 10);
START TRANSACTION;
INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('sale-1');
UPDATE test_checkout_stock SET quantity=quantity-2 WHERE article_id='A';
INSERT INTO test_checkout_ticket VALUES ('sale-1', 15.00);
INSERT INTO test_checkout_payment VALUES ('sale-1', 15.00);
COMMIT;
START TRANSACTION;
INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('rollback-1');
UPDATE test_checkout_stock SET quantity=quantity-3 WHERE article_id='A';
INSERT INTO test_checkout_ticket VALUES ('rollback-1', 22.50);
ROLLBACK;
SQL
assert_count() {
  local sql="$1" expected="$2" actual
  actual=$("${client[@]}" -e "$sql")
  if [[ "$actual" != "$expected" ]]; then
    echo "FAIL: $sql expected=$expected actual=$actual" >&2
    exit 1
  fi
}
assert_count "SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id='sale-1'" 1
assert_count "SELECT COUNT(*) FROM test_checkout_ticket WHERE operation_id='sale-1'" 1
assert_count "SELECT COUNT(*) FROM test_checkout_payment WHERE operation_id='sale-1'" 1
assert_count "SELECT quantity FROM test_checkout_stock WHERE article_id='A'" 8
assert_count "SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id='rollback-1'" 0
assert_count "SELECT COUNT(*) FROM test_checkout_ticket WHERE operation_id='rollback-1'" 0
# The second claim must fail with duplicate-key 1062, never post again.
if "${client[@]}" -e "INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('sale-1')" >/dev/null 2>&1; then
  echo "FAIL: duplicate operation was accepted" >&2
  exit 1
fi
assert_count "SELECT quantity FROM test_checkout_stock WHERE article_id='A'" 8
echo "PASS disposable MariaDB durable claim, payment/stock commit, duplicate rejection and rollback"
