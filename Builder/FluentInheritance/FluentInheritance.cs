using ConsoleRunner;

namespace Builder.FluentInheritance;

using static Console;

public class FluentInheritance : ConsoleProgram
{
    public FluentInheritance()
    {
        Name = "Fluent Builder Inheritance";
    }

    public override void Run()
    {
        var me = Person.New
            .Called("Jack")
            .WorksAsA("Developer")
            .Build();

        WriteLine(me);
    }
}