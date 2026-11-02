Set-StrictMode -Version Latest
function Get-CheckoutDbStartupContract {
    param(
        [Parameter(Mandatory=$true)][string]$ModuleSource,
        [Parameter(Mandatory=$true)][string]$LauncherSource
    )
    # Read-only source contract: no connection, credential evaluation or store mutation.
    $directPort = [regex]::Match($ModuleSource, '_PORT_DB\s*=\s*"(?<port>\d+)"\s*;')
    $launcherPort = [regex]::Match($LauncherSource, '\[int\]\s*\$Port\s*=\s*(?<port>\d+)')
    $envRead = $ModuleSource.Contains('Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING")')
    $envExport = [regex]::Match($LauncherSource, '(?m)^\s*\$env:LOGICA_DB_CONNECTION_STRING\s*=\s*"(?<value>[^"\r\n]*)"')
    $exeStart = [regex]::Match($LauncherSource, 'Start-Process[^\r\n]*LOGICA\.exe')
    $launcherLoopback = $LauncherSource.Contains('--bind-address=127.0.0.1') -and
        $LauncherSource.Contains("Connect('127.0.0.1',\$Port)")
    $exportEndpoint = $envExport.Success -and
        $envExport.Groups['value'].Value.Contains('Server=127.0.0.1;Port=$Port;')
    $exportBeforeExe = $envExport.Success -and $exeStart.Success -and
        $envExport.Index -lt $exeStart.Index
    # Unlike the launcher, the original EXE takes its fallback server from a
    # form label. Equal port numbers alone cannot establish equal endpoints.
    $dynamicDirectServer = $ModuleSource.Contains('Server = _CHEMIN_DB') -and
        [regex]::IsMatch($ModuleSource, '_CHEMIN_DB\s*=\s*[^;]*Label_DB\.Text\s*;')
    $literalDirectLoopback = [regex]::IsMatch($ModuleSource,
        'Server\s*=\s*"127\.0\.0\.1"')
    if (-not $directPort.Success -or -not $launcherPort.Success) {
        throw 'Cannot identify the direct EXE fallback and launcher default DB ports; review startup code.'
    }
    $direct = [int]$directPort.Groups['port'].Value
    $launcher = [int]$launcherPort.Groups['port'].Value
    [pscustomobject]@{
        DirectExeFallbackPort = $direct
        LauncherDefaultPort = $launcher
        DirectExeAcceptsEnvironmentOverride = $envRead
        LauncherExportsEnvironmentOverride = $envExport.Success
        LauncherStartsExeAfterExport = $exportBeforeExe
        LauncherUsesLoopbackEndpoint = ($launcherLoopback -and $exportEndpoint)
        DirectExeServerIsDynamic = $dynamicDirectServer
        # Kept for compatibility with existing consumers: port-only comparison.
        BareExeMatchesLauncher = ($direct -eq $launcher)
        BareExeEndpointProvenEquivalent = ($direct -eq $launcher -and
            $literalDirectLoopback -and -not $dynamicDirectServer)
        LauncherPassesEndpoint = ($envRead -and $exportBeforeExe -and
            $launcherLoopback -and $exportEndpoint)
    }
}
