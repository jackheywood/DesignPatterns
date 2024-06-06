using Builder.FluentBuilder.Builders;
using Utilities;

namespace Builder.FluentBuilder;

public class FluentBuilder() : ConsoleProgram("Fluent Builder")
{
    public override Task RunAsync()
    {
        var builder = new HtmlBuilder("ul");
        builder.AddChild("li", "hello").AddChild("li", "world");
        WriteLine(builder);

        builder.Clear();
        WriteLine(builder);

        return Task.CompletedTask;
    }
}