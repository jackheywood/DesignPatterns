using Composite.GeometricShapes;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new GeometricShapes())
    .Build();

await runner.RunAsync();