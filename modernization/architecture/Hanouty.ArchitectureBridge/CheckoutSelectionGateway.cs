using System;
using System.Collections.Generic;
using System.Data;
using LOGICA.ApplicationLayer.Checkout;

namespace Hanouty.ArchitectureBridge;

// Public .NET 10 entry point over the EXACT recovered production checkout selection
// sources compiled by CoreSources.props. No SQL, WPF, or duplicate selection rules.
public enum SelectionOutcome { Selected, Missing, Cancelled, Ambiguous, InvalidCandidates }
public sealed record ArticleCandidate(string ArticleId, string Barcode);
public sealed record SelectionResponse(SelectionOutcome Outcome, ArticleCandidate? Article);

public static class CheckoutSelectionGateway
{
    public static SelectionResponse ResolveBarcode(
        IReadOnlyList<ArticleCandidate> displayed,
        Func<IReadOnlyList<ArticleCandidate>, int>? chooseVariant,
        Func<IReadOnlyList<ArticleCandidate>> refresh)
    {
        ArgumentNullException.ThrowIfNull(displayed);
        ArgumentNullException.ThrowIfNull(refresh);
        var displayedTable = ToTable(displayed);
        var result = CheckoutSelectionFlowService.ChooseBarcodeWithRefresh(
            displayedTable,
            snapshots =>
            {
                if (chooseVariant == null)
                    throw new InvalidOperationException("Duplicate barcode requires explicit choice.");
                var choices = new List<ArticleCandidate>(snapshots.Count);
                foreach (var s in snapshots)
                    choices.Add(new ArticleCandidate(s.ArticleId, s.Code));
                return chooseVariant(choices.AsReadOnly());
            },
            () => ToTable(refresh()));
        return Map(result);
    }

    public static SelectionResponse ResolveImage(
        ArticleCandidate displayedTile,
        Func<IReadOnlyList<ArticleCandidate>> refreshByArticleId)
    {
        ArgumentNullException.ThrowIfNull(displayedTile);
        ArgumentNullException.ThrowIfNull(refreshByArticleId);
        var tile = new CheckoutArticleTileReference(displayedTile.Barcode, displayedTile.ArticleId);
        return Map(CheckoutSelectionFlowService.ChooseImageWithRefresh(
            tile, () => ToTable(refreshByArticleId())));
    }

    private static DataTable ToTable(IReadOnlyList<ArticleCandidate> articles)
    {
        ArgumentNullException.ThrowIfNull(articles);
        var table = new DataTable();
        table.Columns.Add("ID_ARTICLE", typeof(string));
        table.Columns.Add("Code", typeof(string));
        foreach (var a in articles)
        {
            if (a == null) throw new ArgumentException("Null candidate", nameof(articles));
            table.Rows.Add(a.ArticleId ?? (object)DBNull.Value, a.Barcode ?? (object)DBNull.Value);
        }
        return table;
    }

    private static SelectionResponse Map(CheckoutVariantChoiceResult result)
    {
        var status = result.Status switch
        {
            CheckoutVariantChoiceStatus.Selected => SelectionOutcome.Selected,
            CheckoutVariantChoiceStatus.Missing => SelectionOutcome.Missing,
            CheckoutVariantChoiceStatus.Cancelled => SelectionOutcome.Cancelled,
            CheckoutVariantChoiceStatus.Ambiguous => SelectionOutcome.Ambiguous,
            _ => SelectionOutcome.InvalidCandidates
        };
        if (status != SelectionOutcome.Selected || result.SelectedRow == null)
            return new SelectionResponse(status, null);
        return new SelectionResponse(status, new ArticleCandidate(
            Convert.ToString(result.SelectedRow["ID_ARTICLE"])!,
            Convert.ToString(result.SelectedRow["Code"])!));
    }
}
