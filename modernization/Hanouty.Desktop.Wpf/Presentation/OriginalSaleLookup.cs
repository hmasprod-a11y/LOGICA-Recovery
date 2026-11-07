using System;
using System.Collections.Generic;
using System.Linq;

namespace Hanouty.Desktop.Wpf.Presentation;

// Read-only original-sale evidence from the production Host; never grants a refund.
public sealed record OriginalSaleCandidate(string SaleId, string ReceiptLabel, decimal PaidMad);
public interface IOriginalSaleLookup
{
    IReadOnlyList<OriginalSaleCandidate> FindPersistedSales(string receiptSearch);
}
public sealed class OriginalSaleSelection
{
    private readonly IOriginalSaleLookup _lookup;
    private IReadOnlyList<OriginalSaleCandidate>? _activeSnapshot;
    public OriginalSaleCandidate? Selected { get; private set; }
    public OriginalSaleSelection(IOriginalSaleLookup lookup) =>
        _lookup = lookup ?? throw new ArgumentNullException(nameof(lookup));
    public IReadOnlyList<OriginalSaleCandidate> Search(string receiptSearch)
    {
        Selected = null;
        _activeSnapshot = null;
        if (string.IsNullOrWhiteSpace(receiptSearch)) return Array.Empty<OriginalSaleCandidate>();
        var result = _lookup.FindPersistedSales(receiptSearch.Trim()) ??
            throw new InvalidOperationException("Original-sale lookup unavailable.");
        if (result.Any(s => s is null || string.IsNullOrWhiteSpace(s.SaleId) ||
            string.IsNullOrWhiteSpace(s.ReceiptLabel) || s.PaidMad < 0m) ||
            result.GroupBy(s => s.SaleId, StringComparer.Ordinal).Any(g => g.Count() > 1))
            throw new InvalidOperationException("Invalid or duplicate persisted sale identity.");
        _activeSnapshot = result.ToArray();
        return _activeSnapshot;
    }
    public bool Select(OriginalSaleCandidate candidate, IReadOnlyList<OriginalSaleCandidate> current)
    {
        Selected = null;
        if (candidate is null || current is null || !ReferenceEquals(current, _activeSnapshot) ||
            !current.Any(x => ReferenceEquals(x, candidate))) return false;
        Selected = candidate;
        return true;
    }
    public void Clear()
    {
        Selected = null;
        _activeSnapshot = null;
    }
}
