using static System.Console;

namespace Adapter.DependencyInjection;

public interface ICommand
{
    void Execute();
}

public class SaveCommand : ICommand
{
    public void Execute() => WriteLine("Saving a file");
}

public class OpenCommand : ICommand
{
    public void Execute() => WriteLine("Opening a file");
}