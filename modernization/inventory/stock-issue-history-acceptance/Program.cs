using Hanouty.Desktop.Bootstrap;
using MySql.Data.MySqlClient;

const string connectionString = "Server=127.0.0.1;Port=3307;Database=stock_issue_history_ci;Uid=stock_issue_ci;Pwd=stock-issue-ci-only";
using var connection = new MySqlConnection(connectionString);
connection.Open();

Execute("""
    CREATE TABLE TABLE_PASS (ListUser VARCHAR(64), ListPass VARCHAR(64), Catégorie VARCHAR(64)) ENGINE=InnoDB;
    CREATE TABLE TABLE_ARTICLES (ID_ARTICLE VARCHAR(64) PRIMARY KEY, STOCK DECIMAL(16,3)) ENGINE=InnoDB;
    CREATE TABLE TABLE_SORTIES_ENTETE (ID_BS VARCHAR(64) PRIMARY KEY, TYPE TEXT, NOTES TEXT, ETAT VARCHAR(32)) ENGINE=InnoDB;
    CREATE TABLE TABLE_SORTIES_DETAILS (ID_BS VARCHAR(64), ID_ARTICLE VARCHAR(64), Code TEXT, Article TEXT,
        Qté DECIMAL(16,3), ETAT VARCHAR(32)) ENGINE=InnoDB;
    CREATE TABLE TABLE_MOUVEMENTS_STOCK (DATES VARCHAR(16), HEURE VARCHAR(16), LIBELLE VARCHAR(128),
        ID_ARTICLE VARCHAR(64), CODE_ARTICLE TEXT, ARTICLE TEXT, QUANTITE DECIMAL(16,3)) ENGINE=InnoDB;
    INSERT INTO TABLE_PASS VALUES ('Manager','1234','MANAGER');
    INSERT INTO TABLE_ARTICLES VALUES ('A',12.750),('B',4.125);
    INSERT INTO TABLE_SORTIES_ENTETE VALUES
        ('BS-OK','PERTE','Verre cassé','ENREGISTRER'),('BS-FAIL','TRANSFERT','','ENREGISTRER'),
        ('BS-OLD','AUTRE','','ENREGISTRER');
    INSERT INTO TABLE_SORTIES_DETAILS VALUES
        ('BS-OK','A','001','Verre',2.25,'ENREGISTRER'),('BS-OK','B','002','Plat',0.50,'ENREGISTRER'),
        ('BS-FAIL','A','001','Verre',1,'ENREGISTRER'),('BS-FAIL','B','002','Plat',1,'ENREGISTRER'),
        ('BS-OLD','A','001','Verre',0.50,'ENREGISTRER');
    """);

var service = new StockIssueValidation(connectionString);
var old = service.Validate("BS-OLD", service.ReadForValidation("BS-OLD"), "Manager", "1234");
Require(!old.HistorySaved, "Legacy schema incorrectly reported detailed history.");
Execute(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "migration.sql")));
var legacy = service.ReadHistory("BS-OLD").Single();
Require(legacy.Quantity == 0.50m && legacy.Article == "Verre" &&
    legacy.Actor == "" && legacy.Reason == "" && legacy.StockBefore is null &&
    legacy.StockAfter is null && legacy.ValidatedUtc is null,
    "Legacy movement was lost or unavailable details were fabricated.");
Require(service.ReadHistory("bs-old").Length == 0, "History matched a different document identity.");

var reviewed = service.ReadForValidation("BS-OK");
Reject<UnauthorizedAccessException>(() => service.Validate("BS-OK", reviewed, "Manager", "wrong"));
Execute("UPDATE TABLE_SORTIES_ENTETE SET NOTES='Modifiée' WHERE ID_BS='BS-OK'");
Reject<InvalidOperationException>(() => service.Validate("BS-OK", reviewed, "Manager", "1234"));
Require(service.ReadHistory("BS-OK").Length == 0, "Rejected document left detailed history.");

var result = service.Validate("BS-OK", service.ReadForValidation("BS-OK"), "Manager", "1234");
var movements = new StockIssueValidation(connectionString).ReadHistory("BS-OK");
Require(result.HistorySaved && movements.Length == 2, "Committed document could not be reopened.");
Require(movements[0].Actor == "Manager" && movements[0].Reason == "PERTE · Modifiée" &&
    movements[0].Reference == "BS-OK" && movements[0].Code == "001" && movements[0].Article == "Verre" &&
    movements[0].Quantity == 2.25m && movements[0].StockBefore == 12.25m && movements[0].StockAfter == 10m &&
    movements[1].StockBefore == 4.125m && movements[1].StockAfter == 3.625m &&
    movements[0].ValidatedUtc?.Kind == DateTimeKind.Utc && movements[0].ValidatedUtc == movements[1].ValidatedUtc,
    "Persistent movement evidence differs from the committed document.");
Reject<InvalidOperationException>(() => service.Validate("BS-OK", reviewed, "Manager", "1234"));
Require(service.ReadHistory("BS-OK").Length == 2, "Replay changed history.");

Execute("""
    CREATE TRIGGER reject_second_history BEFORE INSERT ON hanouty_stock_issue_history FOR EACH ROW
    BEGIN
        IF NEW.ARTICLE_ID = 'B' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Forced history failure'; END IF;
    END
    """);
Reject<MySqlException>(() => service.Validate("BS-FAIL", service.ReadForValidation("BS-FAIL"), "Manager", "1234"));
Require(service.ReadHistory("BS-FAIL").Length == 0 && service.Read("BS-FAIL").Length == 2 &&
    Scalar("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK WHERE LIBELLE='Bon de Sortie | BS-FAIL'") == 0 &&
    Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='A'") == 10m &&
    Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='B'") == 3.625m,
    "History failure did not roll back stock, legacy journal and document.");
Console.WriteLine("PASS stock issue history persistence, reopen, authorization, replay and rollback.");

void Execute(string sql)
{
    using var command = new MySqlCommand(sql, connection);
    command.ExecuteNonQuery();
}

decimal Scalar(string sql)
{
    using var command = new MySqlCommand(sql, connection);
    return Convert.ToDecimal(command.ExecuteScalar());
}

static void Require(bool condition, string message)
{
    if (!condition) throw new InvalidOperationException(message);
}

static void Reject<T>(Action action) where T : Exception
{
    try { action(); }
    catch (T) { return; }
    throw new InvalidOperationException($"Expected rejection: {typeof(T).Name}");
}
