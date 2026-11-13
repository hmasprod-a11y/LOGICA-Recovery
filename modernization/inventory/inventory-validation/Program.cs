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
