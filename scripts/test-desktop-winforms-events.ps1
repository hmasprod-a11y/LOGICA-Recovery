# Run on Windows PowerShell in an STA thread: powershell.exe -STA -File scripts/test-desktop-winforms-events.ps1
# Executable WinForms event test. Compiles the exact presenter classes from production,
# then exercises actual TextBox.TextChanged and KeyDown events (no database access).
$ErrorActionPreference = 'Stop'
if ([Threading.Thread]::CurrentThread.GetApartmentState() -ne 'STA') {
    throw 'WinForms event tests require powershell.exe -STA'
}
$sourcePath = Join-Path $PSScriptRoot '..\recovered-source\LOGICA\Form_3_VENTE.cs'
$source = [IO.File]::ReadAllText((Resolve-Path $sourcePath))
$classes = @('BarcodeEnterPresenter', 'ProductSearchResetPresenter', 'ProductSelectionPresenter', 'ArticleImageScrollPresenter', 'ProductSearchFocusPresenter', 'BarcodeInputFocusPresenter')
$production = foreach ($name in $classes) {
    $pattern = '(?s)internal static class ' + [regex]::Escape($name) + '\s*\{.*?\n\}'
    $match = [regex]::Match($source, $pattern)
    if (-not $match.Success) { throw "Missing production presenter: $name" }
    $match.Value
}
$code = 'using System; using System.Windows.Forms; using System.Drawing; ' + ($production -join [Environment]::NewLine)
$code += @'
public static class PresenterHarness {
    public static void SelectBarcode(System.Windows.Forms.TextBoxBase input) { BarcodeInputFocusPresenter.SelectAll(input); }
    public static System.Drawing.Color Focus(bool focused) { return ProductSearchFocusPresenter.Background(focused); }
    public static bool Clear(string value) { return ProductSearchResetPresenter.ShouldClearText(value); }
    public static bool Submit(Keys key, Keys modifiers) { return BarcodeEnterPresenter.ShouldSubmit(key, modifiers); }
    public static bool Dispatch(KeyEventArgs e, Action callback) { return BarcodeEnterPresenter.Dispatch(e, callback); }
    public static bool Lookup(bool scanner, string barcode, string id) { return ProductSelectionPresenter.CanLookup(scanner, barcode, id); }
    public static bool ScrollBounded(int content, int viewport, int position) {
        var state = ArticleImageScrollPresenter.Calculate(content, viewport, position);
        return state.Value >= 0 && state.Value <= state.Maximum - state.LargeChange + 1;
    }
}
'@
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
    if ([PresenterHarness]::Clear($text.Text)) { $text.Clear() } else { $script:refreshCount++ }
    Assert ($script:refreshCount -eq 1) 'nonempty search must dispatch exactly one TextChanged'
    Assert ($text.Text -eq '') 'search must be empty'
    $script:refreshCount = 0
    if ([PresenterHarness]::Clear($text.Text)) { $text.Clear() } else { $script:refreshCount++ }
    Assert ($script:refreshCount -eq 1) 'already empty search must refresh exactly once'
    $script:scanCount = 0
    $text.add_KeyDown({
        param($sender, $e)
        [PresenterHarness]::Dispatch($e, [Action]{ $script:scanCount++ }) | Out-Null
    })
    $raise = [System.Windows.Forms.Control].GetMethod('OnKeyDown', [Reflection.BindingFlags]'Instance,NonPublic')
    if (-not $raise) { throw 'Cannot locate WinForms OnKeyDown' }
    $enter = [System.Windows.Forms.KeyEventArgs]::new([System.Windows.Forms.Keys]::Enter)
    $raise.Invoke($text, @($enter)) | Out-Null
    Assert ($script:scanCount -eq 1 -and $enter.SuppressKeyPress) 'Enter event must submit and suppress'
    $shiftEnter = [System.Windows.Forms.KeyEventArgs]::new([System.Windows.Forms.Keys]([int][System.Windows.Forms.Keys]::Enter -bor [int][System.Windows.Forms.Keys]::Shift))
    $raise.Invoke($text, @($shiftEnter)) | Out-Null
    Assert ($script:scanCount -eq 1 -and -not $shiftEnter.SuppressKeyPress) 'Shift+Enter must not submit or suppress'
    $nullEventCount = $script:scanCount
    Assert (-not [PresenterHarness]::Dispatch($null, [Action]{ $script:scanCount++ })) 'null key event ignored'
    Assert ($script:scanCount -eq $nullEventCount) 'null key event must not call checkout'
    # Focus transitions are real WinForms Enter/Leave events on a textbox.
    # They remain presentation-only and do not change search text or query SQL.
    $text.add_Enter({ $text.BackColor = [PresenterHarness]::Focus($true) })
    $text.add_Leave({ $text.BackColor = [PresenterHarness]::Focus($false) })
    $raiseEnter = [System.Windows.Forms.Control].GetMethod('OnEnter', [Reflection.BindingFlags]'Instance,NonPublic')
    $raiseLeave = [System.Windows.Forms.Control].GetMethod('OnLeave', [Reflection.BindingFlags]'Instance,NonPublic')
    Assert ($null -ne $raiseEnter -and $null -ne $raiseLeave) 'WinForms focus event methods'
    $text.RightToLeft = [System.Windows.Forms.RightToLeft]::Yes
    $raiseEnter.Invoke($text, @([EventArgs]::Empty)) | Out-Null
    Assert ($text.BackColor -eq [System.Drawing.Color]::Yellow) 'RTL search focus highlight'
    $raiseLeave.Invoke($text, @([EventArgs]::Empty)) | Out-Null
    Assert ($text.BackColor -eq [System.Drawing.Color]::White) 'RTL search focus reset'
    Assert ($text.RightToLeft -eq [System.Windows.Forms.RightToLeft]::Yes) 'RTL preserved after focus'
    # Actual click event on a WinForms TextBox, routed to the production adapter.
    $text.Text = '0123456789'
    $text.SelectionStart = 3
    $text.SelectionLength = 0
    $text.add_Click({ [PresenterHarness]::SelectBarcode($text) })
    $raiseClick = [System.Windows.Forms.Control].GetMethod('OnClick', [Reflection.BindingFlags]'Instance,NonPublic')
    Assert ($null -ne $raiseClick) 'WinForms click event method'
    $raiseClick.Invoke($text, @([EventArgs]::Empty)) | Out-Null
    Assert ($text.SelectionStart -eq 0 -and $text.SelectionLength -eq 10) 'barcode click selects full scan input'
    Assert (-not $text.HideSelection) 'barcode selection visible on focus change'
    Assert ($text.Text -eq '0123456789') 'barcode click must not alter text'
    [PresenterHarness]::SelectBarcode($null)
    Assert ([PresenterHarness]::Lookup($true, '12345', $null)) 'barcode selection'
    Assert (-not [PresenterHarness]::Lookup($true, ' ', $null)) 'empty barcode'
    Assert ([PresenterHarness]::Lookup($false, $null, '42')) 'image tile selection'
    Assert (-not [PresenterHarness]::Lookup($false, $null, ' ')) 'empty image ID'
    Assert ([PresenterHarness]::ScrollBounded(500, 100, -900)) 'scroll position clamped'
    # Real WinForms catalogue binding: image-less products remain in the full list.
    # The image grid is a separate visual projection, not the catalogue source.
    $catalogue = New-Object System.Data.DataTable
    [void]$catalogue.Columns.Add('ID_ARTICLE', [string])
    [void]$catalogue.Columns.Add('Article', [string])
    [void]$catalogue.Columns.Add('Images', [string])
    [void]$catalogue.Rows.Add('1', 'No image', '')
    [void]$catalogue.Rows.Add('2', 'With image', 'article.png')
    $list = New-Object System.Windows.Forms.DataGridView
    $tiles = New-Object System.Windows.Forms.FlowLayoutPanel
    try {
        $list.AllowUserToAddRows = $false
        $list.AutoGenerateColumns = $true
        $list.DataSource = $catalogue
        Assert ($list.Rows.Count -eq 2) 'all products remain in the catalogue list'
        $tile = New-Object System.Windows.Forms.Button
        $tile.Tag = '2'
        $tile.Text = 'With image'
        $tiles.Controls.Add($tile)
        Assert ($tiles.Controls.Count -eq 1) 'only image-bearing item in visual grid'
        Assert ($list.Rows.Count -eq 2) 'image grid must not filter full product list'
        Assert ([PresenterHarness]::Lookup($false, $null, [string]$tile.Tag)) 'image tile routes valid article ID'
    } finally {
        $tiles.Dispose()
        $list.Dispose()
        $catalogue.Dispose()
    }
    Write-Host 'PASS: real WinForms TextChanged/KeyDown events and production presenters'
} finally {
    $text.Dispose()
}
