# Manual stock permission source review — 2026-11-05

Status: **UNMAPPED; manual writes remain disabled.**
This extends the existing IManualStockAuthorization / ValidateAuthorizationContext contract.
No second authorization interface, database migration, UI registration or writer enablement is introduced.

## Evidence and limits

Sources examined at Inventory 4e8f03efab78cd8c1d01c877d825760bec578698:
- Form_1_LOGIN.cs:2102–2110 reads TABLE_PASS by parameterized ListPass and copies ListUser/Categorie to Module1 globals. Lines 2092–2098 can separately assign root. These mutable globals are not authenticated session capabilities.
- Form_3_VENTE.cs:11578–11625 maps TABLE_PASS columns to Button_<column> visibility/access prompts. Button_MODIF_QTE_Click:16300–16348 opens the basket quantity editor. MODIF_QTE is sales UI policy, not an explicit manual-stock grant.
- FormDialog_1_UTILISATEURS.cs:4595–4665 assigns VISIBLE/INVISIBLE defaults for role selection. ADMIN does not establish a separate manual-stock permission.
- Form_2_ARTICLES.cs:13831–13833 disables stock editing based on the global setting loaded at 14165 (MODIF_STOCK_MANUEL). It does not verify an actor-scoped grant.
- Architecture 5e6e4257cdea5aa7bb4199ce982b3afa327c1a63, HANOUTY_MASTER_MODERNIZATION_V2.md and HANOUTY_EXECUTION_CONTRACT_V3_2026-11-04.md require verified actor permission but provide no accepted persisted grant mapping.

This bounded review establishes no accepted source. It is not a claim that every historical schema or original executable was exhaustively inspected.

## Contract already delivered

Inventory e279900f097b9ceb1f1149f2fe8c5974340404e6 contains:
- IManualStockAuthorization.VerifyForWrite(connection, transaction, authenticatedSessionId, requestedUserId).
- DenyAllManualStockAuthorization as the only production provider.
- StockAdjustmentWriter.ValidateAuthorizationContext: exact active local connection/transaction and ordinal actor matching, with no mutation.
- Execute and Apply retain unconditional UnauthorizedAccessException guards.

An actor object or successful ValidateAuthorizationContext return is **not** a write capability.
There is no production caller enabling manual stock writes. The new call site is the existing executable acceptance harness, using a clearly marked controlled provider.

## Required mapping review before any write enablement

Architecture must identify the existing authoritative session issuer, immutable actor key, explicit manual-stock grant and revocation representation, or approve a separate development-only schema proposal. No role aliases, MODIF_QTE fallback or implicit shop migration.

The concrete provider must authenticate the live session and reread its explicit grant inside the SAME open InnoDB transaction supplied to VerifyForWrite. Lock the identity/grant rows until stock+audit complete; document lock order and concurrent revocation semantics. Revocation committed before the write's authorization read must deny; a concurrent revocation blocked behind an already authorized transaction must have an explicit reviewed serialization order. Session expiry, deleted/duplicate grant, unavailable source and identity mismatch deny without fallback. Do not log credentials/session secrets.

Manual Execute owns its own transaction. Checkout must never call it or decrement stock twice.

## Executable contract evidence and remaining gates

The existing stock-authorization-acceptance executable now invokes ManualStockAuthorizationContractCases.Run on a real disposable MariaDB transaction. It checks:
1. A controlled provider permits non-writing context validation; revoking that same fixture forces a fresh provider call and rejection.
2. Mismatched/case-changed/null actor and provider failure are rejected.
3. Detached/completed transactions and missing session never reach the provider.
4. Committing after rejection leaves actual stock and audit unchanged.

These are production-boundary contract tests with **controlled authorization evidence**, not real authentication or persisted-grant acceptance. Existing P0 tests remain intact.

Before enabling writes, add actual persisted-session/grant revocation tests and restore positive stock+audit acceptance: successful write, audit-trigger failure after stock update, caller catches then commits (savepoint rollback), stale stock, concurrent updates, duplicate identity, and stock rounding. The disabled path cannot prove successful-write atomicity. Do not count those gates as passed.

Run:
`dotnet run --project modernization/stock-authorization-acceptance/StockAuthorizationAcceptance.csproj -c Release`
using the existing inventory-p0-authorization workflow's disposable loopback MariaDB.
