using Utilities;
using static System.Console;

namespace Singleton.AmbientContext;

public class AmbientContext() : ConsoleProgram("Ambient Context")
{
    public override Task RunAsync()
    {
        var house = new Building();

        using (new BuildingContext(2000))
        {
            // Ground floor
            house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
            house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));

            using (new BuildingContext(4000))
            {
                // 1st floor
                house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
            }

            // Ground floor
            house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)));
        }

        WriteLine(house);

        return Task.CompletedTask;
    }
}