using System;
using System.IO;
using System.Linq;
using System.Threading;
using Hanouty.ArchitectureBridge;
using Hanouty.Checkout.MariaDb;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Checkout
{
    internal static partial class Program
    {
        private static void VerifyPartialCashReturns()
        {
            using (var stream = typeof(Program).Assembly.GetManifestResourceStream("PartialCashReturnMigration"))
            using (var reader = new StreamReader(stream ?? throw new InvalidOperationException("Exact partial-return migration missing."))) Sql(reader.ReadToEnd());
            Sql("UPDATE TABLE_ARTICLES SET STOCK=20,PRIX_V_1=10,PROMOTION=10,PRIX_QTE=0 WHERE ID_ARTICLE='CSharp-Stock'");
            Sql("UPDATE TABLE_ARTICLES SET STOCK=20,PRIX_V_1=3,PROMOTION=0,PRIX_QTE=0 WHERE ID_ARTICLE='CSharp-Other'");
            IAuthorizedCheckoutPort Port(string pin = "1234") => MariaDbCashCheckoutServices.CreatePostingPort(NewConnection, "01", () => pin);
            string State() => string.Join("|", Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE"), Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL"),
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS"), Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS"),
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'"), Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Other'"),
                Scalar("SELECT CL FROM TABLE_NUM"), Scalar("SELECT COUNT(*) FROM hanouty_checkout_operations"), Scalar("SELECT COUNT(*) FROM hanouty_cash_return_consumption"),
                Scalar("SELECT COUNT(*) FROM hanouty_return_line_consumption"), Scalar("SELECT COALESCE(SUM(returned_quantity),0) FROM hanouty_return_line_consumption"),
                Scalar("SELECT COALESCE(SUM(returned_net),0) FROM hanouty_return_line_consumption"));
            void Denied(Action action, string reason)
            {
                var before = State(); var denied = false;
                try { action(); } catch (Exception ex) when (ex is ArgumentException or InvalidOperationException or UnauthorizedAccessException or NotSupportedException or MySqlException) { denied = true; }
                Require(denied && State() == before, reason);
            }
            AuthorizedCheckoutRequest Sale(string id, int first = 3, int second = 2) => new(id, "O'Neil", "MAD", false,
                new[] { new CheckoutBatchLine("CSharp-Stock", first), new CheckoutBatchLine("CSharp-Other", second) },
                new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, first * 9m + second * 3m + 7m) }, first * 9m + second * 3m);
            MariaDbCashCheckoutServices.PartialCashReturnCandidate Candidate(string id) => MariaDbCashCheckoutServices.FindPartialCashReturnCandidatesByReceipt(NewConnection, id).Single();
            AuthorizedCheckoutRequest Prepare(string id, string op, params CheckoutPartialReturnSelection[] selected) =>
                MariaDbCashCheckoutServices.PreparePartialCashReturnRequest(NewConnection, op, "O'Neil", "MAD", id, selected);
            var initialCash = Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'");
            Port().Commit(Sale("partial-original"));
            var original = Candidate("partial-original"); var first = original.Lines.Single(line => line.ArticleId == "CSharp-Stock");
            var staleFull = MariaDbCashCheckoutServices.PrepareFullCashReturnRequest(NewConnection, "partial-stale-full", "O'Neil", "MAD", "partial-original");
            var partial = Prepare(original.SaleId, "partial-first", new CheckoutPartialReturnSelection(first, 1));
            Denied(() => Port("wrong").Commit(partial), "Wrong partial-return PIN wrote stock/cash/consumption.");
            Sql("UPDATE TABLE_PASS SET Catégorie='BLOCKED' WHERE ListUser='O''Neil'");
            Denied(() => Port().Commit(partial), "Unsupported cashier role wrote a partial refund.");
            Sql("UPDATE TABLE_PASS SET Catégorie='UTILISATEUR' WHERE ListUser='O''Neil'");
            Denied(() => Port().Commit(partial with { ExpectedTotal = 10m }), "Caller amount replaced original partial-return net.");
            Denied(() => Prepare(original.SaleId, "partial-over", new CheckoutPartialReturnSelection(first, 4)), "Selected quantity exceeded original quantity.");
            Denied(() => Prepare(original.SaleId, "partial-forged", new CheckoutPartialReturnSelection(first with { OriginalNet = 30m }, 1)), "Forged original price/net snapshot passed partial review.");
            Port().Commit(partial);
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 18m &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Other'") == 18m &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL WHERE ID_TICKET='partial-first' AND ID_ARTICLE='CSharp-Stock' AND Qté=-1 AND TOTAL_NET=-9 AND REMISE=10") == 1 &&
                Scalar("SELECT returned_quantity FROM hanouty_return_line_consumption WHERE original_ticket_id='partial-original' AND article_id='CSharp-Stock'") == 1 &&
                Scalar("SELECT returned_net FROM hanouty_return_line_consumption WHERE original_ticket_id='partial-original' AND article_id='CSharp-Stock'") == 9 &&
                Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'") == initialCash + 24m,
                "First selected-line partial did not refund original discounted9 or track exact stock/quantity/net.");
            var afterFirst = State(); Port().Commit(partial); Require(State() == afterFirst, "Partial operation replay repeated stock/cash/consumption.");
            Denied(() => Port().Commit(staleFull), "A pre-reviewed full-ticket request double-refunded after a partial return.");
            Require(MariaDbCashCheckoutServices.FindFullCashReturnCandidates(NewConnection, original.SaleId).Count == 0,
                "Partially consumed original remained offered by the full-ticket selector.");
            Denied(() => MariaDbCashCheckoutServices.PrepareFullCashReturnRequest(NewConnection, "partial-new-full", "O'Neil", "MAD", original.SaleId),
                "A new full-ticket request ignored existing partial consumption.");
            Denied(() => Prepare(original.SaleId, "partial-stale", new CheckoutPartialReturnSelection(first, 1)), "Stale returned-quantity review was accepted.");
            var next = Candidate(original.SaleId);
            Require(next.RemainingNetMad == 24m, "Remaining original partial net is incorrect.");
            var remainingFirst = next.Lines.Single(line => line.ArticleId == first.ArticleId);
            Sql("UPDATE hanouty_return_line_consumption SET returned_net=10 WHERE original_ticket_id='partial-original'");
            Denied(() => Port().Commit(partial with { OperationId = "partial-corrupt-net" }), "Corrupted cumulative returned net passed original evidence.");
            Sql("UPDATE hanouty_return_line_consumption SET returned_net=9 WHERE original_ticket_id='partial-original'");
            Denied(() => Prepare(original.SaleId, "partial-over-remaining", new CheckoutPartialReturnSelection(remainingFirst, 3)), "Cumulative return exceeded remaining original quantity.");
            var second = Prepare(original.SaleId, "partial-rest", next.Lines.Select(line => new CheckoutPartialReturnSelection(line, checked((int)(line.OriginalQuantity - line.ReturnedQuantity)))).ToArray());
            Sql("CREATE TRIGGER partial_return_fail AFTER INSERT ON TABLE_VENTES_REGLEMENTS FOR EACH ROW BEGIN IF NEW.ID_TICKET='partial-rest' THEN SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT='partial-after-payment'; END IF; END");
            try { Denied(() => Port().Commit(second), "Post-payment partial failure retained cumulative ledger, stock, cash or numbering."); }
            finally { Sql("DROP TRIGGER partial_return_fail"); }
            // Current catalogue values do not replace original prices/discounts.
            Sql("UPDATE TABLE_ARTICLES SET PRIX_V_1=999,PROMOTION=0 WHERE ID_ARTICLE IN ('CSharp-Stock','CSharp-Other')");
            Port().Commit(second);
            Require(Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") == 20m &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Other'") == 20m &&
                Scalar("SELECT COALESCE(SUM(MONTANT),0) FROM TABLE_VENTES_REGLEMENTS WHERE MODE_P='ESPECES'") == initialCash &&
                Scalar("SELECT SUM(returned_net) FROM hanouty_return_line_consumption WHERE original_ticket_id='partial-original'") == 33m &&
                Scalar("SELECT SUM(returned_quantity) FROM hanouty_return_line_consumption WHERE original_ticket_id='partial-original'") == 5m &&
                MariaDbCashCheckoutServices.FindPartialCashReturnCandidatesByReceipt(NewConnection, original.SaleId).Count == 0 &&
                MariaDbCashCheckoutServices.CreateOperationJournal(NewConnection).Lookup(second.OperationId) == CheckoutOperationOutcome.Persisted,
                "Partial plus remainder did not restore original stock/cash exactly or disappear when exhausted.");
            Denied(() => Port().Commit(second with { OperationId = "partial-again" }), "Exhausted partial original was refunded again.");

            // Unsupported fractional-cent unit pricing is refused without consuming
            // anything, while its untouched complete original remains refundable.
            Sql("UPDATE TABLE_ARTICLES SET PRIX_V_1=0.01,PROMOTION=50 WHERE ID_ARTICLE='CSharp-Stock'");
            var rounding = new AuthorizedCheckoutRequest("partial-rounding-original", "O'Neil", "MAD", false,
                new[] { new CheckoutBatchLine("CSharp-Stock", 3) }, new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 0.02m) }, 0.02m);
            Port().Commit(rounding);
            var unsupported = new CheckoutOriginalReturnLineSnapshot("CSharp-Stock", "Lait d'été", 3m, 0.01m, 50m, 0.02m, 0m, 0m);
            Denied(() => Prepare(rounding.OperationId, "partial-rounding-refused", new CheckoutPartialReturnSelection(unsupported, 1)), "Partial refund invented residual-cent allocation.");
            Require(MariaDbCashCheckoutServices.FindPartialCashReturnCandidatesByReceipt(NewConnection, rounding.OperationId).Count == 0 &&
                MariaDbCashCheckoutServices.FindFullCashReturnCandidates(NewConnection, rounding.OperationId).Count == 1,
                "Unsupported partial rounding consumed or hid an untouched valid full original.");
            Port().Commit(MariaDbCashCheckoutServices.PrepareFullCashReturnRequest(NewConnection, "rounding-full-refund", "O'Neil", "MAD", rounding.OperationId));

            // Two independently prepared operations cannot both consume the same
            // reviewed remaining snapshot; the losing cashier must review afresh.
            Sql("UPDATE TABLE_ARTICLES SET PRIX_V_1=10,PROMOTION=10 WHERE ID_ARTICLE='CSharp-Stock'");
            Sql("UPDATE TABLE_ARTICLES SET PRIX_V_1=3,PROMOTION=0 WHERE ID_ARTICLE='CSharp-Other'");
            Port().Commit(Sale("partial-concurrent-original", 2, 1));
            var race = Candidate("partial-concurrent-original"); var raceLine = race.Lines.Single(line => line.ArticleId == "CSharp-Stock");
            var requests = new[] { Prepare(race.SaleId, "partial-race-1", new CheckoutPartialReturnSelection(raceLine, 1)), Prepare(race.SaleId, "partial-race-2", new CheckoutPartialReturnSelection(raceLine, 1)) };
            var successes = 0; var failures = 0; Exception unexpected = null;
            using (var start = new ManualResetEventSlim(false))
            {
                var threads = requests.Select(request => new Thread(() => { start.Wait(); try { Port().Commit(request); Interlocked.Increment(ref successes); }
                    catch (InvalidOperationException) { Interlocked.Increment(ref failures); } catch (Exception ex) { unexpected = ex; } }) { IsBackground = true }).ToArray();
                foreach (var thread in threads) thread.Start(); start.Set();
                foreach (var thread in threads) Require(thread.Join(30000), "Concurrent partial operations did not settle.");
            }
            Require(unexpected is null && successes == 1 && failures == 1 &&
                Scalar("SELECT returned_quantity FROM hanouty_return_line_consumption WHERE original_ticket_id='partial-concurrent-original' AND article_id='CSharp-Stock'") == 1,
                "Concurrent partial operations consumed the same reviewed quantity twice.");
            var last = Candidate(race.SaleId);
            Port().Commit(Prepare(race.SaleId, "partial-race-complete", last.Lines.Select(line => new CheckoutPartialReturnSelection(line, checked((int)(line.OriginalQuantity - line.ReturnedQuantity)))).ToArray()));

            // Full and partial entry points serialize on the same original. A
            // winner in either path excludes the other's stale prepared envelope.
            Port().Commit(Sale("partial-full-race-original", 2, 1));
            var cross = Candidate("partial-full-race-original");
            var crossPartial = Prepare(cross.SaleId, "partial-full-race-part", new CheckoutPartialReturnSelection(cross.Lines.Single(line => line.ArticleId == "CSharp-Stock"), 1));
            var crossFull = MariaDbCashCheckoutServices.PrepareFullCashReturnRequest(NewConnection, "partial-full-race-full", "O'Neil", "MAD", cross.SaleId);
            successes = 0; failures = 0; unexpected = null;
            using (var start = new ManualResetEventSlim(false))
            {
                var threads = new[] { crossPartial, crossFull }.Select(request => new Thread(() => { start.Wait(); try { Port().Commit(request); Interlocked.Increment(ref successes); }
                    catch (InvalidOperationException) { Interlocked.Increment(ref failures); } catch (Exception ex) { unexpected = ex; } }) { IsBackground = true }).ToArray();
                foreach (var thread in threads) thread.Start(); start.Set(); foreach (var thread in threads) Require(thread.Join(30000), "Full/partial return race did not settle.");
            }
            Require(unexpected is null && successes == 1 && failures == 1 &&
                Scalar("SELECT COUNT(*) FROM TABLE_VENTES_ENTETE WHERE ID_TICKET IN ('partial-full-race-part','partial-full-race-full')") == 1 &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Stock'") <= 20m &&
                Scalar("SELECT STOCK FROM TABLE_ARTICLES WHERE ID_ARTICLE='CSharp-Other'") <= 20m,
                "A full and a partial operation both consumed the same original.");
            var crossRemaining = MariaDbCashCheckoutServices.FindPartialCashReturnCandidatesByReceipt(NewConnection, cross.SaleId);
            if (crossRemaining.Count == 1)
            {
                var rest = crossRemaining.Single();
                Port().Commit(Prepare(rest.SaleId, "partial-full-race-rest", rest.Lines.Select(line => new CheckoutPartialReturnSelection(line, checked((int)(line.OriginalQuantity - line.ReturnedQuantity)))).ToArray()));
            }
            Console.WriteLine("PASS partial cash original: selected original discount/price, cumulative quantity/net, partial+remainder, stale full exclusion, wrong PIN/snapshot/amount/overquantity, post-payment rollback, concurrent review, no invented rounding, replay and reconciliation.");
        }
    }
}
