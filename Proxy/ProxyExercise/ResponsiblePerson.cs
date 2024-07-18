namespace Proxy.ProxyExercise;

public class ResponsiblePerson(Person person) : IPerson
{
    public int Age
    {
        get => person.Age;
        set => person.Age = value;
    }

    public string Drink()
    {
        return Age < 18 ? "too young" : person.Drink();
    }

    public string Drive()
    {
        return Age < 16 ? "too young" : person.Drive();
    }

    public string DrinkAndDrive()
    {
        return "dead";
    }
}