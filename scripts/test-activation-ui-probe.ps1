# Synthetic read-only activation UI probe regression; no real license or database.
$ErrorActionPreference = 'Stop'
$work = Join-Path $env:RUNNER_TEMP ('logica-activation-probe-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $work -Force | Out-Null
$source = Join-Path $work 'Fixture.cs'
$exe = Join-Path $work 'ActivationFixture.exe'
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
if (-not (Test-Path -LiteralPath $compiler)) { throw 'Windows .NET Framework C# compiler missing' }
$code = @'
using System;
using System.Drawing;
using System.Windows.Forms;
public static class ActivationFixture {
    [STAThread]
    public static void Main(string[] args) {
        Application.EnableVisualStyles();
        using (var window = new Form()) {
            window.Name = "FixtureWindow";
            window.Text = "Isolated QA activation fixture";
            window.Size = new Size(600, 400);
            var panel = new Panel();
            panel.Name = "Panel_cl\u00e9";
            panel.Size = new Size(420, 180);
            panel.Location = new Point(30, 30);
            panel.Visible = args.Length == 0 || args[0] != "hidden";
            var label = new Label();
            label.Name = "Label13";
            label.Text = "Cl\u00e9 d'activation :";
            label.AutoSize = true;
            panel.Controls.Add(label);
            window.Controls.Add(panel);
            Application.Run(window);
        }
    }
}
'@
$code | Set-Content -LiteralPath $source -Encoding UTF8
& $compiler /nologo /target:winexe /r:System.Windows.Forms.dll /r:System.Drawing.dll "/out:$exe" $source
if ($LASTEXITCODE -ne 0) { throw 'Synthetic WinForms activation fixture compilation failed' }
try {
    foreach ($mode in @('visible', 'hidden')) {
        $process = $null
        try {
            $process = Start-Process -FilePath $exe -ArgumentList $mode -WorkingDirectory $work -PassThru
            $ready = $false
            for ($i = 0; $i -lt 20; $i++) {
                Start-Sleep -Milliseconds 500
                $process.Refresh()
                if ($process.HasExited) { break }
                if ($process.MainWindowHandle -ne 0 -and $process.Responding) { $ready = $true; break }
            }
            if (-not $ready) { throw "Synthetic $mode WinForms fixture did not open" }
            $json = Join-Path $work ("activation-$mode.json")
            & powershell.exe -NoLogo -NoProfile -ExecutionPolicy Bypass -File (Join-Path $PSScriptRoot 'probe-activation-ui.ps1') -TargetProcessId $process.Id -OutputPath $json
            if ($LASTEXITCODE -ne 0) { throw "Activation UI probe failed: $mode" }
            $report = Get-Content -LiteralPath $json -Raw | ConvertFrom-Json
            if ($report.inspectionStatus -ne 'inspected' -or $report.licensedCashierVerified -ne $false) {
                throw "Activation UI probe did not inspect $mode fixture safely"
            }
            if ($mode -eq 'visible' -and $report.activationScreenVisible -ne $true) {
                throw 'Visible activation screen not detected by read-only UI Automation probe'
            }
            if ($mode -eq 'hidden' -and $report.activationScreenVisible -eq $true) {
                throw 'Hidden activation screen incorrectly classified as visible'
            }
            Write-Host "PASS: read-only activation probe correctly classified synthetic $mode screen"
        } finally {
            if ($process) {
                try { $process.Refresh(); if (-not $process.HasExited) { $process.Kill(); $process.WaitForExit(10000) | Out-Null } } catch {}
            }
        }
    }
} finally {
    Remove-Item -LiteralPath $work -Recurse -Force -ErrorAction SilentlyContinue
}
