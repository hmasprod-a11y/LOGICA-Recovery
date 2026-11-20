#if HANOUTY_FINANCIAL
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using Hanouty.Desktop.Wpf;

namespace Hanouty.Desktop.Bootstrap;
internal static partial class DisposableCashSaleAcceptance
{
    private static void VerifyCustomerFiles(CatalogueSettings settings, string pin)
    {
        TraceStep("Customer files, initial balance and durable recovery");
        Sql(settings, """
            ALTER TABLE TABLE_PASS ADD COLUMN IF NOT EXISTS CLIENTS VARCHAR(64) DEFAULT 'VISIBLE';
            ALTER TABLE TABLE_NUM ADD COLUMN IF NOT EXISTS CLIENT BIGINT DEFAULT 700;
            UPDATE TABLE_NUM SET CLIENT=700 WHERE ID=0;
            ALTER TABLE TABLE_CLIENTS ADD COLUMN IF NOT EXISTS ID BIGINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                ADD COLUMN IF NOT EXISTS DATES DATETIME, ADD COLUMN IF NOT EXISTS ICE VARCHAR(255),
                ADD COLUMN IF NOT EXISTS ADRESSE VARCHAR(255), ADD COLUMN IF NOT EXISTS VILLE VARCHAR(255),
                ADD COLUMN IF NOT EXISTS PAYS VARCHAR(255), ADD COLUMN IF NOT EXISTS NOTES VARCHAR(255),
                ADD COLUMN IF NOT EXISTS VENDEUR VARCHAR(255), ADD COLUMN IF NOT EXISTS ETAT VARCHAR(255),
                MODIFY CLIENT VARCHAR(255), MODIFY CODE_CLIENT VARCHAR(255), MODIFY CREDIT_INITIAL DECIMAL(19,4);
            CREATE TABLE TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL (ID BIGINT AUTO_INCREMENT PRIMARY KEY,
                DATES DATETIME, HEURE VARCHAR(255),UTILISATEUR VARCHAR(255),ID_CLIENT VARCHAR(255),CLIENT VARCHAR(255),
                VALEUR_ANCIENNE DOUBLE,VALEUR_NOUVELLE DOUBLE) ENGINE=InnoDB;
            """);
        using (var stream = typeof(DisposableCashSaleAcceptance).Assembly.GetManifestResourceStream("Hanouty.CustomerFilesMigration"))
        using (var reader = new StreamReader(stream ?? throw new InvalidOperationException("Customer migration resource missing."))) Sql(settings, reader.ReadToEnd());
        var financial = Snapshot(settings);
        var store = new CustomerFileStore(settings.ConnectionString);
        var access = store.Authorize("O'Neil", _ => throw new Exception("VISIBLE must not request role PIN."));
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        try
        {
            Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Customer files cashier login failed.");
            CustomerFilesThroughUi(host, pin);
            var created = store.Search(access, "CF'700").Single();
            Require(created.Id == "CL000700" && created.Details.Name == "Nouveau d'été" && created.Details.OpeningCredit == -5.4321m &&
                created.Details.Date == DateTime.Today && created.Details.Ice == "ICE700" && created.Details.Address == "Rue d'été" &&
                created.Details.City == "Salé" && created.Details.Country == "Maroc" && created.Details.Telephone == "0600000700" &&
                created.Details.Notes == "Fichier d'été" && created.Details.Seller == store.Sellers(access).First(value => value.Length != 0) &&
                Number(settings, "SELECT CLIENT FROM TABLE_NUM WHERE ID=0") == 701m &&
                store.History(access, created.Id).Single().Previous == 10.1234m && store.History(access, created.Id).Single().Current == -5.4321m,
                "Customer create/touch signed opening/history lost the original numbering or four decimals.");
            string State() => string.Join("|", Snapshot(settings), Number(settings, "SELECT CLIENT FROM TABLE_NUM WHERE ID=0"),
                Number(settings, "SELECT COUNT(*) FROM TABLE_CLIENTS"), Number(settings, "SELECT COALESCE(SUM(CREDIT_INITIAL),0) FROM TABLE_CLIENTS"),
                Number(settings, "SELECT COUNT(*) FROM TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL"), Number(settings, "SELECT COUNT(*) FROM hanouty_customer_file_operations"));
            void Refused(Action action)
            {
                var before = State(); var rejected = false;
                try { action(); } catch (Exception ex) when (ex is CustomerFileWriteRefusedException or UnauthorizedAccessException) { rejected = true; }
                Require(rejected && State() == before, "Rejected customer modification left persisted effects.");
            }
            var create = new CustomerFileCommand(Guid.NewGuid().ToString("N"), "CREATE", null, created.Details with { Code = "", Name = "Sans code", OpeningCredit = 0m });
            var other = store.Execute(access, create, pin);
            Require(other.Id == "CL000701" && store.Execute(access, create, pin) == other && Number(settings, "SELECT CLIENT FROM TABLE_NUM WHERE ID=0") == 702m,
                "Customer create replay consumed a second number or created another record.");
            Refused(() => store.Execute(access, create with { Draft = create.Draft! with { Name = "Changed retry" } }, pin));
            Refused(() => store.Execute(access, create with { OperationId = Guid.NewGuid().ToString("N"), Draft = created.Details }, pin));
            var update = new CustomerFileCommand(Guid.NewGuid().ToString("N"), "UPDATE", created,
                created.Details with { Name = "Client modifié d'été", Address = "Rue de l'été", City = "Rabat", Notes = "O'Neil" });
            Refused(() => store.Execute(access, update, "incorrect"));
            var changed = store.Execute(access, update, pin);
            Require(changed.Id == created.Id && changed.Details.OpeningCredit == created.Details.OpeningCredit && changed.Details.Address == "Rue de l'été",
                "Metadata update changed identity/opening or lost accented text.");
            Refused(() => store.Execute(access, update with { OperationId = Guid.NewGuid().ToString("N") }, pin));
            Refused(() => store.Execute(access, update with { OperationId = Guid.NewGuid().ToString("N"), Expected = changed,
                Draft = changed.Details with { OpeningCredit = 100m } }, pin));
            var opening = new CustomerFileCommand(Guid.NewGuid().ToString("N"), "OPENING", changed, OpeningCredit: 10.1234m);
            Sql(settings, "CREATE TRIGGER customer_history_fail AFTER INSERT ON TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='customer-history-rollback'");
            try { Refused(() => store.Execute(access, opening, pin)); }
            finally { Sql(settings, "DROP TRIGGER customer_history_fail"); }
            changed = store.Execute(access, opening, pin);
            Require(store.Execute(access, opening, pin) == changed && store.History(access, created.Id).Count == 2,
                "Initial-credit replay repeated history or changed the balance twice.");
            Sql(settings, "CREATE TRIGGER customer_journal_fail AFTER INSERT ON hanouty_customer_file_operations FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='customer-journal-rollback'");
            try { Refused(() => store.Execute(access, create with { OperationId = Guid.NewGuid().ToString("N"), Draft = create.Draft! with { Name = "Rollback" } }, pin)); }
            finally { Sql(settings, "DROP TRIGGER customer_journal_fail"); }
            Sql(settings, "UPDATE TABLE_PASS SET CLIENTS='ACCES MANAGER' WHERE ListUser='O''Neil'");
            var denied = false;
            try { store.Authorize("O'Neil", _ => "6789"); } catch (UnauthorizedAccessException) { denied = true; }
            Require(denied, "ADMIN incorrectly satisfied exact MANAGER access.");
            var manager = store.Authorize("O'Neil", role => role == "MANAGER" ? "5678" : "");
            Sql(settings, "UPDATE TABLE_PASS SET Catégorie='UTILISATEUR' WHERE ListUser='Test manager'");
            Refused(() => store.Execute(manager, create with { OperationId = Guid.NewGuid().ToString("N") }, pin));
            Sql(settings, "UPDATE TABLE_PASS SET Catégorie='MANAGER' WHERE ListUser='Test manager'; UPDATE TABLE_PASS SET CLIENTS='VISIBLE' WHERE ListUser='O''Neil'");
            Require(store.Search(access, "' OR 1=1 --").Count == 0, "Customer search did not preserve literal SQL input.");
            VerifyCustomerFileRecovery(settings, pin, create);
            Require(Snapshot(settings) == financial, "Customer metadata/opening adjustments entered cash, stock or ticket counters.");
            // The new file is a real selectable credit customer, not an isolated administration row.
            var config = Path.Combine(AppContext.BaseDirectory, "gestion_credit.sni"); var old = File.Exists(config) ? File.ReadAllBytes(config) : null;
            try
            {
                File.WriteAllText(config, "True"); host.Window.RefreshCreditSaleAvailability();
                host.ViewModel.ScannerText = "CREDIT-CODE"; host.ViewModel.ScanCommand.Execute(null);
                Require(CreditThroughDialog(host, pin, changed.Id, true, out _, changed.Details.Code, changed.Details.Name), "New customer file could not be used by the actual credit selector.");
                var account = new CustomerCreditStatementReader(settings.ConnectionString).Read(new DateTime(2000, 1, 1), DateTime.Today).Single(row => row.CustomerId == changed.Id);
                Require(account.OpeningCredit == 10.1234m && account.CreditSales == 9m && account.Balance == 19.1234m,
                    "New customer opening and actual credit sale did not meet in the existing statement.");
            }
            finally { if (old is null) File.Delete(config); else File.WriteAllBytes(config, old); }
            File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-customer-files.json"), JsonSerializer.Serialize(new {
                OriginalClNumbering = true, FullMetadata = true, OptionalUniqueCode = true, ImmutableIdentity = true,
                FourDecimalSignedTouch = true, OpeningHistoryAtomic = true, InitialCreditSeparate = true,
                StaleSnapshotDenied = true, ExactRoleAndRevocation = true, FreshCashierPin = true,
                CreateReplay = true, HistoryReplay = true, JournalRollback = true, RecoveryAfterRestart = true,
                LocalLease = true, NoCashStockSideEffects = true, ExistingCreditAndStatementLinked = true
            }, new JsonSerializerOptions { WriteIndented = true }));
        }
        finally { host.Window.Close(); }
    }
    private static void VerifyCustomerFileRecovery(CatalogueSettings settings, string pin, CustomerFileCommand template)
    {
        var store = new CustomerFileStore(settings.ConnectionString, () => throw new IOException("customer-ack-lost"));
        var access = store.Authorize("O'Neil", _ => "");
        var request = template with { OperationId = Guid.NewGuid().ToString("N"), Draft = template.Draft! with { Name = "Reprise après coupure", Code = "RECOVER-CUSTOMER" } };
        using (var workflow = new CustomerFilesWorkflow(store, access, settings.ConnectionString, "01", settings.DataDirectory, () => true, () => pin))
        {
            var locked = false;
            try { using var second = new CustomerFilesWorkflow(store, access, settings.ConnectionString, "01", settings.DataDirectory, () => true, () => pin); }
            catch (InvalidOperationException) { locked = true; }
            Require(locked, "Two customer workflows could overwrite the same recovery file.");
            var unknown = false; try { workflow.Execute(request); } catch (IOException) { unknown = true; }
            Require(unknown && workflow.Pending == request, "Lost customer acknowledgement did not retain the durable request.");
        }
        var before = Number(settings, "SELECT CLIENT FROM TABLE_NUM WHERE ID=0");
        var fresh = new CustomerFileStore(settings.ConnectionString); var grant = fresh.Authorize("O'Neil", _ => "");
        var recoveryPin = "incorrect";
        using var recovered = new CustomerFilesWorkflow(fresh, grant, settings.ConnectionString, "01", settings.DataDirectory, () => true, () => recoveryPin);
        var deniedRetry = false;
        try { recovered.Execute(recovered.Pending!); } catch (InvalidOperationException) { deniedRetry = true; }
        Require(deniedRetry && recovered.Pending == request && Number(settings, "SELECT CLIENT FROM TABLE_NUM WHERE ID=0") == before,
            "Rejected recovery PIN discarded a possibly committed customer request.");
        recoveryPin = pin;
        Require(recovered.Pending == request && recovered.Execute(recovered.Pending!).Details.Name == "Reprise après coupure" && recovered.Pending is null &&
            Number(settings, "SELECT CLIENT FROM TABLE_NUM WHERE ID=0") == before && fresh.Search(grant, "RECOVER-CUSTOMER").Count == 1,
            "Restart recovery duplicated customer/numbering or lost the persisted request.");
    }
    private static void CustomerFilesThroughUi(CatalogueHost host, string pin)
    {
        Exception? failure = null;
        var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromSeconds(15) };
        timer.Tick += (_, _) => { failure ??= new TimeoutException("Customer files UI timed out."); timer.Stop(); foreach (var window in Application.Current.Windows.Cast<Window>().Where(w => w != host.Window && w.IsVisible).Reverse().ToArray()) window.Close(); };
        void Click(Button button) => button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        void Edit(bool create)
        {
            host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                var editor = Application.Current.Windows.OfType<CustomerFileEditorDialog>().SingleOrDefault();
                try
                {
                    Require(editor is not null, "Actual customer editor did not open.");
                    var fields = CatalogueControls<TextBox>(editor!).ToArray();
                    TextBox Field(string label) => fields.Single(field => System.Windows.Automation.AutomationProperties.GetName(field) == label);
                    if (create)
                    {
                        Field("Code client").Text = "CF'700"; Field("Nom du client").Text = "Nouveau d'été"; Field("Téléphone").Text = "0600000700";
                        Field("ICE").Text = "ICE700"; Field("Adresse").Text = "Rue d'été"; Field("Ville").Text = "Salé";
                        Field("Pays").Text = "Maroc"; Field("Notes").Text = "Fichier d'été";
                        var seller = CatalogueControls<ComboBox>(editor!).Single();
                        seller.SelectedItem = seller.Items.Cast<string>().First(value => value.Length != 0);
                    }
                    var credit = Field(create ? "Crédit initial" : "Nouveau crédit initial"); Require(credit.IsReadOnly, "Opening balance required physical typing.");
                    host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                    {
                        var numeric = Application.Current.Windows.OfType<TouchNumericEntryDialog>().SingleOrDefault();
                        try
                        {
                            Require(numeric is not null, "Opening touch keypad did not open.");
                            var keys = CatalogueControls<Button>(numeric!).ToArray();
                            Click(keys.Single(button => Equals(button.Content, "Effacer")));
                            foreach (var key in (create ? "10.1234" : "5.4321"))
                            { var label = key == '.' ? CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator : key.ToString(); Click(keys.Single(button => Equals(button.Content, label))); }
                            if (!create) Click(keys.Single(button => Equals(button.Content, "±")));
                            Click(keys.Single(button => Equals(button.Content, "Appliquer")));
                        }
                        catch (Exception ex) { failure = ex; numeric?.Close(); }
                    }));
                    credit.RaiseEvent(new System.Windows.Input.MouseButtonEventArgs(System.Windows.Input.Mouse.PrimaryDevice, 0, System.Windows.Input.MouseButton.Left) { RoutedEvent = UIElement.PreviewMouseLeftButtonDownEvent });
                    ReviewThroughDialog(host, pin, true, () => Click(CatalogueControls<Button>(editor!).Single(button => button.IsDefault)));
                }
                catch (Exception ex) { failure = ex; editor?.Close(); }
            }));
        }
        host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            var dialog = Application.Current.Windows.OfType<CustomerFilesDialog>().SingleOrDefault();
            try
            {
                Require(dialog is not null && !host.Window.PayByCard() && !host.Window.EndFinancialSession() && !host.Window.ShowCashierEntry(), "Customer manager did not lock nested payment/session dialogs.");
                Edit(true); Click(CatalogueControls<Button>(dialog!).Single(button => Equals(button.Content, "Nouveau client")));
                if (failure is not null) throw failure;
                Edit(false); Click(CatalogueControls<Button>(dialog!).Single(button => Equals(button.Content, "Modifier le crédit initial")));
                if (failure is not null) throw failure;
                dialog!.UpdateLayout();
                var image = new System.Windows.Media.Imaging.RenderTargetBitmap((int)Math.Ceiling(dialog.ActualWidth), (int)Math.Ceiling(dialog.ActualHeight), 96, 96, System.Windows.Media.PixelFormats.Pbgra32);
                image.Render(dialog); var encoder = new System.Windows.Media.Imaging.PngBitmapEncoder(); encoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(image));
                using var stream = File.Create(Path.Combine(EvidenceDirectory, "customer-files-opening-balance.png")); encoder.Save(stream);
            }
            catch (Exception ex) { failure = ex; }
            finally { dialog?.Close(); }
        }));
        timer.Start(); try { Require(host.Window.ShowCustomerFiles(), "Customer manager entry point refused."); }
        finally { timer.Stop(); }
        if (failure is not null) throw new InvalidOperationException("Customer file UI acceptance failed.", failure);
    }
}
#endif
