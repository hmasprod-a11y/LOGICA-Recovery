using MySql.Data.MySqlClient;
namespace Hanouty.Desktop.Bootstrap;
internal static class ProtectedCopySchemaValidation
{
    internal static void Validate(MySqlConnection db)
    {
        var journals = new Dictionary<string,(string Columns,string Primary)> {
            ["hanouty_checkout_operations"]=("operation_id:varchar,created_utc:timestamp","operation_id"),
            ["hanouty_cash_return_consumption"]=("original_ticket_id:varchar,return_operation_id:varchar,consumed_quantity:decimal","original_ticket_id"),
            ["hanouty_return_line_consumption"]=("original_ticket_id:varchar,article_id:varchar,returned_quantity:decimal,returned_net:decimal,last_operation_id:varchar","original_ticket_id,article_id"),
            ["hanouty_purchase_receipt_order"]=("RECEIPT_ID:varchar,ORDER_ID:varchar,ARTICLE_ID:varchar,QUANTITY:decimal","RECEIPT_ID,ARTICLE_ID"),
            ["hanouty_catalogue_price_audit"]=("ID:bigint,ARTICLE_ID:varchar,ACTOR:varchar,PREVIOUS_PRICE:decimal,NEW_PRICE:decimal,CHANGED_UTC:timestamp","ID"),
            ["hanouty_stock_issue_history"]=("ISSUE_ID:varchar,ARTICLE_ID:varchar,ACTOR:varchar,REASON:text,CODE:text,ARTICLE:text,QUANTITY:decimal,STOCK_BEFORE:decimal,STOCK_AFTER:decimal,VALIDATED_UTC:datetime","ISSUE_ID,ARTICLE_ID"),
            ["hanouty_client_settlement_operations"]=("OPERATION_ID:varchar,ACTOR:varchar,CLIENT_ID:varchar,AMOUNT:decimal,PAYMENT_MODE:varchar,NOTES:text,SETTLEMENT_ID:bigint","OPERATION_ID"),
            ["hanouty_supplier_settlement_operations"]=("OPERATION_ID:varchar,ACTOR:varchar,SUPPLIER_ID:varchar,AMOUNT:decimal,PAYMENT_MODE:varchar,NOTES:text,SETTLEMENT_ID:bigint","OPERATION_ID"),
            ["hanouty_customer_file_operations"]=("OPERATION_ID:varchar,ACTOR:varchar,KIND:varchar,CUSTOMER_ID:varchar,PAYLOAD:longtext,RESULT:longtext,CREATED_UTC:datetime","OPERATION_ID"),
            ["hanouty_stock_issue_create_operations"]=("OPERATION_ID:varchar,ACTOR:varchar,ISSUE_ID:varchar,PAYLOAD:longtext,CREATED_UTC:datetime","OPERATION_ID") };
        foreach(var pair in journals)
        {
            using var cmd=new MySqlCommand("SELECT COLUMN_NAME,DATA_TYPE,IS_NULLABLE FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@t",db); cmd.Parameters.AddWithValue("@t",pair.Key);
            var fields=new Dictionary<string,(string Type,string Nullable)>(StringComparer.OrdinalIgnoreCase);
            using(var reader=cmd.ExecuteReader())while(reader.Read())fields.Add(reader.GetString(0),(reader.GetString(1),reader.GetString(2)));
            foreach(var field in pair.Value.Columns.Split(',')) {var parts=field.Split(':');if(!fields.TryGetValue(parts[0],out var actual)||actual.Type!=parts[1]||actual.Nullable!="NO")throw new InvalidOperationException("Journal incompatible : "+pair.Key+"."+parts[0]);}
            using var key=new MySqlCommand("SELECT GROUP_CONCAT(COLUMN_NAME ORDER BY SEQ_IN_INDEX) FROM information_schema.STATISTICS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@t AND INDEX_NAME='PRIMARY'",db);key.Parameters.AddWithValue("@t",pair.Key);
            if(!string.Equals(Convert.ToString(key.ExecuteScalar()),pair.Value.Primary,StringComparison.OrdinalIgnoreCase))throw new InvalidOperationException("Clé de journal incompatible : "+pair.Key);
        }
        foreach(var target in new[]{("hanouty_cash_return_consumption","return_operation_id"),("hanouty_client_settlement_operations","SETTLEMENT_ID"),("hanouty_supplier_settlement_operations","SETTLEMENT_ID")})
        {
            using var key=new MySqlCommand("SELECT COUNT(*) FROM (SELECT INDEX_NAME FROM information_schema.STATISTICS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@t AND NON_UNIQUE=0 GROUP BY INDEX_NAME HAVING COUNT(*)=1 AND MAX(COLUMN_NAME)=@c AND MAX(SUB_PART) IS NULL) AS exact_keys",db);key.Parameters.AddWithValue("@t",target.Item1);key.Parameters.AddWithValue("@c",target.Item2);
            if(Convert.ToInt64(key.ExecuteScalar())<1)throw new InvalidOperationException("Unicité de journal absente : "+target.Item1);
        }
        foreach(var target in new[]{("hanouty_return_line_consumption","returned_quantity",19,4),("hanouty_return_line_consumption","returned_net",19,2),("hanouty_cash_return_consumption","consumed_quantity",16,3),("hanouty_client_settlement_operations","AMOUNT",18,2),("hanouty_supplier_settlement_operations","AMOUNT",18,2)})
        {
            using var field=new MySqlCommand("SELECT COUNT(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@t AND COLUMN_NAME=@c AND NUMERIC_PRECISION=@p AND NUMERIC_SCALE=@s",db);field.Parameters.AddWithValue("@t",target.Item1);field.Parameters.AddWithValue("@c",target.Item2);field.Parameters.AddWithValue("@p",target.Item3);field.Parameters.AddWithValue("@s",target.Item4);if(Convert.ToInt64(field.ExecuteScalar())!=1)throw new InvalidOperationException("Précision financière incompatible : "+target.Item1);
        }
    }
}
