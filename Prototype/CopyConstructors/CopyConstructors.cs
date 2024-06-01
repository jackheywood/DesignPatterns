using Utilities;
using static System.Console;

namespace Prototype.CopyConstructors;

public class CopyConstructors() : ConsoleProgram("Copy Constructors (Better)")
{
    public override Task RunAsync()
    {
        var jane = new Person(["Jane", "Smith"], new Address("Kentish Town Road", 123));

        var john = new Person(jane);
        
        john.Names[0] = "John";
        john.Address.HouseNumber = 321;
        john.Address.StreetName = "Holloway Road";

        WriteLine(jane);
        WriteLine(john);

        return Task.CompletedTask;
    }
}