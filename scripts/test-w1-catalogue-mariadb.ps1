# Requires a disposable, dedicated loopback MariaDB logica_ci on port 3307.
# Run ONLY on the combined Architecture #95 + Inventory #88 checkout; never a shop DB.
$ErrorActionPreference = 'Stop'
if (-not $env:HANOUTY_W1_TEST_DB) { throw 'HANOUTY_W1_TEST_DB is required (disposable loopback:3307/logica_ci)' }
$root = Split-Path $PSScriptRoot -Parent
$project = Join-Path $root 'modernization/inventory/Hanouty.Inventory.MariaDb.Tests/Hanouty.Inventory.MariaDb.Tests.csproj'
dotnet run --project $project --configuration Release
if ($LASTEXITCODE -ne 0) { throw 'W1 isolated MariaDB reader test failed' }
