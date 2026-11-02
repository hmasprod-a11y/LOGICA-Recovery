$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
. (Join-Path $PSScriptRoot 'CheckoutDbStartupContract.ps1')

function Assert-Contract([bool]$condition, [string]$message) {
    if (-not $condition) { throw "Checkout startup contract regression: $message" }
}
$moduleFixture = @'
_CHEMIN_DB = MyProject.Forms.Form_0_TEMPLATE.Label_DB.Text;
_PORT_DB = "3306";
cn_SQL = new MySqlConnection(Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING") ?? new MySqlConnectionStringBuilder { Server = _CHEMIN_DB, Port = uint.Parse(_PORT_DB) }.ConnectionString);
'@
$launcherFixture = @'
param([int]$Port=3308)
$process=Start-Process "mariadbd.exe" -ArgumentList @('--bind-address=127.0.0.1',"--port=$Port")
$probe.Connect('127.0.0.1',$Port)
$env:LOGICA_DB_CONNECTION_STRING="Server=127.0.0.1;Port=$Port;Database=local;"
Start-Process (Join-Path $root 'LOGICA.exe') -Wait
'@
$contract = Get-CheckoutDbStartupContract $moduleFixture $launcherFixture
Assert-Contract ($contract.DirectExeFallbackPort -eq 3306) 'direct fallback port parsing'
Assert-Contract ($contract.LauncherDefaultPort -eq 3308) 'launcher port parsing'
Assert-Contract (-not $contract.BareExeMatchesLauncher) 'bare EXE port mismatch detection'
Assert-Contract $contract.DirectExeServerIsDynamic 'direct EXE fallback host is a UI label'
Assert-Contract (-not $contract.BareExeEndpointProvenEquivalent) 'dynamic EXE host cannot be assumed loopback'
Assert-Contract $contract.LauncherPassesEndpoint 'launcher must export loopback endpoint before child EXE'
Assert-Contract $contract.LauncherStartsExeAfterExport 'launcher export must precede EXE start'
Assert-Contract $contract.LauncherUsesLoopbackEndpoint 'launcher must bind, probe and export same loopback host'

$matching = Get-CheckoutDbStartupContract ($moduleFixture.Replace('3306','3308')) $launcherFixture
Assert-Contract $matching.BareExeMatchesLauncher 'matching ports must be reported'
Assert-Contract (-not $matching.BareExeEndpointProvenEquivalent) 'matching ports do not prove same server'
$literal = Get-CheckoutDbStartupContract ($moduleFixture.Replace(
    '_CHEMIN_DB = MyProject.Forms.Form_0_TEMPLATE.Label_DB.Text;', '').Replace(
    'Server = _CHEMIN_DB', 'Server = "127.0.0.1"').Replace('3306','3308')) $launcherFixture
Assert-Contract $literal.BareExeEndpointProvenEquivalent 'literal loopback plus matching port proves same fallback endpoint'

$missingOverride = Get-CheckoutDbStartupContract ($moduleFixture.Replace(
    'Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING")',
    'Environment.GetEnvironmentVariable("OTHER")')) $launcherFixture
Assert-Contract (-not $missingOverride.LauncherPassesEndpoint) 'missing inherited override must fail'
$missingExport = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    '$env:LOGICA_DB_CONNECTION_STRING=', '$env:OTHER='))
Assert-Contract (-not $missingExport.LauncherPassesEndpoint) 'missing launcher export must fail'
# Construct the true out-of-order case without interpreting fixture variables.
$lateFixture = [regex]::Replace($launcherFixture,
    '(?m)^[ \t]*\$env:LOGICA_DB_CONNECTION_STRING[^\r\n]*(\r?\n)?', '')
$lateFixture += "`n" + '$env:LOGICA_DB_CONNECTION_STRING="Server=127.0.0.1;Port=$Port;Database=local;"'
$late = Get-CheckoutDbStartupContract $moduleFixture $lateFixture
Assert-Contract (-not $late.LauncherPassesEndpoint -and -not $late.LauncherStartsExeAfterExport) 'export after EXE must fail'
$wrongServer = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    'Server=127.0.0.1;', 'Server=192.0.2.1;'))
Assert-Contract (-not $wrongServer.LauncherPassesEndpoint) 'remote connection string must fail'
$wrongBind = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    '--bind-address=127.0.0.1', '--bind-address=0.0.0.0'))
Assert-Contract (-not $wrongBind.LauncherPassesEndpoint) 'non-loopback bind must fail'
$wrongProbe = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    "Connect('127.0.0.1',", "Connect('localhost',"))
Assert-Contract (-not $wrongProbe.LauncherPassesEndpoint) 'different readiness probe host must fail'
$missingLaunch = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    "Start-Process (Join-Path `$root 'LOGICA.exe') -Wait", ''))
Assert-Contract (-not $missingLaunch.LauncherPassesEndpoint) 'export without child EXE launch must fail'

$root = Split-Path $PSScriptRoot -Parent
$module = [IO.File]::ReadAllText((Join-Path $root 'recovered-source/LOGICA/Module1.cs'))
$launcher = [IO.File]::ReadAllText((Join-Path $root 'scripts/Launch-LOGICA.ps1'))
$actual = Get-CheckoutDbStartupContract $module $launcher
Assert-Contract $actual.LauncherPassesEndpoint 'production launcher no longer passes the local endpoint'
Assert-Contract $actual.DirectExeServerIsDynamic 'production direct EXE host source changed; review startup'
Assert-Contract (-not $actual.BareExeEndpointProvenEquivalent) 'production bare EXE is not proven equivalent'
Assert-Contract ($actual.DirectExeFallbackPort -gt 0 -and $actual.DirectExeFallbackPort -le 65535) 'invalid EXE port'
Assert-Contract ($actual.LauncherDefaultPort -gt 0 -and $actual.LauncherDefaultPort -le 65535) 'invalid launcher port'
if (-not $actual.BareExeEndpointProvenEquivalent) {
    Write-Warning ("Bare LOGICA.exe defaults to port {0} and its server comes from a UI label; Start-LOGICA.cmd defaults to loopback port {1} and exports LOGICA_DB_CONNECTION_STRING before starting the child. Bare EXE startup is NOT proven equivalent. No database or licence was changed." -f $actual.DirectExeFallbackPort, $actual.LauncherDefaultPort)
}
Write-Host 'PASS checkout local database endpoint contract (host, port, export ordering, 9 negative/positive fixtures and production source; no DB access)'
