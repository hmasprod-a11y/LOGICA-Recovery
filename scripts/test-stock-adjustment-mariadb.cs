// Disposable MariaDB acceptance for the production StockAdjustmentWriter.
// Requires an explicit isolated logica_ci schema on 127.0.0.1:3307.
// The fixture uses uniquely named InnoDB tables and never touches a shop DB.
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;

internal static class StockAdjustmentMariaDbSmoke
{
    static void Require(bool ok, string message) { if (!ok) throw new Exception(message); }
    static void Sql(MySqlConnection c, MySqlTransaction t, string sql)
    {
        using (var cmd = new MySqlCommand(sql, c, t)) cmd.ExecuteNonQuery();
    }
    static decimal Scalar(MySqlConnection c, MySqlTransaction t, string sql)
    {
        using (var cmd = new MySqlCommand(sql, c, t))
            return Convert.ToDecimal(cmd.ExecuteScalar(), CultureInfo.InvariantCulture);
    }
    static void ExpectFailure(Action action, string scenario)
    {
        try { action(); } catch (TargetInvocationException) { Console.WriteLine("PASS " + scenario); return; }
        throw new Exception("Expected rejection: " + scenario);
    }
    static void Apply(MethodInfo writer, object plan, MySqlConnection c, MySqlTransaction t)
    { writer.Invoke(null, new object[] { c, t, plan }); }

    static int Main()
    {
        string cs = Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING");
        if (String.IsNullOrWhiteSpace(cs)) throw new Exception("Missing isolated CI connection");
        var builder = new MySqlConnectionStringBuilder(cs);
        Require((builder.Server == "127.0.0.1" || builder.Server == "localhost") &&
            builder.Port == 3307 && builder.Database == "logica_ci",
            "Refusing any non-disposable MariaDB target");
        var assembly = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOGICA.exe"));
        var planType = assembly.GetType("LOGICA.Application.Inventory.StockAdjustmentPlan", true);
        var writerType = assembly.GetType("LOGICA.Infrastructure.Inventory.StockAdjustmentWriter", true);
        var create = planType.GetMethod("Create", BindingFlags.Static | BindingFlags.NonPublic);
        var apply = writerType.GetMethod("Apply", BindingFlags.Static | BindingFlags.NonPublic);
        var execute = writerType.GetMethod("Execute", BindingFlags.Static | BindingFlags.NonPublic);
        Require(create != null && apply != null && execute != null, "Production stock adjustment methods missing");
        Func<decimal, decimal, object> plan = (before, after) =>
            create.Invoke(null, new object[] { "CI-ARTICLE", before, after, "CI isolated adjustment", "CI-USER" });

        // The writer expects legacy table names. Run against a freshly-created
        // disposable CI schema only; no automatic schema migration is performed.
        using (var c = new MySqlConnection(cs))
        {
            c.Open();
            // A separate dedicated database is required: fail if any business
            // table already exists, so no original fixtures can be overwritten.
            Require(Scalar(c, null, "SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME IN ('TABLE_ARTICLES','TABLE_MOUVEMENTS_STOCK','TABLE_PARAMETRES')") == 0m,
                "Refusing to overwrite existing tables in logica_ci");
            try
            {
                Sql(c, null, "CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(128), STOCK DECIMAL(18,3), Code VARCHAR(128), Article VARCHAR(255)) ENGINE=InnoDB");
                Sql(c, null, "CREATE TABLE TABLE_PARAMETRES (OBJET VARCHAR(128), VALEUR VARCHAR(32)) ENGINE=InnoDB");
                Sql(c, null, "CREATE TABLE TABLE_MOUVEMENTS_STOCK (DATES DATE, HEURE VARCHAR(16), LIBELLE VARCHAR(255), ID_ARTICLE VARCHAR(128), CODE_ARTICLE VARCHAR(128), ARTICLE VARCHAR(255), QUANTITE DECIMAL(18,3)) ENGINE=InnoDB");
                Sql(c, null, "INSERT INTO TABLE_ARTICLES VALUES ('CI-ARTICLE',10,'CI','Fixture')");
                Sql(c, null, "INSERT INTO TABLE_PARAMETRES VALUES ('MODIF_STOCK_MANUEL','False')");
                using (var tx = c.BeginTransaction())
                {
                    ExpectFailure(() => Apply(apply, plan(10, 12), c, tx), "permission disabled");
                    tx.Rollback();
                }
                ExpectFailure(() => execute.Invoke(null, new object[] { cs, plan(10, 11) }),
                    "owned transaction permission denied");
                Require(Scalar(c, null, "SELECT STOCK FROM TABLE_ARTICLES") == 10m &&
                    Scalar(c, null, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 0m,
                    "Denied owned transaction mutated stock");
                Sql(c, null, "UPDATE TABLE_PARAMETRES SET VALEUR='True'");
                using (var tx = c.BeginTransaction())
                {
                    ExpectFailure(() => Apply(apply, plan(10, 12), c, tx),
                        "missing unique article identity index");
                    tx.Rollback();
                }
                Require(Scalar(c, null, "SELECT STOCK FROM TABLE_ARTICLES") == 10m &&
                    Scalar(c, null, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 0m,
                    "Unsafe schema rejection mutated stock");
                Sql(c, null, "ALTER TABLE TABLE_ARTICLES ADD UNIQUE KEY ci_article_identity (ID_ARTICLE)");
                using (var tx = c.BeginTransaction())
                {
                    Apply(apply, plan(10, 12), c, tx);
                    tx.Rollback();
                }
                Require(Scalar(c, null, "SELECT STOCK FROM TABLE_ARTICLES") == 10m &&
                    Scalar(c, null, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 0m,
                    "Outer rollback must undo stock and audit");
                using (var tx = c.BeginTransaction())
                {
                    Apply(apply, plan(10, 12), c, tx);
                    tx.Commit();
                }
                Require(Scalar(c, null, "SELECT STOCK FROM TABLE_ARTICLES") == 12m &&
                    Scalar(c, null, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 1m,
                    "Successful adjustment must atomically persist stock and movement");
                using (var tx = c.BeginTransaction())
                {
                    ExpectFailure(() => Apply(apply, plan(10, 15), c, tx), "stale snapshot");
                    tx.Rollback();
                }
                bool duplicateRejected = false;
                try { Sql(c, null, "INSERT INTO TABLE_ARTICLES VALUES ('CI-ARTICLE',12,'CI','Duplicate')"); }
                catch (MySqlException ex) { duplicateRejected = ex.Number == 1062; }
                Require(duplicateRejected, "UNIQUE identity must reject concurrent duplicate inserts");
                Require(Scalar(c, null, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 1m,
                    "Rejected attempts must not write audit");

                // Force a journal insert failure after the stock UPDATE. Even when
                // the caller catches the exception and commits its outer transaction,
                // the writer's savepoint must undo the stock mutation.
                Sql(c, null, "ALTER TABLE TABLE_MOUVEMENTS_STOCK ADD CONSTRAINT ci_audit_reject CHECK (QUANTITE < 3)");
                using (var tx = c.BeginTransaction())
                {
                    ExpectFailure(() => Apply(apply, plan(12, 16), c, tx), "audit insert failure");
                    tx.Commit();
                }
                Require(Scalar(c, null, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CI-ARTICLE'") == 12m &&
                    Scalar(c, null, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 1m,
                    "Savepoint must undo stock after failed audit even if caller commits");
                Sql(c, null, "ALTER TABLE TABLE_MOUVEMENTS_STOCK DROP CONSTRAINT ci_audit_reject");
                execute.Invoke(null, new object[] { cs, plan(12, 13) });
                Require(Scalar(c, null, "SELECT STOCK FROM TABLE_ARTICLES") == 13m &&
                    Scalar(c, null, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 2m,
                    "Owned transaction must commit stock and audit");
                ExpectFailure(() => execute.Invoke(null, new object[] { cs, plan(12, 14) }),
                    "owned transaction stale snapshot");
                Require(Scalar(c, null, "SELECT STOCK FROM TABLE_ARTICLES") == 13m &&
                    Scalar(c, null, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 2m,
                    "Failed owned transaction mutated stock");
                Console.WriteLine("PASS production MariaDB permission, rollback, commit, stale and duplicate-ID checks");
            }
            finally
            {
                // Only tables created by this invocation are removed.
                Sql(c, null, "DROP TABLE IF EXISTS TABLE_MOUVEMENTS_STOCK");
                Sql(c, null, "DROP TABLE IF EXISTS TABLE_PARAMETRES");
                Sql(c, null, "DROP TABLE IF EXISTS TABLE_ARTICLES");
            }
        }
        return 0;
    }
}
