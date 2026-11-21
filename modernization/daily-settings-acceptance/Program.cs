using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Hanouty.Checkout.MariaDb;
using Hanouty.Desktop.Bootstrap;
using Hanouty.Desktop.Wpf;
using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;

internal static class Program
{
    private static string connection = "";
    private static void Require(bool value, string reason) { if (!value) throw new InvalidOperationException(reason); }
    private static void Sql(string sql)
    { using var db = new MySqlConnection(connection); db.Open(); using var command = new MySqlCommand(sql, db); command.ExecuteNonQuery(); }
    private static string Scalar(string sql)
    { using var db = new MySqlConnection(connection); db.Open(); using var command = new MySqlCommand(sql, db); return Convert.ToString(command.ExecuteScalar()) ?? ""; }
    private static string State() => string.Join("|", Scalar("SELECT GROUP_CONCAT(CONCAT(OBJET,':',HEX(VALEUR)) ORDER BY BINARY OBJET SEPARATOR '|') FROM TABLE_PARAMETRES"), Scalar("SELECT COUNT(*) FROM SETTINGS_WRITE_PROOF"), Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"), Scalar("SELECT SUM(TOTAL_NET) FROM TABLE_VENTES_JOURNAL"));
    [STAThread]
    private static int Main(string[] args)
    {
        try
        {
            var cs = new MySqlConnectionStringBuilder(Environment.GetEnvironmentVariable("HANOUTY_SETTINGS_TEST_CONNECTION") ?? "");
            Require(cs.Server is "127.0.0.1" or "localhost" && cs.Database == "settings_disposable", "Disposable local settings schema required.");
            cs.CharacterSet = "utf8mb4"; connection = cs.ConnectionString;
            var evidence = Path.GetFullPath(args.FirstOrDefault() ?? "daily-settings-evidence"); Directory.CreateDirectory(evidence);
            Seed();
            var store = new DailyLogicaSettingsStore(connection); var access = store.Authorize("Admin d'été", () => "6789");
            var initial = store.Read(access); var before = State();
            Require(initial.Values.Template == "FR_4C" && initial.Values.Connection == "COM" && initial.Values.ShowTicketNumber && initial.MaximumValueLength == 255,
                "Original raw boolean/unsupported-route snapshot or real SQL field limit changed.");
            void Denied(Action action)
            { var old = State(); var refused = false; try { action(); } catch (Exception ex) when (ex is InvalidOperationException or UnauthorizedAccessException or ArgumentException or NotSupportedException) { refused = true; } Require(refused && State() == old, "Rejected settings command wrote partial configuration/business data."); }
            Denied(() => store.Authorize("Manager", () => "5678")); Denied(() => store.Authorize("User", () => "1234"));
            Denied(() => store.Authorize("Admin d'été", () => "bad")); Denied(() => store.Authorize("Admin d'ete", () => "6789"));
            var arabic = store.Authorize("مدير", () => "8765"); Require(store.Read(arabic) == initial, "Arabic ADMIN did not read the exact original snapshot.");
            Denied(() => store.Authorize("مدیر", () => "8765"));
            Denied(() => new DailyLogicaSettingsStore(connection).Read(access));
            Require(State() == before, "Authorization/read changed settings.");
            var preserved = store.Save(access, initial, initial.Values with { Footer = "Avant l'été" }, "6789");
            Require(preserved.Values.Template == "FR_4C" && preserved.Values.Connection == "COM" && Scalar("SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET='AFFICHER_N_TICKET'") == "-1",
                "Unchanged original raw flag or unsupported route was silently normalized/selected.");
            var active = true; var pinReads = 0; var workflow = new DailyLogicaSettingsWorkflow(store, access, () => active, () => { pinReads++; return "6789"; });
            UiProof(workflow, evidence);
            var saved = store.Read(access);
            Require(pinReads == 1 && saved.Values.Template == "FR_3C" && saved.Values.Connection == "USB" && saved.Values.ShowPayment && saved.Values.ShowQr && saved.Values.PaymentWindow &&
                saved.Values.ShowTicketNumber && saved.Values.Footer == "Merci d'été\r\nمرحبا" && Scalar("SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET='AFFICHER_N_TICKET'") == "-1" &&
                Scalar("SELECT VALEUR FROM TABLE_PARAMETRES WHERE OBJET='UNRELATED'") == "original" && Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL") == "1" && decimal.Parse(Scalar("SELECT SUM(TOTAL_NET) FROM TABLE_VENTES_JOURNAL")) == 99m,
                "Actual UI did not save original keys/UTF8 values exactly or changed unrelated/business data.");
            MySqlConnection Connect() => new(connection);
            Require(MariaDbCashCheckoutServices.IsCardPaymentAvailable(Connect), "Saved FENETRE_MODE_P did not reach the existing real payment availability reader.");
            var localDirectory = Path.Combine(evidence, "test-workstation-profile"); Directory.CreateDirectory(localDirectory); File.WriteAllText(Path.Combine(localDirectory, "PRINTER_CL.sni"), "");
            using (var db = Connect())
            {
                db.Open(); var printer = LogicaReceiptSettings.Read(db, localDirectory); Require(printer is not null && printer.Template == "FR_3C" && printer.Connection == "USB",
                    "Saved model/connection did not reach the existing receipt settings reader.");
                Require(ReceiptPrintRouting.Select("", true, "VENTE", printer!.Connection, printer.Template, out var copies) == ReceiptPrintRoute.FrenchThreeColumn && copies == 1,
                    "Settings did not select the existing FR_3C receipt route.");
            }
            Denied(() => store.Save(access, saved, saved.Values with { Template = "AR_4C" }, "6789"));
            Denied(() => store.Save(access, saved, saved.Values with { Connection = "SERIAL" }, "6789"));
            Denied(() => store.Save(access, saved, saved.Values with { Footer = new string('x', 256) }, "6789"));
            Denied(() => store.Save(access, saved, saved.Values with { Footer = "bad\u001btext" }, "6789"));
            Denied(() => store.Save(access, saved, saved.Values with { Footer = "Wrong PIN" }, "bad"));
            var draft = saved.Values with { ShowQr = false, Footer = "Rollback footer" };
            Sql("CREATE TRIGGER settings_fail BEFORE UPDATE ON TABLE_PARAMETRES FOR EACH ROW BEGIN IF NEW.OBJET='PIED_TICKET' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='settings-after-flags'; END IF; END");
            try { Denied(() => store.Save(access, saved, draft, "6789")); } finally { Sql("DROP TRIGGER settings_fail"); }
            Sql("CREATE TRIGGER settings_tamper BEFORE UPDATE ON TABLE_PARAMETRES FOR EACH ROW BEGIN IF NEW.OBJET='PIED_TICKET' THEN SET NEW.VALEUR='tampered'; END IF; END");
            try { Denied(() => store.Save(access, saved, saved.Values with { Footer = "Expected exact footer" }, "6789")); } finally { Sql("DROP TRIGGER settings_tamper"); }
            Sql("CREATE TRIGGER settings_raw_tamper BEFORE UPDATE ON TABLE_PARAMETRES FOR EACH ROW BEGIN IF NEW.OBJET='AFFICHER_CODE_BARRE' THEN SET NEW.VALEUR='0'; END IF; END");
            try { Denied(() => store.Save(access, saved, saved.Values with { ShowQr = false }, "6789")); } finally { Sql("DROP TRIGGER settings_raw_tamper"); }
            Sql("UPDATE TABLE_PARAMETRES SET VALEUR='Other admin' WHERE OBJET='PIED_TICKET'");
            Denied(() => store.Save(access, saved, saved.Values with { Footer = "Stale overwrite" }, "6789"));
            var refreshed = workflow.Reload(); Require(refreshed.Values.Footer == "Other admin", "Explicit reload did not show concurrent settings.");
            var unknownStore = new DailyLogicaSettingsStore(connection, () => throw new IOException("settings-ack-lost"));
            var unknownAccess = unknownStore.Authorize("Admin d'été", () => "6789"); var retryPin = "6789";
            var unknown = new DailyLogicaSettingsWorkflow(unknownStore, unknownAccess, () => active, () => retryPin);
            var expected = unknown.Reload(); var desired = expected.Values with { Footer = "Saved despite lost acknowledgement" };
            var lost = false; try { unknown.Save(expected, desired); } catch (IOException) { lost = true; }
            Require(lost && unknown.Pending is not null, "Lost settings acknowledgement discarded its immutable desired state.");
            var writes = Scalar("SELECT COUNT(*) FROM SETTINGS_WRITE_PROOF"); retryPin = "bad";
            Denied(() => unknown.Save(expected, desired)); Require(unknown.Pending is not null, "Wrong recovery PIN discarded a possibly applied setting.");
            retryPin = ""; Denied(() => unknown.Save(expected, desired)); Require(unknown.Pending is not null, "Cancelled recovery PIN discarded a possibly applied setting.");
            retryPin = "6789"; Require(unknown.Save(expected, desired).Values == desired && unknown.Pending is null && Scalar("SELECT COUNT(*) FROM SETTINGS_WRITE_PROOF") == writes,
                "Settings retry repeated UPDATEs rather than verifying an already applied deterministic state.");
            var reopened = new DailyLogicaSettingsStore(connection); var reopenedAccess = reopened.Authorize("Admin d'été", () => "6789");
            Require(reopened.Read(reopenedAccess).Values == desired, "Saved configuration did not survive a fresh store/workflow.");
            active = false; Denied(() => workflow.Reload()); active = true;
            Sql("UPDATE TABLE_PASS SET Catégorie='MANAGER' WHERE ListUser='Admin d''été'");
            Denied(() => workflow.Reload()); Denied(() => store.Save(access, refreshed, desired, "6789"));
            Sql("UPDATE TABLE_PASS SET Catégorie='ADMIN' WHERE ListUser='Admin d''été'");
            Sql("INSERT INTO TABLE_PARAMETRES (OBJET,VALEUR) VALUES ('pied_ticket','alias')"); Denied(() => store.Read(access)); Sql("DELETE FROM TABLE_PARAMETRES WHERE BINARY OBJET=BINARY 'pied_ticket'");
            Sql("DELETE FROM TABLE_PARAMETRES WHERE OBJET='AFFICHER_MODE_P'"); Denied(() => store.Read(access));
            File.WriteAllText(Path.Combine(evidence, "daily-logica-settings-acceptance.json"), JsonSerializer.Serialize(new {
                OriginalSevenKeys = true, AdminOnlyFreshPin = true, ArabicAccentExactIdentity = true, UnchangedRawBooleanPreserved = true,
                ExistingUnsupportedRoutePreserved = true, OnlyConnectedNewRoute = true, ActualWpfSave = true,
                ExistingPaymentAvailability = true, ExistingReceiptSettingsAndRoute = true, Utf8MultilineFooter = true,
                UnrelatedAndBusinessDataUnchanged = true, ConcurrentSnapshotRefused = true, MultiKeyRollback = true,
                ExactReadbackTamperRefused = true, LostAcknowledgementVerifiedWithoutNewUpdates = true, RecoveryPinRetainsPending = true,
                ReopenedSettingsPersisted = true, RevokedRoleRefused = true, MissingDuplicateSettingsRefused = true
            }, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine("PASS original daily settings: actual SQL/WPF7keys, raw VB flags, ADMIN/PIN/UTF8/CAS, connected payment/FR_3C readers, rollback/tamper and lost-ack verification without repeated updates."); return 0;
        }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
    }
    private static void Seed() => Sql("CREATE TABLE TABLE_PASS (ListUser VARCHAR(128),ListPass VARCHAR(256),Catégorie VARCHAR(64)) ENGINE=InnoDB; " +
        "INSERT INTO TABLE_PASS VALUES ('Admin d''été','6789','ADMIN'),('مدير','8765','ADMIN'),('Manager','5678','MANAGER'),('User','1234','UTILISATEUR'); " +
        "CREATE TABLE TABLE_PARAMETRES (ID INT AUTO_INCREMENT PRIMARY KEY,OBJET VARCHAR(255),VALEUR VARCHAR(255)) ENGINE=InnoDB; " +
        "INSERT INTO TABLE_PARAMETRES (OBJET,VALEUR) VALUES ('MODELE_TICKET','FR_4C'),('BRANCHEMENT','COM'),('AFFICHER_MODE_P','False'),('AFFICHER_N_TICKET','-1'),('AFFICHER_CODE_BARRE','False'),('PIED_TICKET','Initial'),('FENETRE_MODE_P','False'),('UNRELATED','original'); " +
        "CREATE TABLE TABLE_MODE_P (MODE_P VARCHAR(64)) ENGINE=InnoDB; INSERT INTO TABLE_MODE_P VALUES ('CARTE'); " +
        "CREATE TABLE TABLE_VENTES_JOURNAL (ID INT PRIMARY KEY,TOTAL_NET DECIMAL(19,4)) ENGINE=InnoDB; INSERT INTO TABLE_VENTES_JOURNAL VALUES (1,99); " +
        "CREATE TABLE SETTINGS_WRITE_PROOF (ID INT AUTO_INCREMENT PRIMARY KEY,OBJET VARCHAR(255),VALEUR VARCHAR(255)) ENGINE=InnoDB; " +
        "CREATE TRIGGER settings_write_count AFTER UPDATE ON TABLE_PARAMETRES FOR EACH ROW INSERT INTO SETTINGS_WRITE_PROOF (OBJET,VALEUR) VALUES (NEW.OBJET,NEW.VALEUR)");
    private static IEnumerable<T> Controls<T>(DependencyObject parent) where T : DependencyObject
    { foreach (var child in LogicalTreeHelper.GetChildren(parent).OfType<DependencyObject>()) { if (child is T match) yield return match; foreach (var nested in Controls<T>(child)) yield return nested; } }
    private static void UiProof(IDailyLogicaSettingsWorkflow workflow, string evidence)
    {
        _ = new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown }; var dialog = new DailyLogicaSettingsDialog(workflow); Exception? failure = null;
        var timeout = new DispatcherTimer { Interval = TimeSpan.FromSeconds(10) };
        timeout.Tick += (_, _) => { failure = new TimeoutException("Actual settings window did not settle."); timeout.Stop(); dialog.Close(); };
        dialog.Loaded += (_, _) => dialog.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            try
            {
                var choices = Controls<ComboBox>(dialog).ToArray(); Require(choices.Length == 2, "Actual settings selectors missing.");
                choices[0].SelectedItem = "FR_3C"; choices[1].SelectedItem = "USB";
                foreach (var box in Controls<CheckBox>(dialog)) box.IsChecked = true;
                Controls<TextBox>(dialog).Single(box => System.Windows.Automation.AutomationProperties.GetName(box) == "Pied du ticket LOGICA").Text = "Merci d'été\r\nمرحبا";
                Controls<Button>(dialog).Single(button => Equals(button.Content, "Enregistrer les paramètres")).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                Require(workflow.Pending is null && Controls<TextBlock>(dialog).Any(text => text.Text.StartsWith("Paramètres enregistrés", StringComparison.Ordinal)), "Actual settings UI did not confirm a real SQL save.");
                dialog.UpdateLayout(); var bitmap = new RenderTargetBitmap((int)Math.Ceiling(dialog.ActualWidth), (int)Math.Ceiling(dialog.ActualHeight), 96, 96, PixelFormats.Pbgra32); bitmap.Render(dialog);
                var png = new PngBitmapEncoder(); png.Frames.Add(BitmapFrame.Create(bitmap)); using var output = File.Create(Path.Combine(evidence, "daily-logica-settings-wpf.png")); png.Save(output);
            }
            catch (Exception ex) { failure = ex; }
            finally { timeout.Stop(); dialog.Close(); }
        }));
        timeout.Start(); dialog.ShowDialog(); if (failure is not null) throw failure;
    }
}
