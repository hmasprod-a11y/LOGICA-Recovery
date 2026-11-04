# HANOUTY Cell 05 — Exact-source integration acceptance checkpoint
Date: 2026-11-04. Owner: PR #93. This ledger is an evidence snapshot, not a release approval.

| Source | Exact reviewed SHA | Same-SHA CI | Integration claim |
|---|---|---|---|
| QA #93 baseline | be28ba04af2c772cc5937b198584d994ec47ed3f | 6/6 SUCCESS (41790241472, 41790241569, 41790241609, 41790241462, 41790241478, 41790241519) | Legacy gates only |
| Architecture #95 | 44ad1f29da09b1f7d28efaa35d0784753791d665 | 3/3 SUCCESS | Contracts alone not W1/W2 |
| WPF #96 | 116c95a2e0e180b050afa20cc733aea01fa023f9 | 3/3 SUCCESS | Host build alone not real MariaDB |
| Inventory #88 | a88f482e7075783c7a4cd5e6dc8f43af97005156 | 5/5 SUCCESS incl Windows 41785822929 | Legacy build gate unblocked; real catalogue adapter unproven |
| Checkout #75 | 62ec7fe1f88cd945b3f6700964c154ccc7f6d843 | 4 SUCCESS, Windows FAILED 41783412283; MariaDB 41783412402 SUCCESS | Do not integrate as green |

## Gate matrix (fail closed)
| Gate | State | Acceptance evidence still required |
|---|---|---|
| W0 | PENDING new QA exact-pair run | WPF preview compiled, executable, barcode/photo regression, extracted ZIP hashes on QA+WPF SHA; Windows Inventory green verified |
| W1 | BLOCKED | Actual WPF EXE reads disposable MariaDB catalogue via production adapter; all-products list, image-only tiles, duplicate barcodes, null photos |
| W2 | BLOCKED | WPF authorized cart and SOLDER, durable sale/payment/stock, double-click idempotency, rollback, restart and unknown-commit reconciliation on disposable MariaDB |
| W3 | BLOCKED | Countable V1 feature ledger and physical printer, labels, RDLC, native x86, cashier/permission acceptance |
| W4 | BLOCKED | Offline x64 installer, backup/restore, safe upgrade/rollback, local license and field acceptance |

## Integration safety / rollback
- No multi-branch merge performed; rollback point is QA baseline `be28ba04af2c772cc5937b198584d994ec47ed3f`.
- Review cross-branch API and source conflicts before composing one production tree. Never copy an independent mock into W1/W2 acceptance.
- No legacy production call sites removed by this QA checkpoint (count: 0). No live shop DB or license mutation.
- Open owner dependency: Checkout #75 Windows CI failure; WPF actual App.ResolveServices production MariaDB composition and Inventory concrete catalogue reader must be verified, not inferred.
- The current repository's root `AGENTS.md` was not retrievable from PR #95, PR #93 or main (GitHub 404); do not claim it was read.
