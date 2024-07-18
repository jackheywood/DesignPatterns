using Utilities;

namespace Proxy.ProxyExercise;

public class ProxyExercise() : ConsoleProgram("Proxy Exercise")
{
    public override Task RunAsync()
    {
        var child = new ResponsiblePerson(new Person()) { Age = 8 };
        var teen = new ResponsiblePerson(new Person()) { Age = 17 };
        var adult = new ResponsiblePerson(new Person()) { Age = 27 };

        List<IPerson> responsiblePeople = [child, teen, adult];

        foreach (var person in responsiblePeople)
        {
            WriteLine($"Age: {person.Age}");
            WriteLine($"Drinking: {person.Drink()}");
            WriteLine($"Driving: {person.Drive()}");
            WriteLine($"Drink-Driving: {person.DrinkAndDrive()}");
            WriteLine();
        }

        return Task.CompletedTask;
    }
}