using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class StockIssueDialog : Window
{
    internal StockIssueDialog(StockIssueValidation service, string actor, Func<string> readPin)
    {
        Title = "Bons de sortie";
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        Width = 850;
        Height = 460;
        var panel = new DockPanel { Margin = new Thickness(16) };
        var input = new StackPanel();
        DockPanel.SetDock(input, Dock.Top);
        var number = new TextBox { MinHeight = 34 };
        var open = new Button { Content = "Ouvrir le bon", MinHeight = 36 };
        input.Children.Add(new Label { Content = "N° du bon de sortie", Target = number });
        input.Children.Add(number);
        input.Children.Add(open);
        var history = new Button { Content = "Historique du bon", MinHeight = 36 };
        input.Children.Add(history);
        var create = new Button { Content = "Nouveau bon", MinHeight = 36 };
        input.Children.Add(create);
        create.Click += (_, _) =>
        {
            try
            {
                var editor = new StockIssueCreateDialog(service, actor, readPin) { Owner = this };
                if (editor.ShowDialog() == true && editor.DocumentId is { } id)
                {
                    number.Text = id;
                    open.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                }
            }
            catch (Exception ex) when (ex is InvalidOperationException or MySqlException)
            { MessageBox.Show(this, ex.Message, Title); }
        };
        var status = new TextBlock { Margin = new Thickness(0, 8, 0, 8), TextWrapping = TextWrapping.Wrap };
        input.Children.Add(status);
        panel.Children.Add(input);

        var validate = new Button { Content = "Valider", MinHeight = 38, IsEnabled = false };
        DockPanel.SetDock(validate, Dock.Bottom);
        panel.Children.Add(validate);
        var grid = new DataGrid { IsReadOnly = true, AutoGenerateColumns = false, CanUserAddRows = false };
        grid.Columns.Add(new DataGridTextColumn { Header = "Réf. article", Binding = new Binding(nameof(StockIssueValidation.Line.ArticleId)) });
        grid.Columns.Add(new DataGridTextColumn { Header = "Code", Binding = new Binding("Code") });
        grid.Columns.Add(new DataGridTextColumn { Header = "Article", Binding = new Binding("Article"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        grid.Columns.Add(new DataGridTextColumn { Header = "Qté", Binding = new Binding("Quantity") });
        panel.Children.Add(grid);
        Content = panel;

        StockIssueValidation.Document? reviewed = null;
        var movementColumns = new[]
        {
            new DataGridTextColumn { Header = "Stock avant", Binding = new Binding(nameof(StockIssueValidation.Movement.StockBefore)) },
            new DataGridTextColumn { Header = "Stock après", Binding = new Binding(nameof(StockIssueValidation.Movement.StockAfter)) }
        };
        void Reset()
        {
            reviewed = null;
            grid.ItemsSource = null;
            status.Text = "";
            foreach (var column in movementColumns)
                grid.Columns.Remove(column);
            validate.IsEnabled = false;
        }

        number.TextChanged += (_, _) => Reset();
        open.Click += (_, _) =>
        {
            Reset();
            try
            {
                reviewed = service.ReadForValidation(number.Text.Trim());
                grid.ItemsSource = reviewed.Lines;
                status.Text = string.IsNullOrWhiteSpace(reviewed.Notes)
                    ? reviewed.Type
                    : $"{reviewed.Type} · {reviewed.Notes}";
                if (reviewed.Type == "AVOIR")
                    status.Text += CreditSummary(reviewed);
                validate.IsEnabled = true;
            }
            catch (Exception ex) when (ex is InvalidOperationException or MySqlException)
            { MessageBox.Show(this, ex.Message, Title); }
        };
        static string CreditSummary(StockIssueValidation.Document document)
        {
            var amount = document.PurchaseTotal is decimal total
                ? $"Total net d’achat enregistré : {total:0.00#}"
                : "Total net d’achat non renseigné.";
            return $"\nFournisseur : {document.SupplierName} [{document.SupplierId}]\n{amount}";
        }

        void ShowMovements(StockIssueValidation.Movement[] movements)
        {
            foreach (var column in movementColumns)
                grid.Columns.Add(column);
            grid.ItemsSource = movements;
            var movement = movements[0];
            status.Text = movement.ValidatedUtc is DateTime validatedUtc
                ? $"Bon {movement.Reference} validé par {movement.Actor} le {validatedUtc.ToLocalTime():g}\nMotif : {movement.Reason}"
                : $"Bon {movement.Reference} · Journal LOGICA. Utilisateur, motif et stocks avant/après non enregistrés.";
        }

        history.Click += (_, _) =>
        {
            Reset();
            try
            {
                var movements = service.ReadHistory(number.Text.Trim());
                if (movements.Length == 0)
                {
                    status.Text = "Aucun mouvement enregistré pour ce bon.";
                    return;
                }
                ShowMovements(movements);
            }
            catch (Exception ex) when (ex is InvalidOperationException or MySqlException)
            { MessageBox.Show(this, ex.Message, Title); }
        };
        validate.Click += (_, _) =>
        {
            if (reviewed is not { } document) return;
            var id = number.Text.Trim();
            var confirmation = $"Voulez-vous vraiment valider le bon n° {id} ?";
            if (document.Type == "AVOIR")
                confirmation += CreditSummary(document);
            if (MessageBox.Show(this, confirmation, Title,
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            var pin = readPin();
            if (pin.Length == 0) return;
            try
            {
                var result = service.Validate(id, document, actor, pin);
                Reset();
                ShowMovements(result.Movements);
                if (document.Type == "AVOIR")
                    status.Text += CreditSummary(document);
                if (!result.HistorySaved)
                    status.Text += "\nL’historique détaillé n’est pas installé sur cette base.";
            }
            catch (Exception ex) when (ex is InvalidOperationException or UnauthorizedAccessException or MySqlException)
            {
                Reset();
                MessageBox.Show(this, ex.Message, Title);
            }
        };
    }
}
