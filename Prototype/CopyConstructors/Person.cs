namespace Prototype.CopyConstructors;

public class Person
{
    public Address Address;
    public string[] Names;

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    // More of a C++ option
    public Person(Person other)
    {
        Names = new string[other.Names.Length];
        other.Names.CopyTo(Names, 0);
        Address = new Address(other.Address);
    }

    public override string ToString() => $"Names: {string.Join(" ", Names)}, Address: {{ {Address} }}";
}