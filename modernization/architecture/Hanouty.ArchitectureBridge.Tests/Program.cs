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
Assert(composition.AllProducts().Select(p => p.ArticleId).Distinct(StringComparer.OrdinalIgnoreCase).Count() == 3,
       "production catalogue snapshot preserves unique article identities");
Assert(composition.ImageProducts().Count == 1 &&
       composition.ImageProducts()[0].ArticleId == "21", "photo grid excludes products without actual image path");
var detachedPhotos = composition.ImageProducts();
Assert(detachedPhotos is not IList<ProductSummary> writablePhotos || writablePhotos.IsReadOnly,
       "photo grid cannot be modified through IList");
if (detachedPhotos is IList<ProductSummary> immutablePhotos)
{
    try { immutablePhotos[0] = new ProductSummary("forged", "", "Forged", "images/forged.png");
          throw new Exception("photo grid mutation accepted"); }
    catch (NotSupportedException) { Assert(composition.ImageProducts()[0].ArticleId == "21",
        "photo grid mutation rejected without changing catalogue"); }
}

// A variant prompt receives read-only candidates; it must never rewrite article
// identity in the bridge's selection buffer before the live revalidation.
var guardedPrompt = new CandidateMutationPrompt();
var guardedCart = new RecordingAtomicBatchPort();
var guardedBatch = new CheckoutComposition(sharedReader, guardedPrompt, guardedCart, journal).CreateCheckoutBatch();
Assert(guardedBatch.StageBarcode("123").Outcome == SelectionOutcome.Selected &&
       guardedPrompt.MutationRejected && guardedBatch.PendingCount == 1 &&
       guardedCart.Calls.Count == 0,
       "variant prompt cannot mutate bridge selection candidates");
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
journal.Outcome = (CheckoutOperationOutcome)999;
try { uncertainComposition.Reconcile(uncertainBatch); throw new Exception("invalid journal outcome accepted"); }
catch (InvalidOperationException ex) when (ex.Message.Contains("unsupported durable outcome")) {
    Assert(uncertainBatch.State == CheckoutCommitState.OutcomeUnknown &&
           uncertainBatch.UncertainOperationId == "composed-002" &&
           uncertainBatch.PendingCount == 1 && uncertainCart.Attempts == 1,
           "invalid durable journal outcome preserves unknown lock and never reposts");
}
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
// Barcode selection must enforce the same null-display guard as WPF catalogue lists.
var nullNameReader = new FaultyCatalogue { Mode = "null-display" };
var nullNameCart = new RecordingAtomicBatchPort();
var nullNameBatch = new CheckoutComposition(nullNameReader, new RecordingPrompt(), nullNameCart, journal).CreateCheckoutBatch();
try { nullNameBatch.StageBarcode("123"); throw new Exception("null display accepted through barcode"); }
catch (InvalidOperationException) { Assert(nullNameBatch.PendingCount == 0 && nullNameCart.Calls.Count == 0,
    "null display barcode selection fails closed before financial staging"); }
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
var sessionImages = session.ImageProducts;
Assert(ReferenceEquals(sessionImages, session.ImageProducts),
       "image grid uses the same immutable snapshot throughout one catalogue generation");
Assert(sessionImages is IList<ProductSummary>, "session image catalogue has a guarded list surface");
try
{
    ((IList<ProductSummary>)sessionImages)[0] =
        new ProductSummary("forged", "", "Forged tile", "images/forged.png");
    throw new Exception("session image catalogue mutation accepted");
}
catch (NotSupportedException)
{
    Assert(session.ImageProducts.Count == 1 && session.ImageProducts[0].ArticleId == "21",
        "session photo-grid snapshot rejects mutation without changing catalogue identity");
}
// Both WPF catalogue views use the same immutable snapshot; tile selection
// cannot be forged by a stale or fabricated image entry.
Assert(session.SelectImage(new ProductSummary("21", "", "Forged", "fake/path.png")).Outcome ==
       SelectionOutcome.InvalidCandidates && session.PendingCount == 0,
       "forged photo tile cannot stage a sale");
Assert(session.SelectImage(new ProductSummary("11", "123", "No photo", "fake/path.png")).Outcome ==
       SelectionOutcome.InvalidCandidates && session.PendingCount == 0,
       "non-image list product cannot bypass image grid");
// Ambiguous duplicate photo identities must not silently choose the first tile.
var duplicatePhotoPort = new RecordingAtomicBatchPort();
var duplicatePhotoSession = new CheckoutComposition(new DuplicatePhotoCatalogue(),
    new RecordingPrompt(), duplicatePhotoPort, new CompositionJournal()).CreateSession();
try { _ = duplicatePhotoSession.Products; throw new Exception("duplicate catalogue accepted"); }
catch (InvalidOperationException ex) when (ex.Message.Contains("duplicate article identity"))
{
    Assert(duplicatePhotoSession.PendingCount == 0 && duplicatePhotoPort.Calls.Count == 0,
        "duplicate catalogue identity rejected before any selection or posting");
}
var immutableCatalogue = sessionComposition.AllProducts();
Assert(immutableCatalogue is System.Collections.Generic.IList<ProductSummary>,
    "catalogue exposes a guarded collection contract");
try {
    ((System.Collections.Generic.IList<ProductSummary>)immutableCatalogue)[0] =
        new ProductSummary("forged", "", "Forged", null);
    throw new Exception("catalogue snapshot was mutable");
}
catch (NotSupportedException) { Assert(true, "catalogue snapshot rejects mutation"); }
session.RefreshCatalogue();
Assert(!ReferenceEquals(sessionImages, session.ImageProducts) &&
       ReferenceEquals(session.ImageProducts, session.ImageProducts),
       "explicit catalogue refresh replaces image snapshot atomically");
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
var mutableInvalidCatalogue = new MutableCompositionCatalogue();
var invalidPort = new RecordingAtomicBatchPort();
var invalidSession = new CheckoutComposition(mutableInvalidCatalogue,
    new RecordingPrompt(), invalidPort, new CompositionJournal()).CreateSession();
Assert(invalidSession.SelectArticle(invalidSession.Products[0]).Outcome == SelectionOutcome.Selected,
       "session stages mutable catalogue product");
mutableInvalidCatalogue.ChangeIdentity = true;
Assert(invalidSession.Submit("invalidated-001") == CheckoutBatchStatus.Invalidated &&
       invalidPort.Calls.Count == 0, "stale article refuses financial posting");
mutableInvalidCatalogue.ChangeIdentity = false;
try { invalidSession.Submit("invalidated-001"); throw new Exception("invalidated retry accepted"); }
catch (InvalidOperationException) { Assert(invalidPort.Calls.Count == 0,
    "restored catalogue cannot silently retry invalidated financial operation"); }
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

// A legacy DataRow/DBNull mapping must not leak a null display label into
// the modern WPF catalogue snapshot, even if its DTO contract says non-null.
var malformedDisplayReader = new MutablePhotoCatalogue { DisplayName = null! };
try
{
    new CheckoutComposition(malformedDisplayReader, new RecordingPrompt(),
        new RecordingAtomicBatchPort(), new CompositionJournal()).AllProducts();
    throw new Exception("null catalogue display name accepted");
}
catch (InvalidOperationException ex) when (ex.Message.Contains("display name", StringComparison.Ordinal))
{
    Assert(true, "null legacy display name fails closed at modern catalogue boundary");
}

// Empty or whitespace-only labels are not usable cashier-facing catalogue names.
foreach (var invalidLabel in new[] { "", "   ", "\t" })
{
    var invalidReader = new MutablePhotoCatalogue { DisplayName = invalidLabel };
    try
    {
        new CheckoutComposition(invalidReader, new RecordingPrompt(),
            new RecordingAtomicBatchPort(), new CompositionJournal()).AllProducts();
        throw new Exception("blank catalogue display name accepted");
    }
    catch (InvalidOperationException ex) when (ex.Message.Contains("display name", StringComparison.Ordinal))
    {
        Assert(true, "blank legacy display name fails closed at modern catalogue boundary");
    }
}

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
photoReader.DisplayName = "Renamed article";
Assert(photoSession.SelectImage(originalTile).Outcome == SelectionOutcome.InvalidCandidates &&
       photoSession.PendingCount == 0 && photoPort.Calls.Count == 0,
       "renamed photo article cannot stage stale WPF tile");
photoReader.DisplayName = "Image article";
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
var invalidStateJournal = new CompositionJournal { Outcome = (CheckoutOperationOutcome)99 };
var invalidStatePort = new RecordingFinancialPort();
var invalidStateGate = new AuthorizedCheckoutCommitGate(invalidStatePort, invalidStateJournal);
try { invalidStateGate.Commit(W2(id: "invalid-journal")); throw new Exception("invalid journal accepted"); }
catch (InvalidOperationException ex) when (ex.Message.Contains("unsupported outcome")) { }
Assert(invalidStatePort.Calls == 0 && invalidStateGate.UncertainOperationId == "invalid-journal",
    "invalid durable state prevents posting and locks operation");
try { invalidStateGate.Reconcile("invalid-journal"); throw new Exception("invalid reconciliation accepted"); }
catch (InvalidOperationException ex) when (ex.Message.Contains("unsupported outcome")) { }
Assert(invalidStateGate.UncertainOperationId == "invalid-journal",
    "invalid reconciliation cannot unlock financial gate");
invalidStateJournal.Outcome = CheckoutOperationOutcome.Absent;
Assert(invalidStateGate.Reconcile("invalid-journal") == CheckoutOperationOutcome.Absent &&
       invalidStateGate.UncertainOperationId is null, "valid durable reconciliation unlocks");
var mutableFinancialLines = new[] { new CheckoutBatchLine("immutable-article", 1) };
var mutableFinancialPayments = new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 25m) };
var snapshotJournal = new CompositionJournal { Outcome = CheckoutOperationOutcome.Absent };
var snapshotPort = new RecordingFinancialPort();
snapshotPort.OnCommit = () =>
{
    mutableFinancialLines[0] = new CheckoutBatchLine("forged-article", 99);
    mutableFinancialPayments[0] = new CheckoutPayment(CheckoutPaymentKind.Credit, 1m);
    snapshotJournal.Outcome = CheckoutOperationOutcome.Persisted;
};
var snapshotGate = new AuthorizedCheckoutCommitGate(snapshotPort, snapshotJournal);
Assert(snapshotGate.Commit(W2(id: "snapshot-1", lines: mutableFinancialLines,
       payments: mutableFinancialPayments)) == FinancialCommitOutcome.Committed &&
       snapshotPort.LastRequest!.Lines[0].ArticleId == "immutable-article" &&
       snapshotPort.LastRequest.Payments[0].Kind == CheckoutPaymentKind.Cash,
    "financial posting uses immutable validated line/payment snapshot");

var financialJournal = new CompositionJournal { Outcome = CheckoutOperationOutcome.Absent };
var financialPort = new RecordingFinancialPort();
financialPort.OnCommit = () => financialJournal.Outcome = CheckoutOperationOutcome.Persisted;
var financialGate = new AuthorizedCheckoutCommitGate(financialPort, financialJournal);
var reentrantJournal = new CompositionJournal { Outcome = CheckoutOperationOutcome.Absent };
var reentrantPort = new ReentrantFinancialPort();
reentrantPort.OnCommit = () => reentrantJournal.Outcome = CheckoutOperationOutcome.Persisted;
var reentrantGate = new AuthorizedCheckoutCommitGate(reentrantPort, reentrantJournal);
reentrantPort.OnCommit = () =>
{
    reentrantJournal.Outcome = CheckoutOperationOutcome.Persisted;
    try { reentrantGate.Commit(W2(id: "financial-reentrant")); throw new Exception("nested commit accepted"); }
    catch (InvalidOperationException ex) when (ex.Message.Contains("already in progress")) { }
    try { reentrantGate.Reconcile("financial-reentrant"); throw new Exception("reconcile during commit accepted"); }
    catch (InvalidOperationException ex) when (ex.Message.Contains("already in progress")) { }
};
Assert(reentrantGate.Commit(W2(id: "financial-outer")) == FinancialCommitOutcome.Committed &&
       reentrantPort.Calls == 1, "reentrant financial posting and reconciliation cannot overlap");
var absentJournal = new CompositionJournal { Outcome = CheckoutOperationOutcome.Absent };
var absentPort = new RecordingFinancialPort();
var absentGate = new AuthorizedCheckoutCommitGate(absentPort, absentJournal);
Assert(absentGate.Commit(W2(id: "unconfirmed-financial")) == FinancialCommitOutcome.Unknown &&
       absentGate.UncertainOperationId == "unconfirmed-financial" && absentPort.Calls == 1,
    "successful port acknowledgement without durable journal proof remains unknown");
try { absentGate.Commit(W2(id: "different-financial")); throw new Exception("unconfirmed commit accepted"); }
catch (InvalidOperationException) { }
Assert(absentPort.Calls == 1, "unconfirmed financial operation cannot be blindly retried");
Assert(absentGate.Reconcile("unconfirmed-financial") == CheckoutOperationOutcome.Absent &&
       absentGate.UncertainOperationId is null,
    "durable absent reconciliation unlocks without claiming persistence");
var journalDown = new FailingFinancialJournal();
var journalDownPort = new RecordingFinancialPort();
var journalDownGate = new AuthorizedCheckoutCommitGate(journalDownPort, journalDown);
try { journalDownGate.Commit(W2(id: "journal-down")); throw new Exception("journal failure accepted"); }
catch (ApplicationException) { }
Assert(journalDownGate.UncertainOperationId == "journal-down" && journalDownPort.Calls == 0,
    "journal lookup failure locks operation before any posting");
journalDown.Outcome = CheckoutOperationOutcome.Absent;
Assert(journalDownGate.Reconcile("journal-down") == CheckoutOperationOutcome.Absent,
    "journal recovery reconciles previously unknown operation");

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
// Durable original-ticket identity is mandatory for returns but forbidden on sales.
// The financial port still owns real refund authorization and remains fail-closed.
var returnEnvelope = W2(id: "refund-contract-001") with {
    IsReturn = true, OriginalTicketId = "persisted-ticket-001"
};
returnEnvelope.Validate();
Assert(returnEnvelope.OriginalTicketId == "persisted-ticket-001",
    "return envelope carries the durable original ticket identity");
Assert(InvalidW2(W2() with { IsReturn = true }),
    "return envelope denies missing original ticket identity");
Assert(InvalidW2(W2() with { IsReturn = true, OriginalTicketId = "  " }),
    "return envelope denies blank original ticket identity");
Assert(InvalidW2(W2() with { OriginalTicketId = "persisted-ticket-001" }),
    "sale envelope rejects injected original ticket identity");
Assert(InvalidW2(W2(id: "")), "W2 rejects missing operation ID");
Assert(InvalidW2(W2() with { Currency = " " }), "W2 rejects missing currency");
Assert(InvalidW2(W2(lines: Array.Empty<CheckoutBatchLine>())), "W2 rejects empty sale lines");
Assert(InvalidW2(W2(lines: new[] { new CheckoutBatchLine("article-1", 0) })), "W2 rejects zero quantity");
Assert(InvalidW2(W2() with { ExpectedTotal = 0m }), "W2 rejects zero expected total");
(W2() with { IsReturn = true, OriginalTicketId = "persisted-ticket-001" }).Validate();
Assert(true, "W2 allows referenced non-credit return pending real Checkout policy");
Assert(InvalidW2(W2(cashier: "")), "W2 rejects unauthenticated cashier");
Assert(InvalidW2(W2(lines: new[] { new CheckoutBatchLine("A", 1), new CheckoutBatchLine("a", 2) })),
    "W2 rejects case-colliding article identities");
Assert(InvalidW2(W2(payments: new[] { new CheckoutPayment((CheckoutPaymentKind)999, 25m) })),
    "W2 rejects unknown payment kind");
Assert(InvalidW2(W2(payments: new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, -1m) })),
    "W2 rejects negative payment amount");
Assert(InvalidW2(W2() with { IsReturn = true, Payments = new[] { new CheckoutPayment(CheckoutPaymentKind.Credit, 25m) } }),
    "W2 rejects return credit without explicit checkout policy");



var paymentJournal = new CompositionJournal { Outcome = CheckoutOperationOutcome.Absent };
var paymentPort = new RecordingFinancialPort { OnCommit = () => paymentJournal.Outcome = CheckoutOperationOutcome.Persisted };
var paymentContextReads = 0;
var financialBatch = new AuthorizedCheckoutBatchAdapter(
    new AuthorizedCheckoutCommitGate(paymentPort, paymentJournal),
    () => { paymentContextReads++; return new AuthorizedCheckoutPaymentContext(
        "cashier-01", "MAD", false,
        new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 25m) }, 25m); });
financialBatch.AddBatch(new[] { new CheckoutBatchLine("article-01", 2) }, "financial-batch-001");
Assert(paymentPort.Calls == 1 && paymentContextReads == 1 &&
    paymentPort.LastRequest?.OperationId == "financial-batch-001" &&
    paymentPort.LastRequest.CashierId == "cashier-01" &&
    paymentPort.LastRequest.Lines[0].Quantity == 2 &&
    paymentPort.LastRequest.Payments[0].Amount == 25m,
    "explicit payment adapter sends cashier, tender, quantity and stable ID to existing financial gate");
financialBatch.AddBatch(new[] { new CheckoutBatchLine("article-01", 2) }, "financial-batch-001");
Assert(paymentPort.Calls == 1, "durable persisted operation is never posted twice");
// One adapter and gate must read a fresh authorized context per distinct operation,
// while each posted request retains the first operation's immutable tender snapshot.
var sequentialJournal = new CompositionJournal { Outcome = CheckoutOperationOutcome.Absent };
var sequentialPort = new RecordingFinancialPort {
    OnCommit = () => sequentialJournal.Outcome = CheckoutOperationOutcome.Persisted
};
var activeTender = new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 5.25m) };
var activeCashier = "cashier-01";
var activeTotal = 5.25m;
var sequentialReads = 0;
var sequentialBatch = new AuthorizedCheckoutBatchAdapter(
    new AuthorizedCheckoutCommitGate(sequentialPort, sequentialJournal),
    () => { sequentialReads++; return new AuthorizedCheckoutPaymentContext(
        activeCashier, "MAD", false, activeTender, activeTotal); });
sequentialBatch.AddBatch(new[] { new CheckoutBatchLine("article-01", 1) }, "sequential-001");
var firstRequest = sequentialPort.LastRequest!;
activeCashier = "cashier-02";
activeTender[0] = new CheckoutPayment(CheckoutPaymentKind.Cash, 10m);
activeTotal = 10m;
sequentialJournal.Outcome = CheckoutOperationOutcome.Absent;
sequentialBatch.AddBatch(new[] { new CheckoutBatchLine("article-02", 2) }, "sequential-002");
Assert(sequentialPort.Calls == 2 && sequentialReads == 2 &&
    firstRequest.OperationId == "sequential-001" && firstRequest.CashierId == "cashier-01" &&
    firstRequest.Payments[0].Amount == 5.25m && firstRequest.ExpectedTotal == 5.25m &&
    sequentialPort.LastRequest?.OperationId == "sequential-002" &&
    sequentialPort.LastRequest.CashierId == "cashier-02" &&
    sequentialPort.LastRequest.Payments[0].Amount == 10m &&
    sequentialPort.LastRequest.ExpectedTotal == 10m,
    "distinct operations use fresh cashier/payment context without mutating the prior request");

var unknownJournal = new CompositionJournal { Outcome = CheckoutOperationOutcome.Unknown };
var unknownPort = new RecordingFinancialPort();
var unknownBatch = new AuthorizedCheckoutBatchAdapter(
    new AuthorizedCheckoutCommitGate(unknownPort, unknownJournal),
    () => new AuthorizedCheckoutPaymentContext("cashier-01", "MAD", false,
        new[] { new CheckoutPayment(CheckoutPaymentKind.Cash, 25m) }, 25m));
try { unknownBatch.AddBatch(new[] { new CheckoutBatchLine("article-01", 1) }, "unknown-001"); throw new Exception("unknown accepted"); }
catch (InvalidOperationException ex) when (ex.Message.Contains("Financial outcome unknown")) { }
Assert(unknownPort.Calls == 0, "unknown journal cannot trigger financial write");


var lineSnapshotPort = new RecordingAtomicBatchPort();
var snapshotSession = new CheckoutComposition(new CompositionCatalogue(),
    new RecordingPrompt { Choice = 0 }, lineSnapshotPort, new CompositionJournal()).CreateSession();
Assert(snapshotSession.PendingLines.Count == 0, "empty session snapshot has no lines");
snapshotSession.Scan("123", 2);
snapshotSession.Scan("123", 3);
var capturedLines = snapshotSession.PendingLines;
Assert(capturedLines.Count == 1 && capturedLines[0] == new CheckoutBatchLine("11", 5) &&
    lineSnapshotPort.Calls.Count == 0, "pending lines aggregate repeated scans without posting");
try { ((IList<CheckoutBatchLine>)capturedLines)[0] = new CheckoutBatchLine("forged", 99);
    throw new Exception("mutable pending snapshot"); }
catch (NotSupportedException) { }
snapshotSession.Scan("123", 1);
Assert(capturedLines[0].Quantity == 5 && snapshotSession.PendingLines[0].Quantity == 6,
    "pending lines are detached from later session edits");
var reentrantSessionQuoteRejected = false;
lineSnapshotPort.OnAdd = () =>
{
    try { _ = snapshotSession.PendingLines; }
    catch (InvalidOperationException) { reentrantSessionQuoteRejected = true; }
};
Assert(snapshotSession.Submit("snapshot-live-commit") == CheckoutBatchStatus.Committed &&
    reentrantSessionQuoteRejected &&
    lineSnapshotPort.Calls.Single().Lines.Single() == new CheckoutBatchLine("11", 6) &&
    snapshotSession.PendingLines.Count == 0,
    "production commit freezes posted lines, rejects reentrant quote and clears committed stage");
// The trusted cash quote must read the SAME Application session as WPF selection,
// not reconstruct quantities from UI rows or a second catalogue instance.
var quotePort = new RecordingAtomicBatchPort();
var quoteSession = new CheckoutComposition(new CompositionCatalogue(),
    new RecordingPrompt { Choice = 0 }, quotePort, new CompositionJournal()).CreateSession();
var quoteProduct = quoteSession.Products.Single(p => p.ArticleId == "21");
Assert(quoteSession.SelectArticle(quoteProduct, 2).Outcome == SelectionOutcome.Selected,
    "barcode-free list article stages through the production Application session");
Assert(quoteSession.SelectArticle(quoteProduct, 1).Outcome == SelectionOutcome.Selected,
    "second selection uses the same staged basket");
var trustedQuoteLines = quoteSession.PendingLines;
Assert(trustedQuoteLines.Count == 1 && trustedQuoteLines[0] ==
    new CheckoutBatchLine("21", 3),
    "authoritative quote input aggregates selected list quantities, not WPF display values");
try { ((IList<CheckoutBatchLine>)trustedQuoteLines)[0] = new CheckoutBatchLine("21", 99);
    throw new Exception("trusted quote input was mutable"); }
catch (NotSupportedException) { }
Assert(quoteSession.Submit("quote-session-001") == CheckoutBatchStatus.Committed &&
    quotePort.Calls.Single().Lines.Single() == trustedQuoteLines.Single() &&
    quoteSession.PendingLines.Count == 0,
    "quote input and committed batch have identical identities and quantities; next operation starts empty");

var unknownSnapshotPort = new ThrowingAtomicBatchPort();
var unknownSnapshot = new CheckoutComposition(new CompositionCatalogue(),
    new RecordingPrompt { Choice = 0 }, unknownSnapshotPort, new CompositionJournal()).CreateSession();
unknownSnapshot.Scan("123");
try { unknownSnapshot.Submit("snapshot-unknown"); }
catch (ApplicationException) { }
try { _ = unknownSnapshot.PendingLines; throw new Exception("unknown snapshot exposed"); }
catch (InvalidOperationException) { }
Assert(unknownSnapshotPort.Attempts == 1, "unknown session snapshot cannot authorize retry");
try { unknownSnapshot.Submit("snapshot-unknown"); throw new Exception("uncertain operation retried"); }
catch (InvalidOperationException ex) when (ex.Message.Contains("Reconcile the uncertain checkout outcome")) { }
Assert(unknownSnapshotPort.Attempts == 1 &&
    unknownSnapshot.State == CheckoutCommitState.OutcomeUnknown &&
    unknownSnapshot.OperationId == "snapshot-unknown",
    "repeat submit stays fail-closed until durable reconciliation, without second financial write");
var overflowSnapshotPort = new RecordingAtomicBatchPort();
var overflowSnapshot = new CheckoutComposition(new CompositionCatalogue(),
    new RecordingPrompt { Choice = 0 }, overflowSnapshotPort, new CompositionJournal()).CreateSession();
overflowSnapshot.Scan("123", int.MaxValue);
overflowSnapshot.Scan("123", 1);
try { _ = overflowSnapshot.PendingLines; throw new Exception("overflow snapshot accepted"); }
catch (OverflowException) { }
Assert(overflowSnapshotPort.Calls.Count == 0, "quantity overflow cannot reach posting from preview");

// A reentrant WPF quote must not observe a basket during posting.
var reentrantQuotePort = new RecordingAtomicBatchPort();
var reentrantQuoteBatch = new CheckoutBatchController(new RecordingCatalogue(),
    new RecordingPrompt { Choice = 0 }, reentrantQuotePort);
Assert(reentrantQuoteBatch.StageImage(A("21", ""), 1).Outcome == SelectionOutcome.Selected,
    "reentrant quote stages article");
var quoteBlocked = false;
reentrantQuotePort.OnAdd = () => {
    try { _ = reentrantQuoteBatch.SnapshotLines(); }
    catch (InvalidOperationException) { quoteBlocked = true; }
};
Assert(reentrantQuoteBatch.Commit("reentrant-quote-001") == CheckoutBatchStatus.Committed &&
    quoteBlocked && reentrantQuoteBatch.SnapshotLines().Count == 0,
    "reentrant quote blocked during commit and cleared after posting");

// A lost acknowledgement must not reopen quote or permit implicit retry.
var uncertainQuotePort = new RecordingAtomicBatchPort();
var uncertainQuoteBatch = new CheckoutBatchController(new RecordingCatalogue(),
    new RecordingPrompt { Choice = 0 }, uncertainQuotePort);
uncertainQuoteBatch.StageImage(A("21", ""), 2);
var quoteRejectedInsideFault = false;
uncertainQuotePort.OnAdd = () => {
    try { _ = uncertainQuoteBatch.SnapshotLines(); }
    catch (InvalidOperationException) { quoteRejectedInsideFault = true; }
    throw new ApplicationException("acknowledgement lost after posting");
};
try { uncertainQuoteBatch.Commit("uncertain-quote-001"); throw new Exception("lost acknowledgement swallowed"); }
catch (ApplicationException) { }
var quoteRejectedAfterFault = false;
try { _ = uncertainQuoteBatch.SnapshotLines(); }
catch (InvalidOperationException) { quoteRejectedAfterFault = true; }
Assert(quoteRejectedInsideFault && quoteRejectedAfterFault &&
    uncertainQuoteBatch.State == CheckoutCommitState.OutcomeUnknown &&
    uncertainQuotePort.Calls.Count == 1 && uncertainQuoteBatch.PendingCount == 1,
    "lost acknowledgement blocks quote during commit and until durable reconciliation");
uncertainQuoteBatch.ReconcileUnknownOutcome("uncertain-quote-001", false);
Assert(uncertainQuoteBatch.State == CheckoutCommitState.Ready &&
    uncertainQuoteBatch.SnapshotLines().Single() == new CheckoutBatchLine("21", 2) &&
    uncertainQuotePort.Calls.Count == 1,
    "confirmed absent outcome restores trusted quote without automatic repost");

// Contract acceptance: a return is bounded by the durable original line,
// not by a cashier-supplied number or a second independent return engine.
var originalLine = new OriginalSaleLineReference("sale-100", "line-1");
var originalEvidence = new OriginalSaleReturnEvidence(originalLine, "21", 3, 2);
OriginalSaleReturnGuard.RequireAvailable(originalLine, originalEvidence, "21", 1);
var excessReturnDenied = false;
try { OriginalSaleReturnGuard.RequireAvailable(originalLine, originalEvidence, "21", 2); }
catch (InvalidOperationException) { excessReturnDenied = true; }
var mismatchedOriginalDenied = false;
try { OriginalSaleReturnGuard.RequireAvailable(new OriginalSaleLineReference("sale-101", "line-1"), originalEvidence, "21", 1); }
catch (InvalidOperationException) { mismatchedOriginalDenied = true; }
var missingEvidenceDenied = false;
try { OriginalSaleReturnGuard.RequireAvailable(originalLine, null, "21", 1); }
catch (InvalidOperationException) { missingEvidenceDenied = true; }
Assert(excessReturnDenied && mismatchedOriginalDenied && missingEvidenceDenied,
    "original-sale evidence fails closed on over-return, mismatch and missing data");

var trustedActor = new VerifiedStockActor("session-1", "actor-1");
var verifiedActorSource = new StubVerifiedStockActorSource { Actor = trustedActor };
var verifiedPermissions = new StubManualStockPermissionReader { Allowed = true };
Assert(ManualStockAuthorizationBoundary.RequireAuthorized(verifiedActorSource, verifiedPermissions) == trustedActor,
    "manual stock authorization accepts explicit verified actor and permission");
verifiedPermissions.Allowed = false;
var unauthorizedDenied = false;
try { ManualStockAuthorizationBoundary.RequireAuthorized(verifiedActorSource, verifiedPermissions); }
catch (UnauthorizedAccessException) { unauthorizedDenied = true; }
verifiedPermissions.Allowed = true;
verifiedActorSource.Actor = null;
var anonymousDenied = false;
try { ManualStockAuthorizationBoundary.RequireAuthorized(verifiedActorSource, verifiedPermissions); }
catch (UnauthorizedAccessException) { anonymousDenied = true; }
Assert(unauthorizedDenied && anonymousDenied && verifiedPermissions.Calls == 2,
    "manual stock authorization denies missing actor and explicit permission denial");

// A cashier logout/login during the durable permission read must not grant
// the previous actor's permission to the new session.
verifiedActorSource.Actor = trustedActor;
var changedSessionPermission = new StubManualStockPermissionReader {
    Allowed = true,
    OnRead = () => verifiedActorSource.Actor = new VerifiedStockActor("session-2", "actor-2")
};
var switchedSessionDenied = false;
try { ManualStockAuthorizationBoundary.RequireAuthorized(verifiedActorSource, changedSessionPermission); }
catch (UnauthorizedAccessException) { switchedSessionDenied = true; }
Assert(switchedSessionDenied && changedSessionPermission.Calls == 1,
    "manual stock authorization rejects session change during permission lookup");
verifiedActorSource.Actor = trustedActor;
// Session and actor identifiers are opaque tokens: case changes are NOT
// equivalent identities even when a permission backend uses case-insensitive SQL.
var caseChangedPermission = new StubManualStockPermissionReader {
    Allowed = true,
    OnRead = () => verifiedActorSource.Actor = new VerifiedStockActor("SESSION-1", "actor-1")
};
var caseChangedSessionDenied = false;
try { ManualStockAuthorizationBoundary.RequireAuthorized(verifiedActorSource, caseChangedPermission); }
catch (UnauthorizedAccessException) { caseChangedSessionDenied = true; }
Assert(caseChangedSessionDenied && caseChangedPermission.Calls == 1,
    "manual stock authorization rejects case-changed opaque session token");
verifiedActorSource.Actor = trustedActor;

var failingPermissionSource = new StubManualStockPermissionReader { ThrowOnRead = true };
verifiedActorSource.Actor = trustedActor;
var permissionBackendDenied = false;
try { ManualStockAuthorizationBoundary.RequireAuthorized(verifiedActorSource, failingPermissionSource); }
catch (UnauthorizedAccessException) { permissionBackendDenied = true; }
verifiedActorSource.ThrowOnRead = true;
var identityBackendDenied = false;
try { ManualStockAuthorizationBoundary.RequireAuthorized(verifiedActorSource, verifiedPermissions); }
catch (UnauthorizedAccessException) { identityBackendDenied = true; }
Assert(permissionBackendDenied && identityBackendDenied,
    "manual stock authorization fails closed on identity and permission backend exceptions");

sealed class StubVerifiedStockActorSource : IVerifiedStockActorSource
{
    public VerifiedStockActor? Actor { get; set; }
    public bool ThrowOnRead { get; set; }
    public VerifiedStockActor? CurrentVerifiedActor() => ThrowOnRead ? throw new InvalidOperationException("identity backend unavailable") : Actor;
}
sealed class StubManualStockPermissionReader : IManualStockPermissionReader
{
    public bool Allowed { get; set; }
    public bool ThrowOnRead { get; set; }
    public Action? OnRead { get; set; }
    public int Calls { get; private set; }
    public bool CanAdjustStock(VerifiedStockActor actor) { Calls++; OnRead?.Invoke(); if (ThrowOnRead) throw new InvalidOperationException("permission backend unavailable"); return Allowed; }
}

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
sealed class CandidateMutationPrompt : ICheckoutVariantPrompt
{
    public bool MutationRejected { get; private set; }
    public int Choose(IReadOnlyList<ArticleCandidate> candidates)
    {
        try
        {
            ((System.Collections.Generic.IList<ArticleCandidate>)candidates)[0] =
                new ArticleCandidate("forged", "123");
        }
        catch (NotSupportedException) { MutationRejected = true; }
        return 1;
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
    public Action? OnAdd { get; set; }
    public void AddBatch(IReadOnlyList<CheckoutBatchLine> lines, string operationId)
    {
        Calls.Add((lines.ToList(), operationId));
        OnAdd?.Invoke();
    }
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
sealed class DuplicatePhotoCatalogue : ICatalogueReader
{
    private static readonly ProductSummary Tile = new("photo-duplicate", "", "Same", "images/duplicate.png");
    public IReadOnlyList<ProductSummary> ListAll() => new[] { Tile, Tile };
    public IReadOnlyList<ProductSummary> FindBarcode(string barcode) => Array.Empty<ProductSummary>();
    public IReadOnlyList<ProductSummary> RefreshBarcode(string barcode) => Array.Empty<ProductSummary>();
    public IReadOnlyList<ProductSummary> RefreshArticle(string articleId) => new[] { Tile, Tile };
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
    public string DisplayName { get; set; } = "Image article";
    private ProductSummary Current => new("photo-1", "", DisplayName, ImagePath, VariantId);
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
        "null-display" => new[] { new ProductSummary("11", barcode, null!, null) },
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
    public AuthorizedCheckoutRequest? LastRequest { get; private set; }
    public Action? OnCommit { get; set; }
    public void Commit(AuthorizedCheckoutRequest request)
    {
        Calls++;
        LastRequest = request;
        OnCommit?.Invoke();
        if (ThrowOnCommit) throw new ApplicationException("acknowledgement lost");
    }
}

sealed class FailingFinancialJournal : ICheckoutOperationJournal
{
    public CheckoutOperationOutcome? Outcome { get; set; }
    public CheckoutOperationOutcome Lookup(string operationId) =>
        Outcome ?? throw new ApplicationException("durable journal unavailable");
}

sealed class ReentrantFinancialPort : IAuthorizedCheckoutPort
{
    public Action? OnCommit { get; set; }
    public int Calls { get; private set; }
    public void Commit(AuthorizedCheckoutRequest request)
    {
        Calls++;
        OnCommit?.Invoke();
    }
}
