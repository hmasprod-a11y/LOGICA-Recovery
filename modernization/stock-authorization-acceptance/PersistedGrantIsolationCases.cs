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
        var plan = LOGICA.Application.Inventory.StockAdjustmentPlan.Create(
            "P0-ARTICLE", 10m, 12m, "proposal rollback", "Actor-A");
        const string marker = "HANOUTY_MANUAL_STOCK_PROPOSAL_TEST_ONLY";
        var prior = Environment.GetEnvironmentVariable(marker);
        try {
            Environment.SetEnvironmentVariable(marker, null);
            Denied(() => StockAdjustmentWriter.ExecuteAuthorized(cs, plan, provider, "fixture-token"));
            using (var tx = db.BeginTransaction()) {
                Denied(() => StockAdjustmentWriter.ApplyAuthorized(db, tx, plan, provider, "fixture-token"));
                tx.Commit();
            }
            Environment.SetEnvironmentVariable(marker, "YES");
            // A token+actor key still allows one bearer to identify two actors.
            Sql(db, "ALTER TABLE HANOUTY_AUTH_SESSIONS DROP PRIMARY KEY, ADD UNIQUE KEY misleading (SESSION_TOKEN, ACTOR_ID)");
            Sql(db, "INSERT INTO HANOUTY_AUTH_SESSIONS SELECT SESSION_TOKEN,'Actor-B',EXPIRES_AT,NULL FROM HANOUTY_AUTH_SESSIONS");
            Denied(() => StockAdjustmentWriter.ExecuteAuthorized(cs, plan, provider, "fixture-token"));
            Sql(db, "DELETE FROM HANOUTY_AUTH_SESSIONS WHERE ACTOR_ID='Actor-B'");
            Denied(() => StockAdjustmentWriter.ExecuteAuthorized(cs, plan, provider, "fixture-token"));
            Sql(db, "ALTER TABLE HANOUTY_AUTH_SESSIONS DROP INDEX misleading, ADD PRIMARY KEY (SESSION_TOKEN)");
            Sql(db, "ALTER TABLE HANOUTY_ACTOR_GRANTS DROP PRIMARY KEY");
            Denied(() => StockAdjustmentWriter.ExecuteAuthorized(cs, plan, provider, "fixture-token"));
            Sql(db, "ALTER TABLE HANOUTY_ACTOR_GRANTS ADD PRIMARY KEY (ACTOR_ID,PERMISSION_CODE)");
            var wrongDb = new MySqlConnectionStringBuilder(cs) { Database = "not_the_fixture" };
            Denied(() => StockAdjustmentWriter.ExecuteAuthorized(wrongDb.ConnectionString, plan, provider, "fixture-token"));
            using (var tx = db.BeginTransaction()) {
                StockAdjustmentWriter.ApplyAuthorized(db, tx, plan, provider, "fixture-token");
                using var read = new MySqlCommand("SELECT STOCK=12 AND (SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK)=1 FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'", db, tx);
                Require(Convert.ToInt32(read.ExecuteScalar()) == 1, "Fixture grant failed to write stock and audit together.");
                using var audit = new MySqlCommand("SELECT LIBELLE FROM TABLE_MOUVEMENTS_STOCK", db, tx);
                Require(Convert.ToString(audit.ExecuteScalar()) == "Ajustement [Actor-A] 10 -> 12 : proposal rollback", "Audit must record the verified session actor.");
                tx.Rollback();
            }
            using var after = new MySqlCommand("SELECT STOCK=10 AND (SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK)=0 FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'", db);
            Require(Convert.ToInt32(after.ExecuteScalar()) == 1, "Rollback did not restore both tables.");
        } finally { Environment.SetEnvironmentVariable(marker, prior); }
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
