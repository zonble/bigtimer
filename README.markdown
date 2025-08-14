# BigTimer

[![Build BigTimer](https://github.com/zonble/bigtimer/actions/workflows/build.yml/badge.svg)](https://github.com/zonble/bigtimer/actions/workflows/build.yml)

A simple, lightweight stopwatch application for Windows built with C# and Windows Forms.

## Overview

BigTimer is a minimalist timer/stopwatch application designed to help you track elapsed time with precision. Originally created in 2008, this legacy Windows application provides a clean, easy-to-use interface for timing activities.

## Features

- **Precise Timing**: Displays time in HH:MM:SS.MS format (hours:minutes:seconds.centiseconds)
- **Simple Controls**: Start, Stop, and Reset (Zero) functionality
- **Copy to Clipboard**: Easily copy the current time reading
- **Multilingual Support**: Includes Chinese (Traditional) localization
- **Clean Interface**: Minimal, distraction-free design
- **Lightweight**: Small footprint Windows Forms application

## System Requirements

- **Operating System**: Windows XP or later
- **.NET Framework**: 2.0 or higher
- **Visual Studio**: 2005 or later (for building from source)

## Installation

### Pre-built Application
1. Download the latest release from the releases section
2. Run the installer (`BigTimerInstaller`)
3. Launch BigTimer from your Start Menu or Desktop

### Building from Source
1. Clone this repository:
   ```
   git clone https://github.com/zonble/bigtimer.git
   ```
2. Open `BigTimer.sln` in Visual Studio 2005 or later
3. Build the solution (Build → Build Solution)
4. Run the executable from `BigTimer/bin/Debug/` or `BigTimer/bin/Release/`

## Usage

1. **Start Timing**: Click the "Start" button to begin the timer
2. **Stop Timing**: Click the "Stop" button to pause the timer (time accumulates)
3. **Reset Timer**: Click the "Zero" button to reset the timer to 00:00:00.00
4. **Copy Time**: Right-click to access the context menu and copy current time to clipboard

The timer continues to accumulate time even when stopped and restarted, making it useful for tracking total work time across breaks.

## Technical Details

- **Language**: C# (.NET Framework 2.0)
- **UI Framework**: Windows Forms
- **Timer Precision**: 100ms intervals (centisecond precision)
- **Architecture**: Single-threaded Windows desktop application

## Project Structure

```
BigTimer/
├── BigTimer/              # Main application source code
│   ├── BigTimer.cs        # Main timer form logic
│   ├── AboutForm.cs       # About dialog
│   ├── Program.cs         # Application entry point
│   └── Properties/        # Assembly information and resources
├── BigTimerInstaller/     # Windows installer project
└── README.markdown        # This file
```

## Legacy Status

This is a legacy project from 2008, maintained for historical purposes and simple timing needs. While it continues to work on modern Windows systems, it uses older .NET Framework technologies.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

Copyright © 2008 zonble

## Contributing

This is a legacy project. For modern timer applications, consider using newer frameworks and technologies.

---

*For more information, visit the [project repository](https://github.com/zonble/bigtimer).*