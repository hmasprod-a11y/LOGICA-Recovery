using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Hanouty.Desktop.Wpf.Presentation;

// UI projection only. Inventory owns the real document, authorization and stock writer.
public sealed record InventoryCountLine(string ArticleId, string ArticleName,
    decimal ExpectedQuantity, decimal? PhysicalQuantity)
{
    public decimal? Difference => PhysicalQuantity - ExpectedQuantity;
}
public sealed record InventoryCountDocument(string DocumentId, IReadOnlyList<InventoryCountLine> Lines);
public interface IInventoryCountWorkflow
{
    InventoryCountDocument Open(string documentId);
    InventoryCountDocument RecordPhysicalQuantity(string documentId, string articleId, decimal physicalQuantity);
    bool Confirm(string documentId);
}
public sealed class InventoryCountViewModel : INotifyPropertyChanged
{
    private readonly IInventoryCountWorkflow? _workflow;
    private string _documentId = "";
    private string _articleId = "";
    private string _physicalText = "";
    private string _status = "Contrat Inventory non raccordé — validation indisponible";
    private bool _busy;
    private bool _loaded;
    private string? _openedDocumentId;
    public ObservableCollection<InventoryCountLine> Lines { get; } = new();
    public InventoryCountViewModel(IInventoryCountWorkflow? workflow = null) => _workflow = workflow;
    public string DocumentId { get => _documentId; set { if (_documentId == (value ?? "")) return; _documentId = value ?? ""; InvalidateDocument(); Changed(); Changed(nameof(CanOpen)); } }
    public string ArticleId { get => _articleId; set { _articleId = value ?? ""; Changed(); } }
    public string PhysicalText { get => _physicalText; set { _physicalText = value ?? ""; Changed(); } }
    public string Status { get => _status; private set { _status = value; Changed(); } }
    // Read-only progress is derived exclusively from the Inventory document snapshot.
    // Never infer missing physical counts as zero stock.
    public int CountedLines => Lines.Count(x => x.PhysicalQuantity.HasValue);
    public int RemainingLines => Lines.Count - CountedLines;
    public int DifferenceLines => Lines.Count(x => x.Difference is { } difference && difference != 0m);
    public string CountProgress => $"{CountedLines}/{Lines.Count} articles comptés — {RemainingLines} restants — {DifferenceLines} écarts";
    private void NotifyCountProgress()
    {
        Changed(nameof(CountedLines));
        Changed(nameof(RemainingLines));
        Changed(nameof(DifferenceLines));
        Changed(nameof(CountProgress));
    }
    public bool CanOpen => _workflow is not null && !_busy && !string.IsNullOrWhiteSpace(DocumentId);
    public bool CanRecord => _workflow is not null && _loaded && !_busy && _openedDocumentId == DocumentId;
    public bool CanConfirm => _workflow is not null && _loaded && !_busy && _openedDocumentId == DocumentId &&
        Lines.Count > 0 && Lines.All(x => x.PhysicalQuantity is >= 0m);
    public void Open()
    {
        if (!CanOpen) return;
        Execute(() => Apply(_workflow!.Open(DocumentId)));
    }
    public void Record()
    {
        if (!CanRecord || !Lines.Any(x => x.ArticleId == ArticleId) ||
            !TryParsePhysicalQuantity(PhysicalText, out var quantity) ||
            quantity < 0m)
        {
            Status = "Article ou quantité physique invalide";
            return;
        }
        Execute(() => Apply(_workflow!.RecordPhysicalQuantity(DocumentId, ArticleId, quantity)));
    }
    public void Confirm()
    {
        if (!CanConfirm) return;
        // Freeze the reviewed identity before invoking an external Inventory port.
        // A reentrant UI callback must not redirect confirmation to another document.
        var reviewedDocumentId = _openedDocumentId;
        Execute(() =>
        {
            if (reviewedDocumentId is null || reviewedDocumentId != DocumentId)
                throw new InvalidOperationException("Inventory document changed before confirmation");
            if (!_workflow!.Confirm(reviewedDocumentId)) throw new InvalidOperationException("Inventory refused confirmation");
            if (reviewedDocumentId != DocumentId)
                throw new InvalidOperationException("Inventory document changed during confirmation");
            Lines.Clear();
            NotifyCountProgress();
            _loaded = false;
            _openedDocumentId = null;
            Status = "Document confirmé par Inventory";
        });
    }
    // Physical stock is a quantity, never a monetary value: no thousands grouping,
    // signs, exponents or currency symbols. Accept decimal comma and decimal dot
    // regardless of the workstation locale, without silently changing magnitude.
    private static bool TryParsePhysicalQuantity(string input, out decimal quantity)
    {
        quantity = 0m;
        var value = input.Trim();
        if (value.Length == 0 || value.Any(c => c is not (>= '0' and <= '9') and not '.' and not ','))
            return false;
        if (value.Count(c => c == '.' || c == ',') > 1)
            return false;
        return decimal.TryParse(value.Replace(',', '.'),
            System.Globalization.NumberStyles.AllowDecimalPoint,
            System.Globalization.CultureInfo.InvariantCulture, out quantity);
    }
    private void Apply(InventoryCountDocument document)
    {
        if (document is null || document.DocumentId != DocumentId ||
            document.Lines is null || document.Lines.Any(x => string.IsNullOrWhiteSpace(x.ArticleId) ||
                x.ExpectedQuantity < 0m || x.PhysicalQuantity < 0m) ||
            document.Lines.Select(x => x.ArticleId).Distinct(StringComparer.Ordinal).Count() != document.Lines.Count)
            throw new InvalidOperationException("Invalid Inventory document");
        Lines.Clear();
        foreach (var line in document.Lines) Lines.Add(line);
        NotifyCountProgress();
        _loaded = true;
        _openedDocumentId = document.DocumentId;
        NotifyActions();
        Status = "Document Inventory chargé — écarts affichés";
    }
    private void Execute(Action action)
    {
        _busy = true;
        NotifyActions();
        try { action(); }
        catch (Exception ex) when (ex is not OutOfMemoryException and not StackOverflowException)
        {
            Lines.Clear();
            NotifyCountProgress();
            _loaded = false;
            _openedDocumentId = null;
            // A failed Inventory call invalidates the entire local snapshot.
            // Do not keep an old article/quantity ready for a second document.
            _articleId = "";
            _physicalText = "";
            Changed(nameof(ArticleId));
            Changed(nameof(PhysicalText));
            Status = "Opération refusée — vérifier le document dans Inventory";
        }
        finally { _busy = false; NotifyActions(); }
    }
    private void InvalidateDocument()
    {
        // The physical-count editor belongs to the opened document. Never carry
        // a previous article/quantity into a different document identity.
        _articleId = "";
        _physicalText = "";
        Changed(nameof(ArticleId));
        Changed(nameof(PhysicalText));
        Lines.Clear();
        NotifyCountProgress();
        _loaded = false;
        _openedDocumentId = null;
        Status = "Document modifié — ouvrir le nouveau document avant comptage";
        NotifyActions();
    }
    private void NotifyActions() { Changed(nameof(CanOpen)); Changed(nameof(CanRecord)); Changed(nameof(CanConfirm)); }
    public event PropertyChangedEventHandler? PropertyChanged;
    private void Changed([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
