namespace Hanouty.Desktop.Wpf;

public partial class MainWindow
{
    private Func<string, bool>? _pinLogin;
    public void ConfigurePinLogin(Func<string, bool> authenticate) => _pinLogin = authenticate;
    public void SetLoginFeedback(string message)
    {
        var identity = ReadSessionIdentity();
        CashierSessionLabel.Text = (identity is null ? "Session fermée" : $"Caisse {identity.RegisterId} · {identity.CashierId}") + " · " + message;
        CashierSessionLabel.ToolTip = message;
    }
    private bool SignInWithPin()
    {
        _entryPinCashier = "";
        var pin = "";
        try
        {
            pin = ReadPin("Connexion à la caisse", "Saisissez votre code d’accès.", "");
            return pin.Length != 0 && _pinLogin?.Invoke(pin) == true;
        }
        finally { pin = ""; _entryPinCashier = null; }
    }
}
