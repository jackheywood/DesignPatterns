using Factory.AsyncFactoryMethod;
using Factory.BulkReplacement;
using Factory.FactoryClass;
using Factory.FactoryMethod;
using Factory.InnerFactory;
using Factory.ObjectTracking;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new FactoryMethod())
    .WithProgram(ConsoleKey.D2, new AsyncFactoryMethod())
    .WithProgram(ConsoleKey.D3, new FactoryClass())
    .WithProgram(ConsoleKey.D4, new ObjectTracking())
    .WithProgram(ConsoleKey.D5, new BulkReplacement())
    .WithProgram(ConsoleKey.D6, new InnerFactory())
    .Build();

await runner.RunAsync();