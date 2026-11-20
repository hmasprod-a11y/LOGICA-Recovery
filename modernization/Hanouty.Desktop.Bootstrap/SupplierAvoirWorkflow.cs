using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class SupplierAvoirWorkflow : IDisposable
{
    private readonly StockIssueValidation service;
    private readonly string actor, recovery;
    private readonly Func<string> readPin;
    private readonly FileStream lease;
    private readonly Action? afterCommit;
    private bool busy, disposed;
    internal StockIssueValidation.AvoirCommand? Pending { get; private set; }
    internal SupplierAvoirWorkflow(StockIssueValidation service, string actor, Func<string> readPin,
        string connectionString, string? directory = null, Action? afterCommit = null)
    {
        this.service = service; this.actor = actor; this.readPin = readPin; this.afterCommit = afterCommit;
        var cs = new MySqlConnectionStringBuilder(connectionString);
        var scope = new MySqlConnectionStringBuilder { Server = cs.Server, Port = cs.Port, Database = cs.Database, UserID = cs.UserID }.ConnectionString;
        var key = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(scope + "|" + actor)));
        directory ??= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HANOUTY", "recovery");
        Directory.CreateDirectory(directory); recovery = Path.Combine(directory, "supplier-avoir-" + key + ".json");
        try { lease = new FileStream(recovery + ".lock", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); }
        catch (IOException ex) { throw new InvalidOperationException("Une création d’avoir est déjà ouverte pour ce poste.", ex); }
        try { if (File.Exists(recovery)) Pending = JsonSerializer.Deserialize<StockIssueValidation.AvoirCommand>(File.ReadAllText(recovery)) ?? throw new InvalidOperationException("Reprise de l’avoir illisible."); }
        catch { lease.Dispose(); throw; }
    }
    internal string Execute(StockIssueValidation.AvoirCommand command)
    {
        ObjectDisposedException.ThrowIf(disposed, this);
        if (busy) throw new InvalidOperationException("Enregistrement de l’avoir en cours.");
        if (Pending is not null && JsonSerializer.Serialize(Pending) != JsonSerializer.Serialize(command)) throw new InvalidOperationException("Vérifiez le même avoir avant de modifier sa demande.");
        var recovering = Pending is not null; busy = true;
        try
        {
            if (Pending is null)
            {
                File.WriteAllText(recovery + ".tmp", JsonSerializer.Serialize(command)); File.Move(recovery + ".tmp", recovery, true); Pending = command;
            }
            var pin = readPin();
            try
            {
                if (string.IsNullOrWhiteSpace(pin)) throw new StockIssueValidation.AvoirWriteRefusedException("Enregistrement annulé avant écriture.", new OperationCanceledException());
                var result = service.CreateAvoir(command, actor, pin, afterCommit);
                File.Delete(recovery); Pending = null; return result;
            }
            catch (StockIssueValidation.AvoirWriteRefusedException ex)
            {
                if (recovering) throw new InvalidOperationException("La création précédente reste à vérifier. " + ex.Message, ex);
                File.Delete(recovery); Pending = null; throw;
            }
            finally { pin = ""; }
        }
        finally { busy = false; }
    }
    public void Dispose() { disposed = true; lease.Dispose(); }
}
