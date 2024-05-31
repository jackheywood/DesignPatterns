using Builder.SimpleFluent.Builders;
using static System.Console;

namespace Builder.SimpleFluent;

public static class SimpleFluent
{
    public static void Run()
    {
        var builder = new HtmlBuilder("ul");
        builder.AddChild("li", "hello").AddChild("li", "world");
        WriteLine(builder);

        builder.Clear();
        WriteLine(builder);
    }
}