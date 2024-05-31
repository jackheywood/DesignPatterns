namespace Builder.FacetedBuilder.Builders;

// Facade
public class PersonBuilder
{
    // Reference!
    protected Person Person = new();

    public PersonJobBuilder Works => new(Person);
    public PersonAddressBuilder Lives => new(Person);

    // Could use a Build() method instead
    public static implicit operator Person(PersonBuilder pb) => pb.Person;
}