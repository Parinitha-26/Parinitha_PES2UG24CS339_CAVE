# Seminar Hall Simulation using Unity

## Project Overview

This project is a 3D Seminar Hall Simulation developed in Unity. The scene includes a seminar hall environment with tables, chairs, walls, stage area, lighting system, presentation screen, and interactive UI controls.

## Features

### 1. Light Control
- Toggle seminar hall lights ON/OFF using a UI button.
- Multiple point lights are controlled simultaneously through a Unity script.

### 2. Camera View Switching
- Switch between multiple camera views.
- Different camera angles provide front, top, and alternate perspectives of the seminar hall.

### 3. Presentation Screen Control
- Open and close the presentation screen panel using a UI button.
- Controlled using the `ScreenToggle.cs` script.

### 4. Object Highlighting
- Selected objects can be highlighted when clicked.
- Helps users identify important objects within the scene.

### 5. Interactive User Interface
- UI buttons created using Unity Canvas.
- Controls lighting, camera switching, and presentation screen interactions.

## Technologies Used

- Unity 6
- C#
- Blender
- FBX Exporter
- TextMesh Pro

## Project Structure

```
Assets/
├── Materials/
├── Prefabs/
├── Scenes/
│   └── seminarhall.unity
├── Scripts/
│   ├── LightToggle.cs
│   ├── CameraSwitch.cs
│   ├── ScreenToggle.cs
│   └── ObjectHighlight.cs
└── Models/
    └── seminarHall.fbx
```

## How to Run

1. Open the project in Unity.
2. Open the scene:
   Assets/Scenes/seminarhall.unity
3. Press the Play button.
4. Use:
   - Toggle Lights button to switch lights ON/OFF.
   - Camera Switch button to cycle through camera views.
   - Screen Toggle button to open/close the presentation screen.
   - Click objects to highlight them.

## Learning Outcomes

Through this project, the following concepts were implemented and learned:

- Unity Scene Management
- UI Canvas and Buttons
- Camera Management
- Light Components and Control
- Object Interaction and Highlighting
- Presentation Screen Toggle Functionality
- C# Scripting
- FBX Model Integration
- Material Manipulation
- Interactive User Experience Design

## Exported Assets

The seminar hall model has also been exported as:

```
seminarHall.fbx
```

for reuse in other 3D applications.

## Author

Parinitha
