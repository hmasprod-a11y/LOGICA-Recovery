$ErrorActionPreference='Stop'
$root=(Resolve-Path dist).Path
$serverRoot=(Get-ChildItem (Join-Path $env:RUNNER_TEMP 'logica-mariadb/server') -Recurse -Filter mariadbd.exe | Select-Object -First 1).Directory.Parent.FullName
New-Item -ItemType Junction -Path "$root/bd/mysql-server" -Target $serverRoot | Out-Null
$previous=$env:LOGICA_DB_CONNECTION_STRING
$env:LOGICA_DB_CONNECTION_STRING=$null
$app=$null
try {
 Start-Process "$root/LOGICA.exe" -WorkingDirectory $root | Out-Null
 for($i=0;$i -lt 80;$i++){
  Start-Sleep -Milliseconds 500
  $app=Get-Process LOGICA -ErrorAction SilentlyContinue | Where-Object {$_.Path -eq "$root/LOGICA.exe" -and $_.MainWindowTitle -like '*Development*'} | Select-Object -First 1
  if($app){break}
 }
 if(-not $app){throw 'Opening EXE directly did not reach development login'}
 $probe=New-Object Net.Sockets.TcpClient
 try {$probe.Connect('127.0.0.1',3308)} finally {$probe.Dispose()}
 Write-Host 'PASS direct EXE starts portable database and reaches original development window'
 # A second launcher must not shut down the database owned by the first.
 & powershell.exe -NoLogo -NoProfile -ExecutionPolicy Bypass -File "$root/Launch-LOGICA.ps1" -VerifyOnly
 if($LASTEXITCODE -ne 0){throw 'Second launcher failed'}
 $probe=New-Object Net.Sockets.TcpClient
 try {$probe.Connect('127.0.0.1',3308)} finally {$probe.Dispose()}
 Write-Host 'PASS duplicate launch keeps active database running'
} finally {
 if($app -and -not $app.HasExited){$app.Kill();$app.WaitForExit()}
 for($i=0;$i -lt 40;$i++){
  $probe=New-Object Net.Sockets.TcpClient
  try {$probe.Connect('127.0.0.1',3308);$open=$true} catch {$open=$false} finally {$probe.Dispose()}
  if(-not $open){break}
  Start-Sleep -Milliseconds 500
 }
 $env:LOGICA_DB_CONNECTION_STRING=$previous
}
if($open){throw 'Portable launcher left database running after application exit'}
Write-Host 'PASS launcher shuts down local database after application exits'
