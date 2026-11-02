using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueCreationMovementWriter
    {
        public static void Write(string articleId, Func<string> readCode, Func<string> readArticle,
            Func<string> readStock, MySqlConnection connection)
        {
            var command = new MySqlCommand();
            if (connection.State != ConnectionState.Open)
                connection.Open();
            // Preserve the original two clock reads and deferred form reads after opening.
            // The movement is written after article persistence in the legacy workflow:
            // quotes in a barcode/name must never turn that second write into invalid SQL.
            command.CommandText = "INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES, HEURE, LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE) " +
                "VALUES (@dates, @heure, 'Création d''article', @articleId, @code, @article, @quantity)";
            command.Parameters.AddWithValue("@dates", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@heure", DateTime.Now.ToString("HH:mm:ss"));
            command.Parameters.AddWithValue("@articleId", articleId);
            command.Parameters.AddWithValue("@code", readCode());
            command.Parameters.AddWithValue("@article", readArticle());
            command.Parameters.AddWithValue("@quantity", readStock());
            command.Connection = connection;
            command.ExecuteNonQuery();
            // Deliberately reached only on success, matching the existing failure path.
            connection.Close();
        }
    }
}
