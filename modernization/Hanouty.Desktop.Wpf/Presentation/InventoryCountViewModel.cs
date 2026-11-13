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
    public ObservableCollection<InventoryCountLine> Lines { get; } = new();
    public InventoryCountViewModel(IInventoryCountWorkflow? workflow = null) => _workflow = workflow;
    public string DocumentId { get => _documentId; set { _documentId = value ?? ""; Changed(); Changed(nameof(CanOpen)); } }
    public string ArticleId { get => _articleId; set { _articleId = value ?? ""; Changed(); } }
    public string PhysicalText { get => _physicalText; set { _physicalText = value ?? ""; Changed(); } }
    public string Status { get => _status; private set { _status = value; Changed(); } }
    public bool CanOpen => _workflow is not null && !_busy && !string.IsNullOrWhiteSpace(DocumentId);
    public bool CanRecord => _workflow is not null && _loaded && !_busy;
    public bool CanConfirm => _workflow is not null && _loaded && !_busy &&
        Lines.Count > 0 && Lines.All(x => x.PhysicalQuantity is >= 0m);
    public void Open()
    {
        if (!CanOpen) return;
        Execute(() => Apply(_workflow!.Open(DocumentId.Trim())));
    }
    public void Record()
    {
        if (!CanRecord || !Lines.Any(x => x.ArticleId == ArticleId) ||
            !decimal.TryParse(PhysicalText, System.Globalization.NumberStyles.AllowDecimalPoint,
                System.Globalization.CultureInfo.InvariantCulture, out var quantity) ||
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
        Execute(() =>
        {
            if (!_workflow!.Confirm(DocumentId)) throw new InvalidOperationException("Inventory refused confirmation");
            Lines.Clear();
            _loaded = false;
            Status = "Document confirmé par Inventory";
        });
    }
    private void Apply(InventoryCountDocument document)
    {
        if (document is null || document.DocumentId != DocumentId ||
            document.Lines is null || document.Lines.Any(x => string.IsNullOrWhiteSpace(x.ArticleId) ||
                x.ExpectedQuantity < 0m || x.PhysicalQuantity < 0m))
            throw new InvalidOperationException("Invalid Inventory document");
        Lines.Clear();
        foreach (var line in document.Lines) Lines.Add(line);
        _loaded = true;
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
            _loaded = false;
            Status = "Opération refusée — vérifier le document dans Inventory";
        }
        finally { _busy = false; NotifyActions(); }
    }
    private void NotifyActions() { Changed(nameof(CanOpen)); Changed(nameof(CanRecord)); Changed(nameof(CanConfirm)); }
    public event PropertyChangedEventHandler? PropertyChanged;
    private void Changed([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
