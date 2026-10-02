@echo off
setlocal
pushd "%~dp0"
if errorlevel 1 exit /b 1

where dotnet >nul 2>nul
if errorlevel 1 (
    echo .NET SDK is required. Install it and reopen this window.
    set "buildExitCode=1"
    goto finish
)

dotnet build ExampleMod.csproj -c Release --nologo
set "buildExitCode=%errorlevel%"
if not "%buildExitCode%"=="0" echo Build failed. See the error above.

:finish
popd
if /i not "%~1"=="--no-pause" pause
exit /b %buildExitCode%
