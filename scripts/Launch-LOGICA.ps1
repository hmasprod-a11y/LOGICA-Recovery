param([string]$ServerBin='', [int]$Port=3308, [switch]$VerifyOnly)
$ErrorActionPreference='Stop'
[Net.ServicePointManager]::SecurityProtocol=[Net.SecurityProtocolType]::Tls12
$root=$PSScriptRoot
$data=Join-Path $root 'bd/mysql-data'
$dbName='logica_recovered'
$credentialFile=Join-Path $root 'bd/mysql-credential.xml'
$marker=Join-Path $root 'bd/mysql-import-complete.txt'
$process=$null
$clientFile=$null
try {
 if(-not $ServerBin){
  $serverRoot=Join-Path $root 'bd/mysql-server'
  $server=Get-ChildItem $serverRoot -Recurse -Filter mariadbd.exe -ErrorAction SilentlyContinue | Select-Object -First 1
  if(-not $server){
   Write-Host 'Premier lancement : installation du serveur de base de donnees local...'
   New-Item -ItemType Directory -Force $serverRoot | Out-Null
   $archive=Join-Path $serverRoot 'server.zip'
   $baseUrl='https://archive.mariadb.org/mariadb-10.11.14/winx64-packages'
   Invoke-WebRequest "$baseUrl/mariadb-10.11.14-winx64.zip" -OutFile $archive -UseBasicParsing
   $checks=(Invoke-WebRequest "$baseUrl/sha256sums.txt" -UseBasicParsing).Content
   $line=($checks -split "`n" | Where-Object{$_ -match 'mariadb-10.11.14-winx64.zip\s*$'} | Select-Object -First 1)
   if(-not $line){throw 'Somme de controle du serveur introuvable'}
   $expected=($line.Trim() -split '\s+')[0]
   if((Get-FileHash $archive -Algorithm SHA256).Hash.ToLowerInvariant() -ne $expected.ToLowerInvariant()){throw 'Archive serveur : controle SHA256 incorrect'}
   Expand-Archive $archive $serverRoot -Force
   Remove-Item $archive
   $server=Get-ChildItem $serverRoot -Recurse -Filter mariadbd.exe | Select-Object -First 1
  }
  $ServerBin=$server.Directory.FullName
 }
 if(Test-Path $credentialFile){$credential=Import-Clixml $credentialFile}
 else {
  if(Test-Path "$data/mysql"){throw 'Des donnees existent sans identifiants locaux. Initialisation annulee pour les conserver.'}
  New-Item -ItemType Directory -Force (Join-Path $root 'bd') | Out-Null
  $password=[Guid]::NewGuid().ToString('N')+[Guid]::NewGuid().ToString('N')
  $credential=New-Object Management.Automation.PSCredential('root',(ConvertTo-SecureString $password -AsPlainText -Force))
  $credential | Export-Clixml $credentialFile
 }
 $password=$credential.GetNetworkCredential().Password
 if(-not (Test-Path "$data/mysql")){
  & "$ServerBin/mariadb-install-db.exe" "--datadir=$data" "--password=$password" "--port=$Port"
  if($LASTEXITCODE -ne 0){throw 'Initialisation du serveur local impossible'}
 }
 $clientFile=Join-Path $root 'bd/mysql-client-temporary.ini'
 [IO.File]::WriteAllText($clientFile,"[client]`nhost=127.0.0.1`nport=$Port`nuser=root`npassword=$password`ndefault-character-set=utf8mb4`n")
 $process=Start-Process "$ServerBin/mariadbd.exe" -ArgumentList @("--defaults-file=`"$data/my.ini`"",'--bind-address=127.0.0.1',"--port=$Port",'--console') -PassThru -NoNewWindow
 $ready=$false
 for($i=0;$i -lt 40;$i++){
  $probe=New-Object Net.Sockets.TcpClient
  try {$probe.Connect('127.0.0.1',$Port);$ready=$true} catch {} finally {$probe.Dispose()}
  if($ready){break}
  if($process.HasExited){throw 'Le serveur local ne peut pas demarrer. Verifier le port et le journal mysql.'}
  Start-Sleep -Milliseconds 500
 }
 if(-not $ready){throw 'Le serveur local ne repond pas'}
 if(-not (Test-Path $marker)){
  $existing=& "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" -N -B -e "SELECT COUNT(*) FROM information_schema.schemata WHERE schema_name='$dbName'"
  if($LASTEXITCODE -ne 0 -or @($existing).Count -ne 1 -or [string]$existing -notmatch '^[0-9]+{throw 'La base de recuperation existe deja sans marqueur. Aucun remplacement automatique ne sera effectue.'}
  & "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" -e "CREATE DATABASE $dbName CHARACTER SET utf8mb4"
  if($LASTEXITCODE -ne 0){throw 'Creation de la base de recuperation impossible'}
  foreach($file in @('recovered-original.sql','mysql-compatibility.sql')){
   $sql=(Join-Path $root "recovery/$file").Replace('\','/')
   & "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" --abort-source-on-error $dbName -e "source $sql"
   if($LASTEXITCODE -ne 0){throw "Import interrompu dans $file. Les fichiers et donnees existants sont conserves."}
  }
  [IO.File]::WriteAllText($marker,"Original snapshot imported without replacing an existing database. "+[DateTime]::UtcNow.ToString('o'))
 }
 $env:LOGICA_DB_CONNECTION_STRING="Server=127.0.0.1;Port=$Port;Database=$dbName;Uid=root;Pwd=$password;SslMode=None;Connection Timeout=10;"
 $counts=& "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" -N -B $dbName -e 'SELECT COUNT(*) FROM TABLE_ARTICLES; SELECT COUNT(*) FROM TABLE_VENTES_ENTETE;'
 if($LASTEXITCODE -ne 0 -or @($counts).Count -ne 2 -or @($counts | Where-Object { [string]$_ -notmatch '^[0-9]+ ('Base locale prete. Produits et tickets : '+($counts -join ', '))
 if($VerifyOnly){if([int]$counts[0] -ne 120 -or [int]$counts[1] -ne 11){throw 'Les nombres de lignes importees ne correspondent pas au fichier original'};Write-Host 'PASS portable launcher imports original database and preserves row counts'}
 else {Write-Host 'Demarrage de LOGICA...';Start-Process (Join-Path $root 'LOGICA.exe') -WorkingDirectory $root -Wait}
} catch {Write-Host ('ERREUR : '+$_.Exception.Message) -ForegroundColor Red;exit 1}
finally {
 if($process -and -not $process.HasExited -and $clientFile){
  & "$ServerBin/mariadb-admin.exe" "--defaults-extra-file=$clientFile" shutdown 2>$null | Out-Null
  if(-not $process.WaitForExit(15000)){Write-Host 'Le serveur termine encore ses ecritures. Ne pas supprimer son dossier.'}
 }
 if($clientFile -and (Test-Path $clientFile)){Remove-Item $clientFile -Force}
}
){throw 'La verification de la base locale a echoue. Aucun import automatique ne sera effectue.'}
  if([int]$existing -ne 0){throw 'La base de recuperation existe deja sans marqueur. Aucun remplacement automatique ne sera effectue.'}
  & "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" -e "CREATE DATABASE $dbName CHARACTER SET utf8mb4"
  if($LASTEXITCODE -ne 0){throw 'Creation de la base de recuperation impossible'}
  foreach($file in @('recovered-original.sql','mysql-compatibility.sql')){
   $sql=(Join-Path $root "recovery/$file").Replace('\','/')
   & "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" --abort-source-on-error $dbName -e "source $sql"
   if($LASTEXITCODE -ne 0){throw "Import interrompu dans $file. Les fichiers et donnees existants sont conserves."}
  }
  [IO.File]::WriteAllText($marker,"Original snapshot imported without replacing an existing database. "+[DateTime]::UtcNow.ToString('o'))
 }
 $env:LOGICA_DB_CONNECTION_STRING="Server=127.0.0.1;Port=$Port;Database=$dbName;Uid=root;Pwd=$password;SslMode=None;Connection Timeout=10;"
 $counts=& "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" -N -B $dbName -e 'SELECT COUNT(*) FROM TABLE_ARTICLES; SELECT COUNT(*) FROM TABLE_VENTES_ENTETE;'
 Write-Host ('Base locale prete. Produits et tickets : '+($counts -join ', '))
 if($VerifyOnly){if([int]$counts[0] -ne 120 -or [int]$counts[1] -ne 11){throw 'Les nombres de lignes importees ne correspondent pas au fichier original'};Write-Host 'PASS portable launcher imports original database and preserves row counts'}
 else {Write-Host 'Demarrage de LOGICA...';Start-Process (Join-Path $root 'LOGICA.exe') -WorkingDirectory $root -Wait}
} catch {Write-Host ('ERREUR : '+$_.Exception.Message) -ForegroundColor Red;exit 1}
finally {
 if($process -and -not $process.HasExited -and $clientFile){
  & "$ServerBin/mariadb-admin.exe" "--defaults-extra-file=$clientFile" shutdown 2>$null | Out-Null
  if(-not $process.WaitForExit(15000)){Write-Host 'Le serveur termine encore ses ecritures. Ne pas supprimer son dossier.'}
 }
 if($clientFile -and (Test-Path $clientFile)){Remove-Item $clientFile -Force}
}
 }).Count -gt 0){throw 'Verification authentifiee de la base locale impossible. LOGICA ne sera pas lance.'}
 Write-Host ('Base locale prete. Produits et tickets : '+($counts -join ', '))
 if($VerifyOnly){if([int]$counts[0] -ne 120 -or [int]$counts[1] -ne 11){throw 'Les nombres de lignes importees ne correspondent pas au fichier original'};Write-Host 'PASS portable launcher imports original database and preserves row counts'}
 else {Write-Host 'Demarrage de LOGICA...';Start-Process (Join-Path $root 'LOGICA.exe') -WorkingDirectory $root -Wait}
} catch {Write-Host ('ERREUR : '+$_.Exception.Message) -ForegroundColor Red;exit 1}
finally {
 if($process -and -not $process.HasExited -and $clientFile){
  & "$ServerBin/mariadb-admin.exe" "--defaults-extra-file=$clientFile" shutdown 2>$null | Out-Null
  if(-not $process.WaitForExit(15000)){Write-Host 'Le serveur termine encore ses ecritures. Ne pas supprimer son dossier.'}
 }
 if($clientFile -and (Test-Path $clientFile)){Remove-Item $clientFile -Force}
}
){throw 'La verification de la base locale a echoue. Aucun import automatique ne sera effectue.'}
  if([int]$existing -ne 0){throw 'La base de recuperation existe deja sans marqueur. Aucun remplacement automatique ne sera effectue.'}
  & "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" -e "CREATE DATABASE $dbName CHARACTER SET utf8mb4"
  if($LASTEXITCODE -ne 0){throw 'Creation de la base de recuperation impossible'}
  foreach($file in @('recovered-original.sql','mysql-compatibility.sql')){
   $sql=(Join-Path $root "recovery/$file").Replace('\','/')
   & "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" --abort-source-on-error $dbName -e "source $sql"
   if($LASTEXITCODE -ne 0){throw "Import interrompu dans $file. Les fichiers et donnees existants sont conserves."}
  }
  [IO.File]::WriteAllText($marker,"Original snapshot imported without replacing an existing database. "+[DateTime]::UtcNow.ToString('o'))
 }
 $env:LOGICA_DB_CONNECTION_STRING="Server=127.0.0.1;Port=$Port;Database=$dbName;Uid=root;Pwd=$password;SslMode=None;Connection Timeout=10;"
 $counts=& "$ServerBin/mariadb.exe" "--defaults-extra-file=$clientFile" -N -B $dbName -e 'SELECT COUNT(*) FROM TABLE_ARTICLES; SELECT COUNT(*) FROM TABLE_VENTES_ENTETE;'
 Write-Host ('Base locale prete. Produits et tickets : '+($counts -join ', '))
 if($VerifyOnly){if([int]$counts[0] -ne 120 -or [int]$counts[1] -ne 11){throw 'Les nombres de lignes importees ne correspondent pas au fichier original'};Write-Host 'PASS portable launcher imports original database and preserves row counts'}
 else {Write-Host 'Demarrage de LOGICA...';Start-Process (Join-Path $root 'LOGICA.exe') -WorkingDirectory $root -Wait}
} catch {Write-Host ('ERREUR : '+$_.Exception.Message) -ForegroundColor Red;exit 1}
finally {
 if($process -and -not $process.HasExited -and $clientFile){
  & "$ServerBin/mariadb-admin.exe" "--defaults-extra-file=$clientFile" shutdown 2>$null | Out-Null
  if(-not $process.WaitForExit(15000)){Write-Host 'Le serveur termine encore ses ecritures. Ne pas supprimer son dossier.'}
 }
 if($clientFile -and (Test-Path $clientFile)){Remove-Item $clientFile -Force}
}
