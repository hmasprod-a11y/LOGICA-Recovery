using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class WorkstationPrinterDialog : Window
{
    internal WorkstationPrinterDialog(CatalogueSettings settings, string register, Action authorize)
    {
        Title = "Paramètres — imprimante du poste " + register;
        Width = 620; Height = 370; MinWidth = 500; MinHeight = 330;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var root = new StackPanel { Margin = new Thickness(22) }; Content = root;
        root.Children.Add(new TextBlock { Text = "Imprimante des tickets", FontSize = 24, FontWeight = FontWeights.SemiBold });
        root.Children.Add(new TextBlock { Text = "Choisissez l’imprimante installée sur ce poste. Le choix est conservé lors des mises à jour.", TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 12, 0, 12) });
        var choices = new List<PrinterChoice> { new("0", "Sans impression"), new("", "Imprimante Windows par défaut") };
        foreach (string name in PrinterSettings.InstalledPrinters) choices.Add(new(name, name));
        var printers = new ComboBox { ItemsSource = choices, DisplayMemberPath = nameof(PrinterChoice.Label), MinHeight = 44, FontSize = 17 };
        System.Windows.Automation.AutomationProperties.SetName(printers, "Imprimante des tickets du poste"); root.Children.Add(printers);
        var existingPath = Path.Combine(WorkstationPrinterProfile.DirectoryFor(settings, register), "PRINTER_CL.sni");
        var existing = File.Exists(existingPath) ? File.ReadAllText(existingPath) : "0";
        printers.SelectedItem = choices.FirstOrDefault(choice => choice.Name == existing);
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 12, 0, 12), Text = printers.SelectedItem is null ? "L’imprimante enregistrée est absente. Choisissez une imprimante disponible." : "Le modèle de ticket et le branchement restent ceux des paramètres LOGICA." };
        root.Children.Add(status);
        var save = new Button { Content = "Enregistrer l’imprimante du poste", MinHeight = 46, IsDefault = true }; root.Children.Add(save);
        var close = new Button { Content = "Fermer", MinHeight = 38, Margin = new Thickness(0, 8, 0, 0), IsCancel = true }; root.Children.Add(close);
        save.Click += (_, _) =>
        {
            try
            {
                if (printers.SelectedItem is not PrinterChoice selected) throw new InvalidOperationException("Choisissez une imprimante.");
                authorize(); // Fresh session/role check immediately before persisting the local setting.
                if (selected.Name is not ("" or "0") && !PrinterSettings.InstalledPrinters.Cast<string>().Contains(selected.Name, StringComparer.Ordinal))
                    throw new InvalidOperationException("Cette imprimante n’est plus disponible.");
                SavePrinter(WorkstationPrinterProfile.ProfileDirectory(settings, register), selected.Name);
                status.Text = "Imprimante enregistrée. Ce choix s’applique aux prochains tickets et aux réimpressions.";
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { status.Text = ex is UnauthorizedAccessException or InvalidOperationException or IOException ? ex.Message : "Enregistrement de l’imprimante impossible."; }
        };
    }
    private sealed record PrinterChoice(string Name, string Label);
    internal static void SavePrinter(string directory, string printer)
    {
        if (printer is null || printer.Length > 255 || printer.Any(char.IsControl)) throw new ArgumentException("Nom d’imprimante invalide.");
        Directory.CreateDirectory(directory);
        var target = Path.Combine(directory, "PRINTER_CL.sni");
        var temporary = Path.Combine(directory, Guid.NewGuid().ToString("N") + ".tmp");
        try
        {
            using (var file = new FileStream(temporary, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                var bytes = Encoding.UTF8.GetBytes(printer); file.Write(bytes); file.Flush(true);
            }
            File.Move(temporary, target, true);
        }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
}
