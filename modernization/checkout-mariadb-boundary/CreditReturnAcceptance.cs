using System;
using System.IO;
using System.Linq;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static partial class Program
    {
        private static void VerifyCreditReturns()
        {
            Sql("CREATE TABLE TABLE_CLIENTS (ID_CLIENT VARCHAR(64),CODE_CLIENT VARCHAR(255),CLIENT VARCHAR(255),TELEPHONE VARCHAR(64),CREDIT_INITIAL DECIMAL(19,4)) ENGINE=InnoDB");
            Sql("INSERT INTO TABLE_CLIENTS VALUES ('CR-CLIENT','CR''01','Client d''été','0600000000',0)");
            Sql("UPDATE TABLE_ARTICLES SET STOCK=20,PRIX_V_1=10,PROMOTION=10,PRIX_QTE=0 WHERE ID_ARTICLE='CSharp-Stock'");
            Sql("UPDATE TABLE_ARTICLES SET STOCK=20,PRIX_V_1=3,PROMOTION=0,PRIX_QTE=0 WHERE ID_ARTICLE='CSharp-Other'");
            var directory = Path.Combine(Path.GetTempPath(), "hanouty-credit-return-" + Guid.NewGuid().ToString("N")); Directory.CreateDirectory(directory);
            var config = Path.Combine(directory, "gestion_credit.sni"); File.WriteAllText(config, "True");
            try
            {
                var customer = new CheckoutCustomerIdentity("CR-CLIENT", "CR'01", "Client d'été");
                var sale = new AuthorizedCheckoutRequest("credit-return-original", "O'Neil", "MAD", false,
                    new[] { new CheckoutBatchLine("CSharp-Stock", 2), new CheckoutBatchLine("CSharp-Other", 1) },
                    new[] { new CheckoutPayment(CheckoutPaymentKind.Credit, 21m) }, 21m, Customer: customer);
                IAuthorizedCheckoutPort Port(string pin = "1234") => MariaDbCashCheckoutServices.CreatePostingPort(NewConnection, "01", () => pin, creditConfigurationDirectory: directory);
                string State() => string.Join("|", Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE"), Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"),
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS"), Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS"),
                    Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'"), Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Other'"),
                    Scalar("SELECT CL FROM TABLE_NUM"), Scalar("SELECT COUNT(*) FROM hanouty_checkout_operations"), Scalar("SELECT COUNT(*) FROM hanouty_cash_return_consumption"));
                void Denied(Action action, string message)
                {
                    var before = State(); var denied = false;
                    try { action(); } catch (Exception ex) when (ex is ArgumentException or InvalidOperationException or UnauthorizedAccessException or NotSupportedException or MySqlException) { denied = true; }
                    Require(denied && State() == before, message);
                }
                var cash = Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS");
                var paymentRows = Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS");
                Port().Commit(sale);
                var candidate = MariaDbCashCheckoutServices.FindFullCreditReturnCandidatesByReceipt(NewConnection, sale.OperationId).Single();
                Require(candidate.Customer == customer && candidate.CreditMad == 21m, "Credit original lookup did not preserve the named original and debt.");
                var request = MariaDbCashCheckoutServices.PrepareFullCreditReturnRequest(NewConnection, "credit-return-post", "O'Neil", "MAD", sale.OperationId);
                Require(request.Customer == customer && request.IsReturn && request.Lines.Count == 2, "Credit-return preparation did not reproduce the whole original ticket.");
                Denied(() => Port("wrong").Commit(request), "Wrong credit-return PIN wrote financial effects.");
                Denied(() => Port().Commit(request with { Customer = customer with { Id = "other-client" } }), "Credit return transferred the debt to another customer.");
                Denied(() => Port().Commit(request with { Lines = request.Lines.Take(1).ToArray() }), "Partial credit return bypassed the complete-ticket policy.");
                Denied(() => Port().Commit(request with { ExpectedTotal = 22m }), "Credit return accepted a caller-supplied amount.");
                File.WriteAllText(config, "False"); Denied(() => Port().Commit(request), "Disabled original credit mode still posted a new credit return."); File.WriteAllText(config, "True");
                Sql("UPDATE TABLE_VENTES_JOURNAL SET CLIENT='Corrupted' WHERE ID_TICKET='credit-return-original'");
                Denied(() => Port().Commit(request), "Credit return accepted journal customer inconsistent with the original header.");
                Sql("UPDATE TABLE_VENTES_JOURNAL SET CLIENT='Client d''été' WHERE ID_TICKET='credit-return-original'");
                Sql("CREATE TRIGGER credit_return_fail AFTER INSERT ON TABLE_VENTES_JOURNAL FOR EACH ROW BEGIN IF NEW.OPERATION='RETOUR CREDIT' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='credit-return-rollback'; END IF; END");
                try { Denied(() => Port().Commit(request), "Credit-return rollback left stock, debt, claim or numbering changes."); }
                finally { Sql("DROP TRIGGER credit_return_fail"); }
                // Catalogue changes and a renamed customer do not rewrite the original debt or price.
                Sql("UPDATE TABLE_ARTICLES SET PRIX_V_1=999 WHERE ID_ARTICLE IN ('CSharp-Stock','CSharp-Other')");
                Sql("UPDATE TABLE_CLIENTS SET CLIENT='Renamed customer' WHERE ID_CLIENT='CR-CLIENT'");
                Port().Commit(request);
                Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 20 &&
                    Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Other'") == 20 &&
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS") == paymentRows && Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS") == cash &&
                    Scalar("SELECT COALESCE(SUM(TOTAL_NET),0) FROM TABLE_VENTES_JOURNAL WHERE ID_CLIENT='CR-CLIENT' AND OPERATION IN ('CREDIT','RETOUR CREDIT')") == 0 &&
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET='credit-return-post' AND OPERATION='RETOUR CREDIT' AND TOTAL_NET=-21 AND ID_CLIENT='CR-CLIENT'") == 1 &&
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET='credit-return-post' AND OPERATION='RETOUR CREDIT' AND ID_CLIENT='CR-CLIENT' AND Qté<0") == 2,
                    "Credit return did not restore stock/reduce the named debt without a cash/payment movement.");
                var committed = State(); Port().Commit(request); Require(State() == committed, "Credit-return durable replay duplicated stock/debt effects.");
                Denied(() => Port().Commit(request with { OperationId = "credit-return-again" }), "Another operation consumed an already returned credit ticket.");
                Require(MariaDbCashCheckoutServices.FindFullCreditReturnCandidatesByReceipt(NewConnection, sale.OperationId).Count == 0,
                    "Consumed credit original still appeared in the return selector.");
                Require(MariaDbCashCheckoutServices.CreateOperationJournal(NewConnection).Lookup(request.OperationId) == CheckoutOperationOutcome.Persisted,
                    "Credit return could not be reconciled after restart.");
                Console.WriteLine("PASS credit return: full original customer/discounted prices, no payment or cash, signed debt and stock, PIN/config/customer guards, rollback, replay and reconciliation.");
            }
            finally { File.Delete(config); Directory.Delete(directory); }
        }
    }
}
