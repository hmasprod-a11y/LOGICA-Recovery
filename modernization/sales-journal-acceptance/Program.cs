using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Hanouty.Desktop.Bootstrap;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

internal static class Program
{
    private static string connection = "";
    private static readonly DateTime Day = DateTime.Today;
    private static void Require(bool value, string reason) { if (!value) throw new InvalidOperationException(reason); }
    private static void Sql(string sql, params (string, object)[] values)
    {
        using var db = new MySqlConnection(connection); db.Open(); using var command = new MySqlCommand(sql, db);
        foreach (var (name, value) in values) command.Parameters.AddWithValue(name, value); command.ExecuteNonQuery();
    }
    private static string Fingerprint()
    {
        using var db = new MySqlConnection(connection); db.Open(); using var command = new MySqlCommand("CHECKSUM TABLE TABLE_PASS,TABLE_VENTES_ENTETE,TABLE_VENTES_JOURNAL,TABLE_VENTES_REGLEMENTS EXTENDED", db);
        using var rows = command.ExecuteReader(); var values = new List<string>(); while (rows.Read()) values.Add(rows.GetString(0) + ":" + rows.GetValue(1)); return string.Join("|", values);
    }
    [STAThread]
    private static int Main(string[] args)
    {
        try
        {
            connection = Environment.GetEnvironmentVariable("HANOUTY_JOURNAL_TEST_CONNECTION") ?? "";
            var cs = new MySqlConnectionStringBuilder(connection);
            Require(cs.Server is "127.0.0.1" or "localhost" && cs.Database == "journal_disposable", "Disposable loopback journal schema required.");
            cs.CharacterSet = "utf8mb4"; connection = cs.ConnectionString;
            var evidence = Path.GetFullPath(args.FirstOrDefault() ?? "journal-evidence"); Directory.CreateDirectory(evidence);
            Seed();
            var readonlyCs = new MySqlConnectionStringBuilder(connection) { UserID = "journal_reader", Password = "journal-select-only" }.ConnectionString;
            CharsetProof(new MySqlConnectionStringBuilder(Environment.GetEnvironmentVariable("HANOUTY_JOURNAL_TEST_CONNECTION"))
                { UserID = "journal_reader", Password = "journal-select-only" }.ConnectionString, evidence);
            var reader = new SalesJournalReader(readonlyCs);
            var admin = reader.Authorize("Admin d'été", () => "6789", true);
            var manager = reader.Authorize("Manager", () => "5678");
            var before = Fingerprint(); var allFilter = new SalesJournalFilter(Day.AddDays(-1), Day);
            var all = reader.Read(admin, allFilter);
            Require(all.Tickets.Count == 6 && all.Totals.Sales == 47m && all.Totals.Returns == -10m && all.Totals.PaidNet == 37m &&
                all.Totals.CreditSales == 30m && all.Totals.CreditReturns == -10m && all.Totals.CreditNet == 20m && all.Totals.Quantity == 6.5m &&
                all.Payments.Single(row => row.Mode == "ESPECES").Amount == 20m && all.Payments.Single(row => row.Mode == "CARTE").Amount == 17m && all.PaidPaymentGap == 0m,
                "Original signed sales/returns/credit/quantities or mode totals mixed cash and debt.");
            Require(all.Days.Count == 2 && all.Days.Last().Sales == 27m && all.Cashiers.Single(row => row.Cashier == "Second").PaidNet == 7m,
                "Daily/last-day or cashier aggregation is incorrect.");
            Require(reader.Read(admin, new SalesJournalFilter(Day.AddDays(-3), Day.AddDays(-3))).Totals.PaidNet == 0m,
                "Empty period did not produce zero totals.");
            Require(reader.Read(admin, allFilter with { Cashier = "Admin d'été" }).Totals.PaidNet == 30m &&
                reader.Read(admin, allFilter with { Operation = "CREDIT" }).Totals.CreditSales == 30m &&
                reader.Read(admin, allFilter with { Mode = "CARTE" }).Tickets.Count == 2 &&
                reader.Read(admin, allFilter with { Search = "%_" }).Tickets.Count == 1 &&
                reader.Read(admin, allFilter with { Search = "' OR 1=1 --" }).Tickets.Count == 0,
                "Cashier/operation/mode/literal search changed the selected original scope.");
            var selected = all.Tickets.Single(row => row.Id == "S2"); var detail = reader.Details(admin, selected);
            Require(detail.Lines.Count == 2 && detail.Lines.Sum(row => row.Quantity) == 2.5m && detail.Payments.Count == 3 && detail.Payments.Sum(row => row.Amount) == 20m,
                "Selected ticket details or signed change differ from persisted data.");
            void Denied(Action action)
            {
                var denied = false; try { action(); } catch (Exception ex) when (ex is UnauthorizedAccessException or InvalidOperationException or ArgumentException) { denied = true; }
                Require(denied, "Journal authorization, stale selection or invalid filter was accepted.");
            }
            Denied(() => reader.Authorize("User", () => "1234"));
            Denied(() => reader.Authorize("Manager", () => "5678", true));
            Denied(() => reader.Authorize("Admin d'été", () => "bad", true));
            Denied(() => reader.Authorize("Admin d'ete", () => "6789", true));
            var arabic = reader.Authorize("مدير", () => "8765", true);
            Require(reader.Read(arabic, allFilter).Totals.PaidNet == 37m, "Arabic actor could not read the same authorized original journal.");
            Denied(() => reader.Authorize("مدیر", () => "8765", true));
            Denied(() => reader.Read(admin, allFilter with { From = Day.AddDays(1) }));
            Denied(() => reader.Details(admin, selected with { Total = 999m }));
            var active = true; var reprints = 0;
            var workflow = new SalesJournalWorkflow(reader, admin, () => active, ticket => { Require(ticket == selected, "Wrong reprint identity."); reprints++; });
            workflow.Reprint(selected); Require(reprints == 1, "Persisted reprint hook not reached.");
            active = false; Denied(() => workflow.Read(allFilter)); active = true;
            Require(!new SalesJournalWorkflow(reader, manager, () => true).CanStatistics, "Manager received admin-only statistics.");
            Require(Fingerprint() == before, "Journal reads/reprint callback changed business or credential data.");
            UiProof(workflow, evidence);
            UiProof(new SalesJournalWorkflow(reader, manager, () => true, _ => { }), evidence);
            Require(Fingerprint() == before, "Actual journal dialog changed database data.");
            Sql("UPDATE TABLE_PASS SET Catégorie='UTILISATEUR' WHERE ListUser='Admin d''été'");
            Denied(() => workflow.Read(allFilter)); Denied(() => workflow.Details(selected)); Denied(() => workflow.Reprint(selected));
            Sql("UPDATE TABLE_PASS SET Catégorie='ADMIN' WHERE ListUser='Admin d''été'");
            // Do not hide historical journal data merely because its header is absent.
            Sql("INSERT INTO TABLE_VENTES_JOURNAL VALUES ('ORPHAN','orphan',@date,'Admin d''été','VENTE','A','ORPHAN','Orphan','F',0.5,4,0,2,'')", ("@date", Day));
            var orphan = reader.Read(admin, allFilter);
            Require(orphan.Totals.PaidNet == 39m && orphan.PaidPaymentGap == 2m, "Original journal sum silently discarded orphan rows or hid payment discrepancy.");
            Sql("DELETE FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET='ORPHAN'");
            // Duplicate/case-alias headers cannot select/reprint another ticket.
            Sql("INSERT INTO TABLE_VENTES_ENTETE SELECT LOWER(ID_TICKET),TICKET,DATES,CAISSIER,POSTE,OPERATION,CLIENT,TOTAL_NET FROM TABLE_VENTES_ENTETE WHERE ID_TICKET='S2'");
            var duplicates = reader.Read(admin, allFilter).Tickets.Where(row => string.Equals(row.Id, "S2", StringComparison.OrdinalIgnoreCase)).ToArray();
            Require(duplicates.Length == 2 && duplicates.All(row => !row.CanReprint), "Ambiguous ticket remained reprintable."); Denied(() => reader.Details(admin, duplicates[0]));
            Sql("DELETE FROM TABLE_VENTES_ENTETE WHERE BINARY ID_TICKET=BINARY 's2'");
            Require(Fingerprint() == before, "Acceptance fixture restoration changed original journal state.");
            File.WriteAllText(Path.Combine(evidence, "sales-journal-acceptance.json"), JsonSerializer.Serialize(new {
                OriginalPaidSigns = true, CreditSeparated = true, SignedChangeAndCard = true, FractionalQuantities = true,
                LastDayIncluded = true, EmptyPeriod = true, LiteralSearch = true, CashierModeOperationFilters = true,
                ExactRolesAndFreshPin = true, ArabicAccentsAndLookalikeIdentity = true, RevokedRoleRejected = true, DetailsAndStaleSelection = true,
                DuplicateIdentityDenied = true, OrphanJournalNotHidden = true, ExistingReprintHook = true,
                ActualWpfDialog = true, ActualDetailsAndStatisticsUi = true, ManagerStatisticsHidden = true,
                FilterInvalidation = true, SelectOnlyDatabaseAccount = true, DatabaseUnchanged = true
            }, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine("PASS actual SQL/WPF journal: source signed paid/credit/mode/quantity totals, last-day/filter/roles/details/reprint, duplicate/orphan integrity and unchanged SELECT-only database."); return 0;
        }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
    }
    private static void Seed()
    {
        Sql("CREATE TABLE TABLE_PASS (ListUser VARCHAR(128),ListPass VARCHAR(256),Catégorie VARCHAR(64)) ENGINE=InnoDB; " +
            "INSERT INTO TABLE_PASS VALUES ('Admin d''été','6789','ADMIN'),('Manager','5678','MANAGER'),('User','1234','UTILISATEUR'),('مدير','8765','ADMIN'); " +
            "CREATE TABLE TABLE_VENTES_ENTETE (ID_TICKET VARCHAR(64),TICKET VARCHAR(64),DATES DATETIME(6),CAISSIER VARCHAR(128),POSTE VARCHAR(8),OPERATION VARCHAR(64),CLIENT VARCHAR(255),TOTAL_NET DECIMAL(19,4)) ENGINE=InnoDB; " +
            "CREATE TABLE TABLE_VENTES_JOURNAL (ID_TICKET VARCHAR(64),TICKET VARCHAR(64),DATES DATETIME(6),CAISSIER VARCHAR(128),OPERATION VARCHAR(64),ID_ARTICLE VARCHAR(64),CODE VARCHAR(255),ARTICLE VARCHAR(255),FAMILLE VARCHAR(128),Qté DECIMAL(19,4),PRIX_V DECIMAL(19,4),REMISE DECIMAL(19,4),TOTAL_NET DECIMAL(19,4),CLIENT VARCHAR(255)) ENGINE=InnoDB; " +
            "CREATE TABLE TABLE_VENTES_REGLEMENTS (ID_TICKET VARCHAR(64),TICKET VARCHAR(64),DATES DATETIME(6),CAISSIER VARCHAR(128),MODE_P VARCHAR(128),MONTANT DECIMAL(19,4),OPERATION VARCHAR(64),CLIENT VARCHAR(255)) ENGINE=InnoDB");
        void Ticket(string id, DateTime date, string operation, decimal amount, decimal quantity, string actor = "Admin d'été", string article = "Article d'été")
        {
            Sql("INSERT INTO TABLE_VENTES_ENTETE VALUES (@id,@id,@date,@actor,'01',@op,@client,@amount)", ("@id", id), ("@date", date), ("@actor", actor), ("@op", operation), ("@client", operation.Contains("CREDIT") ? "Client d'été" : ""), ("@amount", amount));
            Sql("INSERT INTO TABLE_VENTES_JOURNAL VALUES (@id,@id,@date,@actor,@op,'A','CODE',@article,'F',@quantity,@unit,0,@amount,@client)",
                ("@id", id), ("@date", date), ("@actor", actor), ("@op", operation), ("@article", article), ("@quantity", quantity), ("@unit", amount / quantity), ("@amount", amount), ("@client", operation.Contains("CREDIT") ? "Client d'été" : ""));
        }
        void Payment(string id, DateTime date, string mode, decimal amount, string operation = "VENTE", string actor = "Admin d'été") =>
            Sql("INSERT INTO TABLE_VENTES_REGLEMENTS VALUES (@id,@id,@date,@actor,@mode,@amount,@op,'')", ("@id", id), ("@date", date), ("@actor", actor), ("@mode", mode), ("@amount", amount), ("@op", operation));
        Ticket("S1", Day.AddDays(-1).AddHours(12), "VENTE", 20m, 2m); Payment("S1", Day.AddDays(-1), "ESPECES", 50m); Payment("S1", Day.AddDays(-1), "ESPECES", -30m);
        var last = Day.AddDays(1).AddTicks(-10); Ticket("S2", last, "VENTE", 20m, 1.5m, article: "Article %_ d'été");
        Sql("UPDATE TABLE_VENTES_JOURNAL SET TOTAL_NET=15,PRIX_V=10 WHERE ID_TICKET='S2'");
        Sql("INSERT INTO TABLE_VENTES_JOURNAL VALUES ('S2','S2',@date,'Admin d''été','VENTE','B','B','Second article','F',1,5,0,5,'')", ("@date", last));
        Payment("S2", last, "ESPECES", 15m); Payment("S2", last, "CARTE", 10m); Payment("S2", last, "ESPECES", -5m);
        Ticket("R1", Day.AddHours(12), "RETOUR REMBOURSEMENT", -10m, -1m); Payment("R1", Day.AddHours(12), "ESPECES", -10m, "RETOUR REMBOURSEMENT");
        Ticket("C1", Day.AddHours(9), "CREDIT", 30m, 3m); Ticket("RC1", Day.AddHours(10), "RETOUR CREDIT", -10m, -1m);
        Ticket("S3", Day.AddHours(6), "VENTE", 7m, 1m, "Second"); Payment("S3", Day, "CARTE", 7m, actor: "Second");
        Ticket("NEXT", Day.AddDays(1), "VENTE", 99m, 1m); Payment("NEXT", Day.AddDays(1), "ESPECES", 99m);
        Ticket("BEFORE", Day.AddDays(-2), "VENTE", 88m, 1m); Payment("BEFORE", Day.AddDays(-2), "ESPECES", 88m);
    }
    private static System.Collections.Generic.IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
    {
        foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>()) { if (child is T result) yield return result; foreach (var nested in Controls<T>(child)) yield return nested; }
    }
    private static void CharsetProof(string source, string evidence)
    {
        var probes = new List<object>();
        foreach (var explicitUtf8 in new[] { false, true })
        {
            var cs = new MySqlConnectionStringBuilder(source); cs.Remove("Character Set"); if (explicitUtf8) cs.CharacterSet = "utf8mb4";
            using var db = new MySqlConnection(cs.ConnectionString); db.Open();
            using var command = new MySqlCommand("SELECT @@character_set_client,@@character_set_connection,@@character_set_results,HEX(ListUser),HEX(@actor),BINARY ListUser=BINARY @actor FROM TABLE_PASS WHERE ListUser LIKE 'Admin%'", db);
            command.Parameters.AddWithValue("@actor", "Admin d'été"); using var row = command.ExecuteReader(); Require(row.Read(), "Charset diagnosis fixture missing.");
            probes.Add(new { ExplicitUtf8 = explicitUtf8, Client = row.GetString(0), Connection = row.GetString(1), Results = row.IsDBNull(2) ? "(NULL)" : row.GetString(2),
                StoredHex = row.GetString(3), ParameterHex = row.GetString(4), BinaryEqual = Convert.ToInt32(row.GetValue(5)) == 1 });
        }
        File.WriteAllText(Path.Combine(evidence, "journal-charset-proof.json"), JsonSerializer.Serialize(probes, new JsonSerializerOptions { WriteIndented = true }));
    }
    private static void UiProof(ISalesJournalWorkflow workflow, string evidence)
    {
        if (Application.Current is null) _ = new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
        var dialog = new SalesJournalDialog(workflow); Exception? failure = null;
        var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(10) };
        timer.Tick += (_, _) => { failure = new TimeoutException("Actual journal dialog did not settle."); timer.Stop(); dialog.Close(); };
        dialog.Loaded += (_, _) => dialog.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            try
            {
                var grid = Controls<DataGrid>(dialog).First(); Require(grid.Items.Count == 5, "Actual journal did not show today's persisted tickets.");
                var tabs = Controls<TabControl>(dialog).Single(); Require(tabs.Items.Count == (workflow.CanStatistics ? 4 : 2), "Statistics tab did not follow the original exact-role grant.");
                grid.SelectedItem = grid.Items.Cast<SalesJournalTicket>().Single(row => row.Id == "S2");
                Require(Controls<Button>(dialog).Single(button => Equals(button.Content, "Réimprimer le ticket")).IsEnabled, "Original ticket selection did not enable reprint.");
                dialog.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                {
                    var detail = Application.Current!.Windows.Cast<Window>().SingleOrDefault(window => window != dialog && window.Title.StartsWith("Détail du ticket", StringComparison.Ordinal));
                    try { Require(detail is not null && Controls<DataGrid>(detail).Single().Items.Count == 2, "Actual selected-ticket detail window did not show its original lines."); }
                    catch (Exception ex) { failure = ex; }
                    finally { detail?.Close(); }
                }));
                Controls<Button>(dialog).Single(button => Equals(button.Content, "Détail du ticket")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                if (failure is not null) throw failure;
                Controls<Button>(dialog).Single(button => Equals(button.Content, "Réimprimer le ticket")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                dialog.UpdateLayout(); var bitmap = new RenderTargetBitmap((int)Math.Ceiling(dialog.ActualWidth), (int)Math.Ceiling(dialog.ActualHeight), 96, 96, PixelFormats.Pbgra32);
                bitmap.Render(dialog); var encoder = new PngBitmapEncoder(); encoder.Frames.Add(BitmapFrame.Create(bitmap)); using (var output = File.Create(Path.Combine(evidence, workflow.CanStatistics ? "sales-journal-wpf.png" : "sales-journal-manager-wpf.png"))) encoder.Save(output);
                if (workflow.CanStatistics)
                {
                    tabs.SelectedIndex = 2; dialog.UpdateLayout(); bitmap = new RenderTargetBitmap((int)Math.Ceiling(dialog.ActualWidth), (int)Math.Ceiling(dialog.ActualHeight), 96, 96, PixelFormats.Pbgra32);
                    bitmap.Render(dialog); encoder = new PngBitmapEncoder(); encoder.Frames.Add(BitmapFrame.Create(bitmap)); using var output = File.Create(Path.Combine(evidence, "sales-statistics-wpf.png")); encoder.Save(output); tabs.SelectedIndex = 0;
                }
                var search = Controls<TextBox>(dialog).Single(box => System.Windows.Automation.AutomationProperties.GetName(box) == "Rechercher un ticket, client ou article"); search.Text = "changed";
                Require(grid.Items.Count == 0 && !Controls<Button>(dialog).Single(button => Equals(button.Content, "Réimprimer le ticket")).IsEnabled,
                    "Editing journal filters retained a stale ticket/reprint target.");
            }
            catch (Exception ex) { failure = ex; }
            finally { timer.Stop(); dialog.Close(); }
        }));
        timer.Start(); dialog.ShowDialog(); if (failure is not null) throw failure;
    }
}
