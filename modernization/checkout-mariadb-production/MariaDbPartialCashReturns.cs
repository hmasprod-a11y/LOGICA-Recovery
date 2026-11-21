using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Hanouty.ArchitectureBridge;
using LOGICA.Domain;
using LOGICA.Infrastructure.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class PartialCashReturnEvidence
    {
        internal static void RequireLedger(MySqlConnection db, MySqlTransaction tx)
        {
            using (var command = new MySqlCommand("SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='hanouty_return_line_consumption'", db, tx))
                if (Convert.ToString(command.ExecuteScalar()) != "InnoDB") throw new InvalidOperationException("Explicit transactional partial-return migration is required.");
            using (var command = new MySqlCommand("SELECT COUNT(*) FROM (SELECT INDEX_NAME FROM information_schema.STATISTICS WHERE TABLE_SCHEMA=DATABASE() " +
                "AND TABLE_NAME='hanouty_return_line_consumption' AND NON_UNIQUE=0 GROUP BY INDEX_NAME HAVING COUNT(*)=2 " +
                "AND SUM(COLUMN_NAME IN ('original_ticket_id','article_id'))=2 AND SUM(SUB_PART IS NOT NULL)=0) AS exact_identity", db, tx))
                if (Convert.ToInt64(command.ExecuteScalar()) < 1) throw new InvalidOperationException("Partial-return original/article identity requires a full unique index.");
        }

        internal static IReadOnlyList<CheckoutOriginalReturnLineSnapshot> Read(MySqlConnection db, MySqlTransaction tx, string original)
        {
            RequireLedger(db, tx);
            // The original header is the common serialization point for all full
            // and partial paths, across independent cashiers and operation IDs.
            using (var command = new MySqlCommand("SELECT ID_TICKET,OPERATION FROM TABLE_VENTES_ENTETE WHERE UPPER(ID_TICKET)=UPPER(@id) FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@id", original); using var row = command.ExecuteReader();
                if (!row.Read() || row.IsDBNull(0) || row.IsDBNull(1) || row.GetString(0) != original || row.GetString(1) != "VENTE" || row.Read())
                    throw new InvalidOperationException("Unique canonical cash original required.");
            }
            using (var command = new MySqlCommand("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE UPPER(original_ticket_id)=UPPER(@id) FOR UPDATE", db, tx))
            { command.Parameters.AddWithValue("@id", original); if (Convert.ToInt64(command.ExecuteScalar()) != 0) throw new InvalidOperationException("Original ticket was already fully returned."); }
            var originalLines = CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLines(db, tx, original);
            var snapshots = new Dictionary<string, CheckoutOriginalReturnLineSnapshot>(StringComparer.Ordinal);
            using (var command = new MySqlCommand("SELECT ID_ARTICLE,ARTICLE,PRIX_V,REMISE FROM TABLE_VENTES_JOURNAL WHERE BINARY ID_TICKET=BINARY @id ORDER BY BINARY ID_ARTICLE FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@id", original); using var row = command.ExecuteReader();
                while (row.Read())
                {
                    if (Enumerable.Range(0, 4).Any(row.IsDBNull)) throw new InvalidOperationException("Incomplete original partial-return price snapshot.");
                    var id = row.GetString(0); var line = originalLines.Single(item => item.ArticleId == id);
                    if (!snapshots.TryAdd(id, new CheckoutOriginalReturnLineSnapshot(id, row.GetString(1), line.Quantity,
                        Convert.ToDecimal(row.GetValue(2)), Convert.ToDecimal(row.GetValue(3)), line.Amount, 0m, 0m)))
                        throw new InvalidOperationException("Duplicate original partial-return line.");
                }
            }
            var consumed = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            using (var command = new MySqlCommand("SELECT original_ticket_id,article_id,returned_quantity,returned_net FROM hanouty_return_line_consumption " +
                "WHERE UPPER(original_ticket_id)=UPPER(@id) ORDER BY BINARY article_id FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@id", original); using var row = command.ExecuteReader();
                while (row.Read())
                {
                    if (Enumerable.Range(0, 4).Any(row.IsDBNull)) throw new InvalidOperationException("Incomplete partial-return consumption.");
                    var id = row.GetString(1); var quantity = Convert.ToDecimal(row.GetValue(2)); var amount = Convert.ToDecimal(row.GetValue(3));
                    if (row.GetString(0) != original || !consumed.Add(id) || !snapshots.TryGetValue(id, out var source) ||
                        quantity <= 0m || decimal.Truncate(quantity) != quantity || quantity > source.OriginalQuantity || amount < 0m || amount > source.OriginalNet ||
                        !Supports(source) || amount != UnitNet(source) * quantity)
                        throw new InvalidOperationException("Partial-return cumulative quantity/net is inconsistent with its original.");
                    snapshots[id] = source with { ReturnedQuantity = quantity, ReturnedNet = amount };
                }
            }
            return snapshots.Values.ToArray();
        }

        internal static decimal UnitNet(CheckoutOriginalReturnLineSnapshot line) =>
            SalesLinePricing.CalculateNetAmount(line.OriginalUnitPrice, 1m, line.OriginalDiscountPercent);
        internal static bool Supports(CheckoutOriginalReturnLineSnapshot line)
        {
            var unit = UnitNet(line);
            return line.OriginalQuantity > 0m && line.OriginalQuantity <= int.MaxValue && decimal.Truncate(line.OriginalQuantity) == line.OriginalQuantity &&
                unit >= 0m && decimal.Round(unit, 2) == unit && unit * line.OriginalQuantity == line.OriginalNet;
        }

        internal static decimal Validate(IReadOnlyList<CheckoutOriginalReturnLineSnapshot> current, IReadOnlyList<CheckoutPartialReturnSelection> selections)
        {
            if (selections is null || selections.Count == 0 || selections.Any(item => item is null || item.Original is null || item.Quantity <= 0) ||
                selections.Select(item => item.Original.ArticleId).Distinct(StringComparer.OrdinalIgnoreCase).Count() != selections.Count)
                throw new InvalidOperationException("Select distinct original lines and positive whole quantities.");
            decimal total = 0m;
            foreach (var selected in selections)
            {
                var original = current.SingleOrDefault(line => line.ArticleId == selected.Original.ArticleId);
                if (original is null || original != selected.Original || !Supports(original) || selected.Quantity > original.OriginalQuantity - original.ReturnedQuantity)
                    throw new InvalidOperationException("Original price, returned quantity or selected amount changed; review remaining original lines.");
                var amount = UnitNet(original) * selected.Quantity;
                if (original.ReturnedNet + amount > original.OriginalNet || decimal.Round(amount, 2) != amount)
                    throw new InvalidOperationException("Partial refund exceeds original net or needs unsupported rounding.");
                total = checked(total + amount);
            }
            if (total <= 0m) throw new InvalidOperationException("A positive exact-cent partial refund is required.");
            return total;
        }

        internal static decimal VerifyAndClaim(MySqlConnection db, MySqlTransaction tx, AuthorizedCheckoutRequest request)
        {
            if (request.PartialCashReturn is null || string.Equals(request.OperationId, request.OriginalTicketId, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("A reviewed new partial-return operation is required.");
            var selections = request.PartialCashReturn.Selections;
            var current = Read(db, tx, request.OriginalTicketId); var total = Validate(current, selections);
            if (request.Payments.Count != 1 || request.Payments[0].Kind != CheckoutPaymentKind.Cash || request.Payments[0].Amount != total || request.ExpectedTotal != total ||
                request.Lines.Count != selections.Count || selections.Any(item => request.Lines.Count(line => line.ArticleId == item.Original.ArticleId && line.Quantity == item.Quantity) != 1))
                throw new InvalidOperationException("Partial cash refund must equal the reviewed original quantities and net.");
            foreach (var selected in selections.OrderBy(item => item.Original.ArticleId, StringComparer.Ordinal))
            {
                var old = selected.Original; var quantity = old.ReturnedQuantity + selected.Quantity; var net = old.ReturnedNet + UnitNet(old) * selected.Quantity;
                using (var command = new MySqlCommand(old.ReturnedQuantity == 0m
                    ? "INSERT INTO hanouty_return_line_consumption (original_ticket_id,article_id,returned_quantity,returned_net,last_operation_id) VALUES (@original,@article,@quantity,@net,@operation)"
                    : "UPDATE hanouty_return_line_consumption SET returned_quantity=@quantity,returned_net=@net,last_operation_id=@operation WHERE BINARY original_ticket_id=BINARY @original AND BINARY article_id=BINARY @article AND returned_quantity=@oldQuantity AND returned_net=@oldNet", db, tx))
                {
                    command.Parameters.AddWithValue("@original", request.OriginalTicketId); command.Parameters.AddWithValue("@article", old.ArticleId);
                    command.Parameters.AddWithValue("@quantity", quantity); command.Parameters.AddWithValue("@net", net); command.Parameters.AddWithValue("@operation", request.OperationId);
                    command.Parameters.AddWithValue("@oldQuantity", old.ReturnedQuantity); command.Parameters.AddWithValue("@oldNet", old.ReturnedNet);
                    if (command.ExecuteNonQuery() != 1) throw new InvalidOperationException("Partial-return cumulative consumption changed.");
                }
                using (var command = new MySqlCommand("SELECT returned_quantity,returned_net,last_operation_id FROM hanouty_return_line_consumption WHERE " +
                    "BINARY original_ticket_id=BINARY @original AND BINARY article_id=BINARY @article FOR UPDATE", db, tx))
                {
                    command.Parameters.AddWithValue("@original", request.OriginalTicketId); command.Parameters.AddWithValue("@article", old.ArticleId); using var row = command.ExecuteReader();
                    if (!row.Read() || Enumerable.Range(0, 3).Any(row.IsDBNull) || Convert.ToDecimal(row.GetValue(0)) != quantity || Convert.ToDecimal(row.GetValue(1)) != net ||
                        row.GetString(2) != request.OperationId || row.Read()) throw new InvalidOperationException("Persisted partial-return quantity, net or operation changed.");
                }
            }
            return total;
        }
    }
}

namespace Hanouty.Checkout.MariaDb
{
    public static partial class MariaDbCashCheckoutServices
    {
        public sealed record PartialCashReturnCandidate(string SaleId, string TicketNumber, string ReceiptDate, string Register,
            decimal OriginalPaidMad, decimal RemainingNetMad, IReadOnlyList<CheckoutOriginalReturnLineSnapshot> Lines);

        public static bool IsPartialCashReturnLineSupported(CheckoutOriginalReturnLineSnapshot line) => line is not null && PartialCashReturnEvidence.Supports(line);

        public static IReadOnlyList<PartialCashReturnCandidate> FindPartialCashReturnCandidatesByReceipt(Func<MySqlConnection> connections, string receipt)
        {
            if (string.IsNullOrWhiteSpace(receipt) || receipt.Length > 64 || receipt != receipt.Trim() || receipt.Any(char.IsControl)) return Array.Empty<PartialCashReturnCandidate>();
            using var db = LocalConnection(connections); db.Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
            foreach (var table in new[] { "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS", "hanouty_cash_return_consumption" }) RequireInnoDb(db, tx, table);
            PartialCashReturnEvidence.RequireLedger(db, tx);
            var headers = new List<(string Id, string Ticket, string Date, string Register)>();
            using (var command = new MySqlCommand("SELECT ID_TICKET,TICKET,DATES,POSTE FROM TABLE_VENTES_ENTETE WHERE BINARY OPERATION=BINARY 'VENTE' AND " +
                "(BINARY ID_TICKET=BINARY @receipt OR BINARY TICKET=BINARY @receipt) LIMIT 21", db, tx))
            {
                command.Parameters.AddWithValue("@receipt", receipt); using var row = command.ExecuteReader();
                while (row.Read()) headers.Add((Convert.ToString(row.GetValue(0)), Convert.ToString(row.GetValue(1)),
                    Convert.ToString(row.GetValue(2), System.Globalization.CultureInfo.InvariantCulture), Convert.ToString(row.GetValue(3))));
            }
            if (headers.Count > 20) throw new InvalidOperationException("Précisez la référence du ticket d'origine.");
            var result = new List<PartialCashReturnCandidate>();
            foreach (var header in headers)
            {
                try
                {
                    var lines = PartialCashReturnEvidence.Read(db, tx, header.Id);
                    var remaining = lines.Sum(line => line.OriginalNet - line.ReturnedNet);
                    if (remaining > 0m && lines.Any(line => PartialCashReturnEvidence.Supports(line) && line.ReturnedQuantity < line.OriginalQuantity && PartialCashReturnEvidence.UnitNet(line) > 0m))
                        result.Add(new PartialCashReturnCandidate(header.Id, header.Ticket, header.Date, header.Register, lines.Sum(line => line.OriginalNet), remaining, lines));
                }
                catch (InvalidOperationException) { } // Corrupt/consumed/unsupported originals are never offered.
            }
            tx.Commit(); return result.AsReadOnly();
        }

        public static AuthorizedCheckoutRequest PreparePartialCashReturnRequest(Func<MySqlConnection> connections, string operationId,
            string cashierId, string currency, string originalTicketId, IReadOnlyList<CheckoutPartialReturnSelection> selected)
        {
            if (string.IsNullOrWhiteSpace(operationId) || operationId.Length > 64 || operationId != operationId.Trim() || operationId.Any(char.IsControl) ||
                string.Equals(operationId, originalTicketId, StringComparison.OrdinalIgnoreCase) || currency != "MAD") throw new ArgumentException("A new stable partial-return operation and MAD currency are required.");
            var selections = selected?.ToArray() ?? Array.Empty<CheckoutPartialReturnSelection>();
            using var db = LocalConnection(connections); db.Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
            foreach (var table in new[] { "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS", "hanouty_cash_return_consumption" }) RequireInnoDb(db, tx, table);
            var current = PartialCashReturnEvidence.Read(db, tx, originalTicketId); var amount = PartialCashReturnEvidence.Validate(current, selections);
            var request = new AuthorizedCheckoutRequest(operationId, cashierId, currency, true,
                selections.Select(item => new CheckoutBatchLine(item.Original.ArticleId, item.Quantity)).ToArray(),
                new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, amount) }, amount, originalTicketId,
                PartialCashReturn: new CheckoutPartialCashReturnReview(Array.AsReadOnly(selections)));
            request.Validate(); tx.Commit(); return request;
        }
    }
}
