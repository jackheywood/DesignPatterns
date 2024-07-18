namespace Proxy.ProtectionProxy;

public class CarProxy(Driver driver) : ICar
{
    private readonly Car _car = new();

    public void Drive()
    {
        WriteLine($"Driver is {driver.Age} years old");
        if (driver.Age >= 16) _car.Drive();
        else WriteLine("Too young to drive");
    }
}