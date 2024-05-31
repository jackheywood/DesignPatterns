using Utilities;

namespace Factory.AbstractFactory;

public class AbstractFactory() : ConsoleProgram("Abstract Factory")
{
    public override Task RunAsync()
    {
        var machine = new HotDrinkMachine();

        var drink = machine.MakeDrink();
        drink.Consume();

        return Task.CompletedTask;
    }
}