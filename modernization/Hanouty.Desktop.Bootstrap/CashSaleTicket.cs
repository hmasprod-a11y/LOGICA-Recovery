using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal static class CashSaleTicket
{
    public static void Show(Window owner, MySqlConnection connection, string operation, string cashier, string register)
    {
        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT h.TICKET, h.DATES, h.CAISSIER, h.Total_NET, j.Article, j.Qté, j.Total_NET
            FROM TABLE_VENTES_ENTETE h
            JOIN TABLE_VENTES_JOURNAL j ON BINARY j.ID_TICKET = BINARY h.ID_TICKET
            WHERE BINARY h.ID_TICKET = BINARY @id AND BINARY h.CAISSIER = BINARY @cashier
              AND BINARY h.POSTE = BINARY @register AND h.OPERATION = 'VENTE' AND j.OPERATION = 'VENTE'
            ORDER BY j.ID_ARTICLE
            """;
        command.Parameters.AddWithValue("@id", operation);
        command.Parameters.AddWithValue("@cashier", cashier);
        command.Parameters.AddWithValue("@register", register);
        using var reader = command.ExecuteReader();
        if (!reader.Read())
        {
            MessageBox.Show(owner, "Ticket de vente introuvable.", "Ticket");
            return;
        }

        var ticket = Convert.ToString(reader.GetValue(0), CultureInfo.CurrentCulture);
        var document = new FlowDocument { FontFamily = new System.Windows.Media.FontFamily("Consolas"),
            FontSize = 12, PagePadding = new Thickness(12) };
        void Line(string text, bool bold = false) => document.Blocks.Add(new Paragraph(new Run(text))
        {
            Margin = new Thickness(0, 0, 0, 4),
            FontWeight = bold ? FontWeights.Bold : FontWeights.Normal
        });

        Line($"TICKET N° {ticket}", true);
        Line($"{reader.GetValue(1)}  {reader.GetValue(2)}");
        Line("Qté  Article  Montant");
        var total = reader.GetDecimal(3);
        do
            Line($"{reader.GetDecimal(5):0.###}  {reader.GetString(4)}  {reader.GetDecimal(6):N2}");
        while (reader.Read());
        reader.Close();
        connection.Close();
        Line($"TOTAL NET  {total:N2} DH", true);

        var panel = new DockPanel();
        var print = new Button { Content = "Imprimer le ticket", MinHeight = 40, Margin = new Thickness(8) };
        DockPanel.SetDock(print, Dock.Bottom);
        panel.Children.Add(print);
        panel.Children.Add(new FlowDocumentScrollViewer { Document = document, VerticalScrollBarVisibility = ScrollBarVisibility.Auto });
        var preview = new Window { Owner = owner, Title = $"Ticket {ticket}", Width = 400, Height = 500,
            WindowStartupLocation = WindowStartupLocation.CenterOwner, Content = panel };
        print.Click += (_, _) =>
        {
            var printer = new PrintDialog();
            if (printer.ShowDialog() != true) return;
            try
            {
                var paginator = ((IDocumentPaginatorSource)document).DocumentPaginator;
                paginator.PageSize = new Size(printer.PrintableAreaWidth, printer.PrintableAreaHeight);
                printer.PrintDocument(paginator, $"Ticket {ticket}");
            }
            catch (Exception)
            {
                MessageBox.Show(preview, "Impression impossible. Vérifiez l’imprimante et réessayez.", "Ticket");
            }
        };
        preview.ShowDialog();
    }
}
