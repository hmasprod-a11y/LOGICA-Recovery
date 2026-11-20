using System.Text.Json;
using Hanouty.Desktop.Bootstrap;
using MySql.Data.MySqlClient;

var connectionString = Environment.GetEnvironmentVariable("HANOUTY_AVOIR_CONNECTION") ?? throw new InvalidOperationException("Explicit disposable connection required.");
var cs = new MySqlConnectionStringBuilder(connectionString);
if (cs.Server != "127.0.0.1" || cs.Database != "supplier_avoir_ci" || cs.Port != 33079 || Environment.GetEnvironmentVariable("HANOUTY_AVOIR_DISPOSABLE") != "I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY")
    throw new InvalidOperationException("Only the dedicated disposable supplier_avoir_ci fixture is accepted.");
using var connection = new MySqlConnection(connectionString); connection.Open();
Execute("""
    CREATE TABLE TABLE_PASS (ListUser VARCHAR(255),ListPass VARCHAR(255),Catégorie VARCHAR(64)) ENGINE=InnoDB;
    INSERT INTO TABLE_PASS VALUES ('O''Neil','1234','UTILISATEUR'),('Manager','5678','MANAGER');
    CREATE TABLE TABLE_NUM (ID INT PRIMARY KEY,BS BIGINT,CL BIGINT) ENGINE=InnoDB;
    INSERT INTO TABLE_NUM VALUES (0,1,99);
    CREATE TABLE TABLE_FOURNISSEURS (ID_FOURNISSEUR VARCHAR(255),CODE_FOURNISSEUR VARCHAR(255),FOURNISSEUR VARCHAR(255),CREDIT_INITIAL DECIMAL(19,4)) ENGINE=InnoDB;
    INSERT INTO TABLE_FOURNISSEURS VALUES ('F1','F''1','Fournisseur d''été',100),('F2','F2','Second',0);
    CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(255) PRIMARY KEY,Code VARCHAR(255),Article VARCHAR(255),PRIX_A DECIMAL(19,4),PRIX_V_1 DECIMAL(19,4),STOCK DECIMAL(19,4)) ENGINE=InnoDB;
    INSERT INTO TABLE_ARTICLES VALUES ('A','001','Article d''été',7.5,12,12),('B','001','Variante',5,8,5);
    CREATE TABLE TABLE_SORTIES_ENTETE (ID BIGINT PRIMARY KEY,ID_BS VARCHAR(255),Dates DATETIME,UTILISATEUR VARCHAR(255),ID_FOURNISSEUR VARCHAR(255),CODE_FOURNISSEUR VARCHAR(255),FOURNISSEUR VARCHAR(255),TYPE VARCHAR(64),TOTAL_NET_ACHATS DECIMAL(19,4),TOTAL_NET_VENTES DECIMAL(19,4),NOTES TEXT,ETAT VARCHAR(64)) ENGINE=InnoDB;
    CREATE TABLE TABLE_SORTIES_DETAILS (Dates DATETIME,ID_BS VARCHAR(255),ID_FOURNISSEUR VARCHAR(255),CODE_FOURNISSEUR VARCHAR(255),FOURNISSEUR VARCHAR(255),TYPE VARCHAR(64),ID_ARTICLE VARCHAR(255),Code VARCHAR(255),Article VARCHAR(255),Prix_A DECIMAL(19,4),Prix_V DECIMAL(19,4),Qté DECIMAL(19,4),TOTAL_NET_ACHATS DECIMAL(19,4),TOTAL_NET_VENTES DECIMAL(19,4),ETAT VARCHAR(64)) ENGINE=InnoDB;
    CREATE TABLE TABLE_RECEPTIONS_ENTETE (ID_FOURNISSEUR VARCHAR(255),TOTAL_NET_ACHATS DECIMAL(19,4)) ENGINE=InnoDB;
    INSERT INTO TABLE_RECEPTIONS_ENTETE VALUES ('F1',80);
    CREATE TABLE TABLE_FOURNISSEURS_REGLE (ID BIGINT PRIMARY KEY,DATES DATETIME,UTILISATEUR VARCHAR(255),ID_REGLE VARCHAR(64),ID_FOURNISSEUR VARCHAR(255),CODE_FOURNISSEUR VARCHAR(255),FOURNISSEUR VARCHAR(255),MONTANT DECIMAL(19,4),MODE_P VARCHAR(255),NOTES TEXT,ETAT VARCHAR(64)) ENGINE=InnoDB;
    INSERT INTO TABLE_FOURNISSEURS_REGLE (ID,ID_FOURNISSEUR,MONTANT) VALUES (1,'F1',8);
    CREATE TABLE TABLE_MOUVEMENTS_STOCK (DATES VARCHAR(32),HEURE VARCHAR(32),LIBELLE VARCHAR(255),ID_ARTICLE VARCHAR(255),CODE_ARTICLE VARCHAR(255),ARTICLE VARCHAR(255),QUANTITE DECIMAL(19,4)) ENGINE=InnoDB;
    """);
Execute(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "history.sql")));
Execute(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "creation.sql")));
var service = new StockIssueValidation(connectionString);
var supplier = service.AvoirSuppliers().Single(row => row.Id == "F1");
var articles = service.AvoirArticles();
Require(articles.Count(row => row.Code == "001") == 2, "Shared codes hid a variant.");
var lines = new[] { new StockIssueValidation.AvoirLine(articles.Single(row => row.Id == "A"), 2m, 7.5m, 12m), new StockIssueValidation.AvoirLine(articles.Single(row => row.Id == "B"), 1m, 5m, 8m) };
var request = new StockIssueValidation.AvoirCommand(Guid.NewGuid().ToString("N"), DateTime.Today, supplier, "Retour d'été", lines);
var account = new PurchaseReceiptValidation(connectionString);
Require(account.ReadSupplierAccount("F1").Balance == 172m, "Initial fixture balance invalid.");
Reject(() => service.CreateAvoir(request, "O'Neil", "wrong"));
Execute("INSERT INTO TABLE_FOURNISSEURS VALUES ('f1','ALIAS','Alias interdit',0)");
Require(service.AvoirSuppliers().All(row => !string.Equals(row.Id, "F1", StringComparison.OrdinalIgnoreCase)), "Case-colliding supplier identities were selectable.");
Reject(() => service.CreateAvoir(request, "O'Neil", "1234"));
Execute("DELETE FROM TABLE_FOURNISSEURS WHERE BINARY ID_FOURNISSEUR=BINARY 'f1'");
var id = service.CreateAvoir(request, "O'Neil", "1234");
Require(id == "BS000001" && Scalar("SELECT BS FROM TABLE_NUM WHERE ID=0") == 2m && Scalar("SELECT CL FROM TABLE_NUM WHERE ID=0") == 99m &&
    Scalar("SELECT SUM(STOCK) FROM TABLE_ARTICLES") == 17m && Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 0 &&
    Scalar("SELECT TOTAL_NET_ACHATS FROM TABLE_SORTIES_ENTETE WHERE ID_BS='BS000001'") == 20m && account.ReadSupplierAccount("F1").Balance == 152m,
    "Creating an avoir lost original numbering/signed debt or moved stock before validation.");
Require(service.CreateAvoir(request, "O'Neil", "1234") == id && Scalar("SELECT COUNT(*) FROM TABLE_SORTIES_ENTETE") == 1m, "Create replay duplicated header.");
Reject(() => service.CreateAvoir(request with { Notes = "Changed replay" }, "O'Neil", "1234"));
var next = request with { OperationId = Guid.NewGuid().ToString("N") };
Execute("UPDATE TABLE_FOURNISSEURS SET FOURNISSEUR='Changed' WHERE ID_FOURNISSEUR='F1'");
Reject(() => service.CreateAvoir(next, "O'Neil", "1234"));
Execute("UPDATE TABLE_FOURNISSEURS SET FOURNISSEUR='Fournisseur d''été' WHERE ID_FOURNISSEUR='F1'; UPDATE TABLE_ARTICLES SET PRIX_A=9 WHERE ID_ARTICLE='A'");
Reject(() => service.CreateAvoir(next, "O'Neil", "1234"));
Execute("UPDATE TABLE_ARTICLES SET PRIX_A=7.5 WHERE ID_ARTICLE='A'");
Execute("CREATE TRIGGER fail_detail AFTER INSERT ON TABLE_SORTIES_DETAILS FOR EACH ROW BEGIN IF NEW.ID_ARTICLE='B' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='avoir-detail-rollback'; END IF; END");
Reject(() => service.CreateAvoir(next, "O'Neil", "1234")); Execute("DROP TRIGGER fail_detail");
Execute("CREATE TRIGGER fail_journal AFTER INSERT ON hanouty_stock_issue_create_operations FOR EACH ROW SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='avoir-journal-rollback'");
Reject(() => service.CreateAvoir(next, "O'Neil", "1234")); Execute("DROP TRIGGER fail_journal");
Require(Scalar("SELECT BS FROM TABLE_NUM WHERE ID=0") == 2m && Scalar("SELECT COUNT(*) FROM TABLE_SORTIES_DETAILS") == 2m && account.ReadSupplierAccount("F1").Balance == 152m,
    "Rejected creation left lines, consumed numbering or changed supplier debt.");
var reviewed = service.ReadForValidation(id);
try { service.Validate(id, reviewed, "O'Neil", "1234"); throw new Exception("Unauthorized validation accepted."); } catch (UnauthorizedAccessException) { }
Execute("CREATE TRIGGER fail_history AFTER INSERT ON hanouty_stock_issue_history FOR EACH ROW BEGIN IF NEW.ARTICLE_ID='B' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='avoir-history-rollback'; END IF; END");
try { service.Validate(id, reviewed, "Manager", "5678"); throw new Exception("Missing validation rollback."); } catch (MySqlException) { }
Execute("DROP TRIGGER fail_history");
Require(Scalar("SELECT SUM(STOCK) FROM TABLE_ARTICLES") == 17m && Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK") == 0m, "Validation failure left stock/movements.");
var result = service.Validate(id, reviewed, "Manager", "5678");
Require(result.HistorySaved && result.Movements.Length == 2 && Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='A'") == 10m &&
    Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='B'") == 4m && account.ReadSupplierAccount("F1").Balance == 152m &&
    service.ReadHistoryWithCredit(id).Credit is { PurchaseTotal: 20m, SupplierId: "F1" }, "Validation did not preserve signed supplier amount and stock/history.");
try { service.Validate(id, reviewed, "Manager", "5678"); throw new Exception("Validation replay accepted."); } catch (InvalidOperationException) { }
var recoveryDirectory = Path.Combine(Path.GetTempPath(), "HANOUTY-avoir-acceptance-" + Guid.NewGuid().ToString("N"));
next = next with { Lines = lines.Select(line => line with { Cost = -line.Cost, Price = -line.Price }).ToArray() };
using (var workflow = service.OpenAvoirWorkflow("O'Neil", () => "1234", recoveryDirectory, () => throw new IOException("lost-avoir-ack")))
{
    try { using var conflict = service.OpenAvoirWorkflow("O'Neil", () => "1234", recoveryDirectory); throw new Exception("Recovery lease conflict accepted."); } catch (InvalidOperationException) { }
    try { workflow.Execute(next); throw new Exception("Missing ack fault."); } catch (IOException) { }
    Require(workflow.Pending is not null, "Unknown result lost pending request.");
}
var beforeRecovery = Scalar("SELECT BS FROM TABLE_NUM WHERE ID=0");
var recoveryPin = "wrong";
using (var workflow = service.OpenAvoirWorkflow("O'Neil", () => recoveryPin, recoveryDirectory))
{
    try { workflow.Execute(workflow.Pending!); throw new Exception("Wrong recovery PIN accepted."); } catch (InvalidOperationException) { }
    Require(workflow.Pending is not null, "Refused retry discarded possibly committed request.");
    recoveryPin = "1234";
    Require(workflow.Execute(workflow.Pending!) == "BS000002" && workflow.Pending is null && Scalar("SELECT BS FROM TABLE_NUM WHERE ID=0") == beforeRecovery &&
        Scalar("SELECT COUNT(*) FROM TABLE_SORTIES_ENTETE") == 2m && account.ReadSupplierAccount("F1").Balance == 172m, "Restart recovery duplicated avoir/numbering or reversed signed outgoing semantics.");
}
var evidence = args.Length == 1 ? args[0] : "."; Directory.CreateDirectory(evidence);
File.WriteAllText(Path.Combine(evidence, "supplier-avoir-acceptance.json"), JsonSerializer.Serialize(new {
    OriginalSignedPrices = true, SupplierIdentityReviewed = true, OriginalBsNumbering = true, SupplierBalanceLinked = true,
    StockOnlyAtValidation = true, AtomicHistory = true, FreshPinAndRole = true, StaleSupplierAndArticleDenied = true,
    DetailAndJournalRollback = true, DuplicateCreation = true, DuplicateValidationDenied = true, RestartRecovery = true,
    WrongRecoveryPinRetainsRequest = true, ExclusiveRecoveryLease = true
}, new JsonSerializerOptions { WriteIndented = true }));
Console.WriteLine("PASS supplier AVOIR create, signed account, stock validation/history, rollback, role/PIN and durable recovery.");

void Execute(string sql) { using var command = new MySqlCommand(sql, connection); command.ExecuteNonQuery(); }
decimal Scalar(string sql) { using var command = new MySqlCommand(sql, connection); return Convert.ToDecimal(command.ExecuteScalar()); }
void Reject(Action action)
{
    var before = string.Join("|", Scalar("SELECT COUNT(*) FROM TABLE_SORTIES_ENTETE"), Scalar("SELECT COUNT(*) FROM TABLE_SORTIES_DETAILS"), Scalar("SELECT BS FROM TABLE_NUM WHERE ID=0"), Scalar("SELECT COUNT(*) FROM hanouty_stock_issue_create_operations"));
    try { action(); } catch (StockIssueValidation.AvoirWriteRefusedException)
    {
        Require(before == string.Join("|", Scalar("SELECT COUNT(*) FROM TABLE_SORTIES_ENTETE"), Scalar("SELECT COUNT(*) FROM TABLE_SORTIES_DETAILS"), Scalar("SELECT BS FROM TABLE_NUM WHERE ID=0"), Scalar("SELECT COUNT(*) FROM hanouty_stock_issue_create_operations")), "Refusal left partial state."); return;
    }
    throw new Exception("Expected safe creation refusal.");
}
static void Require(bool condition, string message) { if (!condition) throw new InvalidOperationException(message); }
