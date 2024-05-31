using Factory.AsyncFactoryMethod;
using Factory.FactoryMethod;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new FactoryMethod())
    .WithProgram(ConsoleKey.D2, new AsyncFactoryMethod())
    .Build();

await runner.RunAsync();