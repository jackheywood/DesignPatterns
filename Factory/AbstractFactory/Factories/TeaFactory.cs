namespace Factory.AbstractFactory.Factories;

using static Console;

internal class TeaFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        WriteTeaPreparation(amount);
        return new Tea();
    }

    private static void WriteTeaPreparation(int amount)
    {
        WriteLine("Put in a teabag...");
        WriteLine($"Pour {amount}ml of boiling water...");
        WriteLine("Squeeze...");
        WriteLine("Remove teabag...");
        WriteLine("Add milk...");
        WriteLine("Enjoy!");
    }
}