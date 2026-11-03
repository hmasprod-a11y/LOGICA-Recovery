# Pure Inventory domain regression; no database, WinForms or store data.
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
if (-not (Test-Path $compiler)) { throw 'Windows .NET Framework compiler missing' }
$exe = Join-Path ([IO.Path]::GetTempPath()) ('hanouty-stock-plan-' + [Guid]::NewGuid().ToString('N') + '.exe')
try {
    & $compiler /nologo /target:exe "/out:$exe" (Join-Path $root 'recovered-source/LOGICA/Application/Inventory/StockAdjustmentPlan.cs') (Join-Path $PSScriptRoot 'test-stock-adjustment-plan.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Stock plan compile failed' }
    & $exe
    if ($LASTEXITCODE -ne 0) { throw 'Stock plan regression failed' }
} finally {
    Remove-Item -LiteralPath $exe -Force -ErrorAction SilentlyContinue
}
