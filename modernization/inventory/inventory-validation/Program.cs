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
