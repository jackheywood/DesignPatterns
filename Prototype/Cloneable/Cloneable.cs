using Utilities;
using static System.Console;

namespace Prototype.Cloneable;

public class Cloneable() : ConsoleProgram("ICloneable (Bad)")
{
    public override Task RunAsync()
    {
        var jane = new Person(["Jane", "Smith"], new Address("Kentish Town Road", 123));

        var john = (Person)jane.Clone();
        
        john.Names[0] = "John";
        john.Address.HouseNumber = 321;

        WriteLine(jane);
        WriteLine(john);

        return Task.CompletedTask;
    }
}