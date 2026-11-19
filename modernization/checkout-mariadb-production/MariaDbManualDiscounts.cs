using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Hanouty.ArchitectureBridge;
using LOGICA.Domain;
using MySql.Data.MySqlClient;

namespace Hanouty.Checkout.MariaDb
{
    public sealed record ManualDiscountLine(string ArticleId, decimal Percentage);

    // Only this production assembly can mint an approval. WPF receives no PIN,
    // mutable grant fields, or constructor capable of creating authorization.
    public sealed class ManualDiscountAuthorization
    {
        internal readonly ManualDiscountGrant State;
        internal ManualDiscountAuthorization(ManualDiscountGrant state) { State = state; }
    }

    public sealed class ApprovedManualDiscount
    {
        internal readonly ManualDiscountGrant State;
        public IReadOnlyList<ManualDiscountLine> Lines { get; }
        public string CashierId => State.Cashier;
        public string RegisterId => State.Register;
        public string Approver => State.Approver;
        internal ApprovedManualDiscount(ManualDiscountGrant state, IEnumerable<ManualDiscountLine> lines)
        {
            State = state;
            Lines = Array.AsReadOnly(lines.ToArray());
        }
        public decimal? PercentageFor(string articleId) =>
            Lines.SingleOrDefault(line => string.Equals(line.ArticleId, articleId, StringComparison.Ordinal))?.Percentage;
        internal void BindOperation(string operation) => State.BindOperation(operation);
    }

    internal sealed class ManualDiscountGrant
    {
        internal readonly string Cashier, Register, Access, Approver, DatabaseScope;
        internal readonly string RequiredRole;
        private readonly object sync = new object();
        private bool applied;
        private string operation;
        internal ManualDiscountGrant(string cashier, string register, string access, string approver, string role, string databaseScope)
        {
            Cashier = cashier; Register = register; Access = access; Approver = approver; RequiredRole = role;
            DatabaseScope = databaseScope;
        }
        internal void ApplyOnce()
        {
            lock (sync)
            {
                if (applied) throw new UnauthorizedAccessException("Cette autorisation de remise a déjà été utilisée.");
                applied = true;
            }
        }
        internal void BindOperation(string id)
        {
            lock (sync)
            {
                if (!applied || string.IsNullOrWhiteSpace(id) || (operation != null && operation != id))
                    throw new UnauthorizedAccessException("La remise appartient à une autre opération.");
                operation = id;
            }
        }
    }

    public sealed record AuthorizedWaitingBasket(
        IReadOnlyList<CheckoutBatchLine> Lines, ApprovedManualDiscount Approval);
    public sealed record ManualDiscountPreview(decimal Percentage, decimal NetTotal, decimal Savings);

    public static partial class MariaDbCashCheckoutServices
    {
        private sealed record ManualAccess(string User, string Role, string Access);
        private sealed record SavedWaitingLine(string ArticleId, int Quantity, decimal Unit, decimal Discount, decimal Net);

        public static bool CanUseManualDiscount(Func<MySqlConnection> connections, string cashier)
        {
            if (string.IsNullOrWhiteSpace(cashier)) return false;
            try
            {
                using var connection = LocalConnection(connections);
                connection.Open();
                using var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                var access = ReadManualAccess(connection, transaction, cashier, false);
                return access.Access != "INVISIBLE" && KnownManualAccess(access.Access);
            }
            catch (Exception ex) when (ex is MySqlException || ex is InvalidOperationException ||
                ex is UnauthorizedAccessException || ex is ArgumentException) { return false; }
        }

        public static ManualDiscountAuthorization AuthorizeManualDiscount(
            Func<MySqlConnection> connections, string cashier, string register, Func<string, string> readRolePin)
        {
            if (string.IsNullOrWhiteSpace(cashier) || cashier != cashier.Trim() || cashier.Length > 64 ||
                cashier.Any(char.IsControl) || register == null || register.Length != 2 ||
                register.Any(character => character < '0' || character > '9'))
                throw new ArgumentException("Une session de caisse valide est requise.");
            using var connection = LocalConnection(connections);
            connection.Open();
            using var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            var first = ReadManualAccess(connection, transaction, cashier, false);
            if (!KnownManualAccess(first.Access) || first.Access == "INVISIBLE")
                throw new UnauthorizedAccessException("La remise est interdite pour cette session.");
            string required = RequiredManualRole(first.Access);
            string approver = cashier;
            string pin = null;
            try
            {
                if (required != null)
                {
                    pin = readRolePin?.Invoke(required);
                    if (string.IsNullOrWhiteSpace(pin) || pin.Length > 256)
                        throw new UnauthorizedAccessException("Autorisation de remise non confirmée.");
                    pin = pin.Trim();
                    var candidates = DiscountRows(connection, transaction,
                        "SELECT ListUser FROM TABLE_PASS WHERE BINARY ListPass=BINARY @pin AND BINARY Catégorie=BINARY @role",
                        ("@pin", pin), ("@role", required));
                    if (candidates.Rows.Count != 1 || candidates.Rows[0].IsNull(0))
                        throw new UnauthorizedAccessException("Le PIN ne correspond pas au rôle demandé.");
                    approver = Convert.ToString(candidates.Rows[0][0]);
                }
                // No financial rows are locked while a person enters the PIN.
                // Lock identities consistently, then verify the same credentials/configuration.
                foreach (var user in new[] { cashier, approver }.Distinct(StringComparer.Ordinal).OrderBy(id => id, StringComparer.Ordinal))
                    ReadManualAccess(connection, transaction, user, true, requireAccess: user == cashier);
                var current = ReadManualAccess(connection, transaction, cashier, true);
                if (current != first)
                    throw new UnauthorizedAccessException("Les droits ont changé. Revoyez la remise.");
                if (required != null && DiscountRows(connection, transaction,
                    "SELECT ListUser FROM TABLE_PASS WHERE BINARY ListUser=BINARY @user AND " +
                    "BINARY ListPass=BINARY @pin AND BINARY Catégorie=BINARY @role FOR UPDATE",
                    ("@user", approver), ("@pin", pin), ("@role", required)).Rows.Count != 1)
                    throw new UnauthorizedAccessException("L’autorisation de remise a changé.");
                transaction.Commit();
                return new ManualDiscountAuthorization(new ManualDiscountGrant(cashier, register, first.Access,
                    approver, required, ManualDatabaseScope(connection)));
            }
            finally { pin = null; }
        }

        public static ApprovedManualDiscount ApplyManualDiscount(
            Func<MySqlConnection> connections, ManualDiscountAuthorization authorization,
            IReadOnlyList<CheckoutBatchLine> basket, ApprovedManualDiscount previous,
            string articleId, bool percentage, decimal value, ManualDiscountPreview expectedPreview = null)
        {
            if (authorization == null || value < 0m)
                throw new ArgumentException("Saisissez une remise positive ou nulle.");
            using var connection = LocalConnection(connections);
            connection.Open();
            using var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            var calculation = CalculateManualDiscount(connection, transaction, authorization, basket,
                previous, articleId, percentage, value);
            if (expectedPreview != null && expectedPreview !=
                new ManualDiscountPreview(calculation.Rate, calculation.Net, calculation.Savings))
                throw new InvalidOperationException("Le prix a changé. Revoyez la remise avant de l’appliquer.");
            authorization.State.ApplyOnce();
            transaction.Commit();
            return calculation.Approval;
        }

        public static ManualDiscountPreview PreviewManualDiscount(
            Func<MySqlConnection> connections, ManualDiscountAuthorization authorization,
            IReadOnlyList<CheckoutBatchLine> basket, ApprovedManualDiscount previous,
            string articleId, bool percentage, decimal value)
        {
            if (authorization == null || value < 0m)
                throw new ArgumentException("Saisissez une remise positive ou nulle.");
            using var connection = LocalConnection(connections);
            connection.Open();
            using var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            var calculation = CalculateManualDiscount(connection, transaction, authorization, basket,
                previous, articleId, percentage, value);
            transaction.Commit();
            return new ManualDiscountPreview(calculation.Rate, calculation.Net, calculation.Savings);
        }

        private static (ApprovedManualDiscount Approval, decimal Rate, decimal Net, decimal Savings)
            CalculateManualDiscount(MySqlConnection connection, MySqlTransaction transaction,
            ManualDiscountAuthorization authorization, IReadOnlyList<CheckoutBatchLine> basket,
            ApprovedManualDiscount previous, string articleId, bool percentage, decimal value)
        {
            if (percentage && value > 100m)
                throw new ArgumentException("La remise doit être comprise entre 0 et 100 %.");
            ValidateManualGrant(authorization.State, connection, transaction);
            if (previous != null && (previous.CashierId != authorization.State.Cashier ||
                previous.RegisterId != authorization.State.Register ||
                previous.State.DatabaseScope != authorization.State.DatabaseScope))
                throw new UnauthorizedAccessException("La remise ne correspond plus à cette session.");
            var quoted = ReadCashSaleBasketInTransaction(connection, transaction, basket, previous);
            if (quoted.Count == 0) throw new InvalidOperationException("Le panier est vide.");
            var targets = articleId == null ? quoted.ToArray() :
                quoted.Where(line => string.Equals(line.ArticleId, articleId, StringComparison.Ordinal)).ToArray();
            if (targets.Length == 0) throw new InvalidOperationException("Sélectionnez un article du panier.");
            decimal rate;
            try
            {
                // Exact FormDialog_REMISE operation order, including the DH conversions.
                if (percentage) rate = Math.Round(value, 2, MidpointRounding.ToEven);
                else if (articleId == null)
                {
                    var denominator = quoted.Sum(line => line.Amount);
                    if (denominator <= 0m) throw new ArgumentException("Le total ne permet pas cette remise en montant.");
                    rate = Math.Round(checked(value * 100m) / denominator, 2, MidpointRounding.ToEven);
                }
                else
                {
                    var denominator = Math.Round(checked(targets[0].UnitPrice * targets[0].Quantity),
                        2, MidpointRounding.ToEven);
                    if (denominator <= 0m) throw new ArgumentException("Le prix ne permet pas cette remise en montant.");
                    var divided = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(
                        Microsoft.VisualBasic.CompilerServices.Operators.DivideObject(
                            value.ToString(System.Globalization.CultureInfo.CurrentCulture), denominator));
                    rate = Convert.ToDecimal(Math.Round(Convert.ToDouble(divided) / 0.01d, 2));
                }
            }
            catch (OverflowException) { throw new ArgumentException("Le montant de remise est trop grand."); }
            if (rate < 0m || rate > 100m)
                throw new ArgumentException("La remise doit être comprise entre 0 et 100 %.");
            var rates = previous?.Lines.Where(line => basket.Any(item => item.ArticleId == line.ArticleId))
                .ToDictionary(line => line.ArticleId, line => line.Percentage, StringComparer.Ordinal)
                ?? new Dictionary<string, decimal>(StringComparer.Ordinal);
            foreach (var target in targets) rates[target.ArticleId] = rate;
            var result = new ApprovedManualDiscount(authorization.State,
                rates.Select(item => new ManualDiscountLine(item.Key, item.Value)));
            var net = ReadCashSaleBasketInTransaction(connection, transaction, basket, result).Sum(line => line.Amount);
            if (net <= 0m)
                throw new ArgumentException("Le net du ticket doit rester positif.");
            var savings = Math.Round(quoted.Sum(line => checked(line.UnitPrice * line.Quantity)) - net,
                2, MidpointRounding.ToEven);
            return (result, rate, net, savings);
        }

        public static ApprovedManualDiscount RetainManualDiscountForBasket(
            ApprovedManualDiscount approval, IReadOnlyList<CheckoutBatchLine> basket)
        {
            if (approval == null) return null;
            var retained = approval.Lines.Where(line => basket.Any(item =>
                string.Equals(item.ArticleId, line.ArticleId, StringComparison.Ordinal))).ToArray();
            return retained.Length == 0 ? null : new ApprovedManualDiscount(approval.State, retained);
        }

        public static void ValidateManualDiscountForWaiting(ApprovedManualDiscount approval,
            string cashier, string register, IReadOnlyList<CheckoutBatchLine> lines,
            MySqlConnection connection, MySqlTransaction transaction) =>
            ValidateManualDiscountForPosting(approval, cashier, register, lines, connection, transaction);

        public static AuthorizedWaitingBasket ReadWaitingBasketForAuthorizedResume(
            Func<MySqlConnection> connections, string waitingId, string cashier, string register,
            Func<string, string> readRolePin)
        {
            if (string.IsNullOrWhiteSpace(waitingId) || waitingId.Length > 64 ||
                waitingId != waitingId.Trim() || waitingId.Any(char.IsControl))
                throw new ArgumentException("Sélectionnez une attente valide.");
            SavedWaitingLine[] saved;
            IReadOnlyList<CashSaleBasketLine> automatic;
            using (var previewConnection = LocalConnection(connections))
            {
                previewConnection.Open();
                using var previewTransaction = previewConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                (saved, automatic) = ReadSavedWaitingConditions(previewConnection, previewTransaction, waitingId);
                previewTransaction.Commit();
            }
            var lines = Array.AsReadOnly(saved.Select(line => new CheckoutBatchLine(line.ArticleId, line.Quantity)).ToArray());
            var rates = saved.Where((line, index) => line.Discount != automatic[index].DiscountPercent)
                .Select(line => new ManualDiscountLine(line.ArticleId, line.Discount)).ToArray();
            if (rates.Length == 0) return new AuthorizedWaitingBasket(lines, null);

            // A persisted percentage is price evidence, not a fresh permission.
            // Authorize before locking waiting/article rows while the PIN dialog is open.
            var authorization = AuthorizeManualDiscount(connections, cashier, register, readRolePin);
            using var connection = LocalConnection(connections);
            connection.Open();
            using var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
            ValidateManualGrant(authorization.State, connection, transaction);
            var current = ReadSavedWaitingConditions(connection, transaction, waitingId);
            if (!saved.SequenceEqual(current.Saved) || !automatic.SequenceEqual(current.Automatic))
                throw new InvalidOperationException("L’attente ou le catalogue a changé pendant l’autorisation.");
            authorization.State.ApplyOnce();
            var approval = new ApprovedManualDiscount(authorization.State, rates);
            transaction.Commit();
            return new AuthorizedWaitingBasket(lines, approval);
        }

        private static (SavedWaitingLine[] Saved, IReadOnlyList<CashSaleBasketLine> Automatic)
            ReadSavedWaitingConditions(MySqlConnection connection, MySqlTransaction transaction, string waitingId)
        {
            RequireInnoDb(connection, transaction, "TABLE_ATTENTE");
            var rows = DiscountRows(connection, transaction,
                "SELECT ID_ARTICLE,Qté AS quantity,PRIX_V AS unit,Remise AS discount,TOTAL_NET AS net,ID_CLIENT " +
                "FROM TABLE_ATTENTE WHERE V=@id ORDER BY BINARY ID_ARTICLE FOR UPDATE", ("@id", waitingId));
            var saved = new List<SavedWaitingLine>();
            foreach (DataRow row in rows.Rows)
            {
                if (row.IsNull("ID_ARTICLE") || row.IsNull("quantity") || row.IsNull("unit") ||
                    row.IsNull("discount") || row.IsNull("net"))
                    throw new InvalidOperationException("L’attente contient des données incomplètes.");
                var quantity = Convert.ToDecimal(row["quantity"]);
                var unit = Convert.ToDecimal(row["unit"]);
                var discount = Convert.ToDecimal(row["discount"]);
                var net = Convert.ToDecimal(row["net"]);
                var customer = row.IsNull("ID_CLIENT") ? "" : Convert.ToString(row["ID_CLIENT"]);
                if (quantity <= 0m || quantity > int.MaxValue || quantity != decimal.Truncate(quantity) ||
                    unit < 0m || discount < 0m || discount > 100m || net < 0m ||
                    (customer != "" && customer != "0") ||
                    Math.Round(SalesLinePricing.CalculateNetAmount(unit, quantity, discount),
                        2, MidpointRounding.ToEven) != net)
                    throw new InvalidOperationException("Reprenez cette attente dans LOGICA pour conserver ses conditions.");
                saved.Add(new SavedWaitingLine(Convert.ToString(row["ID_ARTICLE"]), (int)quantity, unit, discount, net));
            }
            if (saved.Count == 0 || saved.Sum(line => line.Net) <= 0m)
                throw new InvalidOperationException("L’attente doit contenir un ticket au net positif.");
            var lines = saved.Select(line => new CheckoutBatchLine(line.ArticleId, line.Quantity)).ToArray();
            var automatic = ReadCashSaleBasketInTransaction(connection, transaction, lines);
            if (saved.Where((line, index) => line.Unit != automatic[index].UnitPrice).Any())
                throw new InvalidOperationException("Le prix de l’attente a changé. Reprenez-la dans LOGICA.");
            return (saved.ToArray(), automatic);
        }

        internal static void ValidateManualDiscountForPosting(ApprovedManualDiscount approval,
            string cashier, string register, IReadOnlyList<CheckoutBatchLine> lines,
            MySqlConnection connection, MySqlTransaction transaction)
        {
            if (approval == null) return;
            if (approval.CashierId != cashier || approval.RegisterId != register || approval.Lines.Count == 0 ||
                approval.Lines.Any(line => line.Percentage < 0m || line.Percentage > 100m ||
                    !lines.Any(item => string.Equals(item.ArticleId, line.ArticleId, StringComparison.Ordinal))))
                throw new UnauthorizedAccessException("La remise ne correspond pas au panier de cette session.");
            ValidateManualGrant(approval.State, connection, transaction);
        }

        private static void ValidateManualGrant(ManualDiscountGrant grant,
            MySqlConnection connection, MySqlTransaction transaction)
        {
            if (grant.DatabaseScope != ManualDatabaseScope(connection))
                throw new UnauthorizedAccessException("Cette autorisation appartient à une autre base de caisse.");
            foreach (var user in new[] { grant.Cashier, grant.Approver }.Distinct(StringComparer.Ordinal).OrderBy(id => id, StringComparer.Ordinal))
                ReadManualAccess(connection, transaction, user, true, requireAccess: user == grant.Cashier);
            var access = ReadManualAccess(connection, transaction, grant.Cashier, true);
            if (!KnownManualAccess(access.Access) || access.Access == "INVISIBLE" ||
                access.Access != grant.Access || RequiredManualRole(access.Access) != grant.RequiredRole)
                throw new UnauthorizedAccessException("Les droits de remise ont changé.");
            if (grant.RequiredRole != null && DiscountRows(connection, transaction,
                "SELECT ListUser FROM TABLE_PASS WHERE BINARY ListUser=BINARY @user " +
                "AND BINARY Catégorie=BINARY @role FOR UPDATE", ("@user", grant.Approver),
                ("@role", grant.RequiredRole)).Rows.Count != 1)
                throw new UnauthorizedAccessException("Le rôle ayant autorisé la remise n’est plus valide.");
        }

        private static bool KnownManualAccess(string access) =>
            access == "VISIBLE" || access == "INVISIBLE" || access == "ACCES MANAGER" || access == "ACCES ADMIN";
        private static string RequiredManualRole(string access) =>
            access == "ACCES MANAGER" ? "MANAGER" : access == "ACCES ADMIN" ? "ADMIN" : null;

        private static string ManualDatabaseScope(MySqlConnection connection)
        {
            var source = new MySqlConnectionStringBuilder(connection.ConnectionString);
            return new MySqlConnectionStringBuilder {
                Server = source.Server, Port = source.Port, Database = source.Database, UserID = source.UserID
            }.ConnectionString;
        }

        private static ManualAccess ReadManualAccess(MySqlConnection connection, MySqlTransaction transaction,
            string user, bool locked, bool requireAccess = true)
        {
            RequireInnoDb(connection, transaction, "TABLE_PASS");
            var rows = DiscountRows(connection, transaction,
                "SELECT ListUser,Catégorie," + (requireAccess ? "REMISE" : "NULL") +
                " FROM TABLE_PASS WHERE BINARY ListUser=BINARY @user" + (locked ? " FOR UPDATE" : ""),
                ("@user", user));
            if (rows.Rows.Count != 1 || rows.Rows[0].IsNull(0) || rows.Rows[0].IsNull(1) ||
                !new[] { "ADMIN", "MANAGER", "UTILISATEUR" }.Contains(Convert.ToString(rows.Rows[0][1])) ||
                (requireAccess && rows.Rows[0].IsNull(2)))
                throw new UnauthorizedAccessException("Droits de remise indisponibles pour cet utilisateur.");
            return new ManualAccess(Convert.ToString(rows.Rows[0][0]), Convert.ToString(rows.Rows[0][1]),
                rows.Rows[0].IsNull(2) ? "" : Convert.ToString(rows.Rows[0][2]));
        }

        private static DataTable DiscountRows(MySqlConnection connection, MySqlTransaction transaction,
            string sql, params (string Name, object Value)[] parameters)
        {
            using var command = new MySqlCommand(sql, connection, transaction);
            foreach (var parameter in parameters) command.Parameters.AddWithValue(parameter.Name, parameter.Value);
            using var reader = command.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }
    }
}
