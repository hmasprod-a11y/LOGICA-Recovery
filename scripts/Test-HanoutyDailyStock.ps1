param(
    [Parameter(Mandatory=$true)][string]$MariaDbBin,
    [Parameter(Mandatory=$true)][string]$EvidenceDirectory,
    [string]$Dotnet = 'dotnet',
    [ValidateRange(1024,65535)][int]$Port = 33080
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$evidenceRoot = [IO.Path]::GetFullPath($EvidenceDirectory)
New-Item -ItemType Directory -Path $evidenceRoot -Force | Out-Null
foreach ($name in @('daily-stock-acceptance.json','daily-stock-overview.png','daily-stock-movements.png')) {
    $stale = Join-Path $evidenceRoot $name
    if (Test-Path -LiteralPath $stale -PathType Leaf) { Remove-Item -LiteralPath $stale -Force }
}
if (Get-NetTCPConnection -LocalPort $Port -State Listen -ErrorAction SilentlyContinue) { throw "Dedicated daily-stock test port$Port is occupied; no existing server will be changed." }
$bin = (Resolve-Path -LiteralPath $MariaDbBin).Path
foreach ($name in @('mariadb-install-db.exe','mariadbd.exe','mariadb.exe')) {
    if (-not (Test-Path -LiteralPath (Join-Path $bin $name) -PathType Leaf)) { throw "Verified MariaDB runtime is incomplete: $name" }
}
$taskRoot = Join-Path ([IO.Path]::GetTempPath()) ('HANOUTY-daily-stock-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $taskRoot | Out-Null
$data = Join-Path $taskRoot 'data'
$password = [Guid]::NewGuid().ToString('N')
$server = $null
$oldConnection = [Environment]::GetEnvironmentVariable('HANOUTY_DAILY_STOCK_CONNECTION','Process')
$oldMarker = [Environment]::GetEnvironmentVariable('HANOUTY_DAILY_STOCK_DISPOSABLE','Process')
$oldPort = [Environment]::GetEnvironmentVariable('HANOUTY_DAILY_STOCK_PORT','Process')
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
    & (Join-Path $bin 'mariadb.exe') --host=127.0.0.1 "--port=$Port" --user=root "--password=$password" '--execute=CREATE DATABASE daily_stock_ci CHARACTER SET utf8mb4'
    if ($LASTEXITCODE -ne 0) { throw 'Disposable daily-stock schema creation failed.' }
    $env:HANOUTY_DAILY_STOCK_CONNECTION = "Server=127.0.0.1;Port=$Port;Database=daily_stock_ci;Uid=root;Pwd=$password;SslMode=Disabled"
    $env:HANOUTY_DAILY_STOCK_DISPOSABLE = 'I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY'
    $env:HANOUTY_DAILY_STOCK_PORT = "$Port"
    & $Dotnet run --project (Join-Path $PSScriptRoot '../modernization/inventory/daily-stock-acceptance/DailyStockAcceptance.csproj') -c Release -- $evidenceRoot
    if ($LASTEXITCODE -ne 0) { throw 'Daily stock SQL and actual WPF acceptance failed.' }
    Write-Host 'PASS independent daily stock SQL and actual WPF acceptance on a dedicated disposable server.'
} finally {
    try { if ($null -ne $server -and -not $server.HasExited) { Stop-Process -Id $server.Id -ErrorAction Stop } }
    finally {
        [Environment]::SetEnvironmentVariable('HANOUTY_DAILY_STOCK_CONNECTION',$oldConnection,'Process')
        [Environment]::SetEnvironmentVariable('HANOUTY_DAILY_STOCK_DISPOSABLE',$oldMarker,'Process')
        [Environment]::SetEnvironmentVariable('HANOUTY_DAILY_STOCK_PORT',$oldPort,'Process')
    }
}
