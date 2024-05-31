using Factory.BulkReplacement.Factories;
using Utilities;

namespace Factory.BulkReplacement;

public class BulkReplacement() : ConsoleProgram("Bulk Replacement")
{
    public override Task RunAsync()
    {
        var factory = new ReplaceableThemeFactory();

        var magicTheme = factory.CreateTheme(true);
        Console.WriteLine(magicTheme.Value);

        factory.ReplaceTheme(false);
        Console.WriteLine(magicTheme.Value);

        return Task.CompletedTask;
    }
}