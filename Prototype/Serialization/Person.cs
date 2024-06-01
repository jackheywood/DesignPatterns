namespace Prototype.Serialization;

public class Person
{
    public Address Address;
    public string[] Names;

    // Default needed for XML serialization
    public Person()
    { }

    public Person(string[] names, Address address)
    {
        Address = address;
        Names = names;
    }

    public override string ToString() => $"Names: {string.Join(" ", Names)}, Address: {{ {Address} }}";
}