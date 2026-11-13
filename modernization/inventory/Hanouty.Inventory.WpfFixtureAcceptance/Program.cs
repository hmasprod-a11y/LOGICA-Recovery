using System;
using System.IO;
using System.Linq;
using Hanouty.Inventory.MariaDb;
using MySql.Data.MySqlClient;

static void Check(bool condition, string message)
{
    if (!condition) throw new InvalidOperationException("FAIL: " + message);
    Console.WriteLine("PASS: " + message);
}

string connectionString = Environment.GetEnvironmentVariable("HANOUTY_WPF_FIXTURE_DB") ?? "";
string dataDirectory = Environment.GetEnvironmentVariable("HANOUTY_WPF_FIXTURE_DATA") ?? "";
Check(!string.IsNullOrWhiteSpace(connectionString) && !string.IsNullOrWhiteSpace(dataDirectory),
    "explicit disposable connection and data directory required");
var endpoint = new MySqlConnectionStringBuilder(connectionString);
Check((endpoint.Server.Equals("127.0.0.1", StringComparison.OrdinalIgnoreCase) ||
       endpoint.Server.Equals("localhost", StringComparison.OrdinalIgnoreCase)) &&
      endpoint.Database == "hanouty_wpf_fixture", "strict local disposable database");
var png = Path.Combine(Path.GetFullPath(dataDirectory), "bd", "images", "fixture-soap.png");
Check(File.Exists(png), "deterministic fixture image exists");
byte[] imageHeader = new byte[8];
using (var image = File.OpenRead(png))
{
    Check(image.Read(imageHeader, 0, imageHeader.Length) == imageHeader.Length &&
          imageHeader.SequenceEqual(new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 }),
          "fixture image has valid PNG signature");
}
var catalogue = new MariaDbCatalogueReader(connectionString, dataDirectory);
var inventory = new MariaDbInventorySnapshotReader(connectionString);
var all = catalogue.ListAll();
Check(all.Count == 5, "exactly five fictitious catalogue rows");
Check(all.Select(x => x.ArticleId).OrderBy(x => x).SequenceEqual(
    new[] { "DEMO-BLUE", "DEMO-OOS", "DEMO-QUOTED", "DEMO-RED", "DEMO-SOAP" }),
    "stable identities match fixture");
var soap = catalogue.FindBarcode("6900000000011");
Check(soap.Count == 1 && soap[0].ArticleId == "DEMO-SOAP" &&
      soap[0].ImagePath == Path.GetFullPath(png), "soap scan resolves real local PNG");
Check(inventory.ReadUniqueBarcode("6900000000011").Stock == 12m, "soap stock 12");
Check(inventory.ReadArticle("DEMO-SOAP").SalePrice == 18.50m &&
      inventory.ReadArticle("DEMO-SOAP").PurchasePrice == 11.25m,
      "sale and purchase prices remain exact decimal values");
var shared = catalogue.FindBarcode("6900000000028");
Check(shared.Count == 2 && shared.Select(x => x.ArticleId).OrderBy(x => x)
    .SequenceEqual(new[] { "DEMO-BLUE", "DEMO-RED" }), "shared barcode exposes both variants");
bool ambiguous = false;
try { inventory.ReadUniqueBarcode("6900000000028"); }
catch (InvalidOperationException) { ambiguous = true; }
Check(ambiguous, "ambiguous barcode cannot auto-select article");
Check(catalogue.RefreshArticle("DEMO-BLUE").Single().ArticleId == "DEMO-BLUE",
    "explicit variant selection resolves stable article");
Check(inventory.ReadArticle("DEMO-BLUE").Stock == 7m &&
      inventory.ReadArticle("DEMO-RED").Stock == 5m, "distinct variant stock");
Check(catalogue.FindBarcode("6900000000035").Single().ArticleId == "DEMO-OOS" &&
      inventory.ReadUniqueBarcode("6900000000035").Stock == 0m,
      "out-of-stock scan is identifiable but not saleable");
Check(catalogue.RefreshArticle("DEMO-OOS").Single().ImagePath == null,
      "unavailable product does not fabricate an image");
Check(catalogue.FindBarcode("6900000000042").Single().ArticleId == "DEMO-QUOTED",
    "quoted-name product remains discoverable");
Check(catalogue.FindBarcode("6900000000999").Count == 0, "unknown barcode no matches");
Check(catalogue.FindBarcode("6900000000028' OR 1=1 --").Count == 0,
    "injection-shaped barcode cannot broaden search");
Check(inventory.FindStockBelow(1m).Single().ArticleId == "DEMO-OOS",
    "low-stock view identifies unavailable article");
using (var db = new MySqlConnection(connectionString))
{
    db.Open();
    using var forbidden = new MySqlCommand(
        "UPDATE TABLE_ARTICLES SET STOCK = STOCK + 1 WHERE ID_ARTICLE = @id", db);
    forbidden.Parameters.AddWithValue("@id", "DEMO-SOAP");
    bool denied = false;
    try { forbidden.ExecuteNonQuery(); }
    catch (MySqlException ex) when (ex.Number == 1142) { denied = true; }
    Check(denied, "WPF fixture reader SQL account cannot update stock");
}
Check(inventory.ReadArticle("DEMO-SOAP").Stock == 12m,
      "stock unchanged after forbidden write");
Console.WriteLine("PASS: disposable WPF sale reader fixture acceptance; NOT WPF UI or checkout acceptance");
