using Builder.FluentInheritance.Builders;

namespace Builder.FluentInheritance;

public class Person
{
    public string Name;
    public string Position;

    public static Builder New => new();

    public override string ToString() => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";

    public class Builder : PersonJobBuilder<Builder>;
}