param([Parameter(Mandatory=$true)][string]$EvidenceDirectory)
$ErrorActionPreference = 'Stop'
$root = [IO.Path]::GetFullPath($EvidenceDirectory)
$sourcePath = Join-Path $root 'sources.txt'
$reportPath = Join-Path $root 'acceptance.json'
if (-not (Test-Path -LiteralPath $sourcePath -PathType Leaf)) { throw 'Missing immutable source manifest' }
if (-not (Test-Path -LiteralPath $reportPath -PathType Leaf)) { throw 'Missing actual WPF runtime acceptance report' }
$source = Get-Content -LiteralPath $sourcePath -Raw
if ($source -notmatch '(?m)^qa=[0-9a-f]{40}\r? -or
    $source -notmatch '(?m)^host=6d34e06139f9f10c992a926f5cce090ead72a97e\r?) {
  throw 'QA and production host provenance not recorded'
}
$report = Get-Content -LiteralPath $reportPath -Raw | ConvertFrom-Json
if ($report.WindowLoaded -ne $true -or [int]$report.Rows -ne 4 -or
    [int]$report.StagedSelections -ne 3 -or $report.FinancialSubmissionEnabled -ne $false) {
  throw 'Actual WPF/MariaDB W1 runtime evidence does not satisfy acceptance'
}
# The W1 report must never be promoted into W2 financial posting evidence.
[pscustomobject]@{
  Gate='W1 actual Windows WPF catalogue'
  HostSha='6d34e06139f9f10c992a926f5cce090ead72a97e'
  WindowLoaded=$true
  CatalogueRows=4
  StagedSelections=3
  FinancialPostingAccepted=$false
  W2Accepted=$false
} | ConvertTo-Json | Set-Content -LiteralPath (Join-Path $root 'qa-verdict.json')
Write-Host 'PASS W1 actual WPF host acceptance; W2 explicitly not accepted.'
 -or
    $source -notmatch '(?m)^host=6d34e06139f9f10c992a926f5cce090ead72a97e$') {
  throw 'QA and production host provenance not recorded'
}
$report = Get-Content -LiteralPath $reportPath -Raw | ConvertFrom-Json
if ($report.WindowLoaded -ne $true -or [int]$report.Rows -ne 4 -or
    [int]$report.StagedSelections -ne 3 -or $report.FinancialSubmissionEnabled -ne $false) {
  throw 'Actual WPF/MariaDB W1 runtime evidence does not satisfy acceptance'
}
# The W1 report must never be promoted into W2 financial posting evidence.
[pscustomobject]@{
  Gate='W1 actual Windows WPF catalogue'
  HostSha='6d34e06139f9f10c992a926f5cce090ead72a97e'
  WindowLoaded=$true
  CatalogueRows=4
  StagedSelections=3
  FinancialPostingAccepted=$false
  W2Accepted=$false
} | ConvertTo-Json | Set-Content -LiteralPath (Join-Path $root 'qa-verdict.json')
Write-Host 'PASS W1 actual WPF host acceptance; W2 explicitly not accepted.'
) {
  throw 'QA and production host provenance not recorded'
}
$report = Get-Content -LiteralPath $reportPath -Raw | ConvertFrom-Json
if ($report.WindowLoaded -ne $true -or [int]$report.Rows -ne 4 -or
    [int]$report.StagedSelections -ne 3 -or $report.FinancialSubmissionEnabled -ne $false) {
  throw 'Actual WPF/MariaDB W1 runtime evidence does not satisfy acceptance'
}
# The W1 report must never be promoted into W2 financial posting evidence.
[pscustomobject]@{
  Gate='W1 actual Windows WPF catalogue'
  HostSha='6d34e06139f9f10c992a926f5cce090ead72a97e'
  WindowLoaded=$true
  CatalogueRows=4
  StagedSelections=3
  FinancialPostingAccepted=$false
  W2Accepted=$false
} | ConvertTo-Json | Set-Content -LiteralPath (Join-Path $root 'qa-verdict.json')
Write-Host 'PASS W1 actual WPF host acceptance; W2 explicitly not accepted.'
 -or
    $source -notmatch '(?m)^host=6d34e06139f9f10c992a926f5cce090ead72a97e$') {
  throw 'QA and production host provenance not recorded'
}
$report = Get-Content -LiteralPath $reportPath -Raw | ConvertFrom-Json
if ($report.WindowLoaded -ne $true -or [int]$report.Rows -ne 4 -or
    [int]$report.StagedSelections -ne 3 -or $report.FinancialSubmissionEnabled -ne $false) {
  throw 'Actual WPF/MariaDB W1 runtime evidence does not satisfy acceptance'
}
# The W1 report must never be promoted into W2 financial posting evidence.
[pscustomobject]@{
  Gate='W1 actual Windows WPF catalogue'
  HostSha='6d34e06139f9f10c992a926f5cce090ead72a97e'
  WindowLoaded=$true
  CatalogueRows=4
  StagedSelections=3
  FinancialPostingAccepted=$false
  W2Accepted=$false
} | ConvertTo-Json | Set-Content -LiteralPath (Join-Path $root 'qa-verdict.json')
Write-Host 'PASS W1 actual WPF host acceptance; W2 explicitly not accepted.'
