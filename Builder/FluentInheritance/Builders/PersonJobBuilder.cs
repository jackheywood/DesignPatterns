namespace Builder.FluentInheritance.Builders;

public class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>> where TSelf : PersonJobBuilder<TSelf>
{
    public TSelf WorksAsA(string position)
    {
        Person.Position = position;
        return (TSelf)this;
    }
}