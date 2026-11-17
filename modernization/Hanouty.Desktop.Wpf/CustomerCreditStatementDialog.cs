using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Hanouty.Desktop.Wpf;

public sealed record CustomerCreditStatementRow(
    string CustomerId, string Customer, decimal OpeningCredit,
    decimal CreditSales, decimal CreditReturns, decimal Payments, decimal Balance);

public sealed class CustomerCreditStatementDialog : Window
{
    private readonly DatePicker from = new() { SelectedDate = new DateTime(2000, 1, 1), Width = 140 };
    private readonly DatePicker to = new() { SelectedDate = DateTime.Today, Width = 140 };
    private readonly DataGrid grid = new()
    {
        AutoGenerateColumns = false,
        IsReadOnly = true,
        CanUserAddRows = false
    };
    private readonly TextBlock result = new() { Margin = new Thickness(0, 8, 0, 0) };
    private readonly Func<DateTime, DateTime, IReadOnlyList<CustomerCreditStatementRow>> readStatement;

    public CustomerCreditStatementDialog(
        Func<DateTime, DateTime, IReadOnlyList<CustomerCreditStatementRow>> readStatement,
        IReadOnlyList<string>? paymentModes = null, Func<CustomerSettlementRequest, bool>? submitSettlement = null)
    {
        this.readStatement = readStatement ?? throw new ArgumentNullException(nameof(readStatement));
        Title = "État des crédits clients";
        Width = 900;
        Height = 520;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;

        var layout = new DockPanel { Margin = new Thickness(16) };
        var filters = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 0, 0, 8) };
        AddDateFilter(filters, "Du", from);
        AddDateFilter(filters, "Au", to);
        var refresh = new Button { Content = "Afficher", MinWidth = 90 };
        refresh.Click += (_, _) => RefreshStatement();
        filters.Children.Add(refresh);
        var settle = new Button { Content = "Régler le client sélectionné", Margin = new Thickness(8, 0, 0, 0),
            IsEnabled = false };
        grid.SelectionChanged += (_, _) => settle.IsEnabled =
            grid.SelectedItem is CustomerCreditStatementRow && submitSettlement is not null &&
            paymentModes is { Count: > 0 };
        settle.Click += (_, _) =>
        {
            if (grid.SelectedItem is not CustomerCreditStatementRow customer ||
                submitSettlement is null || paymentModes is null) return;
            var dialog = new CustomerSettlementDialog(customer, paymentModes, submitSettlement) { Owner = this };
            if (dialog.ShowDialog() == true) RefreshStatement();
        };
        filters.Children.Add(settle);
        DockPanel.SetDock(filters, Dock.Top);
        layout.Children.Add(filters);
        DockPanel.SetDock(result, Dock.Bottom);
        layout.Children.Add(result);

        AddColumn("ID client", nameof(CustomerCreditStatementRow.CustomerId));
        AddColumn("Client", nameof(CustomerCreditStatementRow.Customer));
        AddColumn("Crédit initial", nameof(CustomerCreditStatementRow.OpeningCredit), true);
        AddColumn("Crédit", nameof(CustomerCreditStatementRow.CreditSales), true);
        AddColumn("Retour", nameof(CustomerCreditStatementRow.CreditReturns), true);
        AddColumn("Règlements", nameof(CustomerCreditStatementRow.Payments), true);
        AddColumn("Reliquat", nameof(CustomerCreditStatementRow.Balance), true);
        layout.Children.Add(grid);
        Content = layout;
        Loaded += (_, _) => RefreshStatement();
    }

    private static void AddDateFilter(Panel filters, string label, DatePicker picker)
    {
        filters.Children.Add(new Label { Content = label, Target = picker });
        picker.Margin = new Thickness(0, 0, 10, 0);
        filters.Children.Add(picker);
    }

    private void AddColumn(string title, string property, bool amount = false)
    {
        var binding = new Binding(property);
        if (amount) binding.StringFormat = "N2";
        grid.Columns.Add(new DataGridTextColumn { Header = title, Binding = binding });
    }

    private void RefreshStatement()
    {
        grid.ItemsSource = null;
        if (from.SelectedDate is not DateTime start || to.SelectedDate is not DateTime end || start > end)
        {
            result.Text = "Sélectionnez une période valide.";
            return;
        }

        try
        {
            var openBalances = readStatement(start.Date, end.Date)
                .Where(row => row.Balance != 0m)
                .OrderByDescending(row => row.Balance)
                .ToArray();
            grid.ItemsSource = openBalances;
            var total = openBalances.Sum(row => row.Balance);
            result.Text = "Total reliquat : " + total.ToString("N2", CultureInfo.CurrentCulture) + " DH";
        }
        catch (Exception)
        {
            result.Text = "Impossible de charger l’état des crédits clients.";
        }
    }
}
