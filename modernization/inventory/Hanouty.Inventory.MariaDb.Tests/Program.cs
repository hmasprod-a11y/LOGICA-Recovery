using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using Hanouty.Inventory.MariaDb;

static class Program
{
    static void Assert(bool condition, string message) { if (!condition) throw new Exception("FAIL " + message); Console.WriteLine("PASS " + message); }
    static void Sql(MySqlConnection connection, string sql)
    {
        using var cmd = new MySqlCommand(sql, connection);
        cmd.ExecuteNonQuery();
    }
    static int Main()
    {
        string connectionString = Environment.GetEnvironmentVariable("HANOUTY_W1_TEST_DB") ?? "";
        var builder = new MySqlConnectionStringBuilder(connectionString);
        if (!(builder.Server == "127.0.0.1" || builder.Server == "localhost") ||
            builder.Port != 3307 || builder.Database != "logica_ci")
            throw new InvalidOperationException("Refusing non-disposable MariaDB; requires loopback:3307/logica_ci");
        var folder = Path.Combine(Path.GetTempPath(), "hanouty-w1-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(Path.Combine(folder, "bd", "images"));
        bool fixtureCreated = false;
        File.WriteAllBytes(Path.Combine(folder, "bd", "images", "exists.png"), new byte[] { 137, 80, 78, 71 });
        try
        {
            using (var db = new MySqlConnection(connectionString))
            {
                db.Open();
                // Dedicated CI-only database; replace only the fixture table, never any shop schema.
                using (var check = new MySqlCommand("SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'TABLE_ARTICLES'", db))
                {
                    if (Convert.ToInt64(check.ExecuteScalar()) != 0)
                        throw new InvalidOperationException("Refusing existing TABLE_ARTICLES even on disposable target.");
                }
                Sql(db, "CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(128) NULL, Code VARCHAR(128) NULL, Article VARCHAR(255), Images VARCHAR(255), STOCK DECIMAL(18,3) NULL, PRIX_V_1 DECIMAL(18,3) NULL, Prix_A DECIMAL(18,3) NULL) ENGINE=InnoDB");
                fixtureCreated = true;
                Sql(db, "INSERT INTO TABLE_ARTICLES VALUES ('A-1','Q''42','First','exists.png',5.500,12.250,7.125),('A-2','Q''42','Variant','missing.png',0,14,8),('A-3',NULL,'No barcode',NULL,2,4,3),('A-4','','Image-only','0',-1,5,4)");
            }
            var remote = new MySqlConnectionStringBuilder(connectionString) { Server = "198.51.100.9" };
            bool remoteRejected = false;
            try { _ = new MariaDbCatalogueReader(remote.ConnectionString, folder); }
            catch (InvalidOperationException) { remoteRejected = true; }
            Assert(remoteRejected, "remote catalogue connection rejected before opening");
            var inventory = new MariaDbInventorySnapshotReader(connectionString);
            Assert(inventory.ReadArticle("A-1").Stock == 5.500m &&
                   inventory.ReadArticle("A-1").SalePrice == 12.250m &&
                   inventory.ReadArticle("A-1").PurchasePrice == 7.125m, "snapshot exact article and decimal prices");
            Assert(inventory.ListAll().Select(x => x.ArticleId).OrderBy(x => x).SequenceEqual(new[] { "A-1", "A-2", "A-3", "A-4" }), "stocktake includes all stable article IDs including missing barcodes");
            Assert(inventory.ListAll().Sum(x => x.Stock) == 6.500m, "stocktake preserves signed decimal stock without rounding");
            Assert(inventory.ReadArticlesByIds(new[] { "A-4", "A-1" }).Select(x => x.ArticleId).SequenceEqual(new[] { "A-4", "A-1" }), "explicit batch preserves requested stable-ID order");
            Assert(inventory.ReadArticlesByIds(Array.Empty<string>()).Count == 0, "empty explicit batch does not query catalogue");
            bool batchMissing = false;
            try { inventory.ReadArticlesByIds(new[] { "A-1", "MISSING" }); } catch (InvalidOperationException) { batchMissing = true; }
            Assert(batchMissing, "batch fails closed when any stable ID is missing");
            bool batchDuplicate = false;
            try { inventory.ReadArticlesByIds(new[] { "A-1", "A-1" }); } catch (ArgumentException) { batchDuplicate = true; }
            Assert(batchDuplicate, "batch rejects repeated stable IDs");
            bool batchInjection = false;
            try { inventory.ReadArticlesByIds(new[] { "A-1", "A-2' OR 1=1 --" }); } catch (InvalidOperationException) { batchInjection = true; }
            Assert(batchInjection, "batch identity SQL injection does not broaden lookup");
            bool batchTooLarge = false;
            try { inventory.ReadArticlesByIds(Enumerable.Repeat("A-1", 501).ToArray()); } catch (ArgumentOutOfRangeException) { batchTooLarge = true; }
            Assert(batchTooLarge, "batch refuses unbounded ID count");
            var totals = inventory.ReadStocktakeTotals();
            Assert(totals.ArticleCount == 4 && totals.SignedUnits == 6.500m, "stocktake totals include all identities and signed units");
            Assert(totals.PositiveStockArticles == 2 && totals.ZeroStockArticles == 1 && totals.NegativeStockArticles == 1, "stocktake distinguishes positive zero and negative articles");
            Assert(totals.PositiveStockArticles + totals.ZeroStockArticles + totals.NegativeStockArticles == totals.ArticleCount, "stocktake stock status partition covers all articles");
            Assert(totals.PurchaseCostValue == 41.1875m && totals.SalePriceValue == 70.375m, "stocktake purchase/sale valuation retains signed decimal precision");
            var selectedTotals = inventory.ReadStocktakeTotalsForArticles(new[] { "A-4", "A-1" });
            Assert(selectedTotals.ArticleCount == 2 && selectedTotals.SignedUnits == 4.500m, "selected stocktake uses explicit IDs and signed quantities");
            Assert(selectedTotals.PurchaseCostValue == 35.1875m && selectedTotals.SalePriceValue == 62.375m, "selected stocktake values retain decimal precision");
            Assert(selectedTotals.PositiveStockArticles == 1 && selectedTotals.NegativeStockArticles == 1, "selected stocktake status counts");
            Assert(inventory.ReadStocktakeTotalsForArticles(Array.Empty<string>()).ArticleCount == 0, "empty selected stocktake has zero totals");
            bool missingSelection = false;
            try { inventory.ReadStocktakeTotalsForArticles(new[] { "A-1", "MISSING" }); } catch (InvalidOperationException) { missingSelection = true; }
            Assert(missingSelection, "selected stocktake refuses missing stable identity");
            var countPreview = inventory.PreviewCountDiscrepancies(new Dictionary<string, decimal>
            {
                ["A-4"] = 0m, ["A-1"] = 4m
            });
            Assert(countPreview.Select(x => x.ArticleId).SequenceEqual(new[] { "A-4", "A-1" }), "physical count preview retains explicit article IDs");
            Assert(countPreview[0].BookUnits == -1m && countPreview[0].DeltaUnits == 1m && countPreview[0].PurchaseCostDelta == 4m, "count preview recovers signed negative book stock");
            Assert(countPreview[1].BookUnits == 5.500m && countPreview[1].DeltaUnits == -1.500m &&
                   countPreview[1].PurchaseCostDelta == -10.6875m, "count preview calculates exact purchase-cost discrepancy");
            Assert(inventory.PreviewCountDiscrepancies(new Dictionary<string, decimal>()).Count == 0, "empty count preview does not write stock");
            bool missingCount = false;
            try { inventory.PreviewCountDiscrepancies(new Dictionary<string, decimal> { ["MISSING"] = 1m }); }
            catch (InvalidOperationException) { missingCount = true; }
            Assert(missingCount, "physical count preview refuses missing article ID");
            bool negativeCount = false;
            try { inventory.PreviewCountDiscrepancies(new Dictionary<string, decimal> { ["A-1"] = -1m }); }
            catch (ArgumentException) { negativeCount = true; }
            Assert(negativeCount, "physical count preview rejects negative physical counts");
            Assert(inventory.ReadArticle("A-1").Stock == 5.500m && inventory.ReadArticle("A-4").Stock == -1m,
                   "physical count preview leaves authoritative SQL stock unchanged");
            Assert(inventory.FindBarcode("Q'42").Count == 2, "snapshot preserves ambiguous quoted barcode candidates");
            bool ambiguousScan = false;
            try { inventory.ReadUniqueBarcode("Q'42"); } catch (InvalidOperationException) { ambiguousScan = true; }
            Assert(ambiguousScan, "snapshot refuses ambiguous barcode");
            Assert(inventory.FindBarcode("Q'42' OR 1=1 --").Count == 0, "snapshot parameterized barcode");
            Assert(inventory.FindStockBelow(1m).Count == 2, "snapshot low stock includes zero and negative stock");
            Assert(inventory.FindOutOfStock().Select(x => x.ArticleId).OrderBy(x => x).SequenceEqual(new[] { "A-2", "A-4" }), "out-of-stock returns zero and negative articles by stable ID");
            Assert(inventory.FindStockInRange(-1m, 0m).Count == 2, "bounded stock interval includes negative and zero");
            Assert(inventory.FindStockInRange(5.500m, 5.500m).Single().ArticleId == "A-1", "bounded stock interval includes exact decimal boundary");
            Assert(inventory.FindStockInRange(0.001m, 5.499m).Single().ArticleId == "A-3", "bounded stock interval excludes both boundaries");
            bool invertedRange = false;
            try { inventory.FindStockInRange(2m, 1m); } catch (ArgumentException) { invertedRange = true; }
            Assert(invertedRange, "inverted stock interval rejected before SQL");
            bool negativeThreshold = false;
            try { inventory.FindStockBelow(-1m); } catch (ArgumentOutOfRangeException) { negativeThreshold = true; }
            Assert(negativeThreshold, "negative low-stock threshold rejected");
            bool missingArticle = false;
            try { inventory.ReadArticle("MISSING"); } catch (InvalidOperationException) { missingArticle = true; }
            Assert(missingArticle, "missing stable article rejected");
            var reader = new MariaDbCatalogueReader(connectionString, folder);
            var all = reader.ListAll();
            Assert(all.Count == 4, "all products, including NULL and empty barcode");
            Assert(all.All(p => p.VariantId == null), "no fabricated variant identity");
            Assert(reader.FindBarcode("Q\u002742").All(p => p.VariantId == null), "duplicate barcodes do not fabricate variants");
            Assert(all.Count(p => p.ImagePath != null) == 1 && File.Exists(all.Single(p => p.ImagePath != null).ImagePath), "only existing photos");
            Assert(reader.FindBarcode("Q'42").Count == 2, "quoted duplicate barcode candidates preserved");
            using (var db = new MySqlConnection(connectionString))
            {
                db.Open();
                Sql(db, "INSERT INTO TABLE_ARTICLES VALUES ('A-5','TRAVERSAL','Unsafe slash','../exists.png',1,2,1)");
                Sql(db, "INSERT INTO TABLE_ARTICLES VALUES ('A-6','BACKSLASH','Unsafe backslash','..\\\\exists.png',1,2,1)");
            }
            Assert(reader.ListAll().Where(p => p.ArticleId == "A-5" || p.ArticleId == "A-6").All(p => p.ImagePath == null), "slash and backslash traversal images rejected");
            using (var db = new MySqlConnection(connectionString))
            {
                db.Open();
                Sql(db, "DELETE FROM TABLE_ARTICLES WHERE ID_ARTICLE IN ('A-5','A-6')");
            }
            Assert(reader.RefreshBarcode("Q'42").Count == 2, "refresh duplicate barcode candidates");
            Assert(reader.FindBarcode("Q'42' OR 1=1 --").Count == 0, "barcode SQL injection cannot broaden");
            Assert(reader.FindBarcode("").Count == 1, "empty barcode is not NULL");
            Assert(reader.RefreshArticle("A-2").Single().ArticleId == "A-2", "stable article identity");
            Assert(reader.RefreshArticle("A-2' OR 1=1 --").Count == 0, "identity SQL injection cannot broaden");
            using (var db = new MySqlConnection(connectionString))
            {
                db.Open();
                Sql(db, "INSERT INTO TABLE_ARTICLES VALUES ('A-1','OTHER','Duplicate','0',1,2,1)");
            }
            bool duplicateRejected = false;
            try { reader.ListAll(); } catch (InvalidOperationException) { duplicateRejected = true; }
            Assert(duplicateRejected, "duplicate stable article identity rejected");
            using (var db = new MySqlConnection(connectionString))
            {
                db.Open();
                Sql(db, "DELETE FROM TABLE_ARTICLES WHERE Code='OTHER'");
                Sql(db, "INSERT INTO TABLE_ARTICLES VALUES (NULL,'ORPHAN','Missing ID',NULL,1,2,1)");
            }
            bool missingRejected = false;
            try { reader.ListAll(); } catch (InvalidOperationException) { missingRejected = true; }
            Assert(missingRejected, "missing stable article identity rejected");
            using (var db = new MySqlConnection(connectionString))
            {
                db.Open();
                Sql(db, "DELETE FROM TABLE_ARTICLES WHERE ID_ARTICLE IS NULL");
                Sql(db, "DELETE FROM TABLE_ARTICLES");
            }
            Assert(reader.ListAll().Count == 0, "empty catalogue is valid");
            var unreachable = new MySqlConnectionStringBuilder(connectionString) { Port = 1, ConnectionTimeout = 2 };
            bool failedClosed = false;
            try { new MariaDbCatalogueReader(unreachable.ConnectionString, folder).ListAll(); }
            catch (MySqlException) { failedClosed = true; }
            Assert(failedClosed, "connection failure does not return empty catalogue");
            Console.WriteLine("PASS W1 real MariaDB reader fixture");
            return 0;
        }
        finally
        {
            if (fixtureCreated)
                try { using var db = new MySqlConnection(connectionString); db.Open(); Sql(db, "DROP TABLE IF EXISTS TABLE_ARTICLES"); } catch { }
            Directory.Delete(folder, true);
        }
    }
}
