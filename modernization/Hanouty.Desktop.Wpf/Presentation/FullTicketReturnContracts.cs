using Hanouty.ArchitectureBridge;
namespace Hanouty.Desktop.Wpf.Presentation;
public interface ITrustedWpfFullTicketReturnPreparation
{
    AuthorizedCheckoutRequest PrepareFullTicketReturn(string operationId, string originalId, CashierPaymentContext context);
}
public interface IContextualWpfFullTicketReturnSubmission : ICheckoutOutcomeReconciliation
{
    CheckoutSubmissionResult SubmitFullTicketReturn(string operationId, string originalId, CashierPaymentContext context);
}
