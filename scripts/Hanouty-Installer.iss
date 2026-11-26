; HANOUTY POS V2.0 — Standalone Windows Installer (Inno Setup 6+)
#define MyAppName "HANOUTY POS"
#define MyAppVersion "2.0.0"
#define MyAppPublisher "HANOUTY"
#define MyAppExeName "Hanouty.Desktop.Bootstrap.exe"
#ifndef PublishDir
  #define PublishDir "..\dist\publish"
#endif

[Setup]
AppId={{8F6E1C4B-4E7D-4C2B-9A3E-202611240001}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\HANOUTY POS
DefaultGroupName=HANOUTY POS
OutputDir=..\dist\installer
OutputBaseFilename=HANOUTY-POS-V2-Setup-win-x64
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
PrivilegesRequired=lowest

[Languages]
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "Créer un raccourci sur le Bureau"; GroupDescription: "Raccourcis :"

[Files]
Source: "{#PublishDir}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\HANOUTY POS"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\Configurer le poste"; Filename: "{app}\{#MyAppExeName}"; Parameters: "--configure-workstation"
Name: "{autodesktop}\HANOUTY POS"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Parameters: "--configure-workstation"; Description: "Configurer la base locale et le poste"; Flags: nowait postinstall skipifsilent
