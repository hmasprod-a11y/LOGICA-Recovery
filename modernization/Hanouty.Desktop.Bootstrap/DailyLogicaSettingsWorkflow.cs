using Hanouty.Desktop.Wpf;

namespace Hanouty.Desktop.Bootstrap;
internal sealed class DailyLogicaSettingsWorkflow(DailyLogicaSettingsStore store, DailyLogicaSettingsStore.Access access,
    Func<bool> active, Func<string> readPin) : IDailyLogicaSettingsWorkflow
{
    public DailyLogicaSettingsChange? Pending { get; private set; }
    private bool busy;
    private void Check() { if (!active()) throw new UnauthorizedAccessException("La session des paramètres a changé."); }
    public DailyLogicaSettingsSnapshot Reload()
    {
        Check(); if (busy) throw new InvalidOperationException("Enregistrement des paramètres en cours.");
        var current = store.Read(access); Pending = null; return current;
    }
    public DailyLogicaSettingsSnapshot Save(DailyLogicaSettingsSnapshot expected, DailyLogicaSettingsValues desired)
    {
        Check(); if (busy) throw new InvalidOperationException("Enregistrement des paramètres en cours.");
        var change = new DailyLogicaSettingsChange(expected, desired); var recovering = Pending is not null;
        if (recovering && Pending != change) throw new InvalidOperationException("Vérifiez la même modification ou relisez les paramètres avant de changer le contenu.");
        busy = true; var pin = "";
        try
        {
            pin = readPin(); Check(); if (string.IsNullOrWhiteSpace(pin)) throw new DailyLogicaSettingsRefusedException("Enregistrement annulé avant écriture.");
            Pending = change;
            var result = store.Save(access, expected, desired, pin); Pending = null; return result;
        }
        catch (DailyLogicaSettingsRefusedException ex)
        {
            if (recovering) throw new InvalidOperationException("La modification précédente reste à vérifier. " + ex.Message, ex);
            Pending = null; throw;
        }
        finally { pin = ""; busy = false; }
    }
}
