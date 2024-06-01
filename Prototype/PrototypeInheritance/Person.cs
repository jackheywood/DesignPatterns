using Prototype.PrototypeInheritance.Extensions;

namespace Prototype.PrototypeInheritance;

public class Person : IDeepCopyable<Person>
{
    public Address Address;
    public string[] Names;

    public void CopyTo(Person target)
    {
        target.Names = (string[])Names.Clone();
        target.Address = Address.DeepCopy();
    }

    public override string ToString() => $"Names: {string.Join(" ", Names)}, Address: {{ {Address} }}";
}