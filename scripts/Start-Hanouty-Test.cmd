@echo off
setlocal
powershell.exe -NoLogo -NoProfile -ExecutionPolicy Bypass -File "%~dp0Start-Hanouty-Test.ps1"
if errorlevel 1 (
  echo.
  echo Hanouty test setup failed. Read the message above and send a screenshot.
  pause
)
