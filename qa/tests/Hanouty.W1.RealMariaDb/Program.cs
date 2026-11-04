using Hanouty.Inventory.MariaDb;
using System;
using System.IO;
using System.Linq;
using MySql.Data.MySqlClient;

var connectionString = Environment.GetEnvironmentVariable("HANOUTY_W1_TEST_CONNECTION")
    ?? throw new InvalidOperationException("A disposable MariaDB connection must be explicitly supplied.");
var marker = Environment.GetEnvironmentVariable("HANOUTY_W1_DISPOSABLE_MARKER");
if (marker != "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY")
    throw new InvalidOperationException("Refusing schema mutation without explicit disposable DB acknowledgement.");
var data = Path.Combine(Path.GetTempPath(), "hanouty-w1-" + Guid.NewGuid().ToString("N"));
Directory.CreateDirectory(Path.Combine(data, "bd", "images"));
try
{
    var image = Path.Combine(data, "bd", "images", "photo.png");
    File.WriteAllBytes(image, new byte[] { 137, 80, 78, 71 });
    using var connection = new MySqlConnection(connectionString);
    connection.Open();
    using (var cmd = new MySqlCommand(
        "CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(64) NOT NULL, Code VARCHAR(64) NULL, Article VARCHAR(128), Images VARCHAR(128) NULL)", connection))
        cmd.ExecuteNonQuery();
    using (var cmd = new MySqlCommand(
        "INSERT INTO TABLE_ARTICLES (ID_ARTICLE, Code, Article, Images) VALUES " +
        "('a','DUP','Apple',NULL),('b','DUP','Apple variant','missing.png')," +
        "('c','','Photo','photo.png'),('d','SINGLE','Ordinary','0')", connection))
        cmd.ExecuteNonQuery();
    var reader = new MariaDbCatalogueReader(connectionString, data);
    var all = reader.ListAll();
    Check(all.Count == 4, "real DB full product list");
    Check(all.Single(x => x.ArticleId == "c").HasImage, "barcode-free real image is available");
    Check(all.Count(x => x.HasImage) == 1, "missing/zero images excluded from photo tiles");
    Check(reader.FindBarcode("DUP").Count == 2, "duplicate barcodes remain distinct");
    Check(reader.RefreshArticle("b").Single().ArticleId == "b", "stable identity refresh");
    Check(reader.FindBarcode("UNKNOWN").Count == 0, "unknown barcode returns empty");
    using (var cmd = new MySqlCommand("INSERT INTO TABLE_ARTICLES (ID_ARTICLE,Code,Article,Images) VALUES ('A','X','Collision',NULL)", connection))
        cmd.ExecuteNonQuery();
    try { reader.ListAll(); throw new Exception("Duplicate article identity accepted"); }
    catch (InvalidOperationException ex) when (ex.Message.Contains("duplicate stable article identity")) { }
    Console.WriteLine("PASS: production Inventory MariaDbCatalogueReader against disposable real MariaDB");
}
finally
{
    using var connection = new MySqlConnection(connectionString);
    connection.Open();
    using var cmd = new MySqlCommand("DROP TABLE IF EXISTS TABLE_ARTICLES", connection);
    cmd.ExecuteNonQuery();
    Directory.Delete(data, recursive: true);
}
static void Check(bool value, string label)
{
    if (!value) throw new Exception("FAIL: " + label);
}
