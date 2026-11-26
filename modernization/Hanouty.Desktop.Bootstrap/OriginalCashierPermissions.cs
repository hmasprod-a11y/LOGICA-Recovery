using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;
internal static class OriginalCashierPermissions
{
    // Form_3_VENTE.CREATION_ACCES maps VISIBLE directly to the action and
    // ACCES MANAGER/ADMIN to an explicit role approval, not a cashier PIN.
    internal static bool Authorize(Func<MySqlConnection> connections, string actor, string action, Func<string,string> approval)
    {
        if (action is not ("MODIF_QTE" or "ANNULATION")) throw new ArgumentException("Action de caisse inconnue.");
        string permission;
        using (var db=connections())
        {
            db.Open(); using var command=new MySqlCommand($"SELECT {action},Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor",db);
            command.Parameters.AddWithValue("@actor",actor);using var rows=command.ExecuteReader();
            if(!rows.Read()||rows.IsDBNull(0)||rows.IsDBNull(1)||rows.GetString(1) is not ("ADMIN" or "MANAGER" or "UTILISATEUR"))return false;
            permission=rows.GetString(0);if(rows.Read())return false;
        }
        if(permission=="VISIBLE")return true;
        var role=permission=="ACCES MANAGER"?"MANAGER":permission=="ACCES ADMIN"?"ADMIN":null;
        if(role is null)return false;
        var pin=approval(role);if(string.IsNullOrWhiteSpace(pin))return false;
        try
        {
            using var db=connections();db.Open();
            using var command=new MySqlCommand($"SELECT COUNT(*) FROM TABLE_PASS WHERE BINARY Catégorie=BINARY @role AND BINARY ListPass=BINARY @pin AND EXISTS (SELECT 1 FROM TABLE_PASS actor WHERE BINARY actor.ListUser=BINARY @actor AND BINARY actor.{action}=BINARY @permission)",db);
            command.Parameters.AddWithValue("@role",role);command.Parameters.AddWithValue("@pin",pin);command.Parameters.AddWithValue("@actor",actor);command.Parameters.AddWithValue("@permission",permission);
            return Convert.ToInt32(command.ExecuteScalar())==1;
        }finally{pin="";}
    }
}
