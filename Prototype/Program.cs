using Prototype.Cloneable;
using Prototype.CopyConstructors;
using Prototype.DeepCopyInterface;
using Prototype.PrototypeInheritance;
using Prototype.Serialization;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new Cloneable())
    .WithProgram(ConsoleKey.D2, new CopyConstructors())
    .WithProgram(ConsoleKey.D3, new DeepCopyInterface())
    .WithProgram(ConsoleKey.D4, new PrototypeInheritance())
    .WithProgram(ConsoleKey.D5, new Serialization())
    .Build();

await runner.RunAsync();