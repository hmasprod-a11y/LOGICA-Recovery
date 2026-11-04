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
CREATE TABLE test_checkout_movement (operation_id VARCHAR(128) PRIMARY KEY, signed_quantity INT NOT NULL) ENGINE=InnoDB;
INSERT INTO test_checkout_stock VALUES ('A', 10);
START TRANSACTION;
INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('sale-1');
UPDATE test_checkout_stock SET quantity=quantity-2 WHERE article_id='A';
INSERT INTO test_checkout_ticket VALUES ('sale-1', 15.00);
INSERT INTO test_checkout_payment VALUES ('sale-1', 15.00);
INSERT INTO test_checkout_movement VALUES ('sale-1', -2);
COMMIT;
START TRANSACTION;
INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('rollback-1');
UPDATE test_checkout_stock SET quantity=quantity-3 WHERE article_id='A';
INSERT INTO test_checkout_ticket VALUES ('rollback-1', 22.50);
INSERT INTO test_checkout_payment VALUES ('rollback-1', 22.50);
INSERT INTO test_checkout_movement VALUES ('rollback-1', -3);
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
assert_count "SELECT COUNT(*) FROM test_checkout_payment WHERE operation_id='rollback-1'" 0
assert_count "SELECT COUNT(*) FROM test_checkout_movement WHERE operation_id='rollback-1'" 0
# The second claim must fail with duplicate-key 1062, never post again.
if "${client[@]}" -e "INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('sale-1')" >/dev/null 2>&1; then
  echo "FAIL: duplicate operation was accepted" >&2
  exit 1
fi
assert_count "SELECT quantity FROM test_checkout_stock WHERE article_id='A'" 8
# A return reverses the stock sign and retains negative financial values.
"${client[@]}" <<'SQL'
START TRANSACTION;
INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('return-1');
UPDATE test_checkout_stock SET quantity=quantity+1 WHERE article_id='A';
INSERT INTO test_checkout_ticket VALUES ('return-1', -7.50);
INSERT INTO test_checkout_payment VALUES ('return-1', -7.50);
INSERT INTO test_checkout_movement VALUES ('return-1', 1);
COMMIT;
SQL
assert_count "SELECT quantity FROM test_checkout_stock WHERE article_id='A'" 9
assert_count "SELECT amount FROM test_checkout_ticket WHERE operation_id='return-1'" -7.50
assert_count "SELECT amount FROM test_checkout_payment WHERE operation_id='return-1'" -7.50
assert_count "SELECT signed_quantity FROM test_checkout_movement WHERE operation_id='return-1'" 1
# Inject a payment write failure: no journal, ticket, movement or stock survives.
if "${client[@]}" <<'SQL'
START TRANSACTION;
INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('failed-payment');
UPDATE test_checkout_stock SET quantity=quantity-4 WHERE article_id='A';
INSERT INTO test_checkout_ticket VALUES ('failed-payment', 31.00);
INSERT INTO test_checkout_movement VALUES ('failed-payment', -4);
INSERT INTO test_checkout_payment VALUES ('failed-payment', 31.00);
INSERT INTO test_checkout_payment VALUES ('failed-payment', 31.00);
COMMIT;
SQL
then
  echo "FAIL: injected duplicate payment did not fail" >&2
  exit 1
fi
# Connection exit after SQL error rolls back the uncommitted transaction.
assert_count "SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id='failed-payment'" 0
assert_count "SELECT COUNT(*) FROM test_checkout_ticket WHERE operation_id='failed-payment'" 0
assert_count "SELECT COUNT(*) FROM test_checkout_movement WHERE operation_id='failed-payment'" 0
assert_count "SELECT quantity FROM test_checkout_stock WHERE article_id='A'" 9
# Two independent connections racing for one operation ID: the second
# claimant must wait for the first transaction and then receive 1062.
# The test is bounded and verifies the DB's unique constraint, not an
# in-memory mutex or mocked repository.
"${client[@]}" <<'SQL' >/dev/null &
START TRANSACTION;
INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('race-1');
SELECT SLEEP(3);
COMMIT;
SQL
first_pid=$!
sleep 1
if "${client[@]}" -e "INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('race-1')" >/dev/null 2>&1; then
  echo "FAIL: concurrent duplicate claim succeeded" >&2
  wait "$first_pid" || true
  exit 1
fi
wait "$first_pid"
assert_count "SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id='race-1'" 1
# A competing checkout may reuse an operation ID ONLY if the first
# transaction rolls back. This is the other half of the idempotency
# contract: failed claims must not strand a valid retry forever.
"${client[@]}" <<'SQL' >/dev/null &
START TRANSACTION;
INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('race-rollback');
SELECT SLEEP(3);
ROLLBACK;
SQL
rollback_pid=$!
sleep 1
"${client[@]}" -e "INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('race-rollback')"
wait "$rollback_pid"
assert_count "SELECT COUNT(*) FROM hanouty_checkout_operations WHERE operation_id='race-rollback'" 1
# A return must not duplicate when its durable operation ID is reused.
if "${client[@]}" -e "INSERT INTO hanouty_checkout_operations (operation_id) VALUES ('return-1')" >/dev/null 2>&1; then
  echo "FAIL: duplicate return claim succeeded" >&2
  exit 1
fi
assert_count "SELECT quantity FROM test_checkout_stock WHERE article_id='A'" 9
echo "PASS disposable MariaDB sale, return, rollback, payment failure and concurrent commit/rollback claim resolution"
