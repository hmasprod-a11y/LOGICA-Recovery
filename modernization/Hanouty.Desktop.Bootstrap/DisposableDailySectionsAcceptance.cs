#if HANOUTY_FINANCIAL
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Hanouty.Desktop.Wpf;

namespace Hanouty.Desktop.Bootstrap;
internal static partial class DisposableCashSaleAcceptance
{
    private static void SaveDailySection(Window window, string name)
    {
        window.UpdateLayout();
        var bitmap = new RenderTargetBitmap((int)Math.Ceiling(window.ActualWidth), (int)Math.Ceiling(window.ActualHeight), 96, 96, PixelFormats.Pbgra32);
        bitmap.Render(window); var png = new PngBitmapEncoder(); png.Frames.Add(BitmapFrame.Create(bitmap));
        using var file = File.Create(Path.Combine(EvidenceDirectory, name)); png.Save(file);
    }
    private static void PrepareDailyFixtureSchema(CatalogueSettings settings)
    {
        // Complete only the disposable fixture with original LOGICA columns and
        // defaults. Ordinary startup never creates or alters any shop schema.
        Sql(settings, "ALTER TABLE TABLE_PASS ADD COLUMN IF NOT EXISTS ARTICLES VARCHAR(32) DEFAULT 'VISIBLE'; " +
            "ALTER TABLE TABLE_ARTICLES ADD COLUMN IF NOT EXISTS Alert DECIMAL(19,4) DEFAULT 3, ADD COLUMN IF NOT EXISTS MODE_STOCK VARCHAR(64) DEFAULT 'FINI'; " +
            "ALTER TABLE TABLE_MOUVEMENTS_STOCK ADD COLUMN IF NOT EXISTS ID BIGINT NOT NULL AUTO_INCREMENT PRIMARY KEY");
        foreach (var (key, value) in new[] { ("MODELE_TICKET", "FR_3C"), ("BRANCHEMENT", "USB"), ("AFFICHER_MODE_P", "True"),
            ("AFFICHER_N_TICKET", "True"), ("AFFICHER_CODE_BARRE", "True"), ("PIED_TICKET", "Merci de votre visite"), ("FENETRE_MODE_P", "True") })
        {
            using var db = new MySql.Data.MySqlClient.MySqlConnection(settings.ConnectionString); db.Open();
            using var command = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO TABLE_PARAMETRES (OBJET,VALEUR) SELECT @key,@value WHERE NOT EXISTS (SELECT 1 FROM TABLE_PARAMETRES WHERE BINARY OBJET=BINARY @key)", db);
            command.Parameters.AddWithValue("@key", key); command.Parameters.AddWithValue("@value", value); command.ExecuteNonQuery();
        }
        foreach (var resource in new[] { "Hanouty.Migrations.20261117-stock-issue-history.sql", "Hanouty.StockIssueCreateMigration" })
        {
            using var stream = typeof(DisposableCashSaleAcceptance).Assembly.GetManifestResourceStream(resource) ?? throw new InvalidOperationException("Disposable fixture migration missing.");
            using var reader = new StreamReader(stream); Sql(settings, reader.ReadToEnd());
        }
    }
    private static void VerifyDailySections(CatalogueSettings settings)
    {
        PrepareDailyFixtureSchema(settings);
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01"); host.Window.Show();
        try
        {
            Require(CashierEntry(host, "Test admin", "01", "0", 0m, "6789"), "Daily sections admin login failed.");
            var before = Snapshot(settings); Exception? failure = null; var childSeen = false;
            host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var stock = Application.Current.Windows.OfType<DailyStockDialog>().SingleOrDefault();
                try
                {
                    Require(stock is not null && !host.Window.ShowPinLogin() && !host.Window.ShowSalesJournal(), "Stock did not freeze other session/section actions.");
                    var grid = CatalogueControls<DataGrid>(stock!).Single(control => System.Windows.Automation.AutomationProperties.GetName(control) == "Articles et stocks trouvés");
                    Require(grid.Items.Count > 0, "Connected Stock did not read existing sale/purchase articles.");
                    SaveDailySection(stock!, "daily-stock-connected.png");
                    host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        var child = Application.Current.Windows.OfType<CataloguePriceDialog>().SingleOrDefault();
                        try { Require(child is not null && !host.TryEndFinancialSession(), "Stock child did not reach the existing editor or allowed a financial session change."); childSeen = true; }
                        catch (Exception ex) { failure = ex; }
                        finally { child?.Close(); }
                    }));
                    CatalogueControls<Button>(stock!).Single(button => Equals(button.Content, "Catalogue et prix")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
                catch (Exception ex) { failure = ex; }
                finally { stock?.Close(); }
            }));
            Require(host.Window.ShowDailyStock(), "Daily stock navigation was unavailable.");
            if (failure is not null) throw new InvalidOperationException("Connected stock section failed.", failure);
            Require(childSeen && Snapshot(settings) == before, "Stock navigation changed financial data or did not reach catalogue.");

            var phase = 0; var settingsSeen = false;
            var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(50) }; var expires = DateTime.UtcNow.AddSeconds(15);
            timer.Tick += (_, _) =>
            {
                try
                {
                    if (DateTime.UtcNow > expires) throw new TimeoutException("Connected settings timed out.");
                    var windows = Application.Current.Windows.Cast<Window>().Where(window => window.Owner == host.Window).ToArray();
                    if (phase == 0 && windows.SingleOrDefault(window => CatalogueControls<PasswordBox>(window).Any()) is { } pin)
                    {
                        phase = 1; CatalogueControls<PasswordBox>(pin).Single().Password = "6789";
                        CatalogueControls<Button>(pin).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                    else if (phase == 1 && windows.OfType<WorkstationSettingsMenu>().SingleOrDefault() is { } menu)
                    {
                        phase = 2; SaveDailySection(menu, "daily-settings-menu.png");
                        host.Window.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                        {
                            var daily = Application.Current.Windows.OfType<DailyLogicaSettingsDialog>().SingleOrDefault();
                            try
                            {
                                Require(daily is not null && CatalogueControls<CheckBox>(daily).Count() == 4, "Daily LOGICA flags were not connected.");
                                settingsSeen = true; SaveDailySection(daily!, "daily-settings-connected.png");
                            }
                            catch (Exception ex) { failure = ex; }
                            finally { phase = 3; daily?.Close(); }
                        }));
                        CatalogueControls<Button>(menu).Single(button => System.Windows.Automation.AutomationProperties.GetName(button) == "Ticket et modes de paiement")
                            .RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                    else if (phase == 3 && windows.OfType<WorkstationSettingsMenu>().SingleOrDefault() is { } finished) { phase = 4; finished.Close(); }
                }
                catch (Exception ex)
                {
                    failure = ex; timer.Stop();
                    foreach (var window in Application.Current.Windows.Cast<Window>().Where(window => window.Owner == host.Window).Reverse().ToArray()) window.Close();
                }
            };
            timer.Start();
            try { CatalogueControls<Button>(host.Window).Single(button => System.Windows.Automation.AutomationProperties.GetName(button) == "Paramètres du poste").RaiseEvent(new RoutedEventArgs(Button.ClickEvent)); }
            finally { timer.Stop(); }
            if (failure is not null) throw new InvalidOperationException("Connected settings section failed.", failure);
            Require(settingsSeen && phase == 4 && Snapshot(settings) == before, "Settings navigation did not use the original store or changed financial data.");
            Require(((TextBlock)host.Window.FindName("TrustedBasketTotal")).Text == "0.00", "Leaving management sections lost the authoritative empty-basket total.");
            SaveDailySection(host.Window, "daily-primary-sections.png");
            File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-daily-sections.json"), JsonSerializer.Serialize(new {
                ActualStockNavigation = true, ExistingArticlesRead = true, ExistingCatalogueWorkflowLinked = true,
                SessionAndSectionsFrozen = true, ActualAdminSettingsPortal = true, OriginalSettingsDialogLinked = true,
                SameDatabaseAndCashier = true, NoFinancialWrites = true, PrimarySectionsVisible = true
            }));
        }
        finally { host.Window.Close(); }
    }
}
#endif
