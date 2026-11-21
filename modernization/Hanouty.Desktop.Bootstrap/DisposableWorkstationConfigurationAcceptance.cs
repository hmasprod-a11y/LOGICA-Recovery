#if HANOUTY_FINANCIAL
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;
internal static partial class DisposableCashSaleAcceptance
{
    private static void VerifyWorkstationConfiguration(CatalogueSettings settings)
    {
        var root = Path.Combine(EvidenceDirectory, "workstation-configuration"); Directory.CreateDirectory(root);
        var path = Path.Combine(root, "workstation.json");
        var reviewed = settings with { WorkstationId = "07" };
        var before = Snapshot(settings);
        var printerDirectory = Path.Combine(root, "printer-profile");
        WorkstationPrinterDialog.SavePrinter(printerDirectory, "Imprimante d’été");
        var printerPath = Path.Combine(printerDirectory, "PRINTER_CL.sni");
        Require(File.ReadAllText(printerPath) == "Imprimante d’été", "Local printer profile lost Unicode identity.");
        WorkstationPrinterDialog.SavePrinter(printerDirectory, "0");
        var invalidPrinterDenied = false;
        try { WorkstationPrinterDialog.SavePrinter(printerDirectory, "forged\nprinter"); }
        catch (ArgumentException) { invalidPrinterDenied = true; }
        Require(invalidPrinterDenied && File.ReadAllText(printerPath) == "0" && Directory.GetFiles(printerDirectory).Length == 1,
            "Invalid printer replaced the saved choice or left an incomplete profile.");
        var changedPassword = new MySqlConnectionStringBuilder(settings.ConnectionString) { Password = "different-test-password" };
        Require(WorkstationPrinterProfile.ProfileDirectory(settings, "01") == WorkstationPrinterProfile.ProfileDirectory(settings with { ConnectionString = changedPassword.ConnectionString }, "01") &&
            WorkstationPrinterProfile.ProfileDirectory(settings, "01") != WorkstationPrinterProfile.ProfileDirectory(settings, "02"),
            "Printer profile was coupled to a password or shared across different registers.");
        WorkstationConfiguration.CheckConnection(reviewed);
        WorkstationConfiguration.Save(path, reviewed);
        var loaded = WorkstationConfiguration.Load(path);
        Require(loaded == reviewed && !File.ReadAllText(path).Contains(new MySqlConnectionStringBuilder(settings.ConnectionString).Password, StringComparison.Ordinal),
            "Saved workstation configuration lost its identity or exposed the database password.");
        var previous = File.ReadAllBytes(path);
        var denied = false;
        try { WorkstationConfiguration.Save(path, reviewed with { ConnectionString = "Server=example.invalid;Database=shop;Uid=admin;Pwd=secret" }); }
        catch (InvalidOperationException) { denied = true; }
        Require(denied && File.ReadAllBytes(path).SequenceEqual(previous), "Invalid configuration replaced the saved workstation.");
        File.WriteAllText(path, "{\"Version\":1,\"ProtectedConnection\":\"not-encrypted\",\"DataDirectory\":\"\",\"Workstation\":\"07\"}");
        denied = false;
        try { WorkstationConfiguration.Load(path); } catch (Exception ex) when (ex is FormatException or System.Security.Cryptography.CryptographicException) { denied = true; }
        Require(denied, "A damaged protected configuration was accepted.");
        File.Delete(path);
        var dialog = new WorkstationSetupDialog(path);
        Exception? failure = null;
        var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromSeconds(20) };
        timer.Tick += (_, _) => { failure ??= new TimeoutException("Workstation setup did not complete."); timer.Stop(); dialog.Close(); };
        dialog.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            try
            {
                var cs = new MySqlConnectionStringBuilder(settings.ConnectionString);
                var fields = CatalogueControls<TextBox>(dialog).ToArray();
                void Set(string name, string value) => fields.Single(field => System.Windows.Automation.AutomationProperties.GetName(field) == name).Text = value;
                Set("Serveur local", cs.Server); Set("Port", cs.Port.ToString()); Set("Base de données", cs.Database); Set("Utilisateur de la base", cs.UserID);
                CatalogueControls<PasswordBox>(dialog).Single().Password = cs.Password;
                Set("Dossier de données LOGICA", settings.DataDirectory); Set("Numéro du poste", "07");
                CatalogueControls<Button>(dialog).Single(button => button.IsDefault).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            catch (Exception ex) { failure = ex; dialog.Close(); }
        }));
        timer.Start(); bool? result;
        try { result = dialog.ShowDialog(); } finally { timer.Stop(); }
        if (failure is not null) throw new InvalidOperationException("Actual workstation setup failed.", failure);
        var configured = WorkstationConfiguration.Load(path);
        Require(result == true && configured is not null && configured.WorkstationId == reviewed.WorkstationId &&
            configured.DataDirectory == reviewed.DataDirectory && new MySqlConnectionStringBuilder(configured.ConnectionString).EquivalentTo(new MySqlConnectionStringBuilder(reviewed.ConnectionString)) && Snapshot(settings) == before,
            "Actual setup dialog did not persist/reload settings or modified financial data.");
        File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-workstation-configuration.json"), JsonSerializer.Serialize(new {
            EncryptedCurrentUser = true, ReloadWithoutEnvironment = true, InvalidConfigurationPreservesPrevious = true,
            DamagedCiphertextRejected = true, ActualSetupDialog = true, NoFinancialWrites = true,
            PersistentUnicodePrinterProfile = true, InvalidPrinterPreservesPrevious = true, PrinterSeparatedByRegister = true
        }));
    }
}
#endif
