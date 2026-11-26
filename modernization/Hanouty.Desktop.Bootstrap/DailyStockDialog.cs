using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Hanouty.Desktop.Bootstrap;

internal sealed record DailyStockHooks(Action<DailyStockReader.Article>? OpenArticle = null, Action? OpenInventory = null,
    Action? OpenReceipts = null, Action? OpenStockIssues = null, Action? OpenCatalogue = null,
    Action<DailyStockReader.Article>? AdjustStock = null, Action? NewArticle = null);

internal sealed class DailyStockDialog : Window
{
    internal DailyStockDialog(DailyStockReader reader, DailyStockReader.Access access, DailyStockHooks? hooks = null)
    {
        StockWorkspaceAppearance.Apply(this);
        hooks ??= new DailyStockHooks();
        Title = "Articles et stock"; Width = 1120; Height = 740; WindowState = WindowState.Maximized; MinWidth = 780; MinHeight = 520;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(16) };
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 0) };
        DockPanel.SetDock(status, Dock.Bottom); panel.Children.Add(status);
        var top = new StackPanel(); DockPanel.SetDock(top, Dock.Top); panel.Children.Add(top);
        top.Children.Add(new TextBlock { Text = "Articles et stock", FontSize = 26, FontWeight = FontWeights.SemiBold });
        top.Children.Add(new TextBlock { Text = "Sélectionnez un article pour modifier sa fiche ou son stock.", Margin = new Thickness(0,6,0,6) });
        var query = new TextBox { MinHeight = 40, MaxLength = 255, Margin = new Thickness(0, 8, 0, 6) };
        System.Windows.Automation.AutomationProperties.SetName(query, "Rechercher par nom, code-barres ou référence");
        top.Children.Add(new TextBlock { Text = "Nom, code-barres ou référence" }); top.Children.Add(query);
        var filters = new WrapPanel { Margin = new Thickness(0, 0, 0, 6) }; top.Children.Add(filters);
        var family = new ComboBox { MinWidth = 180, MinHeight = 36, Margin = new Thickness(0, 0, 12, 0) };
        System.Windows.Automation.AutomationProperties.SetName(family, "Famille du stock");
        family.ItemsSource = new[] { "Toutes les familles" }.Concat(reader.Families(access)).ToArray(); family.SelectedIndex = 0; filters.Children.Add(family);
        CheckBox Filter(string text) { var box = new CheckBox { Content = text, VerticalAlignment = VerticalAlignment.Center, Margin = new Thickness(0, 0, 14, 0) }; filters.Children.Add(box); return box; }
        var exact = Filter("Recherche exacte"); var ignoreZero = Filter("Ignorer les stocks à zéro"); var alerts = Filter("Alertes stock"); var negative = Filter("Stocks négatifs");
        var actions = new WrapPanel { Margin = new Thickness(0, 0, 0, 8) }; top.Children.Add(actions);
        Button ActionButton(string text) { var button = new Button { Content = text, MinHeight = 40, Padding = new Thickness(12, 4, 12, 4), Margin = new Thickness(0, 0, 8, 0) }; actions.Children.Add(button); return button; }
        var find = ActionButton("Rechercher / Actualiser"); var card = ActionButton("Modifier la fiche article"); card.Visibility = hooks.OpenArticle is null ? Visibility.Collapsed : Visibility.Visible;
        var adjust=ActionButton("Augmenter / diminuer le stock");adjust.Visibility=hooks.AdjustStock is null?Visibility.Collapsed:Visibility.Visible;
        System.Windows.Automation.AutomationProperties.SetName(adjust,"Modifier le stock de l’article");
        void Hook(string text, Action? action)
        {
            if (action is null) return;
            var button = ActionButton(text); button.Click += (_, _) => { try { reader.Recheck(access); action(); Load(); } catch (Exception ex) { status.Text = ex.Message; } };
        }
        var tabs = new TabControl(); panel.Children.Add(tabs);
        var stockTab = new TabItem { Header = "Stock actuel" }; var historyTab = new TabItem { Header = "Mouvements de l’article" }; tabs.Items.Add(stockTab); tabs.Items.Add(historyTab);
        var grid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false, RowHeight = 38,
            SelectionMode = DataGridSelectionMode.Single, SelectionUnit = DataGridSelectionUnit.FullRow };
        System.Windows.Automation.AutomationProperties.SetName(grid, "Articles et stocks trouvés");
        foreach (var (caption, binding) in new[] { ("Code-barres", "Code"), ("Article", "Name"), ("Famille", "Family"), ("Référence", "Reference"), ("Stock", "Stock"), ("Alerte", "Alert"), ("Prix achat", "Cost"), ("Prix vente", "Price"), ("État", "State") })
            grid.Columns.Add(new DataGridTextColumn { Header = caption, Binding = new Binding(binding), Width = new DataGridLength(binding == "Name" ? 2 : 1, DataGridLengthUnitType.Star) });
        stockTab.Content = grid;
        var historyPanel = new DockPanel { Margin = new Thickness(8) }; historyTab.Content = historyPanel;
        var historyTop = new StackPanel(); DockPanel.SetDock(historyTop, Dock.Top); historyPanel.Children.Add(historyTop);
        var selected = new TextBlock { Text = "Sélectionnez un article dans le stock actuel.", FontSize = 18, FontWeight = FontWeights.SemiBold, TextWrapping = TextWrapping.Wrap }; historyTop.Children.Add(selected);
        var dates = new WrapPanel { Margin = new Thickness(0, 8, 0, 8) }; historyTop.Children.Add(dates);
        dates.Children.Add(new TextBlock { Text = "Du", VerticalAlignment = VerticalAlignment.Center, Margin = new Thickness(0, 0, 6, 0) });
        var first = new DatePicker { SelectedDate = DateTime.Today.AddDays(-30), Width = 150, MinHeight = 36 }; dates.Children.Add(first);
        dates.Children.Add(new TextBlock { Text = "au", VerticalAlignment = VerticalAlignment.Center, Margin = new Thickness(8, 0, 6, 0) });
        var last = new DatePicker { SelectedDate = DateTime.Today, Width = 150, MinHeight = 36 }; dates.Children.Add(last);
        var movements = new Button { Content = "Afficher les mouvements", MinHeight = 38, Padding = new Thickness(10, 4, 10, 4), Margin = new Thickness(8, 0, 0, 0), IsEnabled = false }; dates.Children.Add(movements);
        historyTop.Children.Add(new TextBlock { Text = "Quantités telles qu’enregistrées dans le journal LOGICA. Le stock actuel est relu dans la fiche article.", TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 0, 0, 8) });
        var journal = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false, RowHeight = 36, MinColumnWidth = 80 };
        System.Windows.Automation.AutomationProperties.SetName(journal, "Journal des mouvements de l’article");
        foreach (var (caption, binding) in new[] { ("Date", "Date"), ("Heure", "Time"), ("Libellé", "Label"), ("Code", "Code"), ("Article", "ArticleName"), ("Quantité enregistrée", "RecordedQuantity") })
            journal.Columns.Add(new DataGridTextColumn { Header = caption, Binding = new Binding(binding), MinWidth = binding is "Label" or "ArticleName" ? 180 : 80,
                Width = binding switch { "Date" => new DataGridLength(155), "Time" => new DataGridLength(90), "Code" => new DataGridLength(90),
                    "RecordedQuantity" => new DataGridLength(140), _ => new DataGridLength(1, DataGridLengthUnitType.Star) } });
        historyPanel.Children.Add(journal);
        void Selection()
        {
            var row = grid.SelectedItem as DailyStockReader.Article; adjust.IsEnabled = card.IsEnabled = movements.IsEnabled = row is { CanonicalIdentity: true };
            selected.Text = row is null ? "Sélectionnez un article dans le stock actuel." : $"{row.Name} · {row.Code} · Stock : {row.Stock:0.###}";
            journal.ItemsSource = null;
        }
        void Invalidate() { grid.ItemsSource = null; journal.ItemsSource = null; Selection(); status.Text = "Filtres modifiés : relancez la recherche."; }
        void Load()
        {
            var previousRow = (grid.SelectedItem as DailyStockReader.Article)?.RowId;
            Invalidate(); tabs.SelectedItem = stockTab;
            try
            {
                var result = reader.Search(access, new DailyStockReader.Query(query.Text.Trim(), exact.IsChecked == true, family.SelectedIndex <= 0 ? "" : family.SelectedItem as string ?? "",
                    ignoreZero.IsChecked == true, alerts.IsChecked == true, negative.IsChecked == true));
                grid.ItemsSource = result.Articles;
                if (previousRow.HasValue) grid.SelectedItem = result.Articles.SingleOrDefault(article => article.RowId == previousRow);
                if (grid.SelectedItem is null && result.Articles.Length == 1) grid.SelectedIndex = 0;
                status.Text = result.HasMore ? "Plus de200 articles : précisez les filtres pour consulter la suite." : $"{result.Articles.Length} article(s) · stock relu à {DateTime.Now:HH:mm:ss}.";
            }
            catch (Exception ex) { status.Text = ex.Message; }
        }
        query.TextChanged += (_, _) => Invalidate(); family.SelectionChanged += (_, _) => Invalidate();
        foreach (var filter in new[] { exact, ignoreZero, alerts, negative }) { filter.Checked += (_, _) => Invalidate(); filter.Unchecked += (_, _) => Invalidate(); }
        grid.SelectionChanged += (_, _) => Selection(); find.Click += (_, _) => Load();
        query.KeyDown += (_, args) => { if (args.Key == System.Windows.Input.Key.Enter) { args.Handled = true; Load(); } };
        grid.MouseDoubleClick += (_, _) => { if (card.IsEnabled) card.RaiseEvent(new RoutedEventArgs(Button.ClickEvent)); };
        card.Click += (_, _) => { if (grid.SelectedItem is not DailyStockReader.Article row) return; try { reader.Recheck(access); hooks.OpenArticle?.Invoke(row); Load(); } catch (Exception ex) { status.Text = ex.Message; } };
        adjust.Click+=(_,_)=>{if(grid.SelectedItem is not DailyStockReader.Article row)return;try{reader.Recheck(access);hooks.AdjustStock?.Invoke(row);Load();}catch(Exception ex){status.Text=ex.Message;}};
        movements.Click += (_, _) =>
        {
            journal.ItemsSource = null;
            try
            {
                if (grid.SelectedItem is not DailyStockReader.Article row || first.SelectedDate is not DateTime from || last.SelectedDate is not DateTime to) return;
                var result = reader.Movements(access, row, from, to); journal.ItemsSource = result.Movements;
                selected.Text = $"{result.Current.Name} · {result.Current.Code} · Stock actuel relu : {result.Current.Stock:0.###}";
                tabs.SelectedItem = historyTab; status.Text = result.HasMore ? "Plus de500 mouvements : réduisez la période." : $"{result.Movements.Length} mouvement(s) pour cet article.";
            }
            catch (Exception ex) { status.Text = ex.Message; }
        };
        first.SelectedDateChanged += (_, _) => journal.ItemsSource = null; last.SelectedDateChanged += (_, _) => journal.ItemsSource = null;
        Hook("Ajouter un article", hooks.NewArticle);
        if (hooks.NewArticle is not null) { var addArticle = actions.Children[actions.Children.Count - 1]; actions.Children.Remove(addArticle); actions.Children.Insert(0, addArticle); }
        Hook("Inventaire physique", hooks.OpenInventory); Hook("Réceptions", hooks.OpenReceipts); Hook("Bons de sortie / Avoirs", hooks.OpenStockIssues);
        Hook("Catalogue et prix", hooks.OpenCatalogue);
        Content = panel; Selection(); Loaded += (_, _) => Load();
    }
}
