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
            // Preserve the two clock reads and deferred raw text reads after opening.
            command.CommandText = "INSERT  INTO   TABLE_MOUVEMENTS_STOCK               ( DATES , HEURE , LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE)         values           ( '" + DateTime.Now.ToString("yyyy-MM-dd") + "' ,  '" + DateTime.Now.ToString("HH:mm:ss") + "'  ,'Création d''article'    ,'" + articleId + "' ,'" + readCode() + "' ,'" + readArticle() + "'  ,'" + readStock() + "'       )        ";
            command.Connection = connection;
            command.ExecuteNonQuery();
            // Deliberately reached only on success, matching the existing failure path.
            connection.Close();
        }
    }
}
