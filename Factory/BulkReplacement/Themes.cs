namespace Factory.BulkReplacement;

public interface ITheme
{
    string TextColour { get; }
    string BackgroundColour { get; }
}

public class LightTheme : ITheme
{
    public string TextColour => "black";
    public string BackgroundColour => "white";

    public override string ToString() => this.ToFormattedString();
}

public class DarkTheme : ITheme
{
    public string TextColour => "white";
    public string BackgroundColour => "dark gray";
    
    public override string ToString() => this.ToFormattedString();
}

public static class ThemeExtensions
{
    public static string ToFormattedString(this ITheme theme) =>
        $"Text Colour: {theme.TextColour}, Background Colour: {theme.BackgroundColour}";
}