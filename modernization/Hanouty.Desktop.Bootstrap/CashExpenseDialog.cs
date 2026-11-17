using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CashExpenseDialog : Window
{
    public CashExpenseDialog(string cashier, Func<DateTime, string, decimal, long> record)
    {
        Title = "Nouvelle dépense";
        Width = 400;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var fields = new StackPanel { Margin = new Thickness(18) };
        var date = new DatePicker { SelectedDate = DateTime.Today };
        var description = new TextBox();
        var amount = new TextBox();
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 0) };
        var save = new Button { Content = "Enregistrer", IsDefault = true, Margin = new Thickness(0, 12, 0, 0) };

        void AddField(string caption, Control field)
        {
            fields.Children.Add(new Label { Content = caption, Target = field });
            fields.Children.Add(field);
        }

        fields.Children.Add(new TextBlock { Text = cashier, Margin = new Thickness(0, 0, 0, 8) });
        AddField("Date", date);
        AddField("Dépense", description);
        AddField("Montant (MAD)", amount);
        fields.Children.Add(save);
        fields.Children.Add(status);
        fields.Children.Add(new Button { Content = "Fermer", IsCancel = true, Margin = new Thickness(0, 8, 0, 0) });
        Content = fields;

        save.Click += (_, _) =>
        {
            if (!save.IsEnabled) return;
            if (date.SelectedDate is not { } expenseDate || string.IsNullOrWhiteSpace(description.Text) ||
                !decimal.TryParse(amount.Text.Trim().Replace(',', '.'), NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture, out var value) || value <= 0m || decimal.Round(value, 2) != value)
            {
                status.Text = "Renseignez la date, le libellé et un montant positif à deux décimales.";
                return;
            }

            save.IsEnabled = false;
            try
            {
                var number = record(expenseDate, description.Text, value);
                status.Text = $"Dépense n° {number} enregistrée.";
                date.IsEnabled = description.IsEnabled = amount.IsEnabled = false;
            }
            catch (UnauthorizedAccessException)
            {
                status.Text = "Autorisation refusée. Fermez cet écran et vérifiez les droits.";
            }
            catch (Exception ex) when (ex is MySqlException or InvalidOperationException or OverflowException)
            {
                status.Text = "Enregistrement non confirmé. Vérifiez le registre avant toute nouvelle saisie.";
            }
        };
    }
}
