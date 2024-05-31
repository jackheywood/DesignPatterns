using Builder.BuilderExercise;
using Builder.FacetedBuilder;
using Builder.FluentBuilder;
using Builder.FunctionalBuilder;
using Builder.Inheritance;
using Builder.StepwiseBuilder;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new FluentBuilder())
    .WithProgram(ConsoleKey.D2, new Inheritance())
    .WithProgram(ConsoleKey.D3, new StepwiseBuilder())
    .WithProgram(ConsoleKey.D4, new FunctionalBuilder())
    .WithProgram(ConsoleKey.D5, new FacetedBuilder())
    .WithProgram(ConsoleKey.D6, new BuilderExercise())
    .Build();

await runner.RunAsync();