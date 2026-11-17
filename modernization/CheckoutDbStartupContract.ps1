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
    $exeStart = [regex]::Match($LauncherSource, 'Start-Process[^\r\n]*LOGICA\.exe[^\r\n]*')
    $launcherLoopback = $LauncherSource.Contains('--bind-address=127.0.0.1') -and
        $LauncherSource.Contains('Connect(''127.0.0.1'',$Port)')
    $exportEndpoint = $envExport.Success -and
        $envExport.Groups['value'].Value.Contains('Server=127.0.0.1;Port=$Port;')
    $exportBeforeExe = $envExport.Success -and $exeStart.Success -and
        $envExport.Index -lt $exeStart.Index
    # A TCP listener is not proof that the local MariaDB instance accepted
    # the launcher credentials. Model startup ordering separately from the
    # authenticated SQL probe, without executing either command here.
    $serverStart = [regex]::Match($LauncherSource,
        '(?m)^\s*\$process\s*=\s*Start-Process[^\r\n]*mariadbd\.exe[^\r\n]*')
    $probe = [regex]::Match($LauncherSource,
        'Connect\(''127\.0\.0\.1'',\s*\$Port\)')
    $readyGuard = [regex]::Match($LauncherSource,
        'if\s*\(\s*-not\s+\$ready\s*\)\s*\{\s*throw')
    $serverUsesConfiguredPort = $serverStart.Success -and
        $serverStart.Value.Contains('"--port=$Port"')
    $orderedReadiness = $serverStart.Success -and $probe.Success -and
        $readyGuard.Success -and $envExport.Success -and $exeStart.Success -and
        $serverStart.Index -lt $probe.Index -and
        $probe.Index -lt $readyGuard.Index -and
        $readyGuard.Index -lt $envExport.Index -and
        $envExport.Index -lt $exeStart.Index
    $waitsForExe = $exeStart.Success -and
        [regex]::IsMatch($exeStart.Value, '-Wait\b')
    $authQuery = [regex]::Match($LauncherSource,
        '(?m)^\s*\$counts\s*=\s*&\s*"\$ServerBin/mariadb\.exe"')
    $authQueryBeforeExe = $authQuery.Success -and $exeStart.Success -and
        $authQuery.Index -lt $exeStart.Index
    $rejectsFailedAuthQuery = $false
    if ($authQueryBeforeExe) {
        $afterAuth = $LauncherSource.Substring($authQuery.Index,
            $exeStart.Index - $authQuery.Index)
        $rejectsFailedAuthQuery = [regex]::IsMatch($afterAuth,
            'if\s*\(\s*\$LASTEXITCODE\s*-ne\s*0\s*\)\s*\{\s*throw')
    }
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
        LauncherStartsAndProbesBeforeExport = ($orderedReadiness -and
            $serverUsesConfiguredPort)
        LauncherWaitsForExe = $waitsForExe
        LauncherRunsAuthenticatedQueryBeforeExe = $authQueryBeforeExe
        LauncherRejectsFailedAuthenticatedQuery = $rejectsFailedAuthQuery
        DirectExeServerIsDynamic = $dynamicDirectServer
        # Kept for compatibility with existing consumers: port-only comparison.
        BareExeMatchesLauncher = ($direct -eq $launcher)
        BareExeEndpointProvenEquivalent = ($direct -eq $launcher -and
            $literalDirectLoopback -and -not $dynamicDirectServer)
        LauncherPassesEndpoint = ($envRead -and $exportBeforeExe -and
            $launcherLoopback -and $exportEndpoint -and $orderedReadiness -and
            $serverUsesConfiguredPort -and $waitsForExe)
    }
}
