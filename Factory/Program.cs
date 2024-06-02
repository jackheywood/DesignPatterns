using Factory.AbstractFactory;
using Factory.AsyncFactoryMethod;
using Factory.BulkReplacement;
using Factory.FactoryClass;
using Factory.FactoryExercise;
using Factory.FactoryMethod;
using Factory.InnerFactory;
using Factory.ObjectTracking;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new FactoryMethod())
    .WithProgram(new AsyncFactoryMethod())
    .WithProgram(new FactoryClass())
    .WithProgram(new ObjectTracking())
    .WithProgram(new BulkReplacement())
    .WithProgram(new InnerFactory())
    .WithProgram(new AbstractFactory())
    .WithProgram(new FactoryExercise())
    .Build();

await runner.RunAsync();