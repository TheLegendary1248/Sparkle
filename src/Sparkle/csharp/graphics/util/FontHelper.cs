using System.Numerics;
using Raylib_cs;

namespace Sparkle.csharp.graphics.util; 

public static class FontHelper {

    public static Font GetDefault() => Raylib.GetFontDefault();
    public static bool IsReady(Font font) => Raylib.IsFontReady(font);
    
    public static Font Load(string path) => Raylib.LoadFont(path);
    public static Font LoadFromImage(Image image, Color key, int firstChar) => Raylib.LoadFontFromImage(image, key, firstChar);
    public static Font LoadFromMemory(string fileType, byte[] fileData, int fontSize, int[] fontChars, int glyphCount) => Raylib.LoadFontFromMemory(fileType, fileData, fontSize, fontChars, glyphCount);
    public static void Unload(Font font) => Raylib.UnloadFont(font);
    
    public static void DrawFPS(int x, int y) => Raylib.DrawFPS(x, y);
    public static void DrawText(string text, int posX, int posY, int fontSize, Color color) => Raylib.DrawText(text, posX, posY, fontSize, color);
    public static void DrawText(Font font, string text, Vector2 pos, float fontSize, float spacing, Color color) => Raylib.DrawTextEx(font, text, pos, fontSize, spacing, color);
    public static void DrawText(Font font, string text, Vector2 pos, Vector2 origin, float rotation, float fontSize, float spacing, Color color) => Raylib.DrawTextPro(font, text, pos, origin, rotation, fontSize, spacing, color);
    public static void DrawTextCodepoint(Font font, int codepoint, Vector2 pos, float fontSize, Color color) => Raylib.DrawTextCodepoint(font, codepoint, pos, fontSize, color);
    
    public static int MeasureText(string text, int fontSize) => Raylib.MeasureText(text, fontSize);
    public static Vector2 MeasureText(Font font, string text, float fontSize, float spacing) => Raylib.MeasureTextEx(font, text, fontSize, spacing);

    public static int GetGlyphIndex(Font font, int character) => Raylib.GetGlyphIndex(font, character);
    public static GlyphInfo GetGlyphInfo(Font font, int character) => Raylib.GetGlyphInfo(font, character);
    public static Rectangle GetGlyphAtlasRec(Font font, int character) => Raylib.GetGlyphAtlasRec(font, character);
}