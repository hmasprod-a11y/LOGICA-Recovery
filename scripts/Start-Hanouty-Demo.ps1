param([string]$DemoRoot = (Join-Path $env:LOCALAPPDATA 'HANOUTY-Demo'), [switch]$PrepareOnly)
$ErrorActionPreference='Stop'
$ProgressPreference='SilentlyContinue'
$OutputEncoding=[Text.UTF8Encoding]::new($false)
Set-StrictMode -Version Latest
Add-Type -AssemblyName System.Security
Add-Type -AssemblyName System.Windows.Forms
$root=[IO.Path]::GetFullPath($DemoRoot)
$server=$null; $guard=$null; $client=$null; $password=$null; $port=0; $status=$null
$names=@('HANOUTY_CATALOGUE_CONNECTION','HANOUTY_DATA_DIRECTORY','HANOUTY_WORKSTATION')
$previous=@{}; foreach($name in $names){$previous[$name]=[Environment]::GetEnvironmentVariable($name,'Process')}
function Run-Sql([string]$Sql) {
    $out=$Sql | & $script:client --host=127.0.0.1 "--port=$script:port" --user=root "--password=$script:password" --default-character-set=utf8mb4 --batch --skip-column-names 2>&1
    if($LASTEXITCODE -ne 0){throw ('Initialisation de la démonstration impossible: '+($out -join ' '))}
    return $out
}
try {
    if(-not $PrepareOnly){
        $status=New-Object Windows.Forms.Form
        $status.Text='HANOUTY — Démonstration'; $status.Width=460; $status.Height=150; $status.StartPosition='CenterScreen'; $status.ControlBox=$false
        $label=New-Object Windows.Forms.Label
        $label.Dock='Fill'; $label.TextAlign='MiddleCenter'; $label.Text="Préparation automatique de HANOUTY…`r`nPremier lancement : veuillez patienter.`r`nVotre code de démonstration : 1234"
        $status.Controls.Add($label); $status.Show(); [Windows.Forms.Application]::DoEvents()
    }
    New-Item -ItemType Directory -Force -Path $root | Out-Null
    $guard=[IO.File]::Open((Join-Path $root 'session.lock'),[IO.FileMode]::OpenOrCreate,[IO.FileAccess]::ReadWrite,[IO.FileShare]::None)
    $manifest=Get-Content -LiteralPath (Join-Path $PSScriptRoot 'DEMO-MANIFEST.json') -Raw | ConvertFrom-Json
    foreach($entry in $manifest.Files){
        $file=Join-Path $PSScriptRoot $entry.Name
        if((Get-FileHash -LiteralPath $file -Algorithm SHA256).Hash -ine $entry.Sha256){throw ('Fichier de démonstration incomplet: '+$entry.Name)}
    }
    $proof=Get-Content -LiteralPath (Join-Path $PSScriptRoot 'financial-package-acceptance.json') -Raw | ConvertFrom-Json
    if($proof.FinancialAcceptance -ne $true -or (Get-FileHash -LiteralPath (Join-Path $PSScriptRoot 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip')).Hash -ine $proof.FinalPackageSha256){throw 'Application financière non validée.'}
    $app=Join-Path $root ('application-'+$proof.SourceSha)
    if(-not(Test-Path -LiteralPath (Join-Path $app 'HANOUTY-MANIFEST.json'))){Expand-Archive -LiteralPath (Join-Path $PSScriptRoot 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip') -DestinationPath $app -Force}
    $applicationManifest=Get-Content -LiteralPath (Join-Path $app 'HANOUTY-MANIFEST.json') -Raw | ConvertFrom-Json
    foreach($entry in $applicationManifest.files){if((Get-FileHash -LiteralPath (Join-Path $app $entry.file)).Hash -ine $entry.sha256){throw 'Application de démonstration modifiée ou incomplète.'}}
    $runtime=Join-Path $root 'runtime-10.11.14'
    if(-not(Test-Path -LiteralPath (Join-Path $runtime 'mariadb-10.11.14-winx64/bin/mariadbd.exe'))){Expand-Archive -LiteralPath (Join-Path $PSScriptRoot 'mariadb-10.11.14-winx64.zip') -DestinationPath $runtime -Force}
    $bin=Join-Path $runtime 'mariadb-10.11.14-winx64/bin'; $client=Join-Path $bin 'mariadb.exe'
    $secret=Join-Path $root 'local-key.bin'; $data=Join-Path $root 'database'
    if(Test-Path -LiteralPath $secret){$bytes=[Security.Cryptography.ProtectedData]::Unprotect([IO.File]::ReadAllBytes($secret),$null,[Security.Cryptography.DataProtectionScope]::CurrentUser); $password=[Text.Encoding]::UTF8.GetString($bytes); [Array]::Clear($bytes,0,$bytes.Length)}
    else {
        if(Test-Path -LiteralPath $data){throw 'Une préparation précédente est incomplète. Ses données ont été conservées.'}
        $password=[Guid]::NewGuid().ToString('N'); $bytes=[Text.Encoding]::UTF8.GetBytes($password)
        [IO.File]::WriteAllBytes($secret,[Security.Cryptography.ProtectedData]::Protect($bytes,$null,[Security.Cryptography.DataProtectionScope]::CurrentUser)); [Array]::Clear($bytes,0,$bytes.Length)
    }
    $probe=[Net.Sockets.TcpListener]::new([Net.IPAddress]::Loopback,0); try{$probe.Start(); $port=([Net.IPEndPoint]$probe.LocalEndpoint).Port}finally{$probe.Stop()}
    if(-not(Test-Path -LiteralPath (Join-Path $data 'my.ini'))){
        & (Join-Path $bin 'mariadb-install-db.exe') "--datadir=$data" "--password=$password" "--port=$port" *> (Join-Path $root 'initialisation.log')
        if($LASTEXITCODE -ne 0){throw 'La préparation automatique de la démonstration a échoué.'}
    }
    $server=Start-Process -FilePath (Join-Path $bin 'mariadbd.exe') -ArgumentList @(('--defaults-file="'+(Join-Path $data 'my.ini')+'"'),'--bind-address=127.0.0.1',"--port=$port") -WindowStyle Hidden -PassThru
    $ready=$false
    for($i=0;$i -lt 60;$i++){
        Start-Sleep -Milliseconds 500
        & (Join-Path $bin 'mariadb-admin.exe') --host=127.0.0.1 "--port=$port" --user=root "--password=$password" ping 2>$null | Out-Null
        if($LASTEXITCODE -eq 0 -and -not $server.HasExited){$ready=$true;break}
        if($server.HasExited){throw 'La démonstration ne peut pas démarrer son service local.'}
    }
    if(-not $ready){throw 'Le démarrage local a dépassé le délai prévu.'}
    $actual=Run-Sql 'SELECT @@datadir;'
    if([IO.Path]::GetFullPath(([string]$actual).Trim()).TrimEnd([char[]]@('/','\')) -ine [IO.Path]::GetFullPath($data).TrimEnd([char[]]@('/','\'))){throw 'Le service local ne correspond pas à cette démonstration.'}
    $seedMarker=Join-Path $root 'ready.json'
    if(-not(Test-Path -LiteralPath $seedMarker)){
        $exists=Run-Sql "SELECT COUNT(*) FROM information_schema.SCHEMATA WHERE SCHEMA_NAME='hanouty_demo';"
        if([int]$exists -ne 0){throw 'Une préparation incomplète a été conservée; aucune donnée ne sera écrasée.'}
        Run-Sql ([IO.File]::ReadAllText((Join-Path $PSScriptRoot 'demo.sql'))) | Out-Null
        @{Version=1;SeedSha256=(Get-FileHash -LiteralPath (Join-Path $PSScriptRoot 'demo.sql')).Hash} | ConvertTo-Json | Set-Content -LiteralPath $seedMarker -Encoding UTF8
    }
    $appData=Join-Path $root 'catalogue'; New-Item -ItemType Directory -Force -Path (Join-Path $appData 'bd/images') | Out-Null
    if(-not(Test-Path -LiteralPath (Join-Path $appData 'gestion_credit.sni'))){[IO.File]::WriteAllText((Join-Path $appData 'gestion_credit.sni'),'True')}
    if(-not(Test-Path -LiteralPath (Join-Path $appData 'PRINTER_CL.sni'))){[IO.File]::WriteAllText((Join-Path $appData 'PRINTER_CL.sni'),'0')}
    # The demonstration uses a free port on every launch. Carry its own printer
    # choice forward without sharing any real workstation's profile.
    $identity="127.0.0.1`n$port`nhanouty_demo`n01"
    $hasher=[Security.Cryptography.SHA256]::Create()
    try{$profileKey=([BitConverter]::ToString($hasher.ComputeHash([Text.Encoding]::UTF8.GetBytes($identity)))).Replace('-','')}finally{$hasher.Dispose()}
    $printerProfile=Join-Path $env:LOCALAPPDATA ('HANOUTY/printer-profiles/'+$profileKey)
    New-Item -ItemType Directory -Force -Path $printerProfile | Out-Null
    Copy-Item -LiteralPath (Join-Path $appData 'PRINTER_CL.sni') -Destination (Join-Path $printerProfile 'PRINTER_CL.sni') -Force
    $env:HANOUTY_CATALOGUE_CONNECTION="Server=127.0.0.1;Port=$port;Database=hanouty_demo;Uid=root;Pwd=$password;SslMode=Disabled;"
    $env:HANOUTY_DATA_DIRECTORY=$appData; $env:HANOUTY_WORKSTATION='01'
    if($PrepareOnly){
        $counts=Run-Sql 'USE hanouty_demo; SELECT COUNT(*) FROM TABLE_ARTICLES; SELECT COUNT(*) FROM TABLE_PASS WHERE ListPass=1234;'
        if([int]$counts[0] -lt 12 -or [int]$counts[1] -ne 1){throw 'Catalogue ou code de démonstration invalide.'}
        @{Ready=$true;NoConfiguration=$true;AutomaticFreePort=$true;Products=[int]$counts[0];PersistentData=$true;Pin='1234'} | ConvertTo-Json | Set-Content -LiteralPath (Join-Path $root 'verification.json') -Encoding UTF8
    }else{
        if($status){$status.Close();$status.Dispose();$status=$null}
        $cashier=Start-Process -FilePath (Join-Path $app 'Hanouty.Desktop.Bootstrap.exe') -WorkingDirectory $app -WindowStyle Normal -Wait -PassThru
        Copy-Item -LiteralPath (Join-Path $printerProfile 'PRINTER_CL.sni') -Destination (Join-Path $appData 'PRINTER_CL.sni') -Force
        if($cashier.ExitCode -ne 0){throw 'La caisse de démonstration ne peut pas être ouverte.'}
    }
}catch{
    $message=$_.Exception.Message
    if(Test-Path -LiteralPath $root){[IO.File]::WriteAllText((Join-Path $root 'dernier-probleme.txt'),$message)}
    if($PrepareOnly){throw}
    [Windows.Forms.MessageBox]::Show($message+"`r`nCode de démonstration : 1234",'HANOUTY — Démonstration') | Out-Null
    exit 1
}finally{
    if($status){$status.Close();$status.Dispose()}
    if($server -and -not $server.HasExited){
        & (Join-Path $bin 'mariadb-admin.exe') --host=127.0.0.1 "--port=$port" --user=root "--password=$password" shutdown 2>$null | Out-Null
        if($LASTEXITCODE -eq 0){$server.WaitForExit(15000)}
    }
    foreach($name in $names){[Environment]::SetEnvironmentVariable($name,$previous[$name],'Process')}
    if($guard){$guard.Dispose()}
}
