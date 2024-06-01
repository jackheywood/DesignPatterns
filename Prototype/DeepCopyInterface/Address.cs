namespace Prototype.DeepCopyInterface;

public class Address(string streetName, int houseNumber) : IPrototype<Address>
{
    public int HouseNumber = houseNumber;
    public string StreetName = streetName;

    public Address DeepCopy() => new(StreetName, HouseNumber);

    public override string ToString() => $"Street Name: {StreetName}, House Number: {HouseNumber}";
}