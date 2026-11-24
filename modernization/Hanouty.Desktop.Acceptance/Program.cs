using System.IO;
using Hanouty.Desktop.Bootstrap;

namespace Hanouty.Desktop.Acceptance;

public static class Program
{
    [STAThread]
    public static int Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.Error.WriteLine("Usage: Hanouty.Desktop.Acceptance <evidence-output.json>");
            return 1;
        }
        return DisposableCashSaleAcceptance.Run(Path.GetFullPath(args[0]));
    }
}
