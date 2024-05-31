namespace Factory.AbstractFactory.Factories;

using static Console;

internal class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        WriteCoffeePreparation(amount);
        return new Coffee();
    }

    private static void WriteCoffeePreparation(int amount)
    {
        WriteLine("Grind some beans...");
        WriteLine("Place in filter...");
        WriteLine($"Pour {amount}ml of boiling water...");
        WriteLine("Wait for coffee to filter through...");
        WriteLine("Add foamed milk...");
        WriteLine("Enjoy!");
    }
}