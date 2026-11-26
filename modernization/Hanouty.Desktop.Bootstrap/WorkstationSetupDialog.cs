using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class WorkstationSetupDialog : Window
{
    internal CatalogueSettings? Settings { get; private set; }
    internal WorkstationSetupDialog(string configurationPath, CatalogueSettings? initial = null)
    {
        Title = "HANOUTY — Configuration du poste"; Width = 540; SizeToContent = SizeToContent.Height;
        WindowStartupLocation = WindowStartupLocation.CenterScreen; ResizeMode = ResizeMode.NoResize;
        MaxHeight = SystemParameters.WorkArea.Height;
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(new TextBlock { Text = "Configurer cette caisse", FontSize = 24, FontWeight = FontWeights.SemiBold });
        panel.Children.Add(new TextBlock { Text = "Choisissez la base LOGICA locale et son dossier de données. Si une préparation est nécessaire, HANOUTY proposera une copie protégée avant de conserver les paramètres du poste.", TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 8) });
        TextBox Field(string label, string initial)
        {
            var field = new TextBox { Text = initial, MinHeight = 36 };
            System.Windows.Automation.AutomationProperties.SetName(field, label);
            panel.Children.Add(new Label { Content = label, Target = field }); panel.Children.Add(field); return field;
        }
        var server = Field("Serveur local", "127.0.0.1"); var port = Field("Port", "3306");
        var database = Field("Base de données", ""); var user = Field("Utilisateur de la base", "");
        var password = new PasswordBox { MinHeight = 36 }; panel.Children.Add(new Label { Content = "Mot de passe de la base", Target = password }); panel.Children.Add(password);
        var directory = Field("Dossier de données LOGICA", "");
        panel.Children.Add(new TextBlock { Text = "Sélectionnez le dossier principal de LOGICA, qui contient bd\\images.", TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 4, 0, 0) });
        var browse = new Button { Content = "Choisir le dossier…", MinHeight = 36, Margin = new Thickness(0, 5, 0, 0) }; panel.Children.Add(browse);
        browse.Click += (_, _) => { var picker = new Microsoft.Win32.OpenFolderDialog { Title = "Dossier de données LOGICA" }; if (picker.ShowDialog(this) == true) directory.Text = picker.FolderName; };
        var workstation = Field("Numéro du poste", "01");
        if (initial is not null)
        {
            var saved = new MySqlConnectionStringBuilder(initial.ConnectionString);
            server.Text = saved.Server; port.Text = saved.Port.ToString(); database.Text = saved.Database; user.Text = saved.UserID;
            password.Password = saved.Password; directory.Text = initial.DataDirectory; workstation.Text = initial.WorkstationId;
        }
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 10, 0, 8) }; panel.Children.Add(status);
        var save = new Button { Content = "Vérifier et préparer le poste", MinHeight = 44, IsDefault = true }; panel.Children.Add(save);
        var cancel = new Button { Content = "Fermer", MinHeight = 38, IsCancel = true, Margin = new Thickness(0, 6, 0, 0) }; panel.Children.Add(cancel);
        save.Click += (_, _) =>
        {
            save.IsEnabled = false;
            try
            {
                if (!uint.TryParse(port.Text, out var selectedPort) || selectedPort is 0 or > 65535) throw new InvalidOperationException("Port invalide.");
                var cs = new MySqlConnectionStringBuilder { Server = server.Text.Trim(), Port = selectedPort, Database = database.Text.Trim(), UserID = user.Text.Trim(), Password = password.Password, SslMode = MySqlSslMode.Disabled };
                var settings = CatalogueSettings.Validate(cs.ConnectionString, directory.Text, workstation.Text);
                WorkstationConfiguration.CheckConnection(settings);
                if (!WorkstationReadiness.IsReady(settings))
                {
                    var preparation = new ProtectedWorkstationCopyDialog(settings, configurationPath) { Owner = this };
                    if (preparation.ShowDialog() == true && preparation.Settings is { } prepared)
                    { Settings = prepared; password.Clear(); DialogResult = true; }
                    return;
                }
                WorkstationConfiguration.Save(configurationPath, settings);
                Settings = settings; password.Clear(); DialogResult = true;
            }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { status.Text = ex is InvalidOperationException ? ex.Message : "Connexion ou enregistrement impossible. Vérifiez les paramètres et les droits de ce poste."; }
            finally { save.IsEnabled = true; }
        };
        Closed += (_, _) => password.Clear();
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
    }
}
