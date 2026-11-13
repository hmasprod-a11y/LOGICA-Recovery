using System;
using System.Collections.Generic;
using Hanouty.Inventory.MariaDb;
using MySql.Data.MySqlClient;

static class Program
{
    private static int _assertions;

    private static void Require(bool condition, string name)
    {
        if (!condition) throw new InvalidOperationException("FAIL: " + name);
        _assertions++;
        Console.WriteLine("PASS: " + name);
    }

    private static void Throws<T>(Action action, string name) where T : Exception
    {
        try { action(); }
        catch (T) { _assertions++; Console.WriteLine("PASS: " + name); return; }
        throw new InvalidOperationException("FAIL: " + name + " (expected " + typeof(T).Name + ")");
    }

    private static void Execute(MySqlConnection connection, string sql)
    {
        using var command = new MySqlCommand(sql, connection);
        command.ExecuteNonQuery();
    }

    private static decimal ReadStock(MySqlConnection connection, string id)
    {
        using var command = new MySqlCommand(
            "SELECT STOCK FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE=BINARY @id", connection);
        command.Parameters.AddWithValue("@id", id);
        return Convert.ToDecimal(command.ExecuteScalar());
    }

    private static int Main()
    {
        string raw = Environment.GetEnvironmentVariable("HANOUTY_INVENTORY_SNAPSHOT_TEST_DB") ?? "";
        var settings = new MySqlConnectionStringBuilder(raw);
        if (!((settings.Server == "127.0.0.1") || settings.Server.Equals("localhost", StringComparison.OrdinalIgnoreCase)) ||
            settings.Port != 3307 || settings.Database != "snapshot_ci")
            throw new InvalidOperationException("Refusing non-disposable database; require loopback:3307/snapshot_ci.");

        bool created = false;
        try
        {
            using (var connection = new MySqlConnection(raw))
            {
                connection.Open();
                using (var existing = new MySqlCommand(
                    "SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='TABLE_ARTICLES'",
                    connection))
                {
                    if (Convert.ToInt32(existing.ExecuteScalar()) != 0)
                        throw new InvalidOperationException("Refusing to replace an existing TABLE_ARTICLES fixture.");
                }

                Execute(connection,
                    "CREATE TABLE TABLE_ARTICLES (" +
                    "ID_ARTICLE VARCHAR(128) NOT NULL PRIMARY KEY, Code VARCHAR(128) NULL, " +
                    "STOCK DECIMAL(18,3) NULL, PRIX_V_1 DECIMAL(18,3) NULL, Prix_A DECIMAL(18,3) NULL) ENGINE=InnoDB");
                created = true;
                using var insert = new MySqlCommand(
                    "INSERT INTO TABLE_ARTICLES (ID_ARTICLE,Code,STOCK,PRIX_V_1,Prix_A) VALUES " +
                    "(@id1,'DUP',2.500,10.250,4.125),(@id2,'DUP',0,12,6),(@id3,@barcode,-1.250,3,2)", connection);
                insert.Parameters.AddWithValue("@id1", "A-1");
                insert.Parameters.AddWithValue("@id2", "A-2");
                insert.Parameters.AddWithValue("@id3", "A-'3");
                insert.Parameters.AddWithValue("@barcode", "CODE-'42");
                insert.ExecuteNonQuery();
            }

            var remote = new MySqlConnectionStringBuilder(raw) { Server = "198.51.100.9" };
            Throws<InvalidOperationException>(
                () => _ = new MariaDbInventorySnapshotReader(remote.ConnectionString),
                "remote database is rejected before connection");

            var reader = new MariaDbInventorySnapshotReader(raw);
            var exact = reader.ReadArticle("A-'3");
            Require(exact.ArticleId == "A-'3" && exact.Barcode == "CODE-'42" &&
                exact.Stock == -1.250m && exact.SalePrice == 3m && exact.PurchasePrice == 2m,
                "stable identity and quoted barcode read exactly");

            var ordered = reader.ReadArticlesByIds(new[] { "A-2", "A-1" });
            Require(ordered.Count == 2 && ordered[0].ArticleId == "A-2" && ordered[1].ArticleId == "A-1",
                "explicit ID batch preserves requested order");
            Throws<InvalidOperationException>(() => reader.ReadArticle("' OR 1=1 --"),
                "injection-shaped article ID cannot broaden a lookup");
            Throws<InvalidOperationException>(() => reader.ReadArticlesByIds(new[] { "A-1", "MISSING" }),
                "batch fails closed when any ID is missing");
            Throws<ArgumentException>(() => reader.ReadArticlesByIds(new[] { "A-1", "A-1" }),
                "duplicate requested IDs are rejected");

            Require(reader.FindBarcode("DUP").Count == 2, "duplicate barcode matches remain visible for explicit selection");
            Throws<InvalidOperationException>(() => reader.ReadUniqueBarcode("DUP"),
                "ambiguous barcode never selects the first variant");
            Require(reader.ReadUniqueBarcode("CODE-'42").ArticleId == "A-'3",
                "unique quoted barcode resolves by exact identity");
            Throws<ArgumentException>(() => reader.FindBarcode(" "),
                "blank barcode is not treated as an identity");

            var preview = reader.PreviewCountDiscrepancies(new Dictionary<string, decimal>
            {
                ["A-1"] = 3.000m
            });
            Require(preview.Count == 1 && preview[0].ArticleId == "A-1" &&
                preview[0].BookUnits == 2.500m && preview[0].DeltaUnits == 0.500m &&
                preview[0].PurchaseCostDelta == 2.0625m,
                "physical-count preview calculates exact signed delta and cost");
            Throws<ArgumentException>(
                () => reader.PreviewCountDiscrepancies(new Dictionary<string, decimal> { ["A-1"] = -1m }),
                "negative physical counts are rejected");

            using (var connection = new MySqlConnection(raw))
            {
                connection.Open();
                Require(ReadStock(connection, "A-1") == 2.500m && ReadStock(connection, "A-'3") == -1.250m,
                    "all snapshot and preview operations leave stock unchanged");
            }

            var totals = reader.ReadStocktakeTotals();
            Require(totals.ArticleCount == 3 && totals.SignedUnits == 1.250m &&
                totals.PositiveStockArticles == 1 && totals.ZeroStockArticles == 1 &&
                totals.NegativeStockArticles == 1,
                "stocktake totals preserve positive, zero, and negative quantities");

            Console.WriteLine("PASS: " + _assertions + " inventory snapshot assertions");
            return 0;
        }
        finally
        {
            if (created)
            {
                using var cleanup = new MySqlConnection(raw);
                cleanup.Open();
                Execute(cleanup, "DROP TABLE TABLE_ARTICLES");
            }
        }
    }
}
