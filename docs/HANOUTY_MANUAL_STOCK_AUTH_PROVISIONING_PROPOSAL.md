# HANOUTY manual stock adjustment — proposed opt-in authorization schema

**Status:** proposed for Architecture PR #95 review; not an approved V1 migration. Never create these tables in a real store automatically. Writer fails closed if tables are absent.

The Inventory PR #88 `MariaDbManualStockAuthorization` uses two InnoDB tables, both locked with `FOR UPDATE` inside the *same* transaction as article update and movement audit:

```sql
CREATE TABLE HANOUTY_AUTH_SESSIONS (
  SESSION_TOKEN VARCHAR(128) PRIMARY KEY,
  ACTOR_ID VARCHAR(128) NOT NULL,
  EXPIRES_AT DATETIME NOT NULL,
  REVOKED_AT DATETIME NULL
) ENGINE=InnoDB;
CREATE TABLE HANOUTY_ACTOR_GRANTS (
  ACTOR_ID VARCHAR(128) NOT NULL,
  PERMISSION_CODE VARCHAR(80) NOT NULL,
  EXPIRES_AT DATETIME NULL,
  REVOKED_AT DATETIME NULL,
  PRIMARY KEY (ACTOR_ID, PERMISSION_CODE)
) ENGINE=InnoDB;
```

Only `PERMISSION_CODE='ManualStockAdjustment'` grants manual stock write; ADMIN, MODIF_QTE and global MODIF_STOCK_MANUEL do not confer actor permissions. The authenticated session token must originate from a trusted login/session service, never from WPF-entered user labels or `StockAdjustmentPlan.UserId`. A real installer/security review must settle token generation/storage, token rotation, and session lifecycle before deployment; the disposable MariaDB test uses a fixture token **only**. Missing, expired, revoked or ambiguous rows deny.

Production manual adjustment remains disabled pending approved session issuance and V1 actor mapping. `ExecuteAuthorized` and `ApplyAuthorized` now require the disposable loopback database `logica_ci` on port 3307 AND the explicit acceptance-process marker `HANOUTY_MANUAL_STOCK_PROPOSAL_TEST_ONLY=YES`. The legacy SQL harness opts in only after checking its isolated connection, and clears the marker afterward. The marker is not a user grant: persisted current session/grant checks still apply. No WPF/production bootstrap registers or sets it.

Within that disposable proposal only, `ExecuteAuthorized` owns a manual-adjustment transaction and `ApplyAuthorized` participates in a manual caller-owned transaction. Checkout sale/return posting uses its existing `CheckoutStockWriter.Apply` and signed quantities; it calls neither manual entry point. Existing `Execute`/`Apply` stay disabled. Audit is a bounded legacy `TABLE_MOUVEMENTS_STOCK.LIBELLE` string with verified matching actor, before/after and reason; article lock, stale snapshot check, unique ID and savepoint protect atomicity. The schema is intentionally **not** auto-provisioned by the production code.

**Open Architecture decision:** approve/revise this proposed schema and specify authoritative session token issuance/revocation and secure storage. QA must selectively import the writer + application authorization models + disposable SQL acceptance, then verify exact-SHA CI. WPF is not yet wired; do not call this a released feature.

Provider hardening: grant-to-session actor joins use BINARY on both sides; both authorization tables must be InnoDB. Provider reads reject missing/nonlocal/detached/inactive contexts. Disposable regressions check exact actor identity under case-insensitive collation, session/grant row locks against concurrent revocation, revocation on next attempt, and rejection of either nontransactional table. No production schema migration or source-of-grant approval is implied. Architecture coordination: Issue #94 comment 6670523833.
