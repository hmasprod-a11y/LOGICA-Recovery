using System.Data;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Hanouty.ArchitectureBridge;
using LOGICA.Application.Inventory;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class DailyStockAdjustmentService
{
    internal sealed record Authorization(Guid Token);
    internal sealed record Snapshot(long RowId, string ArticleId, string Code, string Name, decimal Stock);
    internal enum AdjustmentMode { Increase, Decrease, ActualQuantity }
    internal sealed record Command(string OperationId, Snapshot Expected, AdjustmentMode Mode, decimal Quantity, string Reason);
    internal sealed record Result(string OperationId, Snapshot Before, decimal After, decimal Delta, long MovementId, string AuditLabel, bool Replayed);
    internal sealed class RefusedException(string message, Exception? inner = null) : InvalidOperationException(message, inner);
    private sealed record Grant(VerifiedStockActor Actor, string Permission, string Approver, string? ExactRole);
    private sealed class ActorSource(Func<VerifiedStockActor?> read) : IVerifiedStockActorSource
    { public VerifiedStockActor? CurrentVerifiedActor() => read(); }
    private sealed class PermissionReader(Func<VerifiedStockActor, bool> read) : IManualStockPermissionReader
    { public bool CanAdjustStock(VerifiedStockActor actor) => read(actor); }
    private readonly string connectionString;
    private readonly ActorSource actors;
    private readonly Func<string> readSessionPin;
    private readonly Dictionary<Guid, Grant> grants = new();

    internal DailyStockAdjustmentService(string connectionString, Func<VerifiedStockActor?> currentVerifiedSession, Func<string> readSessionPin)
    {
        this.connectionString = connectionString; actors = new ActorSource(currentVerifiedSession); this.readSessionPin = readSessionPin;
    }
    private MySqlConnection Open()
    {
        var cs = new MySqlConnectionStringBuilder(connectionString);
        if (cs.Server is not ("127.0.0.1" or "localhost" or "::1")) throw new RefusedException("La modification de stock nécessite la base locale du poste.");
        var db = new MySqlConnection(connectionString); try { db.Open(); return db; } catch { db.Dispose(); throw; }
    }
    private static MySqlCommand Sql(MySqlConnection db, MySqlTransaction? tx, string sql, params (string Name, object Value)[] values)
    {
        var command = new MySqlCommand(sql, db, tx);
        foreach (var (name, value) in values) command.Parameters.AddWithValue(name, value);
        return command;
    }
    private static string ActorPermission(MySqlConnection db, MySqlTransaction? tx, string actor, bool locked)
    {
        using var command = Sql(db, tx, "SELECT Catégorie,ARTICLES FROM TABLE_PASS WHERE BINARY ListUser=BINARY @actor" + (locked ? " FOR UPDATE" : ""), ("@actor", actor));
        using var row = command.ExecuteReader();
        if (!row.Read() || row.IsDBNull(0) || row.GetString(0) != "ADMIN" || row.IsDBNull(1)) throw new UnauthorizedAccessException("Seule une session administrateur peut modifier le stock.");
        var permission = row.GetString(1);
        if (permission is not ("VISIBLE" or "ACCES MANAGER" or "ACCES ADMIN") || row.Read()) throw new UnauthorizedAccessException("L’accès à la modification des articles est interdit.");
        return permission;
    }
    private static void ManualSetting(MySqlConnection db, MySqlTransaction? tx, bool locked)
    {
        using var command = Sql(db, tx, "SELECT VALEUR FROM TABLE_PARAMETRES WHERE BINARY OBJET=BINARY 'MODIF_STOCK_MANUEL'" + (locked ? " FOR UPDATE" : ""));
        using var row = command.ExecuteReader();
        if (!row.Read() || row.IsDBNull(0))
            throw new RefusedException("Le réglage « Modification manuelle du stock » est désactivé ou ambigu.");
        var value = row.GetString(0);
        if (row.Read()) throw new RefusedException("Le réglage « Modification manuelle du stock » est désactivé ou ambigu.");
        bool allowed;
        try { allowed = Conversions.ToBoolean(value); }
        catch (Exception ex) when (ex is InvalidCastException or FormatException or OverflowException) { throw new RefusedException("La valeur du réglage de stock est invalide.", ex); }
        if (!allowed) throw new RefusedException("Le réglage « Modification manuelle du stock » est désactivé.");
    }
    private VerifiedStockActor CurrentSession()
    {
        var actor = actors.CurrentVerifiedActor();
        if (actor is null || string.IsNullOrWhiteSpace(actor.SessionId) || string.IsNullOrWhiteSpace(actor.ActorId))
            throw new UnauthorizedAccessException("Une session administrateur authentifiée est nécessaire.");
        return actor;
    }
    internal Authorization Authorize(Func<string, string> readExactRolePin)
    {
        var actor = CurrentSession(); string permission;
        using (var db = Open()) { permission = ActorPermission(db, null, actor.ActorId, false); ManualSetting(db, null, false); }
        var role = permission == "ACCES MANAGER" ? "MANAGER" : permission == "ACCES ADMIN" ? "ADMIN" : null;
        var approver = actor.ActorId;
        if (role is not null)
        {
            var pin = readExactRolePin(role);
            try
            {
                if (string.IsNullOrWhiteSpace(pin)) throw new UnauthorizedAccessException("Autorisation du rôle annulée.");
                using var db = Open();
                using var command = Sql(db, null, "SELECT ListUser FROM TABLE_PASS WHERE BINARY Catégorie=BINARY @role AND BINARY ListPass=BINARY @pin", ("@role", role), ("@pin", pin));
                using var row = command.ExecuteReader();
                if (!row.Read() || row.IsDBNull(0)) throw new UnauthorizedAccessException("PIN du rôle demandé invalide.");
                approver = row.GetString(0); if (row.Read()) throw new UnauthorizedAccessException("Autorisation du rôle ambiguë.");
            }
            finally { pin = ""; }
        }
        var grant = new Grant(actor, permission, approver, role);
        using (var db = Open()) Check(grant, db, null, false);
        var token = new Authorization(Guid.NewGuid()); grants.Add(token.Token, grant); return token;
    }
    private Grant GrantFor(Authorization authorization) => grants.TryGetValue(authorization.Token, out var grant)
        ? grant : throw new UnauthorizedAccessException("Cette autorisation de stock n’appartient pas à la session.");
    private void Check(Grant grant, MySqlConnection db, MySqlTransaction? tx, bool locked)
    {
        var actor = CurrentSession();
        if (actor != grant.Actor) throw new UnauthorizedAccessException("La session administrateur a changé. Rouvrez l’ajustement.");
        if (ActorPermission(db, tx, actor.ActorId, locked) != grant.Permission) throw new UnauthorizedAccessException("Les droits des articles ont changé.");
        if (grant.ExactRole is not null)
        {
            using var command = Sql(db, tx, "SELECT Catégorie FROM TABLE_PASS WHERE BINARY ListUser=BINARY @user" + (locked ? " FOR UPDATE" : ""), ("@user", grant.Approver));
            using var row = command.ExecuteReader();
            if (!row.Read() || row.IsDBNull(0) || row.GetString(0) != grant.ExactRole || row.Read()) throw new UnauthorizedAccessException("L’autorisation du rôle a changé.");
        }
        ManualSetting(db, tx, locked);
        // Reuse the reviewed session boundary, never a UserId/role label supplied by the dialog.
        ManualStockAuthorizationBoundary.RequireAuthorized(actors, new PermissionReader(candidate => candidate == grant.Actor));
    }
    internal Snapshot Preview(Authorization authorization, DailyStockReader.Article selected)
    {
        var grant = GrantFor(authorization);
        using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
        InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_PASS", "TABLE_PARAMETRES", "TABLE_ARTICLES", "TABLE_MOUVEMENTS_STOCK", "hanouty_daily_stock_adjustments");
        Check(grant, db, tx, true); var current = Read(db, tx, selected.RowId);
        if (!selected.CanonicalIdentity || current.ArticleId != selected.Id || current.Code != selected.Code || current.Name != selected.Name)
            throw new RefusedException("L’identité de l’article a changé. Actualisez le stock.");
        tx.Commit(); return current;
    }
    private static Snapshot Read(MySqlConnection db, MySqlTransaction tx, long rowId)
    {
        Snapshot result;
        using (var command = Sql(db, tx, "SELECT ID_ARTICLE,Code,Article,STOCK FROM TABLE_ARTICLES WHERE ID=@row FOR UPDATE", ("@row", rowId)))
        using (var row = command.ExecuteReader())
        {
            if (!row.Read() || row.IsDBNull(0) || row.IsDBNull(2) || row.IsDBNull(3)) throw new RefusedException("Article ou stock introuvable.");
            result = new Snapshot(rowId, row.GetString(0), row.IsDBNull(1) ? "" : row.GetString(1), row.GetString(2), Convert.ToDecimal(row.GetValue(3), CultureInfo.InvariantCulture));
            if (row.Read()) throw new RefusedException("Identité de fiche ambiguë.");
        }
        // Numeric PK write + SERIALIZABLE locking avoids a broad multi-row update
        // even on original LOGICA schemas without a UNIQUE ID_ARTICLE index.
        using var identities = Sql(db, tx, "SELECT ID FROM TABLE_ARTICLES WHERE UPPER(ID_ARTICLE)=UPPER(@id) FOR UPDATE", ("@id", result.ArticleId));
        using var identity = identities.ExecuteReader();
        if (!identity.Read() || identity.GetInt64(0) != rowId || identity.Read()) throw new RefusedException("L’identifiant de cet article est ambigu.");
        return result;
    }
    internal static decimal ProposedAfter(Command request) => request.Mode switch
    {
        AdjustmentMode.Increase when request.Quantity > 0 => checked(request.Expected.Stock + request.Quantity),
        AdjustmentMode.Decrease when request.Quantity > 0 => checked(request.Expected.Stock - request.Quantity),
        AdjustmentMode.ActualQuantity when request.Quantity >= 0 => request.Quantity,
        _ => throw new RefusedException("Choisissez une quantité positive, ou zéro pour un stock réel nul.")
    };
    internal Result Execute(Authorization authorization, Command request, Action? afterCommit = null)
    {
        var attemptedCommit = false;
        try { return Save(); }
        catch (Exception ex) when (!attemptedCommit && ex is not OutOfMemoryException and not StackOverflowException)
        { throw new RefusedException(ex.Message, ex); }
        Result Save()
        {
            var grant = GrantFor(authorization);
            if (!Guid.TryParseExact(request.OperationId, "N", out var op) || request.OperationId != op.ToString("N")) throw new RefusedException("Référence d’ajustement invalide.");
            var plan = StockAdjustmentPlan.Create(request.Expected.ArticleId, request.Expected.Stock, ProposedAfter(request), request.Reason, grant.Actor.ActorId);
            var audit = $"Ajustement [{plan.UserId}] {plan.BeforeStock.ToString(CultureInfo.InvariantCulture)} -> {plan.AfterStock.ToString(CultureInfo.InvariantCulture)} : {plan.Reason}";
            if (Encoding.UTF8.GetByteCount(audit) > 255) throw new RefusedException("Le motif est trop long pour le journal LOGICA.");
            using var db = Open(); using var tx = db.BeginTransaction(IsolationLevel.Serializable);
            InventoryDocumentValidation.RequireTransactionalTables(db, tx, "TABLE_PASS", "TABLE_PARAMETRES", "TABLE_ARTICLES", "TABLE_MOUVEMENTS_STOCK", "hanouty_daily_stock_adjustments");
            Check(grant, db, tx, true);
            var pin = readSessionPin();
            try { InventoryDocumentValidation.Authenticate(db, tx, grant.Actor.ActorId, pin, validationOnly: true); }
            finally { pin = ""; }
            var payload = JsonSerializer.Serialize(request);
            using (var replay = Sql(db, tx, "SELECT ACTOR,PAYLOAD,AFTER_STOCK,DELTA,MOVEMENT_ID,AUDIT_LABEL,ARTICLE_ROW_ID,ARTICLE_ID,BEFORE_STOCK FROM hanouty_daily_stock_adjustments WHERE OPERATION_ID=@op FOR UPDATE", ("@op", request.OperationId)))
            using (var row = replay.ExecuteReader())
                if (row.Read())
                {
                    if (row.GetString(0) != grant.Actor.ActorId || row.GetString(1) != payload || row.GetDecimal(2) != plan.AfterStock || row.GetDecimal(3) != plan.Delta ||
                        row.GetString(5) != audit || row.GetInt64(6) != request.Expected.RowId || row.GetString(7) != request.Expected.ArticleId || row.GetDecimal(8) != request.Expected.Stock)
                        throw new RefusedException("Cette référence appartient à un autre ajustement.");
                    var result = new Result(request.OperationId, request.Expected, row.GetDecimal(2), row.GetDecimal(3), row.GetInt64(4), row.GetString(5), true);
                    if (row.Read()) throw new RefusedException("Cette référence d’ajustement est ambiguë.");
                    row.Close(); VerifyMovement(db, tx, result.MovementId, request.Expected, plan.Delta, audit);
                    Check(grant, db, tx, true); attemptedCommit = true; tx.Commit(); return result;
                }
            var current = Read(db, tx, request.Expected.RowId);
            if (current != request.Expected) throw new RefusedException("Le stock ou la fiche a changé. Actualisez avant de confirmer.");
            using (var update = Sql(db, tx, "UPDATE TABLE_ARTICLES SET STOCK=@after WHERE ID=@row AND STOCK=@before", ("@after", plan.AfterStock), ("@row", current.RowId), ("@before", plan.BeforeStock)))
                if (update.ExecuteNonQuery() != 1) throw new RefusedException("Le stock a changé pendant l’ajustement.");
            if (Read(db, tx, current.RowId) != (current with { Stock = plan.AfterStock })) throw new RefusedException("Le stock relu ne correspond pas à la quantité demandée.");
            long movementId;
            using (var movement = Sql(db, tx, "INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES,HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE) VALUES (@date,@time,@label,@id,@code,@name,@delta)",
                ("@date", DateTime.Now), ("@time", DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture)), ("@label", audit), ("@id", current.ArticleId),
                ("@code", current.Code), ("@name", current.Name), ("@delta", plan.Delta)))
            {
                if (movement.ExecuteNonQuery() != 1 || movement.LastInsertedId <= 0) throw new RefusedException("Le mouvement de stock n’a pas été confirmé.");
                movementId = movement.LastInsertedId;
            }
            using (var journal = Sql(db, tx, "INSERT INTO hanouty_daily_stock_adjustments (OPERATION_ID,ACTOR,SESSION_HASH,ARTICLE_ROW_ID,ARTICLE_ID,BEFORE_STOCK,AFTER_STOCK,DELTA,MOVEMENT_ID,AUDIT_LABEL,PAYLOAD,CREATED_UTC) " +
                "VALUES (@op,@actor,@session,@row,@id,@before,@after,@delta,@movement,@audit,@payload,UTC_TIMESTAMP(6))", ("@op", request.OperationId), ("@actor", grant.Actor.ActorId),
                ("@session", Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(grant.Actor.SessionId)))), ("@row", current.RowId), ("@id", current.ArticleId), ("@before", plan.BeforeStock),
                ("@after", plan.AfterStock), ("@delta", plan.Delta), ("@movement", movementId), ("@audit", audit), ("@payload", payload)))
                if (journal.ExecuteNonQuery() != 1) throw new RefusedException("Le journal d’ajustement n’a pas été confirmé.");
            VerifyMovement(db, tx, movementId, current, plan.Delta, audit);
            if (Read(db, tx, current.RowId) != (current with { Stock = plan.AfterStock })) throw new RefusedException("Le stock a changé pendant l’écriture du journal.");
            using (var verifyJournal = Sql(db, tx, "SELECT ACTOR,PAYLOAD,ARTICLE_ROW_ID,ARTICLE_ID,BEFORE_STOCK,AFTER_STOCK,DELTA,MOVEMENT_ID,AUDIT_LABEL FROM hanouty_daily_stock_adjustments WHERE OPERATION_ID=@op FOR UPDATE", ("@op", request.OperationId)))
            using (var row = verifyJournal.ExecuteReader())
                if (!row.Read() || row.GetString(0) != grant.Actor.ActorId || row.GetString(1) != payload || row.GetInt64(2) != current.RowId || row.GetString(3) != current.ArticleId ||
                    row.GetDecimal(4) != plan.BeforeStock || row.GetDecimal(5) != plan.AfterStock || row.GetDecimal(6) != plan.Delta || row.GetInt64(7) != movementId || row.GetString(8) != audit || row.Read())
                    throw new RefusedException("Le journal relu ne correspond pas à l’ajustement.");
            Check(grant, db, tx, true); attemptedCommit = true; tx.Commit(); afterCommit?.Invoke();
            return new Result(request.OperationId, current, plan.AfterStock, plan.Delta, movementId, audit, false);
        }
    }
    private static void VerifyMovement(MySqlConnection db, MySqlTransaction tx, long movementId, Snapshot article, decimal delta, string audit)
    {
        using var command = Sql(db, tx, "SELECT ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE,LIBELLE FROM TABLE_MOUVEMENTS_STOCK WHERE ID=@row FOR UPDATE", ("@row", movementId));
        using var row = command.ExecuteReader();
        if (!row.Read() || row.IsDBNull(0) || row.GetString(0) != article.ArticleId || (row.IsDBNull(1) ? "" : row.GetString(1)) != article.Code ||
            row.IsDBNull(2) || row.GetString(2) != article.Name || row.IsDBNull(3) || Convert.ToDecimal(row.GetValue(3), CultureInfo.InvariantCulture) != delta ||
            row.IsDBNull(4) || row.GetString(4) != audit || row.Read()) throw new RefusedException("Le mouvement relu ne correspond pas à l’ajustement.");
    }
    internal string RecoveryScope(Authorization authorization)
    {
        var grant = GrantFor(authorization); var cs = new MySqlConnectionStringBuilder(connectionString);
        var scope = new MySqlConnectionStringBuilder { Server = cs.Server, Port = cs.Port, Database = cs.Database, UserID = cs.UserID }.ConnectionString + "|" + grant.Actor.ActorId;
        return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(scope)));
    }
}
