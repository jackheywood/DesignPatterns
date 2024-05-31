using System.Text;

namespace Factory.ObjectTracking.Factories;

public class TrackingThemeFactory
{
    private readonly List<WeakReference<ITheme>> _themes = [];

    public string Info => GetInfo();

    public ITheme CreateTheme(bool dark)
    {
        ITheme theme = dark ? new DarkTheme() : new LightTheme();
        _themes.Add(new WeakReference<ITheme>(theme));
        return theme;
    }

    private string GetInfo()
    {
        var stringBuilder = new StringBuilder();

        foreach (var reference in _themes)
        {
            if (!reference.TryGetTarget(out var theme)) continue;

            var dark = theme is DarkTheme;
            stringBuilder.Append(dark ? "Dark" : "Light")
                .AppendLine(" theme");
        }

        return stringBuilder.ToString();
    }
}