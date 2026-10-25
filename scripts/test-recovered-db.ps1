$ErrorActionPreference='Stop'
$bin=(Get-ChildItem (Join-Path $env:RUNNER_TEMP 'logica-mariadb/server') -Recurse -Filter mariadb.exe | Select-Object -First 1).Directory.FullName
& "$bin/mariadb.exe" --host=127.0.0.1 --port=3307 --user=root --password=logica-ci-only -e 'CREATE DATABASE logica_recovered_check CHARACTER SET utf8mb4;'
if($LASTEXITCODE -ne 0){throw 'Recovery check database creation failed'}
# Use mysql source so PowerShell never decodes or changes the UTF-8 SQL stream.
$sql=(Resolve-Path input/recovered-original.sql).Path.Replace('\','/')
$compat=(Resolve-Path input/mysql-compatibility.sql).Path.Replace('\','/')
& "$bin/mariadb.exe" --host=127.0.0.1 --port=3307 --user=root --password=logica-ci-only --default-character-set=utf8mb4 logica_recovered_check -e "source $sql"
if($LASTEXITCODE -ne 0){throw 'Original Access snapshot import failed'}
& "$bin/mariadb.exe" --host=127.0.0.1 --port=3307 --user=root --password=logica-ci-only --default-character-set=utf8mb4 logica_recovered_check -e "source $compat"
if($LASTEXITCODE -ne 0){throw 'Additive schema compatibility migration failed'}
$dist=(Resolve-Path dist).Path
New-Item -ItemType Directory -Force "$dist/bd","$dist/tchak" | Out-Null
$settings=Get-Content input/original-startup.json -Raw | ConvertFrom-Json
foreach($p in $settings.PSObject.Properties){[IO.File]::WriteAllText((Join-Path $dist $p.Name),[string]$p.Value)}
[IO.File]::WriteAllText("$dist/log_erreur.sni",'')
$env:LOGICA_DB_CONNECTION_STRING='Server=127.0.0.1;Port=3307;Database=logica_recovered_check;Uid=root;Pwd=logica-ci-only;SslMode=None;Connection Timeout=5;'
$csc=Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
& $csc /nologo /platform:x86 /target:exe /r:System.Windows.Forms.dll /r:System.Data.dll "/out:$dist\RecoveredCheck.exe" (Join-Path $PSScriptRoot 'test-recovered-db.cs')
if($LASTEXITCODE -ne 0){throw 'Recovery checker compilation failed'}
Copy-Item dist/LOGICA.exe.config dist/RecoveredCheck.exe.config
$p=Start-Process "$dist/RecoveredCheck.exe" -WorkingDirectory $dist -RedirectStandardOutput results/recovered-database.log -RedirectStandardError results/recovered-database.stderr.log -PassThru
if(-not $p.WaitForExit(60000)){$p.Kill();throw 'Recovery startup timed out'}
Get-Content results/recovered-database.log | ForEach-Object{Write-Host $_}
Remove-Item dist/RecoveredCheck* -Force
if($p.ExitCode -ne 0){throw 'Recovered database verification failed'}
New-Item -ItemType Directory -Force dist/recovery | Out-Null
Copy-Item input/recovered-original.sql,input/mysql-compatibility.sql,input/database-inventory.json dist/recovery
