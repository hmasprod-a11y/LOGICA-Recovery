using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Catalogue
{
    internal static class CatalogueAggregateLookup
    {
        public static DataTable Read(string family, MySqlConnection connection)
        {
            string text = null;
            string text2 = null;
            if (Operators.CompareString(family, "", false) != 0)
            {
                text = "  WHERE  Famille =   '" + family + "'        ";
                text2 = "  AND      Famille =   '" + family + "'        ";
            }
            string text3 = "select    count(ID)  as N  from  TABLE_ARTICLES     " + text + "  ";
            string text4 = "select    count(ID)  as N   from  TABLE_ARTICLES    WHERE       STOCK    <=  Alert   and   STOCK <> 0  " + text2 + " ";
            string text5 = "select    count(ID)  as N   from  TABLE_ARTICLES    WHERE       STOCK    < 0  " + text2 + " ";
            string text6 = "select    count(ID)   as N    from  TABLE_ARTICLES    WHERE       PROMOTION <> 0     " + text2 + "  ";
            string text7 = "select    sum(STOCK * PRIX_MP)   as N   from  TABLE_ARTICLES  where  STOCK > 0     and    PRIX_MP > 0       " + text2 + "  ";
            string text8 = "select    count(ID)   as N   from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_MP <= 0)       " + text2 + "  ";
            string text9 = "select    sum(STOCK * PRIX_A)   as N   from  TABLE_ARTICLES  where  STOCK > 0     and    PRIX_A > 0       " + text2 + " ";
            string text10 = "select    count(ID)   as N   from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_MP <= 0)       " + text2 + "  ";
            string text11 = "select    sum(STOCK * PRIX_V_1)   as N   from  TABLE_ARTICLES  where  STOCK > 0     AND    PRIX_V_1 > 0      " + text2 + "   ";
            string text12 = "select    count(id)   as N   from  TABLE_ARTICLES  where  (STOCK < 0     OR    PRIX_V_1 <= 0)       " + text2 + "  ";
            // Recovered databases predate the optional PRIX_QTE column. Preserve
            // the aggregate row order with a literal zero when it is absent.
            bool hasPriceQuantity;
            bool wasOpen = connection.State == ConnectionState.Open;
            try
            {
                if (!wasOpen) connection.Open();
                using (var check = new MySqlCommand("SELECT COUNT(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'TABLE_ARTICLES' AND COLUMN_NAME = 'PRIX_QTE'", connection))
                    hasPriceQuantity = System.Convert.ToInt32(check.ExecuteScalar()) != 0;
            }
            finally
            {
                if (!wasOpen) connection.Close();
            }
            string text13 = hasPriceQuantity
                ? "select count(ID) as N from TABLE_ARTICLES WHERE PRIX_QTE <> 0 " + text2
                : "select 0 as N";
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable = new DataTable();
            var val = new MySqlDataAdapter(" ( " + text3 + " )       UNION ALL         ( " + text4 + " )        UNION ALL     ( " + text5 + " )      UNION ALL     ( " + text6 + " )      UNION ALL      ( " + text7 + " )      UNION ALL     ( " + text8 + " )     UNION ALL     ( " + text9 + " )      UNION ALL     ( " + text10 + " )     UNION ALL      ( " + text11 + " )       UNION ALL      ( " + text12 + " )      UNION ALL      ( " + text13 + " )       ", connection);
            ((DbDataAdapter)(object)val).Fill(dataTable);
            
            return dataTable;
        }
    }
}
