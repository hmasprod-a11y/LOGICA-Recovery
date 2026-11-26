using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
namespace Hanouty.Desktop.Bootstrap;
internal sealed record OriginalWorkstationSetting(string Key,string Label,string Section,string Kind,string Consumer);
internal sealed record OriginalWorkstationSettingsSnapshot(string Actor,string Revision,IReadOnlyDictionary<string,string> Values,int MaximumLength,IReadOnlySet<string> MissingKeys);
internal sealed class OriginalWorkstationSettingsStore(string connectionString,Func<string?> authenticatedActor,Func<string?> readSessionPin,Action? beforeCommit=null)
{
    internal static readonly OriginalWorkstationSetting[] Definitions = [
        new("MODELE_TICKET","Modèle du ticket","Ticket","template","LogicaReceiptSettings / ReceiptPrintRouting"),
        new("BRANCHEMENT","Branchement imprimante","Ticket","connection","LogicaReceiptSettings / ReceiptPrintRouting"),
        new("AFFICHER_MODE_P","Afficher le paiement","Ticket","bool","LogicaCashReceiptPrinter"),
        new("AFFICHER_N_TICKET","Afficher le numéro du ticket","Ticket","bool","LogicaCashReceiptPrinter"),
        new("AFFICHER_CODE_BARRE","Afficher le QR du ticket","Ticket","bool","LogicaCashReceiptPrinter"),
        new("PIED_TICKET","Pied du ticket","Ticket","text","LogicaCashReceiptPrinter"),
        new("FENETRE_MODE_P","Modes de paiement","Vente","bool","MariaDbCashCheckoutPreparation.RequireCardMode"),
        new("MODIF_STOCK_MANUEL","Autoriser la correction manuelle du stock","Stock","bool","StockAdjustmentWriter"),
        new("GESTION_CLOTURE","Activer les clôtures","Caisse","bool","CashDrawerClosing"),
        new("CLOTURE_CAISSIER_OBLIGER","Clôture caissier avant clôture globale","Caisse","bool","CashDrawerClosing"),
        new("FONDS_CAISSE","Fonds de caisse (MAD)","Caisse","money","CashDrawerClosing") ];
    private static readonly Dictionary<string,string> OriginalDefaults=new(StringComparer.Ordinal) { ["MODIF_STOCK_MANUEL"]="False",["GESTION_CLOTURE"]="False",["CLOTURE_CAISSIER_OBLIGER"]="False",["FONDS_CAISSE"]="0" };
    private MySqlConnection Open()
    {
        var cs=new MySqlConnectionStringBuilder(connectionString){CharacterSet="utf8mb4"};
        if(cs.Server is not("127.0.0.1" or "localhost" or "::1"))throw new InvalidOperationException("Base locale requise.");
        var db=new MySqlConnection(cs.ConnectionString);db.Open();return db;
    }
    private static MySqlCommand Command(MySqlConnection db,MySqlTransaction tx,string sql,params(string Key,object Value)[] args)
    {var cmd=new MySqlCommand(sql,db,tx);foreach(var arg in args)cmd.Parameters.AddWithValue(arg.Key,arg.Value);return cmd;}
    private string RequireSession(MySqlConnection db,MySqlTransaction tx,string? expected=null)
    {
        var actor=authenticatedActor();
        if(string.IsNullOrWhiteSpace(actor)||expected!=null&&!string.Equals(actor,expected,StringComparison.Ordinal))throw new UnauthorizedAccessException("La session ADMIN a changé. Rouvrez les paramètres.");
        foreach(var table in new[]{"TABLE_PASS","TABLE_PARAMETRES"}){
            using var engine=Command(db,tx,"SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@table",("@table",table));
            if(Convert.ToString(engine.ExecuteScalar())!="InnoDB")throw new InvalidOperationException("Paramètres transactionnels indisponibles.");
        }
        using var cmd=Command(db,tx,"SELECT ListUser,Catégorie,ListPass FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor FOR UPDATE",("@actor",actor));
        var sessionPin=readSessionPin();
        try {
        using var rows=cmd.ExecuteReader();
        if(!rows.Read()||rows.IsDBNull(0)||rows.IsDBNull(1)||!string.Equals(rows.GetString(0),actor,StringComparison.Ordinal)||rows.GetString(1)!="ADMIN"||rows.IsDBNull(2)||string.IsNullOrEmpty(sessionPin)||!string.Equals(rows.GetString(2),sessionPin,StringComparison.Ordinal)||rows.Read())throw new UnauthorizedAccessException("Les paramètres sont réservés à la session ADMIN actuelle.");
        return actor;
        } finally { sessionPin=null; }
    }
    private static OriginalWorkstationSettingsSnapshot Read(MySqlConnection db,MySqlTransaction tx,string actor)
    {
        var values=new Dictionary<string,string>(StringComparer.Ordinal);
        var keys=Definitions.Select(d=>d.Key).ToArray();
        using(var cmd=Command(db,tx,"SELECT OBJET,VALEUR FROM TABLE_PARAMETRES WHERE UPPER(OBJET) IN ("+string.Join(",",keys.Select((_,i)=>"@k"+i))+") ORDER BY BINARY OBJET FOR UPDATE")){
            for(var i=0;i<keys.Length;i++)cmd.Parameters.AddWithValue("@k"+i,keys[i]);
            using var rows=cmd.ExecuteReader();while(rows.Read()){
                if(rows.IsDBNull(0)||rows.IsDBNull(1)||!keys.Contains(rows.GetString(0),StringComparer.Ordinal)||!values.TryAdd(rows.GetString(0),rows.GetString(1)))throw new InvalidOperationException("Paramètre absent de valeur, ambigu ou mal nommé.");
            }
        }
        using var size=Command(db,tx,"SELECT CHARACTER_MAXIMUM_LENGTH FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='TABLE_PARAMETRES' AND COLUMN_NAME='VALEUR'");
        var max=size.ExecuteScalar();if(max is null or DBNull)throw new InvalidOperationException("Format des paramètres indisponible.");
        var revision=Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(values.OrderBy(p=>p.Key,StringComparer.Ordinal)))));
        var missing=new HashSet<string>(StringComparer.Ordinal);
        foreach(var pair in OriginalDefaults)if(!values.ContainsKey(pair.Key)){missing.Add(pair.Key);values.Add(pair.Key,pair.Value);}
        return new(actor,revision,new ReadOnlyDictionary<string,string>(values),(int)Math.Min(int.MaxValue,Convert.ToInt64(max)),missing);
    }
    internal OriginalWorkstationSettingsSnapshot Load()
    {using var db=Open();using var tx=db.BeginTransaction(IsolationLevel.Serializable);var actor=RequireSession(db,tx);var result=Read(db,tx,actor);tx.Commit();return result;}
    internal OriginalWorkstationSettingsSnapshot Save(OriginalWorkstationSettingsSnapshot expected,IReadOnlyDictionary<string,string> changes)
    {
        using var db=Open();using var tx=db.BeginTransaction(IsolationLevel.Serializable);var actor=RequireSession(db,tx,expected.Actor);var current=Read(db,tx,actor);
        foreach(var pair in changes){
            var definition=Definitions.SingleOrDefault(d=>d.Key==pair.Key)??throw new ArgumentException("Paramètre non autorisé.");
            if(!current.Values.TryGetValue(pair.Key,out var previous)||pair.Value==null)throw new InvalidOperationException("Paramètre non présent : aucun ajout implicite.");
            if(pair.Value.Length>current.MaximumLength||pair.Value.Any(c=>char.IsControl(c)&&c is not ('\r' or '\n' or '\t')))throw new ArgumentException("Valeur trop longue ou non imprimable.");
            if(pair.Value==previous)continue;
            if(definition.Kind=="bool")_ = Conversions.ToBoolean(pair.Value);
            if(definition.Kind=="template"&&pair.Value!="FR_3C"||definition.Kind=="connection"&&pair.Value!="USB")throw new NotSupportedException("Cette route d'impression reste à raccorder.");
            if(definition.Kind=="money"&&(!decimal.TryParse(pair.Value,NumberStyles.AllowDecimalPoint,CultureInfo.InvariantCulture,out var money)||money<0||decimal.Round(money,2)!=money))throw new ArgumentException("Fonds de caisse : montant positif à deux décimales requis.");
        }
        if(current.Revision!=expected.Revision){if(changes.All(p=>current.Values.TryGetValue(p.Key,out var value)&&value==p.Value)){tx.Commit();return current;}throw new InvalidOperationException("Les paramètres ont changé. Rechargez avant de sauvegarder.");}
        var desired=new Dictionary<string,string>(current.Values,StringComparer.Ordinal);
        foreach(var pair in changes.Where(p=>current.MissingKeys.Contains(p.Key)||current.Values[p.Key]!=p.Value)){
            using var update=Command(db,tx,current.MissingKeys.Contains(pair.Key)?"INSERT INTO TABLE_PARAMETRES (OBJET,VALEUR) VALUES (@key,@value)":"UPDATE TABLE_PARAMETRES SET VALEUR=@value WHERE BINARY OBJET=BINARY @key",("@value",pair.Value),("@key",pair.Key));
            if(update.ExecuteNonQuery()!=1)throw new InvalidOperationException("Écriture non confirmée.");desired[pair.Key]=pair.Value;
        }
        var verified=Read(db,tx,actor);if(desired.Count!=verified.Values.Count||desired.Any(p=>!verified.Values.TryGetValue(p.Key,out var value)||!string.Equals(value,p.Value,StringComparison.Ordinal)))throw new InvalidOperationException("Vérification des paramètres échouée.");
        RequireSession(db,tx,actor);beforeCommit?.Invoke();tx.Commit();return verified;
    }
}




