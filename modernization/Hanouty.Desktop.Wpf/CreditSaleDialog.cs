using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Hanouty.Desktop.Wpf;

public sealed record CreditCustomerChoice(string Id, string Code, string Name, string Telephone);

// Form_5_CLIENTS_LISTE selection followed by the explicit SOLDER CREDIT review.
// The dialog neither prices the basket nor writes a debt/payment.
public sealed class CreditSaleDialog : Window
{
    public CreditCustomerChoice? Customer { get; private set; }
    public CreditSaleDialog(decimal total, Func<string, IReadOnlyList<CreditCustomerChoice>> find)
    {
        Title = "Vente à crédit"; Width = 760; Height = 560; MinWidth = 600; MinHeight = 420;
        MaxHeight = SystemParameters.WorkArea.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(16) };
        var footer = new StackPanel(); DockPanel.SetDock(footer, Dock.Bottom); panel.Children.Add(footer);
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 8) };
        footer.Children.Add(status);
        var confirm = new Button { Content = "Choisir ce client", MinHeight = 48, IsEnabled = false, IsDefault = true };
        footer.Children.Add(confirm);
        var back = new Button { Content = "Changer de client", MinHeight = 40, Margin = new Thickness(0, 6, 0, 0), Visibility = Visibility.Collapsed };
        footer.Children.Add(back);
        footer.Children.Add(new Button { Content = "Annuler", MinHeight = 40, IsCancel = true, Margin = new Thickness(0, 6, 0, 0) });
        var header = new StackPanel(); DockPanel.SetDock(header, Dock.Top); panel.Children.Add(header);
        header.Children.Add(new TextBlock { Text = "Vente à crédit", FontSize = 24, FontWeight = FontWeights.SemiBold });
        header.Children.Add(new TextBlock { Text = $"Net du ticket : {total:N2} MAD", FontSize = 22, Margin = new Thickness(0, 4, 0, 10) });
        var lookup = new DockPanel { Margin = new Thickness(0, 0, 0, 8) };
        var searchButton = new Button { Content = "Rechercher", MinHeight = 40, Padding = new Thickness(12, 4, 12, 4) };
        DockPanel.SetDock(searchButton, Dock.Right); lookup.Children.Add(searchButton);
        var search = new TextBox { MinHeight = 40, Padding = new Thickness(8), Margin = new Thickness(0, 0, 8, 0) };
        System.Windows.Automation.AutomationProperties.SetName(search, "Rechercher un client par nom téléphone ou code");
        lookup.Children.Add(search); header.Children.Add(lookup);
        var grid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false,
            SelectionMode = DataGridSelectionMode.Single, SelectionUnit = DataGridSelectionUnit.FullRow, RowHeight = 40 };
        System.Windows.Automation.AutomationProperties.SetName(grid, "Clients pour la vente à crédit");
        foreach (var (label, property, width) in new[] {
            ("Code", nameof(CreditCustomerChoice.Code), 130d), ("Client", nameof(CreditCustomerChoice.Name), double.NaN),
            ("Téléphone", nameof(CreditCustomerChoice.Telephone), 160d) })
            grid.Columns.Add(new DataGridTextColumn { Header = label, Binding = new Binding(property),
                Width = double.IsNaN(width) ? new DataGridLength(1, DataGridLengthUnitType.Star) : new DataGridLength(width) });
        panel.Children.Add(grid);
        IReadOnlyList<CreditCustomerChoice> rows = Array.Empty<CreditCustomerChoice>();
        CreditCustomerChoice? reviewed = null;
        void Invalidate()
        {
            reviewed = null; Customer = null; confirm.Content = "Choisir ce client"; confirm.IsEnabled = false;
            SizeToContent = SizeToContent.Manual; MinHeight = 420; Height = 560;
            back.Visibility = Visibility.Collapsed; grid.Visibility = Visibility.Visible; lookup.Visibility = Visibility.Visible;
            grid.ItemsSource = null; rows = Array.Empty<CreditCustomerChoice>(); status.Text = "";
        }
        void Search()
        {
            Invalidate();
            try
            {
                rows = find(search.Text);
                grid.ItemsSource = rows; grid.SelectedItem = null;
                status.Text = rows.Count == 0 ? "Aucun client trouvé." : "Choisissez le client du ticket.";
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { status.Text = ex is ArgumentException or InvalidOperationException ? ex.Message : "Liste des clients indisponible."; }
        }
        search.TextChanged += (_, _) => Invalidate();
        searchButton.Click += (_, _) => Search();
        search.KeyDown += (_, args) => { if (args.Key == Key.Enter) { args.Handled = true; Search(); } };
        grid.SelectionChanged += (_, _) => confirm.IsEnabled = grid.SelectedItem is CreditCustomerChoice chosen &&
            rows.Any(row => ReferenceEquals(row, chosen));
        confirm.Click += (_, _) =>
        {
            if (reviewed is null)
            {
                if (grid.SelectedItem is not CreditCustomerChoice chosen || !rows.Any(row => ReferenceEquals(row, chosen))) return;
                reviewed = chosen;
                MinHeight = 320; SizeToContent = SizeToContent.Height;
                grid.Visibility = Visibility.Collapsed; lookup.Visibility = Visibility.Collapsed; back.Visibility = Visibility.Visible;
                status.Text = $"Voulez-vous vraiment valider le crédit pour {chosen.Name} ?\nCode : {chosen.Code}\n" +
                    $"Montant dû : {total.ToString("N2", CultureInfo.CurrentCulture)} MAD\nAucun encaissement n’est enregistré pour ce ticket.";
                confirm.Content = "Confirmer le crédit"; confirm.IsEnabled = true;
                return;
            }
            Customer = reviewed; DialogResult = true;
        };
        back.Click += (_, _) => Search();
        Content = panel; Loaded += (_, _) => Search();
    }
}
