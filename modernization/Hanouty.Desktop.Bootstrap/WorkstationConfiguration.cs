using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal static class WorkstationConfiguration
{
    private sealed record Saved(int Version, string ProtectedConnection, string DataDirectory, string Workstation);
    internal static string DefaultPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HANOUTY", "workstation.json");
    private static readonly byte[] Entropy = Encoding.UTF8.GetBytes("HANOUTY-local-workstation-v1");
    internal static CatalogueSettings? Load(string path)
    {
        if (!File.Exists(path)) return null;
        var saved = JsonSerializer.Deserialize<Saved>(File.ReadAllText(path)) ?? throw new InvalidDataException("Configuration du poste illisible.");
        if (saved.Version != 1) throw new InvalidDataException("Version de configuration du poste inconnue.");
        var bytes = ProtectedData.Unprotect(Convert.FromBase64String(saved.ProtectedConnection), Entropy, DataProtectionScope.CurrentUser);
        try { return CatalogueSettings.Validate(Encoding.UTF8.GetString(bytes), saved.DataDirectory, saved.Workstation); }
        finally { CryptographicOperations.ZeroMemory(bytes); }
    }
    internal static void Save(string path, CatalogueSettings settings)
    {
        settings = CatalogueSettings.Validate(settings.ConnectionString, settings.DataDirectory, settings.WorkstationId);
        var bytes = Encoding.UTF8.GetBytes(settings.ConnectionString);
        byte[] encrypted;
        try { encrypted = ProtectedData.Protect(bytes, Entropy, DataProtectionScope.CurrentUser); }
        finally { CryptographicOperations.ZeroMemory(bytes); }
        var saved = new Saved(1, Convert.ToBase64String(encrypted), settings.DataDirectory, settings.WorkstationId);
        Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(path))!);
        var temporary = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try
        {
            using (var file = new FileStream(temporary, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            { JsonSerializer.Serialize(file, saved); file.Flush(true); }
            File.Move(temporary, path, true);
        }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
    // Configuration only: never create/migrate a database or change shop rows.
    internal static void CheckConnection(CatalogueSettings settings)
    {
        CatalogueSettings.Validate(settings.ConnectionString, settings.DataDirectory, settings.WorkstationId);
        var builder = new MySqlConnectionStringBuilder(settings.ConnectionString) { ConnectionTimeout = 5 };
        using var connection = new MySqlConnection(builder.ConnectionString); connection.Open();
        using var command = connection.CreateCommand(); command.CommandTimeout = 5;
        command.CommandText = "SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME IN ('TABLE_PASS','TABLE_ARTICLES','TABLE_NUM','TABLE_VENTES_ENTETE','TABLE_PARAMETRES')";
        if (Convert.ToInt32(command.ExecuteScalar()) != 5) throw new InvalidOperationException("La base choisie ne contient pas les tables LOGICA attendues.");
        if (!Directory.Exists(Path.Combine(settings.DataDirectory, "bd", "images")))
        {
            command.CommandText = "SELECT COUNT(*) FROM TABLE_ARTICLES WHERE Images IS NOT NULL AND TRIM(Images) NOT IN ('','0')";
            if (Convert.ToInt64(command.ExecuteScalar()) > 0)
                throw new InvalidOperationException("Choisissez le dossier principal LOGICA contenant bd\\images pour conserver les photos des articles.");
        }
    }
    internal static CatalogueSettings? Interactive()
    {
        // Existing explicit test/administrator environments stay isolated from the saved profile.
        if (Environment.GetEnvironmentVariable("HANOUTY_CATALOGUE_CONNECTION") is not null)
            return CatalogueSettings.FromEnvironment();
        CatalogueSettings? previous = null;
        try
        {
            if (Load(DefaultPath) is { } configured)
            {
                previous = configured;
                if (WorkstationReadiness.IsReady(configured)) return configured;
                var preparation = new ProtectedWorkstationCopyDialog(configured, DefaultPath) { WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen };
                return preparation.ShowDialog() == true ? preparation.Settings : null;
            }
        }
        catch (Exception ex) when (ex is IOException or JsonException or CryptographicException or FormatException or InvalidOperationException or ArgumentException or MySqlException)
        { /* A corrupt or foreign-user profile is repaired only by a successful explicit save. */ }
        var dialog = new WorkstationSetupDialog(DefaultPath, previous);
        return dialog.ShowDialog() == true ? dialog.Settings : null;
    }
}
