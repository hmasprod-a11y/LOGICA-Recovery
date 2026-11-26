using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Hanouty.Desktop.Bootstrap;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

internal static class SupplierAvoirUiAcceptance
{
    [STAThread]
    private static int Main(string[] args)
    {
        try { Verify(args.Length == 1 ? args[0] : "."); return 0; }
        catch (Exception ex) { Console.Error.WriteLine(ex); return 1; }
    }
    private static void Verify(string evidence)
    {
        var connectionString = Environment.GetEnvironmentVariable("HANOUTY_AVOIR_CONNECTION") ?? throw new InvalidOperationException("Disposable connection required.");
        var cs = new MySqlConnectionStringBuilder(connectionString);
        if (cs.Server != "127.0.0.1" || cs.Database != "supplier_avoir_ci" || cs.Port != 33079 || Environment.GetEnvironmentVariable("HANOUTY_AVOIR_DISPOSABLE") != "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY") throw new InvalidOperationException("Dedicated disposable fixture required.");
        Directory.CreateDirectory(evidence);
        Execute("CREATE TABLE TABLE_MODE_P (MODE_P VARCHAR(255)) ENGINE=InnoDB; INSERT INTO TABLE_MODE_P VALUES ('ESPECES')");
        Execute(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "settlements.sql")));
        var app = new Application { ShutdownMode = ShutdownMode.OnExplicitShutdown };
        var service = new StockIssueValidation(connectionString); var pins = 0;
        var manager = new StockIssueDialog(service, "O'Neil", () => { pins++; return "1234"; });
        Exception? failure = null;
        var before = Number("SELECT COUNT(*) FROM TABLE_SORTIES_ENTETE");
        var stock = Number("SELECT SUM(STOCK) FROM TABLE_ARTICLES");
        var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(15) };
        timer.Tick += (_, _) => { timer.Stop(); failure = new TimeoutException("Supplier avoir dialog did not finish."); foreach (var window in app.Windows.Cast<Window>().Reverse().ToArray()) window.Close(); };
        manager.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            try
            {
                manager.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                {
                    var editor = app.Windows.OfType<SupplierAvoirCreateDialog>().SingleOrDefault();
                    try
                    {
                        Require(editor is not null, "Real avoir editor did not open from stock-issue entry.");
                        T Field<T>(string name) where T : DependencyObject => Controls<T>(editor!).Single(control => AutomationProperties.GetName(control) == name);
                        var supplier = Field<ComboBox>("Fournisseur"); supplier.SelectedItem = supplier.Items.Cast<StockIssueValidation.SupplierChoice>().Single(row => row.Id == "F1");
                        var article = Field<ComboBox>("Article de l’avoir"); article.SelectedItem = article.Items.Cast<StockIssueValidation.AvoirArticle>().Single(row => row.Id == "A");
                        var cost = Field<TextBox>("Prix d’achat signé"); Require(cost.IsReadOnly, "Avoir price required physical-keyboard typing.");
                        editor!.Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
                        {
                            var numeric = app.Windows.OfType<TouchNumericEntryDialog>().SingleOrDefault();
                            try
                            {
                                Require(numeric is not null, "Signed price touch keypad did not open.");
                                Click(Controls<Button>(numeric!).Single(button => Equals(button.Content, "±")));
                                Click(Controls<Button>(numeric!).Single(button => Equals(button.Content, "Appliquer")));
                            }
                            catch (Exception ex) { failure = ex; numeric?.Close(); }
                        }));
                        cost.RaiseEvent(new MouseButtonEventArgs(Mouse.PrimaryDevice, 0, MouseButton.Left) { RoutedEvent = UIElement.PreviewMouseLeftButtonDownEvent });
                        if (failure is not null) throw failure;
                        Click(Controls<Button>(editor).Single(button => Equals(button.Content, "Ajouter à l’avoir")));
                        Field<TextBox>("Notes de l’avoir").Text = "Création depuis l’interface";
                        Controls<CheckBox>(editor).Single().IsChecked = true;
                        Require(pins == 0 && Controls<TextBlock>(editor).Any(text => text.Text.Contains((-7.5m).ToString("N2", CultureInfo.CurrentCulture))), "Fresh PIN/visible signed total was missing before confirmation.");
                        Capture(editor, Path.Combine(evidence, "supplier-avoir-confirmation.png"));
                        Click(Controls<Button>(editor).Single(button => button.IsDefault));
                        Require(editor.DocumentId is not null && pins == 1, "Real save did not request a fresh PIN and persist the document.");
                    }
                    catch (Exception ex) { failure = ex; editor?.Close(); }
                }));
                Click(Controls<Button>(manager).Single(button => Equals(button.Content, "Nouvel avoir fournisseur")));
                if (failure is not null) throw failure;
                Capture(manager, Path.Combine(evidence, "supplier-avoir-created.png"));
            }
            catch (Exception ex) { failure = ex; }
            finally { manager.Close(); }
        }));
        timer.Start(); manager.ShowDialog(); timer.Stop(); app.Shutdown();
        if (failure is not null) throw new InvalidOperationException("Actual supplier AVOIR WPF acceptance failed.", failure);
        Require(Number("SELECT COUNT(*) FROM TABLE_SORTIES_ENTETE") == before + 1 && Number("SELECT SUM(STOCK) FROM TABLE_ARTICLES") == stock,
            "UI creation changed stock or failed to persist exactly one document.");
        var writer = new SupplierSettlementWriter(connectionString);
        decimal Balance() => writer.ReadAccounts().Single(row => row.SupplierId == "F1").Balance;
        Require(Balance() == 179.5m, "The supplier settlement screen did not share the original statement's outgoing sign.");
        var partial = new SupplierSettlementRequest(Guid.NewGuid().ToString("N"), "F1", 1m, "ESPECES", "Acompte d'été");
        Require(writer.Record(partial, "O'Neil", "1234"), "Partial supplier settlement failed.");
        Require(writer.Record(partial, "O'Neil", "1234") && Balance() == 178.5m,
            "Partial supplier settlement or duplicate changed the wrong balance.");
        var exact = partial with { OperationId = Guid.NewGuid().ToString("N"), Amount = 178.5m };
        var payments = Number("SELECT SUM(MONTANT) FROM TABLE_FOURNISSEURS_REGLE");
        Execute("CREATE TRIGGER fail_settlement_journal AFTER INSERT ON hanouty_supplier_settlement_operations FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='avoir-settlement-rollback'");
        try { writer.Record(exact, "O'Neil", "1234"); throw new Exception("Missing supplier settlement rollback."); } catch (MySqlException) { }
        Execute("DROP TRIGGER fail_settlement_journal");
        Require(Balance() == 178.5m && Number("SELECT SUM(MONTANT) FROM TABLE_FOURNISSEURS_REGLE") == payments, "Settlement journal failure left a payment.");
        Require(writer.Record(exact, "O'Neil", "1234") && Balance() == 0m, "Exact supplier balance could not be settled.");
        // Original save validates a positive amount, not an upper balance cap:
        // advance payments remain permitted and show a negative balance.
        Require(writer.Record(exact with { OperationId = Guid.NewGuid().ToString("N"), Amount = 0.01m }, "O'Neil", "1234") && Balance() == -0.01m,
            "An invented balance cap rejected LOGICA's supplier advance payment.");
        File.WriteAllText(Path.Combine(evidence, "supplier-avoir-wpf.json"), "{\"ActualStockIssueEntry\":true,\"SignedTouchPrice\":true,\"VisibleReviewedTotal\":true,\"FreshPin\":true,\"PersistedDocument\":true,\"StockUnchangedBeforeValidation\":true,\"SharedStatementSign\":true,\"PartialExactAndAdvanceSettlement\":true,\"SettlementRollback\":true}");
        Console.WriteLine("PASS actual stock-issue entry → supplier AVOIR → signed touch price → review → fresh PIN → persisted draft.");
        decimal Number(string sql) { using var db = new MySqlConnection(connectionString); db.Open(); using var cmd = new MySqlCommand(sql, db); return Convert.ToDecimal(cmd.ExecuteScalar()); }
        void Execute(string sql) { using var db = new MySqlConnection(connectionString); db.Open(); using var cmd = new MySqlCommand(sql, db); cmd.ExecuteNonQuery(); }
    }
    private static IEnumerable<T> Controls<T>(DependencyObject root) where T : DependencyObject
    {
        foreach (var child in LogicalTreeHelper.GetChildren(root).OfType<DependencyObject>()) { if (child is T result) yield return result; foreach (var nested in Controls<T>(child)) yield return nested; }
    }
    private static void Click(Button button) => button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
    private static void Require(bool condition, string message) { if (!condition) throw new InvalidOperationException(message); }
    private static void Capture(Window window, string path)
    {
        window.UpdateLayout(); var bitmap = new RenderTargetBitmap((int)Math.Ceiling(window.ActualWidth), (int)Math.Ceiling(window.ActualHeight), 96, 96, PixelFormats.Pbgra32); bitmap.Render(window);
        var encoder = new PngBitmapEncoder(); encoder.Frames.Add(BitmapFrame.Create(bitmap)); using var stream = File.Create(path); encoder.Save(stream);
    }
}
