param(
    [int]$Port = 3306,
    [string]$DbPassword = '1234',
    [switch]$RebuildTests
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest

$root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
Push-Location $root
try {
    # 1. Ensure local MariaDB is running on $Port
    $tcp = New-Object System.Net.Sockets.TcpClient
    $running = $false
    try {
        $ar = $tcp.BeginConnect('127.0.0.1', $Port, $null, $null)
        $running = $ar.AsyncWaitHandle.WaitOne(500, $false) -and $tcp.Connected
    } catch { $running = $false } finally { $tcp.Dispose() }

    $mdbBinDir = Get-ChildItem 'C:\Program Files\MariaDB*\bin' -ErrorAction SilentlyContinue | Select-Object -First 1 -ExpandProperty FullName
    if (-not $mdbBinDir) {
        throw 'MariaDB not found in C:\Program Files\MariaDB*\bin. Install MariaDB 10.11+ first.'
    }
    $mariadbExe = Join-Path $mdbBinDir 'mariadb.exe'
    $mariadbdExe = Join-Path $mdbBinDir 'mariadbd.exe'
    $installDbExe = Join-Path $mdbBinDir 'mariadb-install-db.exe'

    if (-not $running) {
        $dataDir = Join-Path $env:LOCALAPPDATA 'HANOUTY-Dev\mariadb-data'
        if (-not (Test-Path $dataDir)) {
            Write-Host 'Initializing local MariaDB dev data directory...' -ForegroundColor Cyan
            & $installDbExe "--datadir=$dataDir" "--password=$DbPassword"
            if ($LASTEXITCODE -ne 0) { throw 'mariadb-install-db.exe failed.' }
        }
        Write-Host "Starting local MariaDB on port $Port..." -ForegroundColor Cyan
        Start-Process -FilePath $mariadbdExe -ArgumentList "--datadir=$dataDir", "--port=$Port" -WindowStyle Hidden
        $ready = $false
        for ($i = 0; $i -lt 20; $i++) {
            Start-Sleep -Milliseconds 500
            & $mariadbExe --host=127.0.0.1 "--port=$Port" -u root "-p$DbPassword" -e 'SELECT 1;' 2>$null | Out-Null
            if ($LASTEXITCODE -eq 0) { $ready = $true; break }
        }
        if (-not $ready) { throw "MariaDB did not start on port $Port." }
    }

    # 2. Ensure hanouty_dev schema and seed data exist
    $dbExists = (& $mariadbExe --host=127.0.0.1 "--port=$Port" -u root "-p$DbPassword" -N -B -e "SHOW DATABASES LIKE 'hanouty_dev';")
    if (-not $dbExists) {
        Write-Host 'Creating hanouty_dev database from recovered-original.sql + migrations...' -ForegroundColor Cyan
        $sqlParts = [System.Collections.Generic.List[string]]::new()
        $sqlParts.Add("CREATE DATABASE IF NOT EXISTS hanouty_dev CHARACTER SET utf8mb4; USE hanouty_dev; SET SESSION sql_mode='NO_AUTO_VALUE_ON_ZERO';")
        $sqlParts.Add([IO.File]::ReadAllText((Join-Path $root 'input\recovered-original.sql'), [Text.UTF8Encoding]::new($false)))
        foreach ($mig in (Get-ChildItem (Join-Path $root 'input\migrations\*.sql') | Sort-Object Name)) {
            $sqlParts.Add([IO.File]::ReadAllText($mig.FullName, [Text.UTF8Encoding]::new($false)))
        }
        $sqlParts.Add("INSERT IGNORE INTO TABLE_NUM (ID,CL,CLIENT,INV,BC,BR,BS) VALUES (0,0,0,0,0,0,0);")
        $sqlParts.Add("INSERT IGNORE INTO TABLE_PARAMETRES (OBJET,VALEUR) VALUES ('MODELE_TICKET','FR_3C'),('BRANCHEMENT','USB'),('AFFICHER_MODE_P','True'),('AFFICHER_N_TICKET','True'),('AFFICHER_CODE_BARRE','True'),('PIED_TICKET','HANOUTY DEV'),('FENETRE_MODE_P','True');")
        $sqlParts.Add("INSERT IGNORE INTO TABLE_MODE_P (MODE_P,Images) VALUES ('ESPECES','0'),('CARTE','0');")
        $sqlParts.Add("INSERT IGNORE INTO TABLE_FAMILLES (Famille) VALUES ('Epicerie'),('Boissons');")
        $sqlParts.Add("INSERT IGNORE INTO TABLE_ARTICLES (ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,PRIX_V_2,STOCK,Alert,TAUX_TVA,PROMOTION,Images,VISIBLE,TYPE) VALUES ('D1','1001','Lait 1L','Epicerie',4.5,4.5,6,6,100,5,0,0,'0','OUI','ARTICLE'),('D2','1002','Eau 1.5L','Boissons',3,3,5,5,100,5,0,0,'0','OUI','ARTICLE');")

        $tempSql = Join-Path $env:TEMP ('hanouty-dev-init-' + [guid]::NewGuid().ToString('N') + '.sql')
        [IO.File]::WriteAllText($tempSql, ($sqlParts -join "`n"), [Text.UTF8Encoding]::new($false))
        try {
            & $mariadbExe --default-character-set=utf8mb4 --host=127.0.0.1 "--port=$Port" -u root "-p$DbPassword" -e "source $($tempSql.Replace('\','/'))"
            if ($LASTEXITCODE -ne 0) { throw 'Failed to initialize hanouty_dev database.' }
        } finally {
            if (Test-Path $tempSql) { Remove-Item $tempSql -Force -ErrorAction SilentlyContinue }
        }
    }

    # 3. Optional tests
    if ($RebuildTests) {
        & powershell -NoProfile -ExecutionPolicy Bypass -File (Join-Path $root 'scripts\Invoke-HanoutyWindowsPipeline.ps1') -SkipInstaller
        if ($LASTEXITCODE -ne 0) { throw 'Pipeline tests failed.' }
    }

    # 4. Launch HANOUTY POS directly to PIN screen (PIN: 0000 for LE PATRON / ADMIN)
    $devDataDir = Join-Path $env:LOCALAPPDATA 'HANOUTY-Dev\app-data'
    New-Item -ItemType Directory -Path (Join-Path $devDataDir 'bd\images') -Force | Out-Null
    $env:HANOUTY_CATALOGUE_CONNECTION = "Server=127.0.0.1;Port=$Port;Database=hanouty_dev;Uid=root;Pwd=$DbPassword;SslMode=Disabled;"
    $env:HANOUTY_DATA_DIRECTORY = $devDataDir
    $env:HANOUTY_WORKSTATION = '01'

    Write-Host 'Launching HANOUTY POS (PIN: 0000 = LE PATRON / ADMIN)...' -ForegroundColor Green
    & dotnet run --project (Join-Path $root 'modernization\Hanouty.Desktop.Bootstrap\Hanouty.Desktop.Bootstrap.csproj') -c Release
}
finally {
    Pop-Location
}
