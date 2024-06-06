using Prototype.PrototypeInheritance.Extensions;
using Utilities;

namespace Prototype.PrototypeInheritance;

public class PrototypeInheritance() : ConsoleProgram("Prototype Inheritance")
{
    public override Task RunAsync()
    {
        var john = new Employee
        {
            Names = ["John", "Doe"],
            Address = new Address
            {
                HouseNumber = 987,
                StreetName = "Candie Road",
            },
            Salary = 50000,
        };

        var sally = john.DeepCopy();
        sally.Names[0] = "Sally";
        sally.Salary = 54000;
        sally.Address.HouseNumber++;

        WriteLine(john);
        WriteLine(sally);

        return Task.CompletedTask;
    }
}