param(
    [Parameter(Mandatory=$true)][string]$PackageDirectory,
    [Parameter(Mandatory=$true)][string]$EvidenceDirectory,
    [Parameter(Mandatory=$true)][string]$SourceSha
)
$ErrorActionPreference='Stop'
Set-StrictMode -Version Latest
$actualSha=(git rev-parse HEAD).Trim()
if ($actualSha -cne $SourceSha -or $actualSha -cne $env:GITHUB_SHA) { throw "Package source SHA mismatch: $actualSha" }
$package=[IO.Path]::GetFullPath($PackageDirectory)
$evidence=[IO.Path]::GetFullPath($EvidenceDirectory)
$publish=Join-Path $package 'publish'
$extract=Join-Path $package 'extracted-verification'
$exe=Join-Path $extract 'Hanouty.Desktop.Bootstrap.exe'
if (-not (Test-Path $exe)) { throw 'Extracted financial WPF EXE missing.' }
if ($env:HANOUTY_W2_DISPOSABLE_MARKER -ne 'I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY' -or
    $env:HANOUTY_CATALOGUE_CONNECTION -notmatch 'Server=127\.0\.0\.1;Port=3307;Database=logica_ci;') {
    throw 'W2 package test requires only the explicitly disposable loopback:3307/logica_ci database.'
}
New-Item -ItemType Directory -Force $evidence | Out-Null
$acceptance=Join-Path $evidence 'w2'
if (Test-Path $acceptance) { Remove-Item $acceptance -Recurse -Force }
New-Item -ItemType Directory -Force $acceptance | Out-Null
$run=Start-Process -FilePath $exe -ArgumentList @('--verify-disposable-cash-sale',('"' + $acceptance + '"')) -Wait -PassThru
if ($run.ExitCode -ne 0) {
    $failure = Join-Path $acceptance 'w2-failure.txt'
    if (Test-Path -LiteralPath $failure) {
        $summary = Get-Content -LiteralPath $failure -TotalCount 1
        Write-Host ($summary -replace '(?i)(password|pwd)=[^;\s]+', '$1=[redacted]')
    }
    throw "Extracted financial package W2 acceptance exited $($run.ExitCode)."
}
$report=Get-Content (Join-Path $acceptance 'w2-cash-sale.json') -Raw | ConvertFrom-Json
$fields=@('CashierDialogProductionBound','TrustedQuoteDisplayed','WindowLoaded','EditedContextRejected',
'SingleSessionBinding','InitialCashierPinUi','InitialPinCancelAndWrongRejected','CashChangeSql',
'EmptyBasket','TicketPaymentStockSql','Duplicate','ProcessRestart','WrongPinRejected',
'AfterPaymentRollback','UnknownJournalLocked','LostAcknowledgementPersisted','Reconciliation',
'FullCashReturnThroughWpfUi','FullCashReturnSqlReadback','FullCashReturnRollback','FullCashReturnIdempotency')
foreach($field in $fields) { if($report.$field -ne $true) { throw "Extracted package missing W2 evidence: $field" } }
if($report.W2Accepted -ne $true) { throw 'Extracted package did not pass W2 acceptance.' }
# Exercise the same extracted EXE without command-line arguments, as Explorer does.
$launch=Start-Process -FilePath $exe -PassThru
$until=[DateTime]::UtcNow.AddSeconds(20)
$handle=[IntPtr]::Zero
while([DateTime]::UtcNow -lt $until) {
    Start-Sleep -Milliseconds 300
    $launch.Refresh()
    if($launch.HasExited) { throw "Double-click startup exited $($launch.ExitCode)." }
    $handle=$launch.MainWindowHandle
    if($handle -ne [IntPtr]::Zero) { break }
}
if($handle -eq [IntPtr]::Zero) { Stop-Process -Id $launch.Id -Force -ErrorAction SilentlyContinue; throw 'Double-click did not open cashier window.' }
$title=$launch.MainWindowTitle
if($title -notmatch '(?i)hanouty|caisse|cashier') { Stop-Process -Id $launch.Id -Force -ErrorAction SilentlyContinue; throw "Unexpected cashier window title: $title" }
if(-not $launch.CloseMainWindow() -or -not $launch.WaitForExit(10000)) { Stop-Process -Id $launch.Id -Force -ErrorAction SilentlyContinue; throw 'Cashier window did not close cleanly.' }
if($launch.ExitCode -ne 0) { throw "Cashier startup exit code: $($launch.ExitCode)" }
$status='Financial package acceptance passed on exact source SHA ' + $actualSha + '; engineering candidate only.'
Set-Content (Join-Path $publish 'HANOUTY-CANDIDATE-STATUS.txt') $status -Encoding UTF8
$files=@(Get-ChildItem $publish -Recurse -File | Where-Object { $_.Name -ne 'HANOUTY-MANIFEST.json' -and $_.Extension -notin @('.pdb','.mdb') })
$hashes=@($files | Sort-Object FullName | ForEach-Object {
    [pscustomobject]@{ file=[IO.Path]::GetRelativePath($publish,$_.FullName).Replace('\','/'); sha256=(Get-FileHash $_.FullName -Algorithm SHA256).Hash.ToLowerInvariant() }
})
$manifest=[ordered]@{ application='HANOUTY POS WPF'; runtime='win-x64'; framework='net10.0-windows'; mode='financial'; financialAcceptance=$true; candidate='financial-accepted-engineering'; acceptanceSha=$actualSha; acceptanceRunId=$env:GITHUB_RUN_ID; files=$hashes }
$manifestPath=Join-Path $publish 'HANOUTY-MANIFEST.json'
$manifest | ConvertTo-Json -Depth 6 | Set-Content $manifestPath -Encoding UTF8
$zip=Join-Path $package 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip'
Compress-Archive (Join-Path $publish '*') $zip
$final=Join-Path $package 'accepted-extracted'
if(Test-Path $final) { Remove-Item $final -Recurse -Force }
Expand-Archive $zip $final
$finalManifest=Get-Content (Join-Path $final 'HANOUTY-MANIFEST.json') -Raw | ConvertFrom-Json
if($finalManifest.financialAcceptance -ne $true -or $finalManifest.acceptanceSha -cne $actualSha) { throw 'Final package acceptance provenance mismatch.' }
foreach($entry in $finalManifest.files) {
    $file=Join-Path $final ([string]$entry.file)
    if(-not (Test-Path $file) -or (Get-FileHash $file -Algorithm SHA256).Hash.ToLowerInvariant() -cne $entry.sha256) { throw "Accepted package hash mismatch: $($entry.file)" }
}
$exeHash=(Get-FileHash $exe -Algorithm SHA256).Hash.ToLowerInvariant()
$zipHash=(Get-FileHash $zip -Algorithm SHA256).Hash.ToLowerInvariant()
$proof=[ordered]@{SourceSha=$actualSha;WorkflowRunId=$env:GITHUB_RUN_ID;FinancialAcceptance=$true;DoubleClickCashierWindow=$true;WindowTitle=$title;ExtractedExeSha256=$exeHash;FinalPackageSha256=$zipHash}
Copy-Item -LiteralPath $zip -Destination $evidence
$proof | ConvertTo-Json -Depth 4 | Set-Content (Join-Path $evidence 'financial-package-acceptance.json') -Encoding UTF8
Write-Host "PASS extracted financial package W2 and double-click startup: $title"
