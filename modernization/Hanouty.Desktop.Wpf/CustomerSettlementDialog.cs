using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Wpf;

public sealed record CustomerSettlementRequest(
    string OperationId, string CustomerId, decimal Amount, string PaymentMode, string Notes);

public sealed class CustomerSettlementDialog : Window
{
    private readonly TextBox amount = new() { MinWidth = 180 };
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
        if (string.IsNullOrWhiteSpace(customer.CustomerId) || string.IsNullOrWhiteSpace(customer.Customer))
            throw new ArgumentException("Le client sélectionné est incomplet.", nameof(customer));
        Title = "Règlement client";
        Width = 380;
        SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(new TextBlock { Text = customer.Customer, FontSize = 18 });
        panel.Children.Add(new TextBlock { Text = "Reliquat affiché : " +
            customer.Balance.ToString("N2", CultureInfo.CurrentCulture) + " DH" });
        panel.Children.Add(new Label { Content = "Montant", Target = amount });
        panel.Children.Add(amount);
        panel.Children.Add(new Label { Content = "Mode de paiement", Target = mode });
        mode.ItemsSource = paymentModes;
        panel.Children.Add(mode);
        panel.Children.Add(new Label { Content = "Notes", Target = notes });
        panel.Children.Add(notes);
        panel.Children.Add(feedback);
        panel.Children.Add(save);
        Content = panel;
        save.Click += (_, _) =>
        {
            if (posting || committed) return;
            if (submittedRequest is null)
            {
                if (!decimal.TryParse(amount.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var value) || value <= 0)
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
