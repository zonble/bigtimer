@echo off
REM Simple build script for BigTimer
REM This script demonstrates the build process used in GitHub Actions

echo Building BigTimer...
echo.

echo Step 1: Checking for solution file...
if not exist "BigTimer.sln" (
    echo ERROR: BigTimer.sln not found in current directory
    echo Please run this script from the repository root
    exit /b 1
)
echo Found BigTimer.sln

echo.
echo Step 2: Building solution...
echo This would run: msbuild BigTimer.sln /p:Configuration=Release /p:Platform="Any CPU"
echo.
echo Note: This script is for demonstration purposes.
echo To actually build, you need:
echo - Visual Studio or Build Tools for Visual Studio
echo - MSBuild in your PATH
echo - .NET Framework 2.0 or later
echo.

echo Step 3: Expected output location...
echo After successful build, executable will be at:
echo BigTimer\bin\Release\BigTimer.exe
echo.

echo GitHub Actions CI will automatically:
echo - Build on latest Windows with Visual Studio
echo - Archive the Release build artifacts
echo - Make artifacts available for download

pause