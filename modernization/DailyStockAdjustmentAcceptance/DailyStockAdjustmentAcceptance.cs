using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Hanouty.ArchitectureBridge;
using Hanouty.Desktop.Bootstrap;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;
using Service = Hanouty.Desktop.Bootstrap.DailyStockAdjustmentService;

internal static class DailyStockAdjustmentAcceptance
{
    [STAThread]
    private static int Main(string[] args)
    {
        try { Verify(args.Length == 1 ? args[0] : "."); return 0; }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
    }
    private static void Verify(string evidence)
    {
        var cs = Environment.GetEnvironmentVariable("HANOUTY_DAILY_STOCK_ADJUSTMENT_CONNECTION") ?? throw new InvalidOperationException("Dedicated disposable connection required.");
        var options = new MySqlConnectionStringBuilder(cs);
        if (!uint.TryParse(Environment.GetEnvironmentVariable("HANOUTY_DAILY_STOCK_ADJUSTMENT_PORT"), out var port) || options.Server != "127.0.0.1" || options.Port != port ||
            options.Database != "daily_stock_adjustment_ci" || Environment.GetEnvironmentVariable("HANOUTY_DAILY_STOCK_ADJUSTMENT_DISPOSABLE") != "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY") throw new InvalidOperationException("Dedicated disposable stock-adjustment fixture only.");
        using var db = new MySqlConnection(cs); db.Open(); Directory.CreateDirectory(evidence);
        Execute("""
            CREATE TABLE TABLE_PASS (ID BIGINT AUTO_INCREMENT PRIMARY KEY,ListUser VARCHAR(255),ListPass VARCHAR(255),Catégorie VARCHAR(255),ARTICLES VARCHAR(255)) ENGINE=InnoDB;
            INSERT INTO TABLE_PASS (ListUser,ListPass,Catégorie,ARTICLES) VALUES ('Admin','1234','ADMIN','VISIBLE'),('Manager','5678','MANAGER','VISIBLE'),('Cashier','0000','UTILISATEUR','VISIBLE');
            CREATE TABLE TABLE_PARAMETRES (OBJET VARCHAR(255),VALEUR VARCHAR(255)) ENGINE=InnoDB;
            INSERT INTO TABLE_PARAMETRES VALUES ('MODIF_STOCK_MANUEL','-1'),('AJOUT_STOCK_MANUEL','False');
            CREATE TABLE TABLE_ARTICLES (ID BIGINT PRIMARY KEY,ID_ARTICLE VARCHAR(128),Code VARCHAR(255),Article VARCHAR(255),STOCK DECIMAL(19,4),KEY ix_article_id (ID_ARTICLE)) ENGINE=InnoDB;
            INSERT INTO TABLE_ARTICLES VALUES (1,'A','001','Article d''été',10),(2,'B','001','Autre variante',20);
            CREATE TABLE TABLE_MOUVEMENTS_STOCK (ID BIGINT AUTO_INCREMENT PRIMARY KEY,DATES DATETIME,HEURE VARCHAR(255),LIBELLE VARCHAR(255),ID_ARTICLE VARCHAR(128),CODE_ARTICLE VARCHAR(255),ARTICLE VARCHAR(255),QUANTITE VARCHAR(255)) ENGINE=InnoDB;
            """);
        Execute(DailyStockAdjustmentSchema.Sql);
        VerifiedStockActor? actor = new("verified-admin-session-1", "Admin");
        var pin = "1234"; var silentPinReads = 0; var approvals = 0;
        var service = new Service(cs, () => actor, () => { silentPinReads++; return pin; });
        var authorization = service.Authorize(_ => { approvals++; throw new Exception("VISIBLE must not prompt for another PIN."); });
        DailyStockReader.Article Article(decimal stock) => new(1, "A", "001", "Article d'été", "", "", stock, 0m, 1m, 2m, "", "FINI", true);
        Service.Snapshot Preview() => service.Preview(authorization, Article(Number("SELECT STOCK FROM TABLE_ARTICLES WHERE ID=1")));
        Service.Command Request(Service.AdjustmentMode mode, decimal quantity) => new(Guid.NewGuid().ToString("N"), Preview(), mode, quantity, "Correction de stock");
        var increase = Request(Service.AdjustmentMode.Increase, 2.5m);
        var added = service.Execute(authorization, increase);
        Require(added.After == 12.5m && added.Delta == 2.5m && Number("SELECT STOCK FROM TABLE_ARTICLES WHERE ID=1") == 12.5m, "Increase did not persist actual stock.");
        var removed = service.Execute(authorization, Request(Service.AdjustmentMode.Decrease, 1.25m));
        Require(removed.After == 11.25m && removed.Delta == -1.25m, "Decrease did not persist a negative movement delta.");
        var actual = service.Execute(authorization, Request(Service.AdjustmentMode.ActualQuantity, 7m));
        Require(actual.After == 7m && actual.Delta == -4.25m, "Counted actual quantity did not reconcile its delta.");
        Require(service.Execute(authorization, increase).Replayed && Number("SELECT STOCK FROM TABLE_ARTICLES WHERE ID=1") == 7m && Number("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 3m,
            "An earlier operation replay overwrote newer stock or duplicated its movement.");
        Refused(() => service.Execute(authorization, increase with { Quantity = 9m }));
        Refused(() => service.Execute(authorization, Request(Service.AdjustmentMode.Increase, 0m)));
        Refused(() => service.Execute(authorization, Request(Service.AdjustmentMode.Decrease, 100m)));
        Refused(() => service.Execute(authorization, Request(Service.AdjustmentMode.ActualQuantity, 7m)));
        var stale = Request(Service.AdjustmentMode.Increase, 1m);
        Execute("UPDATE TABLE_ARTICLES SET STOCK=8 WHERE ID=1"); Refused(() => service.Execute(authorization, stale));
        Execute("UPDATE TABLE_ARTICLES SET STOCK=7,Article='Changed' WHERE ID=1"); Refused(() => service.Execute(authorization, stale));
        Execute("UPDATE TABLE_ARTICLES SET Article='Article d''été' WHERE ID=1; INSERT INTO TABLE_ARTICLES VALUES (3,'a','OTHER','Ambiguous',1)");
        Refused(() => service.Execute(authorization, stale)); Execute("DELETE FROM TABLE_ARTICLES WHERE ID=3");
        foreach (var disabled in new[] { "False", "0", "malformed" })
        { Execute("UPDATE TABLE_PARAMETRES SET VALEUR='" + disabled + "' WHERE OBJET='MODIF_STOCK_MANUEL'"); Refused(() => service.Execute(authorization, stale)); }
        Execute("UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='MODIF_STOCK_MANUEL'; INSERT INTO TABLE_PARAMETRES VALUES ('MODIF_STOCK_MANUEL','False')");
        Refused(() => service.Execute(authorization, stale)); Execute("DELETE FROM TABLE_PARAMETRES WHERE OBJET='MODIF_STOCK_MANUEL' AND VALEUR='False'");
        actor = new VerifiedStockActor("changed-session", "Admin"); Refused(() => service.Execute(authorization, stale)); actor = new VerifiedStockActor("verified-admin-session-1", "Admin");
        pin = "wrong"; Refused(() => service.Execute(authorization, stale)); pin = "1234";
        var other = new Service(cs, () => actor, () => pin); Refused(() => other.Execute(authorization, stale));
        var nullSession = new Service("Server=192.0.2.10;Database=never_connect;", () => null, () => throw new Exception("Must not read a PIN without a verified session."));
        Denied<UnauthorizedAccessException>(() => nullSession.Authorize(_ => ""));
        actor = new VerifiedStockActor("verified-user", "Cashier"); Denied<UnauthorizedAccessException>(() => service.Authorize(_ => ""));
        actor = new VerifiedStockActor("verified-admin-session-1", "Admin");
        foreach (var trigger in new[] {
            "CREATE TRIGGER fail_movement BEFORE INSERT ON TABLE_MOUVEMENTS_STOCK FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='movement-rollback'",
            "CREATE TRIGGER fail_movement BEFORE INSERT ON TABLE_MOUVEMENTS_STOCK FOR EACH ROW SET NEW.QUANTITE='0'",
            "CREATE TRIGGER fail_movement AFTER INSERT ON TABLE_MOUVEMENTS_STOCK FOR EACH ROW UPDATE TABLE_ARTICLES SET STOCK=STOCK+1 WHERE ID=1" })
        { Execute(trigger); Refused(() => service.Execute(authorization, stale)); Execute("DROP TRIGGER fail_movement"); }
        Execute("CREATE TRIGGER fail_journal AFTER INSERT ON hanouty_daily_stock_adjustments FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='journal-rollback'");
        Refused(() => service.Execute(authorization, stale)); Execute("DROP TRIGGER fail_journal");
        var requests = new[] { stale, stale with { OperationId = Guid.NewGuid().ToString("N") } };
        var outcomes = Task.WhenAll(requests.Select(request => Task.Run(() => { try { service.Execute(authorization, request); return true; } catch (Service.RefusedException) { return false; } }))).GetAwaiter().GetResult();
        Require(outcomes.Count(ok => ok) == 1 && Number("SELECT STOCK FROM TABLE_ARTICLES WHERE ID=1") == 8m && Number("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 4m,
            "Concurrent distinct requests overwrote stock or recorded a stale adjustment.");
        var recovery = Path.Combine(evidence, "recovery"); var interrupted = Request(Service.AdjustmentMode.Increase, 3m);
        using (var flow = new DailyStockAdjustmentWorkflow(service, authorization, recovery, () => throw new IOException("lost-stock-ack")))
        {
            Denied<InvalidOperationException>(() => { using var conflict = new DailyStockAdjustmentWorkflow(service, authorization, recovery); });
            Denied<IOException>(() => flow.Execute(interrupted)); Require(flow.Pending == interrupted, "Lost acknowledgement discarded the durable request.");
        }
        actor = new VerifiedStockActor("verified-admin-session-after-restart", "Admin");
        var reopened = new Service(cs, () => actor, () => pin); var newAuthorization = reopened.Authorize(_ => { approvals++; return ""; });
        using (var flow = new DailyStockAdjustmentWorkflow(reopened, newAuthorization, recovery))
        {
            pin = "wrong"; Denied<InvalidOperationException>(() => flow.Execute(flow.Pending!)); Require(flow.Pending is not null, "A refused recovery discarded a possibly committed adjustment.");
            pin = "1234"; Require(flow.Execute(flow.Pending!).Replayed && flow.Pending is null && Number("SELECT STOCK FROM TABLE_ARTICLES WHERE ID=1") == 11m && Number("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 5m,
                "Process-style recovery duplicated stock or journal.");
        }
        Execute("UPDATE TABLE_PASS SET ARTICLES='ACCES MANAGER' WHERE ListUser='Admin'");
        Denied<UnauthorizedAccessException>(() => reopened.Authorize(_ => "1234"));
        var approved = reopened.Authorize(role => { approvals++; return role == "MANAGER" ? "5678" : ""; });
        var pendingApproval = new Service.Command(Guid.NewGuid().ToString("N"), reopened.Preview(approved, Article(11m)), Service.AdjustmentMode.Increase, 1m, "Correction de stock");
        Execute("UPDATE TABLE_PASS SET Catégorie='UTILISATEUR' WHERE ListUser='Manager'");
        Refused(() => reopened.Execute(approved, pendingApproval));
        Execute("UPDATE TABLE_PASS SET Catégorie='MANAGER' WHERE ListUser='Manager'; UPDATE TABLE_PASS SET ARTICLES='VISIBLE' WHERE ListUser='Admin'");
        var uiService = new Service(cs, () => actor, () => { silentPinReads++; return pin; }); var uiAuth = uiService.Authorize(_ => throw new Exception("VISIBLE must not open role approval."));
        var approvalBeforeUi = approvals;
        VerifyUi(uiService, uiAuth, Article, evidence);
        Require(approvals == approvalBeforeUi && silentPinReads >= 6 && Number("SELECT STOCK FROM TABLE_ARTICLES WHERE ID=1") == 5m && Number("SELECT STOCK FROM TABLE_ARTICLES WHERE ID=2") == 20m,
            "Actual dialogs requested extra approval, failed to write, or changed the other barcode variant.");
        var zero = new Service.Command(Guid.NewGuid().ToString("N"), uiService.Preview(uiAuth, Article(5m)), Service.AdjustmentMode.ActualQuantity, 0m, "Comptage physique");
        Require(uiService.Execute(uiAuth, zero).After == 0m, "Actual counted stock zero was refused.");
        File.WriteAllText(Path.Combine(evidence, "DailyStockAdjustmentAcceptance.json"), JsonSerializer.Serialize(new {
            ActualIncreaseDecreaseAndCountedStock = true, SignedMovementAudit = true, AtomicStockMovementJournal = true,
            VerifiedAdminSession = true, NoRepeatedVisiblePinDialog = true, OriginalManualSetting = true, ExactRoleAndRevocation = true,
            StaleAndAmbiguousIdentityDenied = true, SharedBarcodeVariantIsolated = true, DurableReplayPreservesLaterStock = true,
            ConcurrentStaleWriterDenied = true, MovementAndJournalRollback = true, TamperedReadbackDenied = true,
            InterruptedRecovery = true, WrongRecoveryPinRetainsRequest = true, ExclusiveRecoveryLease = true, CountedZero = true
        }, new JsonSerializerOptions { WriteIndented = true }));
        Console.WriteLine("PASS actual stock writes: increase/decrease/actual quantity, verified ADMIN, silent session PIN, exact role/flag, atomic readback/audit, concurrency and durable recovery.");
        void Execute(string sql) { using var command = new MySqlCommand(sql, db); command.ExecuteNonQuery(); }
        decimal Number(string sql) { using var command = new MySqlCommand(sql, db); return Convert.ToDecimal(command.ExecuteScalar(), CultureInfo.InvariantCulture); }
        string State() => string.Join("|", Number("SELECT SUM(STOCK) FROM TABLE_ARTICLES"), Number("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK"), Number("SELECT COUNT(*) FROM hanouty_daily_stock_adjustments"));
        void Refused(Action action)
        { var before = State(); Denied<Service.RefusedException>(action); Require(State() == before, "A refused stock operation left persisted effects."); }
        void VerifyUi(Service store, Service.Authorization grant, Func<decimal, DailyStockReader.Article> article, string directory)
        {
            var app = new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
            try
            {
                foreach (var (mode, quantity, expected) in new[] { (Service.AdjustmentMode.Increase, "3", 14m), (Service.AdjustmentMode.Decrease, "2", 12m), (Service.AdjustmentMode.ActualQuantity, "5", 5m) })
                {
                    var dialog = new DailyStockAdjustmentDialog(store, grant, article(Number("SELECT STOCK FROM TABLE_ARTICLES WHERE ID=1")), Path.Combine(directory, "ui-recovery"));
                    Exception? failure = null;
                    var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(15) };
                    timer.Tick += (_, _) => { timer.Stop(); failure = new TimeoutException("Stock adjustment UI did not settle."); foreach (var window in app.Windows.Cast<Window>().Reverse().ToArray()) window.Close(); };
                    dialog.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        try
                        {
                            var modeBox = Controls<ComboBox>(dialog).Single(control => AutomationProperties.GetName(control) == "Action sur le stock"); modeBox.SelectedIndex = (int)mode;
                            var field = Controls<TextBox>(dialog).Single(control => AutomationProperties.GetName(control) == "Quantité de stock"); Require(field.IsReadOnly, "Quantity required physical-keyboard typing.");
                            dialog.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                            {
                                var numeric = app.Windows.OfType<TouchNumericEntryDialog>().SingleOrDefault();
                                try
                                {
                                    Require(numeric is not null, "Actual stock quantity keypad did not open.");
                                    Click(Controls<Button>(numeric!).Single(button => Equals(button.Content, "Effacer")));
                                    foreach (var key in quantity) Click(Controls<Button>(numeric!).Single(button => Equals(button.Content, key.ToString())));
                                    Click(Controls<Button>(numeric!).Single(button => Equals(button.Content, "Appliquer")));
                                }
                                catch (Exception ex) { failure = ex; numeric?.Close(); }
                            }));
                            field.RaiseEvent(new MouseButtonEventArgs(Mouse.PrimaryDevice, 0, MouseButton.Left) { RoutedEvent = UIElement.PreviewMouseLeftButtonDownEvent });
                            if (failure is not null) throw failure;
                            Require(app.Windows.Cast<Window>().All(window => !window.GetType().Name.Contains("Pin", StringComparison.OrdinalIgnoreCase)), "VISIBLE stock adjustment opened another PIN dialog.");
                            Capture(dialog, Path.Combine(directory, "DailyStockAdjustment-" + mode + ".png"));
                            Click(Controls<Button>(dialog).Single(button => button.IsDefault));
                            Require(dialog.Saved?.After == expected, "Actual stock dialog did not commit its visible new quantity.");
                        }
                        catch (Exception ex) { failure = ex; dialog.Close(); }
                    }));
                    timer.Start(); dialog.ShowDialog(); timer.Stop(); if (failure is not null) throw new InvalidOperationException("Actual stock adjustment WPF acceptance failed.", failure);
                }
            }
            finally { app.Shutdown(); }
        }
    }
    private static IEnumerable<T> Controls<T>(DependencyObject root) where T : DependencyObject
    { foreach (var child in LogicalTreeHelper.GetChildren(root).OfType<DependencyObject>()) { if (child is T value) yield return value; foreach (var nested in Controls<T>(child)) yield return nested; } }
    private static void Click(Button button) => button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
    private static void Require(bool condition, string message) { if (!condition) throw new InvalidOperationException(message); }
    private static void Denied<T>(Action action) where T : Exception { try { action(); } catch (T) { return; } throw new InvalidOperationException("Expected refusal: " + typeof(T).Name); }
    private static void Capture(Window window, string path)
    {
        window.Dispatcher.Invoke(DispatcherPriority.Render, new Action(window.UpdateLayout));
        var bitmap = new RenderTargetBitmap((int)Math.Ceiling(window.ActualWidth), (int)Math.Ceiling(window.ActualHeight), 96, 96, PixelFormats.Pbgra32); bitmap.Render(window);
        var encoder = new PngBitmapEncoder(); encoder.Frames.Add(BitmapFrame.Create(bitmap)); using var stream = File.Create(path); encoder.Save(stream);
    }
}
