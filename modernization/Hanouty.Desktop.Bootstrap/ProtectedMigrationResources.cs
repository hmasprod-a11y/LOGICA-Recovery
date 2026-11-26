using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Hanouty.Desktop.Bootstrap;
internal static class ProtectedMigrationResources
{
    internal static IReadOnlyList<ProtectedCopyMigration> Load()
    {
        const string prefix = "Hanouty.Migrations.";
        var assembly = typeof(ProtectedMigrationResources).Assembly;
        var result = new List<ProtectedCopyMigration>();
        foreach (var name in assembly.GetManifestResourceNames().Where(name => name.StartsWith(prefix, StringComparison.Ordinal)).Order(StringComparer.Ordinal))
        {
            using var stream = assembly.GetManifestResourceStream(name) ?? throw new InvalidOperationException("Migration de préparation absente.");
            using var reader = new StreamReader(stream, Encoding.UTF8, true);
            var sql = reader.ReadToEnd().Replace("\r\n", "\n").Replace("\r", "\n");
            result.Add(new(name[prefix.Length..], sql, Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(sql))).ToLowerInvariant()));
        }
        if (result.Count != 12) throw new InvalidOperationException("Les migrations de préparation ne sont pas complètes.");
        return result.AsReadOnly();
    }
}
