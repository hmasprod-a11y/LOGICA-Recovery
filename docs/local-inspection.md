# Verified local archive inspection — 2026-10-25

All observations were obtained from `Debug.zip` **without executing any contained program**.

| Item | Observation |
| --- | --- |
| ZIP entries | 653 |
| Main executable | `Debug/LOGICA.exe` — 32,237,056 bytes |
| Debug symbols | `Debug/LOGICA.pdb` — 3,554,816 bytes |
| XML documentation | `Debug/LOGICA.xml` — 26,826 bytes |
| Database library | `Debug/MySql.Data.dll` — 1,177,088 bytes |
| Main executable SHA-256 | `b72028316f36ece1e11bc22f2c9ead133a27ded0db3affcac8136ab0ca602497` |
| PDB header | `Microsoft C/C++ MSF 7.00` |
| XML member documentation | 149 entries: 62 types, 28 properties, 21 fields, 38 methods |

The XML documentation count is **not** the total number of methods/types in the assembly. An earlier Work session reported 227 types and 15,709 methods identified by REA; we have not independently reproduced that REA run here.

## Blockers
The present execution environment does not include `dotnet` or ILSpy and cannot resolve the official download host. No decompilation or build has succeeded here.

## Next run
On a Windows system with the .NET SDK and network access:
```powershell
./scripts/recover.ps1 -Archive 'C:\path\to\Debug.zip'
```
Inspect `extracted-private/source` locally and keep it out of this public repository until reviewed for credentials, proprietary code and licensing restrictions.
