using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class StockIssueCreateDialog : Window
{
    private sealed record DraftLine(StockIssueValidation.ArticleChoice Article, decimal Quantity)
    {
        public string Label => Article.Label;
    }

    internal string? DocumentId { get; private set; }

    internal StockIssueCreateDialog(StockIssueValidation service, string actor, Func<string> readPin)
    {
        Title = "Nouveau bon de sortie";
        Width = 620;
        Height = 620;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(16) };
        var date = new DatePicker { SelectedDate = DateTime.Today };
        var type = new ComboBox { ItemsSource = new[] { "PERTE", "TRANSFERT", "AUTRE" } };
        var article = new ComboBox { ItemsSource = service.Articles(), DisplayMemberPath = "Label", IsTextSearchEnabled = true };
        var quantity = new TextBox { Text = "1" };
        var notes = new TextBox();
        AddField("Date", date);
        AddField("Type", type);
        AddField("Article", article);
        AddField("Quantité", quantity);
        var lines = new ObservableCollection<DraftLine>();
        var list = new DataGrid { ItemsSource = lines, AutoGenerateColumns = false, IsReadOnly = true,
            Height = 120, CanUserAddRows = false };
        list.Columns.Add(new DataGridTextColumn { Header = "Article", Binding = new System.Windows.Data.Binding("Label"),
            Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        list.Columns.Add(new DataGridTextColumn { Header = "Qté", Binding = new System.Windows.Data.Binding("Quantity") });
        var add = new Button { Content = "Ajouter la ligne", MinHeight = 34 };
        panel.Children.Add(add);
        panel.Children.Add(list);
        var remove = new Button { Content = "Retirer la ligne", MinHeight = 34 };
        panel.Children.Add(remove);
        AddField("Notes", notes);
        var save = new Button { Content = "Enregistrer le bon", MinHeight = 38 };
        panel.Children.Add(save);
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap };
        panel.Children.Add(status);
        Content = new ScrollViewer { Content = panel };

        add.Click += (_, _) =>
        {
            if (article.SelectedItem is not StockIssueValidation.ArticleChoice choice ||
                !decimal.TryParse(quantity.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out var count) ||
                count <= 0 || decimal.Round(count, 2) != count || lines.Any(x => x.Article.Id == choice.Id))
            {
                status.Text = "Choisissez un article distinct et une quantité positive.";
                return;
            }
            status.Text = "";
            lines.Add(new DraftLine(choice, count));
        };
        remove.Click += (_, _) => { if (list.SelectedItem is DraftLine line) lines.Remove(line); };
        save.Click += (_, _) =>
        {
            if (date.SelectedDate is not DateTime selectedDate || type.SelectedItem is not string selectedType || lines.Count == 0)
            {
                status.Text = "Renseignez la date, le type et les articles.";
                return;
            }
            var pin = readPin();
            if (string.IsNullOrEmpty(pin)) return;
            try
            {
                DocumentId = service.Create(selectedDate, selectedType, notes.Text,
                    lines.ToDictionary(line => line.Article.Id, line => line.Quantity, StringComparer.Ordinal), actor, pin);
                DialogResult = true;
            }
            catch (Exception ex) when (ex is InvalidOperationException or UnauthorizedAccessException or MySqlException)
            { status.Text = ex.Message; }
        };

        void AddField(string caption, Control control)
        {
            panel.Children.Add(new Label { Content = caption, Target = control });
            panel.Children.Add(control);
        }
    }
}
