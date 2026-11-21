using System.IO;
using System.Security.Cryptography;
using System.Text.Json;

namespace Hanouty.Desktop.Bootstrap;

internal sealed record ProtectedCatalogueFile(string RelativePath, long Length, string Sha256);
internal static class ProtectedCatalogueFiles
{
    private static string Full(string path) => Path.GetFullPath(path).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
    internal static void CheckPaths(string source, string destination)
    {
        var originalFull = Path.GetFullPath(source);
        if (originalFull.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Equals(
            Path.GetPathRoot(originalFull)!.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar), StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Choisissez le dossier LOGICA, pas le disque entier.");
        source = Full(source); destination = Full(destination);
        if (!Directory.Exists(source) || Directory.Exists(destination) || File.Exists(destination) ||
            destination.Equals(source, StringComparison.OrdinalIgnoreCase) ||
            destination.StartsWith(source + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase) ||
            source.StartsWith(destination + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Choisissez un dossier de données LOGICA distinct de la nouvelle copie.");
        foreach (var path in new[] { source, Path.GetDirectoryName(destination)! })
            for (var current = new DirectoryInfo(path); current is not null; current = current.Parent)
                if (current.Exists && (current.Attributes & FileAttributes.ReparsePoint) != 0)
                    throw new InvalidOperationException("Les dossiers liés ne peuvent pas servir à préparer la copie.");
    }
    private static async Task<List<ProtectedCatalogueFile>> Snapshot(string root, CancellationToken token)
    {
        var result = new List<ProtectedCatalogueFile>(); var pending = new Stack<string>(); pending.Push(root);
        while (pending.Count > 0)
        {
            foreach (var item in Directory.EnumerateFileSystemEntries(pending.Pop()).Order(StringComparer.Ordinal))
            {
                token.ThrowIfCancellationRequested(); var attributes = File.GetAttributes(item);
                if ((attributes & FileAttributes.ReparsePoint) != 0) throw new InvalidOperationException("Un fichier ou dossier lié empêche la copie protégée.");
                if ((attributes & FileAttributes.Directory) != 0) { pending.Push(item); continue; }
                var relative = Path.GetRelativePath(root, item);
                if (Path.IsPathRooted(relative) || relative.StartsWith(".." + Path.DirectorySeparatorChar, StringComparison.Ordinal))
                    throw new InvalidOperationException("Chemin de fichier hors du dossier LOGICA.");
                await using var stream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, FileOptions.Asynchronous | FileOptions.SequentialScan);
                var length = stream.Length; var hash = Convert.ToHexString(await SHA256.HashDataAsync(stream, token));
                result.Add(new(relative, length, hash));
            }
        }
        return result.OrderBy(file => file.RelativePath, StringComparer.Ordinal).ToList();
    }
    internal static async Task<IReadOnlyList<ProtectedCatalogueFile>> CopyAsync(string source, string destination,
        Action<string>? progress = null, CancellationToken cancellationToken = default)
    {
        CheckPaths(source, destination); source = Full(source); destination = Full(destination);
        progress?.Invoke("Vérification des fichiers du catalogue…");
        var before = await Snapshot(source, cancellationToken);
        Directory.CreateDirectory(destination);
        foreach (var file in before)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var from = Path.Combine(source, file.RelativePath); var to = Path.GetFullPath(Path.Combine(destination, file.RelativePath));
            if (!to.StartsWith(destination + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Chemin de copie invalide.");
            Directory.CreateDirectory(Path.GetDirectoryName(to)!);
            await using (var input = new FileStream(from, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, FileOptions.Asynchronous | FileOptions.SequentialScan))
            await using (var output = new FileStream(to, FileMode.CreateNew, FileAccess.Write, FileShare.None, 65536, FileOptions.Asynchronous))
            { await input.CopyToAsync(output, cancellationToken); await output.FlushAsync(cancellationToken); output.Flush(true); }
            await using var copied = new FileStream(to, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, FileOptions.Asynchronous);
            if (copied.Length != file.Length || Convert.ToHexString(await SHA256.HashDataAsync(copied, cancellationToken)) != file.Sha256)
                throw new InvalidOperationException("Un fichier du catalogue a changé pendant la copie. Fermez LOGICA puis recommencez dans une nouvelle copie.");
            progress?.Invoke("Fichier du catalogue copié : " + file.RelativePath);
        }
        var after = await Snapshot(source, cancellationToken);
        if (!before.SequenceEqual(after)) throw new InvalidOperationException("Les fichiers LOGICA ont changé pendant la préparation. Cette copie ne sera pas activée.");
        var manifest = Path.Combine(Path.GetDirectoryName(destination)!, "catalogue-files.json");
        await using (var file = new FileStream(manifest, FileMode.CreateNew, FileAccess.Write, FileShare.None))
        { await JsonSerializer.SerializeAsync(file, before, cancellationToken: cancellationToken); await file.FlushAsync(cancellationToken); file.Flush(true); }
        return before.AsReadOnly();
    }
}
