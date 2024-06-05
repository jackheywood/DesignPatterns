using Utilities;

namespace Decorator.MultipleInheritanceInterfaces;

public class MultipleInheritance() : ConsoleProgram("Multiple Inheritance with Interfaces")
{
    public override Task RunAsync()
    {
        var bird = new Bird { Weight = 15 };
        var lizard = new Lizard { Weight = 7 };
        var dragon = new Dragon { Weight = 375 };

        List<IBird> birds = [bird, dragon];
        List<ILizard> lizards = [lizard, dragon];

        foreach (var b in birds) b.Fly();
        foreach (var l in lizards) l.Crawl();

        return Task.CompletedTask;
    }
}