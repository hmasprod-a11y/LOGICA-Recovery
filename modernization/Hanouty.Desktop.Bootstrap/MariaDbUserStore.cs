using System;
using System.Collections.Generic;
using System.Data;
using Hanouty.ArchitectureBridge;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class MariaDbUserStore(string connectionString)
{
    public IReadOnlyList<HanoutyUserRecord> ListUsers()
    {
        var result = new List<HanoutyUserRecord>();
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var cmd = new MySqlCommand(
            "SELECT ID, COALESCE(ListUser,''), COALESCE(`Catégorie`,'UTILISATEUR'), COALESCE(ListPass,'') " +
            "FROM TABLE_PASS ORDER BY `Catégorie` ASC, ListUser ASC", conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            result.Add(new HanoutyUserRecord(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3)));
        }
        return result;
    }

    public int CreateUser(string username, string pin, HanoutyRole role)
    {
        var roleName = UserRoleMatrix.ToLogicaRoleName(role);
        UserRoleMatrix.ValidateNewUser(username, pin, roleName);
        var cleanUser = username.Trim();
        var cleanPin = pin.Trim();

        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var tx = conn.BeginTransaction(IsolationLevel.Serializable);
        using (var dup = new MySqlCommand(
            "SELECT COUNT(*) FROM TABLE_PASS WHERE BINARY ListUser = BINARY @user OR BINARY ListPass = BINARY @pin", conn, tx))
        {
            dup.Parameters.AddWithValue("@user", cleanUser);
            dup.Parameters.AddWithValue("@pin", cleanPin);
            if (Convert.ToInt32(dup.ExecuteScalar()) > 0)
                throw new InvalidOperationException("Un utilisateur ou un code PIN identique existe déjà.");
        }

        using (var insert = new MySqlCommand(
            "INSERT INTO TABLE_PASS (ListUser, ListPass, `Catégorie`) VALUES (@user, @pin, @role); SELECT LAST_INSERT_ID();", conn, tx))
        {
            insert.Parameters.AddWithValue("@user", cleanUser);
            insert.Parameters.AddWithValue("@pin", cleanPin);
            insert.Parameters.AddWithValue("@role", roleName);
            var id = Convert.ToInt32(insert.ExecuteScalar());
            tx.Commit();
            return id;
        }
    }

    public void DeleteUser(int id)
    {
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var tx = conn.BeginTransaction(IsolationLevel.Serializable);
        string? targetRole = null;
        using (var check = new MySqlCommand("SELECT COALESCE(`Catégorie`,'') FROM TABLE_PASS WHERE ID = @id", conn, tx))
        {
            check.Parameters.AddWithValue("@id", id);
            targetRole = Convert.ToString(check.ExecuteScalar());
        }
        if (string.IsNullOrEmpty(targetRole))
            throw new InvalidOperationException("Utilisateur introuvable.");

        if (UserRoleMatrix.ParseRole(targetRole) == HanoutyRole.Admin)
        {
            using var admins = new MySqlCommand(
                "SELECT COUNT(*) FROM TABLE_PASS WHERE UPPER(TRIM(`Catégorie`)) IN ('ADMIN','ADMINISTRATEUR')", conn, tx);
            if (Convert.ToInt32(admins.ExecuteScalar()) <= 1)
                throw new InvalidOperationException("Impossible de supprimer le dernier administrateur.");
        }

        using (var del = new MySqlCommand("DELETE FROM TABLE_PASS WHERE ID = @id", conn, tx))
        {
            del.Parameters.AddWithValue("@id", id);
            del.ExecuteNonQuery();
        }
        tx.Commit();
    }
}
