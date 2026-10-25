# LOGICA Recovery

Recovery workspace for an existing VB.NET Windows Forms POS program.

## Verified locally
- Provided archive: `Debug.zip`, 653 ZIP entries.
- Main program: `Debug/LOGICA.exe` with accompanying `LOGICA.pdb` and `LOGICA.xml`.
- Original Visual Studio project file is not included.
- An earlier Work session *reported* 227 types and 15,709 methods from REA, but this has not been reproduced in this chat.

## Recovery workflow
1. Keep `Debug.zip` and all binaries **off GitHub**.
2. On Windows, install .NET SDK + ILSpy command line tool and run `scripts/recover.ps1 -Archive <path to Debug.zip>`.
3. Keep extracted code in `extracted-private/`, which is ignored by git.
4. Review all decompiled sources for secrets and third-party code before sharing.
5. Reconstruct Windows Forms resources/dependencies; test compile under .NET Framework 4.8, ideally with Windows Visual Studio build tools.
6. Use [REA](https://github.com/morluto/rea) separately for program structure exploration.

**This repo is PUBLIC.** Do not commit executables, PDBs, archives, dumps, raw recovered source, or credentials without careful review. Making the repository private later will not retract previously copied information.

Status: extraction and rebuild not yet verified.
