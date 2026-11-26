using System.IO;
using System.Text.Json;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class DailyStockAdjustmentWorkflow : IDisposable
{
    private readonly DailyStockAdjustmentService service;
    private readonly DailyStockAdjustmentService.Authorization authorization;
    private readonly string recovery;
    private readonly FileStream lease;
    private readonly Action? afterCommit;
    private bool busy, disposed;
    internal DailyStockAdjustmentService.Command? Pending { get; private set; }
    internal DailyStockAdjustmentWorkflow(DailyStockAdjustmentService service, DailyStockAdjustmentService.Authorization authorization, string directory, Action? afterCommit = null)
    {
        this.service = service; this.authorization = authorization; this.afterCommit = afterCommit;
        Directory.CreateDirectory(directory); recovery = Path.Combine(directory, "daily-stock-adjustment-" + service.RecoveryScope(authorization) + ".json");
        try { lease = new FileStream(recovery + ".lock", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None); }
        catch (IOException ex) { throw new InvalidOperationException("Un ajustement de stock est déjà ouvert pour cette session.", ex); }
        try { if (File.Exists(recovery)) Pending = JsonSerializer.Deserialize<DailyStockAdjustmentService.Command>(File.ReadAllText(recovery)) ?? throw new InvalidOperationException("La reprise de l’ajustement est illisible."); }
        catch { lease.Dispose(); throw; }
    }
    internal DailyStockAdjustmentService.Result Execute(DailyStockAdjustmentService.Command command)
    {
        ObjectDisposedException.ThrowIf(disposed, this);
        if (busy) throw new InvalidOperationException("Enregistrement du stock en cours.");
        if (Pending is not null && Pending != command) throw new InvalidOperationException("Vérifiez le même ajustement avant de changer sa quantité.");
        var recovering = Pending is not null; busy = true;
        try
        {
            if (Pending is null)
            {
                File.WriteAllText(recovery + ".tmp", JsonSerializer.Serialize(command)); File.Move(recovery + ".tmp", recovery, true); Pending = command;
            }
            try
            {
                var result = service.Execute(authorization, command, afterCommit);
                File.Delete(recovery); Pending = null; return result;
            }
            catch (DailyStockAdjustmentService.RefusedException ex)
            {
                if (recovering) throw new InvalidOperationException("Le résultat précédent reste à vérifier. " + ex.Message, ex);
                File.Delete(recovery); Pending = null; throw;
            }
        }
        finally { busy = false; }
    }
    public void Dispose() { disposed = true; lease.Dispose(); }
}
