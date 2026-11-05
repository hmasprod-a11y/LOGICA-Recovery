// Real LOGICA assembly acceptance: unverified manual stock writes are disabled.
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;
internal static class StockAdjustmentMariaDbSmoke {
    static void Require(bool ok, string message) { if (!ok) throw new Exception(message); }
    static void Sql(MySqlConnection c, string sql) { using(var cmd=new MySqlCommand(sql,c)) cmd.ExecuteNonQuery(); }
    static decimal Number(MySqlConnection c, string sql) { using(var cmd=new MySqlCommand(sql,c)) return Convert.ToDecimal(cmd.ExecuteScalar(),CultureInfo.InvariantCulture); }
    static void Denied(Action action) {
        try { action(); }
        catch(TargetInvocationException ex) { if(ex.InnerException is UnauthorizedAccessException) return; throw; }
        throw new Exception("Unverified actor was accepted.");
    }
    static int Main() {
        string cs=Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING");
        var settings=new MySqlConnectionStringBuilder(cs);
        Require((settings.Server=="127.0.0.1"||settings.Server=="localhost") && settings.Port==3307 && settings.Database=="logica_ci","Unsafe fixture target");
        var assembly=Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"LOGICA.exe"));
        var planType=assembly.GetType("LOGICA.Application.Inventory.StockAdjustmentPlan",true);
        var writerType=assembly.GetType("LOGICA.Infrastructure.Inventory.StockAdjustmentWriter",true);
        var denyType=assembly.GetType("LOGICA.Application.Inventory.DenyAllManualStockAuthorization",true);
        var deny=Activator.CreateInstance(denyType,true);
        var verify=denyType.GetMethod("VerifyForWrite",BindingFlags.Public|BindingFlags.Instance);
        Require(verify!=null,"Missing explicit deny-by-default authorization adapter");
        Denied(()=>verify.Invoke(deny,new object[]{null,null,"FORGED-SESSION","ADMIN"}));
        Denied(()=>verify.Invoke(deny,new object[]{null,null,"","CI-USER"}));
        var create=planType.GetMethod("Create",BindingFlags.Static|BindingFlags.NonPublic);
        // The V1 inventory rule forbids negative on-hand stock and no-op
        // adjustments. Reject these before opening any database transaction.
        foreach(decimal negative in new[]{-1m,-0.001m}) {
            try { create.Invoke(null,new object[]{"CI-ARTICLE",10m,negative,"invalid negative stock","CI-USER"}); throw new Exception("Negative stock accepted"); }
            catch(TargetInvocationException ex) { if(!(ex.InnerException is ArgumentOutOfRangeException)) throw; }
        }
        try { create.Invoke(null,new object[]{"CI-ARTICLE",10m,10m,"no-op","CI-USER"}); throw new Exception("No-op movement accepted"); }
        catch(TargetInvocationException ex) { if(!(ex.InnerException is ArgumentException)) throw; }
        var apply=writerType.GetMethod("Apply",BindingFlags.Static|BindingFlags.NonPublic);
        var execute=writerType.GetMethod("Execute",BindingFlags.Static|BindingFlags.NonPublic);
        var validate=writerType.GetMethod("ValidateAuthorizationContext",BindingFlags.Static|BindingFlags.NonPublic);
        var applyAuthorized=writerType.GetMethod("ApplyAuthorized",BindingFlags.Static|BindingFlags.NonPublic);
        var executeAuthorized=writerType.GetMethod("ExecuteAuthorized",BindingFlags.Static|BindingFlags.NonPublic);
        Require(applyAuthorized!=null && executeAuthorized!=null,"Missing production authorized adjustment entry points");
        Require(validate!=null,"Missing writer-side actor authorization boundary");
        using(var db=new MySqlConnection(cs)) {
            db.Open();
            Require(Number(db,"SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME IN ('TABLE_ARTICLES','TABLE_PARAMETRES','TABLE_MOUVEMENTS_STOCK')")==0m,"Refusing existing fixture tables");
            Sql(db,"CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(128) PRIMARY KEY,STOCK DECIMAL(18,3),Code TEXT,Article TEXT) ENGINE=InnoDB");
            Sql(db,"CREATE TABLE TABLE_PARAMETRES (OBJET VARCHAR(128),VALEUR VARCHAR(32)) ENGINE=InnoDB");
            Sql(db,"CREATE TABLE TABLE_MOUVEMENTS_STOCK (DATES DATETIME,HEURE VARCHAR(16),LIBELLE VARCHAR(255),ID_ARTICLE VARCHAR(128),CODE_ARTICLE TEXT,ARTICLE TEXT,QUANTITE DECIMAL(18,3)) ENGINE=InnoDB");
            try {
                Sql(db,"INSERT INTO TABLE_ARTICLES VALUES ('CI-ARTICLE',10,'CI','Fixture'); INSERT INTO TABLE_PARAMETRES VALUES ('MODIF_STOCK_MANUEL','True')");
                foreach(string actor in new[]{"FORGED","ADMIN","CI-USER"}) {
                    object plan=create.Invoke(null,new object[]{"CI-ARTICLE",10m,12m,"denied manual adjustment",actor});
                    Denied(()=>execute.Invoke(null,new object[]{cs,plan}));
                    using(var tx=db.BeginTransaction()) {
                        Denied(()=>apply.Invoke(null,new object[]{db,tx,plan}));
                        tx.Commit();
                    }
                }
                object scopedPlan=create.Invoke(null,new object[]{"CI-ARTICLE",10m,12m,"scoped authorization check","CI-USER"});
                Denied(()=>executeAuthorized.Invoke(null,new object[]{cs,scopedPlan,deny,"CI-SESSION"}));
                Denied(()=>executeAuthorized.Invoke(null,new object[]{cs,scopedPlan,null,"CI-SESSION"}));
                using(var authorizedTx=db.BeginTransaction()) {
                    Denied(()=>applyAuthorized.Invoke(null,new object[]{db,authorizedTx,scopedPlan,deny,"CI-SESSION"}));
                    authorizedTx.Commit();
                }
                using(var tx=db.BeginTransaction()) {
                    Denied(()=>validate.Invoke(null,new object[]{db,tx,scopedPlan,null,"CI-SESSION"}));
                    Denied(()=>validate.Invoke(null,new object[]{db,tx,scopedPlan,deny,""}));
                    Denied(()=>validate.Invoke(null,new object[]{db,tx,scopedPlan,deny,"FORGED-SESSION"}));
                    Denied(()=>validate.Invoke(null,new object[]{db,null,scopedPlan,deny,"CI-SESSION"}));
                    Denied(()=>validate.Invoke(null,new object[]{null,tx,scopedPlan,deny,"CI-SESSION"}));
                    tx.Commit();
                }
                // A default provider cannot confer a grant even when the
                // transaction is live and the claimed user/session look valid.
                using(var validTx=db.BeginTransaction()) {
                    Denied(()=>validate.Invoke(null,new object[]{db,validTx,scopedPlan,deny,"CI-SESSION"}));
                    validTx.Rollback();
                }
                // A committed transaction cannot be recycled as proof of a live
                // authorization transaction, even if Connector/NET retains its object.
                var completed=db.BeginTransaction();
                completed.Commit();
                Denied(()=>validate.Invoke(null,new object[]{db,completed,scopedPlan,deny,"CI-SESSION"}));
                completed.Dispose();
                // Reject a transaction belonging to a different live connection:
                // authorization and stock must be checked atomically on one DB session.
                using(var second=new MySqlConnection(cs)) {
                    second.Open();
                    using(var otherTx=second.BeginTransaction()) {
                        Denied(()=>validate.Invoke(null,new object[]{db,otherTx,scopedPlan,deny,"CI-SESSION"}));
                        otherTx.Rollback();
                    }
                }
                Require(Number(db,"SELECT STOCK FROM TABLE_ARTICLES")==10m && Number(db,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK")==0m,"Denied actor changed stock/audit");
                // Explicit disposable-only persisted grant fixture. No migration
                // or automatic table creation occurs in production writer code.
                Sql(db,"CREATE TABLE HANOUTY_AUTH_SESSIONS (SESSION_TOKEN VARCHAR(128) PRIMARY KEY,ACTOR_ID VARCHAR(128) NOT NULL,EXPIRES_AT DATETIME NOT NULL,REVOKED_AT DATETIME NULL) ENGINE=InnoDB");
                Sql(db,"CREATE TABLE HANOUTY_ACTOR_GRANTS (ACTOR_ID VARCHAR(128) NOT NULL,PERMISSION_CODE VARCHAR(80) NOT NULL,EXPIRES_AT DATETIME NULL,REVOKED_AT DATETIME NULL,PRIMARY KEY(ACTOR_ID,PERMISSION_CODE)) ENGINE=InnoDB");
                try {
                    Sql(db,"INSERT INTO HANOUTY_AUTH_SESSIONS VALUES ('CI-SECRET-SESSION','CI-USER',DATE_ADD(UTC_TIMESTAMP(),INTERVAL 1 HOUR),NULL)");
                    Sql(db,"INSERT INTO HANOUTY_ACTOR_GRANTS VALUES ('CI-USER','ManualStockAdjustment',NULL,NULL)");
                    var providerType=assembly.GetType("LOGICA.Infrastructure.Inventory.MariaDbManualStockAuthorization",true);
                    var provider=Activator.CreateInstance(providerType,true);
                    Denied(()=>executeAuthorized.Invoke(null,new object[]{cs,scopedPlan,provider,"FORGED-SESSION"}));
                    Require(Number(db,"SELECT STOCK FROM TABLE_ARTICLES")==10m,"Forged session changed stock");
                    executeAuthorized.Invoke(null,new object[]{cs,scopedPlan,provider,"CI-SECRET-SESSION"});
                    Require(Number(db,"SELECT STOCK FROM TABLE_ARTICLES")==12m,"Authorized stock not persisted");
                    Require(Number(db,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK")==1m,"Authorized movement audit missing");
                    Require(Number(db,"SELECT QUANTITE FROM TABLE_MOUVEMENTS_STOCK")==2m,"Incorrect audited movement delta");
                    // Caller-owned authorized writes must participate in the
                    // outer transaction: rolling it back removes BOTH stock and
                    // the movement audit, not just one of them.
                    object rollbackPlan=create.Invoke(null,new object[]{"CI-ARTICLE",12m,14m,"rollback authorized stock and audit","CI-USER"});
                    using(var rollbackTx=db.BeginTransaction()) {
                        applyAuthorized.Invoke(null,new object[]{db,rollbackTx,rollbackPlan,provider,"CI-SECRET-SESSION"});
                        rollbackTx.Rollback();
                    }
                    Require(Number(db,"SELECT STOCK FROM TABLE_ARTICLES")==12m &&
                        Number(db,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK")==1m,
                        "Caller rollback failed to restore stock and audit atomically");
                    // Stale before-stock cannot overwrite a committed change.
                    using(var staleTx=db.BeginTransaction()) {
                        try {
                            applyAuthorized.Invoke(null,new object[]{db,staleTx,scopedPlan,provider,"CI-SECRET-SESSION"});
                            throw new Exception("Stale stock snapshot accepted");
                        } catch(TargetInvocationException ex) {
                            if(!(ex.InnerException is InvalidOperationException)) throw;
                        }
                        staleTx.Rollback();
                    }
                    Require(Number(db,"SELECT STOCK FROM TABLE_ARTICLES")==12m &&
                        Number(db,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK")==1m,
                        "Stale stock attempt changed stock or audit");
                    Denied(()=>executeAuthorized.Invoke(null,new object[]{cs,scopedPlan,provider,"FORGED-SESSION"}));
                    Sql(db,"UPDATE HANOUTY_ACTOR_GRANTS SET REVOKED_AT=UTC_TIMESTAMP() WHERE ACTOR_ID='CI-USER'");
                    object nextPlan=create.Invoke(null,new object[]{"CI-ARTICLE",12m,13m,"revoked grant","CI-USER"});
                    Denied(()=>executeAuthorized.Invoke(null,new object[]{cs,nextPlan,provider,"CI-SECRET-SESSION"}));
                    Require(Number(db,"SELECT STOCK FROM TABLE_ARTICLES")==12m && Number(db,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK")==1m,"Revoked grant changed stock or audit");
                    Sql(db,"UPDATE HANOUTY_ACTOR_GRANTS SET REVOKED_AT=NULL WHERE ACTOR_ID='CI-USER'");
                    Sql(db,"UPDATE HANOUTY_AUTH_SESSIONS SET REVOKED_AT=UTC_TIMESTAMP() WHERE SESSION_TOKEN='CI-SECRET-SESSION'");
                    Denied(()=>executeAuthorized.Invoke(null,new object[]{cs,nextPlan,provider,"CI-SECRET-SESSION"}));
                    Sql(db,"UPDATE HANOUTY_AUTH_SESSIONS SET REVOKED_AT=NULL,EXPIRES_AT=DATE_SUB(UTC_TIMESTAMP(),INTERVAL 1 SECOND) WHERE SESSION_TOKEN='CI-SECRET-SESSION'");
                    Denied(()=>executeAuthorized.Invoke(null,new object[]{cs,nextPlan,provider,"CI-SECRET-SESSION"}));
                    Sql(db,"UPDATE HANOUTY_AUTH_SESSIONS SET EXPIRES_AT=DATE_ADD(UTC_TIMESTAMP(),INTERVAL 1 HOUR) WHERE SESSION_TOKEN='CI-SECRET-SESSION'");
                    Sql(db,"UPDATE HANOUTY_ACTOR_GRANTS SET EXPIRES_AT=DATE_SUB(UTC_TIMESTAMP(),INTERVAL 1 SECOND) WHERE ACTOR_ID='CI-USER'");
                    Denied(()=>executeAuthorized.Invoke(null,new object[]{cs,nextPlan,provider,"CI-SECRET-SESSION"}));
                    Require(Number(db,"SELECT STOCK FROM TABLE_ARTICLES")==12m && Number(db,"SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK")==1m,"Revoked or expired session/grant changed stock or audit");
                } finally {
                    Sql(db,"DROP TABLE HANOUTY_ACTOR_GRANTS; DROP TABLE HANOUTY_AUTH_SESSIONS");
                }
                Console.WriteLine("PASS persisted actor-scoped authorized adjustment, audit and revoked/forged denial on disposable MariaDB.");
            } finally {
                Sql(db,"DROP TABLE TABLE_MOUVEMENTS_STOCK; DROP TABLE TABLE_PARAMETRES; DROP TABLE TABLE_ARTICLES");
            }
        }
        return 0;
    }
}
