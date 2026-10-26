$ErrorActionPreference='Stop'
$dist=(Resolve-Path dist).Path
$bin=$env:LOGICA_MYSQL_BIN
$work=Join-Path $env:RUNNER_TEMP 'logica-backup-test'
New-Item -ItemType Directory -Force $work | Out-Null
$env:LOGICA_BACKUP_TEST_ROOT=$work
$env:LOGICA_DB_CONNECTION_STRING='Server=127.0.0.1;Port=3307;Database=logica_backup_test;Uid=root;Pwd=logica-ci-only;SslMode=None;CharSet=utf8mb4;Convert Zero Datetime=True;'
$csc=Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
& $csc /nologo /platform:x86 /target:exe /r:System.Windows.Forms.dll /r:System.Data.dll /r:System.Web.Extensions.dll "/r:$dist\LOGICA.exe" "/r:$dist\MySql.Data.dll" "/out:$dist\BackupCheck.exe" (Join-Path $PSScriptRoot 'test-database-backup.cs')
if($LASTEXITCODE -ne 0){throw 'Backup checker compilation failed'}
& $csc /nologo /target:exe /r:System.Core.dll "/out:$work\DumpShim.exe" (Join-Path $PSScriptRoot 'test-dump-shim.cs')
if($LASTEXITCODE -ne 0){throw 'Dump fault injector compilation failed'}
Copy-Item "$dist/LOGICA.exe.config" "$dist/BackupCheck.exe.config"
function Invoke-Check([string]$Mode) {
 $log=Join-Path (Resolve-Path results).Path "backup-$Mode.log"
 $errorLog=Join-Path (Resolve-Path results).Path "backup-$Mode.stderr.log"
 $p=Start-Process "$dist/BackupCheck.exe" -ArgumentList $Mode -WorkingDirectory $dist -RedirectStandardOutput $log -RedirectStandardError $errorLog -PassThru
 if(-not $p.WaitForExit(180000)){$p.Kill();throw "Backup $Mode timed out"}
 Get-Content $log | Select-String 'PASS|FAIL' | ForEach-Object {Write-Host $_}
 if($p.ExitCode -ne 0){throw "Backup $Mode failed; see diagnostic log"}
}
function Invoke-Client([int]$Port,[string]$Statement,[string]$Database='') {
 $databaseOption=@()
 if($Database){$databaseOption=@("--database=$Database")}
 & "$bin/mariadb.exe" @databaseOption --host=127.0.0.1 "--port=$Port" --user=root --password=logica-ci-only --default-character-set=utf8mb4 --abort-source-on-error -e $Statement
 if($LASTEXITCODE -ne 0){throw "Isolated database operation failed on port $Port"}
}
# The dedicated harness may run before POS/recovery tests prepare runtime files.
New-Item -ItemType Directory -Force "$dist/bd","$dist/tchak" | Out-Null
$startup=Get-Content input/original-startup.json -Raw | ConvertFrom-Json
foreach($entry in $startup.PSObject.Properties){[IO.File]::WriteAllText((Join-Path $dist $entry.Name),[string]$entry.Value)}
[IO.File]::WriteAllText("$dist/log_erreur.sni",'')
$secondary=$null
try {
 Invoke-Client 3307 'CREATE DATABASE logica_backup_test CHARACTER SET utf8mb4;'
 $original=(Resolve-Path input/recovered-original.sql).Path.Replace('\','/')
 $compat=(Resolve-Path input/mysql-compatibility.sql).Path.Replace('\','/')
 Invoke-Client 3307 "source $original" logica_backup_test
 Invoke-Client 3307 "source $compat" logica_backup_test
 Invoke-Check 'export'
 # Restore on another server using the SAME database name. Views and routines
 # may contain qualified references; a rename would hide or distort that test.
 $data=Join-Path $work 'restore-server'
 & "$bin/mariadb-install-db.exe" "--datadir=$data" --password=logica-ci-only --port=3309 *> (Join-Path $work 'install.log')
 if($LASTEXITCODE -ne 0){throw 'Isolated restore server initialization failed'}
 Add-Content "$data/my.ini" "`n[mysqld]`nbind-address=127.0.0.1"
 $secondary=Start-Process "$bin/mariadbd.exe" -ArgumentList @("--defaults-file=`"$data/my.ini`"",'--bind-address=127.0.0.1','--port=3309','--console') -RedirectStandardOutput (Join-Path $work 'server.log') -RedirectStandardError (Join-Path $work 'server.stderr.log') -PassThru
 $ready=$false
 for($i=0;$i -lt 60;$i++) {
  & "$bin/mariadb-admin.exe" --host=127.0.0.1 --port=3309 --user=root --password=logica-ci-only ping 2>$null | Out-Null
  if($LASTEXITCODE -eq 0){$ready=$true;break}
  Start-Sleep -Milliseconds 250
 }
 if(-not $ready){throw 'Isolated restore server did not start'}
 $dump=(Get-Content (Join-Path $work 'backup-path.txt') -Raw).Trim().Replace('\','/')
 Invoke-Client 3309 'CREATE DATABASE logica_backup_test CHARACTER SET utf8mb4;'
 Invoke-Client 3309 "source $dump" logica_backup_test
 Invoke-Check 'compare'
 Invoke-Check 'reset'
 $dump=(Get-Content (Join-Path $work 'concurrent-backup-path.txt') -Raw).Trim().Replace('\','/')
 Invoke-Client 3309 'DROP DATABASE logica_backup_test; CREATE DATABASE logica_backup_test CHARACTER SET utf8mb4;'
 Invoke-Client 3309 "source $dump" logica_backup_test
 Invoke-Check 'concurrent-restore'
 Copy-Item (Join-Path $work 'roundtrip-result.json') results/backup-roundtrip.json
 Write-Host 'PASS backup roundtrip, failure guards, original reset rollback and concurrent-write isolation'
} finally {
 if($secondary -and -not $secondary.HasExited){$secondary.Kill();$secondary.WaitForExit()}
 Remove-Item "$dist/BackupCheck.exe","$dist/BackupCheck.exe.config" -Force -ErrorAction SilentlyContinue
 # Backups contain shop snapshot data; only diagnostic summaries are artifacts.
 Remove-Item $work -Recurse -Force -ErrorAction SilentlyContinue
}
