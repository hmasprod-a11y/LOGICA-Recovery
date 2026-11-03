# Run on Windows PowerShell in an STA thread: powershell.exe -STA -File scripts/test-desktop-winforms-events.ps1
# Executable WinForms event test. Compiles the exact presenter classes from production,
# then exercises actual TextBox.TextChanged and KeyDown events (no database access).
$ErrorActionPreference = 'Stop'
if ([Threading.Thread]::CurrentThread.GetApartmentState() -ne 'STA') {
    throw 'WinForms event tests require powershell.exe -STA'
}
$sourcePath = Join-Path $PSScriptRoot '..\recovered-source\LOGICA\Form_3_VENTE.cs'
$source = [IO.File]::ReadAllText((Resolve-Path $sourcePath))
$classes = @('BarcodeEnterPresenter', 'ProductSearchResetPresenter', 'ProductSelectionPresenter', 'ArticleImageScrollPresenter')
$production = foreach ($name in $classes) {
    $pattern = '(?s)internal static class ' + [regex]::Escape($name) + '\s*\{.*?\n\}'
    $match = [regex]::Match($source, $pattern)
    if (-not $match.Success) { throw "Missing production presenter: $name" }
    $match.Value
}
$code = 'using System; using System.Windows.Forms; using System.Drawing; ' + ($production -join [Environment]::NewLine)
Add-Type -TypeDefinition $code -ReferencedAssemblies @('System.Windows.Forms', 'System.Drawing') -ErrorAction Stop
function Assert([bool]$condition, [string]$message) {
    if (-not $condition) { throw "FAIL: $message" }
}
$text = New-Object System.Windows.Forms.TextBox
try {
    $script:refreshCount = 0
    $text.add_TextChanged({ $script:refreshCount++ })
    $text.Text = 'milk'
    $script:refreshCount = 0
    if ([ProductSearchResetPresenter]::ShouldClearText($text.Text)) { $text.Clear() } else { $script:refreshCount++ }
    Assert ($script:refreshCount -eq 1) 'nonempty search must dispatch exactly one TextChanged'
    Assert ($text.Text -eq '') 'search must be empty'
    $script:refreshCount = 0
    if ([ProductSearchResetPresenter]::ShouldClearText($text.Text)) { $text.Clear() } else { $script:refreshCount++ }
    Assert ($script:refreshCount -eq 1) 'already empty search must refresh exactly once'
    $script:scanCount = 0
    $text.add_KeyDown({
        param($sender, $e)
        if ([BarcodeEnterPresenter]::ShouldSubmit($e.KeyCode, $e.Modifiers)) {
            $e.SuppressKeyPress = $true
            $script:scanCount++
        }
    })
    $raise = [System.Windows.Forms.Control].GetMethod('OnKeyDown', [Reflection.BindingFlags]'Instance,NonPublic')
    if (-not $raise) { throw 'Cannot locate WinForms OnKeyDown' }
    $enter = New-Object System.Windows.Forms.KeyEventArgs([System.Windows.Forms.Keys]::Enter)
    $raise.Invoke($text, @($enter)) | Out-Null
    Assert ($script:scanCount -eq 1 -and $enter.SuppressKeyPress) 'Enter event must submit and suppress'
    $shiftEnter = New-Object System.Windows.Forms.KeyEventArgs([System.Windows.Forms.Keys]([int][System.Windows.Forms.Keys]::Enter -bor [int][System.Windows.Forms.Keys]::Shift))
    $raise.Invoke($text, @($shiftEnter)) | Out-Null
    Assert ($script:scanCount -eq 1) 'Shift+Enter must not submit'
    Assert ([ProductSelectionPresenter]::CanLookup($true, '12345', $null)) 'barcode selection'
    Assert (-not [ProductSelectionPresenter]::CanLookup($true, ' ', $null)) 'empty barcode'
    Assert ([ProductSelectionPresenter]::CanLookup($false, $null, '42')) 'image tile selection'
    Assert (-not [ProductSelectionPresenter]::CanLookup($false, $null, ' ')) 'empty image ID'
    $scroll = [ArticleImageScrollPresenter]::Calculate(500, 100, -900)
    Assert ($scroll.Value -le ($scroll.Maximum - $scroll.LargeChange + 1)) 'scroll position clamped'
    Write-Host 'PASS: real WinForms TextChanged/KeyDown events and production presenters'
} finally {
    $text.Dispose()
}
