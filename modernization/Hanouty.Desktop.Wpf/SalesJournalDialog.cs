using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Hanouty.Desktop.Wpf;

public sealed class SalesJournalDialog : Window
{
    public SalesJournalDialog(ISalesJournalWorkflow workflow)
    {
        Title = workflow.CanStatistics ? "Journal et statistiques des ventes" : "Journal des ventes";
        Width = 1120; Height = 720; MinWidth = 760; MinHeight = 480; WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var root = new DockPanel { Margin = new Thickness(16) }; Content = root;
        var heading = new TextBlock { Text = Title, FontSize = 24, FontWeight = FontWeights.SemiBold }; DockPanel.SetDock(heading, Dock.Top); root.Children.Add(heading);
        var filters = new WrapPanel { Margin = new Thickness(0, 10, 0, 8) }; DockPanel.SetDock(filters, Dock.Top); root.Children.Add(filters);
        void Filter(string label, Control control) { var panel = new StackPanel { Margin = new Thickness(0, 0, 8, 0) }; panel.Children.Add(new TextBlock { Text = label }); panel.Children.Add(control); filters.Children.Add(panel); }
        var from = new DatePicker { SelectedDate = DateTime.Today, MinHeight = 36, Width = 140 };
        var to = new DatePicker { SelectedDate = DateTime.Today, MinHeight = 36, Width = 140 };
        var cashier = new ComboBox { MinHeight = 36, Width = 150 }; var mode = new ComboBox { MinHeight = 36, Width = 130 }; var operation = new ComboBox { MinHeight = 36, Width = 160 };
        Filter("Du", from); Filter("Au (inclus)", to); Filter("Caissier (vide = tous)", cashier); Filter("Mode", mode); Filter("Opération", operation);
        var search = new TextBox { MinHeight = 36, Width = 250 }; System.Windows.Automation.AutomationProperties.SetName(search, "Rechercher un ticket, client ou article"); Filter("Ticket, client ou article", search);
        var apply = new Button { Content = "Afficher", MinHeight = 40, Padding = new Thickness(18, 4, 18, 4), VerticalAlignment = VerticalAlignment.Bottom }; filters.Children.Add(apply);
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 6, 0, 0) }; DockPanel.SetDock(status, Dock.Bottom); root.Children.Add(status);
        var summary = new TextBlock { TextWrapping = TextWrapping.Wrap, FontSize = 16, Margin = new Thickness(0, 0, 0, 8) }; DockPanel.SetDock(summary, Dock.Top); root.Children.Add(summary);
        var tabs = new TabControl(); root.Children.Add(tabs);
        var ticketsPanel = new DockPanel(); tabs.Items.Add(new TabItem { Header = "Tickets", Content = ticketsPanel });
        var actions = new WrapPanel { Margin = new Thickness(0, 6, 0, 0) }; DockPanel.SetDock(actions, Dock.Bottom); ticketsPanel.Children.Add(actions);
        var details = new Button { Content = "Détail du ticket", MinHeight = 42, Padding = new Thickness(14, 4, 14, 4), Margin = new Thickness(0, 0, 8, 0) };
        var reprint = new Button { Content = "Réimprimer le ticket", MinHeight = 42, Padding = new Thickness(14, 4, 14, 4) }; actions.Children.Add(details); actions.Children.Add(reprint);
        static DataGrid Grid() => new() { AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false, SelectionMode = DataGridSelectionMode.Single, SelectionUnit = DataGridSelectionUnit.FullRow, RowHeight = 38 };
        static void Columns(DataGrid grid, params (string Label, string Path, string? Format)[] columns)
        {
            foreach (var column in columns) grid.Columns.Add(new DataGridTextColumn { Header = column.Label, Binding = new Binding(column.Path) { StringFormat = column.Format }, Width = DataGridLength.Auto });
        }
        var tickets = Grid(); Columns(tickets, ("Ticket", "Number", null), ("Date", "Date", "dd/MM/yyyy HH:mm"), ("Caissier", "Cashier", null),
            ("Poste", "Register", null), ("Opération", "Operation", null), ("Client", "Customer", null), ("Quantité signée", "Quantity", "0.####"), ("Net MAD", "Total", "0.00"), ("Modes", "Modes", null)); ticketsPanel.Children.Add(tickets);
        var finance = Grid(); Columns(finance, ("Mode de règlement ticket", "Mode", null), ("Montant signé MAD", "Amount", "0.00"));
        tabs.Items.Add(new TabItem { Header = "Règlements des tickets", Content = finance });
        var daily = Grid(); Columns(daily, ("Jour", "Date", "dd/MM/yyyy"), ("Ventes payées", "Sales", "0.00"), ("Retours payés signés", "Returns", "0.00"),
            ("Net payé", "PaidNet", "0.00"), ("Ventes crédit", "CreditSales", "0.00"), ("Retours crédit signés", "CreditReturns", "0.00"), ("Net crédit", "CreditNet", "0.00"), ("Quantité signée", "Quantity", "0.####"));
        var byCashier = Grid(); Columns(byCashier, ("Caissier", "Cashier", null), ("Net payé", "PaidNet", "0.00"), ("Net crédit", "CreditNet", "0.00"), ("Quantité signée", "Quantity", "0.####"));
        if (workflow.CanStatistics) { tabs.Items.Add(new TabItem { Header = "Statistiques par jour", Content = daily }); tabs.Items.Add(new TabItem { Header = "Statistiques par caissier", Content = byCashier }); }
        void Selection() { details.IsEnabled = tickets.SelectedItem is SalesJournalTicket; reprint.IsEnabled = tickets.SelectedItem is SalesJournalTicket { CanReprint: true }; }
        void Clear() { tickets.ItemsSource = null; finance.ItemsSource = null; daily.ItemsSource = null; byCashier.ItemsSource = null; summary.Text = ""; Selection(); status.Text = "Filtres modifiés : cliquez sur Afficher."; }
        void Read()
        {
            Clear(); apply.IsEnabled = false;
            try
            {
                if (from.SelectedDate is not { } begin || to.SelectedDate is not { } end) throw new ArgumentException("Choisissez les deux dates.");
                var result = workflow.Read(new SalesJournalFilter(begin, end, cashier.SelectedItem as string ?? "", mode.SelectedItem as string ?? "", operation.SelectedItem as string ?? "", search.Text));
                tickets.ItemsSource = result.Tickets; finance.ItemsSource = result.Payments; daily.ItemsSource = result.Days; byCashier.ItemsSource = result.Cashiers;
                var t = result.Totals;
                summary.Text = $"{t.Tickets} ticket(s) · Ventes payées {t.Sales:0.00} · Retours {t.Returns:0.00} · NET PAYÉ {t.PaidNet:0.00} MAD\n" +
                    $"Crédit {t.CreditSales:0.00} · Retours crédit {t.CreditReturns:0.00} · NET CRÉDIT {t.CreditNet:0.00} MAD · Quantité signée {t.Quantity:0.####}";
                status.Text = "Crédit et règlements restent séparés du net payé. Les montants de règlement incluent les rendus/remboursements signés ; ils ne représentent pas à eux seuls le fonds du tiroir.";
                if (string.IsNullOrEmpty(mode.SelectedItem as string) && result.PaidPaymentGap != 0m)
                    status.Text = $"Écart journal / règlements tickets : {result.PaidPaymentGap:0.00} MAD. Vérifiez les données. " + status.Text;
            }
            catch (Exception ex) { Clear(); status.Text = ex.Message; }
            finally { apply.IsEnabled = true; }
        }
        from.SelectedDateChanged += (_, _) => Clear(); to.SelectedDateChanged += (_, _) => Clear(); cashier.SelectionChanged += (_, _) => Clear();
        mode.SelectionChanged += (_, _) => Clear(); operation.SelectionChanged += (_, _) => Clear(); search.TextChanged += (_, _) => Clear(); tickets.SelectionChanged += (_, _) => Selection(); apply.Click += (_, _) => Read();
        details.Click += (_, _) =>
        {
            if (tickets.SelectedItem is not SalesJournalTicket selected) return;
            try
            {
                var detail = workflow.Details(selected); var panel = new DockPanel { Margin = new Thickness(12) };
                var identity = new TextBlock { Text = $"{selected.Number} · {selected.Operation} · {selected.Cashier} · {selected.Total:0.00} MAD", FontSize = 18, Margin = new Thickness(0, 0, 0, 8), TextWrapping = TextWrapping.Wrap };
                DockPanel.SetDock(identity, Dock.Top); panel.Children.Add(identity);
                var list = Grid(); Columns(list, ("Article", "Article", null), ("Code", "Code", null), ("Quantité", "Quantity", "0.####"), ("Prix original", "UnitPrice", "0.00"), ("Remise %", "Discount", "0.####"), ("Net signé", "Net", "0.00")); list.ItemsSource = detail.Lines; panel.Children.Add(list);
                new Window { Title = "Détail du ticket — " + selected.Number, Width = 900, Height = 460, Owner = this, WindowStartupLocation = WindowStartupLocation.CenterOwner, Content = panel }.ShowDialog();
            }
            catch (Exception ex) { Clear(); status.Text = ex.Message; }
        };
        reprint.Click += (_, _) => { if (tickets.SelectedItem is not SalesJournalTicket selected) return; try { workflow.Reprint(selected); status.Text = "Demande de réimpression transmise."; } catch (Exception ex) { Clear(); status.Text = ex.Message; } };
        Loaded += (_, _) =>
        {
            try { var options = workflow.Options(); cashier.ItemsSource = options.Cashiers; mode.ItemsSource = options.Modes; operation.ItemsSource = options.Operations; cashier.SelectedIndex = mode.SelectedIndex = operation.SelectedIndex = 0; Read(); }
            catch (Exception ex) { Clear(); status.Text = ex.Message; }
        };
        Selection();
    }
}
