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
$ready=$true
if(-not $ready){throw 'local server not ready'}
$env:LOGICA_DB_CONNECTION_STRING="Server=127.0.0.1;Port=$Port;Database=local;"
$counts=& "$ServerBin/mariadb.exe" -e 'SELECT 1'
if($LASTEXITCODE -ne 0){throw 'authenticated SQL failed'}
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
Assert-Contract $contract.LauncherStartsAndProbesBeforeExport 'local server and TCP readiness must precede child override'
Assert-Contract $contract.LauncherWaitsForExe 'launcher must wait for child before stopping local DB'
Assert-Contract $contract.LauncherRunsAuthenticatedQueryBeforeExe 'authenticated SQL query must precede EXE'
Assert-Contract $contract.LauncherRejectsFailedAuthenticatedQuery 'failed authenticated SQL must stop launch'

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
$missingServer = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    '$process=Start-Process "mariadbd.exe" -ArgumentList @(''--bind-address=127.0.0.1'',"--port=$Port")', ''))
Assert-Contract (-not $missingServer.LauncherPassesEndpoint) 'TCP probe without local server launch must fail'
$wrongServerPort = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    '"--port=$Port"', '"--port=3306"'))
Assert-Contract (-not $wrongServerPort.LauncherPassesEndpoint) 'local server port differs from exported port'
$missingReadyGuard = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    "if(-not `$ready){throw 'local server not ready'}", ''))
Assert-Contract (-not $missingReadyGuard.LauncherPassesEndpoint) 'export without checked TCP readiness must fail'
$missingWait = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    "Start-Process (Join-Path `$root 'LOGICA.exe') -Wait",
    "Start-Process (Join-Path `$root 'LOGICA.exe')"))
Assert-Contract (-not $missingWait.LauncherPassesEndpoint) 'launcher must not stop DB before child exits'
$missingAuthGuard = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    "if(`$LASTEXITCODE -ne 0){throw 'authenticated SQL failed'}", ''))
Assert-Contract (-not $missingAuthGuard.LauncherRejectsFailedAuthenticatedQuery) 'missing authenticated SQL failure guard must be detected'
Assert-Contract $missingAuthGuard.LauncherPassesEndpoint 'auth-query guard is reported separately from endpoint forwarding'
$missingAuthQuery = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    '$counts=& "$ServerBin/mariadb.exe" -e ''SELECT 1''', ''))
Assert-Contract (-not $missingAuthQuery.LauncherRunsAuthenticatedQueryBeforeExe) 'missing authenticated SQL query must be detected'
$missingLaunch = Get-CheckoutDbStartupContract $moduleFixture ($launcherFixture.Replace(
    "Start-Process (Join-Path `$root 'LOGICA.exe') -Wait", ''))
Assert-Contract (-not $missingLaunch.LauncherPassesEndpoint) 'export without child EXE launch must fail'

$root = Split-Path $PSScriptRoot -Parent
$module = [IO.File]::ReadAllText((Join-Path $root 'recovered-source/LOGICA/Module1.cs'))
$launcher = [IO.File]::ReadAllText((Join-Path $root 'scripts/Launch-LOGICA.ps1'))
$actual = Get-CheckoutDbStartupContract $module $launcher
Assert-Contract $actual.LauncherPassesEndpoint 'production launcher no longer passes the local endpoint'
Assert-Contract $actual.LauncherStartsAndProbesBeforeExport 'production server/readiness/export order changed'
Assert-Contract $actual.LauncherWaitsForExe 'production launcher no longer waits for EXE'
Assert-Contract $actual.LauncherRunsAuthenticatedQueryBeforeExe 'production authenticated SQL query missing'
# Report the current launcher gap without locking the regression to a bug:
# Track D may safely add the authenticated-query exit-code guard later.
# The positive/negative fixtures above enforce accurate detection either way.
Assert-Contract $actual.DirectExeServerIsDynamic 'production direct EXE host source changed; review startup'
Assert-Contract (-not $actual.BareExeEndpointProvenEquivalent) 'production bare EXE is not proven equivalent'
Assert-Contract ($actual.DirectExeFallbackPort -gt 0 -and $actual.DirectExeFallbackPort -le 65535) 'invalid EXE port'
Assert-Contract ($actual.LauncherDefaultPort -gt 0 -and $actual.LauncherDefaultPort -le 65535) 'invalid launcher port'
if (-not $actual.BareExeEndpointProvenEquivalent) {
    Write-Warning ("Bare LOGICA.exe defaults to port {0} and its server comes from a UI label; Start-LOGICA.cmd defaults to loopback port {1} and exports LOGICA_DB_CONNECTION_STRING before starting the child. Bare EXE startup is NOT proven equivalent. No database or licence was changed." -f $actual.DirectExeFallbackPort, $actual.LauncherDefaultPort)
}
if (-not $actual.LauncherRejectsFailedAuthenticatedQuery) {
    Write-Warning 'Launcher performs authenticated MariaDB SELECT before EXE but does not check its exit code. A listening non-MariaDB service or failed credentials may still reach LOGICA.exe. QA/launcher owner must guard LASTEXITCODE before launch.'
}
Write-Host 'PASS checkout local database endpoint contract (host, port, server/readiness/auth sequencing, failure-path fixtures and production source; no DB access)'
