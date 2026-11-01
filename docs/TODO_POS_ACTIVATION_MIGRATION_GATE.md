# TODO POS 2.0 — opt-in activation migration gate

This is an isolated **migration policy** in the portable .NET 10 licensing library,
not a change to the current Windows LOGICA.exe or existing shop licenses.

- Default (opt-in=false): return the legacy activation result unchanged.
- Opt-in=true, valid TODO license: accept TODO offline signature and allow startup.
- Opt-in=true, invalid or missing TODO license: retain existing valid legacy access;
  never erase, overwrite, or invalidate an existing customer license.
- Neither branch reads shop databases, modifies receipts, changes UI or connects to a server.
- Clock rollback on perpetual licenses is a non-blocking warning. Annual/trial
  licenses have a 72-hour grace after their signed expiration date.
- The future Windows host must keep legacy activation as the authority until
  its own .NET Framework adapter, customer migration, rollback and isolated
  Windows acceptance tests are complete. The .NET 10 library cannot be loaded
  directly by the .NET Framework 4.8 POS.
- A future Windows adapter must use a compatible verification implementation
  or a separate signed helper with a documented IPC threat model. Never copy
  the issuer private key into a customer installer.
- Do not infer user opt-in from presence of a file. Obtain explicit consent and
  keep a reversible migration state with a documented rollback.
