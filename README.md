# DHShapeMaker 2.0

**SVG Shape Designer for Paint.NET 5.x**

DHShapeMaker is a powerful Paint.NET plugin that allows you to create, edit, and manipulate vector shapes directly within Paint.NET. Originally created by The Dwarf Horde for Paint.NET 3.5, this 2.0 version has been fully ported to Paint.NET 5.x with modern .NET 9.0 support.

## ✨ Features

### Core Functionality

- **Interactive Shape Design**: Create complex SVG-based shapes using multiple line types
- **6 Line Types**:
  - Straight Lines
  - Ellipses/Arcs
  - Cubic Bézier Curves
  - Smooth Cubic Bézier Curves
  - Quadratic Bézier Curves
  - Smooth Quadratic Bézier Curves
- **Visual Editing**: Click and drag to create and modify control points
- **Background Tracing**: Load an image as background to trace over
- **Shape Library**: Save and load shape designs for reuse

### New in Version 2.0

- 🆕 **Automatic Contour Detection**: Extract edges from background images using Sobel edge detection
  - Adjustable sensitivity (5-100)
  - Configurable detail level (1-10 pixels)
  - Maximum point limit (50-2000)
- **Paint.NET 5.x Support**: Fully compatible with latest Paint.NET version
- **.NET 9.0**: Modern framework with improved performance
- **Enhanced UI**: Better dialog layouts and controls

### Shape Operations

- **Multi-Shape Management**: Work with up to 100 shapes simultaneously
- **Transform Tools**: Rotate, flip horizontal/vertical, scale
- **Loop/Close Paths**: Create closed shapes automatically
- **Undo/Redo**: 15-level undo stack
- **Export Options**: Export as Paint.NET shapes or SVG path geometry

## 📋 Requirements

- **Paint.NET 5.x** (or later)
- **Windows 10/11** with .NET 9.0 Runtime
- **Architecture**: x64 only

## 🚀 Installation

1. **Download** the latest `DHShapeMaker.dll` from the releases
2. **Copy** the DLL to your Paint.NET effects folder:
   - `C:\Program Files\paint.net\Effects\`
3. **Restart** Paint.NET
4. Find the plugin under **Effects** → **Tools** → **Shape Maker**

### Building from Source

Requirements:

- Visual Studio 2022 or later
- .NET 9.0 SDK
- Paint.NET 5.x installed

Steps:

```bash
git clone <repository-url>
cd DHShapeMaker
dotnet build
```

The compiled DLL will be in `bin\Debug\DHShapeMaker.dll`

## 🎨 Usage

### Basic Workflow

1. **Open Paint.NET** and load an image (optional - can be used as tracing background)
2. Navigate to **Effects** → **Tools** → **Shape Maker**
3. **Choose a line type** from the toolbar
4. **Click** on the canvas to add control points
5. **Press Enter** or click **Apply Edit** to finalize the current line
6. **Adjust** rotation using the knob control
7. Click **OK** when finished

### Contour Detection (New!)

1. Load an image to trace
2. Click **"Konturen erkennen"** button or use **Edit** → **Reading contours**
3. Adjust parameters in the dialog:
   - **Sensitivity**: Lower values detect more subtle edges
   - **Detail Level**: Lower values create more points (higher detail)
   - **Max Points**: Limit total points for performance
4. Click **OK** to extract contours
5. Edit the detected contours like any other shape

### Keyboard Shortcuts

- **Enter**: Apply current edit
- **Escape**: Deselect/clear
- **Delete**: Remove selected line
- **Arrow Keys**: Navigate through shapes

## 📁 File Formats

### Save/Load Project

- **Format**: Custom `.shape` project files
- **Contains**: All shapes, line types, and settings
- **Location**: Choose anywhere on your system

### Export PDN Shape

- **Format**: Paint.NET native shape format
- **Use**: Can be loaded as standard Paint.NET shapes

### Export SVG Path

- **Format**: SVG path geometry string
- **Use**: Copy to clipboard for use in other SVG tools

## 🔧 Technical Details

### Architecture

- **Framework**: .NET 9.0 for Windows
- **UI**: Windows Forms
- **Graphics**: System.Drawing with GDI+
- **Plugin Type**: Paint.NET Effect Plugin (Classic System)

### Performance

- Optimized for up to 2000 points per contour
- 15-level undo buffer
- Real-time preview rendering
- Efficient Sobel edge detection algorithm

## 📝 Version History

### Version 2.0.0 (2025)

- Complete port to Paint.NET 5.x
- Upgraded to .NET 9.0
- Added automatic contour detection with Sobel edge detection
- Improved UI with parameter dialogs
- Fixed coordinate normalization for proper rendering
- Enhanced edge detection with configurable parameters

### Version 1.x (2015)

- Original release for Paint.NET 3.5
- Basic shape creation and editing
- SVG path support

## 🤝 Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs and feature requests.

## 📄 License

This project is licensed under the **GNU General Public License v2.0** (June 1991).

```
DHShapeMaker - SVG Shape Designer for Paint.NET
Copyright (C) 2015-2025 The Dwarf Horde

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License along
with this program; if not, write to the Free Software Foundation, Inc.,
51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
```

See [LICENSE.md](LICENSE.md) for the full license text.

## 🙏 Credits

- **Original Author**: The Dwarf Horde (2015)
- **Paint.NET 5.x Port**: 2025
- **SVG Library**: Based on svg.codeplex.com components
- **Paint.NET**: Rick Brewster and contributors

## 📞 Support

For issues, questions, or feature requests, please:

- Open an issue on the project repository
- Check existing issues for similar problems
- Provide Paint.NET version and error details when reporting bugs

## 🔗 Links

- [Paint.NET Official Website](https://www.getpaint.net/)
- [Paint.NET Forum](https://forums.getpaint.net/)
- [GNU GPL v2 License](https://www.gnu.org/licenses/old-licenses/gpl-2.0.html)

---

**Made with ❤️ for the Paint.NET community**
