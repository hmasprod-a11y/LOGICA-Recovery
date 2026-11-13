using Hanouty.Inventory.Validation;

var now = new DateTimeOffset(2026, 11, 13, 7, 0, 0, TimeSpan.Zero);
var validShape = new InventoryValidationRequest("INV-TEST-001", new[] { "ART-A", "ART-B" });
int rejected = 0;
void ExpectDenied(string label, InventoryValidationRequest request)
{
    try
    {
        InventoryValidationBoundary.DemandVerifiedGrant(request, null, now);
        throw new Exception("FAIL: " + label + " passed without a verified capability.");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("PASS: " + label + " denied");
        rejected++;
    }
}
void ExpectInvalid(string label, InventoryValidationRequest request)
{
    try
    {
        InventoryValidationBoundary.DemandVerifiedGrant(request, null, now);
        throw new Exception("FAIL: " + label + " accepted.");
    }
    catch (InvalidOperationException)
    {
        Console.WriteLine("PASS: " + label + " rejected");
        rejected++;
    }
}
ExpectDenied("valid physical count without mapped grant", validShape);
ExpectInvalid("missing inventory identity", new InventoryValidationRequest("", new[] { "ART-A" }));
ExpectInvalid("no counted lines", new InventoryValidationRequest("INV-TEST-001", Array.Empty<string>()));
ExpectInvalid("duplicate exact article ID", new InventoryValidationRequest("INV-TEST-001", new[] { "ART-A", "ART-A" }));
ExpectInvalid("blank article ID", new InventoryValidationRequest("INV-TEST-001", new[] { "ART-A", " " }));
ExpectDenied("case-sensitive distinct identities still require grant",
    new InventoryValidationRequest("INV-TEST-001", new[] { "ART-A", "art-a" }));
if (rejected != 6) throw new Exception("Missing denial assertions.");
Console.WriteLine("PASS: six fail-closed boundary cases; no database opened or modified.");

// UI rows can be edited between preview and write. The request must retain an immutable
// identity snapshot; a caller's List<T> must not be able to replace validated identities.
var mutableUiArticleIds = new List<string> { "ART-A", "ART-B" };
var snapshottedRequest = new InventoryValidationRequest("INV-TEST-SNAPSHOT", mutableUiArticleIds);
mutableUiArticleIds[0] = "ART-INJECTED";
mutableUiArticleIds.Add("ART-EXTRA");
if (snapshottedRequest.ArticleIds.Count != 2 ||
    snapshottedRequest.ArticleIds[0] != "ART-A" ||
    snapshottedRequest.ArticleIds[1] != "ART-B")
    throw new Exception("FAIL: inventory identity request changed after caller mutated UI list.");
if (snapshottedRequest.ArticleIds is IList<string> writable)
{
    try
    {
        writable[0] = "ART-INJECTED";
        throw new Exception("FAIL: inventory request exposes a writable identity list.");
    }
    catch (NotSupportedException)
    {
        Console.WriteLine("PASS: immutable article identity snapshot denies UI mutation.");
    }
}
ExpectDenied("immutable snapshot still requires verified grant", snapshottedRequest);



var baseline = new[] {
    new LOGICA.ApplicationLayer.Inventory.StockBaselineLine("ART-A", 8m),
    new LOGICA.ApplicationLayer.Inventory.StockBaselineLine("ART-B", 4m)
};
var counted = new[] {
    new LOGICA.ApplicationLayer.Inventory.StockCountLine("ART-A", 8m, 6m),
    new LOGICA.ApplicationLayer.Inventory.StockCountLine("ART-B", 4m, 4m)
};
var plan = InventoryValidationPreparation.RequireCompleteFreshCount(baseline, counted, baseline);
if (plan.Adjustments.Count != 1 || plan.Adjustments[0].ArticleId != "ART-A" ||
    plan.Adjustments[0].Delta != -2m)
    throw new Exception("Complete fresh inventory plan mismatch.");
Console.WriteLine("PASS: complete fresh count proposes only changed article.");

int refusedPlans = 0;
void ExpectPlanRefused(string label,
    LOGICA.ApplicationLayer.Inventory.StockBaselineLine[] initial,
    LOGICA.ApplicationLayer.Inventory.StockCountLine[] physical,
    LOGICA.ApplicationLayer.Inventory.StockBaselineLine[] current)
{
    try
    {
        InventoryValidationPreparation.RequireCompleteFreshCount(initial, physical, current);
        throw new Exception("FAIL: " + label + " accepted.");
    }
    catch (InvalidOperationException)
    {
        refusedPlans++;
        Console.WriteLine("PASS: " + label + " refused");
    }
}
ExpectPlanRefused("missing count", baseline, new[] { counted[0] }, baseline);
ExpectPlanRefused("unknown count", baseline, new[] { counted[0], counted[1],
    new LOGICA.ApplicationLayer.Inventory.StockCountLine("ART-X", 0m, 1m) }, baseline);
ExpectPlanRefused("stale zero-delta article", baseline, counted, new[] {
    baseline[0], new LOGICA.ApplicationLayer.Inventory.StockBaselineLine("ART-B", 5m) });
ExpectPlanRefused("added article after count", baseline, counted, new[] {
    baseline[0], baseline[1], new LOGICA.ApplicationLayer.Inventory.StockBaselineLine("ART-C", 0m) });
ExpectPlanRefused("removed article after count", baseline, counted, new[] { baseline[0] });
if (refusedPlans != 5) throw new Exception("Missing inventory preparation refusal assertions.");
Console.WriteLine("PASS: read-only coverage/freshness checks; no database opened or modified.");


int malformedRejected = 0;
void ExpectMalformedRefused<TException>(string label,
    LOGICA.ApplicationLayer.Inventory.StockBaselineLine[] initial,
    LOGICA.ApplicationLayer.Inventory.StockCountLine[] physical,
    LOGICA.ApplicationLayer.Inventory.StockBaselineLine[] current) where TException : Exception
{
    try
    {
        InventoryValidationPreparation.RequireCompleteFreshCount(initial, physical, current);
        throw new Exception("FAIL: " + label + " accepted.");
    }
    catch (TException)
    {
        malformedRejected++;
        Console.WriteLine("PASS: " + label + " rejected");
    }
}
ExpectMalformedRefused<InvalidOperationException>("duplicate baseline article",
    new[] { baseline[0], baseline[0], baseline[1] }, counted, baseline);
ExpectMalformedRefused<InvalidOperationException>("duplicate physical count article",
    baseline, new[] { counted[0], counted[0], counted[1] }, baseline);
ExpectMalformedRefused<InvalidOperationException>("duplicate current article after count",
    baseline, counted, new[] { baseline[0], baseline[1], baseline[1] });
ExpectMalformedRefused<ArgumentOutOfRangeException>("negative physical count",
    baseline, new[] {
        new LOGICA.ApplicationLayer.Inventory.StockCountLine("ART-A", 8m, -1m),
        counted[1]
    }, baseline);
ExpectMalformedRefused<ArgumentException>("blank article identity in baseline",
    new[] {
        new LOGICA.ApplicationLayer.Inventory.StockBaselineLine(" ", 8m),
        baseline[1]
    }, counted, baseline);
if (malformedRejected != 5) throw new Exception("Missing malformed inventory refusal assertions.");
Console.WriteLine("PASS: five additional malformed count/identity cases; no database opened or modified.");

 
// Fail closed before even enumerating untrusted or stale UI-provided data.
// The authorization check must be the first operation at the write boundary.
IEnumerable<LOGICA.ApplicationLayer.Inventory.StockBaselineLine> ExplodingBaseline()
{
    throw new Exception("FAIL: baseline enumerated before authorization.");
#pragma warning disable CS0162
    yield break;
#pragma warning restore CS0162
}
IEnumerable<LOGICA.ApplicationLayer.Inventory.StockCountLine> ExplodingCount()
{
    throw new Exception("FAIL: physical count enumerated before authorization.");
#pragma warning disable CS0162
    yield break;
#pragma warning restore CS0162
}
try
{
    InventoryValidationReadiness.RequireAuthorizedCompleteFreshCount(
        validShape, null, now, ExplodingBaseline(), ExplodingCount(), ExplodingBaseline());
    throw new Exception("FAIL: readiness accepted an unmapped capability.");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("PASS: readiness denied before baseline/count enumeration.");
}

 
// A validated request's immutable article identities must match the later count
// snapshot exactly, even when the physical count's own coverage is otherwise valid.
InventoryValidationReadiness.EnsureCountIdentitiesMatchRequest(validShape, counted);
InventoryValidationReadiness.EnsureCountIdentitiesMatchRequest(validShape,
    new[] { counted[1], counted[0] }); // order is not an identity
int mismatches = 0;
void ExpectIdentityMismatch(string label, LOGICA.ApplicationLayer.Inventory.StockCountLine[] lines)
{
    try
    {
        InventoryValidationReadiness.EnsureCountIdentitiesMatchRequest(validShape, lines);
        throw new Exception("FAIL: " + label + " accepted.");
    }
    catch (InvalidOperationException)
    {
        mismatches++;
        Console.WriteLine("PASS: " + label + " refused");
    }
}
ExpectIdentityMismatch("count replaced after request", new[] {
    counted[0], new LOGICA.ApplicationLayer.Inventory.StockCountLine("ART-X", 4m, 4m) });
ExpectIdentityMismatch("count shortened after request", new[] { counted[0] });
ExpectIdentityMismatch("duplicate count identity", new[] { counted[0], counted[0] });
if (mismatches != 3) throw new Exception("Missing count identity snapshot tests.");
Console.WriteLine("PASS: request/count identity consistency, no database opened.");


// A future MariaDB writer must not even open its connection without a verified
// actor/session/capability. The delegate stands in for a connection factory.
int connectionOpens = 0;
try
{
    InventoryValidationWriteGate.ExecuteAfterAuthorization(validShape, null, now, () =>
    {
        connectionOpens++;
        throw new Exception("FAIL: unauthorized inventory transaction connection opened.");
    });
    throw new Exception("FAIL: unauthorized inventory writer accepted.");
}
catch (UnauthorizedAccessException)
{
    if (connectionOpens != 0)
        throw new Exception("FAIL: authorization checked after connection open.");
    Console.WriteLine("PASS: missing grant denies before transaction connection factory.");
}
// An invalid inventory request is also rejected before any connection opens.
try
{
    InventoryValidationWriteGate.ExecuteAfterAuthorization(
        new InventoryValidationRequest(" ", new[] { "ART-A" }), null, now, () =>
        {
            connectionOpens++;
            return 0;
        });
    throw new Exception("FAIL: invalid inventory identity accepted by write gate.");
}
catch (InvalidOperationException)
{
    if (connectionOpens != 0)
        throw new Exception("FAIL: invalid request opened transaction connection.");
    Console.WriteLine("PASS: invalid inventory identity denies before transaction connection.");
}
