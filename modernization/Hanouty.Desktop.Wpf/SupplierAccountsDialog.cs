using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Hanouty.Desktop.Wpf;

public sealed record SupplierSettlementRow(string SupplierId, string Supplier, decimal Opening,
    decimal Receipts, decimal Outgoing, decimal Payments, decimal Balance);

public sealed class SupplierAccountsDialog : Window
{
    public SupplierAccountsDialog(Func<IReadOnlyList<SupplierSettlementRow>> read,
        IReadOnlyList<string> paymentModes, Func<SupplierSettlementRequest, bool> submit)
    {
        Title = "Comptes et règlements fournisseurs";
        Width = 940;
        Height = 540;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(16) };
        var grid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false };
        foreach (var (label, property) in new[] {
            ("Fournisseur", nameof(SupplierSettlementRow.Supplier)),
            ("Crédit initial", nameof(SupplierSettlementRow.Opening)),
            ("Réceptions", nameof(SupplierSettlementRow.Receipts)),
            ("Sorties signées", nameof(SupplierSettlementRow.Outgoing)),
            ("Règlements", nameof(SupplierSettlementRow.Payments)),
            ("Solde", nameof(SupplierSettlementRow.Balance)) })
            grid.Columns.Add(new DataGridTextColumn { Header = label,
                Binding = new Binding(property) { StringFormat = property == nameof(SupplierSettlementRow.Supplier) ? null : "N2" } });
        var feedback = new TextBlock { TextWrapping = TextWrapping.Wrap };
        DockPanel.SetDock(feedback, Dock.Bottom);
        panel.Children.Add(feedback);
        var actions = new StackPanel { Orientation = Orientation.Horizontal };
        var refresh = new Button { Content = "Actualiser", MinHeight = 40, MinWidth = 100 };
        var settle = new Button { Content = "Régler le fournisseur sélectionné", MinHeight = 40,
            Margin = new Thickness(8, 0, 0, 8), IsEnabled = false };
        void Reload()
        {
            grid.ItemsSource = null;
            try { grid.ItemsSource = read(); feedback.Text = ""; }
            catch (Exception) { feedback.Text = "Impossible de charger les comptes fournisseurs."; }
        }
        refresh.Click += (_, _) => Reload();
        grid.SelectionChanged += (_, _) => settle.IsEnabled =
            grid.SelectedItem is SupplierSettlementRow && paymentModes.Count > 0;
        settle.Click += (_, _) =>
        {
            if (grid.SelectedItem is not SupplierSettlementRow supplier) return;
            var dialog = new SupplierSettlementDialog(supplier, paymentModes, submit) { Owner = this };
            if (dialog.ShowDialog() == true) Reload();
        };
        actions.Children.Add(refresh);
        actions.Children.Add(settle);
        DockPanel.SetDock(actions, Dock.Top);
        panel.Children.Add(actions);
        panel.Children.Add(grid);
        Content = panel;
        Loaded += (_, _) => Reload();
    }
}
