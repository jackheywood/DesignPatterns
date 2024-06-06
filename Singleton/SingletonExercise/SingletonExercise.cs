using Utilities;

namespace Singleton.SingletonExercise;

public class SingletonExercise() : ConsoleProgram("Singleton Exercise")
{
    public override Task RunAsync()
    {
        var singleton = new object();
        var singletonIsSingleton = SingletonTester.IsSingleton(() => singleton);
        var newObjectIsSingleton = SingletonTester.IsSingleton(() => new object());

        WriteLine($"Singleton is Singleton: {singletonIsSingleton}");
        WriteLine($"New Object is Singleton: {newObjectIsSingleton}");

        return Task.CompletedTask;
    }
}