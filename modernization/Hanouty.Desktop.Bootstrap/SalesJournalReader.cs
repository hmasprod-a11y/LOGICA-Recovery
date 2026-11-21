using System.Data;
using System.Globalization;
using Hanouty.Desktop.Wpf;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class SalesJournalReader(string connectionString)
{
    internal sealed record Access(SalesJournalReader Owner, string Actor, string Role, bool Statistics);
    private MySqlConnection Open()
    {
        var cs = new MySqlConnectionStringBuilder(connectionString);
        if (cs.Server is not ("127.0.0.1" or "localhost" or "::1")) throw new InvalidOperationException("Base locale requise pour le journal.");
        cs.CharacterSet = "utf8mb4";
        var db = new MySqlConnection(cs.ConnectionString); db.Open(); return db;
    }
    private static MySqlCommand Command(MySqlConnection db, MySqlTransaction tx, string sql, params (string Name, object Value)[] parameters)
    {
        var command = new MySqlCommand(sql, db, tx);
        foreach (var (name, value) in parameters) command.Parameters.AddWithValue(name, value); return command;
    }
    private static void Tables(MySqlConnection db, MySqlTransaction tx)
    {
        foreach (var table in new[] { "TABLE_PASS", "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS" })
        {
            using var command = Command(db, tx, "SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table", ("@table", table));
            if (Convert.ToString(command.ExecuteScalar()) != "InnoDB") throw new InvalidOperationException("Journal transactionnel indisponible.");
        }
    }
    internal Access Authorize(string actor, Func<string> readPin, bool statistics = false)
    {
        var pin = readPin();
        try
        {
            if (string.IsNullOrWhiteSpace(actor) || string.IsNullOrWhiteSpace(pin)) throw new UnauthorizedAccessException("Autorisation du journal annulée.");
            using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.ReadCommitted); Tables(db, tx);
            using var command = Command(db, tx, "SELECT ListPass,Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor FOR UPDATE", ("@actor", actor));
            using var row = command.ExecuteReader();
            if (!row.Read()) throw new UnauthorizedAccessException("Utilisateur du journal introuvable.");
            if (row.IsDBNull(0) || row.IsDBNull(1) || row.GetString(0) != pin ||
                row.GetString(1) is not ("ADMIN" or "MANAGER") || statistics && row.GetString(1) != "ADMIN")
                throw new UnauthorizedAccessException("Journal : ADMIN/MANAGER requis. Statistiques : ADMIN requis.");
            var role = row.GetString(1); if (row.Read()) throw new UnauthorizedAccessException("Identité du journal ambiguë.");
            row.Close(); tx.Commit(); return new Access(this, actor, role, statistics);
        }
        finally { pin = ""; }
    }
    private void Check(Access access, MySqlConnection db, MySqlTransaction tx, bool statistics = false)
    {
        if (!ReferenceEquals(access.Owner, this) || statistics && !access.Statistics) throw new UnauthorizedAccessException("Autorisation du journal étrangère.");
        using var command = Command(db, tx, "SELECT Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor FOR UPDATE", ("@actor", access.Actor));
        using var row = command.ExecuteReader();
        if (!row.Read() || row.IsDBNull(0) || row.GetString(0) != access.Role || access.Role is not ("ADMIN" or "MANAGER") ||
            access.Statistics && access.Role != "ADMIN" || row.Read()) throw new UnauthorizedAccessException("La session ou le rôle du journal a changé.");
    }
    internal SalesJournalOptions Options(Access access)
    {
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead); Tables(db, tx); Check(access, db, tx);
        IReadOnlyList<string> List(string sql)
        {
            var values = new List<string> { "" }; using var command = Command(db, tx, sql); using var rows = command.ExecuteReader();
            while (rows.Read()) if (!rows.IsDBNull(0)) values.Add(Convert.ToString(rows.GetValue(0))!); return values.AsReadOnly();
        }
        var result = new SalesJournalOptions(List("SELECT DISTINCT ListUser FROM TABLE_PASS ORDER BY ListUser"),
            List("SELECT DISTINCT MODE_P FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P IS NOT NULL ORDER BY MODE_P"),
            List("SELECT DISTINCT OPERATION FROM TABLE_VENTES_ENTETE WHERE OPERATION IS NOT NULL ORDER BY OPERATION"));
        tx.Commit(); return result;
    }
    private const string FilterSql = "h.DATES>=@from AND h.DATES<@to AND (@cashier='' OR BINARY h.CAISSIER=BINARY @cashier) AND " +
        "(@operation='' OR BINARY h.OPERATION=BINARY @operation) AND (@mode='' OR EXISTS (SELECT 1 FROM TABLE_VENTES_REGLEMENTS pm " +
        "WHERE BINARY pm.ID_TICKET=BINARY h.ID_TICKET AND BINARY pm.MODE_P=BINARY @mode)) AND " +
        "(@empty=1 OR h.TICKET LIKE @search ESCAPE '!' OR h.ID_TICKET LIKE @search ESCAPE '!' OR h.CLIENT LIKE @search ESCAPE '!' OR " +
        "EXISTS (SELECT 1 FROM TABLE_VENTES_JOURNAL js WHERE BINARY js.ID_TICKET=BINARY h.ID_TICKET AND " +
        "(js.ARTICLE LIKE @search ESCAPE '!' OR js.CODE LIKE @search ESCAPE '!')))";
    private static (string, object)[] Parameters(SalesJournalFilter filter)
    {
        if (filter.From.Date > filter.To.Date || filter.To.Date == DateTime.MaxValue.Date || (filter.To.Date - filter.From.Date).TotalDays > 3660)
            throw new ArgumentException("Choisissez une période valide de dix ans au maximum.");
        if (new[] { filter.Cashier, filter.Mode, filter.Operation, filter.Search }.Any(value => value is null || value.Length > 255 || value.Any(char.IsControl)))
            throw new ArgumentException("Filtre du journal invalide.");
        var literal = filter.Search.Replace("!", "!!").Replace("%", "!%").Replace("_", "!_");
        return new[] { ("@from", (object)filter.From.Date), ("@to", filter.To.Date.AddDays(1)), ("@cashier", filter.Cashier),
            ("@operation", filter.Operation), ("@mode", filter.Mode), ("@empty", filter.Search.Length == 0 ? 1 : 0), ("@search", "%" + literal + "%") };
    }
    private static string Text(MySqlDataReader row, int i) => row.IsDBNull(i) ? "" : Convert.ToString(row.GetValue(i), CultureInfo.InvariantCulture)!;
    private static decimal Money(MySqlDataReader row, int i) => row.IsDBNull(i) ? 0m : Convert.ToDecimal(row.GetValue(i), CultureInfo.InvariantCulture);
    private static DateTime Date(MySqlDataReader row, int i) => row.IsDBNull(i) ? throw new InvalidOperationException("Date de ticket absente.") : Convert.ToDateTime(row.GetValue(i), CultureInfo.InvariantCulture);
    private const string HeaderSql = "SELECT h.ID_TICKET,h.TICKET,h.DATES,h.CAISSIER,h.POSTE,h.OPERATION,h.CLIENT,h.TOTAL_NET," +
        "COALESCE((SELECT SUM(j.Qté) FROM TABLE_VENTES_JOURNAL j WHERE BINARY j.ID_TICKET=BINARY h.ID_TICKET),0)," +
        "COALESCE((SELECT GROUP_CONCAT(DISTINCT p.MODE_P ORDER BY p.MODE_P SEPARATOR ';') FROM TABLE_VENTES_REGLEMENTS p WHERE BINARY p.ID_TICKET=BINARY h.ID_TICKET),'')," +
        "(SELECT COUNT(*) FROM TABLE_VENTES_ENTETE hh WHERE UPPER(hh.ID_TICKET)=UPPER(h.ID_TICKET)) FROM TABLE_VENTES_ENTETE h ";
    private static SalesJournalTicket Header(MySqlDataReader row) => new(Text(row, 0), Text(row, 1), Date(row, 2), Text(row, 3), Text(row, 4), Text(row, 5), Text(row, 6),
        Money(row, 7), Money(row, 8), Text(row, 9), Money(row, 10) == 1m && !string.IsNullOrWhiteSpace(Text(row, 0)) &&
        !string.IsNullOrWhiteSpace(Text(row, 3)) && !string.IsNullOrWhiteSpace(Text(row, 4)) && (Text(row, 5) is "VENTE" or "CREDIT" or "RETOUR REMBOURSEMENT" or "RETOUR CREDIT"));
    internal SalesJournalResult Read(Access access, SalesJournalFilter filter)
    {
        var parameters = Parameters(filter); using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead); Tables(db, tx); Check(access, db, tx);
        var tickets = new List<SalesJournalTicket>();
        using (var command = Command(db, tx, HeaderSql + "WHERE " + FilterSql + " ORDER BY h.DATES DESC,BINARY h.ID_TICKET DESC LIMIT 1001", parameters))
        using (var rows = command.ExecuteReader()) while (rows.Read()) tickets.Add(Header(rows));
        if (tickets.Count > 1000) throw new InvalidOperationException("Plus de 1000 tickets : précisez la période ou la recherche.");
        int ticketCount;
        using (var command = Command(db, tx, "SELECT COUNT(DISTINCT h.ID_TICKET) FROM TABLE_VENTES_ENTETE h WHERE " + FilterSql, parameters))
            ticketCount = Convert.ToInt32(command.ExecuteScalar());
        // Totals come from original signed journal rows, never header/payment
        // joins that duplicate line amounts when a sale has multiple modes.
        var journal = new List<(DateTime Date, string Cashier, string Operation, decimal Net, decimal Quantity)>();
        using (var command = Command(db, tx, "SELECT j.DATES,j.CAISSIER,j.OPERATION,j.TOTAL_NET,j.Qté FROM TABLE_VENTES_JOURNAL j WHERE " +
            "j.DATES>=@from AND j.DATES<@to AND (@cashier='' OR BINARY j.CAISSIER=BINARY @cashier) AND (@operation='' OR BINARY j.OPERATION=BINARY @operation) AND " +
            "(@mode='' OR EXISTS (SELECT 1 FROM TABLE_VENTES_REGLEMENTS pm WHERE BINARY pm.ID_TICKET=BINARY j.ID_TICKET AND BINARY pm.MODE_P=BINARY @mode)) AND " +
            "(@empty=1 OR j.TICKET LIKE @search ESCAPE '!' OR j.ID_TICKET LIKE @search ESCAPE '!' OR j.CLIENT LIKE @search ESCAPE '!' OR j.ARTICLE LIKE @search ESCAPE '!' OR j.CODE LIKE @search ESCAPE '!')", parameters))
        using (var rows = command.ExecuteReader()) while (rows.Read()) journal.Add((Date(rows, 0).Date, Text(rows, 1), Text(rows, 2), Money(rows, 3), Money(rows, 4)));
        decimal Sum(string operation) => journal.Where(row => row.Operation == operation).Sum(row => row.Net);
        var totals = new SalesJournalTotals(ticketCount, Sum("VENTE"), Sum("RETOUR REMBOURSEMENT"), Sum("CREDIT"), Sum("RETOUR CREDIT"), journal.Sum(row => row.Quantity));
        var payments = new List<SalesJournalPaymentTotal>();
        using (var command = Command(db, tx, "SELECT p.MODE_P,SUM(p.MONTANT) FROM TABLE_VENTES_REGLEMENTS p WHERE p.DATES>=@from AND p.DATES<@to AND p.OPERATION IN ('VENTE','RETOUR REMBOURSEMENT') AND " +
            "(@cashier='' OR BINARY p.CAISSIER=BINARY @cashier) AND (@operation='' OR BINARY p.OPERATION=BINARY @operation) AND (@mode='' OR BINARY p.MODE_P=BINARY @mode) AND " +
            "(@empty=1 OR p.TICKET LIKE @search ESCAPE '!' OR p.ID_TICKET LIKE @search ESCAPE '!' OR p.CLIENT LIKE @search ESCAPE '!' OR EXISTS " +
            "(SELECT 1 FROM TABLE_VENTES_JOURNAL js WHERE BINARY js.ID_TICKET=BINARY p.ID_TICKET AND (js.ARTICLE LIKE @search ESCAPE '!' OR js.CODE LIKE @search ESCAPE '!'))) GROUP BY p.MODE_P ORDER BY p.MODE_P", parameters))
        using (var rows = command.ExecuteReader()) while (rows.Read()) payments.Add(new(Text(rows, 0), Money(rows, 1)));
        var days = Enumerable.Range(0, (filter.To.Date - filter.From.Date).Days + 1).Select(offset =>
        {
            var date = filter.From.Date.AddDays(offset); var rows = journal.Where(row => row.Date == date).ToArray();
            return new SalesJournalDaily(date, rows.Where(row => row.Operation == "VENTE").Sum(row => row.Net), rows.Where(row => row.Operation == "RETOUR REMBOURSEMENT").Sum(row => row.Net),
                rows.Where(row => row.Operation == "CREDIT").Sum(row => row.Net), rows.Where(row => row.Operation == "RETOUR CREDIT").Sum(row => row.Net), rows.Sum(row => row.Quantity));
        }).ToArray();
        var cashiers = journal.GroupBy(row => row.Cashier).OrderBy(group => group.Key).Select(group => new SalesJournalCashier(group.Key,
            group.Where(row => row.Operation is "VENTE" or "RETOUR REMBOURSEMENT").Sum(row => row.Net),
            group.Where(row => row.Operation is "CREDIT" or "RETOUR CREDIT").Sum(row => row.Net), group.Sum(row => row.Quantity))).ToArray();
        tx.Commit(); return new(tickets.AsReadOnly(), totals, payments.AsReadOnly(), Array.AsReadOnly(days), Array.AsReadOnly(cashiers));
    }
    internal SalesJournalDetail Details(Access access, SalesJournalTicket expected)
    {
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.RepeatableRead); Tables(db, tx); Check(access, db, tx);
        SalesJournalTicket current;
        using (var command = Command(db, tx, HeaderSql + "WHERE UPPER(h.ID_TICKET)=UPPER(@id)", ("@id", expected.Id)))
        using (var row = command.ExecuteReader())
        {
            if (!row.Read()) throw new InvalidOperationException("Ticket introuvable."); current = Header(row);
            if (row.Read() || current != expected) throw new InvalidOperationException("Le ticket sélectionné a changé ou son identité est ambiguë. Actualisez le journal.");
        }
        var lines = new List<SalesJournalLine>();
        using (var command = Command(db, tx, "SELECT ID_ARTICLE,CODE,ARTICLE,FAMILLE,Qté,PRIX_V,REMISE,TOTAL_NET,OPERATION FROM TABLE_VENTES_JOURNAL WHERE BINARY ID_TICKET=BINARY @id ORDER BY BINARY ID_ARTICLE", ("@id", current.Id)))
        using (var rows = command.ExecuteReader()) while (rows.Read()) lines.Add(new(Text(rows, 0), Text(rows, 1), Text(rows, 2), Text(rows, 3), Money(rows, 4), Money(rows, 5), Money(rows, 6), Money(rows, 7), Text(rows, 8)));
        var payments = new List<SalesJournalPayment>();
        using (var command = Command(db, tx, "SELECT MODE_P,MONTANT,OPERATION FROM TABLE_VENTES_REGLEMENTS WHERE BINARY ID_TICKET=BINARY @id ORDER BY MODE_P,MONTANT DESC", ("@id", current.Id)))
        using (var rows = command.ExecuteReader()) while (rows.Read()) payments.Add(new(Text(rows, 0), Money(rows, 1), Text(rows, 2)));
        if (lines.Count == 0 || lines.Sum(row => row.Net) != current.Total || lines.Any(row => row.Operation != current.Operation))
            throw new InvalidOperationException("Détail du ticket incohérent avec son entête.");
        if (current.Operation is "VENTE" or "RETOUR REMBOURSEMENT" && payments.Sum(row => row.Amount) != current.Total ||
            current.Operation is "CREDIT" or "RETOUR CREDIT" && payments.Count != 0)
            throw new InvalidOperationException("Règlements incohérents avec l’opération du ticket.");
        tx.Commit(); return new(current, lines.AsReadOnly(), payments.AsReadOnly());
    }
}
