using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CustomerFilesWorkflow : ICustomerFilesWorkflow
{
    private readonly CustomerFileStore store;
    private readonly CustomerFileStore.Access access;
    private readonly Func<bool> active;
    private readonly Func<string> readPin;
    private readonly string recovery;
    private readonly FileStream lease;
    private bool busy, disposed;
    public CustomerFileCommand? Pending { get; private set; }
    internal CustomerFilesWorkflow(CustomerFileStore store, CustomerFileStore.Access access,
        string connectionString, string register, string directory, Func<bool> active, Func<string> readPin)
    {
        this.store = store; this.access = access; this.active = active; this.readPin = readPin;
        var cs = new MySqlConnectionStringBuilder(connectionString);
        var scope = new MySqlConnectionStringBuilder { Server = cs.Server, Port = cs.Port, Database = cs.Database, UserID = cs.UserID }.ConnectionString;
        var name = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(scope + "|" + access.Actor + "|" + register)));
        Directory.CreateDirectory(directory); recovery = Path.Combine(directory, "customer-file-pending-" + name + ".json");
        try { lease = new FileStream(recovery + ".lock", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); }
        catch (IOException ex) { throw new InvalidOperationException("Les fichiers clients sont déjà ouverts sur ce poste.", ex); }
        try
        {
            if (File.Exists(recovery)) Pending = JsonSerializer.Deserialize<CustomerFileCommand>(File.ReadAllText(recovery))
                ?? throw new InvalidOperationException("Reprise du fichier client illisible.");
        }
        catch { lease.Dispose(); throw; }
    }
    private void Check()
    { if (disposed || !active()) throw new InvalidOperationException("La session du fichier client a changé."); }
    public IReadOnlyList<CustomerFile> Search(string query) { Check(); if (Pending is not null) throw new InvalidOperationException("Vérifiez d’abord l’enregistrement en cours."); return store.Search(access, query); }
    public IReadOnlyList<CustomerOpeningHistory> History(string id) { Check(); if (Pending is not null) throw new InvalidOperationException("Vérifiez d’abord l’enregistrement en cours."); return store.History(access, id); }
    public IReadOnlyList<string> Sellers() { Check(); return store.Sellers(access); }
    public CustomerFile Execute(CustomerFileCommand command)
    {
        Check(); if (busy) throw new InvalidOperationException("Enregistrement client en cours.");
        if (Pending is not null && Pending != command) throw new InvalidOperationException("Vérifiez la modification précédente avant d’en changer le contenu.");
        var recovering = Pending is not null;
        busy = true;
        try
        {
            if (Pending is null)
            {
                var temp = recovery + ".tmp"; File.WriteAllText(temp, JsonSerializer.Serialize(command)); File.Move(temp, recovery, true); Pending = command;
            }
            var pin = readPin();
            try
            {
                Check();
                if (string.IsNullOrWhiteSpace(pin)) throw new CustomerFileWriteRefusedException("Enregistrement annulé avant écriture.");
                var result = store.Execute(access, command, pin);
                File.Delete(recovery); Pending = null; return result;
            }
            catch (CustomerFileWriteRefusedException ex)
            {
                // A refused retry cannot prove that an earlier lost acknowledgement
                // did not commit. Keep its immutable request until durable replay.
                if (recovering) throw new InvalidOperationException("La reprise reste à vérifier. " + ex.Message, ex);
                File.Delete(recovery); Pending = null; throw;
            }
            finally { pin = ""; }
        }
        finally { busy = false; }
    }
    public void Dispose() { disposed = true; lease.Dispose(); }
}
