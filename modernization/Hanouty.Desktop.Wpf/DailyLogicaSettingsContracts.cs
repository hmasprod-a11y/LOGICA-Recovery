namespace Hanouty.Desktop.Wpf;

public sealed record DailyLogicaSettingsValues(string Template, string Connection, bool ShowPayment, bool ShowTicketNumber,
    bool ShowQr, string Footer, bool PaymentWindow);
public sealed record DailyLogicaSettingsSnapshot(DailyLogicaSettingsValues Values, string Revision, int MaximumValueLength);
public sealed record DailyLogicaSettingsChange(DailyLogicaSettingsSnapshot Expected, DailyLogicaSettingsValues Desired);
public sealed class DailyLogicaSettingsRefusedException(string message, Exception? inner = null) : InvalidOperationException(message, inner);
public interface IDailyLogicaSettingsWorkflow
{
    DailyLogicaSettingsChange? Pending { get; }
    DailyLogicaSettingsSnapshot Reload();
    DailyLogicaSettingsSnapshot Save(DailyLogicaSettingsSnapshot expected, DailyLogicaSettingsValues desired);
}
