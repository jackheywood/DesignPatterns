using Factory.FactoryExercise.Factories;
using Utilities;
using static System.Console;

namespace Factory.FactoryExercise;

public class FactoryExercise() : ConsoleProgram("Factory Coding Exercise")
{
    public override Task RunAsync()
    {
        var factory = new PersonFactory();

        var person1 = factory.CreatePerson("Jack");
        var person2 = factory.CreatePerson("Danni");

        WriteLine(person1);
        WriteLine(person2);

        return Task.CompletedTask;
    }
}