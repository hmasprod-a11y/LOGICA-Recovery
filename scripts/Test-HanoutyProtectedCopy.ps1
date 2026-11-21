param(
    [Parameter(Mandatory=$true)][string]$MariaDbBin,
    [Parameter(Mandatory=$true)][string]$EvidenceDirectory,
    [string]$Dotnet = 'dotnet',
    [ValidateRange(1024,65535)][int]$Port = 33082
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$evidenceRoot = [IO.Path]::GetFullPath($EvidenceDirectory)
New-Item -ItemType Directory -Path $evidenceRoot -Force | Out-Null
foreach ($name in @('protected-copy-acceptance.json','protected-copy-overview.png','protected-copy-movements.png')) {
    $stale = Join-Path $evidenceRoot $name
    if (Test-Path -LiteralPath $stale -PathType Leaf) { Remove-Item -LiteralPath $stale -Force }
}
if (Get-NetTCPConnection -LocalPort $Port -State Listen -ErrorAction SilentlyContinue) { throw "Dedicated protected-copy test port$Port is occupied; no existing server will be changed." }
$bin = (Resolve-Path -LiteralPath $MariaDbBin).Path
foreach ($name in @('mariadb-install-db.exe','mariadbd.exe','mariadb.exe')) {
    if (-not (Test-Path -LiteralPath (Join-Path $bin $name) -PathType Leaf)) { throw "Verified MariaDB runtime is incomplete: $name" }
}
$taskRoot = Join-Path ([IO.Path]::GetTempPath()) ('HANOUTY-protected-copy-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $taskRoot | Out-Null
$data = Join-Path $taskRoot 'data'
$password = 'copy-test-only'
$server = $null
$oldMarker = [Environment]::GetEnvironmentVariable('HANOUTY_COPY_DISPOSABLE','Process')
$oldPort = [Environment]::GetEnvironmentVariable('HANOUTY_COPY_PORT','Process')
try {
    & (Join-Path $bin 'mariadb-install-db.exe') "--datadir=$data" "--password=$password" "--port=$Port" > (Join-Path $taskRoot 'initialize.log') 2>&1
    if ($LASTEXITCODE -ne 0) { throw "Could not initialize the dedicated disposable daily-stock database. See $taskRoot" }
    $server = Start-Process -FilePath (Join-Path $bin 'mariadbd.exe') -ArgumentList @("--defaults-file=`"$data/my.ini`"",'--bind-address=127.0.0.1',"--port=$Port") -WindowStyle Hidden -PassThru
    $ready = $false
    for ($attempt=0; $attempt -lt 30; $attempt++) {
        $listener = Get-NetTCPConnection -LocalPort $Port -State Listen -ErrorAction SilentlyContinue
        if ($listener -and $listener.OwningProcess -eq $server.Id) { $ready = $true; break }
        if ($server.HasExited) { throw 'Disposable daily-stock server exited before readiness.' }
        Start-Sleep -Milliseconds 500
    }
    if (-not $ready) { throw 'Dedicated daily-stock database did not become ready.' }
    $env:HANOUTY_COPY_DISPOSABLE = 'I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY'
    $env:HANOUTY_COPY_PORT = "$Port"
    $repoRoot = [IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..'))
    & $Dotnet run --project (Join-Path $repoRoot 'modernization/protected-copy-acceptance/ProtectedCopyAcceptance.csproj') -c Release -- $repoRoot $bin (Join-Path $evidenceRoot 'backend')
    if ($LASTEXITCODE -ne 0) { throw 'Protected database copy acceptance failed.' }
    & $Dotnet run --project (Join-Path $repoRoot 'modernization/protected-copy-gui-acceptance/ProtectedCopyGuiAcceptance.csproj') -c Release -p:CheckoutProductionProject=../checkout-mariadb-production/CheckoutMariaDbProduction.csproj -- $repoRoot $bin (Join-Path $evidenceRoot 'gui')
    if ($LASTEXITCODE -ne 0) { throw 'Protected first-setup GUI and actual copied-profile sale failed.' }
    Write-Host 'PASS protected database/catalogue preparation, encrypted profile and actual cashier on its copy.'
} finally {
    if ($null -ne $server -and -not $server.HasExited) {
        $owned = Get-Process -Id $server.Id -ErrorAction SilentlyContinue
        if ($null -ne $owned -and $owned.Path -eq (Join-Path $bin 'mariadbd.exe')) { Stop-Process -Id $server.Id -ErrorAction Stop }
    }
    [Environment]::SetEnvironmentVariable('HANOUTY_COPY_DISPOSABLE',$oldMarker,'Process')
    [Environment]::SetEnvironmentVariable('HANOUTY_COPY_PORT',$oldPort,'Process')
}