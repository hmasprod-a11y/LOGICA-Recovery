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
            // This connection is shared by the legacy form. A failed movement INSERT
            // previously left it open, so the next catalogue operation inherited a
            // stale connection after a partial article-create failure. Preserve the
            // original success path, but always release the connection on failure.
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                using (var command = new MySqlCommand())
                {
                    // Preserve the original two clock reads and deferred form reads
                    // after opening; do not change the legacy stock posting order.
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
                }
            }
            finally
            {
                // Also close if a form reader or ExecuteNonQuery throws. Do not
                // swallow the exception: the original save caller must see failure.
                connection.Close();
            }
        }
    }
}
