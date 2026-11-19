using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CataloguePriceDialog : Window
{
    private static string? SelectWorkbook(Window owner)
    {
        var picker = new Microsoft.Win32.OpenFileDialog { Filter = "Excel (*.xlsx)|*.xlsx" };
        return picker.ShowDialog(owner) == true ? picker.FileName : null;
    }

    internal CataloguePriceDialog(CataloguePriceEditor service, Func<CataloguePriceEditor.Price, decimal, bool> save,
        Func<string, string, string, decimal, string?, string?> create,
        Func<CataloguePriceEditor.Card, string, string, string, CataloguePriceEditor.CardDetails, bool> saveCard,
        Func<IReadOnlyList<CataloguePriceEditor.ImportLine>, int?> import, Func<Window, string?>? selectImportFile = null)
    {
        Title = "Prix du catalogue";
        Width = 460;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(20) };
        var id = new TextBox { MinHeight = 36, IsReadOnly = true, Visibility = Visibility.Collapsed };
        var price = new TextBox { MinHeight = 36, IsEnabled = false };
        System.Windows.Automation.AutomationProperties.SetName(id, "Identifiant de l’article");
        System.Windows.Automation.AutomationProperties.SetName(price, "Nouveau prix de vente");
        var open = new Button { Content = "Lire le prix", MinHeight = 36, Margin = new Thickness(0, 6, 0, 8) };
        var write = new Button { Content = "Enregistrer le prix", MinHeight = 36, Margin = new Thickness(0, 6, 0, 0), IsEnabled = false };
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 0) };
        var search = new TextBox { MinHeight = 40, MaxLength = 128 };
        System.Windows.Automation.AutomationProperties.SetName(search, "Rechercher un article par nom ou code-barres");
        var exact = new CheckBox { Content = "Correspondance exacte", Margin = new Thickness(0, 6, 0, 6) };
        System.Windows.Automation.AutomationProperties.SetName(exact, "Recherche exacte du catalogue");
        var find = new Button { Content = "Rechercher les articles", MinHeight = 40 };
        var choices = new ListBox { MinHeight = 80, MaxHeight = 160, DisplayMemberPath = "Label",
            Margin = new Thickness(0, 6, 0, 6) };
        System.Windows.Automation.AutomationProperties.SetName(choices, "Articles trouvés");
        var selected = new TextBlock { Text = "Sélectionnez un article dans les résultats.", TextWrapping = TextWrapping.Wrap };
        panel.Children.Add(new TextBlock { Text = "Nom ou code-barres" });
        panel.Children.Add(search);
        panel.Children.Add(exact);
        panel.Children.Add(find);
        panel.Children.Add(choices);
        panel.Children.Add(selected);
        void RevokeSelection()
        {
            choices.ItemsSource = null;
            id.Clear();
            price.Clear();
            selected.Text = "Sélectionnez un article dans les résultats.";
        }
        void Find()
        {
            RevokeSelection();
            try
            {
                var result = service.Search(search.Text, exact.IsChecked == true);
                choices.ItemsSource = result.Articles;
                status.Text = result.HasMore ? "Plus de 50 articles : précisez la recherche." :
                    result.Articles.Count == 0 ? "Aucun article trouvé." : $"{result.Articles.Count} article(s). Sélectionnez la variante souhaitée.";
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or ArgumentException)
            { status.Text = ex is ArgumentException or InvalidOperationException ? ex.Message : "Recherche indisponible."; }
        }
        search.TextChanged += (_, _) => RevokeSelection();
        exact.Checked += (_, _) => RevokeSelection();
        exact.Unchecked += (_, _) => RevokeSelection();
        find.Click += (_, _) => Find();
        search.KeyDown += (_, args) =>
        {
            if (args.Key == System.Windows.Input.Key.Enter) { args.Handled = true; Find(); }
        };
        choices.SelectionChanged += (_, _) =>
        {
            if (choices.SelectedItem is not CataloguePriceEditor.ArticleChoice choice) return;
            id.Text = choice.Id;
            selected.Text = choice.Label;
            open.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        };
        Hanouty.Desktop.Wpf.TouchNumericEntry.Attach(price, "Prix de vente (MAD)", allowZero: true);
        panel.Children.Add(id);
        panel.Children.Add(open);
        panel.Children.Add(new TextBlock { Text = "Prix de vente (MAD)" });
        panel.Children.Add(price);
        panel.Children.Add(write);
        panel.Children.Add(status);
        var importButton = new Button { Content = "Importer les articles Excel", MinHeight = 36,
            Margin = new Thickness(0, 8, 0, 0) };
        panel.Children.Add(importButton);
        importButton.Click += (_, _) =>
        {
            var file = (selectImportFile ?? SelectWorkbook)(this);
            if (file is not null) ReviewImport(file);
        };

        void ReviewImport(string file)
        {
            try
            {
                var lines = CatalogueWorkbook.Read(file);
                var review = new Window
                {
                    Title = "Vérifier les articles à importer", Owner = this, Width = 800, Height = 520,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                var layout = new DockPanel { Margin = new Thickness(16) };
                var confirm = new Button { Content = $"Importer {lines.Count} article(s)", MinHeight = 42,
                    Margin = new Thickness(0, 8, 0, 0) };
                DockPanel.SetDock(confirm, Dock.Bottom);
                layout.Children.Add(confirm);
                layout.Children.Add(new DataGrid
                {
                    ItemsSource = lines, IsReadOnly = true, CanUserAddRows = false
                });
                confirm.Click += (_, _) => review.DialogResult = true;
                review.Content = layout;
                if (review.ShowDialog() != true) return;
                var count = import(lines);
                if (count.HasValue) status.Text = $"{count.Value} article(s) importé(s).";
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            {
                status.Text = ex is ArgumentException or System.IO.InvalidDataException or UnauthorizedAccessException or InvalidOperationException
                    ? ex.Message : "Import non confirmé. Vérifiez le fichier et le catalogue.";
            }
        }
        var card = new Expander { Header = "Nouvel article", Margin = new Thickness(0, 14, 0, 0) };
        var fields = new StackPanel { Margin = new Thickness(0, 8, 0, 0) };
        TextBox Field(string label)
        {
            fields.Children.Add(new TextBlock { Text = label });
            var field = new TextBox { MinHeight = 32, Margin = new Thickness(0, 2, 0, 6) };
            System.Windows.Automation.AutomationProperties.SetName(field, label);
            fields.Children.Add(field);
            return field;
        }
        var name = Field("Nom du nouvel article");
        var code = Field("Code-barres du nouvel article");
        IReadOnlyList<string> families;
        try { families = service.ReadFamilies(); }
        catch (MySqlException)
        {
            families = Array.Empty<string>();
            status.Text = "Liste des familles indisponible.";
        }

        ComboBox FamilyField(Panel parent, string label)
        {
            parent.Children.Add(new TextBlock { Text = label });
            var field = new ComboBox { ItemsSource = families, MinHeight = 32, Margin = new Thickness(0, 2, 0, 6) };
            System.Windows.Automation.AutomationProperties.SetName(field, label);
            parent.Children.Add(field);
            return field;
        }
        var family = FamilyField(fields, "Famille du nouvel article");
        var newPrice = Field("Prix du nouvel article");
        Hanouty.Desktop.Wpf.TouchNumericEntry.Attach(newPrice, "Prix du nouvel article (MAD)", allowZero: true);
        var variant = Field("Identifiant de l’article source (variante, facultatif)");
        var add = new Button { Content = "Créer l’article", MinHeight = 36 };
        add.Click += (_, _) =>
        {
            if (!decimal.TryParse(newPrice.Text.Trim().Replace(',', '.'), NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out var amount) || amount < 0 || decimal.Round(amount, 2) != amount)
            {
                status.Text = "Saisissez un prix à deux décimales.";
                return;
            }
            add.IsEnabled = false;
            try
            {
                var articleId = create(name.Text.Trim(), code.Text.Trim(), family.SelectedItem as string ?? "", amount,
                    string.IsNullOrWhiteSpace(variant.Text) ? null : variant.Text.Trim());
                if (articleId is not null)
                {
                    RevokeSelection();
                    id.Text = articleId;
                    selected.Text = name.Text + " · " + amount.ToString("N2") + " MAD";
                    status.Text = $"Article {articleId} créé.";
                    name.Clear();
                    code.Clear();
                    family.SelectedIndex = -1;
                    newPrice.Clear();
                    variant.Clear();
                }
            }
            catch (UnauthorizedAccessException)
            {
                status.Text = "Création réservée à un administrateur authentifié.";
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or ArgumentException)
            {
                status.Text = ex is InvalidOperationException or ArgumentException ? ex.Message : "Création non confirmée.";
            }
            finally { add.IsEnabled = true; }
        };
        fields.Children.Add(add);
        card.Content = fields;
        panel.Children.Add(card);
        var edit = new Expander { Header = "Modifier la fiche", Margin = new Thickness(0, 14, 0, 0) };
        var editFields = new StackPanel { Margin = new Thickness(0, 8, 0, 0) };
        var readCard = new Button { Content = "Charger la fiche", MinHeight = 36 };
        editFields.Children.Add(readCard);
        TextBox EditField(string label)
        {
            editFields.Children.Add(new TextBlock { Text = label });
            var field = new TextBox { MinHeight = 32, Margin = new Thickness(0, 2, 0, 6) };
            System.Windows.Automation.AutomationProperties.SetName(field, label);
            editFields.Children.Add(field);
            return field;
        }
        var editName = EditField("Nom de la fiche");
        var editCode = EditField("Code-barres de la fiche");
        var editFamily = FamilyField(editFields, "Famille de la fiche");
        var description = EditField("Description");
        var reference = EditField("Référence");
        var unit = EditField("Unité");
        var location = EditField("Emplacement");
        var apply = new Button { Content = "Enregistrer la fiche", MinHeight = 36, IsEnabled = false };
        editFields.Children.Add(apply);
        edit.Content = editFields;
        panel.Children.Add(edit);
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
        MaxHeight = SystemParameters.WorkArea.Height;

        CataloguePriceEditor.Card? reviewedCard = null;
        id.TextChanged += (_, _) => { reviewedCard = null; apply.IsEnabled = false; };
        readCard.Click += (_, _) =>
        {
            reviewedCard = null;
            apply.IsEnabled = false;
            try
            {
                reviewedCard = service.ReadCard(id.Text.Trim());
                editName.Text = reviewedCard.Name;
                editCode.Text = reviewedCard.Barcode;
                editFamily.ItemsSource = families.Contains(reviewedCard.Family, StringComparer.Ordinal)
                    ? families : families.Append(reviewedCard.Family).ToArray();
                editFamily.SelectedItem = reviewedCard.Family;
                description.Text = reviewedCard.Details.Description;
                reference.Text = reviewedCard.Details.Reference;
                unit.Text = reviewedCard.Details.Unit;
                location.Text = reviewedCard.Details.Location;
                apply.IsEnabled = true;
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException)
            { status.Text = "Fiche article indisponible."; }
        };
        apply.Click += (_, _) =>
        {
            if (reviewedCard is not { } current) return;
            apply.IsEnabled = false;
            try
            {
                var details = new CataloguePriceEditor.CardDetails(description.Text.Trim(), reference.Text.Trim(),
                    unit.Text.Trim(), location.Text.Trim());
                if (saveCard(current, editName.Text.Trim(), editCode.Text.Trim(),
                    editFamily.SelectedItem as string ?? current.Family, details))
                {
                    reviewedCard = null;
                    status.Text = $"Fiche {current.Id} enregistrée.";
                }
                else apply.IsEnabled = true;
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or ArgumentException or UnauthorizedAccessException)
            {
                reviewedCard = null;
                status.Text = ex is ArgumentException or InvalidOperationException or UnauthorizedAccessException
                    ? ex.Message : "Modification non confirmée. Rechargez la fiche.";
            }
        };

        CataloguePriceEditor.Price? reviewed = null;
        void Reset(string message)
        {
            reviewed = null;
            price.IsEnabled = false;
            write.IsEnabled = false;
            status.Text = message;
        }
        id.TextChanged += (_, _) => Reset("");
        open.Click += (_, _) =>
        {
            Reset("");
            try
            {
                reviewed = service.Read(id.Text.Trim());
                price.Text = reviewed.Amount.ToString("0.00", CultureInfo.CurrentCulture);
                status.Text = reviewed.Name;
                selected.Text = reviewed.Name + " · " + reviewed.Amount.ToString("N2") + " MAD";
                price.IsEnabled = true;
                write.IsEnabled = true;
            }
            catch (Exception ex) when (ex is ArgumentException or MySqlException or InvalidOperationException)
            {
                Reset("Article ou prix indisponible.");
            }
        };
        write.Click += (_, _) =>
        {
            if (reviewed is not { } snapshot ||
                !decimal.TryParse(price.Text.Trim().Replace(',', '.'), NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture, out var amount) ||
                amount < 0 || decimal.Round(amount, 2) != amount)
            {
                status.Text = "Saisissez un prix positif ou nul, à deux décimales.";
                return;
            }
            write.IsEnabled = false;
            try
            {
                if (save(snapshot, amount))
                    Reset($"Prix de {snapshot.Name} enregistré : {amount:N2} MAD.");
                else write.IsEnabled = true;
            }
            catch (UnauthorizedAccessException)
            {
                Reset("Modification réservée à un administrateur authentifié.");
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException)
            {
                Reset("Modification non confirmée. Relisez le prix avant de réessayer.");
            }
        };
    }
}
