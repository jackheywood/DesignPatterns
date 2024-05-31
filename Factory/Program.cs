using Factory.AsyncFactoryMethod;
using Factory.FactoryClass;
using Factory.FactoryMethod;
using Factory.ObjectTracking;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new FactoryMethod())
    .WithProgram(ConsoleKey.D2, new AsyncFactoryMethod())
    .WithProgram(ConsoleKey.D3, new FactoryClass())
    .WithProgram(ConsoleKey.D4, new ObjectTracking())
    .Build();

await runner.RunAsync();