using Utilities;
using static System.Console;

namespace Prototype.CopyConstructors;

public class CopyConstructors() : ConsoleProgram("Copy Constructors (Better)")
{
    public override Task RunAsync()
    {
        var bob = new Person(["Bob", "Jones"], new Address("Manchester Road", 26));

        var alice = new Person(bob);
        
        alice.Names[0] = "Alice";
        alice.Address.HouseNumber = 77;
        alice.Address.StreetName = "Liverpool Street";

        WriteLine(bob);
        WriteLine(alice);

        return Task.CompletedTask;
    }
}