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
        Width = 620;
        Height = 410;
        var panel = new DockPanel { Margin = new Thickness(16) };
        var input = new StackPanel();
        DockPanel.SetDock(input, Dock.Top);
        var number = new TextBox { MinHeight = 34 };
        var open = new Button { Content = "Ouvrir le bon", MinHeight = 36 };
        input.Children.Add(new Label { Content = "N° du bon de sortie", Target = number });
        input.Children.Add(number);
        input.Children.Add(open);
        panel.Children.Add(input);

        var validate = new Button { Content = "Valider", MinHeight = 38, IsEnabled = false };
        DockPanel.SetDock(validate, Dock.Bottom);
        panel.Children.Add(validate);
        var grid = new DataGrid { IsReadOnly = true, AutoGenerateColumns = false, CanUserAddRows = false };
        grid.Columns.Add(new DataGridTextColumn { Header = "Code", Binding = new Binding("Code") });
        grid.Columns.Add(new DataGridTextColumn { Header = "Article", Binding = new Binding("Article"), Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        grid.Columns.Add(new DataGridTextColumn { Header = "Qté", Binding = new Binding("Quantity") });
        panel.Children.Add(grid);
        Content = panel;

        StockIssueValidation.Line[]? reviewed = null;
        void Reset()
        {
            reviewed = null;
            grid.ItemsSource = null;
            validate.IsEnabled = false;
        }

        number.TextChanged += (_, _) => Reset();
        open.Click += (_, _) =>
        {
            Reset();
            try
            {
                reviewed = service.Read(number.Text.Trim());
                grid.ItemsSource = reviewed;
                validate.IsEnabled = true;
            }
            catch (Exception ex) when (ex is InvalidOperationException or MySqlException)
            { MessageBox.Show(this, ex.Message, Title); }
        };
        validate.Click += (_, _) =>
        {
            if (reviewed is null) return;
            var id = number.Text.Trim();
            if (MessageBox.Show(this, $"Voulez-vous vraiment valider le bon n° {id} ?", Title,
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            var pin = readPin();
            if (pin.Length == 0) return;
            try
            {
                service.Validate(id, reviewed, actor, pin);
                Reset();
                MessageBox.Show(this, "Validé avec succès.", Title);
            }
            catch (Exception ex) when (ex is InvalidOperationException or UnauthorizedAccessException or MySqlException)
            {
                Reset();
                MessageBox.Show(this, ex.Message, Title);
            }
        };
    }
}
