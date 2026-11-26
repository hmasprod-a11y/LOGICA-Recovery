using System.Runtime.InteropServices;
using System.Security;

namespace Hanouty.Desktop.Bootstrap;

// LOGICA authenticates at entry. Keep that credential in this workstation's
// memory only; existing SQL writers still verify the current password/role on
// every operation. Never persist it or put it in a view model or log.
internal sealed class CashierSessionCredentials : IDisposable
{
    private SecureString? secret;
    private string? actor;
    private string? sessionId;
    internal void Bind(string cashier, string pin)
    {
        if (string.IsNullOrWhiteSpace(cashier) || string.IsNullOrWhiteSpace(pin)) throw new UnauthorizedAccessException("Session caissier indisponible.");
        var next = new SecureString(); foreach (var character in pin) next.AppendChar(character); next.MakeReadOnly();
        Clear(); actor = cashier; secret = next; sessionId = Guid.NewGuid().ToString("N");
    }
    internal string Read(string? expectedActor = null)
    {
        if (secret is null || actor is null || expectedActor is not null && expectedActor != actor)
            throw new UnauthorizedAccessException("Ouvrez une session caissier.");
        var pointer = Marshal.SecureStringToBSTR(secret);
        try { return Marshal.PtrToStringBSTR(pointer); }
        finally { Marshal.ZeroFreeBSTR(pointer); }
    }
    internal Hanouty.ArchitectureBridge.VerifiedStockActor? VerifiedActor => secret is not null && actor is not null && sessionId is not null
        ? new(sessionId, actor) : null;
    internal void Clear() { secret?.Dispose(); secret = null; actor = null; sessionId = null; }
    public void Dispose() => Clear();
}
