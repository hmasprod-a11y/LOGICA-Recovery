using System;
using System.IO;
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
        string connectionString = Environment.GetEnvironmentVariable("HANOUTY_W1_TEST_CONNECTION") ?? "";
        if (Environment.GetEnvironmentVariable("HANOUTY_W1_DISPOSABLE_MARKER") != "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY") throw new InvalidOperationException("Disposable DB acknowledgement required");
        var builder = new MySqlConnectionStringBuilder(connectionString);
        if (!(builder.Server == "127.0.0.1" || builder.Server == "localhost") ||
            builder.Port != 3306 || builder.Database != "hanouty_w1_disposable")
            throw new InvalidOperationException("Refusing non-disposable MariaDB; requires loopback:3306/hanouty_w1_disposable");
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
                Sql(db, "CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(128) NULL, Code VARCHAR(128) NULL, Article VARCHAR(255), Images VARCHAR(255)) ENGINE=InnoDB");
                fixtureCreated = true;
                Sql(db, "INSERT INTO TABLE_ARTICLES VALUES ('A-1','Q''42','First','exists.png'),('A-2','Q''42','Variant','missing.png'),('A-3',NULL,'No barcode',NULL),('A-4','','Image-only','0')");
            }
            var reader = new MariaDbCatalogueReader(connectionString, folder);
            var all = reader.ListAll();
            Assert(all.Count == 4, "all products, including NULL and empty barcode");
            Assert(all.Count(p => p.ImagePath != null) == 1 && File.Exists(all.Single(p => p.ImagePath != null).ImagePath), "only existing photos");
            Assert(reader.FindBarcode("Q'42").Count == 2, "quoted duplicate barcode candidates preserved");
            Assert(reader.RefreshBarcode("Q'42").Count == 2, "refresh duplicate barcode candidates");
            Assert(reader.FindBarcode("Q'42' OR 1=1 --").Count == 0, "barcode SQL injection cannot broaden");
            Assert(reader.FindBarcode("").Count == 1, "empty barcode is not NULL");
            Assert(reader.RefreshArticle("A-2").Single().ArticleId == "A-2", "stable article identity");
            Assert(reader.RefreshArticle("A-2' OR 1=1 --").Count == 0, "identity SQL injection cannot broaden");
            using (var db = new MySqlConnection(connectionString))
            {
                db.Open();
                Sql(db, "INSERT INTO TABLE_ARTICLES VALUES ('A-1','OTHER','Duplicate','0')");
            }
            bool duplicateRejected = false;
            try { reader.ListAll(); } catch (InvalidOperationException) { duplicateRejected = true; }
            Assert(duplicateRejected, "duplicate stable article identity rejected");
            using (var db = new MySqlConnection(connectionString))
            {
                db.Open();
                Sql(db, "DELETE FROM TABLE_ARTICLES WHERE Code='OTHER'");
                Sql(db, "INSERT INTO TABLE_ARTICLES VALUES (NULL,'ORPHAN','Missing ID',NULL)");
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
