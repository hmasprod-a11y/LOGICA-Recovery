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

Console.WriteLine("Production selection-to-checkout workflow regression suite passed.");

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
