using Utilities;

namespace Flyweight.TextFormatting;

public class TextFormatting() : ConsoleProgram("Text Formatting")
{
    public override Task RunAsync()
    {
        var ft = new FormattedText("This is a brave new world");
        ft.Capitalize(10, 15);
        WriteLine(ft);

        var bft = new BetterFormattedText("This is a brave new world");
        bft.GetRange(20, 24).Capitalize = true;
        WriteLine(bft);

        return Task.CompletedTask;
    }
}