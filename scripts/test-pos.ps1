$ErrorActionPreference='Stop'
$dist=(Resolve-Path dist).Path
# Supply required local startup files for isolated Windows tests.
@{'CHEMIN_DB.sni'='127.0.0.1';'CHEMIN_FOLDER.sni'='Application.StartupPath';'poste.sni'='CI_TEST';'mode_windows.sni'='NORMAL';'log_erreur.sni'=''}.GetEnumerator() | ForEach-Object {
  [IO.File]::WriteAllText((Join-Path $dist $_.Key),$_.Value)
}
$csc=Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
& $csc /nologo /platform:x86 /target:exe /r:System.Windows.Forms.dll /r:System.Drawing.dll /r:System.Data.dll "/out:$dist\PosSmoke.exe" (Join-Path $PSScriptRoot 'test-pos.cs')
if ($LASTEXITCODE -ne 0) { throw 'Test harness compilation failed' }
Copy-Item dist/LOGICA.exe.config dist/PosSmoke.exe.config -Force
$cases=@('stock-movement-search','basket','checkout','checkout-rollback','checkout-late-rollback','checkout-fractional','checkout-stock-off','checkout-reject-sale','checkout-reject-return','checkout-reject-empty','checkout-reject-total','checkout-reject-stock','checkout-reject-stock-off','checkout-stock-exact','checkout-missing-stock-lookup','checkout-rounding-window','checkout-select-seller','checkout-select-client','checkout-credit-client','checkout-mixed','checkout-change','checkout-credit','rounding','Form_0_TEMPLATE','Form_1_LOGIN','Form_3_VENTE','Form_2_ARTICLES','Form_6_MOUVEMENTS_STOCK','FormDialog_MODE_P','Report_TICKET_A4')
$results=@()
foreach($case in $cases) {
  $log=Join-Path (Resolve-Path results).Path ($case+'.log')
  $err=Join-Path (Resolve-Path results).Path ($case+'.stderr.log')
  $p=Start-Process (Join-Path $dist 'PosSmoke.exe') -ArgumentList $case -WorkingDirectory $dist -RedirectStandardOutput $log -RedirectStandardError $err -PassThru
  if(-not $p.WaitForExit(60000)) { $p.Kill(); $status='TIMEOUT' } else { $status=if($p.ExitCode -eq 0){'PASS'}else{'FAIL'} }
  $results+= [pscustomobject]@{test=$case;status=$status;exitCode=$p.ExitCode}
  Write-Host "$case $status"
  Get-Content $log | Select-Object -First 30 | ForEach-Object{Write-Host $_}
}
# Launch the real Windows entry point as well as exercising forms through the harness.
$app=Start-Process (Join-Path $dist 'LOGICA.exe') -WorkingDirectory $dist -PassThru
Start-Sleep -Seconds 8
$app.Refresh()
$status=if(-not $app.HasExited -and $app.MainWindowHandle -ne 0 -and $app.Responding){'PASS'}else{'FAIL'}
$results+=[pscustomobject]@{test='LOGICA.exe startup';status=$status;exitCode=$null}
Write-Host "Real LOGICA.exe startup $status; process running=$(-not $app.HasExited); window=$($app.MainWindowHandle); responding=$($app.Responding)"
if(-not $app.HasExited){$app.Kill()}
$results | ConvertTo-Json | Set-Content results/pos-tests.json
# Preserve the application package independently of test harness files.
Remove-Item dist/PosSmoke.exe,dist/PosSmoke.exe.config -Force
if(@($results | Where-Object status -ne 'PASS').Count -gt 0){throw 'Some Windows POS checks failed; see per-test logs'}
