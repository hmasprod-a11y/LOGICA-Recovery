using System.Windows;
using System.Windows.Controls;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;
public partial class MainWindow
{
    private string _returnPaymentMode = "Cash";
    private Func<string, bool>? _changeReturnMode;
    private bool _settingReturnMode;
    public void ConfigureReturnPaymentMode(Func<string, bool> change) => _changeReturnMode = change;
    public bool SetReturnPaymentMode(string mode)
    {
        if (mode is not ("Cash" or "Credit" or "Card") || _businessDocumentsOpen || _customerFilesOpen || _manualDiscountOpen ||
            _cashierEntryOpen || _alternatePaymentOpen || _reviewOpen || _logoutOpen || _pinOpen || _originalSaleLookupBusy ||
            DataContext is not CatalogueViewModel { FinancialSessionActive: true, CheckoutBusy: false, CheckoutUncertain: false, PendingOperationId: null } ||
            _changeReturnMode?.Invoke(mode) != true) return false;
        _returnPaymentMode = mode;
        OriginalSaleSearch_TextChanged(this, null!);
        ConfirmFullReturnButton.Content = mode == "Credit" ? "Confirmer le retour crédit" : mode == "Card" ? "Confirmer le remboursement CARTE" : "Rembourser le ticket en espèces";
        _settingReturnMode = true;
        try { ReturnPaymentMode.SelectedIndex = mode == "Cash" ? 0 : mode == "Credit" ? 1 : 2; }
        finally { _settingReturnMode = false; }
        return true;
    }
    private void ReturnPaymentMode_SelectionChanged(object sender, SelectionChangedEventArgs args)
    {
        if (_settingReturnMode || _changeReturnMode is null) return;
        var mode = (ReturnPaymentMode.SelectedItem as ComboBoxItem)?.Tag as string;
        if (mode is null || SetReturnPaymentMode(mode)) return;
        _settingReturnMode = true;
        try { ReturnPaymentMode.SelectedIndex = _returnPaymentMode == "Cash" ? 0 : _returnPaymentMode == "Credit" ? 1 : 2; }
        finally { _settingReturnMode = false; }
    }
}
