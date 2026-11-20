using System.Windows;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;
public partial class MainWindow
{
    private Action? _openCustomerFiles;
    private bool _customerFilesOpen;
    public void ConfigureCustomerFiles(Action open) => _openCustomerFiles = open;
    public bool ShowCustomerFiles()
    {
        if (_customerFilesOpen || _manualDiscountOpen || _alternatePaymentOpen || _cashierEntryOpen || _reviewOpen || _logoutOpen || _pinOpen ||
            DataContext is not CatalogueViewModel { FinancialSessionActive: true, CheckoutBusy: false, CheckoutUncertain: false, PendingOperationId: null } ||
            _openCustomerFiles is null) return false;
        _customerFilesOpen = true;
        try { _openCustomerFiles(); return true; }
        finally { _customerFilesOpen = false; }
    }
    private void OpenCustomerFiles_Click(object sender, RoutedEventArgs args) => ShowCustomerFiles();
    public string PromptCustomerFilesApproval(string role)
    {
        if (role is not ("MANAGER" or "ADMIN") || _pinOpen ||
            DataContext is not CatalogueViewModel { FinancialSessionActive: true, CheckoutBusy: false, CheckoutUncertain: false, PendingOperationId: null }) return "";
        return ReadPin("Autorisation des fichiers clients", $"Saisissez le PIN du rôle {role}.");
    }
}
