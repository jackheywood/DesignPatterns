namespace Factory.ObjectTracking;

public interface ITheme
{
    string TextColour { get; }
    string BackgroundColour { get; }
}

public class LightTheme : ITheme
{
    public string TextColour => "black";
    public string BackgroundColour => "white";
}

public class DarkTheme : ITheme
{
    public string TextColour => "white";
    public string BackgroundColour => "dark gray";
}