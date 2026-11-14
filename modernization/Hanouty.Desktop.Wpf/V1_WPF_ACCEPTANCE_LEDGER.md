# HANOUTY V3.1 — V1 vs WPF acceptance ledger (Cell04)

Evidence: PR #96 source b2c3976c; QA Host acceptance is independently owned by PR #93. Implemented WPF interaction does NOT imply Windows/MariaDB acceptance.

| V1 area | WPF coverage | Independently accepted | Next proof |
| --- | --- | --- | --- |
| Sale | Partial: catalogue, search, barcode, variants, photos, selection, cash Commit | NO | Real WPF EXE/Host/MariaDB, trusted basket-to-SQL, Windows STA |
| Return | Not accepted | NO | Persisted original refund, durable identity, rollback |
| Payments | Partial: exact cash MAD, transient PIN review, Unknown reconciliation | NO | Real authorized tender, journal/SQL; other tenders unsupported |
| Inventory | Catalogue read-only; no accepted stock screens | NO | Transactional movements, adjustment authorization |
| Suppliers | Not accepted | NO | Purchases, receiving, costs |
| Clients | Not accepted | NO | Lookup, sale association |
| Reports | Not accepted | NO | Sales/stock reporting |
| Settings | RTL toggle only | NO | Offline configuration, register/users |
| Printing | Not accepted | NO | Receipt/label hardware and dimensions |

Count: 9/9 areas inventoried; 2/9 partial cashier flows (sale, payments); 1/9 read-only subset (inventory); 6/9 without accepted workflows; 0/9 independently proven commercially complete. Scanner textbox is NOT scanner hardware verification; printer hardware remains untested.

P0 acceptance: QA-owned production composition launches standalone WPF/net10 + local MariaDB + authenticated Host; select from WPF into trusted basket; exact-cash post; SQL readback and durable journal; Windows WPF STA tests on exact composed SHA. Unknown stays locked until durable result and authorized review; no sale replay, PIN storage, simulated fallback or real-shop mutation. LOGICA WinForms/net48 is a V1 behavior reference, NOT the final product.

Ownership: Cell04 WPF views/presentation/tests; QA Host/Bootstrap and Windows integration runner; Checkout/Architecture financial contracts. Generic LOGICA Windows build does not prove WPF STA or commercial readiness.
