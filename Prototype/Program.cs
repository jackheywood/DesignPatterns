using Prototype.Cloneable;
using Prototype.CopyConstructors;
using Prototype.DeepCopyInterface;
using Prototype.PrototypeExercise;
using Prototype.PrototypeInheritance;
using Prototype.Serialization;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new Cloneable())
    .WithProgram(new CopyConstructors())
    .WithProgram(new DeepCopyInterface())
    .WithProgram(new PrototypeInheritance())
    .WithProgram(new Serialization())
    .WithProgram(new PrototypeExercise())
    .Build();

await runner.RunAsync();