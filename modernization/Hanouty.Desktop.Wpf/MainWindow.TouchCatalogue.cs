using System.Windows;
using System.Windows.Threading;
using Hanouty.Desktop.Wpf.Presentation;

namespace Hanouty.Desktop.Wpf;
public partial class MainWindow
{
    // Form_3_VENTE.B_article2_click restores Text_CODE focus after a tile.
    // Run after the bound selection command, so the next physical scan goes
    // to the scanner field rather than the last product button.
    private void TouchProduct_Click(object sender, RoutedEventArgs e) =>
        Dispatcher.BeginInvoke(DispatcherPriority.Input, new Action(() =>
        {
            if (IsActive && DataContext is CatalogueViewModel { CanSelectProduct: true }) ScannerInput.Focus();
        }));
}
