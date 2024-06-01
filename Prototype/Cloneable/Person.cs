namespace Prototype.Cloneable;

public class Person(string[] names, Address address)
    : ICloneable // Problem - don't know if it's deep cloning or shallow cloning
{
    public Address Address = address;
    public string[] Names = names;

    // Gets very messy with casting and deciding whether to shallow or deep copy
    public object Clone() => new Person((string[])Names.Clone(), (Address)Address.Clone());

    public override string ToString() => $"Names: {string.Join(" ", Names)}, Address: {{ {Address} }}";
}