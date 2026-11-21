using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class ProtectedWorkstationCopyDialog : Window
{
    internal CatalogueSettings? Settings { get; private set; }
    internal ProtectedWorkstationCopyDialog(CatalogueSettings source, string configurationPath)
    {
        Title = "Préparer HANOUTY depuis LOGICA"; Width = 650; SizeToContent = SizeToContent.Height;
        MaxHeight = SystemParameters.WorkArea.Height; WindowStartupLocation = WindowStartupLocation.CenterOwner;
        var cs = new MySqlConnectionStringBuilder(source.ConnectionString);
        var destination = "hanouty_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + Guid.NewGuid().ToString("N")[..8];
        var job = Path.Combine(Path.GetDirectoryName(WorkstationConfiguration.DefaultPath)!, "prepared", destination);
        var assets = Path.Combine(job, "catalogue-data");
        var panel = new StackPanel { Margin = new Thickness(22) };
        Content = new ScrollViewer { Content = panel, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
        panel.Children.Add(new TextBlock { Text = "Préparer une copie de travail", FontSize = 25, FontWeight = FontWeights.SemiBold });
        panel.Children.Add(new TextBlock { Text = $"LOGICA : {cs.Database}\nNouvelle copie HANOUTY : {destination}\nLa base d’origine reste disponible. La préparation crée une sauvegarde vérifiée et une copie distincte pour HANOUTY.", TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 12, 0, 14) });
        panel.Children.Add(new TextBlock { Text = "Outils MariaDB installés sur ce poste" });
        var bin = new TextBox { Text = FindMariaDbTools(), MinHeight = 36, Margin = new Thickness(0, 5, 0, 0) };
        System.Windows.Automation.AutomationProperties.SetName(bin, "Dossier des outils MariaDB"); panel.Children.Add(bin);
        var browse = new Button { Content = "Choisir le dossier des outils…", MinHeight = 38, Margin = new Thickness(0, 5, 0, 10) }; panel.Children.Add(browse);
        browse.Click += (_, _) => { var picker = new Microsoft.Win32.OpenFolderDialog { Title = "Dossier contenant mariadb.exe et mariadb-dump.exe" }; if (picker.ShowDialog(this) == true) bin.Text = picker.FolderName; };
        var sameAccount = new CheckBox { Content = "Utiliser le même compte pour créer la nouvelle copie", IsChecked = true, MinHeight = 38 }; panel.Children.Add(sameAccount);
        var credentials = new StackPanel { Visibility = Visibility.Collapsed };
        credentials.Children.Add(new TextBlock { Text = "Compte autorisé à créer la copie sur ce serveur" });
        var targetUser = new TextBox { MinHeight = 36, Text = cs.UserID }; credentials.Children.Add(targetUser);
        var targetPassword = new PasswordBox { MinHeight = 36, Margin = new Thickness(0, 6, 0, 6) }; credentials.Children.Add(targetPassword); panel.Children.Add(credentials);
        sameAccount.Checked += (_, _) => credentials.Visibility = Visibility.Collapsed;
        sameAccount.Unchecked += (_, _) => credentials.Visibility = Visibility.Visible;
        var acknowledged = new CheckBox { Content = "LOGICA est fermé. Je souhaite préparer cette copie pour HANOUTY.", MinHeight = 40, Margin = new Thickness(0, 8, 0, 8) }; panel.Children.Add(acknowledged);
        var status = new TextBlock { TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0, 8, 0, 8) }; panel.Children.Add(status);
        var prepare = new Button { Content = "Préparer et utiliser la copie", MinHeight = 48, IsDefault = true, IsEnabled = false }; panel.Children.Add(prepare);
        var cancel = new Button { Content = "Fermer", MinHeight = 40, Margin = new Thickness(0, 8, 0, 0) }; panel.Children.Add(cancel);
        var busy = false; var attempted = false; CancellationTokenSource? cancellation = null;
        acknowledged.Checked += (_, _) => prepare.IsEnabled = !busy && !attempted;
        acknowledged.Unchecked += (_, _) => prepare.IsEnabled = false;
        cancel.Click += (_, _) => { if (busy) { cancellation?.Cancel(); status.Text = "Annulation de la préparation en cours…"; } else Close(); };
        Closing += (_, args) => { if (busy) { args.Cancel = true; cancellation?.Cancel(); status.Text = "Annulation de la préparation en cours…"; } };
        prepare.Click += async (_, _) =>
        {
            if (busy || attempted || acknowledged.IsChecked != true) return;
            attempted = true; busy = true; prepare.IsEnabled = false; bin.IsEnabled = browse.IsEnabled = sameAccount.IsEnabled = credentials.IsEnabled = acknowledged.IsEnabled = false;
            cancel.Content = "Annuler la préparation"; cancellation = new CancellationTokenSource();
            using var sourcePassword = Secret(cs.Password);
            using var destinationPassword = sameAccount.IsChecked == true ? sourcePassword.Copy() : targetPassword.SecurePassword;
            var user = sameAccount.IsChecked == true ? cs.UserID : targetUser.Text;
            try
            {
                ProtectedCatalogueFiles.CheckPaths(source.DataDirectory, assets);
                Directory.CreateDirectory(Path.GetDirectoryName(job)!);
                var request = new ProtectedLocalCopyRequest(cs.Server, cs.Port, cs.Database, destination, job, bin.Text,
                    new ProtectedCopyCredentials(cs.UserID, sourcePassword), new ProtectedCopyCredentials(user, destinationPassword),
                    ProtectedMigrationResources.Load(), source.WorkstationId);
                var progress = new Progress<ProtectedCopyProgress>(update => status.Text = update.Message);
                var copy = await Task.Run(() => new ProtectedLocalCopyService().PrepareAsync(request, progress, cancellation.Token));
                if (!copy.Ready || !copy.SourceUnchanged || copy.Database != destination || Path.GetFullPath(copy.DataDirectory) != Path.GetFullPath(job))
                    throw new InvalidOperationException("La copie n’a pas été validée. Le profil actuel est conservé.");
                var fileProgress = new Progress<string>(message => status.Text = message);
                await Task.Run(() => ProtectedCatalogueFiles.CopyAsync(source.DataDirectory, assets, message => ((IProgress<string>)fileProgress).Report(message), cancellation.Token));
                var preparedConnection = new MySqlConnectionStringBuilder(cs.ConnectionString) { Database = destination, UserID = user, Password = Plain(destinationPassword), CharacterSet = "utf8mb4" };
                var prepared = CatalogueSettings.Validate(preparedConnection.ConnectionString, assets, source.WorkstationId);
                WorkstationConfiguration.CheckConnection(prepared);
                if (!WorkstationReadiness.IsReady(prepared)) throw new InvalidOperationException("La copie est incomplète et ne sera pas activée.");
                cancellation.Token.ThrowIfCancellationRequested();
                WorkstationConfiguration.Save(configurationPath, prepared);
                Settings = prepared; busy = false; targetPassword.Clear(); DialogResult = true;
            }
            catch (OperationCanceledException) { status.Text = "Préparation annulée. Le profil actuel est conservé."; }
            catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
            { status.Text = (ex is ProtectedLocalCopyException or InvalidOperationException ? ex.Message : "La préparation n’a pas abouti. Le profil actuel et LOGICA restent disponibles.") + "\nFermez cette fenêtre puis relancez la préparation pour créer une nouvelle copie."; }
            finally
            {
                busy = false; cancellation.Dispose(); cancellation = null; targetPassword.Clear();
                bin.IsEnabled = browse.IsEnabled = sameAccount.IsEnabled = credentials.IsEnabled = acknowledged.IsEnabled = true;
                // Each attempt needs a fresh destination; reopening avoids reusing a partial copy.
                prepare.IsEnabled = false; acknowledged.IsChecked = false; cancel.Content = "Fermer";
            }
        };
        Closed += (_, _) => { targetPassword.Clear(); cancellation?.Dispose(); };
    }
    private static SecureString Secret(string value)
    { var secret = new SecureString(); foreach (var character in value) secret.AppendChar(character); secret.MakeReadOnly(); return secret; }
    private static string Plain(SecureString value)
    { var pointer = Marshal.SecureStringToBSTR(value); try { return Marshal.PtrToStringBSTR(pointer); } finally { Marshal.ZeroFreeBSTR(pointer); } }
    private static string FindMariaDbTools()
    {
        foreach (var name in new[] { "mariadbd", "mysqld" })
            foreach (var process in Process.GetProcessesByName(name))
                using (process)
                    try
                    {
                        var folder = Path.GetDirectoryName(process.MainModule?.FileName);
                        if (folder is not null && File.Exists(Path.Combine(folder, "mariadb.exe")) && File.Exists(Path.Combine(folder, "mariadb-dump.exe"))) return folder;
                    }
                    catch (Exception ex) when (ex is System.ComponentModel.Win32Exception or InvalidOperationException) { }
        return "";
    }
}
