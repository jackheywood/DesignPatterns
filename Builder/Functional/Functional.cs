using Builder.Functional.Builders;
using Builder.Functional.Extensions;
using ConsoleRunner;
using static System.Console;

namespace Builder.Functional;

public class Functional : ConsoleProgram
{
    public Functional()
    {
        Name = "Functional Builder";
    }

    public override void Run()
    {
        var person = new PersonBuilder()
            .Called("Jack")
            .WorksAs("Developer")
            .Build();

        WriteLine(person);
    }
}