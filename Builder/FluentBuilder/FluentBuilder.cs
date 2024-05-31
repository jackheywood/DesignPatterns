using Builder.FluentBuilder.Builders;
using Utilities;
using static System.Console;

namespace Builder.FluentBuilder;

public class FluentBuilder : ConsoleProgram
{
    public FluentBuilder()
    {
        Name = "Fluent Builder";
    }

    public override void Run()
    {
        var builder = new HtmlBuilder("ul");
        builder.AddChild("li", "hello").AddChild("li", "world");
        WriteLine(builder);

        builder.Clear();
        WriteLine(builder);
    }
}