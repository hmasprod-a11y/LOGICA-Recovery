$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
. (Join-Path $PSScriptRoot 'CheckoutDbStartupContract.ps1')

function Assert-Contract([bool]$condition, [string]$message) {
    if (-not $condition) { throw "Checkout startup contract regression: $message" }
}
$moduleFixture = @'
_PORT_DB = "3306";
cn_SQL = new MySqlConnection(Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING") ?? new MySqlConnectionStringBuilder { Port = uint.Parse(_PORT_DB) }.ConnectionString);
'@
$launcherFixture = @'
param([int]$Port=3308)
$env:LOGICA_DB_CONNECTION_STRING="Server=127.0.0.1;Port=$Port;"
'@
$contract = Get-CheckoutDbStartupContract $moduleFixture $launcherFixture
Assert-Contract ($contract.DirectExeFallbackPort -eq 3306) 'direct fallback port parsing'
Assert-Contract ($contract.LauncherDefaultPort -eq 3308) 'launcher port parsing'
Assert-Contract (-not $contract.BareExeMatchesLauncher) 'bare EXE mismatch detection'
Assert-Contract $contract.LauncherPassesEndpoint 'launcher environment inheritance contract'
$matching = Get-CheckoutDbStartupContract ($moduleFixture.Replace('3306','3308')) $launcherFixture
Assert-Contract $matching.BareExeMatchesLauncher 'matching endpoints must not be reported as mismatch'
$missingOverride = Get-CheckoutDbStartupContract ($moduleFixture.Replace('Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING")','Environment.GetEnvironmentVariable("OTHER")')) $launcherFixture
Assert-Contract (-not $missingOverride.LauncherPassesEndpoint) 'missing inherited override must fail contract'
$missingExport = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace('$env:LOGICA_DB_CONNECTION_STRING=','$env:OTHER='))
Assert-Contract (-not $missingExport.LauncherPassesEndpoint) 'missing launcher export must fail contract'

$root = Split-Path $PSScriptRoot -Parent
$module = [IO.File]::ReadAllText((Join-Path $root 'recovered-source/LOGICA/Module1.cs'))
$launcher = [IO.File]::ReadAllText((Join-Path $root 'scripts/Launch-LOGICA.ps1'))
$actual = Get-CheckoutDbStartupContract $module $launcher
Assert-Contract $actual.LauncherPassesEndpoint 'production launcher and EXE no longer share the override'
Assert-Contract ($actual.DirectExeFallbackPort -gt 0 -and $actual.DirectExeFallbackPort -le 65535) 'invalid EXE port'
Assert-Contract ($actual.LauncherDefaultPort -gt 0 -and $actual.LauncherDefaultPort -le 65535) 'invalid launcher port'
if (-not $actual.BareExeMatchesLauncher) {
    Write-Warning ("Bare LOGICA.exe defaults to port {0}; Start-LOGICA.cmd defaults to port {1} and supplies LOGICA_DB_CONNECTION_STRING. Bare EXE startup is NOT equivalent to launcher startup. No database or licence was changed." -f $actual.DirectExeFallbackPort, $actual.LauncherDefaultPort)
}
Write-Host 'PASS checkout local database endpoint contract (4 synthetic cases + production source characterization; no DB access)'
