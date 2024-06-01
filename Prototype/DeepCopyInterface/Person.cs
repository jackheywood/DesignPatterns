namespace Prototype.DeepCopyInterface;

public class Person(string[] names, Address address) : IPrototype<Person>
{
    public Address Address = address;
    public string[] Names = names;

    public Person DeepCopy()
    {
        var names = new string[Names.Length];
        Names.CopyTo(names, 0);
        return new Person(names, Address.DeepCopy());
    }

    public override string ToString() => $"Names: {string.Join(" ", Names)}, Address: {{ {Address} }}";
}