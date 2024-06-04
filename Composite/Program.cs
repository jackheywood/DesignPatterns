using Composite.GeometricShapes;
using Composite.NeuralNetworks;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new GeometricShapes())
    .WithProgram(new NeuralNetworks())
    .Build();

await runner.RunAsync();