$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$framework = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319'
$compiler = Join-Path $framework 'csc.exe'
$visualBasic = Join-Path $framework 'Microsoft.VisualBasic.dll'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-domain-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $executable = Join-Path $temporary 'MonetaryRoundingTests.exe'
    & $compiler /nologo /platform:x86 /target:exe "/r:$visualBasic" "/out:$executable" (Join-Path $root 'recovered-source/LOGICA/Domain/MonetaryRounding.cs') (Join-Path $root 'tests/MonetaryRoundingTests.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Domain test compilation failed' }
    & $executable
    if ($LASTEXITCODE -ne 0) { throw 'Domain tests failed' }
} finally {
    # Only remove the exact files created by this invocation.
    Remove-Item -LiteralPath (Join-Path $temporary 'MonetaryRoundingTests.exe') -Force -ErrorAction SilentlyContinue
    Remove-Item -LiteralPath $temporary -ErrorAction SilentlyContinue
}
