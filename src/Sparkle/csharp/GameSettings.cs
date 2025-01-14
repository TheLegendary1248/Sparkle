using System.Drawing;
using System.Reflection;
using Raylib_cs;

namespace Sparkle.csharp;

public class GameSettings {
    
    public string Title;
    public Size Size;
    public string IconPath;
    public string ContentDirectory;
    public string LogDirectory;
    public int TargetFps;
    public bool Headless;
    public ConfigFlags[] WindowStates;
    
    public GameSettings() {
        this.Title = Assembly.GetEntryAssembly()!.GetName().Name ?? "Sparkle";
        this.Size = new Size(1280, 720);
        this.IconPath = string.Empty;
        this.LogDirectory = "logs";
        this.ContentDirectory = "content";
        this.TargetFps = 0;
        this.Headless = false;
        this.WindowStates = new[] {
            ConfigFlags.FLAG_VSYNC_HINT,
            ConfigFlags.FLAG_WINDOW_RESIZABLE
        };
    }
}