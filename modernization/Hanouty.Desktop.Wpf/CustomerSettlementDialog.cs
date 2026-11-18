using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Wpf;

public sealed record CustomerSettlementRequest(
    string OperationId, string CustomerId, decimal Amount, string PaymentMode, string Notes);

public sealed class CustomerSettlementDialog : Window
{
    private readonly TextBox amount = new() { MinWidth = 180, IsReadOnly = true };
    private readonly ComboBox mode = new() { MinWidth = 180 };
    private readonly TextBox notes = new() { MinHeight = 60, AcceptsReturn = true };
    private readonly TextBlock feedback = new() { TextWrapping = TextWrapping.Wrap };
    private readonly Button save = new() { Content = "Enregistrer", MinHeight = 36 };
    private readonly string operationId = Guid.NewGuid().ToString("N");
    private bool posting;
    private bool committed;
    private CustomerSettlementRequest? submittedRequest;

    public CustomerSettlementDialog(CustomerCreditStatementRow customer, IReadOnlyList<string> paymentModes,
        Func<CustomerSettlementRequest, bool> submit)
    {
        ArgumentNullException.ThrowIfNull(customer);
        ArgumentNullException.ThrowIfNull(paymentModes);
        ArgumentNullException.ThrowIfNull(submit);
        Title = "Règlement client";
        Width = 440;
        MaxHeight = SystemParameters.WorkArea.Height;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(new TextBlock { Text = customer.Customer, FontSize = 18 });
        panel.Children.Add(new TextBlock { Text = "Reliquat affiché : " +
            customer.Balance.ToString("N2", CultureInfo.CurrentCulture) + " DH" });
        panel.Children.Add(new Label { Content = "Montant", Target = amount });
        panel.Children.Add(amount);
        // Same numeric key order and cash denominations as LOGICA's FormDialog_calc.
        var numeric = new System.Windows.Controls.Primitives.UniformGrid { Columns = 3 };
        foreach (var key in new[] { "7", "8", "9", "4", "5", "6", "1", "2", "3", ".", "0", "⌫" })
        {
            var button = new Button { Content = key, MinHeight = 40, Margin = new Thickness(2) };
            button.Click += (_, _) =>
            {
                if (submittedRequest is not null || posting) return;
                var separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                var input = amount.Text;
                if (key == "⌫") { if (input.Length > 0) amount.Text = input[..^1]; return; }
                if (key == ".")
                {
                    if (!input.Contains(separator)) amount.Text = (input.Length == 0 ? "0" : input) + separator;
                    return;
                }
                var next = input == "0" ? key : input + key;
                var decimalAt = next.IndexOf(separator, StringComparison.Ordinal);
                if ((decimalAt < 0 || next.Length - decimalAt - separator.Length <= 2) &&
                    decimal.TryParse(next, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out _))
                    amount.Text = next;
            };
            numeric.Children.Add(button);
        }
        panel.Children.Add(numeric);
        var cash = new System.Windows.Controls.Primitives.UniformGrid { Columns = 3 };
        foreach (var denomination in new[] { 200m, 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.5m })
        {
            var button = new Button { Content = denomination.ToString("0.##", CultureInfo.CurrentCulture) + " DH",
                MinHeight = 40, Margin = new Thickness(2) };
            button.Click += (_, _) =>
            {
                if (submittedRequest is not null || posting) return;
                decimal.TryParse(amount.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out var current);
                if (current <= decimal.MaxValue - denomination)
                    amount.Text = (current + denomination).ToString("0.##", CultureInfo.CurrentCulture);
            };
            cash.Children.Add(button);
        }
        panel.Children.Add(cash);
        panel.Children.Add(new Label { Content = "Mode de paiement", Target = mode });
        mode.ItemsSource = paymentModes;
        panel.Children.Add(mode);
        panel.Children.Add(new Label { Content = "Notes", Target = notes });
        panel.Children.Add(notes);
        panel.Children.Add(feedback);
        panel.Children.Add(save);
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
        save.Click += (_, _) =>
        {
            if (posting || committed) return;
            if (submittedRequest is null)
            {
                if (!decimal.TryParse(amount.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var value) || value <= 0 || decimal.Round(value, 2) != value)
                {
                    feedback.Text = "Veuillez remplir le champ -MONTANT- ";
                    return;
                }
                if (mode.SelectedItem is not string paymentMode || string.IsNullOrWhiteSpace(paymentMode))
                {
                    feedback.Text = "Veuillez remplir le champ -MODE_P- ";
                    return;
                }
                submittedRequest = new CustomerSettlementRequest(operationId, customer.CustomerId,
                    value, paymentMode, notes.Text);
            }
            posting = true;
            save.IsEnabled = false;
            try
            {
                amount.IsReadOnly = true;
                mode.IsEnabled = false;
                notes.IsReadOnly = true;
                committed = submit(submittedRequest);
                if (committed) { DialogResult = true; }
                else { feedback.Text = "Le règlement reste à confirmer. Réessayez avec la même opération."; }
            }
            catch (Exception)
            {
                feedback.Text = "Impossible de confirmer le règlement. Actualisez son état avant de réessayer.";
            }
            finally
            {
                posting = false;
                save.IsEnabled = !committed;
            }
        };
    }
}
