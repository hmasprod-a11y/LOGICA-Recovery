using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;
internal sealed record ProtectedCopyMigration(string Name, string Sql, string Sha256);
internal sealed record ProtectedCopyCredentials(string User, SecureString Password);
internal sealed record ProtectedLocalCopyRequest(string Host, uint Port, string SourceDatabase, string DestinationDatabase,
    string NewDataDirectory, string MariaDbBinDirectory, ProtectedCopyCredentials Source, ProtectedCopyCredentials Destination,
    IReadOnlyList<ProtectedCopyMigration> Migrations, string Workstation = "01");
internal sealed record ProtectedCopyProgress(string Stage, string Message);
internal sealed record ProtectedLocalCopyResult(bool Ready, string Database, string DataDirectory, string BackupFile,
    string BackupSha256, string JournalFile, bool SourceUnchanged);
internal sealed class ProtectedLocalCopyException(string message, string journalFile) : Exception(message)
{ public string JournalFile { get; } = journalFile; }

internal sealed class ProtectedLocalCopyService
{
    private static readonly IReadOnlyDictionary<string,string> AcceptedMigrations = new Dictionary<string,string>(StringComparer.Ordinal) {
        ["20261102-article-add-compatibility.sql"] = "da092bc6946b1599868b5ad6207e834828781c46887d8dfdc3938e556e678c2d",
        ["20261113-purchase-receipt-order.sql"] = "cf9af6d7c8df7e135f7b7335bf761754a5e00ba30e494559778eb8c48d70b6e0",
        ["20261114-catalogue-price-audit.sql"] = "2860f0d276b1780cb3c3d230f87eb1915fc5171cb3639ed7b6ae0cd8eb901bfc",
        ["20261114-purchase-receipt-multiple-lines.sql"] = "e830bf931ad02beb4db814904d3bd6006ea1c86329a4cf89d67078a1908239d6",
        ["20261117-stock-issue-history.sql"] = "f14fb3c9147f31d029b287d1b00c801e79e4c5c93fa9426970dd93db739d4be8",
        ["20261118-client-settlement-operations.sql"] = "b3f412aa2033a748d06cfd11a13953326d70b6f0538b24574d1c6a373e1e0712",
        ["20261118-supplier-settlement-operations.sql"] = "d19100ab496d716eeb890d3ef1376c2ccaf129d23700c73a21ee3aef2c531c8a",
        ["20261120-customer-file-operations.sql"] = "5c76edb83b7b6b6f83b8b64416e52dc985a7a3e92bfee387101f8efcd994dd90",
        ["20261120-partial-cash-return-consumption.sql"] = "ed6e6d2f920016d9729756764b2782dc8133791d9a813943dc4f1580940b09b6",
        ["20261120-stock-issue-create-operations.sql"] = "2a3da4bccf7e086dbf9cf3b37a7bd3501e29e5226d4e1cd193e6054ab6bfe0a6",
        ["20261121-checkout-and-full-return-journals.sql"] = "a86d03070c01fe7bec9c8527264ab68275631b0c4c919b7aa54672ba71245dc6",
    };
    private readonly Action<string>? checkpoint;
    internal ProtectedLocalCopyService(Action<string>? checkpoint = null) => this.checkpoint = checkpoint;
    private static string Quote(string value) => "`" + value.Replace("`", "``") + "`";
    private static string Hash(byte[] value) => Convert.ToHexString(SHA256.HashData(value)).ToLowerInvariant();
    private static string Reveal(SecureString value)
    { var p = Marshal.SecureStringToBSTR(value); try { return Marshal.PtrToStringBSTR(p); } finally { Marshal.ZeroFreeBSTR(p); } }
    private static MySqlConnection Connect(ProtectedLocalCopyRequest r, ProtectedCopyCredentials credential, string database)
    {
        var cs = new MySqlConnectionStringBuilder { Server = r.Host, Port = r.Port, UserID = credential.User,
            Password = Reveal(credential.Password), Database = database, CharacterSet = "utf8mb4", Pooling = false,
            AllowUserVariables = false, AllowLoadLocalInfile = false, ConnectionTimeout = 15, DefaultCommandTimeout = 120 };
        var db = new MySqlConnection(cs.ConnectionString); db.Open(); return db;
    }
    private static object? Scalar(MySqlConnection db, string sql)
    { using var cmd = new MySqlCommand(sql, db); return cmd.ExecuteScalar(); }
    private static void Execute(MySqlConnection db, string sql)
    { using var cmd = new MySqlCommand(sql, db); cmd.CommandTimeout = 300; cmd.ExecuteNonQuery(); }
    [StructLayout(LayoutKind.Sequential)]
    private struct SecurityAttributes { public int Length; public IntPtr Descriptor; [MarshalAs(UnmanagedType.Bool)] public bool Inherit; }
    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool CreateDirectoryW(string path, ref SecurityAttributes attributes);
    private static void PrivateDirectory(string path)
    {
        if (!Directory.Exists(Path.GetDirectoryName(path))) throw new InvalidOperationException("Le dossier parent doit déjà exister.");
        var security = new DirectorySecurity(); security.SetAccessRuleProtection(true, false);
        security.AddAccessRule(new FileSystemAccessRule(WindowsIdentity.GetCurrent().User!, FileSystemRights.FullControl,
            InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
        var bytes = security.GetSecurityDescriptorBinaryForm(); var pinned = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        try {
            var attributes = new SecurityAttributes { Length = Marshal.SizeOf<SecurityAttributes>(), Descriptor = pinned.AddrOfPinnedObject() };
            if (!CreateDirectoryW(path, ref attributes)) throw new InvalidOperationException("Création privée refusée ; aucun dossier existant ne sera réutilisé.");
        } finally { pinned.Free(); }
    }
    private static async Task<string> HashFile(string path, CancellationToken token)
    {
        await using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, true);
        return Convert.ToHexString(await SHA256.HashDataAsync(stream, token)).ToLowerInvariant();
    }
    private static string Defaults(string folder, string name, ProtectedLocalCopyRequest r, ProtectedCopyCredentials credentials)
    {
        static string Escape(string value)
        {
            if (value.Any(c => c == '\0' || c == '\r' || c == '\n')) throw new InvalidOperationException("Identifiants locaux invalides.");
            return "\"" + value.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
        }
        var file = Path.Combine(folder, name + ".cnf");
        using var stream = new FileStream(file, FileMode.CreateNew, FileAccess.Write, FileShare.None);
        using var writer = new StreamWriter(stream, new UTF8Encoding(false));
        writer.Write("[client]\nprotocol=tcp\nhost=" + Escape(r.Host) + "\nport=" + r.Port + "\nuser=" + Escape(credentials.User) +
            "\npassword=" + Escape(Reveal(credentials.Password)) + "\ndefault-character-set=utf8mb4\n");
        return file;
    }
    private static async Task Run(string executable, IEnumerable<string> arguments, string? input, CancellationToken token)
    {
        var start = new ProcessStartInfo(executable) { UseShellExecute = false, CreateNoWindow = true,
            RedirectStandardError = true, RedirectStandardOutput = true, RedirectStandardInput = input != null };
        foreach (var arg in arguments) start.ArgumentList.Add(arg);
        using var process = Process.Start(start) ?? throw new InvalidOperationException("Outil MariaDB indisponible.");
        var error = process.StandardError.ReadToEndAsync(token); var output = process.StandardOutput.ReadToEndAsync(token);
        try
        {
            if (input != null) { await using var file = File.OpenRead(input); await file.CopyToAsync(process.StandardInput.BaseStream, token); process.StandardInput.Close(); }
            await process.WaitForExitAsync(token); await error; await output;
            if (process.ExitCode != 0) throw new InvalidOperationException("Échec de l'outil MariaDB (code " + process.ExitCode + ").");
        }
        catch { if (!process.HasExited) process.Kill(true); throw; }
    }
    private sealed record Table(string Name, string[] Columns, string Ddl);
    private static List<Table> Describe(MySqlConnection db, string schema)
    {
        using var objects = new MySqlCommand("SELECT (SELECT COUNT(*) FROM information_schema.VIEWS WHERE TABLE_SCHEMA=@s)+(SELECT COUNT(*) FROM information_schema.TRIGGERS WHERE TRIGGER_SCHEMA=@s)+(SELECT COUNT(*) FROM information_schema.ROUTINES WHERE ROUTINE_SCHEMA=@s)+(SELECT COUNT(*) FROM information_schema.EVENTS WHERE EVENT_SCHEMA=@s)", db);
        objects.Parameters.AddWithValue("@s", schema);
        if (Convert.ToInt64(objects.ExecuteScalar()) != 0) throw new InvalidOperationException("Vues, déclencheurs ou programmes SQL : préparation non prise en charge.");
        var names = new List<string>();
        using (var cmd = new MySqlCommand("SELECT TABLE_NAME,ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=@s ORDER BY BINARY TABLE_NAME", db))
        {
            cmd.Parameters.AddWithValue("@s", schema); using var reader = cmd.ExecuteReader();
            while (reader.Read()) { if (!string.Equals(reader.GetString(1), "InnoDB", StringComparison.Ordinal)) throw new InvalidOperationException("Toutes les tables source doivent être InnoDB."); names.Add(reader.GetString(0)); }
        }
        var result = new List<Table>();
        foreach (var name in names)
        {
            var columns = new List<string>();
            using (var cmd = new MySqlCommand("SELECT COLUMN_NAME,EXTRA FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=@s AND TABLE_NAME=@t ORDER BY ORDINAL_POSITION", db))
            {
                cmd.Parameters.AddWithValue("@s", schema); cmd.Parameters.AddWithValue("@t", name); using var reader = cmd.ExecuteReader();
                while (reader.Read()) { if (reader.GetString(1).Contains("GENERATED", StringComparison.OrdinalIgnoreCase)) throw new InvalidOperationException("Colonne calculée non prise en charge."); columns.Add(reader.GetString(0)); }
            }
            using var ddl = new MySqlCommand("SHOW CREATE TABLE " + Quote(name), db); using var dr = ddl.ExecuteReader(); dr.Read();
            result.Add(new(name, columns.ToArray(), dr.GetString(1)));
        }
        using var foreign = new MySqlCommand("SELECT COUNT(*) FROM information_schema.KEY_COLUMN_USAGE WHERE TABLE_SCHEMA=@s AND REFERENCED_TABLE_SCHEMA IS NOT NULL AND REFERENCED_TABLE_SCHEMA<>@s", db);
        foreign.Parameters.AddWithValue("@s", schema);
        if (Convert.ToInt64(foreign.ExecuteScalar()) != 0) throw new InvalidOperationException("Relation vers une autre base non prise en charge.");
        return result;
    }
    private static string Fingerprint(MySqlConnection db, IReadOnlyList<Table> tables, bool ddl)
    {
        using var digest = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
        foreach (var table in tables)
        {
            digest.AppendData(Encoding.UTF8.GetBytes(table.Name + "\n" + (ddl ? table.Ddl : "") + "\n"));
            var expression = "CONCAT(" + string.Join(",'|',", table.Columns.Select(c => "IF(" + Quote(c) + " IS NULL,'N',CONCAT('V',HEX(CAST(" + Quote(c) + " AS BINARY))))")) + ")";
            using var cmd = new MySqlCommand("SELECT " + expression + " AS row_bytes FROM " + Quote(table.Name) + " ORDER BY BINARY row_bytes", db);
            cmd.CommandTimeout = 300; using var reader = cmd.ExecuteReader();
            while (reader.Read()) { digest.AppendData(Encoding.UTF8.GetBytes(reader.GetString(0))); digest.AppendData(new byte[] { 10 }); }
        }
        return Convert.ToHexString(digest.GetHashAndReset()).ToLowerInvariant();
    }
    public async Task<ProtectedLocalCopyResult> PrepareAsync(ProtectedLocalCopyRequest r, IProgress<ProtectedCopyProgress>? progress = null, CancellationToken cancellationToken = default)
    {
        string journal = "", sourceDefaults = "", destinationDefaults = "";
        void Log(string stage, string message) { progress?.Report(new(stage, message)); if (journal.Length != 0) File.AppendAllText(journal, JsonSerializer.Serialize(new { utc = DateTime.UtcNow, stage, message }) + "\n"); checkpoint?.Invoke(stage); }
        try
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (r.Host is not ("127.0.0.1" or "localhost" or "::1") || r.Port is 0 or > 65535 || !Regex.IsMatch(r.SourceDatabase, @"\A[A-Za-z0-9_]{1,64}\z") ||
                !Regex.IsMatch(r.DestinationDatabase, @"\Ahanouty_[a-z0-9_]{1,54}\z") || string.Equals(r.SourceDatabase, r.DestinationDatabase, StringComparison.OrdinalIgnoreCase) ||
                new[] { "mysql", "sys", "information_schema", "performance_schema" }.Contains(r.SourceDatabase, StringComparer.OrdinalIgnoreCase)) throw new InvalidOperationException("Source locale et nouveau nom hanouty_ distinct requis.");
            if (r.NewDataDirectory.Split(new[] { '\\', '/' }).Any(segment => segment is ".." or ".") || r.NewDataDirectory.Skip(2).Contains(':') ) throw new InvalidOperationException("Chemin de dossier non canonique refusé.");
            var folder = Path.GetFullPath(r.NewDataDirectory);
            if (!Path.IsPathFullyQualified(r.NewDataDirectory) || folder.StartsWith("\\\\") || Directory.Exists(folder) || File.Exists(folder)) throw new InvalidOperationException("Choisissez un nouveau dossier local vide.");
            for (var ancestor = new DirectoryInfo(folder).Parent; ancestor != null; ancestor = ancestor.Parent)
                if (ancestor.Exists && (ancestor.Attributes & FileAttributes.ReparsePoint) != 0) throw new InvalidOperationException("Les liens et redirections de dossier sont refusés.");
            var dump = Path.Combine(Path.GetFullPath(r.MariaDbBinDirectory), "mariadb-dump.exe"); var client = Path.Combine(Path.GetFullPath(r.MariaDbBinDirectory), "mariadb.exe");
            if (!File.Exists(dump) || !File.Exists(client)) throw new InvalidOperationException("Les outils MariaDB officiels doivent être sélectionnés.");
            if (r.Migrations.Count != 11 || r.Migrations.Select(m => m.Name).Distinct(StringComparer.Ordinal).Count() != 11) throw new InvalidOperationException("Les onze migrations livrées sont requises.");
            foreach (var m in r.Migrations)
                if (!AcceptedMigrations.TryGetValue(m.Name, out var acceptedHash) || !string.Equals(acceptedHash, m.Sha256, StringComparison.OrdinalIgnoreCase) || !string.Equals(Hash(Encoding.UTF8.GetBytes(m.Sql.Replace("\r\n", "\n"))), m.Sha256, StringComparison.OrdinalIgnoreCase)) throw new InvalidOperationException("Migration absente ou empreinte invalide.");
            using var source = Connect(r, r.Source, r.SourceDatabase); Execute(source, "SET SESSION TRANSACTION READ ONLY");
            var tables = Describe(source, r.SourceDatabase); ValidateOriginal(source, tables, r.Workstation);
            var before = Fingerprint(source, tables, true); var rows = Fingerprint(source, tables, false);
            using var destination = Connect(r, r.Destination, "");
            using (var exists = new MySqlCommand("SELECT COUNT(*) FROM information_schema.SCHEMATA WHERE SCHEMA_NAME=@s", destination))
            { exists.Parameters.AddWithValue("@s", r.DestinationDatabase); if (Convert.ToInt64(exists.ExecuteScalar()) != 0) throw new InvalidOperationException("La destination existe déjà : aucune réutilisation permise."); }
            PrivateDirectory(folder); journal = Path.Combine(folder, "preparation.jsonl");
            Log("source-verified", "LOGICA doit rester fermé ; source vérifiée en lecture seule.");
            sourceDefaults = Defaults(folder, "source-private", r, r.Source); destinationDefaults = Defaults(folder, "destination-private", r, r.Destination);
            var backup = Path.Combine(folder, "original-backup.sql");
            await Run(dump, new[] { "--defaults-file=" + sourceDefaults, "--single-transaction", "--skip-lock-tables", "--skip-add-locks", "--skip-add-drop-table", "--skip-disable-keys", "--skip-comments", "--skip-triggers", "--skip-events", "--skip-routines", "--hex-blob", "--no-tablespaces", "--result-file=" + backup, r.SourceDatabase }, null, cancellationToken);
            var backupHash = await HashFile(backup, cancellationToken); Log("backup-verified", backupHash);
            Execute(destination, "CREATE DATABASE " + Quote(r.DestinationDatabase) + " CHARACTER SET utf8mb4 COLLATE utf8mb4_bin"); Log("destination-created", "Nouvelle copie uniquement ; les DDL ne sont pas transactionnels.");
            await Run(client, new[] { "--defaults-file=" + destinationDefaults, "--binary-mode", r.DestinationDatabase }, backup, cancellationToken);
            destination.ChangeDatabase(r.DestinationDatabase);
            if (Fingerprint(destination, tables, false) != rows) throw new InvalidOperationException("La copie ne correspond pas à la sauvegarde source.");
            Log("import-verified", "Toutes les lignes originales sont identiques.");
            foreach (var migration in r.Migrations.OrderBy(m => m.Name, StringComparer.Ordinal))
            { cancellationToken.ThrowIfCancellationRequested(); Log("migration-start", migration.Name + " " + migration.Sha256 + " DDL non transactionnel"); Execute(destination, migration.Sql); Log("migration-complete", migration.Name); }
            ValidatePrepared(destination, r.Workstation); ProtectedCopySchemaValidation.Validate(destination);
            if (await HashFile(backup, cancellationToken) != backupHash) throw new InvalidOperationException("La sauvegarde a changé pendant la préparation.");
            if (Fingerprint(destination, tables, false) != rows) throw new InvalidOperationException("Une migration a modifié les données originales.");
            using var freshSource = Connect(r, r.Source, r.SourceDatabase); Execute(freshSource, "SET SESSION TRANSACTION READ ONLY");
            if (Fingerprint(freshSource, Describe(freshSource, r.SourceDatabase), true) != before) throw new InvalidOperationException("La source a changé : fermez LOGICA et recommencez dans une nouvelle destination.");
            Log("ready", "Copie validée ; source inchangée. Aucun profil magasin modifié.");
            return new(true, r.DestinationDatabase, folder, backup, backupHash, journal, true);
        }
        catch (Exception e)
        {
            if (journal.Length != 0) File.AppendAllText(journal, JsonSerializer.Serialize(new { utc = DateTime.UtcNow, stage = "refused", message = "Copie non activable ; source jamais modifiée par ce service." }) + "\n");
            throw new ProtectedLocalCopyException(e is InvalidOperationException or OperationCanceledException ? e.Message : "Préparation refusée. La copie incomplète reste isolée ; aucune activation.", journal);
        }
        finally { if (sourceDefaults.Length != 0) File.Delete(sourceDefaults); if (destinationDefaults.Length != 0) File.Delete(destinationDefaults); }
    }
    private static void ValidateOriginal(MySqlConnection db, List<Table> tables, string workstation)
    {
        if (workstation != "01") throw new InvalidOperationException("Poste invalide.");
        var required = new Dictionary<string, string[]> {
            ["TABLE_PASS"] = ["ListUser", "ListPass", "Catégorie"], ["TABLE_NUM"] = ["ID", "CL", "CLIENT", "INV", "BC", "BR", "BS"],
            ["TABLE_ARTICLES"] = ["ID_ARTICLE", "Code", "Article", "PRIX_A", "PRIX_MP", "PRIX_V_1", "STOCK"],
            ["TABLE_PARAMETRES"] = ["OBJET", "VALEUR"], ["TABLE_MODE_P"] = ["MODE_P"],
            ["TABLE_VENTES_ENTETE"] = ["ID_TICKET", "TICKET", "DATES", "CAISSIER", "Total_NET", "OPERATION"],
            ["TABLE_VENTES_JOURNAL"] = ["ID_TICKET", "ID_ARTICLE", "Qté", "PRIX_V", "Remise", "Total_NET", "OPERATION"],
            ["TABLE_VENTES_REGLEMENTS"] = ["ID_TICKET", "MONTANT", "MODE_P", "OPERATION"],
            ["TABLE_MOUVEMENTS_STOCK"] = ["DATES", "ID_ARTICLE", "QUANTITE"],
            ["TABLE_CLIENTS"] = ["ID_CLIENT", "CODE_CLIENT", "CLIENT", "CREDIT_INITIAL"],
            ["TABLE_FOURNISSEURS"] = ["ID_FOURNISSEUR", "CODE_FOURNISSEUR", "FOURNISSEUR", "CREDIT_INITIAL"],
            ["TABLE_CLIENTS_REGLE"] = ["ID_REGLE", "ID_CLIENT", "MONTANT", "MODE_P"],
            ["TABLE_FOURNISSEURS_REGLE"] = ["ID_REGLE", "ID_FOURNISSEUR", "MONTANT", "MODE_P"],
            ["TABLE_INVENTAIRES_ENTETE"] = ["ID_INV", "ETAT"], ["TABLE_INVENTAIRES_DETAILS"] = ["ID_INV", "ID_ARTICLE", "STOCK_PHYSIQUE"],
            ["TABLE_COMMANDES_ENTETE"] = ["ID_BC", "ETAT"], ["TABLE_COMMANDES_DETAILS"] = ["ID_BC", "ID_ARTICLE", "Qté"],
            ["TABLE_RECEPTIONS_ENTETE"] = ["ID_BR", "ETAT"], ["TABLE_RECEPTIONS_DETAILS"] = ["ID_BR", "ID_ARTICLE", "Qté"],
            ["TABLE_SORTIES_ENTETE"] = ["ID_BS", "ETAT"], ["TABLE_SORTIES_DETAILS"] = ["ID_BS", "ID_ARTICLE", "Qté"],
            ["TABLE_DEPENSES"] = ["ID", "DATES", "MONTANT"], ["TABLE_" + workstation] = ["ID_ARTICLE", "Qté", "PRIX_V", "Remise", "TOTAL_NET"] };
        foreach (var pair in required)
        { var table = tables.SingleOrDefault(t => string.Equals(t.Name, pair.Key, StringComparison.OrdinalIgnoreCase)); if (table == null || pair.Value.Any(c => !table.Columns.Contains(c, StringComparer.OrdinalIgnoreCase))) throw new InvalidOperationException("Schéma LOGICA incompatible : " + pair.Key); }
        foreach (var target in new[] { ("TABLE_ARTICLES", "STOCK"), ("TABLE_ARTICLES", "PRIX_V_1"), ("TABLE_ARTICLES", "PRIX_A"), ("TABLE_ARTICLES", "PRIX_MP"), ("TABLE_VENTES_JOURNAL", "Qté"), ("TABLE_VENTES_JOURNAL", "Remise"), ("TABLE_VENTES_JOURNAL", "Total_NET"), ("TABLE_VENTES_REGLEMENTS", "MONTANT"), ("TABLE_CLIENTS", "CREDIT_INITIAL"), ("TABLE_FOURNISSEURS", "CREDIT_INITIAL") })
        {
            using var field = new MySqlCommand("SELECT DATA_TYPE FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@t AND COLUMN_NAME=@c", db);
            field.Parameters.AddWithValue("@t", target.Item1); field.Parameters.AddWithValue("@c", target.Item2);
            if (Convert.ToString(field.ExecuteScalar()) is not ("decimal" or "double" or "float" or "int" or "bigint" or "smallint" or "mediumint" or "tinyint")) throw new InvalidOperationException("Champ numérique LOGICA incompatible : " + target.Item1 + "." + target.Item2);
        }
        if (Convert.ToInt64(Scalar(db, "SELECT COUNT(*) FROM TABLE_NUM")) != 1 || Convert.ToInt64(Scalar(db, "SELECT COUNT(*) FROM TABLE_NUM WHERE ID=0 AND CL>=0 AND CL<999999 AND CLIENT>=0 AND INV>=0 AND BC>=0 AND BR>=0 AND BS>=0")) != 1) throw new InvalidOperationException("Compteurs LOGICA incompatibles : singleton ID=0 et compteurs positifs requis.");
        if (Convert.ToInt64(Scalar(db, "SELECT COUNT(*) FROM " + Quote("TABLE_" + workstation))) != 0) throw new InvalidOperationException("Le panier LOGICA contient une opération non terminée. Terminez-la dans LOGICA.");
    }
    private static void ValidatePrepared(MySqlConnection db, string workstation)
    {
        var tables = Describe(db, db.Database); ValidateOriginal(db, tables, workstation);
        foreach (var name in new[] { "hanouty_checkout_operations", "hanouty_cash_return_consumption", "hanouty_return_line_consumption", "hanouty_purchase_receipt_order", "hanouty_catalogue_price_audit", "hanouty_stock_issue_history", "hanouty_client_settlement_operations", "hanouty_supplier_settlement_operations", "hanouty_customer_file_operations", "hanouty_stock_issue_create_operations" })
            if (!tables.Any(t => string.Equals(t.Name, name, StringComparison.OrdinalIgnoreCase))) throw new InvalidOperationException("Journal de sécurité manquant : " + name);
    }
}









