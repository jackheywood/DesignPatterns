using JetBrains.dotMemoryUnit;
using Xunit;
using Xunit.Abstractions;

// ReSharper disable Xunit.XunitTestWithConsoleOutput
namespace Flyweight.RepeatedUserNames;

public class MemoryTests
{
    private readonly ITestOutputHelper _output;

    public MemoryTests(ITestOutputHelper output)
    {
        _output = output;
        DotMemoryUnitTestOutput.SetOutputMethod(output.WriteLine);
    }

    [Fact]
    public void TestUserMemory() // 8,174,500 bytes
    {
        var names = Enumerable.Range(0, 100).Select(_ => RandomString()).ToArray();

        var users = (
                from firstName in names
                from lastName in names
                select new User($"{firstName} {lastName}")
            )
            .ToList();

        ForceGarbageCollection();

        dotMemory.Check(memory => { _output.WriteLine($"No facade memory used: {memory.SizeInBytes} bytes"); });
    }

    [Fact]
    public void TestUser2Memory() // 7,658,913 bytes
    {
        var names = Enumerable.Range(0, 100).Select(_ => RandomString()).ToArray();

        var users = (
                from firstName in names
                from lastName in names
                select new User2($"{firstName} {lastName}")
            )
            .ToList();

        ForceGarbageCollection();

        dotMemory.Check(memory => { _output.WriteLine($"Facade memory used: {memory.SizeInBytes} bytes"); });
    }

    private static void ForceGarbageCollection()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }

    private static string RandomString()
    {
        var rand = new Random();
        return new string(
            Enumerable.Range(0, 10)
                .Select(_ => (char)('a' + rand.Next(26)))
                .ToArray());
    }
}