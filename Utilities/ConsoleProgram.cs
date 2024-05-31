namespace Utilities;

public abstract class ConsoleProgram(string name)
{
    public string Name = name;
    public abstract Task RunAsync();
}