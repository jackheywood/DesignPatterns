namespace Prototype.Serialization;

public class Address
{
    public int HouseNumber;
    public string StreetName;

    // Default needed for XML serialization
    public Address()
    { }

    public Address(string streetName, int houseNumber)
    {
        HouseNumber = houseNumber;
        StreetName = streetName;
    }

    public override string ToString() => $"Street Name: {StreetName}, House Number: {HouseNumber}";
}