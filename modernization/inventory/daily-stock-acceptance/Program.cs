using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Hanouty.Desktop.Bootstrap;
using MySql.Data.MySqlClient;

internal static class DailyStockAcceptance
{
    [STAThread]
    private static int Main(string[] args)
    {
        try { Verify(args.Length == 1 ? args[0] : "."); return 0; }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
    }
    private static void Verify(string evidence)
    {
        var connectionString = Environment.GetEnvironmentVariable("HANOUTY_DAILY_STOCK_CONNECTION") ?? throw new InvalidOperationException("Dedicated disposable connection required.");
        var cs = new MySqlConnectionStringBuilder(connectionString);
        if (!uint.TryParse(Environment.GetEnvironmentVariable("HANOUTY_DAILY_STOCK_PORT"), out var explicitPort) || explicitPort is < 1024 or > 65535 ||
            cs.Server != "127.0.0.1" || cs.Database != "daily_stock_ci" || cs.Port != explicitPort || Environment.GetEnvironmentVariable("HANOUTY_DAILY_STOCK_DISPOSABLE") != "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY")
            throw new InvalidOperationException("Only the dedicated disposable daily_stock_ci fixture is accepted.");
        using var db = new MySqlConnection(connectionString); db.Open();
        Execute("""
            CREATE TABLE TABLE_PASS (ID BIGINT AUTO_INCREMENT PRIMARY KEY,ListUser VARCHAR(255),ListPass VARCHAR(255),Catégorie VARCHAR(255),ARTICLES VARCHAR(255)) ENGINE=InnoDB;
            INSERT INTO TABLE_PASS (ListUser,ListPass,Catégorie,ARTICLES) VALUES ('O''Neil','1234','UTILISATEUR','VISIBLE'),('Manager','5678','MANAGER','VISIBLE'),('Admin','6789','ADMIN','VISIBLE');
            CREATE TABLE TABLE_ARTICLES (ID BIGINT PRIMARY KEY,ID_ARTICLE VARCHAR(255),Code VARCHAR(255),Article VARCHAR(255),Famille VARCHAR(255),Reference VARCHAR(255),STOCK DOUBLE,Alert DOUBLE,Prix_A DOUBLE,PRIX_V_1 DOUBLE,DATE_INVENTAIRE DATETIME,MODE_STOCK VARCHAR(255)) ENGINE=InnoDB;
            INSERT INTO TABLE_ARTICLES VALUES
            (1,'A','001','Lait d''été','Épicerie','REF''1',12.5,15,4,6,'2026-01-01','FINI'),
            (2,'B','001','Autre lait','Épicerie','REF2',0,0,5,8,'2026-01-02','FINI'),
            (3,'C','003','Matière négative','Matières','',-2,0,1,2,NULL,'MATIERE PREMIERE'),
            (4,'D','004','Sans gestion de stock','Divers','',1,2,1,2,NULL,'0'),
            (5,'E','LIT','100%_littéral','Divers','',1,2,1,2,NULL,'FINI'),
            (6,'F','','Article photo','Divers','',4,0,1,2,NULL,'FINI'),
            (7,'AMB','AMB1','Identité ancienne','Divers','',4,0,1,2,NULL,'FINI'),
            (8,'amb','AMB2','Identité ambiguë','Divers','',4,0,1,2,NULL,'FINI');
            CREATE TABLE TABLE_MOUVEMENTS_STOCK (ID BIGINT AUTO_INCREMENT PRIMARY KEY,DATES DATETIME,HEURE VARCHAR(255),LIBELLE VARCHAR(255),ID_ARTICLE VARCHAR(255),CODE_ARTICLE VARCHAR(255),ARTICLE VARCHAR(255),QUANTITE VARCHAR(255)) ENGINE=InnoDB;
            """);
        using (var command = new MySqlCommand("INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES,HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE) VALUES (@first,'08:00:00','Réception d''été','A','001','Ancien libellé','2,50'),(@last,'23:59:59','Bon de Sortie | BS001','A','001','Lait d''été','1'),(@next,'00:00:00','Après période','A','001','Lait d''été','9'),(@last,'12:00:00','Autre variante','B','001','Autre lait','7')", db))
        { command.Parameters.AddWithValue("@first", DateTime.Today.AddDays(-1)); command.Parameters.AddWithValue("@last", DateTime.Today.AddDays(1).AddSeconds(-1)); command.Parameters.AddWithValue("@next", DateTime.Today.AddDays(1)); command.ExecuteNonQuery(); }
        var reader = new DailyStockReader(connectionString);
        var access = reader.Authorize("O'Neil", _ => throw new Exception("VISIBLE incorrectly requested a role PIN."));
        var all = new DailyStockReader.Query("", false, "", false, false, false);
        Require(reader.Search(access, all).Articles.Length == 8 && reader.Families(access).Length == 3, "Directory did not expose original stock/families.");
        var shared = reader.Search(access, all with { Text = "001", Exact = true }).Articles;
        Require(shared.Length == 2 && shared.Select(row => row.Id).Distinct().Count() == 2, "Barcode search silently chose or hid a variant.");
        Require(reader.Search(access, all with { Text = "%_" }).Articles.Single().Id == "E" && reader.Search(access, all with { Text = "' OR 1=1 --" }).Articles.Length == 0,
            "Search did not keep SQL and wildcard text literal.");
        Require(reader.Search(access, all with { IgnoreZero = true }).Articles.Length == 7 && reader.Search(access, all with { Family = "Épicerie" }).Articles.Length == 2 &&
            reader.Search(access, all with { AlertsOnly = true }).Articles.Select(row => row.Id).Order().SequenceEqual(new[] { "A", "C", "E" }) &&
            reader.Search(access, all with { NegativeOnly = true }).Articles.Single().Id == "C", "Original zero/family/stock-mode alert rules changed.");
        var a = shared.Single(row => row.Id == "A");
        Execute("UPDATE TABLE_ARTICLES SET STOCK=21 WHERE ID=1");
        var history = reader.Movements(access, a, DateTime.Today.AddDays(-1), DateTime.Today);
        Require(history.Current.Stock == 21m && history.Movements.Length == 2 && history.Movements.Select(row => row.RecordedQuantity).Contains("2,50") &&
            history.Movements.All(row => row.ArticleId == "A"), "History lost last-day records, altered legacy quantity text or mixed barcode variants.");
        Deny<InvalidOperationException>(() => reader.Movements(access, reader.Search(access, all with { Text = "AMB1", Exact = true }).Articles.Single(), DateTime.Today.AddDays(-1), DateTime.Today));
        Execute("UPDATE TABLE_ARTICLES SET Article='Changed identity' WHERE ID=1");
        Deny<InvalidOperationException>(() => reader.Movements(access, a, DateTime.Today.AddDays(-1), DateTime.Today));
        Execute("UPDATE TABLE_ARTICLES SET Article='Lait d''été',STOCK=12.5 WHERE ID=1; UPDATE TABLE_PASS SET ARTICLES='INVISIBLE' WHERE ListUser='O''Neil'");
        Deny<UnauthorizedAccessException>(() => reader.Search(access, all)); Deny<UnauthorizedAccessException>(() => reader.Authorize("O'Neil", _ => "5678"));
        Execute("UPDATE TABLE_PASS SET ARTICLES='ACCES MANAGER' WHERE ListUser='O''Neil'");
        Deny<UnauthorizedAccessException>(() => reader.Authorize("O'Neil", _ => "6789"));
        var approved = reader.Authorize("O'Neil", role => role == "MANAGER" ? "5678" : "");
        Require(reader.Search(approved, all).Articles.Length == 8, "Exact manager approval did not open stock.");
        Execute("UPDATE TABLE_PASS SET Catégorie='UTILISATEUR' WHERE ListUser='Manager'");
        Deny<UnauthorizedAccessException>(() => reader.Movements(approved, a, DateTime.Today.AddDays(-1), DateTime.Today));
        Execute("UPDATE TABLE_PASS SET Catégorie='MANAGER' WHERE ListUser='Manager'; UPDATE TABLE_PASS SET ARTICLES='VISIBLE' WHERE ListUser='O''Neil'");
        Deny<UnauthorizedAccessException>(() => new DailyStockReader(connectionString).Search(access, all));
        var before = Snapshot(); Directory.CreateDirectory(evidence);
        VerifyUi(reader, access, evidence);
        Require(Snapshot() == before, "Stock directory/history/hooks changed stock, catalogue or journal data.");
        File.WriteAllText(Path.Combine(evidence, "daily-stock-acceptance.json"), JsonSerializer.Serialize(new {
            ActualWpfSearchAndSelection = true, SharedBarcodeVariants = true, OriginalZeroFamilyAlertFilters = true,
            LiteralSqlAndWildcards = true, FreshPersistedStock = true, FullLastDayHistory = true, RawLegacyQuantities = true,
            AmbiguousAndChangedIdentityDenied = true, OriginalArticlesPermission = true, ExactRoleAndRevocation = true,
            ReadOnlyNoStockWrites = true, QueryInvalidatesSelection = true, ExistingWorkflowHooks = true
        }, new JsonSerializerOptions { WriteIndented = true }));
        Console.WriteLine("PASS daily stock: actual WPF search/variants/current stock/history, original role/alert filters, revocation and no writes.");
        void Execute(string sql) { using var command = new MySqlCommand(sql, db); command.ExecuteNonQuery(); }
        string Snapshot() { using var command = new MySqlCommand("SELECT CONCAT((SELECT COUNT(*) FROM TABLE_ARTICLES),'|',(SELECT SUM(STOCK) FROM TABLE_ARTICLES),'|',(SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK))", db); return Convert.ToString(command.ExecuteScalar())!; }
    }
    private static void VerifyUi(DailyStockReader reader, DailyStockReader.Access access, string evidence)
    {
        var app = new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
        var opened = ""; var inventoryHooks = 0;
        var dialog = new DailyStockDialog(reader, access, new DailyStockHooks(row => opened = row.Id, () => inventoryHooks++));
        Exception? failure = null;
        var timeout = new DispatcherTimer { Interval = TimeSpan.FromSeconds(15) };
        timeout.Tick += (_, _) => { timeout.Stop(); failure = new TimeoutException("Daily stock actual WPF acceptance timed out."); dialog.Close(); };
        dialog.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            try
            {
                T Named<T>(string name) where T : DependencyObject => Controls<T>(dialog).Single(control => AutomationProperties.GetName(control) == name);
                Button Button(string label) => Controls<Button>(dialog).Single(button => Equals(button.Content, label));
                var query = Named<TextBox>("Rechercher par nom, code-barres ou référence");
                var grid = Named<DataGrid>("Articles et stocks trouvés");
                Require(grid.Items.Count == 8 && grid.IsReadOnly, "Actual directory did not open a readonly persisted stock list.");
                query.Text = "001"; Click(Button("Rechercher / Actualiser")); Require(grid.Items.Count == 2, "Actual UI barcode search hid a variant.");
                grid.SelectedItem = grid.Items.OfType<DailyStockReader.Article>().Single(row => row.Id == "A");
                Require(Button("Afficher les mouvements").IsEnabled, "Selecting an unambiguous article did not enable history.");
                Capture(dialog, Path.Combine(evidence, "daily-stock-overview.png"));
                Click(Button("Modifier la fiche article")); Require(opened == "A", "Article hook targeted another barcode variant.");
                grid.SelectedItem = grid.Items.OfType<DailyStockReader.Article>().Single(row => row.Id == "A");
                Click(Button("Afficher les mouvements"));
                var journal = Named<DataGrid>("Journal des mouvements de l’article");
                Require(journal.Items.Count == 2 && journal.IsReadOnly, "Actual movement UI did not show the selected article's journal.");
                Capture(dialog, Path.Combine(evidence, "daily-stock-movements.png"));
                Require(journal.Columns.All(column => column.ActualWidth >= 80), "Movement columns collapsed to unreadable widths after changing tabs.");
                query.Text = "003"; Require(grid.Items.Count == 0 && journal.Items.Count == 0 && !Button("Modifier la fiche article").IsEnabled,
                    "Changing a stock query kept the previous actionable selection/history.");
                Click(Button("Inventaire physique")); Require(inventoryHooks == 1, "Existing inventory hook was not invoked.");
            }
            catch (Exception ex) { failure = ex; }
            finally { dialog.Close(); }
        }));
        timeout.Start(); dialog.ShowDialog(); timeout.Stop(); app.Shutdown();
        if (failure is not null) throw new InvalidOperationException("Actual daily stock WPF acceptance failed.", failure);
    }
    private static IEnumerable<T> Controls<T>(DependencyObject root) where T : DependencyObject
    { foreach (var child in LogicalTreeHelper.GetChildren(root).OfType<DependencyObject>()) { if (child is T value) yield return value; foreach (var nested in Controls<T>(child)) yield return nested; } }
    private static void Click(Button button) => button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
    private static void Require(bool condition, string message) { if (!condition) throw new InvalidOperationException(message); }
    private static void Deny<T>(Action action) where T : Exception { try { action(); } catch (T) { return; } throw new InvalidOperationException("Expected refusal: " + typeof(T).Name); }
    private static void Capture(Window window, string path)
    {
        window.Dispatcher.Invoke(DispatcherPriority.Render, new Action(window.UpdateLayout));
        var image = new RenderTargetBitmap((int)Math.Ceiling(window.ActualWidth), (int)Math.Ceiling(window.ActualHeight), 96, 96, PixelFormats.Pbgra32); image.Render(window);
        var encoder = new PngBitmapEncoder(); encoder.Frames.Add(BitmapFrame.Create(image)); using var stream = File.Create(path); encoder.Save(stream);
    }
}
