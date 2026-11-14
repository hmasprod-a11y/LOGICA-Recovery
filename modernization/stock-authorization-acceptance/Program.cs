using LOGICA.Application.Inventory;
using LOGICA.Infrastructure.Inventory;
using LOGICA.Infrastructure.Catalogue;
using System.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

static class Program
{
    static void Require(bool ok, string message) { if (!ok) throw new Exception(message); }
    static StockAdjustmentPlan Plan(string user) => StockAdjustmentPlan.Create("P0-ARTICLE", 10m, 12m, "permission regression", user);
    static void Denied(Action action)
    {
        try { action(); }
        catch (UnauthorizedAccessException) { return; }
        throw new Exception("Unverified manual adjustment was not rejected.");
    }
    static void Sql(MySqlConnection c, MySqlTransaction tx, string sql) {
        using var cmd = new MySqlCommand(sql, c, tx); cmd.ExecuteNonQuery();
    }
    static decimal Number(MySqlConnection c, string sql) {
        using var cmd = new MySqlCommand(sql, c);
        return Convert.ToDecimal(cmd.ExecuteScalar(), CultureInfo.InvariantCulture);
    }
    static int Main(string[] args)
    {
        foreach (var actor in new[] { "FORGED", "ADMIN", "trusted-looking-user" }) {
            Denied(() => StockAdjustmentWriter.Execute("Server=192.0.2.10;Database=never_connect;", Plan(actor)));
            Denied(() => StockAdjustmentWriter.Apply(null, null, Plan(actor)));
        }
        Console.WriteLine("PASS actual production Execute/Apply deny unverified actors before any connection");
        if (args.Contains("--no-database")) return 0;
        var cs = Environment.GetEnvironmentVariable("HANOUTY_P0_TEST_CONNECTION")
            ?? throw new Exception("Explicit disposable connection required.");
        var settings = new MySqlConnectionStringBuilder(cs);
        Require(settings.Server == "127.0.0.1" && settings.Port == 3307 &&
            settings.Database == "logica_ci" &&
            Environment.GetEnvironmentVariable("HANOUTY_P0_DISPOSABLE") == "YES", "Unsafe fixture target");
        using var db = new MySqlConnection(cs); db.Open();
        // CREATE without DROP/REPLACE: never overwrite someone else's data.
        Sql(db, null, "CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(128) PRIMARY KEY, STOCK DECIMAL(18,3), Code TEXT, Article TEXT) ENGINE=InnoDB");
        Sql(db, null, "CREATE TABLE TABLE_PARAMETRES (OBJET VARCHAR(128), VALEUR VARCHAR(32)) ENGINE=InnoDB");
        Sql(db, null, "CREATE TABLE TABLE_MOUVEMENTS_STOCK (LIBELLE VARCHAR(255), QUANTITE DECIMAL(18,3)) ENGINE=InnoDB");
        Sql(db, null, "INSERT INTO TABLE_ARTICLES VALUES ('P0-ARTICLE',10,'P0','Test'); INSERT INTO TABLE_PARAMETRES VALUES ('MODIF_STOCK_MANUEL','True')");
        foreach (var enabled in new[] { "True", "False", "True" }) {
            Sql(db, null, "UPDATE TABLE_PARAMETRES SET VALEUR='" + enabled + "'");
            foreach (var actor in new[] { "FORGED", "ADMIN", "trusted-looking-user" }) {
                Denied(() => StockAdjustmentWriter.Execute(cs, Plan(actor)));
                using var tx = db.BeginTransaction();
                Denied(() => StockAdjustmentWriter.Apply(db, tx, Plan(actor)));
                // Even an incorrect caller committing after denial leaves no partial write.
                tx.Commit();
            }
        }
        Task.WaitAll(Enumerable.Range(0, 2).Select(_ => Task.Run(() => {
            using var concurrent = new MySqlConnection(cs); concurrent.Open();
            using var tx = concurrent.BeginTransaction();
            Denied(() => StockAdjustmentWriter.Apply(concurrent, tx, Plan("ADMIN")));
            tx.Commit();
        })).ToArray());
        Require(Number(db, "SELECT STOCK FROM TABLE_ARTICLES") == 10m &&
            Number(db, "SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 0m,
            "Denied/forged/concurrent requests changed stock or audit.");
        // An unavailable audit store cannot weaken the authorization gate.
        Sql(db, null, "RENAME TABLE TABLE_MOUVEMENTS_STOCK TO blocked_audit");
        Denied(() => StockAdjustmentWriter.Execute(cs, Plan("ADMIN")));
        Require(Number(db, "SELECT STOCK FROM TABLE_ARTICLES") == 10m &&
            Number(db, "SELECT COUNT(*) FROM blocked_audit") == 0m, "Audit unavailable caused partial writes.");
        Console.WriteLine("PASS real MariaDB: global flag cannot authorize, forged actors denied, concurrent/outer-commit denial preserves stock+audit. Manual adjustment remains DISABLED.");

        // The production catalogue editor must use the current persisted setting,
        // lock it through the stock write, and reject stale UI snapshots.
        Sql(db, null, "INSERT INTO TABLE_PARAMETRES VALUES ('AJOUT_STOCK_MANUEL','False')");
        Sql(db, null, "UPDATE TABLE_PARAMETRES SET VALEUR='False' WHERE OBJET='MODIF_STOCK_MANUEL'");
        using (var adapter = new MySqlDataAdapter("SELECT * FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'", db))
        {
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            var articles = new DataTable(); adapter.Fill(articles);
            Require(articles.Rows.Count == 1, "Catalogue edit fixture missing.");
            articles.Rows[0]["STOCK"] = 12m;
            Denied(() => CatalogueRowPersistence.UpdateAndAccept(adapter, articles));
            Require(Number(db, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'") == 10m,
                "Disabled article stock edit reached MariaDB.");
        }
        Sql(db, null, "UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='MODIF_STOCK_MANUEL'");
        using (var adapter = new MySqlDataAdapter("SELECT * FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'", db))
        {
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            var articles = new DataTable(); adapter.Fill(articles);
            articles.Rows[0]["STOCK"] = 12m;
            Sql(db, null, "UPDATE TABLE_PARAMETRES SET VALEUR='False' WHERE OBJET='MODIF_STOCK_MANUEL'");
            Denied(() => CatalogueRowPersistence.UpdateAndAccept(adapter, articles));
            Require(Number(db, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'") == 10m,
                "Stale enabled UI setting bypassed the persisted deny setting.");
        }
        Sql(db, null, "UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='MODIF_STOCK_MANUEL'");
        using (var adapter = new MySqlDataAdapter("SELECT * FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'", db))
        {
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            var articles = new DataTable(); adapter.Fill(articles);
            articles.Rows[0]["STOCK"] = 12m;
            CatalogueRowPersistence.UpdateAndAccept(adapter, articles);
            Require(Number(db, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'") == 12m,
                "Enabled stock edit did not persist atomically.");
        }
        Sql(db, null, "UPDATE TABLE_PARAMETRES SET VALEUR='False' WHERE OBJET='AJOUT_STOCK_MANUEL'");
        using (var adapter = new MySqlDataAdapter("SELECT * FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'", db))
        {
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            var articles = new DataTable(); adapter.Fill(articles);
            var added = articles.NewRow(); added["ID_ARTICLE"] = "P0-NEW-ARTICLE";
            added["STOCK"] = 2m; added["Code"] = "NEW"; added["Article"] = "New"; articles.Rows.Add(added);
            Denied(() => CatalogueRowPersistence.UpdateAndAccept(adapter, articles));
            Require(Number(db, "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-NEW-ARTICLE'") == 0m,
                "Disabled initial stock allowed new article persistence.");
        }
        using (var tx = db.BeginTransaction())
        {
            Denied(() => CatalogueRowPersistence.RequireManualStockPermission(db, tx, "AJOUT_STOCK_MANUEL"));
            tx.Rollback();
        }
        Sql(db, null, "UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='AJOUT_STOCK_MANUEL'");
        using (var tx = db.BeginTransaction())
        {
            CatalogueRowPersistence.RequireManualStockPermission(db, tx, "AJOUT_STOCK_MANUEL");
            tx.Rollback();
        }
        Require(Number(db, "SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-ARTICLE'") == 12m &&
            Number(db, "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE ID_ARTICLE='P0-NEW-ARTICLE'") == 0m,
            "Catalogue permission integration left an unexpected article write.");
        Console.WriteLine("PASS real MariaDB: edit/add/collection stock guards deny disabled or stale UI settings, permit configured edits, and preserve transaction boundaries.");
        return 0;
    }
}
