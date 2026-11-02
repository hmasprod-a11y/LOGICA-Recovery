# Isolated Windows MariaDB 10.11 regression for the PR84 additive article migration.
# Never connects to a shop database. Uses only the disposable CI service on 127.0.0.1:3307.
$ErrorActionPreference = 'Stop'
$bin = (Get-ChildItem (Join-Path $env:RUNNER_TEMP 'logica-mariadb/server') -Recurse -Filter mariadb.exe -File | Select-Object -First 1).Directory.FullName
if (-not $bin) { throw 'Isolated MariaDB client not found' }
$client = Join-Path $bin 'mariadb.exe'
$arguments = @('--host=127.0.0.1','--port=3307','--user=root','--password=logica-ci-only','--batch','--raw','--skip-column-names')
function Invoke-CiSql([string]$sql, [string]$database = '') {
    $args = @($arguments)
    if ($database) { $args += $database }
    $args += @('-e', $sql)
    $result = @(& $client @args 2>&1)
    if ($LASTEXITCODE -ne 0) { throw "Isolated MariaDB query failed: $($result -join ' | ')" }
    return @($result)
}
$source = 'logica_recovered_check'
$target = 'logica_pr84_schema_ci'
$sourceCount = @(Invoke-CiSql "SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA='$source' AND TABLE_NAME='TABLE_ARTICLES';")
if ($sourceCount.Count -ne 1 -or $sourceCount[0] -ne '1') { throw 'Recovered fixture missing: test-recovered-db.ps1 must run first' }
$originalColumns = @(Invoke-CiSql "SELECT COLUMN_NAME FROM information_schema.COLUMNS WHERE TABLE_SCHEMA='$source' AND TABLE_NAME='TABLE_ARTICLES' ORDER BY ORDINAL_POSITION;")
if ($originalColumns.Count -lt 5) { throw 'Recovered article fixture columns incomplete' }
$quoted = @($originalColumns | ForEach-Object { ([string][char]96) + $_.Replace([string][char]96, ([string][char]96)+([string][char]96)) + ([string][char]96) }) -join ','
function Get-OriginalDataDigest() {
    $rows = @(Invoke-CiSql "SELECT $quoted FROM TABLE_ARTICLES ORDER BY 1;" $target)
    $bytes = [Text.Encoding]::UTF8.GetBytes(($rows -join "`n"))
    $sha = [Security.Cryptography.SHA256]::Create()
    try { return [BitConverter]::ToString($sha.ComputeHash($bytes)).Replace('-','') }
    finally { $sha.Dispose() }
}
$script = (Resolve-Path 'input/migrations/20261102-article-add-compatibility.sql').Path.Replace('\\','/')
try {
    Invoke-CiSql "CREATE DATABASE $target CHARACTER SET utf8mb4;" | Out-Null
    Invoke-CiSql "CREATE TABLE $target`.TABLE_ARTICLES LIKE $source`.TABLE_ARTICLES; INSERT INTO $target`.TABLE_ARTICLES SELECT * FROM $source`.TABLE_ARTICLES;" | Out-Null
    $before = Get-OriginalDataDigest
    $rowCount = @(Invoke-CiSql 'SELECT COUNT(*) FROM TABLE_ARTICLES;' $target)[0]
    for ($pass = 1; $pass -le 2; $pass++) {
        $migration = @(& $client @arguments $target '-e' "source $script" 2>&1)
        if ($LASTEXITCODE -ne 0) { throw "PR84 schema migration failed on pass $pass : $($migration -join ' | ')" }
        $after = Get-OriginalDataDigest
        if ($after -ne $before) { throw "PR84 schema migration modified original article data on pass $pass" }
        if (@(Invoke-CiSql 'SELECT COUNT(*) FROM TABLE_ARTICLES;' $target)[0] -ne $rowCount) {
            throw "PR84 migration changed article row count on pass $pass"
        }
        foreach ($name in @('GROUPE','PRIX_QTE','PRIX_QTE_MIN','Taille','Couleur','Emplacement')) {
            $count = @(Invoke-CiSql "SELECT COUNT(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA='$target' AND TABLE_NAME='TABLE_ARTICLES' AND COLUMN_NAME='$name';")[0]
            if ($count -ne '1') { throw "PR84 migration did not create exactly one $name column on pass $pass" }
        }
        Write-Host "PASS: PR84 additive schema migration pass $pass preserved $rowCount recovered article rows and original columns"
    }
} finally {
    Invoke-CiSql "DROP DATABASE IF EXISTS $target;" | Out-Null
}
Write-Host 'PASS: isolated MariaDB article migration is idempotent and data-preserving'
