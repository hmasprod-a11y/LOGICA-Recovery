using System.IO;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
namespace Hanouty.Desktop.Bootstrap;
internal static class WorkstationPrinterProfile
{
    internal static string ProfileDirectory(CatalogueSettings settings, string register)
    {
        var cs = new MySqlConnectionStringBuilder(settings.ConnectionString);
        var identity = $"{cs.Server.ToLowerInvariant()}\n{cs.Port}\n{cs.Database}\n{register}";
        var key = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(identity)));
        return Path.Combine(Path.GetDirectoryName(WorkstationConfiguration.DefaultPath)!, "printer-profiles", key);
    }
    internal static string DirectoryFor(CatalogueSettings settings, string register)
    {
        var profile = ProfileDirectory(settings, register);
        return File.Exists(Path.Combine(profile, "PRINTER_CL.sni")) ? profile
            : File.Exists(Path.Combine(settings.DataDirectory, "PRINTER_CL.sni")) ? settings.DataDirectory : AppContext.BaseDirectory;
    }
    internal static string FeatureDirectory(CatalogueSettings settings) =>
        File.Exists(Path.Combine(settings.DataDirectory, "gestion_credit.sni")) ? settings.DataDirectory : AppContext.BaseDirectory;
}
