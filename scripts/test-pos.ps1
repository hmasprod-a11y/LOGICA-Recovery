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
$cases=@('checkout-blank-barcode-posting','checkout-list-selection','checkout-quantity-keypad-dpi','checkout-scanner-enter','checkout-search-shortcut','checkout-barcode-chooser','checkout-article-search-sql','checkout-image-grid','checkout-contrast','checkout-keyboard-contrast','checkout-basket-selection-contrast','checkout-basket-header-dpi','checkout-product-list-header-dpi','checkout-family-caption-contrast','checkout-product-list-selection-contrast','checkout-product-name-row-dpi','checkout-white-buttons-contrast','catalogue-keys','catalogue-barcodes','catalogue-save-guards','collection-save-guards','collection-duplicate-code','collection-duplicate-later','collection-variant-insert','collection-quantity-totals','catalogue-aggregate-refresh','catalogue-aggregate-failure','catalogue-create','catalogue-edit','catalogue-duplicates','catalogue-movement-failure','catalogue-sequence-failure','catalogue-insert-failure','catalogue-update-failure','catalogue-create-empty','catalogue-create-null-sequence','catalogue-create-empty-null','catalogue-balance-reject','catalogue-balance-format','cash-counting','stock-movement-search','stock-movement-search-failure','shared-export-projection','inventory-decline-validation','inventory-empty-validation','inventory-transaction-preflight','basket','checkout','checkout-rollback','checkout-late-rollback','checkout-fractional','checkout-stock-off','checkout-reject-sale','checkout-reject-return','checkout-reject-empty','checkout-reject-total','checkout-reject-stock','checkout-reject-stock-off','checkout-stock-exact','checkout-missing-stock-lookup','checkout-rounding-window','checkout-select-seller','checkout-select-client','checkout-credit-client','checkout-mixed','checkout-change','checkout-credit','rounding','Form_0_TEMPLATE','Form_1_LOGIN','Form_3_VENTE','Form_2_ARTICLES','Form_6_MOUVEMENTS_STOCK','FormDialog_MODE_P','Report_TICKET_A4')
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
# Windows cold-start may take longer than the former fixed eight seconds.
# Poll for a real responsive main window; do not count a live headless process as PASS.
$deadline=[Diagnostics.Stopwatch]::StartNew()
$ready=$false
do {
  Start-Sleep -Seconds 2
  $app.Refresh()
  if($app.HasExited){break}
  if($app.MainWindowHandle -ne 0 -and $app.Responding){$ready=$true;break}
} while ($deadline.Elapsed.TotalSeconds -lt 30)
$status=if($ready){'PASS'}else{'FAIL'}
$results+=[pscustomobject]@{test='LOGICA.exe startup';status=$status;exitCode=$null}
Write-Host "Real LOGICA.exe startup $status; process running=$(-not $app.HasExited); window=$($app.MainWindowHandle); responding=$($app.Responding)"
if(-not $app.HasExited){$app.Kill()}
$results | ConvertTo-Json | Set-Content results/pos-tests.json
# Preserve the application package independently of test harness files.
Remove-Item dist/PosSmoke.exe,dist/PosSmoke.exe.config -Force
if(@($results | Where-Object status -ne 'PASS').Count -gt 0){throw 'Some Windows POS checks failed; see per-test logs'}
