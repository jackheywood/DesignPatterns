using Utilities;
using static System.Console;

namespace Decorator.AdapterDecorator;

public class AdapterDecorator() : ConsoleProgram("Adapter-Decorator")
{
    public override Task RunAsync()
    {
        // Simple refactoring to solve immutable string problem!
        MyStringBuilder s = "Hello";
        s += " World!";
        WriteLine(s);

        return Task.CompletedTask;
    }
}