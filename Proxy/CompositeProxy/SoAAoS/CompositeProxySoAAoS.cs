using Utilities;

namespace Proxy.CompositeProxy.SoAAoS;

public class CompositeProxySoAAoS() : ConsoleProgram("Composite Proxy: SoA/AoS")
{
    public override Task RunAsync()
    {
        const int size = 100;

        RunBasicCreatures(size);
        RunProxyCreatures(size);

        return Task.CompletedTask;
    }

    private static void RunBasicCreatures(int size)
    {
        // AoS
        // Basic data layout:
        // Age X Y Age X Y Age X Y Age X Y

        var creatures = new Creature[size];
        PopulateCreatures(creatures);
        foreach (var c in creatures) c.X++;
    }

    private static void RunProxyCreatures(int size)
    {
        // SoA
        // Preferred layout for CPU:
        // Age Age Age Age X X X X Y Y Y Y

        var creatures = new Creatures(size);
        foreach (var c in creatures) c.X++;
    }

    private static void PopulateCreatures(Creature[] creatures)
    {
        var random = new Random();
        for (var i = 0; i < creatures.Length; i++)
        {
            var bytes = new byte[1];
            random.NextBytes(bytes);

            creatures[i] = new Creature
            {
                Age = bytes[0],
                X = random.Next(),
                Y = random.Next(),
            };
        }
    }
}