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
            Sql(db,"CREATE TABLE TABLE_MOUVEMENTS_STOCK (LIBELLE VARCHAR(255),QUANTITE DECIMAL(18,3)) ENGINE=InnoDB");
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
                Console.WriteLine("PASS actual LOGICA Execute/Apply reject unverified actors with feature enabled; stock/audit unchanged. Manual adjustment remains DISABLED.");
            } finally {
                Sql(db,"DROP TABLE TABLE_MOUVEMENTS_STOCK; DROP TABLE TABLE_PARAMETRES; DROP TABLE TABLE_ARTICLES");
            }
        }
        return 0;
    }
}
