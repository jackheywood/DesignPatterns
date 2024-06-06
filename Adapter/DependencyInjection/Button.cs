namespace Adapter.DependencyInjection;

public class Button(ICommand command, string name)
{
    public void Click()
    {
        command.Execute();
    }

    public void Print()
    {
        WriteLine($"I am a button called {name}");
    }
}