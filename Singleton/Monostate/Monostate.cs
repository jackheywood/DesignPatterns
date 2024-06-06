using Utilities;

namespace Singleton.Monostate;

public class Monostate() : ConsoleProgram("Monostate")
{
    public override Task RunAsync()
    {
        var chairman = new Chairman
        {
            Name = "Bruce Buck",
            Age = 78,
        };

        var chairman2 = new Chairman
        {
            Name = "Todd Boehly",
            Age = 50,
        };

        WriteLine($"Chairman 1 - {chairman}");
        WriteLine($"Chairman 2 - {chairman2}");

        return Task.CompletedTask;
    }
}