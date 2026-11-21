using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace Hanouty.Desktop.Wpf;

public sealed class BusinessDocumentsDialog : Window
{
    public BusinessDocumentsDialog(IBusinessDocumentsWorkflow workflow)
    {
        Title = "Devis, bons de livraison et factures"; Width = 1160; Height = 760; MinWidth = 800; MinHeight = 550;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(16) };
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 0) };
        DockPanel.SetDock(status, Dock.Bottom); panel.Children.Add(status);
        var top = new StackPanel(); DockPanel.SetDock(top, Dock.Top); panel.Children.Add(top);
        top.Children.Add(new TextBlock { Text = Title, FontSize = 24, FontWeight = FontWeights.SemiBold });
        var filters = new WrapPanel { Margin = new Thickness(0, 8, 0, 8) }; top.Children.Add(filters);
        var kind = new ComboBox { Width = 170, MinHeight = 38, ItemsSource = new[] { "Devis", "Bon de livraison", "Facture" }, SelectedIndex = 0 };
        var from = new DatePicker { SelectedDate = DateTime.Today.AddMonths(-1), Width = 140, MinHeight = 38 };
        var to = new DatePicker { SelectedDate = DateTime.Today, Width = 140, MinHeight = 38 };
        var search = new TextBox { Width = 250, MinHeight = 38 };
        foreach (var (label, control) in new (string, Control)[] { ("Document", kind), ("Du", from), ("Au", to), ("Numéro, code ou client", search) })
        {
            var item = new StackPanel { Margin = new Thickness(0, 0, 8, 0) }; item.Children.Add(new Label { Content = label, Target = control }); item.Children.Add(control); filters.Children.Add(item);
            System.Windows.Automation.AutomationProperties.SetName(control, label);
        }
        var actions = new WrapPanel { Margin = new Thickness(0, 0, 0, 8) }; top.Children.Add(actions);
        Button Add(string label) { var b = new Button { Content = label, MinHeight = 42, Padding = new Thickness(12, 4, 12, 4), Margin = new Thickness(0, 0, 8, 0) }; actions.Children.Add(b); return b; }
        var find = Add("Rechercher"); var consult = Add("Consulter"); var validate = Add("Valider le document"); var preview = Add("Aperçu / imprimer");
        var totals = new TextBlock { FontSize = 18, FontWeight = FontWeights.SemiBold, Margin = new Thickness(0, 6, 0, 8) };
        DockPanel.SetDock(totals, Dock.Bottom); panel.Children.Add(totals);
        var grid = new Grid(); grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); panel.Children.Add(grid);
        DataGrid Table() => new() { AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false, SelectionMode = DataGridSelectionMode.Single, SelectionUnit = DataGridSelectionUnit.FullRow, RowHeight = 38 };
        void Column(DataGrid target, string label, string property, string? format = null) => target.Columns.Add(new DataGridTextColumn { Header = label, Binding = new Binding(property) { StringFormat = format }, Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        var headers = Table(); grid.Children.Add(headers);
        foreach (var (label, property, format) in new[] { ("Numéro", "Number", (string?)null), ("Date", "Date", "dd/MM/yyyy"), ("Client", "Customer", null), ("État", "State", null), ("HT", "TotalHt", "N2"), ("TVA", "TotalTax", "N2"), ("TTC", "TotalTtc", "N2") }) Column(headers, label, property, format);
        var lines = Table(); lines.Margin = new Thickness(0, 8, 0, 0); Grid.SetRow(lines, 1); grid.Children.Add(lines);
        foreach (var (label, property, format) in new[] { ("Code", "Code", (string?)null), ("Article", "Article", null), ("Qté", "Quantity", "0.####"), ("PU TTC", "UnitTtc", "N2"), ("Remise %", "DiscountRate", "0.####"), ("HT", "TotalHt", "N2"), ("TVA", "TotalTax", "N2"), ("TTC", "TotalTtc", "N2") }) Column(lines, label, property, format);
        BusinessDocumentSnapshot? current = null;
        void ClearDetail() { current = null; lines.ItemsSource = null; totals.Text = ""; validate.IsEnabled = preview.IsEnabled = false; }
        void Changed() { headers.ItemsSource = null; ClearDetail(); consult.IsEnabled = false; status.Text = "Critères modifiés : relancez la recherche."; }
        void Read()
        {
            ClearDetail();
            if (headers.SelectedItem is not BusinessDocumentHeader selected) return;
            try
            {
                current = workflow.Read((BusinessDocumentKind)kind.SelectedIndex, selected.RowId); lines.ItemsSource = current.Lines;
                totals.Text = $"HT {current.Header.TotalHt:N2}   TVA {current.Header.TotalTax:N2}   TTC {current.Header.TotalTtc:N2} MAD   Remise {current.Header.Discount:N2}";
                validate.IsEnabled = current.Header.State == "ENREGISTRER"; preview.IsEnabled = true;
                status.Text = $"{current.Header.Number} — {current.Header.Customer} — {current.Header.State}";
            }
            catch (Exception ex) { status.Text = ex.Message; }
        }
        headers.SelectionChanged += (_, _) => { ClearDetail(); consult.IsEnabled = headers.SelectedItem is BusinessDocumentHeader; };
        kind.SelectionChanged += (_, _) => Changed(); from.SelectedDateChanged += (_, _) => Changed(); to.SelectedDateChanged += (_, _) => Changed(); search.TextChanged += (_, _) => Changed();
        find.Click += (_, _) =>
        {
            Changed();
            try { var rows = workflow.Search((BusinessDocumentKind)kind.SelectedIndex, from.SelectedDate ?? DateTime.MinValue, to.SelectedDate ?? DateTime.MinValue, search.Text); headers.ItemsSource = rows; status.Text = $"{rows.Count} document(s)."; }
            catch (Exception ex) { status.Text = ex.Message; }
        };
        consult.Click += (_, _) => Read();
        validate.Click += (_, _) =>
        {
            if (current is null || MessageBox.Show(this, $"Valider {current.Header.Number} pour {current.Header.TotalTtc:N2} MAD ?", "Validation du document", MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK) return;
            try { workflow.Validate(current); Read(); status.Text = "Validation confirmée. " + status.Text; }
            catch (Exception ex) { ClearDetail(); status.Text = "Résultat à vérifier en consultant à nouveau ce document. " + ex.Message; }
        };
        preview.Click += (_, _) =>
        {
            if (current is null) return;
            try
            {
                var fresh = workflow.Read(current.Kind, current.Header.RowId);
                if (fresh.Revision != current.Revision || fresh.Header.State != current.Header.State) { ClearDetail(); throw new InvalidOperationException("Document modifié : consultez-le à nouveau avant impression."); }
                new BusinessDocumentPreviewDialog(fresh) { Owner = this }.ShowDialog();
            }
            catch (Exception ex) { status.Text = ex.Message; }
        };
        Content = panel; ClearDetail(); consult.IsEnabled = false;
    }
}

public sealed class BusinessDocumentPreviewDialog : Window
{
    public BusinessDocumentPreviewDialog(BusinessDocumentSnapshot snapshot)
    {
        Title = "Aperçu — " + snapshot.Header.Number; Width = 900; Height = 720; WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(12) }; var print = new Button { Content = "Imprimer…", MinHeight = 44 };
        DockPanel.SetDock(print, Dock.Top); panel.Children.Add(print);
        var viewer = new FlowDocumentScrollViewer { Document = BuildDocument(snapshot), VerticalScrollBarVisibility = ScrollBarVisibility.Auto }; panel.Children.Add(viewer);
        print.Click += (_, _) => { var dialog = new PrintDialog(); if (dialog.ShowDialog() == true) dialog.PrintDocument(((IDocumentPaginatorSource)BuildDocument(snapshot)).DocumentPaginator, Title); };
        Content = panel;
    }
    public static FlowDocument BuildDocument(BusinessDocumentSnapshot snapshot)
    {
        var h = snapshot.Header;
        var document = new FlowDocument { FontFamily = new System.Windows.Media.FontFamily("Segoe UI"), FontSize = 12, PagePadding = new Thickness(36), ColumnWidth = double.PositiveInfinity };
        var label = snapshot.Kind switch { BusinessDocumentKind.Devis => "DEVIS", BusinessDocumentKind.BonLivraison => "BON DE LIVRAISON", _ => "FACTURE" };
        document.Blocks.Add(new Paragraph(new Run($"{label} {h.Number}")) { FontSize = 22, FontWeight = FontWeights.Bold });
        document.Blocks.Add(new Paragraph(new Run($"Le {h.Date:dd/MM/yyyy} — {h.State}\n{snapshot.CustomerName}\nICE : {snapshot.CustomerIce}\n{snapshot.CustomerAddress}")));
        var table = new Table { CellSpacing = 0 }; var group = new TableRowGroup(); table.RowGroups.Add(group);
        foreach (var width in new[] { 90d, 210d, 55d, 70d, 70d, 80d }) table.Columns.Add(new TableColumn { Width = new GridLength(width) });
        void Row(params string[] values) { var row = new TableRow(); foreach (var value in values) row.Cells.Add(new TableCell(new Paragraph(new Run(value))) { Padding = new Thickness(3), BorderThickness = new Thickness(0, 0, 0, 0.5), BorderBrush = System.Windows.Media.Brushes.Gray }); group.Rows.Add(row); }
        Row("Code", "Article", "Qté", "PU TTC", "Remise %", "Total TTC");
        foreach (var line in snapshot.Lines) Row(line.Code, line.Article, line.Quantity.ToString("0.####", CultureInfo.CurrentCulture), line.UnitTtc.ToString("N2"), line.DiscountRate.ToString("0.####"), line.TotalTtc.ToString("N2"));
        document.Blocks.Add(table);
        document.Blocks.Add(new Paragraph(new Run($"Total HT : {h.TotalHt:N2} MAD\nTVA : {h.TotalTax:N2} MAD\nTotal TTC : {h.TotalTtc:N2} MAD\nRemise : {h.Discount:N2} MAD")) { TextAlignment = TextAlignment.Right, FontWeight = FontWeights.Bold });
        document.Blocks.Add(new Paragraph(new Run(h.Notes))); return document;
    }
}
