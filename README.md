# PaintingApp 🎨

A feature-rich Windows Forms drawing application built in C# that demonstrates solid object-oriented programming principles. Create, manipulate, and manage geometric shapes with an intuitive interface.

##  Features

### Drawing Capabilities
- **Shape Creation**: Draw rectangles, circles, triangles, and hexagons
- **Color Selection**: Choose from a full color palette before drawing
- **Precision Drawing**: Click and drag to define shape dimensions

### Shape Management
- **Selection**: Click on shapes to select them
- **Movement**: Drag selected shapes to new positions
- **Deletion**: Remove individual shapes or clear the entire canvas
- **Visual Feedback**: Selected shapes are highlighted using dotted borders for clear identification.

### File Operations
- **Save Projects**: Export your drawings to `.txt` files
- **Load Projects**: Import previously saved drawings
- **Cross-Session Persistence**: Continue working on saved projects

##  Screenshots

*Note: Add screenshots here showing the main interface, drawing in action, and the color picker*



##  Usage Guide

### Basic Drawing
1. **Select a Shape**: Click one of the shape buttons (Rectangle, Circle, Triangle, Hexagon)
2. **Choose a Color**: Click the color button to open the color picker
3. **Draw**: Click and drag on the canvas to create your shape

### Shape Manipulation
- **Select**: Click on any shape to select it (it will be highlighted)
- **Move**: Drag a selected shape to move it around the canvas
- **Delete**: 
  - Select a shape and press `Delete` key, or
  - Use the "Delete Selected" button, or
  - Use "Clear All" to remove everything

### File Operations
- **Save**: Click "Save" to export your drawing as a `.txt` file
- **Load**: Click "Load" to import a previously saved drawing
- **File Location**: Files are saved in a human-readable text format

### Project Structure
```
PaintingApp/
├── 📁 Forms/
│   ├── MainForm.cs              # Main application window
│   ├── MainForm.Designer.cs     # UI layout and controls
│   └── MainForm.resx            # Form resources
├── 📁 Shapes/
│   ├── Shape.cs                 # Abstract base class
│   ├── RectangleShape.cs        # Rectangle implementation
│   ├── CircleShape.cs           # Circle implementation
│   ├── TriangleShape.cs         # Triangle implementation
│   └── HexagonShape.cs          # Hexagon implementation
├── 📁 Helpers/
│   └── ShapeSerializer.cs       # File save/load operations
├── 📁 Properties/
│   └── AssemblyInfo.cs          # Application metadata
├── Program.cs                   # Application entry point
├── PaintingApp.csproj           # Project configuration
├── PaintingApp.sln              # Solution file
└── README.md                    # This file
```





*For questions, suggestions, or bug reports, please [open an issue](../../issues) on GitHub.*
