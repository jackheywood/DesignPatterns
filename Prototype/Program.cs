using Prototype.Cloneable;
using Prototype.CopyConstructors;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new Cloneable())
    .WithProgram(ConsoleKey.D2, new CopyConstructors())
    .Build();

await runner.RunAsync();