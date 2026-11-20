using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Hanouty.Desktop.Wpf;

public sealed class CustomerFilesDialog : Window
{
    public CustomerFilesDialog(ICustomerFilesWorkflow workflow)
    {
        Title = "Fichiers clients"; Width = 1040; Height = 650; MinWidth = 720; MinHeight = 460;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new DockPanel { Margin = new Thickness(16) };
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 0) };
        DockPanel.SetDock(status, Dock.Bottom); panel.Children.Add(status);
        var top = new StackPanel(); DockPanel.SetDock(top, Dock.Top); panel.Children.Add(top);
        top.Children.Add(new TextBlock { Text = "Fichiers clients", FontSize = 24, FontWeight = FontWeights.SemiBold });
        var search = new TextBox { MinHeight = 40, Margin = new Thickness(0, 8, 0, 8) };
        System.Windows.Automation.AutomationProperties.SetName(search, "Rechercher dans les fichiers clients"); top.Children.Add(search);
        var buttons = new WrapPanel { Margin = new Thickness(0, 0, 0, 8) }; top.Children.Add(buttons);
        Button Add(string label) { var button = new Button { Content = label, MinHeight = 42, Padding = new Thickness(12, 4, 12, 4), Margin = new Thickness(0, 0, 6, 0) }; buttons.Children.Add(button); return button; }
        var refresh = Add("Rechercher"); var create = Add("Nouveau client"); var edit = Add("Modifier le client");
        var opening = Add("Modifier le crédit initial"); var history = Add("Historique du crédit initial");
        var grid = new DataGrid { AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false, RowHeight = 40,
            SelectionMode = DataGridSelectionMode.Single, SelectionUnit = DataGridSelectionUnit.FullRow };
        foreach (var (label, binding) in new[] { ("N° client", "Id"), ("Code", "Details.Code"), ("Client", "Details.Name"),
            ("Téléphone", "Details.Telephone"), ("Ville", "Details.City"), ("Vendeur", "Details.Seller"), ("Crédit initial", "Details.OpeningCredit") })
            grid.Columns.Add(new DataGridTextColumn { Header = label, Binding = new Binding(binding) { StringFormat = binding.EndsWith("OpeningCredit") ? "0.####" : null }, Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
        panel.Children.Add(grid);
        void Selection() => edit.IsEnabled = opening.IsEnabled = history.IsEnabled = grid.SelectedItem is CustomerFile && workflow.Pending is null;
        void Load(string? selected = null)
        {
            grid.ItemsSource = null; Selection();
            try
            {
                var rows = workflow.Search(search.Text); grid.ItemsSource = rows;
                grid.SelectedItem = rows.SingleOrDefault(row => row.Id == selected); status.Text = $"{rows.Count} client(s).";
            }
            catch (Exception ex) { status.Text = ex.Message; }
        }
        void Editor(string kind, CustomerFile? expected)
        {
            var dialog = new CustomerFileEditorDialog(workflow, kind, expected) { Owner = this };
            if (dialog.ShowDialog() == true)
            {
                Load(dialog.Saved?.Id);
                status.Text = "Enregistrement confirmé. " + status.Text;
            }
            Selection();
        }
        search.TextChanged += (_, _) => { grid.ItemsSource = null; Selection(); status.Text = "Recherche modifiée : relancez la recherche."; };
        grid.SelectionChanged += (_, _) => Selection(); refresh.Click += (_, _) => Load();
        create.Click += (_, _) => Editor("CREATE", null);
        edit.Click += (_, _) => { if (grid.SelectedItem is CustomerFile row) Editor("UPDATE", row); };
        opening.Click += (_, _) => { if (grid.SelectedItem is CustomerFile row) Editor("OPENING", row); };
        history.Click += (_, _) =>
        {
            if (grid.SelectedItem is not CustomerFile row) return;
            try
            {
                var list = new DataGrid { ItemsSource = workflow.History(row.Id), AutoGenerateColumns = false, IsReadOnly = true, CanUserAddRows = false, RowHeight = 36 };
                foreach (var (label, property) in new[] { ("Date", "Date"), ("Heure", "Time"), ("Utilisateur", "Actor"), ("Client", "Customer"), ("Ancienne valeur", "Previous"), ("Nouvelle valeur", "Current") })
                    list.Columns.Add(new DataGridTextColumn { Header = label, Binding = new Binding(property) { StringFormat = property == "Date" ? "dd/MM/yyyy" : property is "Previous" or "Current" ? "0.####" : null }, Width = new DataGridLength(1, DataGridLengthUnitType.Star) });
                new Window { Title = "Historique du crédit initial — " + row.Id, Width = 900, Height = 460,
                    Content = list, Owner = this, WindowStartupLocation = WindowStartupLocation.CenterOwner }.ShowDialog();
            }
            catch (Exception ex) { status.Text = ex.Message; }
        };
        Loaded += (_, _) => { if (workflow.Pending is { } pending) Editor(pending.Kind, pending.Expected); else Load(); };
        Closing += (_, args) => { if (workflow.Pending is not null) { args.Cancel = true; status.Text = "Vérifiez l’enregistrement en cours avant de quitter."; } };
        Content = panel; Selection();
    }
}

public sealed class CustomerFileEditorDialog : Window
{
    public CustomerFile? Saved { get; private set; }
    public CustomerFileEditorDialog(ICustomerFilesWorkflow workflow, string kind, CustomerFile? expected)
    {
        var pending = workflow.Pending;
        var initial = pending?.Draft ?? expected?.Details ?? new CustomerFileDraft("", "", DateTime.Today, "", "", "", "", "", "", "", 0m);
        Title = kind == "CREATE" ? "Nouveau client" : kind == "UPDATE" ? "Modifier le client" : "Modifier le crédit initial";
        Width = 560; MaxHeight = SystemParameters.WorkArea.Height; SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var panel = new StackPanel { Margin = new Thickness(18) };
        panel.Children.Add(new TextBlock { Text = Title, FontSize = 24, FontWeight = FontWeights.SemiBold });
        panel.Children.Add(new TextBlock { Text = expected is null ? "Numéro client attribué à l’enregistrement." : expected.Id, Margin = new Thickness(0, 4, 0, 8) });
        var fields = new Dictionary<string, TextBox>();
        TextBox Field(string label, string value)
        {
            var box = new TextBox { Text = value, MinHeight = 36 }; fields.Add(label, box);
            System.Windows.Automation.AutomationProperties.SetName(box, label);
            panel.Children.Add(new Label { Content = label, Target = box }); panel.Children.Add(box); return box;
        }
        DatePicker? date = null; ComboBox? seller = null;
        if (kind != "OPENING")
        {
            Field("Code client", initial.Code); Field("Nom du client", initial.Name);
            date = new DatePicker { SelectedDate = initial.Date, MinHeight = 36 }; panel.Children.Add(new Label { Content = "Date" }); panel.Children.Add(date);
            Field("ICE", initial.Ice); Field("Adresse", initial.Address); Field("Ville", initial.City); Field("Pays", initial.Country);
            Field("Téléphone", initial.Telephone); Field("Notes", initial.Notes);
            seller = new ComboBox { ItemsSource = workflow.Sellers(), SelectedItem = initial.Seller, MinHeight = 36 };
            panel.Children.Add(new Label { Content = "Vendeur" }); panel.Children.Add(seller);
        }
        else panel.Children.Add(new TextBlock { Text = expected!.Details.Name + $"\nAncien crédit : {expected.Details.OpeningCredit:0.####} MAD", TextWrapping = TextWrapping.Wrap });
        var value = pending?.OpeningCredit ?? initial.OpeningCredit;
        var credit = Field(kind == "OPENING" ? "Nouveau crédit initial" : "Crédit initial", value.ToString("0.####", CultureInfo.CurrentCulture));
        TouchNumericEntry.Attach(credit, "Crédit initial", allowZero: true, decimalPlaces: 4, allowNegative: true);
        if (kind == "UPDATE") credit.IsEnabled = false;
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 10, 0, 6) }; panel.Children.Add(status);
        var save = new Button { Content = pending is null ? "Enregistrer" : "Vérifier l’enregistrement", MinHeight = 44, IsDefault = true };
        var cancel = new Button { Content = "Annuler", MinHeight = 40, IsCancel = true, Margin = new Thickness(0, 6, 0, 0) };
        panel.Children.Add(save); panel.Children.Add(cancel);
        void Lock(bool locked)
        {
            foreach (var field in fields.Values) field.IsEnabled = !locked;
            if (kind == "UPDATE") credit.IsEnabled = false;
            if (date is not null) date.IsEnabled = !locked; if (seller is not null) seller.IsEnabled = !locked;
            cancel.IsEnabled = !locked;
        }
        Lock(pending is not null);
        save.Click += (_, _) =>
        {
            save.IsEnabled = false;
            try
            {
                if (pending is null)
                {
                    if (!decimal.TryParse(credit.Text, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out var amount))
                        throw new CustomerFileWriteRefusedException("Saisissez le crédit initial au pavé numérique.");
                    string Text(string label) => fields[label].Text;
                    var draft = kind == "OPENING" ? null : new CustomerFileDraft(Text("Code client"), Text("Nom du client"), date!.SelectedDate ?? DateTime.MinValue,
                        Text("ICE"), Text("Adresse"), Text("Ville"), Text("Pays"), Text("Téléphone"), Text("Notes"), seller!.SelectedItem as string ?? "", amount);
                    pending = new CustomerFileCommand(Guid.NewGuid().ToString("N"), kind, expected, draft, kind == "OPENING" ? amount : null);
                }
                Lock(true); Saved = workflow.Execute(pending); pending = null; DialogResult = true;
            }
            catch (CustomerFileWriteRefusedException ex) { pending = workflow.Pending; Lock(pending is not null); status.Text = "Aucune modification appliquée. " + ex.Message; }
            catch (Exception ex) { pending = workflow.Pending ?? pending; Lock(true); status.Text = "Résultat à vérifier avant une autre modification. " + ex.Message; }
            finally { save.IsEnabled = true; save.Content = pending is null ? "Enregistrer" : "Vérifier l’enregistrement"; }
        };
        Closing += (_, args) => { if (workflow.Pending is not null) { args.Cancel = true; status.Text = "Vérifiez la même opération avant de fermer."; } };
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
    }
}
