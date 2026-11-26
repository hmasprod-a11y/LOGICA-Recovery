using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Hanouty.Desktop.Wpf;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class SupplierAvoirCreateDialog : Window
{
    internal string? DocumentId { get; private set; }
    internal SupplierAvoirCreateDialog(StockIssueValidation service, SupplierAvoirWorkflow workflow)
    {
        Title = "Nouvel avoir fournisseur"; Width = 820; Height = 740; MinWidth = 640; MinHeight = 500;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(16) };
        var footer = new StackPanel(); DockPanel.SetDock(footer, Dock.Bottom); panel.Children.Add(footer);
        var total = new TextBlock { FontSize = 20, FontWeight = FontWeights.SemiBold, Margin = new Thickness(0, 8, 0, 8) };
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap };
        var save = new Button { Content = "Enregistrer l’avoir", MinHeight = 44, IsDefault = true };
        footer.Children.Add(total); footer.Children.Add(status); footer.Children.Add(save);
        var fields = new StackPanel(); panel.Children.Add(new ScrollViewer { Content = fields, VerticalScrollBarVisibility = ScrollBarVisibility.Auto });
        fields.Children.Add(new TextBlock { Text = Title, FontSize = 24, FontWeight = FontWeights.SemiBold });
        fields.Children.Add(new TextBlock { Text = "Enregistrement : compte fournisseur selon le total signé. Validation séparée : sortie du stock.", TextWrapping = TextWrapping.Wrap });
        void Field(string title, Control control)
        { System.Windows.Automation.AutomationProperties.SetName(control, title); fields.Children.Add(new Label { Content = title, Target = control }); fields.Children.Add(control); }
        var date = new DatePicker { SelectedDate = DateTime.Today, MinHeight = 36 }; Field("Date de l’avoir", date);
        var supplierSearch = new TextBox { MinHeight = 36 }; Field("Rechercher un fournisseur", supplierSearch);
        var suppliers = service.AvoirSuppliers();
        var supplier = new ComboBox { ItemsSource = suppliers, DisplayMemberPath = "Label", MinHeight = 38 }; Field("Fournisseur", supplier);
        supplierSearch.TextChanged += (_, _) =>
        {
            var query = supplierSearch.Text.Trim(); supplier.SelectedItem = null;
            supplier.ItemsSource = suppliers.Where(item => item.Name.Contains(query, StringComparison.CurrentCultureIgnoreCase) || item.Code.Contains(query, StringComparison.OrdinalIgnoreCase)).ToArray();
        };
        var articles = service.AvoirArticles();
        var articleSearch = new TextBox { MinHeight = 36 }; Field("Rechercher un article", articleSearch);
        var article = new ComboBox { ItemsSource = articles, DisplayMemberPath = "Label", MinHeight = 38 }; Field("Article de l’avoir", article);
        articleSearch.TextChanged += (_, _) =>
        {
            var query = articleSearch.Text.Trim(); article.SelectedItem = null;
            article.ItemsSource = articles.Where(item => item.Name.Contains(query, StringComparison.CurrentCultureIgnoreCase) || item.Code.Contains(query, StringComparison.OrdinalIgnoreCase)).ToArray();
        };
        var quantity = new TextBox { Text = "1", MinHeight = 36 }; TouchNumericEntry.Attach(quantity, "Quantité de l’avoir"); Field("Quantité de l’avoir", quantity);
        var cost = new TextBox { Text = "0", MinHeight = 36 }; TouchNumericEntry.Attach(cost, "Prix d’achat signé", allowZero: true, allowNegative: true); Field("Prix d’achat signé", cost);
        var price = new TextBox { Text = "0", MinHeight = 36 }; TouchNumericEntry.Attach(price, "Prix de vente signé", allowZero: true, allowNegative: true); Field("Prix de vente signé", price);
        article.SelectionChanged += (_, _) =>
        {
            if (article.SelectedItem is StockIssueValidation.AvoirArticle row)
            { cost.Text = row.Cost.ToString("0.##", CultureInfo.CurrentCulture); price.Text = row.Price.ToString("0.##", CultureInfo.CurrentCulture); }
        };
        var lines = new ObservableCollection<StockIssueValidation.AvoirLine>();
        var add = new Button { Content = "Ajouter à l’avoir", MinHeight = 40 }; fields.Children.Add(add);
        var list = new DataGrid { ItemsSource = lines, AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false, Height = 150, RowHeight = 34 };
        foreach (var (caption, binding) in new[] { ("Article", "Label"), ("Quantité", "Quantity"), ("Achat signé", "Cost"), ("Vente signée", "Price"), ("Net achat signé", "CostNet") })
            list.Columns.Add(new DataGridTextColumn { Header = caption, Binding = new Binding(binding), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        fields.Children.Add(list);
        var remove = new Button { Content = "Retirer de l’avoir", MinHeight = 40 }; fields.Children.Add(remove);
        var notes = new TextBox { MinHeight = 36 }; Field("Notes de l’avoir", notes);
        var confirmation = new CheckBox { Content = "Je confirme le fournisseur, les quantités et le total signé affiché.", Margin = new Thickness(0, 8, 0, 8) }; footer.Children.Insert(1, confirmation);
        void Refresh() { total.Text = $"Total achat signé : {lines.Sum(line => line.CostNet):N2} MAD"; confirmation.IsChecked = false; }
        bool Money(TextBox box, out decimal value) => decimal.TryParse(box.Text, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out value) && decimal.Round(value, 2) == value;
        add.Click += (_, _) =>
        {
            if (article.SelectedItem is not StockIssueValidation.AvoirArticle row || !Money(quantity, out var count) || count <= 0 || count > 9999 ||
                !Money(cost, out var purchase) || !Money(price, out var retail) || lines.Any(line => line.Article.Id == row.Id))
            { status.Text = "Sélectionnez un article distinct, une quantité positive (maximum9999) et des prix valides."; return; }
            var added = new StockIssueValidation.AvoirLine(row, count, purchase, retail);
            try { _ = lines.Sum(line => line.CostNet) + added.CostNet; _ = lines.Sum(line => line.PriceNet) + added.PriceNet; }
            catch (OverflowException) { status.Text = "Montant trop grand pour cet avoir."; return; }
            lines.Add(added); status.Text = ""; Refresh();
        };
        remove.Click += (_, _) => { if (list.SelectedItem is StockIssueValidation.AvoirLine line) { lines.Remove(line); Refresh(); } };
        supplier.SelectionChanged += (_, _) => confirmation.IsChecked = false;
        date.SelectedDateChanged += (_, _) => confirmation.IsChecked = false;
        notes.TextChanged += (_, _) => confirmation.IsChecked = false;
        var pending = workflow.Pending;
        void Lock(bool locked) => fields.IsEnabled = !locked;
        if (pending is not null)
        {
            date.SelectedDate = pending.Date; supplier.ItemsSource = new[] { pending.Supplier }; supplier.SelectedItem = pending.Supplier; notes.Text = pending.Notes;
            foreach (var line in pending.Lines) lines.Add(line); Refresh(); Lock(true); save.Content = "Vérifier l’enregistrement précédent";
            status.Text = "Une création interrompue doit être vérifiée avec le même contenu avant toute nouvelle opération.";
        }
        else Refresh();
        save.Click += (_, _) =>
        {
            save.IsEnabled = false;
            try
            {
                if (pending is null)
                {
                    if (date.SelectedDate is not DateTime day || supplier.SelectedItem is not StockIssueValidation.SupplierChoice selected || lines.Count == 0 || confirmation.IsChecked != true)
                    { status.Text = "Sélectionnez le fournisseur et confirmez l’avoir complet."; return; }
                    pending = new StockIssueValidation.AvoirCommand(Guid.NewGuid().ToString("N"), day.Date, selected, notes.Text, lines.ToArray());
                }
                Lock(true); DocumentId = workflow.Execute(pending); pending = null; DialogResult = true;
            }
            catch (StockIssueValidation.AvoirWriteRefusedException ex) { pending = workflow.Pending; Lock(pending is not null); status.Text = "Aucune création appliquée. " + ex.Message; }
            catch (Exception ex) { pending = workflow.Pending ?? pending; Lock(true); status.Text = "Résultat à vérifier avant une autre création. " + ex.Message; }
            finally { save.IsEnabled = true; save.Content = pending is null ? "Enregistrer l’avoir" : "Vérifier l’enregistrement précédent"; }
        };
        Closing += (_, args) => { if (workflow.Pending is not null) { args.Cancel = true; status.Text = "Vérifiez la création précédente avant de fermer."; } };
        Content = panel;
    }
}
