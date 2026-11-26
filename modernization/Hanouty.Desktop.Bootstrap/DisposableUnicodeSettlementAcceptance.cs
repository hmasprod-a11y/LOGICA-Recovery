#if HANOUTY_FINANCIAL
using System.IO;
using System.Text.Json;
using Hanouty.Desktop.Wpf;
namespace Hanouty.Desktop.Bootstrap;
internal static partial class DisposableCashSaleAcceptance
{
    private static void VerifyUnicodeSettlementReplay(CatalogueSettings settings, string pin)
    {
        var request = new CustomerSettlementRequest("unicode-settlement-" + Guid.NewGuid().ToString("N"), "CREDIT-NEW", 0.01m, "ESPECES", "Été — acompte d'été");
        var writer = new CustomerSettlementWriter(settings.ConnectionString);
        Require(writer.Record(request, "O'Neil", pin), "Unicode customer settlement failed.");
        var persisted = Snapshot(settings);
        Require(writer.Record(request, "O'Neil", pin) && Snapshot(settings) == persisted,
            "Accented settlement notes broke durable replay or duplicated the payment.");
        Sql(settings, $"UPDATE TABLE_CLIENTS_REGLE SET NOTES='Modified' WHERE ID_REGLE='{request.OperationId}'");
        var altered = Snapshot(settings); var denied = false;
        try { writer.Record(request, "O'Neil", pin); } catch (InvalidOperationException) { denied = true; }
        Require(denied && Snapshot(settings) == altered, "A modified persisted settlement was incorrectly accepted as the original replay.");
        Sql(settings, $"UPDATE TABLE_CLIENTS_REGLE SET NOTES='Été — acompte d''été' WHERE ID_REGLE='{request.OperationId}'");
        File.WriteAllText(Path.Combine(EvidenceDirectory, "w2-unicode-settlement.json"), JsonSerializer.Serialize(new {
            ExactUnicodeReplay = true, NoDuplicatePayment = true, ModifiedPersistedNotesDenied = true
        }));
    }
}
#endif
