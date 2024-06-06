using Utilities;

namespace Factory.AsyncFactoryMethod;

public class AsyncFactoryMethod() : ConsoleProgram("Asynchronous Factory Method")
{
    public override async Task RunAsync()
    {
        var foo = await Foo.CreateAsync("Sync Data");
        WriteLine(foo);
    }
}