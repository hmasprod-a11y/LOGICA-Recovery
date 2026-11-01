# TODO POS 2.0 — identity and offline licensing design (prototype)

**Product name:** TODO POS 2.0. The name evokes both "everything" and the English
"to do" (what needs doing). The recovered LOGICA POS remains the known-good Windows
baseline. This document **does not authorize renaming or modifying the current shop
executable**, altering customer databases, or bypassing any existing activation.

## License architecture (no vendor-hosted server)

- Separate .NET 10 prototype: `modernization/TODO.Licensing`, issuer CLI and tests.
- ECDSA P-256 / SHA-256 signatures. Only the public verification key belongs in a
  future customer runtime; the private issuer key remains exclusively with the owner.
- Offline issuer supports perpetual licenses and licenses with UTC expiration dates,
  optional hashed device binding, editions and seat counts. All validation is local.
- License is a signed JSON envelope; signature covers the exact UTF-8 payload bytes.
  A 128-bit public-key identifier allows future key rotation and a trusted-key registry.
- No network, account, cloud database, telemetry, hosting bill or recurring
  licensing infrastructure is required. This is not a guarantee of zero support,
  distribution, code-signing or Windows Store expenses.

## Prototype commands (on a private .NET 10 machine)

```powershell
dotnet run --project modernization/TODO.Licensing.Issuer -- keygen ./issuer-private.pem
dotnet run --project modernization/TODO.Licensing.Issuer -- issue ./issuer-private.pem <guid> Standard 1 never ./client.license.json
dotnet run --project modernization/TODO.Licensing.Issuer -- verify ./issuer-private.pem.pub.pem ./client.license.json
dotnet run --project modernization/TODO.Licensing.Tests
pwsh -File scripts/test-todo-license-cli.ps1
```

Never commit `issuer-private.pem`, a customer license, hardware identifiers, or
shop credentials. Store the private key in an encrypted offline backup, restrict file
permissions, and keep it away from the customer installer. CLI refuses to overwrite
an existing private key or license. Use an approved customer device identifier,
hash it locally, and transfer **only its SHA-256 digest** when device binding is needed.

## Known offline limitations

Without an online authority, an already-issued valid license cannot be revoked
instantly on an offline machine. Clock rollback resistance is best-effort at most;
a fully offline application cannot reliably prove current time or prevent binary
patching. Device-bound licenses require a documented, privacy-preserving transfer
policy for hardware changes and support recovery. A signature verifies authenticity
of the license, not that the POS executable itself has not been patched.

## Rollout gate — not yet implemented

1. Keep LOGICA installation and license working unchanged; finish independent
   cryptographic and CLI tests on Linux and Windows.
2. Review ownership of the original code/assets and legal rights to change product
   identity and license terms. Select edition names, support policy and public-key
   rotation strategy.
3. Design an explicit opt-in migration from the original activation to TODO POS,
   with backup/rollback, license transfer and tests against isolated copies of
   real-world store data. **Never silently invalidate existing paid licenses.**
4. Only then wire a public-key verifier into the Windows product, rename binaries,
   branding, installer, manuals, help and user-facing screens. No issuer private key
   may ship with the app. Keep a separate Windows .NET Framework compatibility
   adapter until migration is validated.
5. Treat web and Microsoft Store as future distribution targets, not as a claim
   that the recovered .NET Framework 4.8 / Bunifu POS is already portable.

The prototype is not integrated into the current LOGICA.exe, and should not be
used as evidence that the new activation has been deployed to customers.
