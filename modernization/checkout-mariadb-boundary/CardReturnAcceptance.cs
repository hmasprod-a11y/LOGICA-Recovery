using System;
using System.Linq;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static partial class Program
    {
        private static void VerifyCardReturns()
        {
            Sql("CREATE TABLE TABLE_PARAMETRES (OBJET VARCHAR(255),VALEUR VARCHAR(255)) ENGINE=InnoDB");
            Sql("INSERT INTO TABLE_PARAMETRES VALUES ('FENETRE_MODE_P','True')");
            Sql("CREATE TABLE TABLE_MODE_P (MODE_P VARCHAR(255)) ENGINE=InnoDB"); Sql("INSERT INTO TABLE_MODE_P VALUES ('CARTE')");
            Sql("UPDATE TABLE_ARTICLES SET STOCK=20,PRIX_V_1=10,PROMOTION=10,PRIX_QTE=0 WHERE ID_ARTICLE='CSharp-Stock'");
            Sql("UPDATE TABLE_ARTICLES SET STOCK=20,PRIX_V_1=3,PROMOTION=0,PRIX_QTE=0 WHERE ID_ARTICLE='CSharp-Other'");
            IAuthorizedCheckoutPort Port(string pin = "1234") => MariaDbCashCheckoutServices.CreatePostingPort(NewConnection, "01", () => pin);
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
            foreach (var mixed in new[] { false, true })
            {
                var original = mixed ? "card-refund-mixed-original" : "card-refund-original";
                var operation = original + "-return";
                var initialCash = Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'");
                var sale = new AuthorizedCheckoutRequest(original, "O'Neil", "MAD", false,
                    new[] { new CheckoutBatchLine("CSharp-Stock", 2), new CheckoutBatchLine("CSharp-Other", 1) },
                    mixed ? new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 20m), new CheckoutPayment(CheckoutPaymentKind.Card, 5m) }
                          : new[] { new CheckoutPayment(CheckoutPaymentKind.Card, 21m) }, 21m);
                Port().Commit(sale);
                var candidate = MariaDbCashCheckoutServices.FindFullCardReturnCandidatesByReceipt(NewConnection, original).Single();
                Require(candidate.RefundMad == 21m && candidate.OriginalCashMad == (mixed ? 16m : 0m) && candidate.OriginalCardMad == (mixed ? 5m : 21m),
                    "Paid-return lookup lost original card/net cash after signed change.");
                Denied(() => MariaDbCashCheckoutServices.PrepareFullCardReturnRequest(NewConnection, operation, "O'Neil", "MAD", original, false),
                    "Card refund could be prepared without explicit external reimbursement confirmation.");
                var request = MariaDbCashCheckoutServices.PrepareFullCardReturnRequest(NewConnection, operation, "O'Neil", "MAD", original, true);
                Denied(() => Port().Commit(request with { ExternalCardRefundConfirmed = false }), "Unconfirmed card refund passed the posting envelope.");
                Denied(() => Port("wrong").Commit(request), "Wrong card-refund PIN wrote financial effects.");
                Denied(() => Port().Commit(request with { Lines = request.Lines.Take(1).ToArray() }), "Partial card return passed full-original evidence.");
                Denied(() => Port().Commit(request with { Payments = new[] { new CheckoutPayment(CheckoutPaymentKind.Card, 20m) } }), "Card refund accepted an amount different from the original net.");
                Denied(() => Port().Commit(request with { Payments = new[] { new CheckoutPayment(CheckoutPaymentKind.Card, 5m), new CheckoutPayment(CheckoutPaymentKind.Cash, 16m) } }),
                    "Card/mixed original produced an invented two-mode refund instead of LOGICA's single refund mode.");
                Sql("UPDATE TABLE_PARAMETRES SET VALEUR='False' WHERE OBJET='FENETRE_MODE_P'");
                Denied(() => Port().Commit(request), "Disabled payment modes still posted CARTE refund.");
                Sql("UPDATE TABLE_PARAMETRES SET VALEUR='True' WHERE OBJET='FENETRE_MODE_P'");
                Sql("CREATE TRIGGER card_return_fail AFTER INSERT ON TABLE_VENTES_REGLEMENTS FOR EACH ROW BEGIN IF NEW.OPERATION='RETOUR REMBOURSEMENT' AND NEW.MODE_P='CARTE' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='card-return-rollback'; END IF; END");
                try { Denied(() => Port().Commit(request), "Card-return payment failure retained stock, receipt, claim or sequence changes."); }
                finally { Sql("DROP TRIGGER card_return_fail"); }
                var cashAfterSale = Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'");
                Port().Commit(request);
                Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 20 &&
                    Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Other'") == 20 &&
                    Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'") == cashAfterSale &&
                    cashAfterSale == initialCash + (mixed ? 16m : 0m) &&
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET='" + operation + "' AND MODE_P='CARTE' AND OPERATION='RETOUR REMBOURSEMENT' AND MONTANT=-21") == 1 &&
                    Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET='" + operation + "'") == 1 &&
                    Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE ID_TICKET IN ('" + operation + "','" + original + "')") == 0,
                    "Full single-mode CARTE refund did not restore stock and reconcile original total without moving drawer cash.");
                var committed = State(); Port().Commit(request); Require(State() == committed, "Card-refund duplicate posted stock/payment again.");
                Denied(() => Port().Commit(request with { OperationId = operation + "-again" }), "A second card-refund operation consumed the original twice.");
                Require(MariaDbCashCheckoutServices.FindFullCardReturnCandidatesByReceipt(NewConnection, original).Count == 0 &&
                    MariaDbCashCheckoutServices.CreateOperationJournal(NewConnection).Lookup(operation) == CheckoutOperationOutcome.Persisted,
                    "Card refund remained selectable or could not reconcile its durable journal.");
            }
            Console.WriteLine("PASS full CARTE and mixed-original CARTE refund: externally confirmed single mode, original net/change evidence, unchanged drawer, signed card, stock, PIN/config, rollback, duplicate and reconciliation.");
        }
    }
}
