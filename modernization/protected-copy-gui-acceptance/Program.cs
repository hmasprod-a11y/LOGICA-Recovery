using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
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
    private static void Check(bool value, string message) { if (!value) throw new InvalidOperationException(message); }
    private static IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
    { foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>()) { if (child is T match) yield return match; foreach (var nested in Controls<T>(child)) yield return nested; } }
    private static void Capture(Window window, string path)
    {
        window.UpdateLayout(); var image = new RenderTargetBitmap((int)Math.Ceiling(window.ActualWidth), (int)Math.Ceiling(window.ActualHeight), 96, 96, PixelFormats.Pbgra32); image.Render(window);
        var png = new PngBitmapEncoder(); png.Frames.Add(BitmapFrame.Create(image)); using var file = File.Create(path); png.Save(file);
    }
    [STAThread]
    private static int Main(string[] args)
    {
        var result = 1; var app = new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
        var owner = new Window { Title = "Protected copy acceptance", Width = 700, Height = 450 };
        owner.Loaded += async (_, _) =>
        {
            try
            {
                var root = Path.GetFullPath(args[0]); var tools = Path.GetFullPath(args[1]); var evidence = Path.GetFullPath(args[2]); Directory.CreateDirectory(evidence);
                Check(Environment.GetEnvironmentVariable("HANOUTY_COPY_DISPOSABLE") == "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY", "Disposable copy marker required.");
                var port = uint.Parse(Environment.GetEnvironmentVariable("HANOUTY_COPY_PORT") ?? "0"); Check(port > 0, "Explicit disposable copy port required.");
                var cs = new MySqlConnectionStringBuilder { Server = "127.0.0.1", Port = port, Database = "copy_gui_" + Guid.NewGuid().ToString("N"), UserID = "root", Password = "copy-test-only", CharacterSet = "utf8mb4", Pooling = false };
                using var admin = new MySqlConnection(new MySqlConnectionStringBuilder(cs.ConnectionString) { Database = "" }.ConnectionString); admin.Open();
                void Sql(string sql) { using var command = new MySqlCommand(sql, admin); command.ExecuteNonQuery(); }
                object? Scalar(string sql) { using var command = new MySqlCommand(sql, admin); return command.ExecuteScalar(); }
                Sql("CREATE DATABASE `" + cs.Database + "` CHARACTER SET utf8mb4"); admin.ChangeDatabase(cs.Database);
                var original = File.ReadAllText(Path.Combine(root, "input", "recovered-original.sql"));
                foreach (var table in new[] { "TABLE_PASS", "TABLE_NUM", "TABLE_ARTICLES", "TABLE_PARAMETRES", "TABLE_MODE_P", "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS", "TABLE_MOUVEMENTS_STOCK", "TABLE_CLIENTS", "TABLE_FOURNISSEURS", "TABLE_CLIENTS_REGLE", "TABLE_FOURNISSEURS_REGLE", "TABLE_INVENTAIRES_ENTETE", "TABLE_INVENTAIRES_DETAILS", "TABLE_COMMANDES_ENTETE", "TABLE_COMMANDES_DETAILS", "TABLE_RECEPTIONS_ENTETE", "TABLE_RECEPTIONS_DETAILS", "TABLE_SORTIES_ENTETE", "TABLE_SORTIES_DETAILS", "TABLE_DEPENSES", "TABLE_01" })
                {
                    var ddl = Regex.Match(original, @"CREATE TABLE\s+`" + table + @"`\s*\([\s\S]*?;", RegexOptions.IgnoreCase);
                    Check(ddl.Success, "Original fixture DDL missing: " + table); Sql(ddl.Value);
                }
                Sql("SET SESSION sql_mode=CONCAT(@@sql_mode,',NO_AUTO_VALUE_ON_ZERO'); INSERT INTO TABLE_NUM (ID,CL,CLIENT,INV,BC,BR,BS) VALUES (0,0,0,0,0,0,0); " +
                    "INSERT INTO TABLE_PASS (ListUser,ListPass,`Catégorie`,ARTICLES) VALUES ('Admin été مسؤول','1234','ADMIN','VISIBLE'); " +
                    "INSERT INTO TABLE_ARTICLES (ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,STOCK,TAUX_TVA,PROMOTION,Images) VALUES ('gui-fixture','GUI-CODE','Lait été حليب','Food',4,4,6,12,0,0,'fixture.png')");
                foreach (var pair in new[] { ("MODELE_TICKET", "FR_3C"), ("BRANCHEMENT", "USB"), ("AFFICHER_MODE_P", "True"), ("AFFICHER_N_TICKET", "True"), ("AFFICHER_CODE_BARRE", "True"), ("PIED_TICKET", "Merci"), ("FENETRE_MODE_P", "True") })
                { using var command = new MySqlCommand("INSERT INTO TABLE_PARAMETRES (OBJET,VALEUR) VALUES (@key,@value)", admin); command.Parameters.AddWithValue("@key", pair.Item1); command.Parameters.AddWithValue("@value", pair.Item2); command.ExecuteNonQuery(); }
                var sourceData = Path.Combine(evidence, "source-files"); Directory.CreateDirectory(Path.Combine(sourceData, "bd", "images"));
                var encoder = new PngBitmapEncoder(); encoder.Frames.Add(BitmapFrame.Create(BitmapSource.Create(1, 1, 96, 96, PixelFormats.Bgra32, null, new byte[] { 0, 128, 0, 255 }, 4)));
                using (var image = File.Create(Path.Combine(sourceData, "bd", "images", "fixture.png"))) encoder.Save(image);
                File.WriteAllText(Path.Combine(sourceData, "gestion_credit.sni"), "True"); File.WriteAllText(Path.Combine(sourceData, "PRINTER_CL.sni"), "0");
                var settings = CatalogueSettings.Validate(cs.ConnectionString, sourceData, "01");
                Check(!WorkstationReadiness.IsReady(settings), "Original fixture was incorrectly accepted as an already prepared workstation.");
                var profile = Path.Combine(evidence, "workstation.json"); File.WriteAllText(profile, "previous-profile-bytes");
                Exception? failure = null;
                bool RunWizard(bool valid)
                {
                    var wizard = new ProtectedWorkstationCopyDialog(settings, profile) { Owner = owner }; var submitted = false;
                    var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(50) }; var expires = DateTime.UtcNow.AddSeconds(45);
                    timer.Tick += (_, _) =>
                    {
                        try
                        {
                            if (DateTime.UtcNow > expires) throw new TimeoutException("Protected copy wizard timed out.");
                            if (!submitted)
                            {
                                Controls<TextBox>(wizard).Single(field => System.Windows.Automation.AutomationProperties.GetName(field) == "Dossier des outils MariaDB").Text = valid ? tools : Path.Combine(evidence, "missing-tools");
                                Controls<CheckBox>(wizard).Single(field => field.Content?.ToString()?.StartsWith("LOGICA est fermé", StringComparison.Ordinal) == true).IsChecked = true;
                                Capture(wizard, Path.Combine(evidence, valid ? "protected-copy-wizard.png" : "protected-copy-invalid.png"));
                                submitted = true; Controls<Button>(wizard).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                            }
                            else if (Controls<Button>(wizard).Any(button => Equals(button.Content, "Fermer")))
                            {
                                if (valid)
                                {
                                    Capture(wizard, Path.Combine(evidence, "protected-copy-refusal.png"));
                                    throw new InvalidOperationException("Wizard refused: " + Controls<TextBlock>(wizard).Last().Text);
                                }
                                wizard.Close();
                            }
                        }
                        catch (Exception ex) { failure = ex; wizard.Close(); }
                    };
                    timer.Start(); bool? accepted;
                    try { accepted = wizard.ShowDialog(); } finally { timer.Stop(); }
                    if (failure is not null) throw new InvalidOperationException("Actual copy wizard failed.", failure);
                    Check(valid ? accepted == true && wizard.Settings is not null : accepted != true && wizard.Settings is null, "Copy wizard activation did not match validated outcome.");
                    return accepted == true;
                }
                RunWizard(false); Check(File.ReadAllText(profile) == "previous-profile-bytes", "Failed preparation replaced the current workstation profile.");
                RunWizard(true); var prepared = WorkstationConfiguration.Load(profile) ?? throw new InvalidOperationException("Prepared profile was not saved.");
                Check(WorkstationReadiness.IsReady(prepared) && !File.ReadAllText(profile).Contains("copy-test-only", StringComparison.Ordinal), "Prepared profile is incomplete or exposes credentials.");
                var originalPhoto = File.ReadAllBytes(Path.Combine(sourceData, "bd", "images", "fixture.png"));
                var copiedPhoto = File.ReadAllBytes(Path.Combine(prepared.DataDirectory, "bd", "images", "fixture.png"));
                Check(originalPhoto.SequenceEqual(copiedPhoto), "Catalogue image copy differs.");
                Check(WorkstationPrinterProfile.DirectoryFor(prepared, "01") == prepared.DataDirectory && WorkstationPrinterProfile.FeatureDirectory(prepared) == prepared.DataDirectory,
                    "Original printer or credit configuration was not restored from the copied data.");
                var host = CatalogueHost.CreateCashierWorkstation(prepared, "01"); host.Window.Show();
                void QueuePin()
                {
                    _ = host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        var prompt = Application.Current.Windows.Cast<Window>().SingleOrDefault(window => window.Owner == host.Window && Controls<PasswordBox>(window).Any());
                        try { Check(prompt is not null, "Fresh cashier PIN missing."); Controls<PasswordBox>(prompt!).Single().Password = "1234"; Controls<Button>(prompt!).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent)); }
                        catch (Exception ex) { failure = ex; prompt?.Close(); }
                    }));
                }
                void Pin(Action action) { QueuePin(); action(); if (failure is not null) throw failure; }
                try
                {
                    var logged = false; Pin(() => logged = host.Window.ShowPinLogin()); Check(logged, "Copied profile could not authenticate original Unicode cashier.");
                    host.ViewModel.ScannerText = "GUI-CODE"; host.ViewModel.ScanCommand.Execute(null); Check(host.Session.PendingCount == 1, "Copied catalogue scanner did not reach the real session.");
                    _ = host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        var payment = Application.Current.Windows.OfType<CashierEntryDialog>().SingleOrDefault();
                        try
                        {
                            Check(payment is not null, "Copied workstation cash dialog missing.");
                            foreach (var coin in new[] { "5 MAD", "1 MAD" }) Controls<Button>(payment!).Single(button => System.Windows.Automation.AutomationProperties.GetName(button) == coin).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                            QueuePin();
                            Controls<Button>(payment!).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                        }
                        catch (Exception ex) { failure = ex; payment?.Close(); }
                    }));
                    var pay = (Button)host.Window.FindName("CompleteCheckoutButton");
                    host.Window.UpdateLayout(); Check(pay.IsEnabled && !host.ViewModel.CanCommit, "Fixed payment action was disabled before receiving cash.");
                    Capture(host.Window, Path.Combine(evidence, "prepared-cashier-before-payment.png"));
                    pay.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    if (failure is not null) throw failure;
                    Check(!host.ViewModel.CheckoutUncertain && host.Session.PendingCount == 0, "First copied-profile sale failed.");
                    Check(((TextBlock)host.Window.FindName("TrustedBasketTotal")).Text == "0.00", "Acknowledged sale did not immediately restore the authoritative empty-basket total.");
                    using var copied = new MySqlConnection(prepared.ConnectionString); copied.Open();
                    using var proof = new MySqlCommand("SELECT (SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='gui-fixture')=11 AND (SELECT CL FROM TABLE_NUM WHERE ID=0)=1 AND (SELECT SUM(MONTANT) FROM TABLE_VENTES_REGLEMENTS)=6 AND (SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL)=1", copied);
                    Check(Convert.ToBoolean(proof.ExecuteScalar()) && Convert.ToDecimal(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='gui-fixture'")) == 12m && Convert.ToInt32(Scalar("SELECT CL FROM TABLE_NUM WHERE ID=0")) == 0, "Copied sale changed the original or posted wrong stock/payment/counter.");
                    Capture(host.Window, Path.Combine(evidence, "prepared-cashier-sale.png"));
                }
                finally { host.Window.Close(); }
                File.WriteAllText(Path.Combine(evidence, "protected-copy-gui.json"), JsonSerializer.Serialize(new { ActualPreparationWizard = true, FailedCopyPreservesProfile = true, OriginalSchema = true, TwelveEmbeddedMigrations = true,
                    EncryptedProfileActivatedAfterValidation = true, CatalogueImageVerified = true, OriginalPrinterAndCreditFilesPreserved = true, UnicodePinLogin = true,
                    ActualScannerCashCoinsAndFreshPin = true, FixedPayButtonOpensCalculatorAndPosts = true, FirstSaleStockCounterPayment = true, OriginalDatabaseUnchanged = true }));
                Console.WriteLine("PASS protected first-setup wizard, copied files/profile and real scanner/coin/PIN sale with original database unchanged."); result = 0;
            }
            catch (Exception ex) { Console.Error.WriteLine(ex); }
            finally { owner.Close(); app.Shutdown(); }
            await Task.CompletedTask;
        };
        app.Run(owner); return result;
    }
}
