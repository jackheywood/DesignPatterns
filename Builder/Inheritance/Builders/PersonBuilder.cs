namespace Builder.Inheritance.Builders;

public abstract class PersonBuilder
{
    protected Person Person = new();

    public Person Build() => Person;
}