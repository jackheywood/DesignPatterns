using Utilities;

namespace Decorator.CustomStringBuilder;

public class CustomStringBuilder() : ConsoleProgram("Custom String Builder")
{
    public override Task RunAsync()
    {
        var cb = new CodeBuilder();
        cb.AppendLine("class Foo")
            .AppendLine("{")
            .AppendLine("}");

        WriteLine(cb);

        return Task.CompletedTask;
    }
}