using System;
using LOGICA.Application.Inventory;

internal static class StockAdjustmentPlanSmoke
{
    static void Check(bool ok, string message)
    {
        if (!ok) throw new Exception(message);
    }

    static void Reject(Action action)
    {
        try { action(); }
        catch (ArgumentException) { return; }
        throw new Exception("Expected invalid stock adjustment to fail closed.");
    }

    static int Main()
    {
        var increase = StockAdjustmentPlan.Create(" ART-1 ", 2.500m, 7.250m,
            " Inventaire ", " cashier-1 ");
        Check(increase.ArticleId == "ART-1", "Article identity");
        Check(increase.BeforeStock == 2.500m && increase.AfterStock == 7.250m,
            "Exact decimal before/after");
        Check(increase.Delta == 4.750m, "Positive delta");
        Check(increase.Reason == "Inventaire" && increase.UserId == "cashier-1",
            "Audit metadata");
        var decrease = StockAdjustmentPlan.Create("ART-1", 7.250m, 0m,
            "Breakage", "manager");
        Check(decrease.Delta == -7.250m, "Negative delta");
        Reject(() => StockAdjustmentPlan.Create("", 1m, 2m, "Count", "user"));
        Reject(() => StockAdjustmentPlan.Create("A", 1m, 2m, " ", "user"));
        Reject(() => StockAdjustmentPlan.Create("A", 1m, 2m, "Count", null));
        Reject(() => StockAdjustmentPlan.Create("A", 1m, 1m, "Count", "user"));
        Reject(() => StockAdjustmentPlan.Create("A", -1m, 2m, "Count", "user"));
        Reject(() => StockAdjustmentPlan.Create("A", 1m, -2m, "Count", "user"));
        Console.WriteLine("PASS stock adjustment plan invariants");
        return 0;
    }
}
