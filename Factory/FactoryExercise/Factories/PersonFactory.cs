namespace Factory.FactoryExercise.Factories;

public class PersonFactory
{
    private int _index;

    public Person CreatePerson(string name) =>
        new()
        {
            Id = _index++,
            Name = name,
        };
}