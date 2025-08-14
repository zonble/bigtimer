# BigTimer - Windows Forms Timer Application

BigTimer is a simple Windows Forms timer application written in C# targeting .NET Framework 4.0. It provides a basic countdown/stopwatch functionality with traditional Chinese localization support.

Always reference these instructions first and fallback to search or bash commands only when you encounter unexpected information that does not match the info here.

## Working Effectively

### Bootstrap and Build the Repository

**CRITICAL**: Always fix the missing resource file first before any build attempts:
- `cd /home/runner/work/bigtimer/bigtimer/BigTimer`
- `cp AboutForm.resx AboutForm.zh-TW.resx`

**Install Dependencies**:
- `sudo apt update`
- `sudo apt install -y mono-complete mono-mcs` -- takes 2-3 minutes to complete. NEVER CANCEL. Set timeout to 10+ minutes.

**Build Commands**:
- `cd /home/runner/work/bigtimer/bigtimer`
- `xbuild BigTimer.sln` -- builds Debug configuration, takes under 2 seconds
- `xbuild BigTimer.sln /property:Configuration=Release` -- builds Release configuration, takes under 2 seconds
- `xbuild BigTimer.sln /target:Clean` -- cleans build artifacts
- `xbuild BigTimer.sln /target:Rebuild` -- clean rebuild, takes under 2 seconds

**Build individual project**:
- `xbuild BigTimer/BigTimer.csproj` -- builds just the main application

### Validation

- ALWAYS run the bootstrapping steps (install mono and fix missing resource file) before any build attempts.
- ALWAYS validate builds work by running `xbuild BigTimer.sln` after making code changes.
- The application builds successfully but CANNOT be manually tested via GUI in a headless Linux environment.
- Build output is located in `BigTimer/bin/Debug/BigTimer.exe` and `BigTimer/bin/Release/BigTimer.exe`.
- Application loads via Mono but requires X server for GUI, so expect "Could not open display" errors when trying to run.

**Manual Testing Limitation**: This is a Windows Forms GUI application that cannot be functionally tested in a headless environment. You can only validate that it compiles and loads without throwing compilation errors.

### Repository Structure

- **Main Application**: `BigTimer/` - Contains the core timer application
- **Installer**: `BigTimerInstaller/` - Contains Windows installer project (does not build on Linux)
- **Solution File**: `BigTimer.sln` - Main Visual Studio solution file

### Known Issues and Workarounds

1. **Missing Resource File**: The project references `AboutForm.zh-TW.resx` but the file doesn't exist in the repository.
   - **Workaround**: Copy `AboutForm.resx` to `AboutForm.zh-TW.resx` before building
   - **Always do this first** before any build attempts

2. **Installer Project**: The BigTimerInstaller project uses a .vdproj format that doesn't build on Linux/Mono.
   - **Expected behavior**: Build warnings about invalid data and missing project configuration
   - **Impact**: Main application builds successfully despite installer warnings

3. **xbuild Deprecation**: The build system shows warnings that xbuild is deprecated.
   - **Current approach**: Continue using xbuild as it works reliably
   - **Future consideration**: Could migrate to newer MSBuild if needed

### Testing

- **No unit tests exist** in this repository
- **No test framework** is configured
- **No CI/CD** workflows exist
- **Manual testing** is limited to verifying compilation success on Linux

### Linting and Code Quality

- **No linting tools** are configured in this repository
- **No code analysis** rules are defined
- **No formatting tools** are setup
- Code follows basic C# conventions but no automated enforcement exists

### Build Timing Expectations

- **Mono installation**: 2-3 minutes (with package downloads)
- **Clean build**: Under 2 seconds
- **Rebuild**: Under 2 seconds  
- **Resource file copy**: Instant
- **NEVER CANCEL** any operation - all are very fast or have legitimate reasons for duration

### Common Tasks

#### Full Bootstrap (First Time Setup)
```bash
cd /home/runner/work/bigtimer/bigtimer
# Fix missing resource file
cd BigTimer && cp AboutForm.resx AboutForm.zh-TW.resx && cd ..
# Install build tools  
sudo apt update && sudo apt install -y mono-complete mono-mcs
# Build application
xbuild BigTimer.sln
```

#### Development Workflow
```bash
cd /home/runner/work/bigtimer/bigtimer
# After making code changes
xbuild BigTimer.sln
# Verify no compilation errors
echo $?  # Should be 0 for success
```

#### Verify Application Loads
```bash
cd /home/runner/work/bigtimer/bigtimer/BigTimer
# This will show X server error but confirms app loads correctly
mono bin/Debug/BigTimer.exe --help 2>&1 || echo "GUI app loaded (X server error expected)"
```

## Common Commands Output Reference

### Repository Root Structure
```
ls -la /home/runner/work/bigtimer/bigtimer/
.git/
.gitignore
BigTimer/           # Main application project
BigTimer.sln        # Solution file
BigTimerInstaller/  # Windows installer project (Linux incompatible)
README.markdown     # Empty file
```

### Build Output Structure
```
BigTimer/bin/Debug/
BigTimer.exe        # Main executable (PE32 format)
BigTimer.exe.mdb    # Debug symbols
zh-TW/              # Chinese localization resources
  BigTimer.resources.dll
```

### Typical Build Success Output
```
Build succeeded.
Warnings: 3 Warning(s) (about installer project - expected)
Errors: 0 Error(s)
Time Elapsed 00:00:00.xxxx (under 2 seconds)
```

Always remember to fix the missing resource file issue before building, and expect installer-related warnings which don't affect the main application build.