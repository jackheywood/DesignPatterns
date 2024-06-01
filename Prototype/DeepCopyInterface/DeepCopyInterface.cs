using Utilities;
using static System.Console;

namespace Prototype.DeepCopyInterface;

public class DeepCopyInterface() : ConsoleProgram("Deep Copy Interface")
{
    public override Task RunAsync()
    {
        var will = new Person(["William", "Heywood"], new Address("Brighton Road", 66));

        var jack = will.DeepCopy();

        jack.Names[0] = "Jack";
        jack.Address.StreetName = "London Street";
        
        WriteLine(will);
        WriteLine(jack);

        return Task.CompletedTask;
    }
}