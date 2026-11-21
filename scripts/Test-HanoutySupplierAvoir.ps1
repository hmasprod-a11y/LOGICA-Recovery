param(
    [Parameter(Mandatory=$true)][string]$MariaDbBin,
    [Parameter(Mandatory=$true)][string]$EvidenceDirectory,
    [string]$Dotnet = 'dotnet'
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
if (Get-NetTCPConnection -LocalPort 33079 -State Listen -ErrorAction SilentlyContinue) { throw 'Dedicated AVOIR test port33079 is occupied; no existing server will be changed.' }
$bin = (Resolve-Path -LiteralPath $MariaDbBin).Path
foreach ($name in @('mariadb-install-db.exe','mariadbd.exe','mariadb.exe')) {
    if (-not (Test-Path -LiteralPath (Join-Path $bin $name) -PathType Leaf)) { throw "Verified MariaDB runtime is incomplete: $name" }
}
$taskRoot = Join-Path ([IO.Path]::GetTempPath()) ('HANOUTY-avoir-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $taskRoot | Out-Null
$data = Join-Path $taskRoot 'data'
$password = [Guid]::NewGuid().ToString('N')
$server = $null
$oldConnection = [Environment]::GetEnvironmentVariable('HANOUTY_AVOIR_CONNECTION','Process')
$oldMarker = [Environment]::GetEnvironmentVariable('HANOUTY_AVOIR_DISPOSABLE','Process')
try {
    & (Join-Path $bin 'mariadb-install-db.exe') "--datadir=$data" "--password=$password" --port=33079 > (Join-Path $taskRoot 'initialize.log') 2>&1
    if ($LASTEXITCODE -ne 0) { throw "Could not initialize the dedicated disposable AVOIR database. See $taskRoot" }
    $server = Start-Process -FilePath (Join-Path $bin 'mariadbd.exe') -ArgumentList @("--defaults-file=`"$data/my.ini`"",'--bind-address=127.0.0.1','--port=33079') -WindowStyle Hidden -PassThru
    $ready = $false
    for ($attempt=0; $attempt -lt 30; $attempt++) {
        $listener = Get-NetTCPConnection -LocalPort 33079 -State Listen -ErrorAction SilentlyContinue
        if ($listener -and $listener.OwningProcess -eq $server.Id) { $ready = $true; break }
        if ($server.HasExited) { throw 'Disposable AVOIR server exited before readiness.' }
        Start-Sleep -Milliseconds 500
    }
    if (-not $ready) { throw 'Dedicated AVOIR database did not become ready.' }
    & (Join-Path $bin 'mariadb.exe') --host=127.0.0.1 --port=33079 --user=root "--password=$password" '--execute=CREATE DATABASE supplier_avoir_ci CHARACTER SET utf8mb4'
    if ($LASTEXITCODE -ne 0) { throw 'Disposable AVOIR schema creation failed.' }
    $env:HANOUTY_AVOIR_CONNECTION = "Server=127.0.0.1;Port=33079;Database=supplier_avoir_ci;Uid=root;Pwd=$password;SslMode=Disabled"
    $env:HANOUTY_AVOIR_DISPOSABLE = 'I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY'
    & $Dotnet run --project (Join-Path $PSScriptRoot '../modernization/inventory/supplier-avoir-acceptance/SupplierAvoirAcceptance.csproj') -c Release -- $EvidenceDirectory
    if ($LASTEXITCODE -ne 0) { throw 'Supplier AVOIR SQL/account/stock/recovery acceptance failed.' }
    & $Dotnet run --project (Join-Path $PSScriptRoot '../modernization/inventory/supplier-avoir-wpf-acceptance/SupplierAvoirWpfAcceptance.csproj') -c Release -- $EvidenceDirectory
    if ($LASTEXITCODE -ne 0) { throw 'Actual supplier AVOIR WPF/settlement acceptance failed.' }
    Write-Host 'PASS independent supplier AVOIR SQL and actual WPF acceptance on a dedicated disposable server.'
} finally {
    try { if ($null -ne $server -and -not $server.HasExited) { Stop-Process -Id $server.Id -ErrorAction Stop } }
    finally {
        [Environment]::SetEnvironmentVariable('HANOUTY_AVOIR_CONNECTION',$oldConnection,'Process')
        [Environment]::SetEnvironmentVariable('HANOUTY_AVOIR_DISPOSABLE',$oldMarker,'Process')
    }
}
