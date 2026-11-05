using System;
using System.Data;
using LOGICA.Infrastructure.Inventory;
using MySql.Data.MySqlClient;

// Proposed storage fixture only: proves the production provider's query/locks,
// not approval of the schema, session issuer, or WPF manual-write enablement.
internal static class PersistedGrantIsolationCases
{
    static void Require(bool value, string message) { if (!value) throw new Exception(message); }
    static void Sql(MySqlConnection db, string sql) { using var cmd = new MySqlCommand(sql, db); cmd.ExecuteNonQuery(); }
    static void Denied(Action action) {
        try { action(); } catch (UnauthorizedAccessException) { return; }
        throw new Exception("Expected persisted grant denial.");
    }
    internal static void Run(MySqlConnection db, string cs)
    {
        Sql(db, "CREATE TABLE HANOUTY_AUTH_SESSIONS (SESSION_TOKEN VARCHAR(128) PRIMARY KEY, ACTOR_ID VARCHAR(128) NOT NULL, EXPIRES_AT DATETIME NOT NULL, REVOKED_AT DATETIME NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci");
        Sql(db, "CREATE TABLE HANOUTY_ACTOR_GRANTS (ACTOR_ID VARCHAR(128) NOT NULL, PERMISSION_CODE VARCHAR(80) NOT NULL, EXPIRES_AT DATETIME NULL, REVOKED_AT DATETIME NULL, PRIMARY KEY(ACTOR_ID,PERMISSION_CODE)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci");
        var provider = new MariaDbManualStockAuthorization();
        Sql(db, "INSERT INTO HANOUTY_AUTH_SESSIONS VALUES ('fixture-token','Actor-A',DATE_ADD(UTC_TIMESTAMP(),INTERVAL 1 HOUR),NULL)");
        Sql(db, "INSERT INTO HANOUTY_ACTOR_GRANTS VALUES ('actor-a','ManualStockAdjustment',NULL,NULL)");
        using (var tx = db.BeginTransaction()) {
            Denied(() => provider.VerifyForWrite(db, tx, "fixture-token", "Actor-A"));
            tx.Commit();
        }
        Sql(db, "UPDATE HANOUTY_ACTOR_GRANTS SET ACTOR_ID='Actor-A'");
        using (var tx = db.BeginTransaction()) {
            Require(provider.VerifyForWrite(db, tx, "fixture-token", "Actor-A").UserId == "Actor-A", "Exact actor grant missing.");
            Denied(() => provider.VerifyForWrite(db, tx, "FIXTURE-TOKEN", "Actor-A"));
            Denied(() => provider.VerifyForWrite(db, tx, "fixture-token", "actor-a"));
            // Grant/session reads must retain real row locks until outer completion.
            using var second = new MySqlConnection(cs); second.Open();
            Sql(second, "SET innodb_lock_wait_timeout=1");
            foreach (var table in new[] { "HANOUTY_ACTOR_GRANTS", "HANOUTY_AUTH_SESSIONS" }) {
                try {
                    Sql(second, "UPDATE " + table + " SET REVOKED_AT=UTC_TIMESTAMP()");
                    throw new Exception("Revocation bypassed the transaction's row lock.");
                } catch (MySqlException ex) {
                    Require(ex.Number == 1205, "Unexpected revocation SQL error.");
                }
            }
            tx.Rollback();
        }
        Sql(db, "UPDATE HANOUTY_ACTOR_GRANTS SET REVOKED_AT=UTC_TIMESTAMP()");
        using (var tx = db.BeginTransaction()) {
            Denied(() => provider.VerifyForWrite(db, tx, "fixture-token", "Actor-A"));
            tx.Commit();
        }
        Sql(db, "UPDATE HANOUTY_ACTOR_GRANTS SET REVOKED_AT=NULL");
        foreach (var table in new[] { "HANOUTY_AUTH_SESSIONS", "HANOUTY_ACTOR_GRANTS" }) {
            Sql(db, "ALTER TABLE " + table + " ENGINE=MyISAM");
            using (var tx = db.BeginTransaction()) {
                Denied(() => provider.VerifyForWrite(db, tx, "fixture-token", "Actor-A"));
                tx.Commit();
            }
            Sql(db, "ALTER TABLE " + table + " ENGINE=InnoDB");
        }
        var completed = db.BeginTransaction(); completed.Commit();
        Denied(() => provider.VerifyForWrite(db, completed, "fixture-token", "Actor-A"));
        completed.Dispose();
        using (var tx = db.BeginTransaction()) {
            using var detached = new MySqlConnection(cs);
            Denied(() => provider.VerifyForWrite(detached, tx, "fixture-token", "Actor-A"));
            tx.Rollback();
        }
        Sql(db, "DROP TABLE HANOUTY_ACTOR_GRANTS");
        using (var tx = db.BeginTransaction()) {
            Denied(() => provider.VerifyForWrite(db, tx, "fixture-token", "Actor-A"));
            tx.Commit();
        }
        Sql(db, "DROP TABLE HANOUTY_AUTH_SESSIONS");
        Console.WriteLine("PASS production provider: exact actor join, transactional storage, grant/session revocation locks, fresh revocation denial and invalid context.");
    }
}
