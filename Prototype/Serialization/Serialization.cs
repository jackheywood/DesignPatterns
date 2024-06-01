using Prototype.Serialization.Extensions;
using Utilities;
using static System.Console;

namespace Prototype.Serialization;

public class Serialization() : ConsoleProgram("Copy Through Serialization")
{
    public override Task RunAsync()
    {
        var arlo = new Person(["Arlo", "Tostevin"], new Address("Aliem Street", 12));

        var piper = arlo.DeepCopyMessagePack();
        piper.Names[0] = "Piper";
        piper.Address.HouseNumber--;
        piper.Address.StreetName = "Woolly Hat Way";

        var mabel = arlo.DeepCopyXml();
        mabel.Names[0] = "Mabel";
        mabel.Names[1] = "Moody";
        mabel.Address.StreetName = "Digging Drive";

        WriteLine(arlo);
        WriteLine(piper);
        WriteLine(mabel);

        return Task.CompletedTask;
    }
}