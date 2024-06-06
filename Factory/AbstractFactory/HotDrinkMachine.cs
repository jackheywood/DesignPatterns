using Factory.AbstractFactory.Factories;

namespace Factory.AbstractFactory;

public class HotDrinkMachine
{
    private readonly List<(string, IHotDrinkFactory)> _factories = [];

    public HotDrinkMachine()
    {
        foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
            {
                var name = t.Name.Replace("Factory", string.Empty);
                var factory = (IHotDrinkFactory)Activator.CreateInstance(t)!;
                _factories.Add((name, factory));
            }
        }
    }

    public IHotDrink MakeDrink()
    {
        WriteLine("Available drinks:");

        for (var i = 0; i < _factories.Count; i++)
        {
            var factory = _factories[i];
            WriteLine($"{i}: {factory.Item1}");
        }

        while (true)
        {
            if (TryParseDrinkInput(out var i))
            {
                Write("Specify amount: ");
                if (TryParseAmountInput(out var amount))
                {
                    return _factories[i].Item2.Prepare(amount);
                }
            }

            WriteLine("Incorrect input, try again!");
        }
    }

    private bool TryParseDrinkInput(out int index)
    {
        index = -1;
        var input = ReadLine();
        return input != null && int.TryParse(input, out index) && index >= 0 && index < _factories.Count;
    }

    private static bool TryParseAmountInput(out int amount)
    {
        amount = -1;
        var input = ReadLine();
        return input != null && int.TryParse(input, out amount) && amount > 0;
    }
}