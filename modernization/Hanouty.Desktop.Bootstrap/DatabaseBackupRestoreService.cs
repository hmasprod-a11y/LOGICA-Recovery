using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

public sealed record DatabaseBackupResult(string BackupFilePath, string Sha256, long SizeBytes);

internal sealed class DatabaseBackupRestoreService(string connectionString, string toolsDirectory)
{
    public async Task<DatabaseBackupResult> CreateBackupAsync(string outputDirectory, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(outputDirectory))
            throw new ArgumentException("Dossier de sauvegarde obligatoire.", nameof(outputDirectory));
        Directory.CreateDirectory(outputDirectory);

        var builder = new MySqlConnectionStringBuilder(connectionString);
        if (string.IsNullOrWhiteSpace(builder.Database))
            throw new InvalidOperationException("Nom de base de données manquant.");

        var dumpExe = FindTool("mariadb-dump.exe", "mysqldump.exe");
        var stamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
        var sqlPath = Path.Combine(outputDirectory, $"hanouty-backup-{builder.Database}-{stamp}.sql");
        var defaultsFile = WriteTempDefaultsFile(builder);

        try
        {
            await RunProcessAsync(dumpExe, new[]
            {
                $"--defaults-file={defaultsFile}",
                "--single-transaction",
                "--routines",
                "--triggers",
                "--hex-blob",
                $"--result-file={sqlPath}",
                builder.Database
            }, null, ct);

            var hash = await ComputeSha256Async(sqlPath, ct);
            await File.WriteAllTextAsync(sqlPath + ".sha256", $"{hash}  {Path.GetFileName(sqlPath)}{Environment.NewLine}", Encoding.UTF8, ct);
            var size = new FileInfo(sqlPath).Length;
            return new DatabaseBackupResult(sqlPath, hash, size);
        }
        finally
        {
            TryDelete(defaultsFile);
        }
    }

    public async Task RestoreBackupAsync(string sqlFilePath, string safetySnapshotDirectory, CancellationToken ct = default)
    {
        if (!File.Exists(sqlFilePath))
            throw new FileNotFoundException("Fichier de sauvegarde introuvable.", sqlFilePath);

        var shaFile = sqlFilePath + ".sha256";
        if (File.Exists(shaFile))
        {
            var expected = (await File.ReadAllTextAsync(shaFile, ct)).Split(' ', StringSplitOptions.RemoveEmptyEntries)[0].Trim();
            var actual = await ComputeSha256Async(sqlFilePath, ct);
            if (!string.Equals(expected, actual, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Le fichier de sauvegarde est corrompu (empreinte SHA-256 invalide).");
        }

        // Always take a safety snapshot before restoring over the target database.
        await CreateBackupAsync(safetySnapshotDirectory, ct);

        var builder = new MySqlConnectionStringBuilder(connectionString);
        var clientExe = FindTool("mariadb.exe", "mysql.exe");
        var defaultsFile = WriteTempDefaultsFile(builder);
        try
        {
            await RunProcessAsync(clientExe, new[]
            {
                $"--defaults-file={defaultsFile}",
                "--binary-mode",
                builder.Database
            }, sqlFilePath, ct);
        }
        finally
        {
            TryDelete(defaultsFile);
        }
    }

    private string FindTool(params string[] names)
    {
        foreach (var name in names)
        {
            var candidate = Path.Combine(toolsDirectory, name);
            if (File.Exists(candidate)) return candidate;
        }
        return names[0];
    }

    private static string WriteTempDefaultsFile(MySqlConnectionStringBuilder b)
    {
        var path = Path.Combine(Path.GetTempPath(), $"hanouty-my-{Guid.NewGuid():N}.cnf");
        var content = $"[client]\nhost={b.Server}\nport={b.Port}\nuser={b.UserID}\npassword={b.Password}\n";
        File.WriteAllText(path, content, new UTF8Encoding(false));
        return path;
    }

    private static void TryDelete(string path)
    {
        try { if (File.Exists(path)) File.Delete(path); }
        catch (IOException) { }
    }

    private static async Task<string> ComputeSha256Async(string filePath, CancellationToken ct)
    {
        await using var stream = File.OpenRead(filePath);
        var hash = await SHA256.HashDataAsync(stream, ct);
        return Convert.ToHexString(hash).ToLowerInvariant();
    }

    private static async Task RunProcessAsync(string exe, string[] args, string? stdinFile, CancellationToken ct)
    {
        var psi = new ProcessStartInfo(exe)
        {
            UseShellExecute = false,
            RedirectStandardInput = stdinFile is not null,
            RedirectStandardError = true,
            CreateNoWindow = true
        };
        foreach (var a in args) psi.ArgumentList.Add(a);
        using var proc = Process.Start(psi) ?? throw new InvalidOperationException($"Impossible de lancer {exe}.");
        if (stdinFile is not null)
        {
            await using var fs = File.OpenRead(stdinFile);
            await fs.CopyToAsync(proc.StandardInput.BaseStream, ct);
            proc.StandardInput.Close();
        }
        var err = await proc.StandardError.ReadToEndAsync(ct);
        await proc.WaitForExitAsync(ct);
        if (proc.ExitCode != 0)
            throw new InvalidOperationException($"Échec de {Path.GetFileName(exe)} (code {proc.ExitCode}) : {err}");
    }
}
