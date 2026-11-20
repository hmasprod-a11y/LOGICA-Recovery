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
    // Form_3_VENTE.Button_SOLDER_CREDIT: negative quantity/net posts RETOUR CREDIT,
    // restoring stock and reducing the named customer's debt without cash/payment.
    internal static class CreditReturnOriginalSaleEvidence
    {
        internal sealed record Proof(CheckoutCustomerIdentity Customer,
            IReadOnlyList<CashReturnOriginalSaleEvidence.CashReturnOriginalSaleLine> Lines, decimal Amount);

        internal static Proof Read(MySqlConnection db, MySqlTransaction tx, string original)
        {
            if (string.IsNullOrWhiteSpace(original) || original.Length > 64 || original != original.Trim() || original.Any(char.IsControl) ||
                db.State != ConnectionState.Open || !ReferenceEquals(tx.Connection, db))
                throw new InvalidOperationException("A canonical original credit ticket and active transaction are required.");
            CheckoutCustomerIdentity customer; decimal amount;
            using (var command = new MySqlCommand("SELECT ID_TICKET,OPERATION,TOTAL_NET,ID_CLIENT,CODE_CLIENT,CLIENT " +
                "FROM TABLE_VENTES_ENTETE WHERE UPPER(ID_TICKET)=UPPER(@id) FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@id", original);
                using var row = command.ExecuteReader();
                if (!row.Read() || Enumerable.Range(0, 6).Any(row.IsDBNull) || row.GetString(0) != original || row.GetString(1) != "CREDIT")
                    throw new InvalidOperationException("The unique original credit sale is unavailable.");
                amount = Convert.ToDecimal(row.GetValue(2));
                customer = new CheckoutCustomerIdentity(row.GetString(3), row.GetString(4), row.GetString(5)); customer.Validate();
                if (row.Read() || amount <= 0 || decimal.Round(amount, 2) != amount)
                    throw new InvalidOperationException("Original credit header is ambiguous or has an invalid amount.");
            }
            // Keep the original customer's persisted snapshot in the return. The live
            // identity must still exist uniquely; a rename does not transfer its debt.
            var current = Hanouty.Checkout.MariaDb.MariaDbCashCheckoutServices.ReadCreditCustomer(db, tx, customer.Id);
            if (current.Id != customer.Id) throw new InvalidOperationException("Original customer identity is ambiguous.");
            using (var command = new MySqlCommand("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE BINARY ID_TICKET=BINARY @id FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@id", original);
                if (Convert.ToInt64(command.ExecuteScalar()) != 0) throw new InvalidOperationException("Credit original unexpectedly contains payment movements.");
            }
            var lines = new List<CashReturnOriginalSaleEvidence.CashReturnOriginalSaleLine>();
            var ids = new HashSet<string>(StringComparer.OrdinalIgnoreCase); decimal total = 0;
            using (var command = new MySqlCommand("SELECT ID_ARTICLE,Qté,PRIX_V,REMISE,TOTAL_NET,OPERATION,ID_CLIENT,CODE_CLIENT,CLIENT " +
                "FROM TABLE_VENTES_JOURNAL WHERE BINARY ID_TICKET=BINARY @id ORDER BY BINARY ID_ARTICLE FOR UPDATE", db, tx))
            {
                command.Parameters.AddWithValue("@id", original);
                using var row = command.ExecuteReader();
                while (row.Read())
                {
                    if (Enumerable.Range(0, 9).Any(row.IsDBNull)) throw new InvalidOperationException("Incomplete original credit line.");
                    var id = row.GetString(0); var quantity = Convert.ToDecimal(row.GetValue(1)); var price = Convert.ToDecimal(row.GetValue(2));
                    var discount = Convert.ToDecimal(row.GetValue(3)); var net = Convert.ToDecimal(row.GetValue(4));
                    if (string.IsNullOrWhiteSpace(id) || !ids.Add(id) || quantity <= 0 || price < 0 || discount < 0 || discount > 100 ||
                        net < 0 || net != Math.Round(SalesLinePricing.CalculateNetAmount(price, quantity, discount), 2, MidpointRounding.ToEven) ||
                        row.GetString(5) != "CREDIT" || row.GetString(6) != customer.Id || row.GetString(7) != customer.Code || row.GetString(8) != customer.Name)
                        throw new InvalidOperationException("Original credit line or customer does not match its header.");
                    total = checked(total + net); lines.Add(new CashReturnOriginalSaleEvidence.CashReturnOriginalSaleLine(id, quantity, net));
                }
            }
            if (lines.Count == 0 || total != amount) throw new InvalidOperationException("Original credit details do not match its debt.");
            return new Proof(customer, lines.AsReadOnly(), amount);
        }

        internal static decimal VerifyAndClaim(MySqlConnection db, MySqlTransaction tx, AuthorizedCheckoutRequest request)
        {
            if (string.Equals(request.OperationId, request.OriginalTicketId, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("A credit return cannot reuse an alias of the original operation.");
            var proof = Read(db, tx, request.OriginalTicketId);
            if (request.Customer != proof.Customer || request.Lines.Count != proof.Lines.Count ||
                proof.Lines.Any(line => request.Lines.Count(item => item.ArticleId == line.ArticleId && item.Quantity == line.Quantity) != 1))
                throw new InvalidOperationException("Review the complete original credit ticket and its customer before returning it.");
            CashReturnConsumptionClaim.ClaimFullOriginal(db, tx, request.OriginalTicketId, request.OperationId, proof.Lines.Sum(line => line.Quantity));
            return proof.Amount;
        }
    }
}

namespace Hanouty.Checkout.MariaDb
{
    public static partial class MariaDbCashCheckoutServices
    {
        public sealed record PersistedCreditReturnCandidate(string SaleId, string TicketNumber, string ReceiptDate,
            string Register, decimal CreditMad, CheckoutCustomerIdentity Customer);

        public static IReadOnlyList<PersistedCreditReturnCandidate> FindFullCreditReturnCandidatesByReceipt(
            Func<MySqlConnection> connections, string receipt)
        {
            if (string.IsNullOrWhiteSpace(receipt) || receipt.Length > 64 || receipt != receipt.Trim() || receipt.Any(char.IsControl))
                return Array.Empty<PersistedCreditReturnCandidate>();
            using var db = LocalConnection(connections); db.Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
            foreach (var table in new[] { "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS", "hanouty_cash_return_consumption" }) RequireInnoDb(db, tx, table);
            var headers = new List<(string Id, string Ticket, string Date, string Register)>();
            using (var command = new MySqlCommand("SELECT ID_TICKET,TICKET,DATES,POSTE FROM TABLE_VENTES_ENTETE WHERE BINARY OPERATION=BINARY 'CREDIT' AND " +
                "(BINARY ID_TICKET=BINARY @receipt OR BINARY TICKET=BINARY @receipt) LIMIT 21", db, tx))
            {
                command.Parameters.AddWithValue("@receipt", receipt); using var reader = command.ExecuteReader();
                while (reader.Read()) headers.Add((Convert.ToString(reader.GetValue(0)), Convert.ToString(reader.GetValue(1)),
                    Convert.ToString(reader.GetValue(2), System.Globalization.CultureInfo.InvariantCulture), Convert.ToString(reader.GetValue(3))));
            }
            if (headers.Count > 20) throw new InvalidOperationException("Précisez la référence de la vente à crédit.");
            var result = new List<PersistedCreditReturnCandidate>();
            foreach (var header in headers)
            {
                try
                {
                    using var claimed = new MySqlCommand("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE UPPER(original_ticket_id)=UPPER(@id)", db, tx);
                    claimed.Parameters.AddWithValue("@id", header.Id); if (Convert.ToInt64(claimed.ExecuteScalar()) != 0) continue;
                    var proof = CreditReturnOriginalSaleEvidence.Read(db, tx, header.Id);
                    ValidateOriginalReturnLines(proof.Lines.Select(line => (line.ArticleId, line.Quantity)).ToArray());
                    result.Add(new PersistedCreditReturnCandidate(header.Id, header.Ticket, header.Date, header.Register, proof.Amount, proof.Customer));
                }
                catch (InvalidOperationException) { } // Never offer damaged or ambiguous originals.
            }
            tx.Commit(); return result.AsReadOnly();
        }

        public static AuthorizedCheckoutRequest PrepareFullCreditReturnRequest(Func<MySqlConnection> connections,
            string operationId, string cashierId, string currency, string originalTicketId)
        {
            if (string.Equals(operationId, originalTicketId, StringComparison.OrdinalIgnoreCase) || string.IsNullOrWhiteSpace(operationId) || operationId.Length > 64 ||
                operationId != operationId.Trim() || operationId.Any(char.IsControl) || currency != "MAD")
                throw new ArgumentException("Stable credit-return operation and MAD currency are required.");
            using var db = LocalConnection(connections); db.Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
            foreach (var table in new[] { "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS", "hanouty_cash_return_consumption" }) RequireInnoDb(db, tx, table);
            var proof = CreditReturnOriginalSaleEvidence.Read(db, tx, originalTicketId);
            using (var claim = new MySqlCommand("SELECT COUNT(*) FROM hanouty_cash_return_consumption WHERE UPPER(original_ticket_id)=UPPER(@id)", db, tx))
            { claim.Parameters.AddWithValue("@id", originalTicketId); if (Convert.ToInt64(claim.ExecuteScalar()) != 0) throw new InvalidOperationException("Original credit ticket was already returned."); }
            ValidateOriginalReturnLines(proof.Lines.Select(line => (line.ArticleId, line.Quantity)).ToArray());
            var request = new AuthorizedCheckoutRequest(operationId, cashierId, currency, true,
                proof.Lines.Select(line => new CheckoutBatchLine(line.ArticleId, checked((int)line.Quantity))).ToArray(),
                new[] { new CheckoutPayment(CheckoutPaymentKind.Credit, proof.Amount) }, proof.Amount, originalTicketId, proof.Customer);
            request.Validate(); tx.Commit(); return request;
        }
    }
}
