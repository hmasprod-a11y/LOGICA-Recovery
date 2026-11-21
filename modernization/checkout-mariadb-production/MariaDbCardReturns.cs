using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Hanouty.ArchitectureBridge;
using LOGICA.Infrastructure.Checkout;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static class CardReturnOriginalSaleEvidence
    {
        internal sealed record Proof(decimal Amount, decimal OriginalCash, decimal OriginalCard,
            IReadOnlyList<CashReturnOriginalSaleEvidence.CashReturnOriginalSaleLine> Lines);

        internal static Proof Read(MySqlConnection db, MySqlTransaction tx, string original)
        {
            var amount = CashReturnOriginalSaleEvidence.ReadExactCashSaleAmount(db, tx, original);
            using (var command = new MySqlCommand("SELECT ID_TICKET,OPERATION,ID_CLIENT FROM TABLE_VENTES_ENTETE WHERE UPPER(ID_TICKET)=UPPER(@id) FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@id", original); using var row = command.ExecuteReader();
                if (!row.Read() || row.IsDBNull(0) || row.IsDBNull(1) || row.IsDBNull(2) || row.GetString(0) != original || row.GetString(1) != "VENTE" || row.GetString(2) != "0" || row.Read())
                    throw new InvalidOperationException("Original paid ticket is ambiguous or belongs to an unsupported named-sale flow.");
            }
            decimal cash = 0m, card = 0m, change = 0m; var cashRows = 0; var cardRows = 0; var changeRows = 0;
            using (var command = new MySqlCommand("SELECT MONTANT,MODE_P,OPERATION FROM TABLE_VENTES_REGLEMENTS WHERE BINARY ID_TICKET=BINARY @id FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@id", original); using var row = command.ExecuteReader();
                while (row.Read())
                {
                    if (row.IsDBNull(0) || row.IsDBNull(1) || row.IsDBNull(2) || row.GetString(2) != "VENTE")
                        throw new InvalidOperationException("Incomplete original paid settlement.");
                    var value = Convert.ToDecimal(row.GetValue(0)); var mode = row.GetString(1);
                    if (value == 0m || decimal.Round(value, 2) != value) throw new InvalidOperationException("Original settlement must contain nonzero whole-cent movements.");
                    if (mode == "CARTE" && value > 0) { card = checked(card + value); cardRows++; }
                    else if (mode == "ESPECES" && value > 0) { cash = checked(cash + value); cashRows++; }
                    else if (mode == "ESPECES" && value < 0) { change = checked(change + value); changeRows++; }
                    else throw new InvalidOperationException("Unsupported original card/mixed settlement movement.");
                }
            }
            if (cardRows != 1 || cashRows > 1 || changeRows > 1 || changeRows != 0 && cashRows != 1 ||
                cash + change < 0 || card + cash + change != amount || card > amount ||
                cashRows == 0 && (changeRows != 0 || card != amount) || cashRows == 1 && (card >= amount || cash + change <= 0))
                throw new InvalidOperationException("Original card/mixed settlement does not match its net total.");
            var lines = CashReturnOriginalSaleEvidence.ReadOriginalFullQuantityLines(db, tx, original, amount);
            return new Proof(amount, cash + change, card, lines);
        }

        internal static decimal VerifyAndClaim(MySqlConnection db, MySqlTransaction tx, AuthorizedCheckoutRequest request)
        {
            if (!request.ExternalCardRefundConfirmed || request.Payments.Count != 1 || request.Payments[0].Kind != CheckoutPaymentKind.Card ||
                string.Equals(request.OperationId, request.OriginalTicketId, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("An externally confirmed single CARTE refund is required.");
            var proof = Read(db, tx, request.OriginalTicketId);
            if (request.Lines.Count != proof.Lines.Count || proof.Lines.Any(line => request.Lines.Count(item => item.ArticleId == line.ArticleId && item.Quantity == line.Quantity) != 1))
                throw new InvalidOperationException("The complete original paid line set must be reviewed.");
            CashReturnConsumptionClaim.ClaimFullOriginal(db, tx, request.OriginalTicketId, request.OperationId, proof.Lines.Sum(line => line.Quantity));
            return proof.Amount;
        }
    }
}

namespace Hanouty.Checkout.MariaDb
{
    public static partial class MariaDbCashCheckoutServices
    {
        public sealed record PersistedCardReturnCandidate(string SaleId, string TicketNumber, string ReceiptDate,
            string Register, decimal RefundMad, decimal OriginalCashMad, decimal OriginalCardMad);

        public static IReadOnlyList<PersistedCardReturnCandidate> FindFullCardReturnCandidatesByReceipt(Func<MySqlConnection> connections, string receipt)
        {
            if (string.IsNullOrWhiteSpace(receipt) || receipt.Length > 64 || receipt != receipt.Trim() || receipt.Any(char.IsControl))
                return Array.Empty<PersistedCardReturnCandidate>();
            using var db = LocalConnection(connections); db.Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
            foreach (var table in new[] { "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS", "hanouty_cash_return_consumption" }) RequireInnoDb(db, tx, table);
            var headers = new List<(string Id, string Ticket, string Date, string Register)>();
            using (var command = new MySqlCommand("SELECT ID_TICKET,TICKET,DATES,POSTE FROM TABLE_VENTES_ENTETE WHERE BINARY OPERATION=BINARY 'VENTE' AND " +
                "(BINARY ID_TICKET=BINARY @receipt OR BINARY TICKET=BINARY @receipt) LIMIT 21", db, tx))
            {
                command.Parameters.AddWithValue("@receipt", receipt); using var row = command.ExecuteReader();
                while (row.Read()) headers.Add((Convert.ToString(row.GetValue(0)), Convert.ToString(row.GetValue(1)),
                    Convert.ToString(row.GetValue(2), System.Globalization.CultureInfo.InvariantCulture), Convert.ToString(row.GetValue(3))));
            }
            if (headers.Count > 20) throw new InvalidOperationException("Précisez la référence de la vente CARTE/mixte.");
            var result = new List<PersistedCardReturnCandidate>();
            foreach (var header in headers)
            {
                try
                {
                    using var claim = new MySqlCommand("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE UPPER(original_ticket_id)=UPPER(@id)", db, tx);
                    claim.Parameters.AddWithValue("@id", header.Id); if (Convert.ToInt64(claim.ExecuteScalar()) != 0 || CashReturnConsumptionClaim.HasPartialConsumption(db, tx, header.Id)) continue;
                    var proof = CardReturnOriginalSaleEvidence.Read(db, tx, header.Id);
                    ValidateOriginalReturnLines(proof.Lines.Select(line => (line.ArticleId, line.Quantity)).ToArray());
                    result.Add(new PersistedCardReturnCandidate(header.Id, header.Ticket, header.Date, header.Register, proof.Amount, proof.OriginalCash, proof.OriginalCard));
                }
                catch (InvalidOperationException) { } // Damaged originals are never offered.
            }
            tx.Commit(); return result.AsReadOnly();
        }

        public static AuthorizedCheckoutRequest PrepareFullCardReturnRequest(Func<MySqlConnection> connections, string operationId,
            string cashierId, string currency, string originalTicketId, bool externalRefundConfirmed)
        {
            if (!externalRefundConfirmed || string.IsNullOrWhiteSpace(operationId) || operationId.Length > 64 || operationId != operationId.Trim() ||
                operationId.Any(char.IsControl) || string.Equals(operationId, originalTicketId, StringComparison.OrdinalIgnoreCase) || currency != "MAD")
                throw new ArgumentException("Explicitly confirmed external CARTE reimbursement and a stable new operation are required.");
            using var db = LocalConnection(connections); db.Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
            foreach (var table in new[] { "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS", "hanouty_cash_return_consumption" }) RequireInnoDb(db, tx, table);
            var proof = CardReturnOriginalSaleEvidence.Read(db, tx, originalTicketId);
            using (var command = new MySqlCommand("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE UPPER(original_ticket_id)=UPPER(@id)", db, tx))
            { command.Parameters.AddWithValue("@id", originalTicketId); if (Convert.ToInt64(command.ExecuteScalar()) != 0 || CashReturnConsumptionClaim.HasPartialConsumption(db, tx, originalTicketId)) throw new InvalidOperationException("Original paid ticket was already returned."); }
            ValidateOriginalReturnLines(proof.Lines.Select(line => (line.ArticleId, line.Quantity)).ToArray());
            var request = new AuthorizedCheckoutRequest(operationId, cashierId, currency, true,
                proof.Lines.Select(line => new CheckoutBatchLine(line.ArticleId, checked((int)line.Quantity))).ToArray(),
                new[] { new CheckoutPayment(CheckoutPaymentKind.Card, proof.Amount) }, proof.Amount, originalTicketId,
                ExternalCardRefundConfirmed: true);
            request.Validate(); tx.Commit(); return request;
        }
    }
}
