# Real local MariaDB cash posting

This .NET 10 production library exposes the existing Architecture financial and operation-journal ports through `MariaDbCashCheckoutServices`. The acceptance executable references this library; it no longer recompiles replacement writers.

Provide the reviewed Architecture project at `ArchitectureProject` (default is the exact checkout supplied by the existing financial workflow). The host supplies an explicit local connection factory, a two-digit workstation and a transient PIN provider. No default PIN, schema creation, licensing change or automatic registration exists.

The preparation authenticates against the existing `TABLE_PASS(ListUser,ListPass,Catégorie)` on the caller's active transaction. It accepts the original sales roles ADMIN/MANAGER/UTILISATEUR, rejects ambiguous/unknown identities, locks and verifies the existing workstation basket and article records, and requires all affected tables to be InnoDB. It validates quantities, standard PRIX_V_1, costs, tax and per-line totals against the requested envelope; it never trusts UI prices.

## Accepted implementation slice

Anonymous MAD cash sale, exact tender, standard price, no promotion/tier/manual discount, existing correctly priced basket, one supported original ticket-sequence row. The same production ticket, journal, payment, stock, movement and completion writers execute in one transaction with the existing operation claim. Header/payment/journal values are parameterized; decimal conversion preserves VB input conversion while avoiding culture-dependent SQL literals. Receipt staging verifies the persisted receipt inside the transaction; physical printing is a separate post-commit/peripheral gate.

Unsupported policies fail closed in this new slice. They remain available through the unchanged characterized legacy host; this is not V1 parity, WPF production registration, a licensing gate or commercial acceptance. Currency/tier/discount/return/change/customer behavior must be extended only with parity evidence.

## Verification

The existing `checkout-mariadb-boundary` executable uses real disposable TABLE_PASS, article prices and basket rows with this production preparation/factory. Tests cover invalid/injection-shaped PIN, wrong cashier/category, stale price, underpayment, unsupported promotion, remote endpoint, nontransactional table, failure after actual payment insertion with complete rollback, quoted names and exact decimal persistence under fr-FR/en-US, and duplicate suppression. No live store schema or credentials are used.
