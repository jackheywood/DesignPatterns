namespace Proxy.ProxyExercise;

public interface IPerson
{
    int Age { get; set; }
    string Drink();
    string Drive();
    string DrinkAndDrive();
}