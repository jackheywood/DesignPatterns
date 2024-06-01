namespace Prototype.Cloneable;

public class Address(string streetName, int houseNumber) : ICloneable
{
    public int HouseNumber = houseNumber;
    public string StreetName = streetName;

    public object Clone() => new Address(StreetName, HouseNumber);

    public override string ToString() => $"Street Name: {StreetName}, House Number: {HouseNumber}";
}