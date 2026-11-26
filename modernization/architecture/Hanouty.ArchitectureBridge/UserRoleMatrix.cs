using System;
using System.Collections.Generic;

namespace Hanouty.ArchitectureBridge;

public enum HanoutyRole
{
    Utilisateur,
    Manager,
    Admin
}

public enum HanoutyPermission
{
    PosSell,
    ApplyManualDiscount,
    ProcessReturn,
    ValidateInventory,
    EditCataloguePrice,
    CloseCashDrawer,
    ManageUsers,
    BackupAndRestore,
    ManagePurchaseOrders,
    ViewMarginAndStatistics
}

public sealed record HanoutyUserRecord(int Id, string Username, string Role, string Pin);

public static class UserRoleMatrix
{
    public static HanoutyRole ParseRole(string? rawRole)
    {
        if (string.IsNullOrWhiteSpace(rawRole))
            return HanoutyRole.Utilisateur;
        return rawRole.Trim().ToUpperInvariant() switch
        {
            "ADMIN" or "ADMINISTRATEUR" => HanoutyRole.Admin,
            "MANAGER" or "GERANT" or "GÉRANT" => HanoutyRole.Manager,
            _ => HanoutyRole.Utilisateur
        };
    }

    public static string ToLogicaRoleName(HanoutyRole role) => role switch
    {
        HanoutyRole.Admin => "ADMIN",
        HanoutyRole.Manager => "MANAGER",
        _ => "UTILISATEUR"
    };

    public static bool HasPermission(string? rawRole, HanoutyPermission permission) =>
        HasPermission(ParseRole(rawRole), permission);

    public static bool HasPermission(HanoutyRole role, HanoutyPermission permission) => role switch
    {
        HanoutyRole.Admin => true,
        HanoutyRole.Manager => permission is not HanoutyPermission.ManageUsers and not HanoutyPermission.BackupAndRestore,
        HanoutyRole.Utilisateur => permission is HanoutyPermission.PosSell,
        _ => false
    };

    public static void ValidateNewUser(string? username, string? pin, string? role)
    {
        if (string.IsNullOrWhiteSpace(username) || username.Trim().Length < 2 || username.Trim().Length > 64)
            throw new ArgumentException("Le nom d'utilisateur doit contenir entre 2 et 64 caractères.", nameof(username));
        if (string.IsNullOrWhiteSpace(pin) || pin.Trim().Length < 4 || pin.Trim().Length > 32)
            throw new ArgumentException("Le code PIN doit contenir entre 4 et 32 caractères.", nameof(pin));
        if (string.IsNullOrWhiteSpace(role))
            throw new ArgumentException("Le rôle utilisateur est obligatoire.", nameof(role));
    }
}
