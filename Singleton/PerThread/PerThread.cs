using Utilities;
using static System.Console;

namespace Singleton.PerThread;

public class PerThread() : ConsoleProgram("Per-Thread Singleton")
{
    public override async Task RunAsync()
    {
        var task1 = Task.Factory.StartNew(() =>
        {
            WriteLine($"Thread 1.0: {PerThreadSingleton.Instance.Id}");
            WriteLine($"Thread 1.1: {PerThreadSingleton.Instance.Id}");
        });

        var task2 = Task.Factory.StartNew(() =>
        {
            WriteLine($"Thread 2.0: {PerThreadSingleton.Instance.Id}");
            WriteLine($"Thread 2.1: {PerThreadSingleton.Instance.Id}");
        });

        await Task.WhenAll(task1, task2);
    }
}