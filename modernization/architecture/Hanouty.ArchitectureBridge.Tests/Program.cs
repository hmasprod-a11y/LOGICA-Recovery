using Hanouty.ArchitectureBridge;

static void Assert(bool value, string name)
{
    if (!value) throw new Exception("FAILED: " + name);
    Console.WriteLine("PASS: " + name);
}
static ArticleCandidate A(string id, string code) => new(id, code);

var original = new[] { A("11", "123"), A("12", "123") };
var chosen = CheckoutSelectionGateway.ResolveBarcode(original, _ => 1, () => original);
Assert(chosen.Outcome == SelectionOutcome.Selected && chosen.Article?.ArticleId == "12", "duplicate barcode explicit variant");
var cancelled = CheckoutSelectionGateway.ResolveBarcode(original, _ => -1, () => throw new Exception("refresh must not run"));
Assert(cancelled.Outcome == SelectionOutcome.Cancelled, "cancel before live refresh");
var removed = CheckoutSelectionGateway.ResolveBarcode(original, _ => 1, () => new[] { A("11", "123") });
Assert(removed.Outcome != SelectionOutcome.Selected, "stale variant fails closed");
var changed = CheckoutSelectionGateway.ResolveBarcode(new[] { A("11", "123") }, null, () => new[] { A("11", "456") });
Assert(changed.Outcome != SelectionOutcome.Selected, "changed barcode fails closed");
var blank = CheckoutSelectionGateway.ResolveImage(A("21", ""), () => new[] { A("21", "") });
Assert(blank.Outcome == SelectionOutcome.Selected && blank.Article?.ArticleId == "21", "image-only blank barcode");
var swapped = CheckoutSelectionGateway.ResolveImage(A("21", ""), () => new[] { A("22", "") });
Assert(swapped.Outcome != SelectionOutcome.Selected, "image tile reused identity fails closed");
var none = CheckoutSelectionGateway.ResolveBarcode(Array.Empty<ArticleCandidate>(), null, () => throw new Exception("refresh must not run"));
Assert(none.Outcome == SelectionOutcome.Missing, "no candidates");
// Production workflow: validated selection is the only input to the checkout port.
var port = new RecordingCheckoutPort();
var workflow = new CheckoutSelectionWorkflow(port);
var added = workflow.AddBarcode(original, _ => 1, () => original, 3);
Assert(added.Outcome == SelectionOutcome.Selected && port.Calls.Count == 1 &&
       port.Calls[0] == ("12", 3), "barcode selection dispatches verified identity and quantity");
var before = port.Calls.Count;
var stale = workflow.AddBarcode(original, _ => 1, () => new[] { A("11", "123") });
Assert(stale.Outcome != SelectionOutcome.Selected && port.Calls.Count == before,
       "stale variant never reaches checkout");
var cancelledFlow = workflow.AddBarcode(original, _ => -1, () => throw new Exception("refresh must not run"));
Assert(cancelledFlow.Outcome == SelectionOutcome.Cancelled && port.Calls.Count == before,
       "cancelled choice never reaches checkout");
var imageFlow = workflow.AddImage(A("21", ""), () => new[] { A("21", "") }, 2);
Assert(imageFlow.Outcome == SelectionOutcome.Selected && port.Calls[^1] == ("21", 2),
       "barcode-free image dispatches by stable article ID");
before = port.Calls.Count;
var replaced = workflow.AddImage(A("21", ""), () => new[] { A("22", "") });
Assert(replaced.Outcome != SelectionOutcome.Selected && port.Calls.Count == before,
       "reused image tile never reaches checkout");
try { workflow.AddImage(A("21", ""), () => throw new Exception("must not refresh"), 0); throw new Exception("invalid quantity accepted"); }
catch (ArgumentOutOfRangeException) { Assert(port.Calls.Count == before, "invalid quantity fails before refresh"); }
var failingPort = new ThrowingCheckoutPort();
try { new CheckoutSelectionWorkflow(failingPort).AddImage(A("21", ""), () => new[] { A("21", "") }); throw new Exception("port failure swallowed"); }
catch (ApplicationException) { Assert(failingPort.Attempts == 1, "checkout port failure propagates without retry"); }

// Host-facing integration: lookup, explicit duplicate choice, live refresh, cart write.
var catalogue = new RecordingCatalogue();
var variantPrompt = new RecordingPrompt { Choice = 1 };
var hostCart = new RecordingCheckoutPort();
var controller = new CheckoutSelectionController(catalogue, variantPrompt, hostCart);
var hostSelected = controller.ScanBarcode("123", 4);
Assert(hostSelected.Outcome == SelectionOutcome.Selected &&
       hostCart.Calls[^1] == ("12", 4) &&
       catalogue.BarcodeReads.SequenceEqual(new[] { "find:123", "refresh:123" }) &&
       variantPrompt.Attempts == 1, "host scan resolves duplicate, refreshes captured barcode and posts quantity");
var priorHostCount = hostCart.Calls.Count;
catalogue.ChangeRefresh = true;
var hostStale = controller.ScanBarcode("123");
Assert(hostStale.Outcome != SelectionOutcome.Selected && hostCart.Calls.Count == priorHostCount,
       "host stale variant never posts to cart");
catalogue.ChangeRefresh = false;
var hostImage = controller.SelectImage(A("21", ""), 2);
Assert(hostImage.Outcome == SelectionOutcome.Selected && hostCart.Calls[^1] == ("21", 2) &&
       catalogue.ArticleReads[^1] == "21", "host barcode-free image uses stable article identity");
priorHostCount = hostCart.Calls.Count;
catalogue.ReplaceImage = true;
var staleImage = controller.SelectImage(A("21", ""));
Assert(staleImage.Outcome != SelectionOutcome.Selected && hostCart.Calls.Count == priorHostCount,
       "host replaced image identity fails closed");
var emptyBarcode = controller.ScanBarcode(" ");
Assert(emptyBarcode.Outcome == SelectionOutcome.Missing && hostCart.Calls.Count == priorHostCount,
       "empty scan does not access catalogue or post");
var emptyIdentity = controller.SelectImage(A("", ""));
Assert(emptyIdentity.Outcome == SelectionOutcome.InvalidCandidates && hostCart.Calls.Count == priorHostCount,
       "empty tile identity cannot post");
try { controller.ScanBarcode("123", 0); throw new Exception("invalid scan quantity accepted"); }
catch (ArgumentOutOfRangeException) { Assert(hostCart.Calls.Count == priorHostCount, "invalid scan quantity rejected before catalogue read"); }
try { controller.SelectImage(A("21", ""), 0); throw new Exception("invalid tile quantity accepted"); }
catch (ArgumentOutOfRangeException) { Assert(hostCart.Calls.Count == priorHostCount, "invalid tile quantity rejected before catalogue read"); }


// Atomic multi-line checkout: stage first, then revalidate every article.
var atomicCart = new RecordingAtomicBatchPort();
var batch = new CheckoutBatchController(new RecordingCatalogue(), new RecordingPrompt { Choice = 1 }, atomicCart);
Assert(batch.StageImage(A("21", ""), 2).Outcome == SelectionOutcome.Selected, "batch stages barcode-free image");
Assert(batch.StageBarcode("123", 3).Outcome == SelectionOutcome.Selected, "batch stages duplicate barcode");
Assert(atomicCart.Calls.Count == 0 && batch.PendingCount == 2, "staging never writes cart");
var batchStatus = batch.Commit("sale-001");
Assert(batchStatus == CheckoutBatchStatus.Committed && atomicCart.Calls.Count == 1 &&
       atomicCart.Calls[0].OperationId == "sale-001" &&
       atomicCart.Calls[0].Lines.Count == 2 &&
       atomicCart.Calls[0].Lines[0] == new CheckoutBatchLine("21", 2) &&
       atomicCart.Calls[0].Lines[1] == new CheckoutBatchLine("12", 3),
       "one atomic port call contains all validated lines");
Assert(batch.PendingCount == 0 && batch.Commit("sale-002") == CheckoutBatchStatus.Empty,
       "successful commit clears pending and empty commit does not write");
var changedCatalogue = new RecordingCatalogue();
var blockedCart = new RecordingAtomicBatchPort();
var blockedBatch = new CheckoutBatchController(changedCatalogue, new RecordingPrompt { Choice = 1 }, blockedCart);
blockedBatch.StageImage(A("21", ""));
changedCatalogue.ReplaceImage = true;
Assert(blockedBatch.Commit("sale-003") == CheckoutBatchStatus.Invalidated &&
       blockedCart.Calls.Count == 0 && blockedBatch.PendingCount == 1,
       "changed article identity blocks entire atomic commit");
blockedBatch.Clear();
Assert(blockedBatch.PendingCount == 0, "explicit clear discards staged lines");
var collapsingCatalogue = new RecordingCatalogue();
var collapsingCart = new RecordingAtomicBatchPort();
var collapsingBatch = new CheckoutBatchController(collapsingCatalogue,
    new RecordingPrompt { Choice = 0 }, collapsingCart);
Assert(collapsingBatch.StageBarcode("123").Outcome == SelectionOutcome.Selected,
    "duplicate barcode explicitly staged before catalogue change");
collapsingCatalogue.ChangeRefresh = true;
Assert(collapsingBatch.Commit("collapsed-variant") == CheckoutBatchStatus.Invalidated &&
       collapsingCart.Calls.Count == 0 && collapsingBatch.PendingCount == 1,
    "duplicate variant collapse blocks commit without cart write");

try { blockedBatch.Commit(" "); throw new Exception("blank operation ID accepted"); }
catch (ArgumentException) { Assert(blockedCart.Calls.Count == 0, "blank operation ID fails closed"); }
var failingBatchPort = new ThrowingAtomicBatchPort();
var retryBatch = new CheckoutBatchController(new RecordingCatalogue(), new RecordingPrompt(), failingBatchPort);
retryBatch.StageImage(A("21", ""));
try { retryBatch.Commit("sale-004"); throw new Exception("atomic port failure swallowed"); }
catch (ApplicationException) {
    Assert(failingBatchPort.Attempts == 1 && retryBatch.PendingCount == 1,
        "failed atomic write propagates, retains stage, never retries automatically");
}

// Unknown write outcome: no user interaction may accidentally duplicate a sale.
Assert(retryBatch.State == CheckoutCommitState.OutcomeUnknown &&
       retryBatch.UncertainOperationId == "sale-004", "unknown outcome retains stable operation ID");
try { retryBatch.Commit("sale-005"); throw new Exception("new operation accepted after unknown outcome"); }
catch (InvalidOperationException) { Assert(failingBatchPort.Attempts == 1, "unknown outcome blocks second write"); }
try { retryBatch.StageImage(A("21", "")); throw new Exception("staging allowed after unknown outcome"); }
catch (InvalidOperationException) { Assert(retryBatch.PendingCount == 1, "unknown outcome blocks staging"); }
try { retryBatch.Clear(); throw new Exception("clearing allowed after unknown outcome"); }
catch (InvalidOperationException) { Assert(retryBatch.PendingCount == 1, "unknown outcome blocks clearing"); }
try { retryBatch.ReconcileUnknownOutcome("different-sale", true); throw new Exception("wrong operation reconciled"); }
catch (InvalidOperationException) { Assert(retryBatch.State == CheckoutCommitState.OutcomeUnknown, "reconciliation requires exact ID"); }
retryBatch.ReconcileUnknownOutcome("sale-004", true);
Assert(retryBatch.State == CheckoutCommitState.Ready && retryBatch.PendingCount == 0 &&
       retryBatch.Commit("sale-006") == CheckoutBatchStatus.Empty,
       "durably confirmed commit clears stage without resubmission");
var confirmedAbsent = new CheckoutBatchController(new RecordingCatalogue(), new RecordingPrompt(), new ThrowingAtomicBatchPort());
confirmedAbsent.StageImage(A("21", ""));
try { confirmedAbsent.Commit("sale-007"); throw new Exception("failure swallowed"); }
catch (ApplicationException) { }
confirmedAbsent.ReconcileUnknownOutcome("sale-007", false);
Assert(confirmedAbsent.State == CheckoutCommitState.Ready && confirmedAbsent.PendingCount == 1,
       "durably confirmed absent operation retains stage for explicit retry");

// Shared production composition: one catalogue contract drives list, photo grid,
// duplicate-barcode selection and the atomic batch without WPF/SQL dependencies.
var sharedReader = new CompositionCatalogue();
var sharedCart = new RecordingAtomicBatchPort();
var journal = new CompositionJournal();
var composition = new CheckoutComposition(sharedReader, new RecordingPrompt { Choice = 1 }, sharedCart, journal);
Assert(composition.AllProducts().Count == 3, "composition lists all catalogue articles");
Assert(composition.ImageProducts().Count == 1 &&
       composition.ImageProducts()[0].ArticleId == "21", "photo grid excludes products without actual image path");
var composedBatch = composition.CreateCheckoutBatch();
Assert(composedBatch.StageBarcode("123", 2).Article?.ArticleId == "12", "composition selects explicit duplicate barcode");
Assert(composedBatch.StageImage(A("21", ""), 1).Outcome == SelectionOutcome.Selected,
       "composition selects barcode-free photo article");
Assert(composedBatch.Commit("composed-001") == CheckoutBatchStatus.Committed &&
       sharedCart.Calls.Count == 1 && sharedCart.Calls[0].Lines.Count == 2,
       "composition dispatches validated mixed batch once");
// A changed catalogue identity between staging and commit invalidates the whole batch.
var mutableReader = new MutableCompositionCatalogue();
var staleCart = new RecordingAtomicBatchPort();
var staleComposition = new CheckoutComposition(mutableReader, new RecordingPrompt(), staleCart, journal);
var staleBatch = staleComposition.CreateCheckoutBatch();
Assert(staleBatch.StageBarcode("999").Outcome == SelectionOutcome.Selected,
       "mutable catalogue stages a real article");
mutableReader.ChangeIdentity = true;
Assert(staleBatch.Commit("composed-stale") == CheckoutBatchStatus.Invalidated &&
       staleCart.Calls.Count == 0, "identity changed before commit blocks whole batch");
try { new CheckoutComposition(null!, new RecordingPrompt(), sharedCart, journal); throw new Exception("missing reader accepted"); }
catch (ArgumentNullException) { Assert(true, "production composition refuses missing reader"); }
var uncertainCart = new ThrowingAtomicBatchPort();
var uncertainComposition = new CheckoutComposition(sharedReader, new RecordingPrompt(), uncertainCart, journal);
var uncertainBatch = uncertainComposition.CreateCheckoutBatch();
uncertainBatch.StageImage(A("21", ""));
try { uncertainBatch.Commit("composed-002"); throw new Exception("failure swallowed"); }
catch (ApplicationException) { }
Assert(uncertainComposition.Reconcile(uncertainBatch) == CheckoutOperationOutcome.Unknown &&
       uncertainBatch.State == CheckoutCommitState.OutcomeUnknown,
       "unknown durable journal outcome leaves cart blocked");
journal.Outcome = CheckoutOperationOutcome.Persisted;
Assert(uncertainComposition.Reconcile(uncertainBatch) == CheckoutOperationOutcome.Persisted &&
       uncertainBatch.PendingCount == 0 && uncertainBatch.State == CheckoutCommitState.Ready,
       "persisted journal outcome clears pending without duplicate post");
var absentBatch = uncertainComposition.CreateCheckoutBatch();
absentBatch.StageImage(A("21", ""));
try { absentBatch.Commit("composed-003"); throw new Exception("failure swallowed"); }
catch (ApplicationException) { }
journal.Outcome = CheckoutOperationOutcome.Absent;
Assert(uncertainComposition.Reconcile(absentBatch) == CheckoutOperationOutcome.Absent &&
       absentBatch.PendingCount == 1 && absentBatch.State == CheckoutCommitState.Ready,
       "absent durable outcome unlocks retained staged selection");

// Real-reader boundary must fail closed on corrupted/misrouted MariaDB result sets.
var mismatchedReader = new FaultyCatalogue { Mode = "wrong-barcode" };
var mismatchedCart = new RecordingAtomicBatchPort();
var mismatchedBatch = new CheckoutComposition(mismatchedReader, new RecordingPrompt(), mismatchedCart, journal).CreateCheckoutBatch();
try { mismatchedBatch.StageBarcode("123"); throw new Exception("wrong barcode accepted"); }
catch (InvalidOperationException) { Assert(mismatchedBatch.PendingCount == 0 && mismatchedCart.Calls.Count == 0,
    "wrong-barcode catalogue response cannot reach checkout"); }
var duplicateReader = new FaultyCatalogue { Mode = "duplicate-id" };
var duplicateBatch = new CheckoutComposition(duplicateReader, new RecordingPrompt(), mismatchedCart, journal).CreateCheckoutBatch();
try { duplicateBatch.StageBarcode("123"); throw new Exception("duplicate ID accepted"); }
catch (InvalidOperationException) { Assert(duplicateBatch.PendingCount == 0 && mismatchedCart.Calls.Count == 0,
    "duplicate identity cannot reach checkout"); }
var wrongArticleReader = new FaultyCatalogue { Mode = "wrong-article" };
var wrongArticleBatch = new CheckoutComposition(wrongArticleReader, new RecordingPrompt(), mismatchedCart, journal).CreateCheckoutBatch();
try { wrongArticleBatch.StageImage(A("21", "")); throw new Exception("wrong article accepted"); }
catch (InvalidOperationException) { Assert(wrongArticleBatch.PendingCount == 0 && mismatchedCart.Calls.Count == 0,
    "wrong-article refresh cannot reach checkout"); }

// WPF-facing session exercises the approved composition through a single executable
// catalogue -> variant choice -> staged cart -> atomic checkout path.
var sessionCart = new RecordingAtomicBatchPort();
var sessionJournal = new CompositionJournal();
var sessionComposition = new CheckoutComposition(new CompositionCatalogue(),
    new RecordingPrompt { Choice = 1 }, sessionCart, sessionJournal);
var session = sessionComposition.CreateSession();
Assert(session.Products.Count == 3 && session.ImageProducts.Count == 1,
       "session exposes all products and only image products");
// Both WPF catalogue views use the same immutable snapshot; tile selection
// cannot be forged by a stale or fabricated image entry.
Assert(session.SelectImage(new ProductSummary("21", "", "Forged", "fake/path.png")).Outcome ==
       SelectionOutcome.InvalidCandidates && session.PendingCount == 0,
       "forged photo tile cannot stage a sale");
Assert(session.SelectImage(new ProductSummary("11", "123", "No photo", "fake/path.png")).Outcome ==
       SelectionOutcome.InvalidCandidates && session.PendingCount == 0,
       "non-image list product cannot bypass image grid");
session.RefreshCatalogue();
Assert(session.Products.Count == 3 && session.ImageProducts.Count == 1,
       "explicit catalogue refresh preserves list/photo membership");
Assert(session.Scan("123", 2).Article?.ArticleId == "12" &&
       session.SelectImage(session.ImageProducts[0], 1).Outcome == SelectionOutcome.Selected &&
       session.PendingCount == 2, "session stages real barcode variant and image-only product");
Assert(session.Submit("session-001") == CheckoutBatchStatus.Committed &&
       sessionCart.Calls.Count == 1 &&
       sessionCart.Calls[0].Lines.SequenceEqual(new[] {
           new CheckoutBatchLine("12", 2), new CheckoutBatchLine("21", 1) }),
       "session sends one atomic mixed batch with original quantities");
Assert(session.PendingCount == 0 && session.OperationId is null,
       "acknowledged operation releases session ID");
var failedSession = new CheckoutComposition(new CompositionCatalogue(),
    new RecordingPrompt(), new ThrowingAtomicBatchPort(), sessionJournal).CreateSession();
failedSession.SelectImage(failedSession.ImageProducts[0]);
try { failedSession.Submit("session-002"); throw new Exception("failed write swallowed"); }
catch (ApplicationException) { }
Assert(failedSession.State == CheckoutCommitState.OutcomeUnknown &&
       failedSession.OperationId == "session-002", "session preserves ID after lost acknowledgement");
try { failedSession.Submit("session-003"); throw new Exception("different ID accepted"); }
catch (InvalidOperationException) { Assert(true, "session refuses changed ID"); }
try { failedSession.Scan("123"); throw new Exception("edit accepted during uncertainty"); }
catch (InvalidOperationException) { Assert(true, "session blocks edits while unknown"); }
Assert(failedSession.Reconcile() == CheckoutOperationOutcome.Unknown,
       "unknown journal keeps WPF session blocked");
sessionJournal.Outcome = CheckoutOperationOutcome.Persisted;
Assert(failedSession.Reconcile() == CheckoutOperationOutcome.Persisted &&
       failedSession.PendingCount == 0 && failedSession.OperationId is null,
       "durably persisted session clears without duplicate posting");
var invalidSession = new CheckoutComposition(new MutableCompositionCatalogue(),
    new RecordingPrompt(), new RecordingAtomicBatchPort(), new CompositionJournal()).CreateSession();
Assert(invalidSession.Scan("999").Outcome == SelectionOutcome.Selected,
       "session stages mutable catalogue product");
invalidSession.DiscardInvalidated();
Assert(invalidSession.PendingCount == 0, "explicit discard resets pending session");

// V1 parity: repeated product scans increment quantity, not duplicate sale rows.
var repeatedCart = new RecordingAtomicBatchPort();
var repeated = new CheckoutComposition(new CompositionCatalogue(), new RecordingPrompt { Choice = 1 },
    repeatedCart, new CompositionJournal()).CreateSession();
Assert(repeated.Scan("123", 2).Outcome == SelectionOutcome.Selected &&
       repeated.Scan("123", 3).Outcome == SelectionOutcome.Selected &&
       repeated.SelectImage(repeated.ImageProducts[0], 1).Outcome == SelectionOutcome.Selected,
       "repeated barcode and image selection stages");
Assert(repeated.Submit("repeat-001") == CheckoutBatchStatus.Committed &&
       repeatedCart.Calls.Count == 1 && repeatedCart.Calls[0].Lines.Count == 2 &&
       repeatedCart.Calls[0].Lines[0] == new CheckoutBatchLine("12", 5) &&
       repeatedCart.Calls[0].Lines[1] == new CheckoutBatchLine("21", 1),
       "same article aggregates quantities in first-selection order");
var overflowCart = new RecordingAtomicBatchPort();
var overflow = new CheckoutComposition(new CompositionCatalogue(), new RecordingPrompt { Choice = 1 },
    overflowCart, new CompositionJournal()).CreateSession();
overflow.Scan("123", int.MaxValue);
overflow.Scan("123", 1);
try { overflow.Submit("overflow-001"); throw new Exception("quantity overflow accepted"); }
catch (OverflowException) { Assert(overflowCart.Calls.Count == 0,
    "quantity overflow cannot write partial checkout"); }

// Real WPF tile selection must re-read live Inventory identity/photo/variant.
var photoReader = new MutablePhotoCatalogue();
var photoPort = new RecordingAtomicBatchPort();
var photoSession = new CheckoutComposition(photoReader, new RecordingPrompt(),
    photoPort, new CompositionJournal()).CreateSession();
var originalTile = photoSession.ImageProducts[0];
photoReader.VariantId = "replacement";
Assert(photoSession.SelectImage(originalTile).Outcome == SelectionOutcome.InvalidCandidates &&
       photoSession.PendingCount == 0, "changed variant cannot stage stale WPF tile");
photoReader.VariantId = "v1";
photoReader.ImagePath = null;
Assert(photoSession.SelectImage(originalTile).Outcome == SelectionOutcome.InvalidCandidates &&
       photoSession.PendingCount == 0, "removed photo cannot stage stale WPF tile");
photoReader.ImagePath = "images/replaced.png";
Assert(photoSession.SelectImage(originalTile).Outcome == SelectionOutcome.InvalidCandidates &&
       photoSession.PendingCount == 0, "replaced photo cannot stage stale WPF tile");
photoReader.ImagePath = "images/original.png";
Assert(photoSession.SelectImage(originalTile).Outcome == SelectionOutcome.Selected &&
       photoSession.Submit("photo-current-001") == CheckoutBatchStatus.Committed &&
       photoPort.Calls.Count == 1, "current WPF photo stages and posts exactly once");

var preCommitReader = new MutablePhotoCatalogue();
var preCommitPort = new RecordingAtomicBatchPort();
var preCommit = new CheckoutComposition(preCommitReader, new RecordingPrompt(),
    preCommitPort, new CompositionJournal()).CreateSession();
Assert(preCommit.SelectImage(preCommit.ImageProducts[0]).Outcome == SelectionOutcome.Selected,
       "live photo stages before catalogue update");
preCommitReader.VariantId = "new-variant";
Assert(preCommit.Submit("photo-stale-001") == CheckoutBatchStatus.Invalidated &&
       preCommitPort.Calls.Count == 0 && preCommit.PendingCount == 1,
       "photo variant changed after staging aborts entire atomic submission");
preCommit.DiscardInvalidated();
preCommit.RefreshCatalogue();
Assert(preCommit.SelectImage(preCommit.ImageProducts[0]).Outcome == SelectionOutcome.Selected &&
       preCommit.Submit("photo-fresh-002") == CheckoutBatchStatus.Committed &&
       preCommitPort.Calls.Count == 1,
       "operator refresh and explicit restage safely completes current variant");

Console.WriteLine("Production selection-to-checkout workflow regression suite passed.");

// W2 authorization envelope: reject incomplete identity, forged article sets,
// and unsupported payment values before any production port can be invoked.
AuthorizedCheckoutRequest W2(string id = "sale-001", string cashier = "cashier-01",
    CheckoutBatchLine[]? lines = null, CheckoutPayment[]? payments = null) =>
    new(id, cashier, "MAD", false,
        lines ?? new[] { new CheckoutBatchLine("article-1", 1) },
        payments ?? new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 25m) }, 25m);
W2().Validate();
Assert(true, "W2 authorized checkout envelope accepts explicit cashier/payment");
var brokenJournal = new FailingFinancialJournal();
var protectedPort = new RecordingFinancialPort();
var protectedGate = new AuthorizedCheckoutCommitGate(protectedPort, brokenJournal);
try { protectedGate.Commit(W2(id: "lookup-failed")); throw new Exception("must throw"); }
catch (ApplicationException) { }
Assert(protectedGate.UncertainOperationId == "lookup-failed" && protectedPort.Calls == 0,
    "failed durable lookup blocks posting and records unknown operation");
try { protectedGate.Commit(W2(id: "different-operation")); throw new Exception("must block"); }
catch (InvalidOperationException) { }
Assert(protectedPort.Calls == 0, "unknown lookup cannot authorize another financial write");
brokenJournal.Outcome = CheckoutOperationOutcome.Absent;
Assert(protectedGate.Reconcile("lookup-failed") == CheckoutOperationOutcome.Absent &&
       protectedGate.UncertainOperationId is null,
    "durable absent reconciliation unlocks after lookup outage");
var financialJournal = new CompositionJournal { Outcome = CheckoutOperationOutcome.Absent };
var financialPort = new RecordingFinancialPort();
var financialGate = new AuthorizedCheckoutCommitGate(financialPort, financialJournal);
Assert(financialGate.Commit(W2(id: "financial-1")) == FinancialCommitOutcome.Committed &&
       financialPort.Calls == 1, "financial gate delegates exactly one validated request");
financialJournal.Outcome = CheckoutOperationOutcome.Persisted;
Assert(financialGate.Commit(W2(id: "financial-1")) == FinancialCommitOutcome.AlreadyCommitted &&
       financialPort.Calls == 1, "persisted financial operation never reposts");
financialJournal.Outcome = CheckoutOperationOutcome.Absent;
financialPort.ThrowOnCommit = true;
try { financialGate.Commit(W2(id: "financial-unknown")); throw new Exception("must throw"); }
catch (ApplicationException) { }
Assert(financialGate.UncertainOperationId == "financial-unknown" && financialPort.Calls == 2,
    "ambiguous financial write locks operation ID");
try { financialGate.Commit(W2(id: "financial-2")); throw new Exception("must block"); }
catch (InvalidOperationException) { }
Assert(financialPort.Calls == 2, "unknown financial outcome blocks next write");
financialJournal.Outcome = CheckoutOperationOutcome.Unknown;
Assert(financialGate.Reconcile("financial-unknown") == CheckoutOperationOutcome.Unknown &&
       financialGate.UncertainOperationId == "financial-unknown",
    "unknown ledger lookup does not unlock");
financialJournal.Outcome = CheckoutOperationOutcome.Persisted;
Assert(financialGate.Reconcile("financial-unknown") == CheckoutOperationOutcome.Persisted &&
       financialGate.UncertainOperationId is null, "durable persisted reconciliation unlocks");

static bool InvalidW2(AuthorizedCheckoutRequest request)
{
    try { request.Validate(); return false; }
    catch (ArgumentException) { return true; }
}
Assert(InvalidW2(W2(id: "")), "W2 rejects missing operation ID");
Assert(InvalidW2(W2() with { Currency = " " }), "W2 rejects missing currency");
Assert(InvalidW2(W2(lines: Array.Empty<CheckoutBatchLine>())), "W2 rejects empty sale lines");
Assert(InvalidW2(W2(lines: new[] { new CheckoutBatchLine("article-1", 0) })), "W2 rejects zero quantity");
Assert(InvalidW2(W2() with { ExpectedTotal = 0m }), "W2 rejects zero expected total");
(W2() with { IsReturn = true }).Validate();
Assert(true, "W2 allows non-credit return pending real Checkout policy");
Assert(InvalidW2(W2(cashier: "")), "W2 rejects unauthenticated cashier");
Assert(InvalidW2(W2(lines: new[] { new CheckoutBatchLine("A", 1), new CheckoutBatchLine("a", 2) })),
    "W2 rejects case-colliding article identities");
Assert(InvalidW2(W2(payments: new[] { new CheckoutPayment((CheckoutPaymentKind)999, 25m) })),
    "W2 rejects unknown payment kind");
Assert(InvalidW2(W2(payments: new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, -1m) })),
    "W2 rejects negative payment amount");
Assert(InvalidW2(W2() with { IsReturn = true, Payments = new[] { new CheckoutPayment(CheckoutPaymentKind.Credit, 25m) } }),
    "W2 rejects return credit without explicit checkout policy");


sealed class RecordingCheckoutPort : ICheckoutArticlePort
{
    public List<(string, int)> Calls { get; } = new();
    public void AddSelectedArticle(string articleId, int quantity) => Calls.Add((articleId, quantity));
}
sealed class ThrowingCheckoutPort : ICheckoutArticlePort
{
    public int Attempts { get; private set; }
    public void AddSelectedArticle(string articleId, int quantity)
    {
        Attempts++;
        throw new ApplicationException("checkout unavailable");
    }
}

sealed class RecordingCatalogue : ICheckoutSelectionCatalogue
{
    public List<string> BarcodeReads { get; } = new();
    public List<string> ArticleReads { get; } = new();
    public bool ChangeRefresh { get; set; }
    public bool ReplaceImage { get; set; }
    public IReadOnlyList<ArticleCandidate> FindBarcode(string barcode)
    {
        BarcodeReads.Add("find:" + barcode);
        return new[] { new ArticleCandidate("11", barcode), new ArticleCandidate("12", barcode) };
    }
    public IReadOnlyList<ArticleCandidate> RefreshBarcode(string barcode)
    {
        BarcodeReads.Add("refresh:" + barcode);
        return ChangeRefresh
            ? new[] { new ArticleCandidate("11", barcode) }
            : new[] { new ArticleCandidate("11", barcode), new ArticleCandidate("12", barcode) };
    }
    public IReadOnlyList<ArticleCandidate> RefreshArticle(string articleId)
    {
        ArticleReads.Add(articleId);
        return new[] { new ArticleCandidate(ReplaceImage ? "22" : articleId, "") };
    }
}
sealed class RecordingPrompt : ICheckoutVariantPrompt
{
    public int Choice { get; set; }
    public int Attempts { get; private set; }
    public int Choose(IReadOnlyList<ArticleCandidate> candidates)
    {
        Attempts++;
        return Choice;
    }
}

sealed class RecordingAtomicBatchPort : IAtomicCheckoutBatchPort
{
    public List<(List<CheckoutBatchLine> Lines, string OperationId)> Calls { get; } = new();
    public void AddBatch(IReadOnlyList<CheckoutBatchLine> lines, string operationId)
        => Calls.Add((lines.ToList(), operationId));
}
sealed class ThrowingAtomicBatchPort : IAtomicCheckoutBatchPort
{
    public int Attempts { get; private set; }
    public void AddBatch(IReadOnlyList<CheckoutBatchLine> lines, string operationId)
    {
        Attempts++;
        throw new ApplicationException("transaction result unknown");
    }
}

sealed class CompositionCatalogue : ICatalogueReader
{
    private static readonly ProductSummary[] Products = {
        new("11", "123", "First", null),
        new("12", "123", "Variant", null, "v2"),
        new("21", "", "Photo only", "images/21.png")
    };
    public IReadOnlyList<ProductSummary> ListAll() => Products;
    public IReadOnlyList<ProductSummary> FindBarcode(string barcode) =>
        Products.Where(p => p.Barcode == barcode).ToArray();
    public IReadOnlyList<ProductSummary> RefreshBarcode(string barcode) => FindBarcode(barcode);
    public IReadOnlyList<ProductSummary> RefreshArticle(string articleId) =>
        Products.Where(p => p.ArticleId == articleId).ToArray();
}
sealed class CompositionJournal : ICheckoutOperationJournal
{
    public CheckoutOperationOutcome Outcome { get; set; } = CheckoutOperationOutcome.Unknown;
    public CheckoutOperationOutcome Lookup(string operationId) => Outcome;
}

sealed class MutableCompositionCatalogue : ICatalogueReader
{
    public bool ChangeIdentity { get; set; }
    private ProductSummary Current => new(ChangeIdentity ? "new-id" : "old-id", "999", "Mutable", null);
    public IReadOnlyList<ProductSummary> ListAll() => new[] { Current };
    public IReadOnlyList<ProductSummary> FindBarcode(string barcode) => new[] { Current };
    public IReadOnlyList<ProductSummary> RefreshBarcode(string barcode) => new[] { Current };
    public IReadOnlyList<ProductSummary> RefreshArticle(string articleId) => new[] { Current };
}

sealed class MutablePhotoCatalogue : ICatalogueReader
{
    public string? ImagePath { get; set; } = "images/original.png";
    public string? VariantId { get; set; } = "v1";
    private ProductSummary Current => new("photo-1", "", "Image article", ImagePath, VariantId);
    public IReadOnlyList<ProductSummary> ListAll() => new[] { Current };
    public IReadOnlyList<ProductSummary> FindBarcode(string barcode) => Array.Empty<ProductSummary>();
    public IReadOnlyList<ProductSummary> RefreshBarcode(string barcode) => Array.Empty<ProductSummary>();
    public IReadOnlyList<ProductSummary> RefreshArticle(string articleId) => new[] { Current };
}

sealed class FaultyCatalogue : ICatalogueReader
{
    public string Mode { get; set; } = "";
    public IReadOnlyList<ProductSummary> ListAll() => Array.Empty<ProductSummary>();
    public IReadOnlyList<ProductSummary> FindBarcode(string barcode) => Mode switch
    {
        "wrong-barcode" => new[] { new ProductSummary("11", "other", "Wrong", null) },
        "duplicate-id" => new[] { new ProductSummary("11", barcode, "A", null),
                                  new ProductSummary("11", barcode, "B", null) },
        _ => Array.Empty<ProductSummary>()
    };
    public IReadOnlyList<ProductSummary> RefreshBarcode(string barcode) => FindBarcode(barcode);
    public IReadOnlyList<ProductSummary> RefreshArticle(string articleId) =>
        new[] { new ProductSummary("22", "", "Wrong article", null) };
}



sealed class RecordingFinancialPort : IAuthorizedCheckoutPort
{
    public int Calls { get; private set; }
    public bool ThrowOnCommit { get; set; }
    public void Commit(AuthorizedCheckoutRequest request)
    {
        Calls++;
        if (ThrowOnCommit) throw new ApplicationException("acknowledgement lost");
    }
}

sealed class FailingFinancialJournal : ICheckoutOperationJournal
{
    public CheckoutOperationOutcome? Outcome { get; set; }
    public CheckoutOperationOutcome Lookup(string operationId) =>
        Outcome ?? throw new ApplicationException("durable journal unavailable");
}
