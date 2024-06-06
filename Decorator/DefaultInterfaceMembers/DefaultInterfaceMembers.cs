using Utilities;

namespace Decorator.DefaultInterfaceMembers;

public class DefaultInterfaceMembers(): ConsoleProgram("Multiple Inheritance with Default Interface Members")
{
    public override Task RunAsync()
    {
        var dragon = new Dragon { Age = 5, Rarity = 3 };
        
        ((ILizard)dragon).Crawl();
        if (dragon is IBird bird) bird.Fly();
        
        return Task.CompletedTask;
    }
}