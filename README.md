# ViConnect Music Player

A modern, sleek desktop music player built with C# and Windows Forms featuring a contemporary dark UI and SQLite database integration.

![Version](https://img.shields.io/badge/version-1.0.0-blue)
![.NET](https://img.shields.io/badge/.NET-Windows%20Forms-purple)
![License](https://img.shields.io/badge/license-MIT-green)

## Features

### 🎵 Core Functionality
- **Play, Pause, Stop** controls for seamless playback
- **Next/Previous Track** navigation
- **Progress Bar** with click-to-seek functionality
- **Volume Control** with visual slider and percentage display
- **Album Art Display** with automatic metadata extraction
- **Playlist Management** with persistent storage

### ⚡ Advanced Controls
- **Repeat Mode** - Loop current track
- **Shuffle Mode** - Random playback order
- **Mute Toggle** - Quick audio muting
- **Skip Forward/Backward** - Jump ±5 seconds
- **Remove Tracks** - Delete songs from playlist

### ⌨️ Keyboard Shortcuts
- `Space` - Play/Pause toggle
- `Up Arrow` - Increase volume (+5%)
- `Down Arrow` - Decrease volume (-5%)
- `Right Arrow` - Skip forward 5 seconds
- `Left Arrow` - Skip backward 5 seconds
- `M` - Mute/Unmute
- `S` - Toggle shuffle
- `R` - Toggle repeat

### 🎨 Modern UI Design
- **Dark Theme** - Easy on the eyes
- **Purple Accent Colors** - Modern aesthetic
- **Flat Design** - Clean and contemporary
- **Smooth Hover Effects** - Interactive feedback
- **Responsive Layout** - Optimized spacing

## Screenshots

```
┌─────────────────────────────────────────┐
│  ViConnect Music Player                 │
├─────────────────────────────────────────┤
│  [Album Art]  │  [Track List]           │
│               │                          │
│               │  ♪ Song 1.mp3           │
│               │  ♪ Song 2.mp3           │
│               │                          │
│  🔁 🔀 🔇    │  [Volume]    [Remove]   │
├─────────────────────────────────────────┤
│  0:00  ████████░░░░░░░░░░░░  3:45       │
│  ⏮  ⏭  ▶  ⏸  ⏹      [Add]             │
└─────────────────────────────────────────┘
```

## Technology Stack

- **Framework**: .NET Windows Forms
- **Language**: C# 
- **Database**: SQLite 3
- **Media Player**: Windows Media Player ActiveX Control
- **Metadata**: TagLib# (TagLib-Sharp)
- **Configuration**: System.Configuration

## Prerequisites

- Windows OS (7, 8, 10, 11)
- .NET Framework 4.7.2 or higher / .NET 6.0+
- Windows Media Player installed

## Installation

### NuGet Packages Required

```bash
Install-Package System.Data.SQLite
Install-Package TagLibSharp
Install-Package System.Configuration.ConfigurationManager
```

### Manual Setup

1. Clone the repository
```bash
git clone https://github.com/yourusername/viconnect-music-player.git
cd viconnect-music-player
```

2. Open `Project_Mp.sln` in Visual Studio

3. Restore NuGet packages

4. Build the solution (Ctrl + Shift + B)

5. Run the application (F5)

## Database Setup

The application uses SQLite for persistent playlist storage. The database file `songs.db` will be created automatically on first run with the following schema:

```sql
CREATE TABLE Songs (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Path TEXT NOT NULL
);
```

### Connection String

Located in `App.config`:
```xml
<connectionStrings>
    <add name="Default" 
         connectionString="Data Source=.\songs.db;Version=3;" 
         providerName="System.Data.SqlClient"/>
</connectionStrings>
```

## Usage

### Adding Songs
1. Click the **Add** button
2. Select one or multiple audio files
3. Supported formats: `.mp3`, `.wav`, `.m4a`, `.wma`, `.aac`
4. Songs are automatically saved to the database

### Playing Music
1. Select a track from the playlist
2. Click the **Play** button or double-click the track
3. Use controls to manage playback

### Managing Playlist
- **Remove**: Select a track and click **Remove**
- **Navigate**: Use Previous/Next buttons
- **Seek**: Click anywhere on the progress bar

## Project Structure

```
Project_Mp/
├── Form1.cs                 # Main form logic
├── Form1.Designer.cs        # UI design and styling
├── Program.cs               # Application entry point
├── App.config              # Configuration and connection strings
├── songs.db                # SQLite database (auto-generated)
└── README.md               # This file
```

## Configuration

### Color Scheme (Original)

The original UI uses the following color palette:

| Element | Color (RGB) | Hex |
|---------|-------------|-----|
| Form Background | `0, 0, 0` | `#000000` |
| Panel Background | `192, 0, 0` | `#C00000` |
| Button Background | `0, 0, 0` | `#000000` |
| Text Color (Primary) | `255, 128, 0` | `#FF8000` |
| Text Color (Secondary) | `255, 255, 255` | `#FFFFFF` |
| Volume Track | `192, 0, 0` | `#C00000` |

### Customization

To modify the color scheme, edit the `Form1.Designer.cs` file and update the `Color.FromArgb()` values.

## Known Issues

- Windows Media Player control requires Windows OS
- Some audio formats may require additional codecs
- Album art extraction depends on file metadata

## Future Enhancements

- [ ] Equalizer controls
- [ ] Create/save multiple playlists
- [ ] Search and filter functionality
- [ ] Drag-and-drop file support
- [ ] Mini player mode
- [ ] Lyrics display
- [ ] Audio visualization
- [ ] Cross-platform support (.NET MAUI)

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Windows Media Player for media playback
- TagLib# for metadata extraction
- SQLite for lightweight database solution
- Modern UI design inspired by Spotify and Apple Music

## Contact

Project Link: [https://github.com/yourusername/viconnect-music-player](https://github.com/yourusername/viconnect-music-player)

---

**Made with ♥ and C#**
