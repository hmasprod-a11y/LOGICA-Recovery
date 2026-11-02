# Read-only UI Automation inspection of an already running extracted LOGICA.exe.
# Never enters activation keys, reads license values, or modifies registry/database state.
[CmdletBinding()]
param(
    [Parameter(Mandatory=$true)][int]$TargetProcessId,
    [Parameter(Mandatory=$true)][string]$OutputPath
)
$ErrorActionPreference = 'Stop'
$report = [ordered]@{
    processId = $TargetProcessId
    inspectionStatus = 'unavailable'
    activationPanelLocated = $false
    activationPanelVisible = $null
    activationLabelLocated = $false
    activationLabelVisible = $null
    activationScreenVisible = $null
    licensedCashierVerified = $false
}
try {
    Add-Type -AssemblyName UIAutomationClient
    Add-Type -AssemblyName UIAutomationTypes
    $target = Get-Process -Id $TargetProcessId -ErrorAction Stop
    $target.Refresh()
    if ($target.HasExited -or $target.MainWindowHandle -eq [IntPtr]::Zero) {
        throw 'Target has no inspectable main window'
    }
    $window = [System.Windows.Automation.AutomationElement]::FromHandle($target.MainWindowHandle)
    if ($null -eq $window) { throw 'UI Automation root not available' }
    $nodes = $window.FindAll(
        [System.Windows.Automation.TreeScope]::Descendants,
        [System.Windows.Automation.Condition]::TrueCondition)
    for ($i = 0; $i -lt $nodes.Count; $i++) {
        $node = $nodes.Item($i)
        try {
            $id = [string]$node.Current.AutomationId
            $name = [string]$node.Current.Name
            $visible = -not [bool]$node.Current.IsOffscreen
            if ($id -eq 'Panel_clé' -or $id -eq 'Panel_cle') {
                $report.activationPanelLocated = $true
                $report.activationPanelVisible = $visible
            }
            if ($id -eq 'Label13' -or $name -match "(?i)Cl[eé] d.activation") {
                $report.activationLabelLocated = $true
                if ($visible) { $report.activationLabelVisible = $true }
                elseif ($null -eq $report.activationLabelVisible) { $report.activationLabelVisible = $false }
            }
        } catch [System.Windows.Automation.ElementNotAvailableException] {
            # A control may disappear during startup; never interpret that as licensed.
        }
    }
    $report.inspectionStatus = 'inspected'
    if ($report.activationPanelVisible -eq $true -or $report.activationLabelVisible -eq $true) {
        $report.activationScreenVisible = $true
    } elseif ($report.activationPanelLocated -or $report.activationLabelLocated) {
        $report.activationScreenVisible = $false
    }
} catch {
    # Do not record exception messages: they can include local paths or user data.
    $report.inspectionStatus = 'unavailable'
    $report.errorType = $_.Exception.GetType().Name
}
$report | ConvertTo-Json -Depth 4 | Set-Content -LiteralPath $OutputPath -Encoding UTF8
Write-Host ("Read-only activation UI inspection: status={0}; activationVisible={1}; licensedCashierVerified=False" -f
    $report.inspectionStatus, $report.activationScreenVisible)
