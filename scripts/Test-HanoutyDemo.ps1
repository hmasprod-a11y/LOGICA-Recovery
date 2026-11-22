param([Parameter(Mandatory=$true)][string]$BundleDirectory,[Parameter(Mandatory=$true)][string]$EvidenceDirectory,[string]$Dotnet='dotnet')
$ErrorActionPreference='Stop'
Set-StrictMode -Version Latest
Add-Type -AssemblyName System.Security
$evidence=[IO.Path]::GetFullPath($EvidenceDirectory)
New-Item -ItemType Directory -Force -Path $evidence | Out-Null
$root=Join-Path $evidence ('fresh-'+[Guid]::NewGuid().ToString('N'))
$launcher=Join-Path $BundleDirectory 'Start-Hanouty-Demo.ps1'
& powershell.exe -NoProfile -ExecutionPolicy Bypass -File $launcher -DemoRoot $root -PrepareOnly
if($LASTEXITCODE -ne 0){throw 'Fresh offline demo preparation failed.'}
$keyBefore=(Get-FileHash -LiteralPath (Join-Path $root 'local-key.bin')).Hash
$seedBefore=(Get-FileHash -LiteralPath (Join-Path $root 'ready.json')).Hash
$previous=@{};foreach($name in @('HANOUTY_CATALOGUE_CONNECTION','HANOUTY_DATA_DIRECTORY','HANOUTY_WORKSTATION')){$previous[$name]=[Environment]::GetEnvironmentVariable($name,'Process')}
try{
    foreach($pass in 1..2){
        if($pass -eq 2){
            & powershell.exe -NoProfile -ExecutionPolicy Bypass -File $launcher -DemoRoot $root -PrepareOnly
            if($LASTEXITCODE -ne 0){throw 'Demo restart failed.'}
            if((Get-FileHash -LiteralPath (Join-Path $root 'local-key.bin')).Hash -cne $keyBefore -or (Get-FileHash -LiteralPath (Join-Path $root 'ready.json')).Hash -cne $seedBefore){throw 'Restart replaced the saved demonstration.'}
        }
        $bytes=[Security.Cryptography.ProtectedData]::Unprotect([IO.File]::ReadAllBytes((Join-Path $root 'local-key.bin')),$null,[Security.Cryptography.DataProtectionScope]::CurrentUser)
        $password=[Text.Encoding]::UTF8.GetString($bytes);[Array]::Clear($bytes,0,$bytes.Length)
        $bin=Join-Path $root 'runtime-10.11.14/mariadb-10.11.14-winx64/bin'
        $probe=[Net.Sockets.TcpListener]::new([Net.IPAddress]::Loopback,0);try{$probe.Start();$port=([Net.IPEndPoint]$probe.LocalEndpoint).Port}finally{$probe.Stop()}
        $data=Join-Path $root 'database';$server=$null
        try{
            $server=Start-Process -FilePath (Join-Path $bin 'mariadbd.exe') -ArgumentList @(('--defaults-file="'+(Join-Path $data 'my.ini')+'"'),'--bind-address=127.0.0.1',"--port=$port") -WindowStyle Hidden -PassThru
            $ready=$false
            for($attempt=0;$attempt -lt 40;$attempt++){Start-Sleep -Milliseconds 500;& (Join-Path $bin 'mariadb-admin.exe') --host=127.0.0.1 --port=$port --user=root --password=$password ping 2>$null | Out-Null;if($LASTEXITCODE -eq 0){$ready=$true;break}}
            if(-not $ready){throw 'Owned demo verification database did not start.'}
            $env:HANOUTY_CATALOGUE_CONNECTION="Server=127.0.0.1;Port=$port;Database=hanouty_demo;Uid=root;Pwd=$password;SslMode=Disabled;"
            $env:HANOUTY_DATA_DIRECTORY=Join-Path $root 'catalogue';$env:HANOUTY_WORKSTATION='01'
            $repo=Split-Path $PSScriptRoot
            & $Dotnet run --project (Join-Path $repo 'modernization/demo-acceptance/DemoAcceptance.csproj') -c Release -p:CheckoutProductionProject=../checkout-mariadb-production/CheckoutMariaDbProduction.csproj -- (Join-Path $evidence "pass-$pass")
            if($LASTEXITCODE -ne 0){throw "Demo PIN/scanner/coin payment verification failed on pass$pass."}
        }finally{if($server -and -not $server.HasExited){& (Join-Path $bin 'mariadb-admin.exe') --host=127.0.0.1 --port=$port --user=root --password=$password shutdown 2>$null | Out-Null;$server.WaitForExit(15000)}}
    }
    $first=Get-Content -LiteralPath (Join-Path $evidence 'pass-1/demo-ui.json') -Raw | ConvertFrom-Json
    $second=Get-Content -LiteralPath (Join-Path $evidence 'pass-2/demo-ui.json') -Raw | ConvertFrom-Json
    if($first.PreviousCounter -ne 0 -or $second.PreviousCounter -ne $first.CurrentCounter -or $second.CurrentCounter -ne 2){throw 'Sales did not persist across restart.'}
    @{OfflineFreshStart=$true;NoLogicaConfiguration=$true;Pin1234=$true;ActualWpfSales=$true;StockPosted=$true;RestartPreservesSales=$true;TwoSales=$true} | ConvertTo-Json | Set-Content -LiteralPath (Join-Path $evidence 'demo-acceptance.json') -Encoding UTF8
    Write-Host 'PASS offline demonstration, PIN, scanner, cash keypad, stock and restart persistence.'
}finally{foreach($name in $previous.Keys){[Environment]::SetEnvironmentVariable($name,$previous[$name],'Process')}}
