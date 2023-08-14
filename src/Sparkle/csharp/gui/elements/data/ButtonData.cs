using Raylib_cs;
using Sparkle.csharp.graphics.util;

namespace Sparkle.csharp.gui.elements.data; 

public class ButtonData {
    
    public Texture2D Texture;
    public Color Color;
    public Color DefaultColor { get; private set; }
    public Color HoverColor;

    public ButtonData() {
        this.Texture = TextureHelper.LoadFromImage(ImageHelper.GenColor(10, 10, Color.WHITE));
        this.Color = Color.WHITE;
        this.DefaultColor = this.Color;
        this.HoverColor = Color.LIGHTGRAY;
    }
}