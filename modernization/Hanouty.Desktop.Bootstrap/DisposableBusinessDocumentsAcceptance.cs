#if HANOUTY_FINANCIAL
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Hanouty.Desktop.Wpf;

namespace Hanouty.Desktop.Bootstrap;

internal static partial class DisposableCashSaleAcceptance
{
    // Root calls after VerifyCustomerFiles, which has restored original customer columns.
    private static void VerifyBusinessDocuments(CatalogueSettings settings, string pin)
    {
        TraceStep("Original devis/BL/facture consultation, validation and print data");
        Sql(settings, "INSERT INTO TABLE_CLIENTS (ID_CLIENT,CODE_CLIENT,CLIENT,ICE,ADRESSE,CREDIT_INITIAL) VALUES ('DOC-CLIENT','D''100','Société d’été','ICE100','Rue d’été',0)");
        var before = Snapshot(settings);
        var user = new BusinessDocumentStore(settings.ConnectionString, "O'Neil");
        var manager = new BusinessDocumentStore(settings.ConnectionString, "Test manager");
        foreach (var (kind, name, key) in new[] { (BusinessDocumentKind.Devis, "DEVIS", "ID_DEVIS"), (BusinessDocumentKind.BonLivraison, "BL", "ID_BL"), (BusinessDocumentKind.Facture, "FACTURE", "ID_FACTURE") })
        {
            Sql(settings, $"""
                CREATE TABLE TABLE_{name}_ENTETE (ID BIGINT PRIMARY KEY, {key} VARCHAR(255), DATES DATETIME,
                  ID_CLIENT VARCHAR(255),CODE_CLIENT VARCHAR(255),CLIENT VARCHAR(255),UTILISATEUR VARCHAR(255),NOTES VARCHAR(255),ETAT VARCHAR(255),
                  TOTAL_HT_DOC DECIMAL(19,4),TOTAL_TVA_DOC DECIMAL(19,4),TOTAL_TTC_DOC DECIMAL(19,4),TOTAL_REMISE_DOC DECIMAL(19,4)) ENGINE=InnoDB;
                CREATE TABLE TABLE_{name}_DETAILS (ID BIGINT PRIMARY KEY, {key} VARCHAR(255), DATES DATETIME, ID_CLIENT VARCHAR(255),CODE_CLIENT VARCHAR(255),CLIENT VARCHAR(255),
                  ID_ARTICLE VARCHAR(255),Code VARCHAR(255),Article VARCHAR(255),PU_TTC DECIMAL(19,4),TAUX_TVA DECIMAL(19,4),PU_HT DECIMAL(19,4),`Qté` DECIMAL(19,4),
                  TOTAL_TTC DECIMAL(19,4),TOTAL_TVA DECIMAL(19,4),TOTAL_HT DECIMAL(19,4),TAUX_REMISE DECIMAL(19,4),ETAT VARCHAR(255)) ENGINE=InnoDB;
                INSERT INTO TABLE_{name}_ENTETE VALUES (1,'{name}''100',CONCAT(CURDATE(),' 23:59:59'),'DOC-CLIENT','D''100','Société d’été','O''Neil','Note d’été','ENREGISTRER',100,20,120,10);
                INSERT INTO TABLE_{name}_DETAILS VALUES
                  (1,'{name}''100',CURDATE(),'DOC-CLIENT','D''100','Société d’été','A1','A''1','Article d’été',65,20,54.1667,1,60,10,50,7.6923,'ENREGISTRER'),
                  (2,'{name}''100',CURDATE(),'DOC-CLIENT','D''100','Société d’été','A2','0002','Deuxième article',65,20,54.1667,1,60,10,50,7.6923,'ENREGISTRER');
                """);
            var listed = user.Search(kind, DateTime.Today, DateTime.Today, "D'100");
            Require(listed.Count == 1 && listed[0].TotalTtc == 120m && user.Search(kind, DateTime.Today, DateTime.Today, "' OR 1=1 --").Count == 0,
                "Original document search lost literal input or end-of-day inclusion.");
            var reviewed = user.Read(kind, 1);
            Require(reviewed.Lines.Count == 2 && reviewed.Header.TotalHt == 100m && reviewed.Header.TotalTax == 20m && reviewed.Header.Discount == 10m &&
                reviewed.CustomerIce == "ICE100" && reviewed.CustomerAddress == "Rue d’été", "Document detail lost original persisted tax/customer fields.");
            void Denied(Action action)
            {
                var no = false; try { action(); } catch (Exception) { no = true; }
                Require(no && Number(settings, $"SELECT COUNT(*) FROM TABLE_{name}_ENTETE WHERE ETAT='VALIDER'") == 0 &&
                    Number(settings, $"SELECT COUNT(*) FROM TABLE_{name}_DETAILS WHERE ETAT='VALIDER'") == 0,
                    "Document rejection left header/detail partially validated.");
            }
            Denied(() => user.Validate(reviewed, pin));
            Denied(() => manager.Validate(reviewed, "wrong"));
            Sql(settings, $"UPDATE TABLE_{name}_ENTETE SET NOTES='Changed' WHERE ID=1");
            Denied(() => manager.Validate(reviewed, "5678"));
            reviewed = manager.Read(kind, 1);
            Sql(settings, $"CREATE TRIGGER documents_validation_fail AFTER UPDATE ON TABLE_{name}_DETAILS FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='documents-rollback'");
            try { Denied(() => manager.Validate(reviewed, "5678")); }
            finally { Sql(settings, "DROP TRIGGER documents_validation_fail"); }
            var validated = manager.Validate(reviewed, "5678");
            Require(validated.Header.State == "VALIDER" && validated.Lines.All(line => line.State == "VALIDER") &&
                manager.Validate(reviewed, "5678").Revision == validated.Revision,
                "Original document validation or idempotent readback failed.");
            var flow = BusinessDocumentPreviewDialog.BuildDocument(validated);
            var text = new TextRange(flow.ContentStart, flow.ContentEnd).Text;
            Require(text.Contains("Société d’été") && text.Contains("ICE100") && text.Contains("Article d’été") && text.Contains("120") && text.Contains("TVA"),
                "Printable document lost persisted lines/customer/totals.");
            Sql(settings, $"UPDATE TABLE_{name}_ENTETE SET TOTAL_TTC_DOC=121 WHERE ID=1");
            var inconsistent = false; try { user.Read(kind, 1); } catch (InvalidOperationException) { inconsistent = true; }
            Require(inconsistent, "Header/line total mismatch was silently printed.");
            Sql(settings, $"UPDATE TABLE_{name}_ENTETE SET TOTAL_TTC_DOC=120 WHERE ID=1");
        }
        Require(Snapshot(settings) == before, "Document validation changed stock, cash or ticket counters.");
        BusinessDocumentsThroughUi(settings, pin);
        File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-business-documents.json"), JsonSerializer.Serialize(new {
            OriginalThreeKinds = true, PersistedTaxTotals = true, LiteralSearchAndLastDay = true,
            CustomerAndLines = true, UserValidationDenied = true, FreshManagerPin = true, StaleSnapshotDenied = true,
            AtomicValidationRollback = true, ValidatedReadback = true, MismatchDenied = true,
            PrintData = true, ActualDirectoryUi = true, NoCashStockEffects = true
        }, new JsonSerializerOptions { WriteIndented = true }));
    }
    private static void BusinessDocumentsThroughUi(CatalogueSettings settings, string pin)
    {
        var host = CatalogueHost.CreateCashierWorkstation(settings, "01");
        Require(CashierEntry(host, "O'Neil", "01", "0", 0m, pin), "Business document cashier entry failed.");
        BusinessDocumentsDialog? dialog = null; Exception? failure = null;
        host.Window.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
        {
            try
            {
                dialog = Application.Current.Windows.OfType<BusinessDocumentsDialog>().Single();
                Require(!host.Window.ShowCustomerFiles() && !host.Window.EndFinancialSession() && !host.Window.SetReturnPaymentMode("Credit"),
                    "Business documents did not lock nested administration/session/return changes.");
                var controls = CatalogueControls<Button>(dialog).ToArray();
                void Click(string text) => controls.Single(button => Equals(button.Content, text)).RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                Click("Rechercher"); var grids = CatalogueControls<DataGrid>(dialog).ToArray();
                var headers = grids.Single(grid => grid.Items.Cast<object>().Any(item => item is BusinessDocumentHeader));
                Require(headers.Items.Count == 1, "Actual document directory did not show the persisted document.");
                headers.SelectedIndex = 0; Click("Consulter");
                Require(grids.Single(grid => grid != headers).Items.Count == 2 && controls.Single(button => Equals(button.Content, "Aperçu / imprimer")).IsEnabled,
                    "Actual document consultation did not bind lines or print entry.");
                dialog.UpdateLayout();
                var bitmap = new System.Windows.Media.Imaging.RenderTargetBitmap((int)Math.Ceiling(dialog.ActualWidth), (int)Math.Ceiling(dialog.ActualHeight), 96, 96, System.Windows.Media.PixelFormats.Pbgra32);
                bitmap.Render(dialog); var png = new System.Windows.Media.Imaging.PngBitmapEncoder(); png.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(bitmap));
                using (var stream = File.Create(Path.Combine(EvidenceDirectory, "business-documents-directory.png"))) png.Save(stream);
                dialog.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle, new Action(() =>
                {
                    var preview = Application.Current.Windows.OfType<BusinessDocumentPreviewDialog>().SingleOrDefault();
                    try { Require(preview is not null && CatalogueControls<FlowDocumentScrollViewer>(preview!).Single().Document is not null, "Actual print preview did not open."); }
                    catch (Exception ex) { failure = ex; }
                    finally { preview?.Close(); }
                }));
                Click("Aperçu / imprimer");
                if (failure is not null) throw failure;
                var search = CatalogueControls<TextBox>(dialog).Single(box => System.Windows.Automation.AutomationProperties.GetName(box) == "Numéro, code ou client");
                search.Text = "changed";
                Require(headers.Items.Count == 0 && !controls.Single(button => Equals(button.Content, "Aperçu / imprimer")).IsEnabled,
                    "Edited document search retained a stale printable selection.");
            }
            catch (Exception ex) { failure = ex; }
            finally { dialog?.Close(); }
        }));
        try { Require(host.Window.ShowBusinessDocuments(), "Documents entry refused."); }
        finally { host.Window.Close(); }
        if (failure is not null) throw new InvalidOperationException("Document UI acceptance failed.", failure);
    }
}
#endif
