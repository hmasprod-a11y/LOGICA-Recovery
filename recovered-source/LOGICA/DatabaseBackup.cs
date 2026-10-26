using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using MySql.Data.MySqlClient;

namespace LOGICA;

// Backup and maintenance share one lock lifetime. InnoDB next-key locks keep
// all rows and insertion gaps stable while the independent dump uses MVCC.
public static class DatabaseBackup
{
    public static string Create(string connectionString, string directory, string serverBin)
    {
        return CreateAndClear(connectionString, directory, new string[0], serverBin);
    }

    public static string CreateToFile(string connectionString, string destination, string serverBin)
    {
        destination = Path.GetFullPath(destination);
        if (!string.Equals(Path.GetExtension(destination), ".sql", StringComparison.OrdinalIgnoreCase))
            throw new ArgumentException("Choisir un fichier .sql; les anciennes bases .sni ont un autre format.");
        if (File.Exists(destination) || File.Exists(destination + ".sha256"))
            throw new IOException("Ce fichier existe deja. Choisissez un nouveau nom pour conserver la sauvegarde precedente.");
        string generated = Create(connectionString, Path.GetDirectoryName(destination), serverBin);
        bool dataCreated = false, hashCreated = false;
        try
        {
            using (var target = new FileStream(destination, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                dataCreated = true;
                using (var source = File.OpenRead(generated)) source.CopyTo(target);
                target.Flush(true);
            }
            using (var target = new FileStream(destination + ".sha256", FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                hashCreated = true;
                byte[] hash = Encoding.ASCII.GetBytes(File.ReadAllText(generated + ".sha256", Encoding.ASCII));
                target.Write(hash, 0, hash.Length); target.Flush(true);
            }
            Verify(destination);
        }
        catch
        {
            if (dataCreated) File.Delete(destination);
            if (hashCreated) File.Delete(destination + ".sha256");
            throw;
        }
        File.Delete(generated); File.Delete(generated + ".sha256");
        return destination;
    }

    public static string FindServerBin(string root)
    {
        string configured = Environment.GetEnvironmentVariable("LOGICA_MYSQL_BIN");
        if (!string.IsNullOrWhiteSpace(configured)) return Path.GetFullPath(configured);
        string servers = Path.Combine(root, "bd", "mysql-server");
        if (Directory.Exists(servers))
            foreach (string name in new[] { "mariadb-dump.exe", "mysqldump.exe" })
            {
                string file = Directory.GetFiles(servers, name, SearchOption.AllDirectories).FirstOrDefault();
                if (file != null) return Path.GetDirectoryName(file);
            }
        throw new FileNotFoundException("Outil de sauvegarde MySQL introuvable. Configurez LOGICA_MYSQL_BIN.");
    }

    public static string CreateAndClear(string connectionString, string directory, string[] selectedTables, string serverBin)
    {
        if (selectedTables == null) throw new ArgumentNullException("selectedTables");
        string dump = new[] { "mariadb-dump.exe", "mysqldump.exe" }
            .Select(n => Path.Combine(serverBin, n)).FirstOrDefault(File.Exists);
        if (dump == null) throw new FileNotFoundException("Outil de sauvegarde MySQL introuvable.");
        var settings = new MySqlConnectionStringBuilder(connectionString);
        if (string.IsNullOrWhiteSpace(settings.Database)) throw new InvalidOperationException("Base de donnees obligatoire.");
        // The bundled CLI cannot silently weaken a verified TLS connection.
        string ssl = settings.SslMode.ToString();
        if (ssl != "None" && ssl != "Preferred" && ssl != "Disabled")
            throw new NotSupportedException("Ce mode TLS exige une configuration de sauvegarde dediee.");
        string backup = null;
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var tables = new List<string>();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT TABLE_NAME,ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME";
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        if (!string.Equals(reader.GetString(1), "InnoDB", StringComparison.OrdinalIgnoreCase))
                            throw new NotSupportedException("Sauvegarde transactionnelle impossible: table non InnoDB.");
                        tables.Add(reader.GetString(0));
                    }
            }
            string[] selected = selectedTables.Distinct(StringComparer.Ordinal).ToArray();
            if (selected.Any(t => !tables.Contains(t))) throw new InvalidOperationException("Table selectionnee inconnue.");
            using (var transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead))
            {
                try
                {
                    // Full scans lock records AND gaps, including empty tables.
                    // Consume the reader without converting values (zero dates/binary).
                    foreach (string table in tables)
                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandTimeout = 120;
                            command.CommandText = "SELECT * FROM " + Identifier(table) + " FOR UPDATE";
                            using (var reader = command.ExecuteReader()) while (reader.Read()) { }
                        }
                    backup = Export(dump, settings, directory);
                    // No DELETE can run unless the complete dump and hash exist.
                    Verify(backup);
                    foreach (string table in selected)
                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandTimeout = 120;
                            command.CommandText = "DELETE FROM " + Identifier(table);
                            command.ExecuteNonQuery();
                        }
                    transaction.Commit();
                    return backup;
                }
                catch
                {
                    try { transaction.Rollback(); } catch { }
                    throw;
                }
            }
        }
    }

    public static void Verify(string file)
    {
        string expected = File.ReadAllText(file + ".sha256", Encoding.ASCII).Trim();
        if (!string.Equals(expected, Hash(file), StringComparison.OrdinalIgnoreCase))
            throw new InvalidDataException("Integrite de sauvegarde invalide.");
    }

    private static string Identifier(string name) { return "`" + name.Replace("`", "``") + "`"; }
    private static string Hash(string file)
    {
        using (var sha = SHA256.Create())
        using (var stream = File.OpenRead(file))
            return BitConverter.ToString(sha.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
    }
    private static string Option(string value)
    {
        if (value.IndexOf('\0') >= 0) throw new ArgumentException("Option MySQL invalide.");
        return "\"" + value.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r").Replace("\n", "\\n") + "\"";
    }
    private static string Argument(string value)
    {
        // Windows command-line quoting, including trailing backslashes.
        var result = new StringBuilder("\""); int slashes = 0;
        foreach (char c in value)
        {
            if (c == '\\') { slashes++; continue; }
            if (c == '"') result.Append('\\', slashes * 2 + 1).Append(c);
            else result.Append('\\', slashes).Append(c);
            slashes = 0;
        }
        return result.Append('\\', slashes * 2).Append('"').ToString();
    }

    private static string Export(string executable, MySqlConnectionStringBuilder settings, string directory)
    {
        Directory.CreateDirectory(directory);
        string final = Path.Combine(Path.GetFullPath(directory), "LOGICA-" + DateTime.UtcNow.ToString("yyyyMMddTHHmmssfff", CultureInfo.InvariantCulture) + "-" + Guid.NewGuid().ToString("N") + ".sql");
        string partial = final + ".partial";
        string temporary = Path.Combine(Path.GetTempPath(), "logica-backup-" + Guid.NewGuid().ToString("N"));
        var security = new DirectorySecurity();
        security.SetAccessRuleProtection(true, false);
        security.AddAccessRule(new FileSystemAccessRule(WindowsIdentity.GetCurrent().User, FileSystemRights.FullControl,
            InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
        Directory.CreateDirectory(temporary, security);
        bool published = false;
        try
        {
            string options = Path.Combine(temporary, "client.ini");
            string text = "[client]\nprotocol=tcp\nhost=" + Option(settings.Server) + "\nport=" + settings.Port.ToString(CultureInfo.InvariantCulture)
                + "\nuser=" + Option(settings.UserID) + "\npassword=" + Option(settings.Password) + "\ndefault-character-set=utf8mb4\n";
            if (settings.SslMode.ToString() == "None" || settings.SslMode.ToString() == "Disabled") text += "skip-ssl\n";
            File.WriteAllText(options, text, new UTF8Encoding(false));
            var start = new ProcessStartInfo(executable,
                Argument("--defaults-file=" + options) + " --single-transaction --skip-lock-tables --skip-add-locks --hex-blob --routines --events --triggers "
                + Argument("--result-file=" + partial) + " " + Argument(settings.Database));
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardError = true;
            using (var process = Process.Start(start))
            {
                var errors = process.StandardError.ReadToEndAsync();
                if (!process.WaitForExit(120000))
                {
                    process.Kill(); process.WaitForExit();
                    throw new TimeoutException("Sauvegarde MySQL trop longue; aucune table effacee.");
                }
                errors.GetAwaiter().GetResult(); // Drain diagnostics; never expose credentials.
                if (process.ExitCode != 0) throw new IOException("Echec de sauvegarde MySQL (code " + process.ExitCode + "); aucune table effacee.");
            }
            using (var stream = File.OpenRead(partial))
            {
                if (stream.Length == 0) throw new InvalidDataException("Sauvegarde vide.");
                stream.Position = Math.Max(0, stream.Length - 4096);
                using (var reader = new StreamReader(stream))
                    if (!reader.ReadToEnd().Contains("-- Dump completed on")) throw new InvalidDataException("Sauvegarde incomplete.");
            }
            File.Move(partial, final);
            File.WriteAllText(final + ".sha256", Hash(final) + "\n", Encoding.ASCII);
            // Complete OS-level flushes before any DELETE is allowed to commit.
            foreach (string file in new[] { final, final + ".sha256" })
                using (var stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite, FileShare.Read)) stream.Flush(true);
            published = true;
            return final;
        }
        finally
        {
            if (File.Exists(partial)) File.Delete(partial);
            if (!published)
            {
                if (File.Exists(final)) File.Delete(final);
                if (File.Exists(final + ".sha256")) File.Delete(final + ".sha256");
            }
            if (Directory.Exists(temporary)) Directory.Delete(temporary, true);
        }
    }
}
