namespace Builder.Functional;

public class Person
{
    public string Name;
    public string Position;

    public override string ToString() => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
}