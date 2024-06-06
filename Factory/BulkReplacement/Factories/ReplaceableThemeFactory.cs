namespace Factory.BulkReplacement.Factories;

public class ReplaceableThemeFactory
{
    private readonly List<WeakReference<Ref<ITheme>>> _themes = [];

    public Ref<ITheme> CreateTheme(bool dark)
    {
        var themeRef = new Ref<ITheme>(CreateThemeImpl(dark));
        _themes.Add(new WeakReference<Ref<ITheme>>(themeRef));
        return themeRef;
    }

    // Relies on user not unwrapping the value from Ref
    public void ReplaceTheme(bool dark)
    {
        foreach (var theme in _themes)
        {
            if (theme.TryGetTarget(out var reference))
            {
                reference.Value = CreateThemeImpl(dark);
            }
        }
    }

    private static ITheme CreateThemeImpl(bool dark) => dark ? new DarkTheme() : new LightTheme();
}