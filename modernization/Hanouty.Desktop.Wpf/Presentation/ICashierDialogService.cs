using System;
using System.Collections.Generic;
using System.Windows;

namespace Hanouty.Desktop.Wpf.Presentation;

public interface ICashierDialogService
{
    void ShowCustomerCreditStatement(
        Func<string?, DateTime, DateTime, IReadOnlyList<CustomerCreditStatementRow>> readStatement,
        IReadOnlyList<string>? paymentModes,
        Func<CustomerSettlementRequest, bool>? submitSettlement);

    void ShowInventoryCount(IInventoryCountWorkflow workflow);

    void ShowCashDrawerCount(
        Func<decimal, bool, bool>? closeCashDrawer,
        Func<decimal, bool>? setOpeningCash);
}

internal sealed class WpfCashierDialogService(Window owner) : ICashierDialogService
{
    public void ShowCustomerCreditStatement(
        Func<string?, DateTime, DateTime, IReadOnlyList<CustomerCreditStatementRow>> readStatement,
        IReadOnlyList<string>? paymentModes,
        Func<CustomerSettlementRequest, bool>? submitSettlement) =>
        new CustomerCreditStatementDialog(readStatement, paymentModes, submitSettlement) { Owner = owner }.ShowDialog();

    public void ShowInventoryCount(IInventoryCountWorkflow workflow) =>
        new InventoryCountWindow(workflow) { Owner = owner }.ShowDialog();

    public void ShowCashDrawerCount(
        Func<decimal, bool, bool>? closeCashDrawer,
        Func<decimal, bool>? setOpeningCash) =>
        new CashDrawerCountDialog(closeCashDrawer, setOpeningCash) { Owner = owner }.ShowDialog();
}
