using Factory.FactoryMethod;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new FactoryMethod())
    .Build();

runner.Run();