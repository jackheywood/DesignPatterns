namespace Prototype.PrototypeInheritance;

public class Address : IDeepCopyable<Address>
{
    public int HouseNumber;
    public string StreetName;
    
    public void CopyTo(Address target)
    {
        target.StreetName = StreetName;
        target.HouseNumber = HouseNumber;
    }

    public override string ToString() => $"Street Name: {StreetName}, House Number: {HouseNumber}";
}