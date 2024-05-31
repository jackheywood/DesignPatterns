namespace Factory.FactoryExercise;

public class Person
{
    public int Id { get; init; }
    public string Name { get; init; }

    public override string ToString() => $"Id: {Id}, Name: {Name}";
}