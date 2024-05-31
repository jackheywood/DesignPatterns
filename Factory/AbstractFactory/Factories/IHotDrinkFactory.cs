namespace Factory.AbstractFactory.Factories;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}