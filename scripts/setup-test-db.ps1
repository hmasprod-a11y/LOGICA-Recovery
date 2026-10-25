$ErrorActionPreference='Stop'
$base=Join-Path $env:RUNNER_TEMP 'logica-mariadb'
New-Item -ItemType Directory -Force $base | Out-Null
$url='https://archive.mariadb.org/mariadb-10.11.14/winx64-packages/mariadb-10.11.14-winx64.zip'
Invoke-WebRequest $url -OutFile "$base/server.zip"
Invoke-WebRequest 'https://archive.mariadb.org/mariadb-10.11.14/winx64-packages/sha256sums.txt' -OutFile "$base/sha256sums.txt"
$hash=(Get-FileHash "$base/server.zip" -Algorithm SHA256).Hash.ToLowerInvariant()
$expected=(Get-Content "$base/sha256sums.txt" | Where-Object { $_ -match 'mariadb-10.11.14-winx64.zip$' }) -split '\s+'
if($hash -ne $expected[0]) { throw 'MariaDB package checksum mismatch' }
Expand-Archive "$base/server.zip" "$base/server"
$bin=(Get-ChildItem "$base/server" -Recurse -Filter mariadb-install-db.exe | Select-Object -First 1).Directory.FullName
$data="$base/data"
& "$bin/mariadb-install-db.exe" "--datadir=$data" --password=logica-ci-only --port=3307
if($LASTEXITCODE -ne 0) { throw 'Isolated database initialization failed' }
$p=Start-Process "$bin/mariadbd.exe" -ArgumentList @("--defaults-file=$data/my.ini",'--bind-address=127.0.0.1','--port=3307','--console') -PassThru -RedirectStandardOutput "$base/server.log" -RedirectStandardError "$base/server.stderr.log"
$ready=$false
for($i=0;$i -lt 30;$i++) {
 & "$bin/mariadb-admin.exe" --host=127.0.0.1 --port=3307 --user=root --password=logica-ci-only ping 2>$null
 if($LASTEXITCODE -eq 0){$ready=$true;break}
 Start-Sleep -Seconds 1
}
if(-not $ready){throw 'Isolated database did not start'}
& "$bin/mariadb.exe" --host=127.0.0.1 --port=3307 --user=root --password=logica-ci-only -e 'CREATE DATABASE logica_ci CHARACTER SET utf8mb4;'
if($LASTEXITCODE -ne 0){throw 'Test database creation failed'}
'LOGICA_DB_CONNECTION_STRING=Server=127.0.0.1;Port=3307;Database=logica_ci;Uid=root;Pwd=logica-ci-only;SslMode=None;Connection Timeout=5;' | Out-File $env:GITHUB_ENV -Append
Write-Host 'Isolated loopback database ready on port 3307'
