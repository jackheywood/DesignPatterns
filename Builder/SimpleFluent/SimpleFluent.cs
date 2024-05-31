using Builder.SimpleFluent.Builders;
using ConsoleRunner;
using static System.Console;

namespace Builder.SimpleFluent;

public class SimpleFluent : ConsoleProgram
{
    public SimpleFluent()
    {
        Name = "Simple Fluent Builder";
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