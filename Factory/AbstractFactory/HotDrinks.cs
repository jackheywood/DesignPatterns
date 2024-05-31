namespace Factory.AbstractFactory;

using static Console;

public interface IHotDrink
{
    void Consume();
}

internal class Tea : IHotDrink
{
    public void Consume()
    {
        WriteLine("What a lovely cup of tea!");
    }
}

internal class Coffee : IHotDrink
{
    public void Consume()
    {
        WriteLine("Mmmmm coffee...");
    }
}