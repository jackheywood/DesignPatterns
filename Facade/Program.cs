using Facade.FacadeExercise;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new FacadeExercise())
    .Build();

await runner.RunAsync();