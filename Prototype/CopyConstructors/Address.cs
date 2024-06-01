namespace Prototype.CopyConstructors;

public class Address(string streetName, int houseNumber)
{
    public int HouseNumber = houseNumber;
    public string StreetName = streetName;

    public Address(Address other) : this(other.StreetName, other.HouseNumber)
    { }

    public override string ToString() => $"Street Name: {StreetName}, House Number: {HouseNumber}";
}