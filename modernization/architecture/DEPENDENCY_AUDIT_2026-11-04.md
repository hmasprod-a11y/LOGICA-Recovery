# Architecture dependency audit — 2026-11-04

## Exact source revisions inspected

- Architecture PR #95: `df3ccd8d4e1053cecd9a338e1cfae0fd1df8640f`
- WPF PR #96: `116c95a2e0e180b050afa20cc733aea01fa023f9`
- Inventory PR #88: `d1639cf0025a3def47f92cf2211a7eddbe4edafe`
- Checkout PR #75: `f130c72106ee7d69efb80c1050ad0bb1739a591c`
- QA PR #93: `372671f527423b9d5f177778e48435816473b973`

## Verified dependency edges (project files)

```text
Hanouty.WpfContractAdapter (net10.0-windows)
  -> Hanouty.ArchitectureBridge (net10.0)
  -> Hanouty.Desktop.Wpf (net10.0-windows, WinExe)

Hanouty.Inventory.MariaDb (net10.0)
  -> Hanouty.ArchitectureBridge (net10.0)
  -> MySql.Data 9.4.0 (package)
```

The arrow indentation above means **two independent references from Adapter**:
Adapter -> ArchitectureBridge and Adapter -> WPF. It does NOT mean
ArchitectureBridge -> WPF. WPF has no ProjectReference at the inspected SHA.
No project-reference cycle exists among these four projects. Adding WPF ->
Adapter would create a cycle and is forbidden.

The supervisor exclusively owns `modernization/Hanouty.Desktop.Bootstrap/`
and its integration workflow. This audit does not modify either.

## Build inclusion issue — handoff, not a concurrent W2 fix

ArchitectureBridge sets `EnableDefaultCompileItems=false` and explicitly
lists six C# files in its project file. It does **not** list
`AuthorizedCheckoutContract.cs`, despite the file existing in PR #95.
Consequently that W2 contract is not compiled into the bridge assembly by
the inspected project definition. Any test assertions against its types
would fail compilation if compiled by this project without inclusion.
Supervisor/Checkout own W2 closure: coordinate the fix before counting W2.

## Acceptance boundaries

- Project-reference graph inspection is static, not a successful combined build.
- PR mergeability flags are not proof of conflict-free integration against QA.
- No W1/W2 implementation, host, workflow, or store data was changed here.
