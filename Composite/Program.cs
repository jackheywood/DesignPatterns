using Composite.CompositeSpecification;
using Composite.GeometricShapes;
using Composite.NeuralNetworks;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new GeometricShapes())
    .WithProgram(new NeuralNetworks())
    .WithProgram(new CompositeSpecification())
    .Build();

await runner.RunAsync();