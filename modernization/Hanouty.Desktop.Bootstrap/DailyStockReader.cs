using System.Data;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

// Form_2_ARTICLES: état du stock and movement history; never posts a stock adjustment.
internal sealed class DailyStockReader(string connectionString)
{
    internal sealed record Access(DailyStockReader Owner, string Actor, string Permission, string Approver, string? ExactRole);
    internal sealed record Article(long RowId, string Id, string Code, string Name, string Family, string Reference,
        decimal? Stock, decimal? Alert, decimal? Cost, decimal? Price, string InventoryDate, string StockMode, bool CanonicalIdentity)
    {
        public bool StockAlert => Stock is decimal stock && Alert is decimal alert && stock <= alert && stock != 0m && StockMode is "FINI" or "MATIERE PREMIERE";
        public string State => !CanonicalIdentity ? "Identité à vérifier" : Stock < 0 ? "Stock négatif" : StockAlert ? "Alerte stock" : "";
    }
    internal sealed record Query(string Text, bool Exact, string Family, bool IgnoreZero, bool AlertsOnly, bool NegativeOnly);
    internal sealed record SearchResult(Article[] Articles, bool HasMore);
    internal sealed record Movement(long RowId, string Date, string Time, string Label, string ArticleId, string Code, string ArticleName, string RecordedQuantity);
    internal sealed record History(Article Current, Movement[] Movements, bool HasMore);

    private MySqlConnection Open()
    {
        var cs = new MySqlConnectionStringBuilder(connectionString);
        if (cs.Server is not ("127.0.0.1" or "localhost" or "::1")) throw new InvalidOperationException("Le stock nécessite la base locale de ce poste.");
        var db = new MySqlConnection(connectionString);
        try { db.Open(); return db; } catch { db.Dispose(); throw; }
    }
    private static MySqlCommand Command(MySqlConnection db, MySqlTransaction? tx, string sql, params (string Name, object Value)[] values)
    {
        var command = new MySqlCommand(sql, db, tx);
        foreach (var (name, value) in values) command.Parameters.AddWithValue(name, value);
        return command;
    }
    private static string ReadPermission(MySqlConnection db, MySqlTransaction? tx, string actor)
    {
        using var command = Command(db, tx, "SELECT ARTICLES,Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor", ("@actor", actor));
        using var row = command.ExecuteReader();
        if (!row.Read() || row.IsDBNull(0) || row.IsDBNull(1) || row.GetString(1) is not ("ADMIN" or "MANAGER" or "UTILISATEUR"))
            throw new UnauthorizedAccessException("Accès aux articles et au stock interdit.");
        var permission = row.GetString(0);
        if (permission is not ("VISIBLE" or "ACCES MANAGER" or "ACCES ADMIN") || row.Read()) throw new UnauthorizedAccessException("Accès aux articles et au stock interdit.");
        return permission;
    }
    internal Access Authorize(string actor, Func<string, string> readRolePin)
    {
        string permission;
        using (var db = Open()) permission = ReadPermission(db, null, actor);
        var role = permission == "ACCES MANAGER" ? "MANAGER" : permission == "ACCES ADMIN" ? "ADMIN" : null;
        var approver = actor;
        if (role is not null)
        {
            var pin = readRolePin(role);
            try
            {
                if (string.IsNullOrWhiteSpace(pin)) throw new UnauthorizedAccessException("Autorisation des articles annulée.");
                using var db = Open();
                using var command = Command(db, null, "SELECT ListUser FROM TABLE_PASS WHERE BINARY Catégorie=BINARY @role AND BINARY ListPass=BINARY @pin", ("@role", role), ("@pin", pin));
                using var row = command.ExecuteReader();
                if (!row.Read() || row.IsDBNull(0)) throw new UnauthorizedAccessException("PIN du rôle demandé invalide.");
                approver = row.GetString(0); if (row.Read()) throw new UnauthorizedAccessException("Autorisation du stock ambiguë.");
            }
            finally { pin = ""; }
        }
        var access = new Access(this, actor, permission, approver, role);
        using (var db = Open()) Check(access, db, null);
        return access;
    }
    private void Check(Access access, MySqlConnection db, MySqlTransaction? tx)
    {
        if (!ReferenceEquals(access.Owner, this) || ReadPermission(db, tx, access.Actor) != access.Permission)
            throw new UnauthorizedAccessException("L’accès aux articles a changé. Fermez puis rouvrez cette section.");
        if (access.ExactRole is null) return;
        using var command = Command(db, tx, "SELECT Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor", ("@actor", access.Approver));
        using var row = command.ExecuteReader();
        if (!row.Read() || row.IsDBNull(0) || row.GetString(0) != access.ExactRole || row.Read()) throw new UnauthorizedAccessException("L’autorisation du rôle demandé a changé.");
    }
    internal string[] Families(Access access)
    {
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead); Check(access, db, tx);
        using var command = Command(db, tx, "SELECT DISTINCT Famille FROM TABLE_ARTICLES WHERE Famille IS NOT NULL AND TRIM(Famille)<>'' ORDER BY Famille");
        var result = new List<string>(); using (var row = command.ExecuteReader()) while (row.Read()) result.Add(row.GetString(0));
        tx.Commit(); return result.ToArray();
    }
    private const string Columns = "a.ID,a.ID_ARTICLE,a.Code,a.Article,a.Famille,a.Reference,a.STOCK,a.Alert,a.Prix_A,a.PRIX_V_1,CAST(a.DATE_INVENTAIRE AS CHAR),a.MODE_STOCK," +
        "(a.ID_ARTICLE IS NOT NULL AND TRIM(a.ID_ARTICLE)<>'' AND NOT EXISTS (SELECT 1 FROM TABLE_ARTICLES d WHERE UPPER(d.ID_ARTICLE)=UPPER(a.ID_ARTICLE) AND d.ID<>a.ID))";
    private static Article ReadArticle(MySqlDataReader row)
    {
        string Text(int index) => row.IsDBNull(index) ? "" : Convert.ToString(row.GetValue(index), CultureInfo.InvariantCulture)!;
        decimal? Amount(int index) => row.IsDBNull(index) ? null : Convert.ToDecimal(row.GetValue(index), CultureInfo.InvariantCulture);
        return new Article(row.GetInt64(0), Text(1), Text(2), Text(3), Text(4), Text(5), Amount(6), Amount(7), Amount(8), Amount(9), Text(10), Text(11), row.GetBoolean(12));
    }
    internal SearchResult Search(Access access, Query query)
    {
        if (query.Text.Length > 255 || query.Family.Length > 255 || query.Text.Any(char.IsControl) || query.Family.Any(char.IsControl))
            throw new ArgumentException("La recherche doit contenir au maximum255 caractères sans caractères de contrôle.");
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead); Check(access, db, tx);
        using var command = Command(db, tx, "SELECT " + Columns + " FROM TABLE_ARTICLES a WHERE " +
            "(@empty=1 OR (@exact=1 AND (a.Code=@text OR a.Article=@text OR a.Reference=@text)) OR " +
            "(@exact=0 AND (INSTR(a.Code,@text)>0 OR INSTR(a.Article,@text)>0 OR INSTR(a.Reference,@text)>0))) " +
            "AND (@family='' OR a.Famille=@family) AND (@ignore=0 OR a.STOCK<>0) " +
            "AND (@alerts=0 OR (a.STOCK<=a.Alert AND a.STOCK<>0 AND a.MODE_STOCK IN ('FINI','MATIERE PREMIERE'))) " +
            "AND (@negative=0 OR (a.STOCK<0 AND a.MODE_STOCK IN ('FINI','MATIERE PREMIERE'))) ORDER BY a.ID DESC LIMIT 201",
            ("@empty", query.Text.Length == 0 ? 1 : 0), ("@text", query.Text), ("@exact", query.Exact ? 1 : 0), ("@family", query.Family),
            ("@ignore", query.IgnoreZero ? 1 : 0), ("@alerts", query.AlertsOnly ? 1 : 0), ("@negative", query.NegativeOnly ? 1 : 0));
        var rows = new List<Article>(); using (var row = command.ExecuteReader()) while (row.Read()) rows.Add(ReadArticle(row));
        tx.Commit(); return new SearchResult(rows.Take(200).ToArray(), rows.Count > 200);
    }
    internal History Movements(Access access, Article selected, DateTime firstDay, DateTime lastDay)
    {
        if (firstDay.Date > lastDay.Date || lastDay.Date == DateTime.MaxValue.Date) throw new ArgumentException("Choisissez une période valide pour les mouvements.");
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead); Check(access, db, tx);
        Article current;
        using (var command = Command(db, tx, "SELECT " + Columns + " FROM TABLE_ARTICLES a WHERE a.ID=@row", ("@row", selected.RowId)))
        using (var row = command.ExecuteReader())
        {
            if (!row.Read()) throw new InvalidOperationException("Cet article n’existe plus. Actualisez le stock.");
            current = ReadArticle(row);
            if (!current.CanonicalIdentity || current.Id != selected.Id || current.Code != selected.Code || current.Name != selected.Name || row.Read())
                throw new InvalidOperationException("L’identité de l’article a changé. Actualisez puis sélectionnez-le de nouveau.");
        }
        using var history = Command(db, tx, "SELECT ID,CAST(DATES AS CHAR),HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE " +
            "FROM TABLE_MOUVEMENTS_STOCK WHERE ID_ARTICLE=@id AND DATES>=@first AND DATES<@last ORDER BY ID DESC LIMIT 501",
            ("@id", current.Id), ("@first", firstDay.Date), ("@last", lastDay.Date.AddDays(1)));
        var movements = new List<Movement>();
        using (var row = history.ExecuteReader()) while (row.Read())
        {
            string Text(int index) => row.IsDBNull(index) ? "" : Convert.ToString(row.GetValue(index), CultureInfo.InvariantCulture)!;
            movements.Add(new Movement(row.GetInt64(0), Text(1), Text(2), Text(3), Text(4), Text(5), Text(6), Text(7)));
        }
        tx.Commit(); return new History(current, movements.Take(500).ToArray(), movements.Count > 500);
    }
    internal void Recheck(Access access) { using var db = Open(); Check(access, db, null); }
}
