using Factory.AsyncFactoryMethod;
using Factory.FactoryClass;
using Factory.FactoryMethod;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new FactoryMethod())
    .WithProgram(ConsoleKey.D2, new AsyncFactoryMethod())
    .WithProgram(ConsoleKey.D3, new FactoryClass())
    .Build();

await runner.RunAsync();